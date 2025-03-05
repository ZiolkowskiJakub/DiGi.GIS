using DiGi.BDOT10k.Classes;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static string Reference(this OT_ADJA_A oT_ADJA_A)
        {
            if (oT_ADJA_A == null)
            {
                return null;
            }

            string result = null;

            result = Create.Reference(oT_ADJA_A.lokalnyId);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Create.Reference(oT_ADJA_A.id);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Reference(oT_ADJA_A.geometria);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            return null;
        }

        public static string Reference(this OT_ADMS_A oT_ADMS_A)
        {
            if (oT_ADMS_A == null)
            {
                return null;
            }

            string result = null;

            result = Create.Reference(oT_ADMS_A.lokalnyId);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Create.Reference(oT_ADMS_A.id);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Reference(oT_ADMS_A.geometria);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            return null;
        }

        public static string Reference(this OT_BUBD_A oT_BUBD_A)
        {
            if (oT_BUBD_A == null)
            {
                return null;
            }

            string result = null;

            result = Create.Reference(oT_BUBD_A.lokalnyId);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            List<string> identyfikatoryEGiB = oT_BUBD_A.identyfikatorEGiB;
            if (identyfikatoryEGiB != null && identyfikatoryEGiB.Count != 0)
            {
                foreach (string identyfikatorEGiB in identyfikatoryEGiB)
                {
                    if (string.IsNullOrWhiteSpace(identyfikatorEGiB))
                    {
                        continue;
                    }

                    result = Create.Reference(identyfikatorEGiB);
                    if (result == identyfikatorEGiB)
                    {
                        return result;
                    }
                }

                foreach (string identyfikatorEGiB in identyfikatoryEGiB)
                {
                    if (string.IsNullOrWhiteSpace(identyfikatorEGiB))
                    {
                        continue;
                    }

                    result = Create.Reference(identyfikatorEGiB);
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        return result;
                    }
                }
            }

            result = Create.Reference(oT_BUBD_A.id);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Reference(oT_BUBD_A.geometria);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            return null;
        }

        public static string Reference(this GML.Classes.Geometry geometry)
        {
            if(geometry == null)
            {
                return null;
            }

            string result;

            result = Create.Reference(geometry.id);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            if(geometry is Polygon)
            {
                return Reference((Polygon)geometry);
            }

            if (geometry is LinearRing)
            {
                return Reference((LinearRing)geometry);
            }

            return null;
        }

        public static string Reference(this Polygon polygon)
        {
            if (polygon == null)
            {
                return null;
            }

            string result;

            result = Create.Reference(polygon.id);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Create.Hash(polygon).ToString();
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            return null;
        }

        public static string Reference(this LinearRing linearRing)
        {
            if (linearRing == null)
            {
                return null;
            }

            string result;

            result = Create.Reference(linearRing.id);
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            result = Create.Hash(linearRing).ToString();
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            return null;
        }
    }
}
