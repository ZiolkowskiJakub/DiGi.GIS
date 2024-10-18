using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum BuildingGeneralFunction
    {
        [Description("office buildings")] office_buildings,
        [Description("commercial and service buildings")] commercial_service_buildings,
        [Description("residential buildings")] residential_buildings,
        [Description("buildings for education, science, culture, and sports")] buildings_for_education_science_culture_and_sports,
        [Description("agricultural production, service, and utility buildings")] agricultural_production_service_utility_buildings,
        [Description("industrial buildings")] industrial_buildings,
        [Description("hospital buildings and other healthcare buildings")] hospital_and_healthcare_buildings,
        [Description("transport and communication buildings")] transport_and_communication_buildings,
        [Description("other non-residential buildings")] other_non_residential_buildings,
        [Description("tanks, silos, and storage buildings")] tanks_silos_and_storage_buildings,
    }
}
