using DiGi.BDOT10k.UI;
using DiGi.BDOT10k.UI.Classes;
using DiGi.Geo.Classes;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace DiGi.Geo
{
    public static partial class Modify
    {
        public static bool Extract(this ExtractOptions extractOptions)
        {
            if(extractOptions == null)
            {
                return false;
            }

            string path = extractOptions.SourcePath;

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return false;
            }

            string directory = extractOptions.DestionationDirectory;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
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
                            string directory_Region = Path.Combine(directory, Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name));
                            if (!Directory.Exists(directory_Region))
                            {
                                Directory.CreateDirectory(directory_Region);
                            }

                            string directory_Buildings = Path.Combine(directory_Region, extractOptions.DirectoryName);
                            if (!Directory.Exists(directory_Buildings))
                            {
                                Directory.CreateDirectory(directory_Buildings);
                            }
                            else if (!extractOptions.UpdateExisting)
                            {
                                continue;
                            }

                            DeflateStream deflateStream_Zip = zipArchiveEntry_Zip.Open() as DeflateStream;
                            if (deflateStream_Zip == null)
                            {
                                continue;
                            }

                            ZipArchive zipArchive_Files = new ZipArchive(deflateStream_Zip);

                            SlownikObiektowGeometrycznych slownikObiektowGeometrycznych = new SlownikObiektowGeometrycznych();

                            foreach (ZipArchiveEntry zipArchiveEntry_File in zipArchive_Files.Entries)
                            {
                                if (zipArchiveEntry_File.Name.EndsWith("__OT_ADMS_A.xml") || zipArchiveEntry_File.Name.EndsWith("__OT_BUBD_A.xml"))
                                {
                                    slownikObiektowGeometrycznych.Load(zipArchiveEntry_File.Open());
                                }
                            }

                            if (slownikObiektowGeometrycznych.GetObiektGeometryczny<BUBD_A>() == null || slownikObiektowGeometrycznych.GetObiektGeometryczny<ADMS_A>() == null)
                            {
                                continue;
                            }

                            List<Building2D> building2Ds = slownikObiektowGeometrycznych.Building2Ds();
                            if (building2Ds == null)
                            {
                                continue;
                            }

                            foreach (Building2D building2D in building2Ds)
                            {
                                string reference = building2D?.Reference;
                                if (string.IsNullOrWhiteSpace(reference))
                                {
                                    continue;
                                }

                                string directory_Building = Path.Combine(directory_Buildings, reference);
                                if (!Directory.Exists(directory_Building))
                                {
                                    Directory.CreateDirectory(directory_Building);
                                }
                                else if (!extractOptions.UpdateExisting)
                                {
                                    continue;
                                }

                                Core.Convert.ToFile(building2D, Path.Combine(directory_Building, extractOptions.FileName));
                            }
                        };
                    }
                }
            }

            return true;
        }
    }
}
