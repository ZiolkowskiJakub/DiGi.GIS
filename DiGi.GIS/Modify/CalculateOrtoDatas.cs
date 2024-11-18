using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async void CalculateOrtoDatas(this GISModelFile gISModelFile, IEnumerable<Building2D> building2Ds, OrtoDataOptions ortoDataOptions, bool overrideExisting = false)
        {
            if (gISModelFile == null || building2Ds == null)
            {
                return;
            }

            GISModel gISModel = gISModelFile.Value;
            if (gISModel == null)
            {
                return;
            }

            string path_Model = gISModelFile.Path;
            if (string.IsNullOrWhiteSpace(path_Model))
            {
                return;
            }

            string directory = System.IO.Path.GetDirectoryName(path_Model);
            if (!System.IO.Directory.Exists(directory))
            {
                return;
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
                return;
            }

            string path_OrtoDatas = System.IO.Path.Combine(directory, "ortoData.dgz");



            using (OrtoDatasFile ortoDataFile = new OrtoDatasFile(path_OrtoDatas))
            {
                ortoDataFile.Open();

                string path_Relative = Core.Query.RelativePath(path_Model, path_OrtoDatas);

                foreach (Building2D building2D in building2Ds_All)
                {
                    if (!overrideExisting && gISModel.TryGetRelatedObject(building2D, out OrtoDatasCalculationResult ortoDatasCalculationResult) && ortoDatasCalculationResult != null)
                    {
                        continue;
                    }

                    UniqueReference uniqueReference = await ortoDataFile.AddValue(building2D, ortoDataOptions);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    ortoDatasCalculationResult = new OrtoDatasCalculationResult(new InstanceRelatedExternalReference(path_Relative, uniqueReference));

                    gISModel.Update(building2D, ortoDatasCalculationResult);
                }

                ortoDataFile.Save();
            }
        }
    }
}

