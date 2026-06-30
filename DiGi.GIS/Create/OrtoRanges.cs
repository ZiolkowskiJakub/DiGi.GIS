using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a list of ortho ranges based on the provided GIS model and options.
        /// </summary>
        /// <param name="gISModel">The GIS model from which building data is retrieved.</param>
        /// <param name="references">An optional collection of references to filter the buildings included in the calculation.</param>
        /// <param name="ortoRangeOptions">Options specifying the dimensions for the ortho ranges.</param>
        /// <param name="tolerance">The distance tolerance used for range and intersection checks.</param>
        /// <returns>A list of <see cref="OrtoRange"/> objects if successful; otherwise, null.</returns>
        public static List<OrtoRange>? OrtoRanges(GISModel? gISModel, IEnumerable<string>? references = null, OrtoRangeOptions? ortoRangeOptions = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            List<Building2D>? building2Ds = gISModel?.GetObjects<Building2D>();
            if (building2Ds == null)
            {
                return null;
            }

            if (references != null)
            {
                building2Ds = building2Ds.FindAll(x => references.Contains(x.Reference));
            }

            if (building2Ds == null || building2Ds.Count == 0)
            {
                return null;
            }

            LinkedList<Tuple<Building2D, BoundingBox2D>> tuples = [];
            foreach (Building2D building2D in building2Ds)
            {
                BoundingBox2D? boundingBox2D = null;

                Building2DGeometryCalculationResult? building2DGeometryCalculationResult = gISModel!.GetRelatedObject<Building2DGeometryCalculationResult>(building2D);

                boundingBox2D = building2DGeometryCalculationResult?.BoundingBox;

                boundingBox2D ??= building2D.PolygonalFace2D?.GetBoundingBox();

                if (boundingBox2D == null)
                {
                    continue;
                }

                tuples.AddLast(new Tuple<Building2D, BoundingBox2D>(building2D, boundingBox2D));
            }

            ortoRangeOptions ??= new OrtoRangeOptions();

            List<OrtoRange> result = [];

            while (tuples.Count > 0)
            {
                Building2D building2D = tuples.First!.Value.Item1;
                BoundingBox2D boundingBox2D_Building2D = tuples.First!.Value.Item2;

                tuples.RemoveFirst();

                if (building2D == null)
                {
                    continue;
                }

                Point2D? point2D = boundingBox2D_Building2D.GetCentroid();

                BoundingBox2D? boundingBox2D = Geometry.Planar.Create.BoundingBox2D(point2D, ortoRangeOptions.Width, ortoRangeOptions.Height);
                if (boundingBox2D is null)
                {
                    continue;
                }

                boundingBox2D.Add(boundingBox2D_Building2D);

                HashSet<string> references_Intersect = [];
                HashSet<string> references_Inside = [];

                LinkedListNode<Tuple<Building2D, BoundingBox2D>>? node = tuples.Last;
                while (node != null)
                {
                    LinkedListNode<Tuple<Building2D, BoundingBox2D>>? node_Previous = node.Previous;

                    string? reference = node.Value.Item1.Reference;
                    if (string.IsNullOrWhiteSpace(reference))
                    {
                        node = node_Previous;
                        continue;
                    }

                    BoundingBox2D boundingBox2D_Temp = node.Value.Item2;

                    if (!boundingBox2D.InRange(boundingBox2D_Temp, tolerance))
                    {
                        node = node_Previous;
                        continue;
                    }

                    if (!boundingBox2D.Inside(boundingBox2D_Temp, tolerance))
                    {
                        references_Intersect.Add(reference!);
                        node = node_Previous;
                        continue;
                    }

                    references_Inside.Add(reference!);
                    tuples.Remove(node);

                    node = node_Previous;
                }

                result.Add(new OrtoRange(boundingBox2D, references_Inside, references_Intersect));
            }

            return result;
        }
    }
}