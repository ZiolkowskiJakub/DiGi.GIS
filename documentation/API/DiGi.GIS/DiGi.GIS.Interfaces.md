#### [DiGi\.GIS](index.md 'index')

## DiGi\.GIS\.Interfaces Namespace
### Interfaces

<a name='DiGi.GIS.Interfaces.IConstructionDateCalculationResult'></a>

## IConstructionDateCalculationResult Interface

Defines the contract for an object representing the result of a construction date calculation\.

```csharp
public interface IConstructionDateCalculationResult : DiGi.GIS.Interfaces.IGISGuidResult, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Derived  
↳ [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')

Implements [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult'), [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Properties

<a name='DiGi.GIS.Interfaces.IConstructionDateCalculationResult.DateTime'></a>

## IConstructionDateCalculationResult\.DateTime Property

Gets the calculated construction date and time\.

```csharp
System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.GIS.Interfaces.IDirectorySource'></a>

## IDirectorySource Interface

Defines the contract for a data source that is based on a directory\.

```csharp
internal interface IDirectorySource : DiGi.GIS.Interfaces.ISource, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')

Implements [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.GIS.Interfaces.IDirectorySource.Directory'></a>

## IDirectorySource\.Directory Property

Gets the path of the directory associated with this source\.

```csharp
string? Directory { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Interfaces.IExtractOptions'></a>

## IExtractOptions Interface

Defines the contract for extraction options used within the GIS module\.

```csharp
public interface IExtractOptions : DiGi.Core.Interfaces.IOptions, DiGi.Core.Interfaces.IObject, DiGi.GIS.Interfaces.IGISObject
```

Derived  
↳ [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions')

Implements [DiGi\.Core\.Interfaces\.IOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ioptions 'DiGi\.Core\.Interfaces\.IOptions'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')

<a name='DiGi.GIS.Interfaces.IGISGuidObject'></a>

## IGISGuidObject Interface

Defines an object that integrates both GIS uniqueness and GUID identification capabilities\.

```csharp
public interface IGISGuidObject : DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Derived  
↳ [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')  
↳ [OccupancyData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyData 'DiGi\.GIS\.Classes\.OccupancyData')  
↳ [OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')  
↳ [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')  
↳ [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData')  
↳ [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D')  
↳ [IOccupancyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IOccupancyData 'DiGi\.GIS\.Interfaces\.IOccupancyData')  
↳ [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')

Implements [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')

<a name='DiGi.GIS.Interfaces.IGISGuidObject2D'></a>

## IGISGuidObject2D Interface

Defines an object that combines the properties of a GUID\-based object and a two\-dimensional unique object within the GIS context\.

```csharp
public interface IGISGuidObject2D : DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject2D
```

Derived  
↳ [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')  
↳ [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')

Implements [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [IGISUniqueObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject2D 'DiGi\.GIS\.Interfaces\.IGISUniqueObject2D')

<a name='DiGi.GIS.Interfaces.IGISGuidResult'></a>

## IGISGuidResult Interface

Represents a result object that is uniquely identified by a GUID\.

```csharp
public interface IGISGuidResult : DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Derived  
↳ [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult')  
↳ [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')  
↳ [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')  
↳ [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')  
↳ [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')  
↳ [IConstructionDateCalculationResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult')

Implements [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')

<a name='DiGi.GIS.Interfaces.IGISObject'></a>

## IGISObject Interface

Defines the basic properties and behaviors for a Geographic Information System \(GIS\) object\.

```csharp
public interface IGISObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult')  
↳ [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')  
↳ [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')  
↳ [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')  
↳ [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')  
↳ [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')  
↳ [Building2DYearBuiltPredictionsFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictionsFile')  
↳ [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')  
↳ [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions')  
↳ [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')  
↳ [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')  
↳ [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')  
↳ [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')  
↳ [GISModelFileManager](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileManager 'DiGi\.GIS\.Classes\.GISModelFileManager')  
↳ [IndexData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexData 'DiGi\.GIS\.Classes\.IndexData')  
↳ [IndexDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexDataFile 'DiGi\.GIS\.Classes\.IndexDataFile')  
↳ [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')  
↳ [OccupancyData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyData 'DiGi\.GIS\.Classes\.OccupancyData')  
↳ [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')  
↳ [OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')  
↳ [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile')  
↳ [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')  
↳ [OrtoRangeFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeFile 'DiGi\.GIS\.Classes\.OrtoRangeFile')  
↳ [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source')  
↳ [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData')  
↳ [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')  
↳ [StatisticalDataCollectionFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollectionFile 'DiGi\.GIS\.Classes\.StatisticalDataCollectionFile')  
↳ [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')  
↳ [StatisticalUnitFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnitFile 'DiGi\.GIS\.Classes\.StatisticalUnitFile')  
↳ [StatisticalYearlyData&lt;T&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')  
↳ [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')  
↳ [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt')  
↳ [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData')  
↳ [YearBuiltDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile 'DiGi\.GIS\.Classes\.YearBuiltDataFile')  
↳ [IConstructionDateCalculationResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult')  
↳ [IDirectorySource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IDirectorySource 'DiGi\.GIS\.Interfaces\.IDirectorySource')  
↳ [IExtractOptions](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IExtractOptions 'DiGi\.GIS\.Interfaces\.IExtractOptions')  
↳ [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject')  
↳ [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D')  
↳ [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult')  
↳ [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject')  
↳ [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')  
↳ [IGISUniqueObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject2D 'DiGi\.GIS\.Interfaces\.IGISUniqueObject2D')  
↳ [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult')  
↳ [IOccupancyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IOccupancyData 'DiGi\.GIS\.Interfaces\.IOccupancyData')  
↳ [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource')  
↳ [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')  
↳ [IStatisticalYearlyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData')  
↳ [IStatisticalYearlyData&lt;T&gt;](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_ 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>')  
↳ [IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt')  
↳ [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.GIS.Interfaces.IGISRelation'></a>

## IGISRelation Interface

Defines the contract for GIS relation objects, extending the base relation functionality\.

```csharp
public interface IGISRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [AdministrativeAreal2DAdministrativeAreal2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DAdministrativeAreal2DsRelation')  
↳ [AdministrativeAreal2DBuilding2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DBuilding2DsRelation')  
↳ [AdministrativeAreal2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResultRelation')  
↳ [AdministrativeAreal2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DOccupancyCalculationResultRelation')  
↳ [AdministrativeAreal2DStatisticalUnitsCalculcationRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationRelation')  
↳ [Building2DConstructionDateCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResultRelation')  
↳ [Building2DExternalReferenceUniqueResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation 'DiGi\.GIS\.Classes\.Building2DExternalReferenceUniqueResultRelation')  
↳ [Building2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResultRelation')  
↳ [Building2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DOccupancyCalculationResultRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.GIS.Interfaces.IGISSerializableObject'></a>

## IGISSerializableObject Interface

Defines a contract for objects that are both GIS\-compatible and serializable\.

```csharp
public interface IGISSerializableObject : DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult')  
↳ [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')  
↳ [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')  
↳ [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')  
↳ [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')  
↳ [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')  
↳ [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')  
↳ [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')  
↳ [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')  
↳ [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')  
↳ [IndexData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexData 'DiGi\.GIS\.Classes\.IndexData')  
↳ [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')  
↳ [OccupancyData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyData 'DiGi\.GIS\.Classes\.OccupancyData')  
↳ [OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')  
↳ [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')  
↳ [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source')  
↳ [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData')  
↳ [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')  
↳ [StatisticalYearlyData&lt;T&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')  
↳ [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt')  
↳ [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData')  
↳ [IConstructionDateCalculationResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult')  
↳ [IDirectorySource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IDirectorySource 'DiGi\.GIS\.Interfaces\.IDirectorySource')  
↳ [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject')  
↳ [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D')  
↳ [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult')  
↳ [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')  
↳ [IGISUniqueObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject2D 'DiGi\.GIS\.Interfaces\.IGISUniqueObject2D')  
↳ [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult')  
↳ [IOccupancyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IOccupancyData 'DiGi\.GIS\.Interfaces\.IOccupancyData')  
↳ [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource')  
↳ [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')  
↳ [IStatisticalYearlyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData')  
↳ [IStatisticalYearlyData&lt;T&gt;](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_ 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>')  
↳ [IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt')  
↳ [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.GIS.Interfaces.IGISUniqueObject'></a>

## IGISUniqueObject Interface

Defines a contract for an object that is both uniquely identifiable and serializable within the GIS context\.

```csharp
public interface IGISUniqueObject : DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult')  
↳ [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')  
↳ [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')  
↳ [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')  
↳ [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')  
↳ [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')  
↳ [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')  
↳ [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')  
↳ [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')  
↳ [IndexData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexData 'DiGi\.GIS\.Classes\.IndexData')  
↳ [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')  
↳ [OccupancyData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyData 'DiGi\.GIS\.Classes\.OccupancyData')  
↳ [OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')  
↳ [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')  
↳ [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source')  
↳ [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')  
↳ [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData')  
↳ [IConstructionDateCalculationResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult')  
↳ [IDirectorySource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IDirectorySource 'DiGi\.GIS\.Interfaces\.IDirectorySource')  
↳ [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject')  
↳ [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D')  
↳ [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult')  
↳ [IGISUniqueObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject2D 'DiGi\.GIS\.Interfaces\.IGISUniqueObject2D')  
↳ [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult')  
↳ [IOccupancyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IOccupancyData 'DiGi\.GIS\.Interfaces\.IOccupancyData')  
↳ [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource')  
↳ [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')

Implements [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.GIS.Interfaces.IGISUniqueObject2D'></a>

## IGISUniqueObject2D Interface

Defines the contract for a unique object that exists within a two\-dimensional geographic information system \(GIS\) coordinate space\.

```csharp
public interface IGISUniqueObject2D : DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')  
↳ [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')  
↳ [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D')

Implements [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.GIS.Interfaces.IGISUniqueResult'></a>

## IGISUniqueResult Interface

Defines the contract for a unique GIS result object, inheriting from both [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult') and [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')\.

```csharp
public interface IGISUniqueResult : DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Derived  
↳ [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult')  
↳ [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')  
↳ [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')  
↳ [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')  
↳ [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')  
↳ [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')  
↳ [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')  
↳ [IConstructionDateCalculationResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult')  
↳ [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult')

Implements [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')

<a name='DiGi.GIS.Interfaces.IOccupancyData'></a>

## IOccupancyData Interface

Defines the properties for occupancy data objects within the GIS system\.

```csharp
public interface IOccupancyData : DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Derived  
↳ [OccupancyData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyData 'DiGi\.GIS\.Classes\.OccupancyData')

Implements [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Properties

<a name='DiGi.GIS.Interfaces.IOccupancyData.Reference'></a>

## IOccupancyData\.Reference Property

Gets the reference identifier associated with the occupancy data\.

```csharp
string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Interfaces.ISource'></a>

## ISource Interface

Defines the contract for a source object within the GIS system\.

```csharp
public interface ISource : DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')  
↳ [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source')  
↳ [IDirectorySource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IDirectorySource 'DiGi\.GIS\.Interfaces\.IDirectorySource')

Implements [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.GIS.Interfaces.IStatisticalData'></a>

## IStatisticalData Interface

Defines the properties for an object that represents statistical data\.

```csharp
public interface IStatisticalData : DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData')  
↳ [StatisticalYearlyData&lt;T&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')  
↳ [IStatisticalYearlyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData')  
↳ [IStatisticalYearlyData&lt;T&gt;](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_ 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>')

Implements [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.GIS.Interfaces.IStatisticalData.Name'></a>

## IStatisticalData\.Name Property

Gets the name of the statistical data\.

```csharp
string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Interfaces.IStatisticalData.Reference'></a>

## IStatisticalData\.Reference Property

Gets the reference identifier associated with the statistical data\.

```csharp
string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Interfaces.IStatisticalYearlyData'></a>

## IStatisticalYearlyData Interface

Defines a contract for statistical data that is organized by year\.

```csharp
public interface IStatisticalYearlyData : DiGi.GIS.Interfaces.IStatisticalData, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [StatisticalYearlyData&lt;T&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')  
↳ [IStatisticalYearlyData&lt;T&gt;](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_ 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>')

Implements [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.GIS.Interfaces.IStatisticalYearlyData.Years'></a>

## IStatisticalYearlyData\.Years Property

Gets the collection of years available in the statistical data\.

```csharp
System.Collections.Generic.IEnumerable<short>? Years { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Interfaces.IStatisticalYearlyData_T_'></a>

## IStatisticalYearlyData\<T\> Interface

Defines a generic contract for accessing statistical data values associated with specific years\.

```csharp
public interface IStatisticalYearlyData<T> : DiGi.GIS.Interfaces.IStatisticalYearlyData, DiGi.GIS.Interfaces.IStatisticalData, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```
#### Type parameters

<a name='DiGi.GIS.Interfaces.IStatisticalYearlyData_T_.T'></a>

`T`

The type of the statistical data value\.

Derived  
↳ [StatisticalYearlyData&lt;T&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')

Implements [IStatisticalYearlyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData'), [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.GIS.Interfaces.IStatisticalYearlyData_T_.this[short]'></a>

## IStatisticalYearlyData\<T\>\.this\[short\] Property

Gets the statistical data value for the specified year\.

```csharp
T? this[short year] { get; }
```
#### Parameters

<a name='DiGi.GIS.Interfaces.IStatisticalYearlyData_T_.this[short].year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year for which to retrieve the statistical data\.

#### Property Value
[T](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_.T 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>\.T')

<a name='DiGi.GIS.Interfaces.IYearBuilt'></a>

## IYearBuilt Interface

Defines the properties for an object that represents the year a structure was built\.

```csharp
public interface IYearBuilt : DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt')

Implements [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.GIS.Interfaces.IYearBuilt.Source'></a>

## IYearBuilt\.Source Property

Gets the source description of the year built information\.

```csharp
string? Source { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Interfaces.IYearBuilt.Year'></a>

## IYearBuilt\.Year Property

Gets the year the structure was built\.

```csharp
short Year { get; }
```

#### Property Value
[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

<a name='DiGi.GIS.Interfaces.IYearBuilt.YearBuiltSource'></a>

## IYearBuilt\.YearBuiltSource Property

Gets the categorized source of the year built information\.

```csharp
DiGi.GIS.Enums.YearBuiltSource YearBuiltSource { get; }
```

#### Property Value
[YearBuiltSource](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource 'DiGi\.GIS\.Enums\.YearBuiltSource')

<a name='DiGi.GIS.Interfaces.IYearBuiltData'></a>

## IYearBuiltData Interface

Defines the properties for data representing the year a structure was built\.

```csharp
public interface IYearBuiltData : DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Derived  
↳ [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData')

Implements [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Properties

<a name='DiGi.GIS.Interfaces.IYearBuiltData.Reference'></a>

## IYearBuiltData\.Reference Property

Gets the reference identifier or description associated with the year built data\.

```csharp
string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')