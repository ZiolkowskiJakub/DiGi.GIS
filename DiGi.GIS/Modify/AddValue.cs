using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<UniqueReference> AddValue(this OrtoDatasFile ortoDatasFile, Building2D builidng2D, OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions = null)
        {
            if (ortoDatasFile == null || builidng2D == null)
            {
                return null;
            }

            if(ortoDatasBuilding2DOptions == null)
            {
                ortoDatasBuilding2DOptions = new OrtoDatasBuilding2DOptions();
            }

            OrtoDatas ortoDatas = await Create.OrtoDatas(builidng2D, ortoDatasBuilding2DOptions.Years, ortoDatasBuilding2DOptions.Offset, ortoDatasBuilding2DOptions.Width, ortoDatasBuilding2DOptions.Reduce, squared: true);
            if(ortoDatas == null)
            {
                return null;
            }

            UniqueReference result = ortoDatasFile.AddValue(ortoDatas);
            return result;
        }

        public static async Task<UniqueReference> AddValue(this OrtoDatasFile ortoDatasFile, OrtoRange ortoRange, OrtoDatasOrtoRangeOptions ortoDatasOrtoRangeOptions = null)
        {
            if (ortoDatasFile == null || ortoRange == null)
            {
                return null;
            }

            if (ortoDatasOrtoRangeOptions == null)
            {
                ortoDatasOrtoRangeOptions = new OrtoDatasOrtoRangeOptions();
            }

            OrtoDatas ortoDatas = await Create.OrtoDatas(ortoRange, ortoDatasOrtoRangeOptions.Years, ortoDatasOrtoRangeOptions.Scale, ortoDatasOrtoRangeOptions.Reduce);
            if (ortoDatas == null)
            {
                return null;
            }

            UniqueReference result = ortoDatasFile.AddValue(ortoDatas);
            return result;
        }
    }
}
