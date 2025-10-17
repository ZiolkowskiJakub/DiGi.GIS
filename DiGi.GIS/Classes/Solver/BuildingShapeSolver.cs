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
    public class BuildingShapeSolver : IOneToOneSolver<Building2D, BuildingShape>
    {
        private double tolerance = Core.Constans.Tolerance.Distance;
        private double offset = 1.0;
        private double thinnessRatio = 0.9;

        private Building2D? input = null;
        private BuildingShape output = BuildingShape.Undefined;


        public BuildingShapeSolver(double offset = 1, double thinnessRatio = 0.9, double tolerance = Core.Constans.Tolerance.Distance)
        {
            this.offset = offset;
            this.thinnessRatio = thinnessRatio;
            this.tolerance = tolerance;
        }

        public Building2D? Input
        {
            set
            {
                input = value;
            }
        }

        public BuildingShape Output
        {
            get
            {
                return output;
            }
        }

        public bool Solve()
        {
            output = BuildingShape.Undefined;

            if(input?.PolygonalFace2D?.ExternalEdge is not IPolygonal2D externalEdge)
            {
                return false;
            }

            List<IPolygonal2D>? internalEdges = input?.PolygonalFace2D?.InternalEdges;

            double area = externalEdge.GetArea();
            if(area <= tolerance)
            {
                return false;
            }

            if (Geometry.Planar.Create.Rectangle2D(externalEdge, tolerance) is not Rectangle2D rectangle2D)
            {
                return false;
            }

            double perimeter = externalEdge.GetPerimeter();

            double isoperimetricRatio = Geometry.Core.Query.IsoperimetricRatio(area, perimeter);

            if(isoperimetricRatio >= thinnessRatio)
            {
                output = BuildingShape.Circural;
                return true;
            }

            double rectangleArea = rectangle2D.GetArea();

            double rectangleThinnesRatio = Geometry.Core.Query.RectangularThinnessRatio(area, rectangleArea);

            double length = System.Math.Max(rectangle2D.Width, rectangle2D.Height);

            double squareThinnesRatio = Geometry.Core.Query.SquareThinnessRatio(area, length * length);

            if(internalEdges is null || internalEdges.Count == 0)
            {
                if(squareThinnesRatio >= thinnessRatio)
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

            Polygonal2DSelfIntersectionSolver polygonal2DSelfIntersectionSolver = new Polygonal2DSelfIntersectionSolver(offset, tolerance);

            List<IPolygonal2D>? polygonal2Ds = Geometry.Planar.Query.Difference(rectangle2D, externalEdge);
            if(polygonal2Ds is not null)
            {
                for (int i = polygonal2Ds.Count - 1; i >= 0; i--)
                {
                    if (polygonal2Ds[i].RectangularThinnessRatio(tolerance) < 1 - thinnessRatio)
                    {
                        polygonal2Ds.RemoveAt(i);
                        continue;
                    }

                    polygonal2DSelfIntersectionSolver.Input = polygonal2Ds[i];
                    if (polygonal2DSelfIntersectionSolver.Solve())
                    {
                        if (polygonal2DSelfIntersectionSolver.Output is IPolygonal2D polygonal2D_Output)

                            polygonal2Ds[i] = polygonal2D_Output;
                    }
                }
            }

            if(polygonal2Ds is null || polygonal2Ds.Count == 0)
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

                output = BuildingShape.Other;
                return true;
            }

            Rectangle2D? rectangle2D_Offset = rectangle2D.Offset(-offset);
            if(rectangle2D_Offset is null)
            {
                output = BuildingShape.Undefined;
                return false;
            }
            
            double minArea = rectangle2D_Offset.GetArea() / 9;

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

                output = BuildingShape.Other;
                return true;
            }


            if(rectangle2D_Offset.GetSegments() is not List<Segment2D> segment2Ds)
            {
                output = BuildingShape.Undefined;
                return false;
            }

            List<Tuple<int, Segment2D>> tuples = [];
            for (int i = 0; i < segment2Ds.Count; i++)
            {
                tuples.Add(new Tuple<int, Segment2D>(i, segment2Ds[i]));
            }

            if(polygonal2Ds.Count > 1)
            {
                polygonal2Ds = Geometry.Planar.Query.Union(polygonal2Ds)?.ConvertAll(x => (IPolygonal2D)x);
            }

            if (polygonal2Ds is null)
            {
                output = BuildingShape.Undefined;
                return false;
            }

            Dictionary<int, HashSet<int>> dictionary = [];
            for(int i =0; i < polygonal2Ds.Count; i++)
            {
                IPolygonal2D polygonal2D = polygonal2Ds[i];
                foreach (Tuple<int, Segment2D> tuple in tuples)
                {
                    if(tuple.Item2.Intersect(polygonal2D, tolerance))
                    {
                        if(!dictionary.TryGetValue(tuple.Item1, out HashSet<int> polygonal2Ds_Index))
                        {
                            polygonal2Ds_Index = [];
                            dictionary[tuple.Item1] = polygonal2Ds_Index;
                        }

                        if(polygonal2Ds_Index.Count > 1)
                        {
                            output = BuildingShape.Other;
                            return true;
                        }

                        polygonal2Ds_Index.Add(i);
                    }
                }
            }

            if(dictionary.Count == 0)
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
            foreach(HashSet<int> polygonal2Ds_Index in dictionary.Values)
            {
                counts.Add(polygonal2Ds_Index.Count);
            }

            if (dictionary.Count == 2)
            {
                if (counts.Contains(2))
                {
                    if (!counts.Contains(1))
                    {
                        output = BuildingShape.Other;
                        return true;
                    }

                    output = dictionary.Keys.Last() - dictionary.Keys.First() == 2 ? BuildingShape.Other : BuildingShape.F;
                    return true;
                }

                output = dictionary.Keys.Last() - dictionary.Keys.First() == 2 ? BuildingShape.H : BuildingShape.L;
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
    }
}
