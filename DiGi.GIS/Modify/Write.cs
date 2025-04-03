using DiGi.BDL.Classes;
using DiGi.BDL.Enums;
using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<bool> Write(this IEnumerable<Building2D> building2Ds, string directory, Range<int> range)
        {
            if (building2Ds == null || string.IsNullOrWhiteSpace(directory) || range == null)
            {
                return false;
            }

            foreach (Building2D building2D in building2Ds)
            {
                await Write(building2D, directory, range);
            }

            return true;
        }

        public static async Task<bool> Write(this Building2D building2D, string directory, Range<int> range)
        {
            if (building2D == null || string.IsNullOrWhiteSpace(directory) || range == null)
            {
                return false;
            }

            string? id = building2D.Reference;
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            string directory_Building = System.IO.Path.Combine(directory, id);
            if (!Directory.Exists(directory_Building))
            {
                Directory.CreateDirectory(directory_Building);
            }

            string directory_Orto = directory_Building;

            //string directory_Orto = System.IO.Path.Combine(directory_BUBD_A, "orto");
            //if (!Directory.Exists(directory_Orto))
            //{
            //    Directory.CreateDirectory(directory_Orto);
            //}

            Dictionary<int, string> dictionary_Path = new Dictionary<int, string>();
            for (int i = range.Min; i <= range.Max; i++)
            {
                string path_Orto = System.IO.Path.Combine(directory_Orto, string.Format("{0}.jpeg", i));
                if (path_Orto == null || File.Exists(path_Orto))
                {
                    continue;
                }

                dictionary_Path[i] = path_Orto;
            }

            if (dictionary_Path.Count == 0)
            {
                return true;
            }

            Dictionary<int, byte[]> dictionary = await Query.BytesDictionary(building2D.PolygonalFace2D?.GetBoundingBox(), dictionary_Path.Keys);
            if (dictionary == null)
            {
                return true;
            }

            foreach (KeyValuePair<int, byte[]> keyValuePair in dictionary)
            {
                if (keyValuePair.Value == null)
                {
                    continue;
                }

                string path_Orto = System.IO.Path.Combine(directory_Orto, string.Format("{0}.jpeg", keyValuePair.Key));

                using (Stream memoryStream = new MemoryStream(keyValuePair.Value), fileStream = new FileStream(path_Orto, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                {
                    await memoryStream.CopyToAsync(fileStream);
                }
            }

            return true;
        }

        public static async Task<bool> Write(this StatisticalUnit statisticalUnit, string path, IEnumerable<Variable> variables, Range<int> years)
        {
            if(statisticalUnit == null || variables == null || years == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            string code = statisticalUnit.Code;
            if (code == null || variables.Count() == 0 || years.Max - years.Min == 0)
            {
                return false;
            }

            List<int> years_Temp = new List<int>();
            for(int i = years.Min; i <= years.Max; i++)
            {
                years_Temp.Add(i);
            }

            return await Write(code, path, variables, years_Temp);
        }

        public static async Task<bool> Write(this string code, string path, IEnumerable<Variable> variables, IEnumerable<int> years, bool overrideExisting = false)
        {
            if(string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(path) || variables == null || variables.Count() == 0 || years == null || years.Count() == 0)
            {
                return false;
            }

            UniqueReference uniqueReference = StatisticalDataCollectionFile.GetUniqueReference(code);
            if (uniqueReference == null)
            {
                return false;
            }

            StatisticalDataCollection statisticalDataCollection = null;

            using (StatisticalDataCollectionFile statisticalDataCollectionFile = new StatisticalDataCollectionFile(path))
            {
                statisticalDataCollectionFile.Open();
                statisticalDataCollection = statisticalDataCollectionFile.GetValue(uniqueReference);
            }

            List<Variable> variables_Temp = new List<Variable>(variables);

            if(statisticalDataCollection != null && !overrideExisting)
            {
                for (int i = variables_Temp.Count - 1; i >= 0; i--)
                {
                    if (statisticalDataCollection.Contains(variables_Temp[i]))
                    {
                        variables_Temp.RemoveAt(i);
                    }
                }
            }

            if(variables_Temp.Count == 0)
            {
                return false;
            }

            UnitYearlyValues unitYearlyValues = await BDL.Create.UnitYearlyValues(code, variables_Temp, years);
            if (unitYearlyValues == null)
            {
                return false;
            }

            if(statisticalDataCollection == null)
            {
                statisticalDataCollection = unitYearlyValues.ToDiGi();
            }
            else
            {
                statisticalDataCollection.AddRange(unitYearlyValues);
            }

            if (statisticalDataCollection == null)
            {
                return false;
            }

            bool result = false;

            using (StatisticalDataCollectionFile statisticalDataCollectionFile = new StatisticalDataCollectionFile(path))
            {
                statisticalDataCollectionFile.AddValue(statisticalDataCollection);
                result = statisticalDataCollectionFile.Save();
            }

            return result;
        }
    }
}
