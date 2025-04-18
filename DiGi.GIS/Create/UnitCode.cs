using DiGi.GIS.Classes;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static UnitCode UnitCode(string code)
        {
            if(code == null)
            {
                return null;
            }

            string result = code.Trim();
            if(!result.All(char.IsDigit))
            {
                return null;
            }

            while(result.Length < 12)
            {
                result += "0";
            }

            return new UnitCode(result);

        }
    }
}
