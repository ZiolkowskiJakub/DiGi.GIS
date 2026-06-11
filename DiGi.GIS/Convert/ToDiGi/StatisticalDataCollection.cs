using DiGi.BDL.Classes;
using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="UnitYearlyValues"/> instance to a <see cref="StatisticalDataCollection"/>.
        /// </summary>
        /// <param name="unitYearlyValues">The yearly values for the unit to be converted.</param>
        /// <returns>A <see cref="StatisticalDataCollection"/> containing the data, or <c>null</c> if the input is null or a valid unit code cannot be created.</returns>
        public static StatisticalDataCollection? ToDiGi(this UnitYearlyValues? unitYearlyValues)
        {
            UnitCode? unitCode = Create.UnitCode(unitYearlyValues?.unitId);
            if (unitCode == null)
            {
                return null;
            }

            StatisticalDataCollection? result = new(System.Guid.NewGuid(), unitCode);
            result.AddRange(unitYearlyValues);

            return result;
        }
    }
}