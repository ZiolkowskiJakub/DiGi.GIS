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
        public static List<OrtoRange> OrtoRanges(GISModel gISModel, IEnumerable<string> references = null, OrtoRangeOptions ortoRangeOptions = null, double tolerance = Core.Constans.Tolerance.Distance)
        {

            List<Building2D> building2Ds = gISModel?.GetObjects<Building2D>();
            if(building2Ds == null)
            {
                return null;
            }

            if(references != null)
            {
                building2Ds = building2Ds.FindAll(x => references.Contains(x.Reference));
            }

            if(building2Ds == null || building2Ds.Count == 0)
            {
                return null;
            }

            List<Tuple<Building2D, BoundingBox2D>> tuples = new List<Tuple<Building2D, BoundingBox2D>>();
            foreach(Building2D building2D in building2Ds)
            {
                BoundingBox2D boundingBox2D = null;

                Building2DGeometryCalculationResult building2DGeometryCalculationResult = gISModel.GetRelatedObject<Building2DGeometryCalculationResult>(building2D);

                boundingBox2D = building2DGeometryCalculationResult?.BoundingBox;

                if (boundingBox2D == null)
                {
                    boundingBox2D = building2D.PolygonalFace2D?.GetBoundingBox();
                }

                if (boundingBox2D == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<Building2D, BoundingBox2D>(building2D, boundingBox2D));
            }

            if(ortoRangeOptions == null)
            {
                ortoRangeOptions = new OrtoRangeOptions();
            }

            List<OrtoRange> result = new List<OrtoRange>();

            while (tuples.Count > 0)
            {
                Building2D building2D = tuples[0].Item1;
                BoundingBox2D boundingBox2D_Building2D = tuples[0].Item2;

                tuples.RemoveAt(0);

                if(building2D == null)
                {
                    continue;
                }

                Point2D point2D = boundingBox2D_Building2D.GetCentroid();

                BoundingBox2D boundingBox2D = Geometry.Planar.Create.BoundingBox2D(point2D, ortoRangeOptions.Width, ortoRangeOptions.Height);

                boundingBox2D.Add(boundingBox2D_Building2D);

                HashSet<string> references_Intersect = new HashSet<string>();
                HashSet<string> references_Inside = new HashSet<string>();

                for(int i = tuples.Count - 1; i >= 0; i--)
                {
                    string reference = tuples[i].Item1.Reference;
                    if(string.IsNullOrWhiteSpace(reference))
                    {
                        continue;
                    }

                    BoundingBox2D boundingBox2D_Temp = tuples[i].Item2;

                    if(!boundingBox2D.InRange(boundingBox2D_Temp, tolerance))
                    {
                        continue;
                    }

                    if(!boundingBox2D.Inside(boundingBox2D_Temp, tolerance))
                    {
                        references_Intersect.Add(reference);
                        continue;
                    }

                    references_Inside.Add(reference);
                    tuples.Remove(tuples[i]);
                }

                result.Add(new OrtoRange(boundingBox2D, references_Inside, references_Intersect));
            }

            return result;
        }
    }
}
