using DiGi.BDOT10k.UI;
using DiGi.BDOT10k.UI.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace DiGi.GIS
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
                                if (zipArchiveEntry_File.Name.EndsWith(Constans.FileNamePrefix.OT_ADMS_A) || zipArchiveEntry_File.Name.EndsWith(Constans.FileNamePrefix.OT_BUBD_A))
                                {
                                    slownikObiektowGeometrycznych.Load(zipArchiveEntry_File.Open());
                                }
                            }

                            if (slownikObiektowGeometrycznych.GetObiektGeometryczny<BUBD_A>() == null || slownikObiektowGeometrycznych.GetObiektGeometryczny<ADMS_A>() == null)
                            {
                                continue;
                            }

                            GISModel gISModel = Convert.ToDiGi(slownikObiektowGeometrycznych);
                            if(gISModel == null)
                            {
                                continue;
                            }

                            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel.GetObjects<AdministrativeAreal2D>();
                            if(administrativeAreal2Ds != null)
                            {
                                string directory_AdministrativeAreals = Path.Combine(directory_Region, extractOptions.AdministrativeArealsDirectoryName);
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
                                    else if (!extractOptions.UpdateExisting)
                                    {
                                        continue;
                                    }

                                    Core.Convert.ToFile(administrativeAreal2D, Path.Combine(directory_AdministrativeAreal, extractOptions.AdministrativeAreal2DFileName));
                                }
                            }

                            List<Building2D> building2Ds = gISModel.GetObjects<Building2D>();
                            if (building2Ds != null)
                            {
                                string directory_Buildings = Path.Combine(directory_Region, extractOptions.BuildingsDirectoryName);
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
                                    else if (!extractOptions.UpdateExisting)
                                    {
                                        continue;
                                    }

                                    Core.Convert.ToFile(building2D, Path.Combine(directory_Building, extractOptions.Building2DFileName));
                                }
                            }
                        };
                    }
                }
            }

            return true;
        }
    }
}
