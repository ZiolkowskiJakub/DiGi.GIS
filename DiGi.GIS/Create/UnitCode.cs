using DiGi.GIS.Classes;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a string representation of a unit code into a <see cref="UnitCode"/> object, ensuring it is padded to 12 digits.
        /// </summary>
        /// <param name="code">The input string containing the unit code.</param>
        /// <returns>A <see cref="UnitCode"/> instance if the input is valid and numeric; otherwise, null.</returns>
        public static UnitCode? UnitCode(string? code)
        {
            if (code == null)
            {
                return null;
            }

            string result = code.Trim();
            if (!result.All(char.IsDigit))
            {
                return null;
            }

            while (result.Length < 12)
            {
                result += "0";
            }

            return new UnitCode(result);
        }
    }
}