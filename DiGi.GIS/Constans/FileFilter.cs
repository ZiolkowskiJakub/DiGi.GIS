namespace DiGi.GIS.Constans
{
    public static class FileFilter
    {
        public static Core.IO.Classes.FileFilter GISModelFile { get; } = Core.IO.Create.FileFilter(FileTypeName.GISModelFile, FileExtension.GISModelFile);
        public static Core.IO.Classes.FileFilter OrtoDatasFile { get; } = Core.IO.Create.FileFilter(FileTypeName.OrtoDatasFile, FileExtension.OrtoDatasFile);
        public static Core.IO.Classes.FileFilter YearBuiltDataFile { get; } = Core.IO.Create.FileFilter(FileTypeName.YearBuiltDatasFile, FileExtension.YearBuiltDataFile);
        public static Core.IO.Classes.FileFilter StatisticalDataCollectionFile { get; } = Core.IO.Create.FileFilter(FileTypeName.StatisticalDataCollectionFile, FileExtension.StatisticalDataCollectionFile);
        public static Core.IO.Classes.FileFilter StatisticalUnitFile { get; } = Core.IO.Create.FileFilter(FileTypeName.StatisticalUnitFile, FileExtension.StatisticalUnitFile);
        public static Core.IO.Classes.FileFilter OrtoRangeFile { get; } = Core.IO.Create.FileFilter(FileTypeName.YearBuiltDatasFile, FileExtension.OrtoRangeFile);
        public static Core.IO.Classes.FileFilter Building2DYearBuiltPredictionsFile { get; } = Core.IO.Create.FileFilter(FileTypeName.Building2DYearBuiltPredictionsFile, FileExtension.Building2DYearBuiltPredictionsFile);
    }
}
