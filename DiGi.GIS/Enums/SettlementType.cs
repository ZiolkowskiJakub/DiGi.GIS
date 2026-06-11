using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the type of settlement.
    /// </summary>
    public enum SettlementType
    {
        /// <summary>
        /// The settlement type is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// The settlement is rural.
        /// </summary>
        [Description("Rural")] Rural,

        /// <summary>
        /// The settlement is urban.
        /// </summary>
        [Description("Urban")] Urban,
    }
}