using DiGi.EPW.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static EPWFile? EPWFile(this Point2D? point2D, IEnumerable<EPWFile>? ePWFiles, out double distance)
        {
            distance = double.NaN;

            if(point2D == null || ePWFiles == null)
            {
                return null;
            }

            Point3D? point3D = Convert.ToEPSG4326(point2D);
            if(point3D is null)
            {
                return null;
            }

            List<Tuple<double, Point3D, EPWFile>> tuples = [];

            foreach (EPWFile ePWFile in ePWFiles)
            {
                Location? location = ePWFile?.Location;
                if(location == null)
                {
                    continue;
                }

                Point3D point3D_EPWFile = new (location.Longitude, location.Latitude, location.Elevation);

                tuples.Add(new Tuple<double, Point3D, EPWFile>(point3D.Distance(point3D_EPWFile), point3D_EPWFile, ePWFile!));
            }

            if(tuples == null || tuples.Count == 0)
            {
                return null;
            }

            tuples.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            Tuple<double, Point3D, EPWFile> tuple = tuples[0];

            distance = Distance(point3D.Y, point3D.X, tuple.Item2.Y, tuple.Item2.X);

            return tuple.Item3;
        }
    }
}
