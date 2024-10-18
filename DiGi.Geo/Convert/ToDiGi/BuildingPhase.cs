using DiGi.BDOT10k.Enums;
using DiGi.Geo.Enums;
using System;

namespace DiGi.Geo
{
    public static partial class Convert
    {
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


