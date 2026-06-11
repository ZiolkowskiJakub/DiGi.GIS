using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts from geoportal zip GML file to DiGi.GIS objects.
        /// </summary>
        /// <param name="path_Input">The path to the source zip GML file.</param>
        /// <param name="directory_Output">The directory where the converted files will be saved.</param>
        /// <param name="oT_ADJA_A">Indicates whether to convert OT_ADJA_A.xml files (AdministrativeSubdivision).</param>
        /// <param name="oT_ADMS_A">Indicates whether to convert OT_ADMS_A.xml files (AdministrativeDivision).</param>
        /// <param name="oT_BUBD_A">Indicates whether to convert OT_BUBD_A.xml files (Building2D).</param>
        /// <returns>A list of paths to the created output files, or null if the input is invalid or no files were processed.</returns>
        public static List<string>? ToDiGi(this string? path_Input, string? directory_Output, bool oT_ADJA_A = true, bool oT_ADMS_A = true, bool oT_BUBD_A = true)
        {
            if (string.IsNullOrWhiteSpace(path_Input) || !File.Exists(path_Input) || string.IsNullOrWhiteSpace(directory_Output))
            {
                return null;
            }

            List<string> sufixes = [];
            if (oT_ADJA_A)
            {
                sufixes.Add(Constants.FileNameSufix.OT_ADJA_A);
            }

            if (oT_ADMS_A)
            {
                sufixes.Add(Constants.FileNameSufix.OT_ADMS_A);
            }

            if (oT_BUBD_A)
            {
                sufixes.Add(Constants.FileNameSufix.OT_BUBD_A);
            }

            if (sufixes.Count == 0)
            {
                return null;
            }

            List<string> result = [];

            using (ZipArchive zipArchive = ZipFile.OpenRead(path_Input))
            {
                foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                {
                    if (zipArchiveEntry.Open() is not DeflateStream deflateStream)
                    {
                        continue;
                    }

                    using ZipArchive zipArchive_ZipArchieve = new(deflateStream);

                    foreach (ZipArchiveEntry zipArchiveEntry_Zip in zipArchive_ZipArchieve.Entries)
                    {
                        string directory_Region = Path.Combine(directory_Output, Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name));
                        if (!Directory.Exists(directory_Region))
                        {
                            Directory.CreateDirectory(directory_Region);
                        }

                        if (zipArchiveEntry_Zip.Open() is not DeflateStream deflateStream_Zip)
                        {
                            continue;
                        }

                        ZipArchive zipArchive_Files = new(deflateStream_Zip);

                        GISModel gISModel = new(Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name), new DirectorySource(zipArchiveEntry_Zip.FullName));

                        foreach (ZipArchiveEntry zipArchiveEntry_File in zipArchive_Files.Entries)
                        {
                            //if (zipArchiveEntry_File.Name.EndsWith(Constants.FileNameSufix.OT_ADJA_A) || zipArchiveEntry_File.Name.EndsWith(Constants.FileNameSufix.OT_ADMS_A) || zipArchiveEntry_File.Name.EndsWith(Constants.FileNameSufix.OT_BUBD_A))
                            if (sufixes.FindIndex(x => zipArchiveEntry_File.Name.EndsWith(x)) != -1)
                            {
                                gISModel.AddRange(zipArchiveEntry_File.Open());
                            }
                        }

                        string path_Output = Path.Combine(directory_Region, string.Format("{0}.{1}", Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name), Constants.FileExtension.GISModelFile));
                        using (GISModelFile gISModelFile = new(path_Output))
                        {
                            gISModelFile.Value = gISModel;
                            gISModelFile.Save();
                        }

                        result.Add(path_Output);
                    }
                    ;
                }
            }

            return result;
        }
    }
}