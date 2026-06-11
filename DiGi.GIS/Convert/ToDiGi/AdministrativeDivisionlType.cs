using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="OT_RodzajJednostkiAdministracyjnej"/> value to its corresponding <see cref="AdministrativeDivisionType"/>.
        /// </summary>
        /// <param name="oT_RodzajJednostkiAdministracyjnej">The administrative unit type from the OT source.</param>
        /// <returns>The equivalent <see cref="AdministrativeDivisionType"/>.</returns>
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

        /// <summary>
        /// Converts a <see cref="StatisticalUnitType"/> value to its corresponding <see cref="AdministrativeDivisionType"/>, or null if no mapping exists.
        /// </summary>
        /// <param name="statisticalUnitType">The statistical unit type to convert.</param>
        /// <returns>The equivalent <see cref="AdministrativeDivisionType"/> if found; otherwise, null.</returns>
        public static AdministrativeDivisionType? ToDiGi(this StatisticalUnitType statisticalUnitType)
        {
            return statisticalUnitType switch
            {
                StatisticalUnitType.country => AdministrativeDivisionType.country,
                StatisticalUnitType.voivedships => AdministrativeDivisionType.voivodeship,
                StatisticalUnitType.counties => AdministrativeDivisionType.county,
                StatisticalUnitType.municipalities => AdministrativeDivisionType.municipality,
                //StatisticalUnitType. => AdministrativeDivisionType.town_in_urban_rural_municipality,
                //StatisticalUnitType. => AdministrativeDivisionType.district_or_delegation,
                _ => null,
            };
        }
    }
}