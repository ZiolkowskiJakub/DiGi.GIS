namespace DiGi.GIS.Constants
{
    /// <summary>
    /// Provides a set of predefined file filters used for filtering files in the GIS module.
    /// </summary>
    public static class FileFilter
    {
        /// <summary>
        /// Gets the file filter for GIS model files.
        /// </summary>
        public static Core.IO.Classes.FileFilter GISModelFile { get; } = Core.IO.Create.FileFilter(FileTypeName.GISModelFile, FileExtension.GISModelFile);

        /// <summary>
        /// Gets the file filter for ortho data files.
        /// </summary>
        public static Core.IO.Classes.FileFilter OrtoDatasFile { get; } = Core.IO.Create.FileFilter(FileTypeName.OrtoDatasFile, FileExtension.OrtoDatasFile);

        /// <summary>
        /// Gets the file filter for year built data files.
        /// </summary>
        public static Core.IO.Classes.FileFilter YearBuiltDataFile { get; } = Core.IO.Create.FileFilter(FileTypeName.YearBuiltDatasFile, FileExtension.YearBuiltDataFile);

        /// <summary>
        /// Gets the file filter for statistical data collection files.
        /// </summary>
        public static Core.IO.Classes.FileFilter StatisticalDataCollectionFile { get; } = Core.IO.Create.FileFilter(FileTypeName.StatisticalDataCollectionFile, FileExtension.StatisticalDataCollectionFile);

        /// <summary>
        /// Gets the file filter for statistical unit files.
        /// </summary>
        public static Core.IO.Classes.FileFilter StatisticalUnitFile { get; } = Core.IO.Create.FileFilter(FileTypeName.StatisticalUnitFile, FileExtension.StatisticalUnitFile);

        /// <summary>
        /// Gets the file filter for ortho range files.
        /// </summary>
        public static Core.IO.Classes.FileFilter OrtoRangeFile { get; } = Core.IO.Create.FileFilter(FileTypeName.YearBuiltDatasFile, FileExtension.OrtoRangeFile);

        /// <summary>
        /// Gets the file filter for building 2D year built predictions files.
        /// </summary>
        public static Core.IO.Classes.FileFilter Building2DYearBuiltPredictionsFile { get; } = Core.IO.Create.FileFilter(FileTypeName.Building2DYearBuiltPredictionsFile, FileExtension.Building2DYearBuiltPredictionsFile);
    }
}