using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static AdministrativeDivisionType ToDiGi(this OT_RodzajJednostkiAdministracyjnej oT_RodzajJednostkiAdministracyjnej)
        {
            return oT_RodzajJednostkiAdministracyjnej switch
            {
                OT_RodzajJednostkiAdministracyjnej.panstwo => AdministrativeDivisionType.country,
                OT_RodzajJednostkiAdministracyjnej.wojewodztwo => AdministrativeDivisionType.voivodeship,
                OT_RodzajJednostkiAdministracyjnej.powiat => AdministrativeDivisionType.county,
                OT_RodzajJednostkiAdministracyjnej.gmina => AdministrativeDivisionType.municipality,
                OT_RodzajJednostkiAdministracyjnej.miasto_w_gminie_miejsko_wiejskiej => AdministrativeDivisionType.town_in_urban_rural_municipality,
                OT_RodzajJednostkiAdministracyjnej.dzielnica_lub_delegatura => AdministrativeDivisionType.district_or_delegation,
                _ => throw new NotImplementedException(),
            };
        }
    }
}


