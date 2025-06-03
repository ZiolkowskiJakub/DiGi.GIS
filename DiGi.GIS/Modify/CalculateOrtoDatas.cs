using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<HashSet<GuidReference>> CalculateOrtoDatas(this IEnumerable<Building2D> building2Ds, string path, OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions, bool overrideExisting = false)
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

            if(ortoDatasBuilding2DOptions == null)
            {
                ortoDatasBuilding2DOptions = new OrtoDatasBuilding2DOptions();
            }

            directory = ortoDatasBuilding2DOptions.Directory(directory);
            if(!System.IO.Directory.Exists(directory))
            {
                System.IO.DirectoryInfo directoryInfo = System.IO.Directory.CreateDirectory(directory);
                if(directoryInfo == null)
                {
                    return null;
                }
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
            if (ortoDatasBuilding2DOptions.MaxFileSize != ulong.MaxValue)
            {
                fileName = Query.FileName(directory, fileName, System.IO.Path.GetExtension(path), ortoDatasBuilding2DOptions.MaxFileSize);
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, string.Format("{0}{1}", fileName, System.IO.Path.GetExtension(path)));

            using (OrtoDatasFile ortoDatasFile = new OrtoDatasFile(path_OrtoDatas))
            {
                ortoDatasFile.Open();

                foreach (Building2D building2D in building2Ds_Temp)
                {
                    UniqueReference uniqueReference = await ortoDatasFile.AddValue(building2D, ortoDatasBuilding2DOptions);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    result.Add(new GuidReference(building2D));
                }

                ortoDatasFile.Save();
            }

            return result;
        }

        public static async Task<HashSet<GuidReference>> CalculateOrtoDatas(this IEnumerable<OrtoRange> ortoRanges, string path, OrtoDatasOrtoRangeOptions ortoDatasOrtoRangeOptions, bool overrideExisting = false)
        {
            if (ortoRanges == null)
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

            if (ortoDatasOrtoRangeOptions == null)
            {
                ortoDatasOrtoRangeOptions = new OrtoDatasOrtoRangeOptions();
            }

            directory = ortoDatasOrtoRangeOptions.Directory(directory);
            if (!System.IO.Directory.Exists(directory))
            {
                System.IO.DirectoryInfo directoryInfo = System.IO.Directory.CreateDirectory(directory);
                if (directoryInfo == null)
                {
                    return null;
                }
            }

            IEnumerable<OrtoRange> ortoRanges_Temp = ortoRanges;
            if (!overrideExisting)
            {
                Dictionary<GuidReference, OrtoDatas> dictionary = Query.OrtoDatasDictionary(directory, ortoRanges_Temp);
                if (dictionary != null && dictionary.Count != 0)
                {
                    List<OrtoRange> ortoRanges_Temp_Temp = new List<OrtoRange>(ortoRanges_Temp);
                    foreach (OrtoRange ortoRange in ortoRanges_Temp)
                    {
                        GuidReference guidReference = ortoRange == null ? null : new GuidReference(ortoRange);
                        if (dictionary.ContainsKey(guidReference))
                        {
                            ortoRanges_Temp_Temp.Remove(ortoRange);
                        }
                    }

                    ortoRanges_Temp = ortoRanges_Temp_Temp;
                }
            }

            HashSet<GuidReference> result = new HashSet<GuidReference>();

            if (ortoRanges_Temp.Count() == 0)
            {
                return result;
            }

            string fileName = System.IO.Path.GetFileNameWithoutExtension(path);
            if (ortoDatasOrtoRangeOptions.MaxFileSize != ulong.MaxValue)
            {
                fileName = Query.FileName(directory, fileName, System.IO.Path.GetExtension(path), ortoDatasOrtoRangeOptions.MaxFileSize);
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, string.Format("{0}{1}", fileName, System.IO.Path.GetExtension(path)));

            using (OrtoDatasFile ortoDatasFile = new OrtoDatasFile(path_OrtoDatas))
            {
                ortoDatasFile.Open();

                foreach (OrtoRange ortoRange in ortoRanges_Temp)
                {
                    UniqueReference uniqueReference = await ortoDatasFile.AddValue(ortoRange, ortoDatasOrtoRangeOptions);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    result.Add(new GuidReference(ortoRange));
                }

                ortoDatasFile.Save();
            }

            return result;
        }
    }
}

