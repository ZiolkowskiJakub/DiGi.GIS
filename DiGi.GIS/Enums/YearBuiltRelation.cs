using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies how a stored year relates to the true construction year.
    /// </summary>
    public enum YearBuiltRelation
    {
        /// <summary>
        /// Built exactly in the stored year.
        /// </summary>
        [Description("Exact")] Exact = 0,

        /// <summary>
        /// Already present in the oldest photo; the construction year is at or before the stored year.
        /// </summary>
        [Description("AtOrBefore")] AtOrBefore = 1,

        /// <summary>
        /// Not yet present in the newest photo; the construction year is after the stored year.
        /// </summary>
        [Description("After")] After = 2,
    }
}
