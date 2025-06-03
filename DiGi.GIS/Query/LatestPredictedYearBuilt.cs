using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static short? LatestPredictedYearBuilt(this GISModelFile gISModelFile, Building2D builidng2D)
        {
            if (gISModelFile == null || builidng2D == null)
            {
                return null;
            }
            string reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            Dictionary<string, YearBuiltData> dictionary = YearBuiltDataDictionary<YearBuiltData>(gISModelFile, new string[] { reference });
            if(dictionary == null || !dictionary.TryGetValue(reference, out YearBuiltData yearBuiltData) || yearBuiltData == null)
            {
                return null;
            }

            return yearBuiltData.GetLatestPredictedYearBuilt()?.Year;
        }
    }
}







