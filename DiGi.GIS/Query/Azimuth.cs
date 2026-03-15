using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static double Azimuth(this Building2D? builidng2D, Vector2D? referenceDirection = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (builidng2D?.PolygonalFace2D is not PolygonalFace2D polygonalFace2D)
            {
                return double.NaN;
            }

            Rectangle2D? rectangle2D = Geometry.Planar.Create.Rectangle2D(polygonalFace2D, tolerance);
            if (rectangle2D is null)
            {
                return double.NaN;
            }

            referenceDirection ??= Geometry.Planar.Constants.Vector2D.WorldY;

            Vector2D? direction = rectangle2D.Height > rectangle2D.Width ? rectangle2D.WidthDirection : rectangle2D.HeightDirection;
            if (direction is null)
            {
                return double.NaN;
            }

            double signedAngle = double.NaN;

            if (polygonalFace2D?.Edges is List<IPolygonal2D> edges)
            {
                if (direction.GetInversed() is not Vector2D direction_Inversed)
                {
                    return double.NaN;
                }

                double sum = 0;
                double sum_Inversed = 0;

                foreach (IPolygonal2D edge in edges)
                {
                    if (edge?.GetSegments() is not List<Segment2D> segment2Ds || edge.Normals() is not List<Vector2D> normals)
                    {
                        continue;
                    }

                    for (int i = 0; i < segment2Ds.Count; i++)
                    {
                        if (direction.Angle(normals[i]) <= direction_Inversed.Angle(normals[i]))
                        {
                            sum += segment2Ds[i].Length;
                        }
                        else
                        {
                            sum_Inversed += segment2Ds[i].Length;
                        }
                    }
                }

                if (sum > 0 || sum_Inversed > 0)
                {
                    signedAngle = sum >= sum_Inversed ? direction.SignedAngle(referenceDirection) : direction_Inversed.SignedAngle(referenceDirection);
                }
            }

            if (double.IsNaN(signedAngle))
            {
                signedAngle = Math.Min(direction.Angle(referenceDirection), direction.GetInversed().Angle(referenceDirection));
            }

            double result = signedAngle * 180.0 / Math.PI;
            if (result < 0)
            {
                result += 360;
            }

            return result;
        }
    }
}