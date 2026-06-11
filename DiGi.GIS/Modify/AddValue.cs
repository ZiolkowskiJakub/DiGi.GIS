using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        /// <summary>
        /// Asynchronously adds a value to the specified OrtoDatasFile based on building data and provided options.
        /// </summary>
        /// <param name="ortoDatasFile">The target file where the generated OrtoDatas value will be added.</param>
        /// <param name="building2D">The 2D building object used as a source for creating the OrtoDatas.</param>
        /// <param name="ortoDatasBuilding2DOptions">Optional settings to configure how the OrtoDatas are generated from the building data.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the unique reference of the added value, or null if the input parameters were null or the creation process failed.</returns>
        public static async Task<UniqueReference?> AddValue(this OrtoDatasFile? ortoDatasFile, Building2D? building2D, OrtoDatasBuilding2DOptions? ortoDatasBuilding2DOptions = null)
        {
            if (ortoDatasFile == null || building2D == null)
            {
                return null;
            }

            ortoDatasBuilding2DOptions ??= new OrtoDatasBuilding2DOptions();

            OrtoDatas? ortoDatas = await Create.OrtoDatas(building2D, ortoDatasBuilding2DOptions.Years, ortoDatasBuilding2DOptions.Offset, ortoDatasBuilding2DOptions.Width, ortoDatasBuilding2DOptions.Reduce, squared: true);
            if (ortoDatas == null)
            {
                return null;
            }

            UniqueReference? result = ortoDatasFile.AddValue(ortoDatas);
            return result;
        }

        /// <summary>
        /// Asynchronously adds a value to the specified OrtoDatasFile based on range data and provided options.
        /// </summary>
        /// <param name="ortoDatasFile">The target file where the generated OrtoDatas value will be added.</param>
        /// <param name="ortoRange">The range object used as a source for creating the OrtoDatas.</param>
        /// <param name="ortoDatasOrtoRangeOptions">Optional settings to configure how the OrtoDatas are generated from the range data.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the unique reference of the added value, or null if the input parameters were null or the creation process failed.</returns>
        public static async Task<UniqueReference?> AddValue(this OrtoDatasFile? ortoDatasFile, OrtoRange? ortoRange, OrtoDatasOrtoRangeOptions? ortoDatasOrtoRangeOptions = null)
        {
            if (ortoDatasFile == null || ortoRange == null)
            {
                return null;
            }

            ortoDatasOrtoRangeOptions ??= new OrtoDatasOrtoRangeOptions();

            OrtoDatas? ortoDatas = await Create.OrtoDatas(ortoRange, ortoDatasOrtoRangeOptions.Years, ortoDatasOrtoRangeOptions.Scale, ortoDatasOrtoRangeOptions.Reduce);
            if (ortoDatas == null)
            {
                return null;
            }

            UniqueReference? result = ortoDatasFile.AddValue(ortoDatas);
            return result;
        }
    }
}