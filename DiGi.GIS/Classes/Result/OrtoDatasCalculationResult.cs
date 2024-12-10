using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasCalculationResult : Building2DExternalReferenceUniqueResult
    {
        public OrtoDatasCalculationResult(InstanceRelatedExternalReference reference)
            :base(reference)
        {

        }

        public OrtoDatasCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public OrtoDatasCalculationResult(OrtoDatasCalculationResult ortoDatasCalculationResult)
            : base(ortoDatasCalculationResult)
        {

        }
    }
}
