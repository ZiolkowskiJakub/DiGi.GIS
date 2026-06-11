using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        /// <summary>
        /// Calculates orthodata for the specified collection of building 2D objects and saves them to the provided path.
        /// </summary>
        /// <param name="building2Ds">The collection of Building2D objects to process.</param>
        /// <param name="path">The file path where the orthodata should be stored.</param>
        /// <param name="ortoDatasBuilding2DOptions">The options used for calculating orthodata for building 2D objects.</param>
        /// <param name="overrideExisting">A value indicating whether to override existing data in the target files.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a set of <see cref="GuidReference"/> for the processed buildings, or null if the input parameters are invalid.</returns>
        public static async Task<HashSet<GuidReference>?> CalculateOrtoDatas(this IEnumerable<Building2D>? building2Ds, string? path, OrtoDatasBuilding2DOptions? ortoDatasBuilding2DOptions, bool overrideExisting = false)
        {
            if (building2Ds == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string? directory = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory))
            {
                return null;
            }

            ortoDatasBuilding2DOptions ??= new OrtoDatasBuilding2DOptions();

            directory = ortoDatasBuilding2DOptions.Directory(directory);
            if (!System.IO.Directory.Exists(directory))
            {
                System.IO.DirectoryInfo directoryInfo = System.IO.Directory.CreateDirectory(directory);
                if (directoryInfo == null)
                {
                    return null;
                }
            }

            IEnumerable<Building2D> building2Ds_Temp = building2Ds;
            if (!overrideExisting)
            {
                Dictionary<GuidReference, OrtoDatas>? dictionary = Query.OrtoDatasDictionary(directory, building2Ds_Temp);
                if (dictionary != null && dictionary.Count != 0)
                {
                    List<Building2D> building2Ds_Temp_Temp = [.. building2Ds_Temp];
                    foreach (Building2D building2D in building2Ds_Temp)
                    {
                        if (building2D is null)
                        {
                            continue;
                        }

                        GuidReference guidReference = new(building2D);
                        //if (dictionary.ContainsKey(guidReference))
                        //{
                        //    building2Ds_Temp_Temp.Remove(building2D);
                        //}

                        if (dictionary.TryGetValue(guidReference, out OrtoDatas ortoDatas) && ortoDatas != null)
                        {
                            building2Ds_Temp_Temp.Remove(building2D);
                        }
                    }

                    building2Ds_Temp = building2Ds_Temp_Temp;
                }
            }
            else
            {
                Dictionary<GuidReference, OrtoDatas>? dictionary = Query.OrtoDatasDictionary(directory, building2Ds_Temp, out Dictionary<GuidReference, string>? pathDictionary);
                if (dictionary != null && dictionary.Count != 0 && pathDictionary != null && pathDictionary.Count != 0)
                {
                    Dictionary<string, List<GuidReference>> dictionary_GuidReference = [];
                    foreach (KeyValuePair<GuidReference, string> keyValuePair in pathDictionary)
                    {
                        if (!dictionary_GuidReference.TryGetValue(keyValuePair.Value, out List<GuidReference> guidReferences) || guidReferences == null)
                        {
                            guidReferences = [];
                            dictionary_GuidReference[keyValuePair.Value] = guidReferences;
                        }

                        guidReferences.Add(keyValuePair.Key);
                    }

                    foreach (KeyValuePair<string, List<GuidReference>> keyValuePair in dictionary_GuidReference)
                    {
                        using OrtoDatasFile ortoDatasFile = new(keyValuePair.Key);
                        ortoDatasFile.Open();

                        List<UniqueReference> uniqueReferences = [];
                        foreach (GuidReference guidReference in keyValuePair.Value)
                        {
                            if (!dictionary.TryGetValue(guidReference, out OrtoDatas ortoDatas) || ortoDatas is null)
                            {
                                continue;
                            }

                            if (ortoDatasFile.GetUniqueReference(ortoDatas) is not UniqueReference uniqueReference)
                            {
                                continue;
                            }

                            uniqueReferences.Add(uniqueReference);
                        }

                        ortoDatasFile.Remove(uniqueReferences);

                        ortoDatasFile.Save();
                    }
                }
            }

            HashSet<GuidReference> result = [];

            if (building2Ds_Temp.Count() == 0)
            {
                return result;
            }

            string? fileName = System.IO.Path.GetFileNameWithoutExtension(path);
            if (ortoDatasBuilding2DOptions.MaxFileSize != ulong.MaxValue)
            {
                fileName = Query.FileName(directory, fileName, System.IO.Path.GetExtension(path), ortoDatasBuilding2DOptions.MaxFileSize);
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                return result;
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, string.Format("{0}{1}", fileName, System.IO.Path.GetExtension(path)));

            using (OrtoDatasFile ortoDatasFile = new(path_OrtoDatas))
            {
                ortoDatasFile.Open();

                foreach (Building2D building2D in building2Ds_Temp)
                {
                    UniqueReference? uniqueReference = await ortoDatasFile.AddValue(building2D, ortoDatasBuilding2DOptions);
                    if (uniqueReference is null)
                    {
                        continue;
                    }

                    result.Add(new GuidReference(building2D));
                }

                ortoDatasFile.Save();
            }

            return result;
        }

        /// <summary>
        /// Calculates orthodata for the specified collection of ortho range objects and saves them to the provided path.
        /// </summary>
        /// <param name="ortoRanges">The collection of OrtoRange objects to process.</param>
        /// <param name="path">The file path where the orthodata should be stored.</param>
        /// <param name="ortoDatasOrtoRangeOptions">The options used for calculating orthodata for ortho range objects.</param>
        /// <param name="overrideExisting">A value indicating whether to override existing data in the target files.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a set of <see cref="GuidReference"/> for the processed ranges, or null if the input parameters are invalid.</returns>
        public static async Task<HashSet<GuidReference>?> CalculateOrtoDatas(this IEnumerable<OrtoRange>? ortoRanges, string? path, OrtoDatasOrtoRangeOptions? ortoDatasOrtoRangeOptions, bool overrideExisting = false)
        {
            if (ortoRanges == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string? directory = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory))
            {
                return null;
            }

            ortoDatasOrtoRangeOptions ??= new OrtoDatasOrtoRangeOptions();

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
                Dictionary<GuidReference, OrtoDatas>? dictionary = Query.OrtoDatasDictionary(directory, ortoRanges_Temp);
                if (dictionary != null && dictionary.Count != 0)
                {
                    List<OrtoRange> ortoRanges_Temp_Temp = [.. ortoRanges_Temp];
                    foreach (OrtoRange ortoRange in ortoRanges_Temp)
                    {
                        if (ortoRange is null)
                        {
                            continue;
                        }

                        GuidReference? guidReference = new(ortoRange);
                        if (dictionary.ContainsKey(guidReference))
                        {
                            ortoRanges_Temp_Temp.Remove(ortoRange);
                        }
                    }

                    ortoRanges_Temp = ortoRanges_Temp_Temp;
                }
            }

            HashSet<GuidReference> result = [];

            if (ortoRanges_Temp.Count() == 0)
            {
                return result;
            }

            string? fileName = System.IO.Path.GetFileNameWithoutExtension(path);
            if (ortoDatasOrtoRangeOptions.MaxFileSize != ulong.MaxValue)
            {
                fileName = Query.FileName(directory, fileName, System.IO.Path.GetExtension(path), ortoDatasOrtoRangeOptions.MaxFileSize);
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                return result;
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, string.Format("{0}{1}", fileName, System.IO.Path.GetExtension(path)));

            using (OrtoDatasFile ortoDatasFile = new(path_OrtoDatas))
            {
                ortoDatasFile.Open();

                foreach (OrtoRange ortoRange in ortoRanges_Temp)
                {
                    UniqueReference? uniqueReference = await ortoDatasFile.AddValue(ortoRange, ortoDatasOrtoRangeOptions);
                    if (uniqueReference is null)
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