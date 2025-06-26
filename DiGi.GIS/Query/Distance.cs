using System;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static double Distance(double latitude_1, double longitude_1, double latitude_2, double longitude_2)
        {
            if(double.IsNaN(latitude_1) || double.IsNaN(latitude_2) || double.IsNaN(longitude_1) || double.IsNaN(longitude_2))
            {
                return double.NaN;
            }

            double r = 6371000; // Earth radius in meters

            double radLat1 = latitude_1 * Math.PI / 180.0; ;
            double radLat2 = latitude_2 * Math.PI / 180.0; ;
            double deltaLat = (latitude_2 - latitude_1) * Math.PI / 180.0;
            double deltaLon = (longitude_2 - longitude_1) * Math.PI / 180.0;

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(radLat1) * Math.Cos(radLat2) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return r * c;
        }
    }
}

