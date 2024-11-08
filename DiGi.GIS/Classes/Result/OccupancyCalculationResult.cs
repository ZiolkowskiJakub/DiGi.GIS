﻿using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OccupancyCalculationResult : UniqueResult<Areal2D>, IGISUniqueResult
    {
        [JsonInclude, JsonPropertyName("Occupancy")]
        private int? occupancy = null;

        public OccupancyCalculationResult(int? occupancy)
            :base()
        {
            this.occupancy = occupancy;
        }

        [JsonIgnore]
        public int? Occupancy
        {
            get
            {
                return occupancy;
            }
        }
    }
}