using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static bool Extract(this DirectoryExtractOptions directoryExtractOptions)
        {
            if(directoryExtractOptions == null)
            {
                return false;
            }

            string path = directoryExtractOptions.SourcePath;

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return false;
            }

            string directory = directoryExtractOptions.DestionationDirectory;
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
                            else if (!directoryExtractOptions.UpdateExisting)
                            {
                                continue;
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

                            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel.GetObjects<AdministrativeAreal2D>();
                            if(administrativeAreal2Ds != null)
                            {
                                string directory_AdministrativeAreals = Path.Combine(directory_Region, directoryExtractOptions.AdministrativeArealsDirectoryName);
                                if (!Directory.Exists(directory_AdministrativeAreals))
                                {
                                    Directory.CreateDirectory(directory_AdministrativeAreals);
                                }

                                foreach (AdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
                                {
                                    string reference = administrativeAreal2D?.Reference;
                                    if (string.IsNullOrWhiteSpace(reference))
                                    {
                                        continue;
                                    }

                                    string directory_AdministrativeAreal = Path.Combine(directory_AdministrativeAreals, reference);
                                    if (!Directory.Exists(directory_AdministrativeAreal))
                                    {
                                        Directory.CreateDirectory(directory_AdministrativeAreal);
                                    }
                                    else if (!directoryExtractOptions.UpdateExisting)
                                    {
                                        continue;
                                    }

                                    Core.Convert.ToFileInfo(administrativeAreal2D, Path.Combine(directory_AdministrativeAreal, directoryExtractOptions.AdministrativeAreal2DFileName));
                                }
                            }

                            List<Building2D> building2Ds = gISModel.GetObjects<Building2D>();
                            if (building2Ds != null)
                            {
                                string directory_Buildings = Path.Combine(directory_Region, directoryExtractOptions.BuildingsDirectoryName);
                                if (!Directory.Exists(directory_Buildings))
                                {
                                    Directory.CreateDirectory(directory_Buildings);
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
                                    else if (!directoryExtractOptions.UpdateExisting)
                                    {
                                        continue;
                                    }

                                    Core.Convert.ToFileInfo(building2D, Path.Combine(directory_Building, directoryExtractOptions.Building2DFileName));
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
