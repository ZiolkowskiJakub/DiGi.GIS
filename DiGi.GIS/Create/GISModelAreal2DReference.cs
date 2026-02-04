using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static GISModelAreal2DReference? GISModelAreal2DReference(this string reference)
        {
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            string reference_Temp = reference.Trim();

            int index_End = reference_Temp.IndexOf(']');
            if (index_End > 0 && reference_Temp.StartsWith("["))
            {
                string gISModelReference = reference_Temp.Substring(1, index_End - 1);
                string areal2DReference = reference_Temp.Substring(index_End + 1);

                return new GISModelAreal2DReference(gISModelReference, areal2DReference);
            }

            return new GISModelAreal2DReference(null, reference);
        }
    }
}