using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<HashSet<GuidReference>> CalculateOrtoDatas(this IEnumerable<Building2D> building2Ds, string path, OrtoDatasOptions ortoDatasOptions, bool overrideExisting = false)
        {
            if(building2Ds == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory))
            {
                return null;
            }

            if(ortoDatasOptions == null)
            {
                ortoDatasOptions = new OrtoDatasOptions();
            }

            IEnumerable<Building2D> building2Ds_Temp = building2Ds;
            if (!overrideExisting)
            {
                Dictionary<GuidReference, OrtoDatas> dictionary = Query.OrtoDatasDictionary(directory, building2Ds_Temp);
                if (dictionary != null && dictionary.Count != 0)
                {
                    List<Building2D> building2Ds_Temp_Temp = new List<Building2D>(building2Ds_Temp);
                    foreach (Building2D building2D in building2Ds_Temp)
                    {
                        GuidReference guidReference = building2D == null ? null : new GuidReference(building2D);
                        if (dictionary.ContainsKey(guidReference))
                        {
                            building2Ds_Temp_Temp.Remove(building2D);
                        }
                    }

                    building2Ds_Temp = building2Ds_Temp_Temp;
                }
            }

            HashSet<GuidReference> result = new HashSet<GuidReference>();

            if (building2Ds_Temp.Count() == 0)
            {
                return result;
            }

            string fileName = System.IO.Path.GetFileNameWithoutExtension(path);
            if (ortoDatasOptions.MaxFileSize != ulong.MaxValue)
            {
                fileName = Query.FileName(directory, fileName, System.IO.Path.GetExtension(path), ortoDatasOptions.MaxFileSize);
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, string.Format("{0}{1}", fileName, System.IO.Path.GetExtension(path)));

            using (OrtoDatasFile ortoDataFile = new OrtoDatasFile(path_OrtoDatas))
            {
                ortoDataFile.Open();

                foreach (Building2D building2D in building2Ds_Temp)
                {
                    UniqueReference uniqueReference = await ortoDataFile.AddValue(building2D, ortoDatasOptions);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    result.Add(new GuidReference(building2D));
                }

                ortoDataFile.Save();
            }

            return result;
        }

    }
}

