using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static short? UserYearBuilt(this GISModelFile? gISModelFile, Building2D? builidng2D)
        {
            if (gISModelFile == null || builidng2D == null)
            {
                return null;
            }
            string? reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            Dictionary<string, YearBuiltData>? dictionary = YearBuiltDataDictionary<YearBuiltData>(gISModelFile, [reference!]);
            if (dictionary == null || !dictionary.TryGetValue(reference!, out YearBuiltData yearBuiltData) || yearBuiltData == null)
            {
                return null;
            }

            return yearBuiltData.GetUserYearBuilt()?.Year;
        }

        public static short? UserYearBuilt(string? directory, Building2D? builidng2D)
        {
            if (directory == null || builidng2D == null || string.IsNullOrWhiteSpace(directory))
            {
                return null;
            }
            string? reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            Dictionary<string, YearBuiltData>? dictionary = YearBuiltDataDictionary<YearBuiltData>(directory, [reference!]);
            if (dictionary == null || !dictionary.TryGetValue(reference!, out YearBuiltData yearBuiltData) || yearBuiltData == null)
            {
                return null;
            }

            return yearBuiltData.GetUserYearBuilt()?.Year;
        }
    }
}