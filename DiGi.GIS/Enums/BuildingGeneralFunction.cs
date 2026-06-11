using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the general function of a building.
    /// </summary>
    public enum BuildingGeneralFunction
    {
        /// <summary>
        /// Office buildings.
        /// </summary>
        [Description("office buildings")] office_buildings,

        /// <summary>
        /// Commercial and service buildings.
        /// </summary>
        [Description("commercial and service buildings")] commercial_service_buildings,

        /// <summary>
        /// Residential buildings.
        /// </summary>
        [Description("residential buildings")] residential_buildings,

        /// <summary>
        /// Buildings for education, science, culture, and sports.
        /// </summary>
        [Description("buildings for education, science, culture, and sports")] buildings_for_education_science_culture_and_sports,

        /// <summary>
        /// Agricultural production, service, and utility buildings.
        /// </summary>
        [Description("agricultural production, service, and utility buildings")] agricultural_production_service_utility_buildings,

        /// <summary>
        /// Industrial buildings.
        /// </summary>
        [Description("industrial buildings")] industrial_buildings,

        /// <summary>
        /// Hospital buildings and other healthcare buildings.
        /// </summary>
        [Description("hospital buildings and other healthcare buildings")] hospital_and_healthcare_buildings,

        /// <summary>
        /// Transport and communication buildings.
        /// </summary>
        [Description("transport and communication buildings")] transport_and_communication_buildings,

        /// <summary>
        /// Other non-residential buildings.
        /// </summary>
        [Description("other non-residential buildings")] other_non_residential_buildings,

        /// <summary>
        /// Tanks, silos, and storage buildings.
        /// </summary>
        [Description("tanks, silos, and storage buildings")] tanks_silos_and_storage_buildings,
    }
}