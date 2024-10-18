using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static BuildingGeneralFunction ToDiGi(this OT_FunOgolnaBudynku oT_FunOgolnaBudynku)
        {
            return oT_FunOgolnaBudynku switch
            {
                OT_FunOgolnaBudynku.budynki_biurowe => BuildingGeneralFunction.office_buildings,
                OT_FunOgolnaBudynku.budynki_handlowouslugowe => BuildingGeneralFunction.commercial_service_buildings,
                OT_FunOgolnaBudynku.budynki_mieszkalne => BuildingGeneralFunction.residential_buildings,
                OT_FunOgolnaBudynku.budynki_oswiaty_nauki_i_kultury_oraz_budynki_sportowe => BuildingGeneralFunction.buildings_for_education_science_culture_and_sports,
                OT_FunOgolnaBudynku.budynki_produkcyjne_uslugowe_i_gospodarcze_dla_rolnictwa => BuildingGeneralFunction.agricultural_production_service_utility_buildings,
                OT_FunOgolnaBudynku.budynki_przemyslowe => BuildingGeneralFunction.industrial_buildings,
                OT_FunOgolnaBudynku.budynki_szpitali_i_inne_budynki_opieki_zdrowotnej => BuildingGeneralFunction.hospital_and_healthcare_buildings,
                OT_FunOgolnaBudynku.budynki_transportu_i_laczności => BuildingGeneralFunction.transport_and_communication_buildings,
                OT_FunOgolnaBudynku.pozostale_budynki_niemieszkalne => BuildingGeneralFunction.other_non_residential_buildings,
                OT_FunOgolnaBudynku.zbiorniki_silosy_i_budynki_magazynowe => BuildingGeneralFunction.tanks_silos_and_storage_buildings,
                _ => throw new NotImplementedException(),
            };
        }
    }
}


