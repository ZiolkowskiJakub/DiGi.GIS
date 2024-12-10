using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<UniqueReference> AddValue(this OrtoDatasFile ortoDatasFile, Building2D builidng2D, OrtoDatasOptions ortoDatasOptions = null)
        {
            if (ortoDatasFile == null || builidng2D == null)
            {
                return null;
            }

            if(ortoDatasOptions == null)
            {
                ortoDatasOptions = new OrtoDatasOptions();
            }

            OrtoDatas ortoDatas = await Create.OrtoDatas(builidng2D, ortoDatasOptions.Years, ortoDatasOptions.Offset, ortoDatasOptions.Width, ortoDatasOptions.Reduce);
            if(ortoDatas == null)
            {
                return null;
            }

            UniqueReference result = ortoDatasFile.AddValue(ortoDatas);
            return result;
        }
    }
}
