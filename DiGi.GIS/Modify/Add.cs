using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<UniqueReference> AddValue(this OrtoDatasFile ortoDatasFile, Building2D builidng2D, OrtoDataOptions ortoDataOptions = null)
        {
            if (ortoDatasFile == null || builidng2D == null)
            {
                return null;
            }

            if(ortoDataOptions == null)
            {
                ortoDataOptions = new OrtoDataOptions();
            }

            OrtoDatas ortoDatas = await Create.OrtoDatas(builidng2D, ortoDataOptions.Years, ortoDataOptions.Offset, ortoDataOptions.Width);
            if(ortoDatas == null)
            {
                return null;
            }

            UniqueReference result = ortoDatasFile.AddValue(ortoDatas);
            return result;
        }
    }
}
