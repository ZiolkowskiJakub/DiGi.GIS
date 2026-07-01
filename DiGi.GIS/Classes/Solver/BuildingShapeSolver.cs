using DiGi.Core.Constants;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides functionality to solve and determine the geometric shape of a building based on its 2D representation.
    /// </summary>
    public class BuildingShapeSolver : IOneToOneSolver<Building2D, BuildingShape>
    {
        private readonly double microTolerance = Tolerance.Distance;
        private readonly double macroTolerance = Tolerance.MacroDistance;
        private readonly double offset = 1.0;
        private readonly double thinnessRatio = 0.9;

        private Building2D? input = null;
        private BuildingShape output = BuildingShape.Undefined;

        private readonly double areaFactor = 0.5;
        private readonly double aspectRatioFactor = 0.3;
        private readonly double rectangleThinnessRatioFactor = 0.2;

        private readonly double scoreFactor = 0.7;

        //private double minRectangleThinnessRatio = 0.5;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingShapeSolver"/> class.
        /// </summary>
        /// <param name="offset">The offset value used during geometry calculations. Must be greater than zero.</param>
        /// <param name="thinnessRatio">The ratio threshold used to determine thinness and shape classification. Must be within the range (0, 1].</param>
        /// <param name="microTolerance">The micro-level distance tolerance for geometric operations. Must be greater than zero.</param>
        /// <param name="macroTolerance">The macro-level distance tolerance for geometric operations. Must be greater than zero.</param>
        /// <param name="areaFactor">The weight applied to a candidate notch's normalized area when scoring notch significance. Must be finite and non-negative.</param>
        /// <param name="aspectRatioFactor">The weight applied to a candidate notch's aspect ratio when scoring notch significance. Must be finite and non-negative.</param>
        /// <param name="rectangleThinnessRatioFactor">The weight applied to a candidate notch's rectangular thinness ratio when scoring notch significance. Must be finite and non-negative.</param>
        /// <param name="scoreFactor">The fraction of the highest notch score used as the cut-off for retaining notches. Must be within the range (0, 1].</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when any argument falls outside its permitted range.</exception>
        public BuildingShapeSolver(double offset = 1, double thinnessRatio = 0.9, double microTolerance = Tolerance.Distance, double macroTolerance = Tolerance.MacroDistance, double areaFactor = 0.5, double aspectRatioFactor = 0.3, double rectangleThinnessRatioFactor = 0.2, double scoreFactor = 0.7)
        {
            if (double.IsNaN(offset) || offset <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(offset), offset, "The offset must be greater than zero.");
            }

            if (double.IsNaN(thinnessRatio) || thinnessRatio <= 0 || thinnessRatio > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(thinnessRatio), thinnessRatio, "The thinness ratio must be within the range (0, 1].");
            }

            if (double.IsNaN(microTolerance) || microTolerance <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(microTolerance), microTolerance, "The micro tolerance must be greater than zero.");
            }

            if (double.IsNaN(macroTolerance) || macroTolerance <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(macroTolerance), macroTolerance, "The macro tolerance must be greater than zero.");
            }

            if (double.IsNaN(areaFactor) || areaFactor < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(areaFactor), areaFactor, "The area factor must be finite and non-negative.");
            }

            if (double.IsNaN(aspectRatioFactor) || aspectRatioFactor < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(aspectRatioFactor), aspectRatioFactor, "The aspect ratio factor must be finite and non-negative.");
            }

            if (double.IsNaN(rectangleThinnessRatioFactor) || rectangleThinnessRatioFactor < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rectangleThinnessRatioFactor), rectangleThinnessRatioFactor, "The rectangle thinness ratio factor must be finite and non-negative.");
            }

            if (areaFactor + aspectRatioFactor + rectangleThinnessRatioFactor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(areaFactor), "At least one of the notch scoring factors must be greater than zero.");
            }

            if (double.IsNaN(scoreFactor) || scoreFactor <= 0 || scoreFactor > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(scoreFactor), scoreFactor, "The score factor must be within the range (0, 1].");
            }

            this.offset = offset;
            this.thinnessRatio = thinnessRatio;
            this.microTolerance = microTolerance;
            this.macroTolerance = macroTolerance;
            this.areaFactor = areaFactor;
            this.aspectRatioFactor = aspectRatioFactor;
            this.rectangleThinnessRatioFactor = rectangleThinnessRatioFactor;
            this.scoreFactor = scoreFactor;
        }

        /// <summary>
        /// Gets or sets the input building geometry to be analyzed.
        /// </summary>
        public Building2D? Input
        {
            set
            {
                input = value;
            }
        }

        /// <summary>
        /// Gets the determined shape of the building after solving.
        /// </summary>
        public BuildingShape Output
        {
            get
            {
                return output;
            }
        }

        /// <summary>
        /// Analyzes the input building geometry and determines its corresponding <see cref="BuildingShape"/>.
        /// </summary>
        /// <returns>True if a shape was successfully determined; otherwise, false.</returns>
        public bool Solve()
        {
            output = BuildingShape.Undefined;

            if (input?.PolygonalFace2D?.ExternalEdge is not IPolygonal2D externalEdge)
            {
                return false;
            }

            List<IPolygonal2D>? internalEdges = input?.PolygonalFace2D?.InternalEdges;
            bool hasHoles = internalEdges is not null && internalEdges.Count != 0;

            double area = externalEdge.GetArea();
            if (area <= microTolerance)
            {
                return false;
            }

            if (Geometry.Planar.Create.Rectangle2D(externalEdge, microTolerance) is not Rectangle2D rectangle2D)
            {
                return false;
            }

            double perimeter = externalEdge.GetPerimeter();

            double isoperimetricRatio = Geometry.Core.Query.IsoperimetricRatio(area, perimeter);

            if (isoperimetricRatio >= thinnessRatio)
            {
                output = BuildingShape.Circural;
                return true;
            }

            double rectangleArea = rectangle2D.GetArea();

            double rectangleThinnesRatio = Geometry.Core.Query.RectangularThinnessRatio(area, rectangleArea);

            double length = Math.Max(rectangle2D.Width, rectangle2D.Height);

            double squareThinnesRatio = Geometry.Core.Query.SquareThinnessRatio(area, length * length);

            if (internalEdges is null || internalEdges.Count == 0)
            {
                if (squareThinnesRatio >= thinnessRatio)
                {
                    output = BuildingShape.Square;
                    return true;
                }

                if (rectangleThinnesRatio >= thinnessRatio)
                {
                    output = BuildingShape.Rectangular;
                    return true;
                }
            }

            List<IPolygonal2D>? polygonal2Ds = Geometry.Planar.Query.Difference(rectangle2D.Offset(-macroTolerance), externalEdge);
            if (polygonal2Ds is not null)
            {
                for (int i = polygonal2Ds.Count - 1; i >= 0; i--)
                {
                    if (Geometry.Planar.Query.SelfIntersectionPolygons(polygonal2Ds[i], offset, macroTolerance) is not List<Polygon2D> polygon2Ds || polygon2Ds.Count == 0)
                    {
                        continue;
                    }

                    polygonal2Ds.RemoveAt(i);

                    for (int j = polygon2Ds.Count - 1; j >= 0; j--)
                    {
                        polygonal2Ds.Add(polygon2Ds[j]);
                    }
                }

                List<Tuple<double, IPolygonal2D>> tuples_Polygonal2D = [];
                for (int i = polygonal2Ds.Count - 1; i >= 0; i--)
                {
                    double area_Temp = polygonal2Ds[i].GetArea();
                    if (area_Temp < macroTolerance)
                    {
                        polygonal2Ds.RemoveAt(i);
                        continue;
                    }

                    tuples_Polygonal2D.Add(new Tuple<double, IPolygonal2D>(area_Temp, polygonal2Ds[i]));
                }

                if (tuples_Polygonal2D.Count != 0)
                {
                    double maxArea = tuples_Polygonal2D.Max(x => x.Item1);

                    for (int i = tuples_Polygonal2D.Count - 1; i >= 0; i--)
                    {
                        IPolygonal2D polygonal2D = tuples_Polygonal2D[i].Item2;

                        Rectangle2D? rectangle2D_Temp = Geometry.Planar.Create.Rectangle2D(polygonal2D, microTolerance);
                        if (rectangle2D_Temp is null)
                        {
                            tuples_Polygonal2D.RemoveAt(i);
                            continue;
                        }

                        double aspectRatio = Geometry.Planar.Query.AspectRatio(rectangle2D_Temp);
                        if (aspectRatio < 1 - thinnessRatio)
                        {
                            tuples_Polygonal2D.RemoveAt(i);
                            continue;
                        }

                        double rectangleThinnesRatio_Temp = polygonal2D.RectangularThinnessRatio(microTolerance);
                        if (rectangleThinnesRatio_Temp < 1 - thinnessRatio)
                        {
                            tuples_Polygonal2D.RemoveAt(i);
                            continue;
                        }

                        tuples_Polygonal2D[i] = new Tuple<double, IPolygonal2D>(areaFactor * (tuples_Polygonal2D[i].Item1 / maxArea) + aspectRatioFactor * aspectRatio + rectangleThinnessRatioFactor * rectangleThinnesRatio_Temp, polygonal2D);
                    }

                    if (tuples_Polygonal2D.Count != 0)
                    {
                        double minScore = tuples_Polygonal2D.Max(x => x.Item1) * scoreFactor;

                        polygonal2Ds = tuples_Polygonal2D.FindAll(x => x.Item1 >= minScore).ConvertAll(x => x.Item2);
                    }
                }
            }

            if (polygonal2Ds is null || polygonal2Ds.Count == 0)
            {
                output = FallbackShape(hasHoles, squareThinnesRatio, rectangleThinnesRatio);
                return true;
            }

            Rectangle2D? rectangle2D_Offset = rectangle2D.Offset(-offset);
            if (rectangle2D_Offset is null)
            {
                output = BuildingShape.Undefined;
                return false;
            }

            double minArea = rectangle2D_Offset.GetArea() / 18;//9 * Math.Max(rectangleThinnesRatio, minRectangleThinnessRatio);

            for (int i = polygonal2Ds.Count - 1; i >= 0; i--)
            {
                if (polygonal2Ds[i].GetArea() < minArea)
                {
                    polygonal2Ds.RemoveAt(i);
                    continue;
                }
            }

            if (polygonal2Ds.Count == 0)
            {
                output = FallbackShape(hasHoles, squareThinnesRatio, rectangleThinnesRatio);
                return true;
            }

            if (rectangle2D_Offset.GetSegments() is not List<Segment2D> segment2Ds)
            {
                output = BuildingShape.Undefined;
                return false;
            }

            List<Tuple<int, Segment2D>> tuples = [];
            for (int i = 0; i < segment2Ds.Count; i++)
            {
                tuples.Add(new Tuple<int, Segment2D>(i, segment2Ds[i]));
            }

            if (polygonal2Ds.Count > 1)
            {
                polygonal2Ds = Geometry.Planar.Query.Union(polygonal2Ds)?.ConvertAll(x => (IPolygonal2D)x);
            }

            if (polygonal2Ds is null)
            {
                output = BuildingShape.Undefined;
                return false;
            }

            Dictionary<int, HashSet<int>> dictionary = [];
            for (int i = 0; i < polygonal2Ds.Count; i++)
            {
                IPolygonal2D polygonal2D = polygonal2Ds[i];
                foreach (Tuple<int, Segment2D> tuple in tuples)
                {
                    if (tuple.Item2.Intersect(polygonal2D, microTolerance))
                    {
                        if (!dictionary.TryGetValue(tuple.Item1, out HashSet<int> polygonal2Ds_Index))
                        {
                            polygonal2Ds_Index = [];
                            dictionary[tuple.Item1] = polygonal2Ds_Index;
                        }

                        if (polygonal2Ds_Index.Count > 1)
                        {
                            output = BuildingShape.Other;
                            return true;
                        }

                        polygonal2Ds_Index.Add(i);
                    }
                }
            }

            if (dictionary.Count == 0)
            {
                output = BuildingShape.O;
                return true;
            }

            if (dictionary.Count == 1)
            {
                int count = dictionary.Values.First().Count;

                switch (count)
                {
                    case 1:
                        output = BuildingShape.U;
                        return true;

                    case 2:
                        output = BuildingShape.E;
                        return true;
                }

                output = BuildingShape.Other;
                return true;
            }

            List<int> counts = [];
            foreach (HashSet<int> polygonal2Ds_Index in dictionary.Values)
            {
                counts.Add(polygonal2Ds_Index.Count);
            }

            if (dictionary.Count == 2)
            {
                // The two touched segments sit on opposite sides of the bounding rectangle when their
                // indices differ by 2 (segments are ordered 0-1-2-3, so pairs {0,2} and {1,3} are opposite).
                // Use Min/Max rather than First/Last because dictionary key order follows insertion, not value,
                // so a raw Last()-First() subtraction can be negative and miss the opposite-side case.
                bool oppositeSides = dictionary.Keys.Max() - dictionary.Keys.Min() == 2;

                if (counts.Contains(2))
                {
                    if (!counts.Contains(1))
                    {
                        output = BuildingShape.Other;
                        return true;
                    }

                    output = oppositeSides ? BuildingShape.Other : BuildingShape.F;
                    return true;
                }

                output = oppositeSides ? BuildingShape.H : BuildingShape.L;
                return true;
            }

            if (dictionary.Count == 3)
            {
                if (counts.Count(x => x == 2) == 1)
                {
                    output = BuildingShape.T;
                    return true;
                }

                output = BuildingShape.Other;
                return true;
            }

            if (dictionary.Count == 4)
            {
                if (counts.TrueForAll(x => x == 1) || counts.TrueForAll(x => x == 2))
                {
                    output = BuildingShape.X;
                    return true;
                }
            }

            output = BuildingShape.Other;
            return true;
        }

        /// <summary>
        /// Resolves the shape for a footprint whose external edge fills its bounding rectangle and produced no significant notches.
        /// </summary>
        /// <param name="hasHoles">Indicates whether the footprint encloses one or more internal edges (courtyards).</param>
        /// <param name="squareThinnessRatio">The square thinness ratio of the external edge.</param>
        /// <param name="rectangleThinnessRatio">The rectangular thinness ratio of the external edge.</param>
        /// <returns>The resolved <see cref="BuildingShape"/>.</returns>
        private BuildingShape FallbackShape(bool hasHoles, double squareThinnessRatio, double rectangleThinnessRatio)
        {
            bool boxLike = squareThinnessRatio >= thinnessRatio || rectangleThinnessRatio >= thinnessRatio;

            // A box-filling footprint that also encloses a courtyard (hole) is a ring, i.e. an O-shape;
            // the same footprint without a hole is a plain Square or Rectangular.
            if (boxLike && hasHoles)
            {
                return BuildingShape.O;
            }

            if (squareThinnessRatio >= thinnessRatio)
            {
                return BuildingShape.Square;
            }

            if (rectangleThinnessRatio >= thinnessRatio)
            {
                return BuildingShape.Rectangular;
            }

            return BuildingShape.Other;
        }
    }
}