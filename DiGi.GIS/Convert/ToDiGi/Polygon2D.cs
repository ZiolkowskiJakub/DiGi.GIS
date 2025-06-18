using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static Polygon2D ToDiGi(this GML.Classes.LinearRing linearRing)
        {
            if (linearRing == null)
            {
                return null;
            }

            List<double> values = linearRing.posList;
            if (values == null)
            {
                return null;
            }

            int count = values.Count;

            if (count == 0 || count % 2 != 0)
            {
                return null;
            }

            List<Point2D> point2Ds = new List<Point2D>();
            for (int i = 0; i < values.Count; i = i + 2)
            {
                point2Ds.Add(new Point2D(values[i], values[i + 1]));
            }

            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            int lastIndex = point2Ds.Count - 1;

            if (point2Ds[0].Equals(point2Ds[lastIndex]))
            {
                point2Ds.RemoveAt(lastIndex);
            }

            return new Polygon2D(point2Ds);
        }
    }
}
