using DiGi.GIS.Classes;
using System.IO.Compression;
using System.IO;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static List<string> ToDiGi(this string path_Input, string directory_Output)
        {
            if(string.IsNullOrWhiteSpace(path_Input) || !File.Exists(path_Input) || string.IsNullOrWhiteSpace(directory_Output))
            {
                return null;
            }

            List<string> result = new List<string>();

            using (ZipArchive zipArchive = ZipFile.OpenRead(path_Input))
            {
                foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                {
                    DeflateStream deflateStream = zipArchiveEntry.Open() as DeflateStream;
                    if (deflateStream == null)
                    {
                        continue;
                    }

                    using (ZipArchive zipArchive_ZipArchieve = new ZipArchive(deflateStream))
                    {
                        foreach (ZipArchiveEntry zipArchiveEntry_Zip in zipArchive_ZipArchieve.Entries)
                        {
                            string directory_Region = Path.Combine(directory_Output, Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name));
                            if (!Directory.Exists(directory_Region))
                            {
                                Directory.CreateDirectory(directory_Region);
                            }

                            DeflateStream deflateStream_Zip = zipArchiveEntry_Zip.Open() as DeflateStream;
                            if (deflateStream_Zip == null)
                            {
                                continue;
                            }

                            ZipArchive zipArchive_Files = new ZipArchive(deflateStream_Zip);

                            GISModel gISModel = new GISModel(new DirectorySource(zipArchiveEntry_Zip.FullName));

                            foreach (ZipArchiveEntry zipArchiveEntry_File in zipArchive_Files.Entries)
                            {
                                if (zipArchiveEntry_File.Name.EndsWith(Constans.FileNamePrefix.OT_ADMS_A) || zipArchiveEntry_File.Name.EndsWith(Constans.FileNamePrefix.OT_BUBD_A))
                                {
                                    gISModel.AddRange(zipArchiveEntry_File.Open());
                                }
                            }

                            string path_Output = Path.Combine(directory_Region, string.Format("{0}.{1}", Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name), Constans.FileExtension.GISModelFile));
                            using (GISModelFile gISModelFile = new GISModelFile(path_Output))
                            {
                                gISModelFile.Value = gISModel;
                                gISModelFile.Save();
                            }

                            result.Add(path_Output);
                        };
                    }
                }
            }

            return result;
        }
    }
}
