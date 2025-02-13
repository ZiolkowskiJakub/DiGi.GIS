using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<HashSet<GuidReference>> CalculateOrtoDatas(this GISModelFile gISModelFile, IEnumerable<Building2D> building2Ds, OrtoDatasOptions ortoDatasOptions, bool overrideExisting = false)
        {
            if (gISModelFile == null || building2Ds == null)
            {
                return null;
            }

            GISModel gISModel = gISModelFile.Value;
            if (gISModel == null)
            {
                return null;
            }

            string path_Model = gISModelFile.Path;
            if (string.IsNullOrWhiteSpace(path_Model))
            {
                return null;
            }

            string fileName = System.IO.Path.GetFileNameWithoutExtension(path_Model);

            string directory = System.IO.Path.GetDirectoryName(path_Model);
            if (!System.IO.Directory.Exists(directory))
            {
                return null;
            }

            HashSet<System.Guid> guids = new HashSet<System.Guid>();
            foreach (Building2D building2D in building2Ds)
            {
                if (building2D == null)
                {
                    continue;
                }

                guids.Add(building2D.Guid);
            }

            List<Building2D> building2Ds_All = gISModel.GetObjects<Building2D>(x => guids.Contains(x.Guid));
            if (building2Ds_All == null || building2Ds_All.Count == 0)
            {
                return null;
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, string.Format("{0}.{1}", fileName, Constans.FileExtension.OrtoDatasFile));


            HashSet<GuidReference> result = new HashSet<GuidReference>();
            using (OrtoDatasFile ortoDataFile = new OrtoDatasFile(path_OrtoDatas))
            {
                ortoDataFile.Open();

                string path_Relative = Core.IO.Query.RelativePath(directory, path_OrtoDatas);

                foreach (Building2D building2D in building2Ds_All)
                {
                    if (!overrideExisting && gISModel.TryGetRelatedObject(building2D, out OrtoDatasCalculationResult ortoDatasCalculationResult) && ortoDatasCalculationResult != null)
                    {
                        continue;
                    }

                    UniqueReference uniqueReference = await ortoDataFile.AddValue(building2D, ortoDatasOptions);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    result.Add(new GuidReference(building2D));

                    ortoDatasCalculationResult = new OrtoDatasCalculationResult(new InstanceRelatedExternalReference(path_Relative, uniqueReference));

                    gISModel.Update(building2D, ortoDatasCalculationResult);
                }



                ortoDataFile.Save();
            }

            if(result != null && result.Count != 0)
            {
                gISModelFile.Value = gISModel;
                gISModelFile.Save();
            }

            return result;
        }
    }
}

