using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the source from which the year built information was obtained.
    /// </summary>
    public enum YearBuiltSource
    {
        /// <summary>
        /// Indicates that the year built was provided by a user.
        /// </summary>
        [Description("User")] User,

        /// <summary>
        /// Indicates that the year built was generated via a prediction model.
        /// </summary>
        [Description("Prediction")] Prediction,

        /// <summary>
        /// Indicates that the year built was obtained from another source.
        /// </summary>
        [Description("Other")] Other,
    }
}