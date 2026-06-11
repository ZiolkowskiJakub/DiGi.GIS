using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="OT_KatIstnienia"/> enumeration value to its corresponding <see cref="BuildingPhase"/> value.
        /// </summary>
        /// <param name="oT_KatIstnienia">The source <see cref="OT_KatIstnienia"/> value to convert.</param>
        /// <returns>The equivalent <see cref="BuildingPhase"/> value.</returns>
        public static BuildingPhase ToDiGi(this OT_KatIstnienia oT_KatIstnienia)
        {
            return oT_KatIstnienia switch
            {
                OT_KatIstnienia.nieczynny => BuildingPhase.unoccupied,
                OT_KatIstnienia.zniszczony => BuildingPhase.destroyed,
                OT_KatIstnienia.eksploatowany => BuildingPhase.occupied,
                OT_KatIstnienia.w_budowie => BuildingPhase.under_construction,
                _ => throw new NotImplementedException(),
            };
        }
    }
}