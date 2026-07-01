#### [DiGi\.GIS](index.md 'index')

## DiGi\.GIS\.Classes Namespace
### Classes

<a name='DiGi.GIS.Classes.AdministrativeAreal2D'></a>

## AdministrativeAreal2D Class

Represents an abstract base class for administrative areas in a 2D coordinate system\.

```csharp
public abstract class AdministrativeAreal2D : DiGi.GIS.Classes.Areal2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') → [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') → AdministrativeAreal2D

Derived  
↳ [AdministrativeDivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeDivision 'DiGi\.GIS\.Classes\.AdministrativeDivision')  
↳ [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D)'></a>

## AdministrativeAreal2D\(AdministrativeAreal2D\) Constructor

Initializes a new instance of the AdministrativeAreal2D class as a copy of another AdministrativeAreal2D\.

```csharp
public AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeArea2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D).administrativeArea2D'></a>

`administrativeArea2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The source administrative area instance to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D,string)'></a>

## AdministrativeAreal2D\(AdministrativeAreal2D, string\) Constructor

Initializes a new instance of the AdministrativeAreal2D class as a copy of another AdministrativeAreal2D with a new code\.

```csharp
public AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeArea2D, string? code);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D,string).administrativeArea2D'></a>

`administrativeArea2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The source administrative area instance to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The new identification code to assign to the copied administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,string)'></a>

## AdministrativeAreal2D\(Guid, string, string, PolygonalFace2D, string\) Constructor

Initializes a new instance of the AdministrativeAreal2D class\.

```csharp
public AdministrativeAreal2D(System.Guid guid, string? reference, string? code, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, string? name);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string associated with the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identification code of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,string).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face defining the geometry of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2D\(JsonObject\) Constructor

Initializes a new instance of the AdministrativeAreal2D class from a JSON object\.

```csharp
public AdministrativeAreal2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.AdministrativeAreal2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the administrative area data\.
### Properties

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.Code'></a>

## AdministrativeAreal2D\.Code Property

Gets the code of the administrative area\.

```csharp
public string? Code { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.AdministrativeAreal2D.Name'></a>

## AdministrativeAreal2D\.Name Property

Gets the name of the administrative area\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation'></a>

## AdministrativeAreal2DAdministrativeAreal2DsRelation Class

Represents a one\-to\-many bidirectional relation between administrative areal 2D entities\.

```csharp
public class AdministrativeAreal2DAdministrativeAreal2DsRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.GIS.Classes.AdministrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2D>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → AdministrativeAreal2DAdministrativeAreal2DsRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_)'></a>

## AdministrativeAreal2DAdministrativeAreal2DsRelation\(AdministrativeAreal2D, IEnumerable\<AdministrativeAreal2D\>\) Constructor

Initializes a new instance of the [AdministrativeAreal2DAdministrativeAreal2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DAdministrativeAreal2DsRelation') class\.

```csharp
public AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D administrativeAreal2D, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.AdministrativeAreal2D> administrativeAreal2Ds);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The parent administrative areal 2D entity\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_).administrativeAreal2Ds'></a>

`administrativeAreal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of related administrative areal 2D entities\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation)'></a>

## AdministrativeAreal2DAdministrativeAreal2DsRelation\(AdministrativeAreal2DAdministrativeAreal2DsRelation\) Constructor

Initializes a new instance of the [AdministrativeAreal2DAdministrativeAreal2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DAdministrativeAreal2DsRelation') class by copying an existing relation\.

```csharp
public AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation administrativeAreal2DAdministrativeAreal2DsRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation).administrativeAreal2DAdministrativeAreal2DsRelation'></a>

`administrativeAreal2DAdministrativeAreal2DsRelation` [AdministrativeAreal2DAdministrativeAreal2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DAdministrativeAreal2DsRelation')

The source relation instance to copy\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DAdministrativeAreal2DsRelation\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DAdministrativeAreal2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DAdministrativeAreal2DsRelation') class from a JSON object\.

```csharp
public AdministrativeAreal2DAdministrativeAreal2DsRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DAdministrativeAreal2DsRelation.AdministrativeAreal2DAdministrativeAreal2DsRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the relation data\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation'></a>

## AdministrativeAreal2DBuilding2DsRelation Class

Represents a one\-to\-many bidirectional relation between an administrative areal 2D and building 2D entities\.

```csharp
public class AdministrativeAreal2DBuilding2DsRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.GIS.Classes.AdministrativeAreal2D, DiGi.GIS.Classes.Building2D>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → AdministrativeAreal2DBuilding2DsRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## AdministrativeAreal2DBuilding2DsRelation\(AdministrativeAreal2D, IEnumerable\<Building2D\>\) Constructor

Initializes a new instance of the [AdministrativeAreal2DBuilding2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DBuilding2DsRelation') class\.

```csharp
public AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D administrativeAreal2D, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D> building2Ds);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative areal 2D entity\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of building 2D entities\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation)'></a>

## AdministrativeAreal2DBuilding2DsRelation\(AdministrativeAreal2DBuilding2DsRelation\) Constructor

Initializes a new instance of the [AdministrativeAreal2DBuilding2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DBuilding2DsRelation') class by copying an existing relation\.

```csharp
public AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation).administrativeAreal2DBuilding2DsRelation'></a>

`administrativeAreal2DBuilding2DsRelation` [AdministrativeAreal2DBuilding2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DBuilding2DsRelation')

The source relation to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DBuilding2DsRelation\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DBuilding2DsRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DBuilding2DsRelation') class from a JSON object\.

```csharp
public AdministrativeAreal2DBuilding2DsRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DBuilding2DsRelation.AdministrativeAreal2DBuilding2DsRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the relation data\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult'></a>

## AdministrativeAreal2DExternalReferenceGuidResult Class

Represents a result object that provides the external reference GUID for an administrative areal 2D entity\.

```csharp
public abstract class AdministrativeAreal2DExternalReferenceGuidResult : DiGi.Core.Classes.ExternalReferenceGuidResult<DiGi.GIS.Classes.AdministrativeAreal2D, DiGi.Core.Classes.InstanceRelatedExternalReference>, DiGi.GIS.Interfaces.IGISGuidResult, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → [DiGi\.Core\.Classes\.ExternalReferenceGuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.externalreferenceguidresult-2 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.externalreferenceguidresult-2 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\`2')[DiGi\.Core\.Classes\.InstanceRelatedExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.instancerelatedexternalreference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.externalreferenceguidresult-2 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\`2') → AdministrativeAreal2DExternalReferenceGuidResult

Implements [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult'), [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult.AdministrativeAreal2DExternalReferenceGuidResult(DiGi.Core.Classes.InstanceRelatedExternalReference)'></a>

## AdministrativeAreal2DExternalReferenceGuidResult\(InstanceRelatedExternalReference\) Constructor

Initializes a new instance of the [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult') class using the specified external reference\.

```csharp
public AdministrativeAreal2DExternalReferenceGuidResult(DiGi.Core.Classes.InstanceRelatedExternalReference reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult.AdministrativeAreal2DExternalReferenceGuidResult(DiGi.Core.Classes.InstanceRelatedExternalReference).reference'></a>

`reference` [DiGi\.Core\.Classes\.InstanceRelatedExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.instancerelatedexternalreference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')

The instance\-related external reference to initialize with\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult.AdministrativeAreal2DExternalReferenceGuidResult(DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult)'></a>

## AdministrativeAreal2DExternalReferenceGuidResult\(AdministrativeAreal2DExternalReferenceGuidResult\) Constructor

Initializes a new instance of the [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult') class by copying another result object\.

```csharp
public AdministrativeAreal2DExternalReferenceGuidResult(DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult administrativeAreal2DExternalReferenceGuidResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult.AdministrativeAreal2DExternalReferenceGuidResult(DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult).administrativeAreal2DExternalReferenceGuidResult'></a>

`administrativeAreal2DExternalReferenceGuidResult` [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult')

The source result object to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult.AdministrativeAreal2DExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DExternalReferenceGuidResult\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DExternalReferenceGuidResult') class from the specified JSON object\.

```csharp
public AdministrativeAreal2DExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DExternalReferenceGuidResult.AdministrativeAreal2DExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for the result\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult'></a>

## AdministrativeAreal2DGeometryCalculationResult Class

Represents the result of a geometry calculation for an administrative areal 2D object\.

```csharp
public class AdministrativeAreal2DGeometryCalculationResult : DiGi.Core.Classes.GuidResult<DiGi.GIS.Classes.AdministrativeAreal2D>, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → AdministrativeAreal2DGeometryCalculationResult

Implements [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double)'></a>

## AdministrativeAreal2DGeometryCalculationResult\(BoundingBox2D, Rectangle2D, Point2D, Point2D, double, double, double\) Constructor

Initializes a new instance of the AdministrativeAreal2DGeometryCalculationResult class

```csharp
public AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox, DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle, DiGi.Geometry.Planar.Classes.Point2D? centroid, DiGi.Geometry.Planar.Classes.Point2D? internalPoint, double thinnessRatio, double rectangularity, double area);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).boundingBox'></a>

`boundingBox` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).rectangle'></a>

`rectangle` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle representation of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).centroid'></a>

`centroid` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The centroid point of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).internalPoint'></a>

`internalPoint` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The internal point within the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).thinnessRatio'></a>

`thinnessRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thinness ratio of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).rectangularity'></a>

`rectangularity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rectangularity measure of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double).area'></a>

`area` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The area of the administrative area\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult)'></a>

## AdministrativeAreal2DGeometryCalculationResult\(AdministrativeAreal2DGeometryCalculationResult\) Constructor

Initializes a new instance of the AdministrativeAreal2DGeometryCalculationResult class as a copy

```csharp
public AdministrativeAreal2DGeometryCalculationResult(DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult).administrativeAreal2DGeometryCalculationResult'></a>

`administrativeAreal2DGeometryCalculationResult` [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')

The source result object to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DGeometryCalculationResult\(JsonObject\) Constructor

Initializes a new instance of the AdministrativeAreal2DGeometryCalculationResult class from a JSON object

```csharp
public AdministrativeAreal2DGeometryCalculationResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.AdministrativeAreal2DGeometryCalculationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.Area'></a>

## AdministrativeAreal2DGeometryCalculationResult\.Area Property

Gets the area of the administrative area

```csharp
public double Area { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.BoundingBox'></a>

## AdministrativeAreal2DGeometryCalculationResult\.BoundingBox Property

Gets the bounding box of the administrative area

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.Centroid'></a>

## AdministrativeAreal2DGeometryCalculationResult\.Centroid Property

Gets the centroid point of the administrative area

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Centroid { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.InternalPoint'></a>

## AdministrativeAreal2DGeometryCalculationResult\.InternalPoint Property

Gets the internal point within the administrative area

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? InternalPoint { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.Rectangle2D'></a>

## AdministrativeAreal2DGeometryCalculationResult\.Rectangle2D Property

Gets the rectangle representation of the administrative area

```csharp
public DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.Rectangularity'></a>

## AdministrativeAreal2DGeometryCalculationResult\.Rectangularity Property

Gets the rectangularity measure of the administrative area

```csharp
public double Rectangularity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult.ThinnessRatio'></a>

## AdministrativeAreal2DGeometryCalculationResult\.ThinnessRatio Property

Gets the thinness ratio of the administrative area

```csharp
public double ThinnessRatio { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation'></a>

## AdministrativeAreal2DGeometryCalculationResultRelation Class

Represents a one\-to\-one directional relation between an administrative areal 2D object and its geometry calculation result\.

```csharp
public class AdministrativeAreal2DGeometryCalculationResultRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.GIS.Classes.AdministrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → AdministrativeAreal2DGeometryCalculationResultRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult)'></a>

## AdministrativeAreal2DGeometryCalculationResultRelation\(AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult\) Constructor

Initializes a new instance of the [AdministrativeAreal2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResultRelation') class using the specified source and target objects\.

```csharp
public AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D administrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The source administrative areal 2D object\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult).administrativeAreal2DGeometryCalculationResult'></a>

`administrativeAreal2DGeometryCalculationResult` [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')

The target geometry calculation result object\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation)'></a>

## AdministrativeAreal2DGeometryCalculationResultRelation\(AdministrativeAreal2DGeometryCalculationResultRelation\) Constructor

Initializes a new instance of the [AdministrativeAreal2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResultRelation') class by copying another relation instance\.

```csharp
public AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation building2DGeometryCalculationResultRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation).building2DGeometryCalculationResultRelation'></a>

`building2DGeometryCalculationResultRelation` [AdministrativeAreal2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResultRelation')

The existing relation instance to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DGeometryCalculationResultRelation\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResultRelation') class from a JSON object\.

```csharp
public AdministrativeAreal2DGeometryCalculationResultRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResultRelation.AdministrativeAreal2DGeometryCalculationResultRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the relation data\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation'></a>

## AdministrativeAreal2DOccupancyCalculationResultRelation Class

Represents a one\-to\-one directional relation between an administrative areal 2D and an occupancy calculation result\.

```csharp
public class AdministrativeAreal2DOccupancyCalculationResultRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.GIS.Classes.AdministrativeAreal2D, DiGi.GIS.Classes.OccupancyCalculationResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → AdministrativeAreal2DOccupancyCalculationResultRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.OccupancyCalculationResult)'></a>

## AdministrativeAreal2DOccupancyCalculationResultRelation\(AdministrativeAreal2D, OccupancyCalculationResult\) Constructor

Initializes a new instance of the [AdministrativeAreal2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DOccupancyCalculationResultRelation') class\.

```csharp
public AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D administrativeAreal2D, DiGi.GIS.Classes.OccupancyCalculationResult occupancyCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.OccupancyCalculationResult).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative areal 2D entity\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.OccupancyCalculationResult).occupancyCalculationResult'></a>

`occupancyCalculationResult` [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')

The occupancy calculation result entity\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation)'></a>

## AdministrativeAreal2DOccupancyCalculationResultRelation\(AdministrativeAreal2DOccupancyCalculationResultRelation\) Constructor

Initializes a new instance of the [AdministrativeAreal2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DOccupancyCalculationResultRelation') class by copying another instance\.

```csharp
public AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation administrativeAreal2DOccupancyCalculationResultRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation).administrativeAreal2DOccupancyCalculationResultRelation'></a>

`administrativeAreal2DOccupancyCalculationResultRelation` [AdministrativeAreal2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DOccupancyCalculationResultRelation')

The existing relation instance to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DOccupancyCalculationResultRelation\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DOccupancyCalculationResultRelation') class from a JSON object\.

```csharp
public AdministrativeAreal2DOccupancyCalculationResultRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DOccupancyCalculationResultRelation.AdministrativeAreal2DOccupancyCalculationResultRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing relation data\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationRelation Class

Represents a one\-to\-one directional relation between an administrative areal 2D object and its statistical units calculation result\.

```csharp
public class AdministrativeAreal2DStatisticalUnitsCalculcationRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.GIS.Classes.AdministrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → AdministrativeAreal2DStatisticalUnitsCalculcationRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult)'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationRelation\(AdministrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult\) Constructor

Initializes a new instance of the [AdministrativeAreal2DStatisticalUnitsCalculcationRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationRelation') class with specified source and target objects\.

```csharp
public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2D administrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitsCalculcationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The source administrative areal 2D object\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult).administrativeAreal2DStatisticalUnitsCalculcationResult'></a>

`administrativeAreal2DStatisticalUnitsCalculcationResult` [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')

The target statistical units calculation result object\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation)'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationRelation\(AdministrativeAreal2DStatisticalUnitsCalculcationRelation\) Constructor

Initializes a new instance of the [AdministrativeAreal2DStatisticalUnitsCalculcationRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationRelation') class by copying another instance\.

```csharp
public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation administrativeAreal2DStatisticalUnitsCalculcationRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation).administrativeAreal2DStatisticalUnitsCalculcationRelation'></a>

`administrativeAreal2DStatisticalUnitsCalculcationRelation` [AdministrativeAreal2DStatisticalUnitsCalculcationRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationRelation')

The existing relation instance to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationRelation\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DStatisticalUnitsCalculcationRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationRelation') class from a JSON object\.

```csharp
public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationRelation.AdministrativeAreal2DStatisticalUnitsCalculcationRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing relation data\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationResult Class

Represents the result of calculating statistical units for a 2D administrative area\.

```csharp
public class AdministrativeAreal2DStatisticalUnitsCalculcationResult : DiGi.Core.Classes.GuidResult<DiGi.GIS.Classes.AdministrativeAreal2D>, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → AdministrativeAreal2DStatisticalUnitsCalculcationResult

Implements [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.AdministrativeAreal2DStatisticalUnitsCalculcationResult(DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult)'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationResult\(AdministrativeAreal2DStatisticalUnitsCalculcationResult\) Constructor

Initializes a new instance of the [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult') class by copying another result instance\.

```csharp
public AdministrativeAreal2DStatisticalUnitsCalculcationResult(DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitsCalculcationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.AdministrativeAreal2DStatisticalUnitsCalculcationResult(DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult).administrativeAreal2DStatisticalUnitsCalculcationResult'></a>

`administrativeAreal2DStatisticalUnitsCalculcationResult` [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')

The source result instance to copy from\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.AdministrativeAreal2DStatisticalUnitsCalculcationResult(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_)'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationResult\(IEnumerable\<StatisticalUnit\>\) Constructor

Initializes a new instance of the [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult') class using a collection of statistical units\.

```csharp
public AdministrativeAreal2DStatisticalUnitsCalculcationResult(System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.StatisticalUnit> statisticalUnits);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.AdministrativeAreal2DStatisticalUnitsCalculcationResult(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_).statisticalUnits'></a>

`statisticalUnits` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of statistical units to assign\.

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.AdministrativeAreal2DStatisticalUnitsCalculcationResult(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationResult\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult') class from a JSON object\.

```csharp
public AdministrativeAreal2DStatisticalUnitsCalculcationResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.AdministrativeAreal2DStatisticalUnitsCalculcationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult.StatisticalUnits'></a>

## AdministrativeAreal2DStatisticalUnitsCalculcationResult\.StatisticalUnits Property

Gets or sets the collection of statistical units associated with this calculation result\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.StatisticalUnit> StatisticalUnits { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Classes.AdministrativeDivision'></a>

## AdministrativeDivision Class

Represents an administrative division with a specific type, extending AdministrativeAreal2D

```csharp
public class AdministrativeDivision : DiGi.GIS.Classes.AdministrativeAreal2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') → [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') → [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D') → AdministrativeDivision
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision)'></a>

## AdministrativeDivision\(AdministrativeDivision\) Constructor

Initializes a new instance of the AdministrativeDivision class as a deep copy of another AdministrativeDivision

```csharp
public AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision? administrativeDivision);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision).administrativeDivision'></a>

`administrativeDivision` [AdministrativeDivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeDivision 'DiGi\.GIS\.Classes\.AdministrativeDivision')

The AdministrativeDivision to copy, or null to create an empty instance

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision,string)'></a>

## AdministrativeDivision\(AdministrativeDivision, string\) Constructor

Initializes a new instance of the AdministrativeDivision class as a copy of another AdministrativeDivision with a new code

```csharp
public AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision? administrativeDivision, string? code);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision,string).administrativeDivision'></a>

`administrativeDivision` [AdministrativeDivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeDivision 'DiGi\.GIS\.Classes\.AdministrativeDivision')

The AdministrativeDivision to copy, or null to create an empty instance

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(DiGi.GIS.Classes.AdministrativeDivision,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The new code to assign to the copied division

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string)'></a>

## AdministrativeDivision\(Guid, string, string, PolygonalFace2D, AdministrativeDivisionType, string\) Constructor

Initializes a new instance of the AdministrativeDivision class with all required properties

```csharp
public AdministrativeDivision(System.Guid guid, string? reference, string? code, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, DiGi.GIS.Enums.AdministrativeDivisionType administrativeDivisionType, string name);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the division

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code for the division

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The 2D polygonal face geometry

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string).administrativeDivisionType'></a>

`administrativeDivisionType` [AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType')

The type of the administrative division

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeDivisionType,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the division

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeDivision\(JsonObject\) Constructor

Initializes a new instance of the AdministrativeDivision class from a JSON object

```csharp
public AdministrativeDivision(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivision(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the division data
### Properties

<a name='DiGi.GIS.Classes.AdministrativeDivision.AdministrativeDivisionType'></a>

## AdministrativeDivision\.AdministrativeDivisionType Property

Gets the type of this administrative division \(e\.g\., country, voivodeship, county, municipality\)

```csharp
public DiGi.GIS.Enums.AdministrativeDivisionType AdministrativeDivisionType { get; }
```

#### Property Value
[AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType')

<a name='DiGi.GIS.Classes.AdministrativeSubdivision'></a>

## AdministrativeSubdivision Class

Represents an administrative subdivision \(e\.g\., city, village, colony\) with optional occupancy data, extending AdministrativeAreal2D

```csharp
public class AdministrativeSubdivision : DiGi.GIS.Classes.AdministrativeAreal2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') → [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') → [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D') → AdministrativeSubdivision
### Constructors

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision)'></a>

## AdministrativeSubdivision\(AdministrativeSubdivision\) Constructor

Initializes a new instance of the AdministrativeSubdivision class as a deep copy of another AdministrativeSubdivision

```csharp
public AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision? administrativeSubdivision);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision).administrativeSubdivision'></a>

`administrativeSubdivision` [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The AdministrativeSubdivision to copy, or null to create an empty instance

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision,string)'></a>

## AdministrativeSubdivision\(AdministrativeSubdivision, string\) Constructor

Initializes a new instance of the AdministrativeSubdivision class as a copy of another AdministrativeSubdivision with a new code

```csharp
public AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision? administrativeSubdivision, string? code);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision,string).administrativeSubdivision'></a>

`administrativeSubdivision` [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The AdministrativeSubdivision to copy, or null to create an empty instance

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(DiGi.GIS.Classes.AdministrativeSubdivision,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The new code to assign to the copied subdivision

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_)'></a>

## AdministrativeSubdivision\(Guid, string, string, PolygonalFace2D, AdministrativeSubdivisionType, string, Nullable\<uint\>\) Constructor

Initializes a new instance of the AdministrativeSubdivision class with all required properties

```csharp
public AdministrativeSubdivision(System.Guid guid, string? reference, string code, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, DiGi.GIS.Enums.AdministrativeSubdivisionType administrativeSubdivisionType, string? name, System.Nullable<uint> occupancy);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the subdivision

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A code for the subdivision

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The 2D polygonal face geometry

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).administrativeSubdivisionType'></a>

`administrativeSubdivisionType` [AdministrativeSubdivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeSubdivisionType 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')

The type of the administrative subdivision

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional name for the subdivision

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Guid,string,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.GIS.Enums.AdministrativeSubdivisionType,string,System.Nullable_uint_).occupancy'></a>

`occupancy` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional maximum occupancy value

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeSubdivision\(JsonObject\) Constructor

Initializes a new instance of the AdministrativeSubdivision class from a JSON object

```csharp
public AdministrativeSubdivision(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivision(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the subdivision data
### Properties

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.AdministrativeSubdivisionType'></a>

## AdministrativeSubdivision\.AdministrativeSubdivisionType Property

Gets the type of this administrative subdivision \(e\.g\., city, village, colony, hamlet\)

```csharp
public DiGi.GIS.Enums.AdministrativeSubdivisionType AdministrativeSubdivisionType { get; }
```

#### Property Value
[AdministrativeSubdivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeSubdivisionType 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')

<a name='DiGi.GIS.Classes.AdministrativeSubdivision.Occupancy'></a>

## AdministrativeSubdivision\.Occupancy Property

Gets the maximum occupancy of the subdivision

```csharp
public System.Nullable<uint> Occupancy { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.Areal2D'></a>

## Areal2D Class

Represents a two\-dimensional areal object within the GIS coordinate system\.

```csharp
public abstract class Areal2D : DiGi.GIS.Classes.GISGuidObject2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') → Areal2D

Derived  
↳ [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')  
↳ [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')
### Constructors

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(DiGi.GIS.Classes.Areal2D)'></a>

## Areal2D\(Areal2D\) Constructor

Initializes a new instance of the [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') class by copying an existing [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') object\.

```csharp
public Areal2D(DiGi.GIS.Classes.Areal2D? areal2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(DiGi.GIS.Classes.Areal2D).areal2D'></a>

`areal2D` [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D')

The source areal object to copy from\.

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Areal2D\(Guid, string, PolygonalFace2D\) Constructor

Initializes a new instance of the [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') class\.

```csharp
public Areal2D(System.Guid guid, string? reference, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string associated with the object\.

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face that defines the geometry of the area\.

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(System.Text.Json.Nodes.JsonObject)'></a>

## Areal2D\(JsonObject\) Constructor

Initializes a new instance of the [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') class using data from a JSON object\.

```csharp
public Areal2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Areal2D.Areal2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the initialization data\.
### Properties

<a name='DiGi.GIS.Classes.Areal2D.PolygonalFace2D'></a>

## Areal2D\.PolygonalFace2D Property

Gets the polygonal face associated with this areal object\.

```csharp
public DiGi.Geometry.Planar.Classes.PolygonalFace2D? PolygonalFace2D { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

<a name='DiGi.GIS.Classes.Building2D'></a>

## Building2D Class

Represents a 2D building with storey count, phase, and functional classification, extending Areal2D

```csharp
public class Building2D : DiGi.GIS.Classes.Areal2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') → [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D') → Building2D
### Constructors

<a name='DiGi.GIS.Classes.Building2D.Building2D(DiGi.GIS.Classes.Building2D)'></a>

## Building2D\(Building2D\) Constructor

Initializes a new instance of the Building2D class as a deep copy of another Building2D

```csharp
public Building2D(DiGi.GIS.Classes.Building2D building2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2D.Building2D(DiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The Building2D to copy, or null to create an empty instance

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_)'></a>

## Building2D\(Guid, string, PolygonalFace2D, ushort, Nullable\<BuildingPhase\>, Nullable\<BuildingGeneralFunction\>, IEnumerable\<BuildingSpecificFunction\>\) Constructor

Initializes a new instance of the Building2D class with all required properties

```csharp
public Building2D(System.Guid guid, string? reference, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, ushort storeys, System.Nullable<DiGi.GIS.Enums.BuildingPhase> buildingPhase, System.Nullable<DiGi.GIS.Enums.BuildingGeneralFunction> buildingGeneralFunction, System.Collections.Generic.IEnumerable<DiGi.GIS.Enums.BuildingSpecificFunction> buildingSpecificFunctions);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the building

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The 2D polygonal face geometry

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).storeys'></a>

`storeys` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The number of storeys

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).buildingPhase'></a>

`buildingPhase` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[BuildingPhase](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingPhase 'DiGi\.GIS\.Enums\.BuildingPhase')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The current phase of the building

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).buildingGeneralFunction'></a>

`buildingGeneralFunction` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[BuildingGeneralFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingGeneralFunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The general function of the building

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Guid,string,DiGi.Geometry.Planar.Classes.PolygonalFace2D,ushort,System.Nullable_DiGi.GIS.Enums.BuildingPhase_,System.Nullable_DiGi.GIS.Enums.BuildingGeneralFunction_,System.Collections.Generic.IEnumerable_DiGi.GIS.Enums.BuildingSpecificFunction_).buildingSpecificFunctions'></a>

`buildingSpecificFunctions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[BuildingSpecificFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingSpecificFunction 'DiGi\.GIS\.Enums\.BuildingSpecificFunction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The specific functions of the building

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Text.Json.Nodes.JsonObject)'></a>

## Building2D\(JsonObject\) Constructor

Initializes a new instance of the Building2D class from a JSON object

```csharp
public Building2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2D.Building2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the building data
### Properties

<a name='DiGi.GIS.Classes.Building2D.BuildingGeneralFunction'></a>

## Building2D\.BuildingGeneralFunction Property

Gets the general function of the building \(e\.g\., residential, commercial, industrial, educational\)

```csharp
public System.Nullable<DiGi.GIS.Enums.BuildingGeneralFunction> BuildingGeneralFunction { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[BuildingGeneralFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingGeneralFunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.Building2D.BuildingPhase'></a>

## Building2D\.BuildingPhase Property

Gets the current phase of the building \(e\.g\., occupied, unoccupied, under construction, destroyed\)

```csharp
public System.Nullable<DiGi.GIS.Enums.BuildingPhase> BuildingPhase { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[BuildingPhase](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingPhase 'DiGi\.GIS\.Enums\.BuildingPhase')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.Building2D.BuildingSpecificFunctions'></a>

## Building2D\.BuildingSpecificFunctions Property

Gets the set of specific functions for this building \(e\.g\., single\_family\_building, hospital, school\)

```csharp
public System.Collections.Generic.HashSet<DiGi.GIS.Enums.BuildingSpecificFunction> BuildingSpecificFunctions { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[BuildingSpecificFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingSpecificFunction 'DiGi\.GIS\.Enums\.BuildingSpecificFunction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.GIS.Classes.Building2D.Storeys'></a>

## Building2D\.Storeys Property

Gets the number of storeys in the building

```csharp
public ushort Storeys { get; }
```

#### Property Value
[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')
### Methods

<a name='DiGi.GIS.Classes.Building2D.Clone()'></a>

## Building2D\.Clone\(\) Method

Creates a deep copy of this Building2D instance

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new Building2D instance with the same data

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult'></a>

## Building2DConstructionDateCalculationResult Class

Represents the result of a construction date calculation for a 2D building\.

```csharp
public abstract class Building2DConstructionDateCalculationResult : DiGi.Core.Classes.GuidResult<DiGi.GIS.Classes.Building2D>, DiGi.GIS.Interfaces.IConstructionDateCalculationResult, DiGi.GIS.Interfaces.IGISGuidResult, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → Building2DConstructionDateCalculationResult

Derived  
↳ [Building2DMachineLearningConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DMachineLearningConstructionDateCalculationResult')  
↳ [Building2DManualConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DManualConstructionDateCalculationResult')

Implements [IConstructionDateCalculationResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult'), [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult'), [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult()'></a>

## Building2DConstructionDateCalculationResult\(\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult') class\.

```csharp
public Building2DConstructionDateCalculationResult();
```

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DConstructionDateCalculationResult)'></a>

## Building2DConstructionDateCalculationResult\(Building2DConstructionDateCalculationResult\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult') class by copying another result instance\.

```csharp
public Building2DConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DConstructionDateCalculationResult? building2DConstructionDateCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DConstructionDateCalculationResult).building2DConstructionDateCalculationResult'></a>

`building2DConstructionDateCalculationResult` [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')

The source calculation result to copy from\.

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult(System.DateTime)'></a>

## Building2DConstructionDateCalculationResult\(DateTime\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult') class with a specified date and time\.

```csharp
public Building2DConstructionDateCalculationResult(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The construction date and time\.

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DConstructionDateCalculationResult\(JsonObject\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult') class from a JSON object\.

```csharp
public Building2DConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.Building2DConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResult.DateTime'></a>

## Building2DConstructionDateCalculationResult\.DateTime Property

Gets the calculated construction date and time\.

```csharp
public System.DateTime DateTime { get; }
```

Implements [DateTime](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IConstructionDateCalculationResult.DateTime 'DiGi\.GIS\.Interfaces\.IConstructionDateCalculationResult\.DateTime')

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation'></a>

## Building2DConstructionDateCalculationResultRelation Class

Represents a one\-to\-many directional relation between a Building2D entity and its associated Building2DConstructionDateCalculationResult entities\.

```csharp
public class Building2DConstructionDateCalculationResultRelation : DiGi.Core.Relation.Classes.OneToManyDirectionalRelation<DiGi.GIS.Classes.Building2D, DiGi.GIS.Classes.Building2DConstructionDateCalculationResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2') → Building2DConstructionDateCalculationResultRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2DConstructionDateCalculationResult_)'></a>

## Building2DConstructionDateCalculationResultRelation\(Building2D, IEnumerable\<Building2DConstructionDateCalculationResult\>\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResultRelation') class with a specific building and a collection of calculation results\.

```csharp
public Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2D building2D, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2DConstructionDateCalculationResult> constructionDateCalculationResults);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2DConstructionDateCalculationResult_).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The parent Building2D entity\.

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2DConstructionDateCalculationResult_).constructionDateCalculationResults'></a>

`constructionDateCalculationResults` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of associated construction date calculation results\.

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation)'></a>

## Building2DConstructionDateCalculationResultRelation\(Building2DConstructionDateCalculationResultRelation\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResultRelation') class by copying another instance\.

```csharp
public Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation building2DConstructionDateCalculationResultRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation).building2DConstructionDateCalculationResultRelation'></a>

`building2DConstructionDateCalculationResultRelation` [Building2DConstructionDateCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResultRelation')

The existing relation instance to copy from\.

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DConstructionDateCalculationResultRelation\(JsonObject\) Constructor

Initializes a new instance of the [Building2DConstructionDateCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResultRelation') class from a JSON object\.

```csharp
public Building2DConstructionDateCalculationResultRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DConstructionDateCalculationResultRelation.Building2DConstructionDateCalculationResultRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing relation data\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult'></a>

## Building2DExternalReferenceGuidResult Class

Represents a result object containing the GUID for an external reference of a 2D building\.

```csharp
public abstract class Building2DExternalReferenceGuidResult : DiGi.Core.Classes.ExternalReferenceGuidResult<DiGi.GIS.Classes.Building2D, DiGi.Core.Classes.InstanceRelatedExternalReference>, DiGi.GIS.Interfaces.IGISGuidResult, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → [DiGi\.Core\.Classes\.ExternalReferenceGuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.externalreferenceguidresult-2 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.externalreferenceguidresult-2 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\`2')[DiGi\.Core\.Classes\.InstanceRelatedExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.instancerelatedexternalreference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.externalreferenceguidresult-2 'DiGi\.Core\.Classes\.ExternalReferenceGuidResult\`2') → Building2DExternalReferenceGuidResult

Implements [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult'), [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult.Building2DExternalReferenceGuidResult(DiGi.Core.Classes.InstanceRelatedExternalReference)'></a>

## Building2DExternalReferenceGuidResult\(InstanceRelatedExternalReference\) Constructor

Initializes a new instance of the [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult') class using the specified external reference\.

```csharp
public Building2DExternalReferenceGuidResult(DiGi.Core.Classes.InstanceRelatedExternalReference reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult.Building2DExternalReferenceGuidResult(DiGi.Core.Classes.InstanceRelatedExternalReference).reference'></a>

`reference` [DiGi\.Core\.Classes\.InstanceRelatedExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.instancerelatedexternalreference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')

The external reference used to initialize the result\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult.Building2DExternalReferenceGuidResult(DiGi.GIS.Classes.Building2DExternalReferenceGuidResult)'></a>

## Building2DExternalReferenceGuidResult\(Building2DExternalReferenceGuidResult\) Constructor

Initializes a new instance of the [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult') class by copying another instance\.

```csharp
public Building2DExternalReferenceGuidResult(DiGi.GIS.Classes.Building2DExternalReferenceGuidResult building2DExternalReferenceGuidResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult.Building2DExternalReferenceGuidResult(DiGi.GIS.Classes.Building2DExternalReferenceGuidResult).building2DExternalReferenceGuidResult'></a>

`building2DExternalReferenceGuidResult` [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')

The source result instance to copy from\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult.Building2DExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DExternalReferenceGuidResult\(JsonObject\) Constructor

Initializes a new instance of the [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult') class from the specified JSON object\.

```csharp
public Building2DExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DExternalReferenceGuidResult.Building2DExternalReferenceGuidResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation'></a>

## Building2DExternalReferenceUniqueResultRelation Class

Represents a one\-to\-many bidirectional relation between a Building2D entity and its unique external reference results\.

```csharp
public class Building2DExternalReferenceUniqueResultRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.GIS.Classes.Building2D, DiGi.GIS.Classes.Building2DExternalReferenceGuidResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → Building2DExternalReferenceUniqueResultRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2DExternalReferenceGuidResult_)'></a>

## Building2DExternalReferenceUniqueResultRelation\(Building2D, IEnumerable\<Building2DExternalReferenceGuidResult\>\) Constructor

Initializes a new instance of the [Building2DExternalReferenceUniqueResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation 'DiGi\.GIS\.Classes\.Building2DExternalReferenceUniqueResultRelation') class\.

```csharp
public Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2D building2D, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2DExternalReferenceGuidResult> building2DExternalReferenceUniqueResults);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2DExternalReferenceGuidResult_).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building entity associated with this relation\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2DExternalReferenceGuidResult_).building2DExternalReferenceUniqueResults'></a>

`building2DExternalReferenceUniqueResults` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique external reference results associated with the building\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation)'></a>

## Building2DExternalReferenceUniqueResultRelation\(Building2DExternalReferenceUniqueResultRelation\) Constructor

Initializes a new instance of the [Building2DExternalReferenceUniqueResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation 'DiGi\.GIS\.Classes\.Building2DExternalReferenceUniqueResultRelation') class by copying an existing relation\.

```csharp
public Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation ortoDatasCalculationResultRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation).ortoDatasCalculationResultRelation'></a>

`ortoDatasCalculationResultRelation` [Building2DExternalReferenceUniqueResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation 'DiGi\.GIS\.Classes\.Building2DExternalReferenceUniqueResultRelation')

The source relation to copy from\.

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DExternalReferenceUniqueResultRelation\(JsonObject\) Constructor

Initializes a new instance of the [Building2DExternalReferenceUniqueResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation 'DiGi\.GIS\.Classes\.Building2DExternalReferenceUniqueResultRelation') class from a JSON object\.

```csharp
public Building2DExternalReferenceUniqueResultRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DExternalReferenceUniqueResultRelation.Building2DExternalReferenceUniqueResultRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the relation data\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult'></a>

## Building2DGeometryCalculationResult Class

Represents the result of geometry calculations for a 2D building\.

```csharp
public class Building2DGeometryCalculationResult : DiGi.Core.Classes.GuidResult<DiGi.GIS.Classes.Building2D>, DiGi.GIS.Interfaces.IGISGuidResult, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → Building2DGeometryCalculationResult

Implements [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult'), [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double)'></a>

## Building2DGeometryCalculationResult\(BoundingBox2D, Rectangle2D, Point2D, Point2D, double, double, double, double, double, double\) Constructor

Initializes a new instance of the Building2DGeometryCalculationResult class\.

```csharp
public Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox, DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle, DiGi.Geometry.Planar.Classes.Point2D? centroid, DiGi.Geometry.Planar.Classes.Point2D? internalPoint, double thinnessRatio, double rectangularity, double area, double perimeter, double rectangularThinnessRatio, double isoperimetricRatio);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).boundingBox'></a>

`boundingBox` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).rectangle'></a>

`rectangle` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle representation of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).centroid'></a>

`centroid` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The centroid point of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).internalPoint'></a>

`internalPoint` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The internal point within the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).thinnessRatio'></a>

`thinnessRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thinness ratio of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).rectangularity'></a>

`rectangularity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rectangularity measure of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).area'></a>

`area` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The area of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).perimeter'></a>

`perimeter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The perimeter of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).rectangularThinnessRatio'></a>

`rectangularThinnessRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rectangular thinness ratio of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double,double,double,double,double,double).isoperimetricRatio'></a>

`isoperimetricRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The isoperimetric ratio of the building\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Building2DGeometryCalculationResult\(Building2DGeometryCalculationResult\) Constructor

Initializes a new instance of the Building2DGeometryCalculationResult class as a copy\.

```csharp
public Building2DGeometryCalculationResult(DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(DiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The source result object to copy from\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DGeometryCalculationResult\(JsonObject\) Constructor

Initializes a new instance of the Building2DGeometryCalculationResult class from a JSON object\.

```csharp
public Building2DGeometryCalculationResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the calculation result data\.
### Properties

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Area'></a>

## Building2DGeometryCalculationResult\.Area Property

Gets the area of the building\.

```csharp
public double Area { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.BoundingBox'></a>

## Building2DGeometryCalculationResult\.BoundingBox Property

Gets the bounding box of the building\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Centroid'></a>

## Building2DGeometryCalculationResult\.Centroid Property

Gets the centroid point of the building\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Centroid { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.InternalPoint'></a>

## Building2DGeometryCalculationResult\.InternalPoint Property

Gets the internal point within the building\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? InternalPoint { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.IsoperimetricRatio'></a>

## Building2DGeometryCalculationResult\.IsoperimetricRatio Property

Gets the isoperimetric ratio of the building\.

```csharp
public double IsoperimetricRatio { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Perimeter'></a>

## Building2DGeometryCalculationResult\.Perimeter Property

Gets the perimeter of the building\.

```csharp
public double Perimeter { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Rectangle2D'></a>

## Building2DGeometryCalculationResult\.Rectangle2D Property

Gets the rectangle representation of the building\.

```csharp
public DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.Rectangularity'></a>

## Building2DGeometryCalculationResult\.Rectangularity Property

Gets the rectangularity measure of the building\.

```csharp
public double Rectangularity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.RectangularThinnessRatio'></a>

## Building2DGeometryCalculationResult\.RectangularThinnessRatio Property

Gets the rectangular thinness ratio of the building\.

```csharp
public double RectangularThinnessRatio { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResult.ThinnessRatio'></a>

## Building2DGeometryCalculationResult\.ThinnessRatio Property

Gets the thinness ratio of the building\.

```csharp
public double ThinnessRatio { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation'></a>

## Building2DGeometryCalculationResultRelation Class

Represents a one\-to\-one directional relation between a Building2D entity and its associated Building2DGeometryCalculationResult\.

```csharp
public class Building2DGeometryCalculationResultRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.GIS.Classes.Building2D, DiGi.GIS.Classes.Building2DGeometryCalculationResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → Building2DGeometryCalculationResultRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Building2DGeometryCalculationResultRelation\(Building2D, Building2DGeometryCalculationResult\) Constructor

Initializes a new instance of the [Building2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResultRelation') class with the specified building and geometry calculation result\.

```csharp
public Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2D building2D, DiGi.GIS.Classes.Building2DGeometryCalculationResult building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DGeometryCalculationResult).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The source Building2D entity\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The target Building2DGeometryCalculationResult entity\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation)'></a>

## Building2DGeometryCalculationResultRelation\(Building2DGeometryCalculationResultRelation\) Constructor

Initializes a new instance of the [Building2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResultRelation') class by copying an existing relation\.

```csharp
public Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation building2DGeometryCalculationResultRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation).building2DGeometryCalculationResultRelation'></a>

`building2DGeometryCalculationResultRelation` [Building2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResultRelation')

The source relation to copy from\.

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DGeometryCalculationResultRelation\(JsonObject\) Constructor

Initializes a new instance of the [Building2DGeometryCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResultRelation') class from a JSON object\.

```csharp
public Building2DGeometryCalculationResultRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DGeometryCalculationResultRelation.Building2DGeometryCalculationResultRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the relation data\.

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult'></a>

## Building2DMachineLearningConstructionDateCalculationResult Class

Represents the result of a construction date calculation for a 2D building using machine learning\.

```csharp
public class Building2DMachineLearningConstructionDateCalculationResult : DiGi.GIS.Classes.Building2DConstructionDateCalculationResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult') → Building2DMachineLearningConstructionDateCalculationResult
### Constructors

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult()'></a>

## Building2DMachineLearningConstructionDateCalculationResult\(\) Constructor

Initializes a new instance of the [Building2DMachineLearningConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DMachineLearningConstructionDateCalculationResult') class\.

```csharp
public Building2DMachineLearningConstructionDateCalculationResult();
```

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult)'></a>

## Building2DMachineLearningConstructionDateCalculationResult\(Building2DMachineLearningConstructionDateCalculationResult\) Constructor

Initializes a new instance of the [Building2DMachineLearningConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DMachineLearningConstructionDateCalculationResult') class by copying another instance\.

```csharp
public Building2DMachineLearningConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult building2DMachineLearningConstructionDateCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult).building2DMachineLearningConstructionDateCalculationResult'></a>

`building2DMachineLearningConstructionDateCalculationResult` [Building2DMachineLearningConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DMachineLearningConstructionDateCalculationResult')

The source instance to copy from\.

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult(System.DateTime)'></a>

## Building2DMachineLearningConstructionDateCalculationResult\(DateTime\) Constructor

Initializes a new instance of the [Building2DMachineLearningConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DMachineLearningConstructionDateCalculationResult') class with the specified date and time\.

```csharp
public Building2DMachineLearningConstructionDateCalculationResult(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The construction date and time\.

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DMachineLearningConstructionDateCalculationResult\(JsonObject\) Constructor

Initializes a new instance of the [Building2DMachineLearningConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DMachineLearningConstructionDateCalculationResult') class from the specified JSON object\.

```csharp
public Building2DMachineLearningConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DMachineLearningConstructionDateCalculationResult.Building2DMachineLearningConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the calculation result data\.

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult'></a>

## Building2DManualConstructionDateCalculationResult Class

Represents the result of a manual construction date calculation for a 2D building\.

```csharp
public class Building2DManualConstructionDateCalculationResult : DiGi.GIS.Classes.Building2DConstructionDateCalculationResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult') → Building2DManualConstructionDateCalculationResult
### Constructors

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult()'></a>

## Building2DManualConstructionDateCalculationResult\(\) Constructor

Initializes a new instance of the [Building2DManualConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DManualConstructionDateCalculationResult') class\.

```csharp
public Building2DManualConstructionDateCalculationResult();
```

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult)'></a>

## Building2DManualConstructionDateCalculationResult\(Building2DManualConstructionDateCalculationResult\) Constructor

Initializes a new instance of the [Building2DManualConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DManualConstructionDateCalculationResult') class by copying an existing instance\.

```csharp
public Building2DManualConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult building2DManualConstructionDateCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult(DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult).building2DManualConstructionDateCalculationResult'></a>

`building2DManualConstructionDateCalculationResult` [Building2DManualConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DManualConstructionDateCalculationResult')

The source instance to copy from\.

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult(System.DateTime)'></a>

## Building2DManualConstructionDateCalculationResult\(DateTime\) Constructor

Initializes a new instance of the [Building2DManualConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DManualConstructionDateCalculationResult') class using the specified date and time\.

```csharp
public Building2DManualConstructionDateCalculationResult(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time to be used for the construction date calculation result\.

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DManualConstructionDateCalculationResult\(JsonObject\) Constructor

Initializes a new instance of the [Building2DManualConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DManualConstructionDateCalculationResult') class from a JSON object\.

```csharp
public Building2DManualConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DManualConstructionDateCalculationResult.Building2DManualConstructionDateCalculationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the construction date calculation result data\.

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation'></a>

## Building2DOccupancyCalculationResultRelation Class

Represents a one\-to\-one directional relation between a Building2D entity and an OccupancyCalculationResult entity\.

```csharp
public class Building2DOccupancyCalculationResultRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.GIS.Classes.Building2D, DiGi.GIS.Classes.OccupancyCalculationResult>, DiGi.GIS.Interfaces.IGISRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → Building2DOccupancyCalculationResultRelation

Implements [IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OccupancyCalculationResult)'></a>

## Building2DOccupancyCalculationResultRelation\(Building2D, OccupancyCalculationResult\) Constructor

Initializes a new instance of the [Building2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DOccupancyCalculationResultRelation') class with the specified building and occupancy calculation result\.

```csharp
public Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2D building2D, DiGi.GIS.Classes.OccupancyCalculationResult occupancyCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OccupancyCalculationResult).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The Building2D entity involved in the relation\.

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OccupancyCalculationResult).occupancyCalculationResult'></a>

`occupancyCalculationResult` [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')

The OccupancyCalculationResult entity involved in the relation\.

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation)'></a>

## Building2DOccupancyCalculationResultRelation\(Building2DOccupancyCalculationResultRelation\) Constructor

Initializes a new instance of the [Building2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DOccupancyCalculationResultRelation') class by copying an existing relation\.

```csharp
public Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation building2DOccupancyCalculationResultRelation);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation).building2DOccupancyCalculationResultRelation'></a>

`building2DOccupancyCalculationResultRelation` [Building2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DOccupancyCalculationResultRelation')

The source relation to copy from\.

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DOccupancyCalculationResultRelation\(JsonObject\) Constructor

Initializes a new instance of the [Building2DOccupancyCalculationResultRelation](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation 'DiGi\.GIS\.Classes\.Building2DOccupancyCalculationResultRelation') class using a JSON object\.

```csharp
public Building2DOccupancyCalculationResultRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DOccupancyCalculationResultRelation.Building2DOccupancyCalculationResultRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the relation data\.

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions'></a>

## Building2DYearBuiltPredictions Class

Stores and manages predicted year built data for buildings, extending SerializableObject

```csharp
public class Building2DYearBuiltPredictions : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Building2DYearBuiltPredictions
### Constructors

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(DiGi.GIS.Classes.Building2DYearBuiltPredictions)'></a>

## Building2DYearBuiltPredictions\(Building2DYearBuiltPredictions\) Constructor

Initializes a new instance of the Building2DYearBuiltPredictions class by copying another instance

```csharp
public Building2DYearBuiltPredictions(DiGi.GIS.Classes.Building2DYearBuiltPredictions? building2DYearBuiltPredictions);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(DiGi.GIS.Classes.Building2DYearBuiltPredictions).building2DYearBuiltPredictions'></a>

`building2DYearBuiltPredictions` [Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')

The instance to copy

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltPrediction_)'></a>

## Building2DYearBuiltPredictions\(string, IEnumerable\<YearBuiltPrediction\>\) Constructor

Initializes a new instance of the Building2DYearBuiltPredictions class with a reference and a collection of year built predictions

```csharp
public Building2DYearBuiltPredictions(string? reference, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.YearBuiltPrediction>? yearBuiltPredictions);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltPrediction_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltPrediction_).yearBuiltPredictions'></a>

`yearBuiltPredictions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of YearBuiltPrediction objects

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DYearBuiltPredictions\(JsonObject\) Constructor

Initializes a new instance of the Building2DYearBuiltPredictions class from a JSON object

```csharp
public Building2DYearBuiltPredictions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Building2DYearBuiltPredictions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from
### Properties

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Reference'></a>

## Building2DYearBuiltPredictions\.Reference Property

Gets the reference string for this building

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.this[ushort]'></a>

## Building2DYearBuiltPredictions\.this\[ushort\] Property

Gets the year built prediction for the specified year\.

```csharp
public DiGi.GIS.Classes.YearBuiltPrediction? this[ushort year] { get; }
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.this[ushort].year'></a>

`year` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The year to look up\.

#### Property Value
[YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction')

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.Years'></a>

## Building2DYearBuiltPredictions\.Years Property

Gets the list of years that have year built predictions

```csharp
public System.Collections.Generic.List<ushort>? Years { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.GetYearBuiltPrediction(ushort)'></a>

## Building2DYearBuiltPredictions\.GetYearBuiltPrediction\(ushort\) Method

Gets the year built prediction for the specified year, or the nearest lower year prediction if an exact match is not found\.

```csharp
public DiGi.GIS.Classes.YearBuiltPrediction? GetYearBuiltPrediction(ushort year);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictions.GetYearBuiltPrediction(ushort).year'></a>

`year` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The year to look up\.

#### Returns
[YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction')  
A [YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction') object if a matching or lower value is found; otherwise, null\.

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile'></a>

## Building2DYearBuiltPredictionsFile Class

Represents a file storage for Building2DYearBuiltPredictions data

```csharp
public class Building2DYearBuiltPredictionsFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.GIS.Classes.Building2DYearBuiltPredictions>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → Building2DYearBuiltPredictionsFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.Building2DYearBuiltPredictionsFile(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile)'></a>

## Building2DYearBuiltPredictionsFile\(Building2DYearBuiltPredictionsFile\) Constructor

Initializes a new instance of the Building2DYearBuiltPredictionsFile class by copying another instance

```csharp
public Building2DYearBuiltPredictionsFile(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile? building2DYearBuiltPredictionsFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.Building2DYearBuiltPredictionsFile(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile).building2DYearBuiltPredictionsFile'></a>

`building2DYearBuiltPredictionsFile` [Building2DYearBuiltPredictionsFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictionsFile')

The instance to copy

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.Building2DYearBuiltPredictionsFile(string)'></a>

## Building2DYearBuiltPredictionsFile\(string\) Constructor

Initializes a new instance of the Building2DYearBuiltPredictionsFile class with the specified file path

```csharp
public Building2DYearBuiltPredictionsFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.Building2DYearBuiltPredictionsFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.Building2DYearBuiltPredictionsFile(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DYearBuiltPredictionsFile\(JsonObject\) Constructor

Initializes a new instance of the Building2DYearBuiltPredictionsFile class from a JSON object

```csharp
public Building2DYearBuiltPredictionsFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.Building2DYearBuiltPredictionsFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from
### Methods

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.GetUniqueReference(DiGi.GIS.Classes.Building2DYearBuiltPredictions)'></a>

## Building2DYearBuiltPredictionsFile\.GetUniqueReference\(Building2DYearBuiltPredictions\) Method

Gets the unique reference for the specified building year built predictions

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.GIS.Classes.Building2DYearBuiltPredictions? building2DYearBuiltPredictions);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.GetUniqueReference(DiGi.GIS.Classes.Building2DYearBuiltPredictions).building2DYearBuiltPredictions'></a>

`building2DYearBuiltPredictions` [Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')

The building year built predictions to get the reference for

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference associated with the provided object, or null if the object is null\.

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.GetUniqueReference(string)'></a>

## Building2DYearBuiltPredictionsFile\.GetUniqueReference\(string\) Method

Gets the unique reference for the specified reference string

```csharp
public static DiGi.Core.Classes.UniqueReference? GetUniqueReference(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile.GetUniqueReference(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference created from the reference string, or null if the reference is null\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver'></a>

## BuildingShapeSolver Class

Provides functionality to solve and determine the geometric shape of a building based on its 2D representation\.

```csharp
public class BuildingShapeSolver : DiGi.Core.Interfaces.IOneToOneSolver<DiGi.GIS.Classes.Building2D, DiGi.GIS.Enums.BuildingShape>, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → BuildingShapeSolver

Implements [DiGi\.Core\.Interfaces\.IOneToOneSolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')[BuildingShape](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingShape 'DiGi\.GIS\.Enums\.BuildingShape')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Constructors

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double)'></a>

## BuildingShapeSolver\(double, double, double, double, double, double, double, double\) Constructor

Initializes a new instance of the [BuildingShapeSolver](DiGi.GIS.Classes.md#DiGi.GIS.Classes.BuildingShapeSolver 'DiGi\.GIS\.Classes\.BuildingShapeSolver') class\.

```csharp
public BuildingShapeSolver(double offset=1.0, double thinnessRatio=0.9, double microTolerance=1E-06, double macroTolerance=0.001, double areaFactor=0.5, double aspectRatioFactor=0.3, double rectangleThinnessRatioFactor=0.2, double scoreFactor=0.7);
```
#### Parameters

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset value used during geometry calculations\. Must be greater than zero\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).thinnessRatio'></a>

`thinnessRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ratio threshold used to determine thinness and shape classification\. Must be within the range \(0, 1\]\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).microTolerance'></a>

`microTolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The micro\-level distance tolerance for geometric operations\. Must be greater than zero\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).macroTolerance'></a>

`macroTolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The macro\-level distance tolerance for geometric operations\. Must be greater than zero\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).areaFactor'></a>

`areaFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The weight applied to a candidate notch's normalized area when scoring notch significance\. Must be finite and non\-negative\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).aspectRatioFactor'></a>

`aspectRatioFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The weight applied to a candidate notch's aspect ratio when scoring notch significance\. Must be finite and non\-negative\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).rectangleThinnessRatioFactor'></a>

`rectangleThinnessRatioFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The weight applied to a candidate notch's rectangular thinness ratio when scoring notch significance\. Must be finite and non\-negative\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.BuildingShapeSolver(double,double,double,double,double,double,double,double).scoreFactor'></a>

`scoreFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The fraction of the highest notch score used as the cut\-off for retaining notches\. Must be within the range \(0, 1\]\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when any argument falls outside its permitted range\.
### Properties

<a name='DiGi.GIS.Classes.BuildingShapeSolver.Input'></a>

## BuildingShapeSolver\.Input Property

Gets or sets the input building geometry to be analyzed\.

```csharp
public DiGi.GIS.Classes.Building2D? Input { set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2.input 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2\.Input')

#### Property Value
[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

<a name='DiGi.GIS.Classes.BuildingShapeSolver.Output'></a>

## BuildingShapeSolver\.Output Property

Gets the determined shape of the building after solving\.

```csharp
public DiGi.GIS.Enums.BuildingShape Output { get; }
```

Implements [Output](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2.output 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2\.Output')

#### Property Value
[BuildingShape](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingShape 'DiGi\.GIS\.Enums\.BuildingShape')
### Methods

<a name='DiGi.GIS.Classes.BuildingShapeSolver.FallbackShape(bool,double,double)'></a>

## BuildingShapeSolver\.FallbackShape\(bool, double, double\) Method

Resolves the shape for a footprint whose external edge fills its bounding rectangle and produced no significant notches\.

```csharp
private DiGi.GIS.Enums.BuildingShape FallbackShape(bool hasHoles, double squareThinnessRatio, double rectangleThinnessRatio);
```
#### Parameters

<a name='DiGi.GIS.Classes.BuildingShapeSolver.FallbackShape(bool,double,double).hasHoles'></a>

`hasHoles` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the footprint encloses one or more internal edges \(courtyards\)\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.FallbackShape(bool,double,double).squareThinnessRatio'></a>

`squareThinnessRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The square thinness ratio of the external edge\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.FallbackShape(bool,double,double).rectangleThinnessRatio'></a>

`rectangleThinnessRatio` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rectangular thinness ratio of the external edge\.

#### Returns
[BuildingShape](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingShape 'DiGi\.GIS\.Enums\.BuildingShape')  
The resolved [BuildingShape](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingShape 'DiGi\.GIS\.Enums\.BuildingShape')\.

<a name='DiGi.GIS.Classes.BuildingShapeSolver.Solve()'></a>

## BuildingShapeSolver\.Solve\(\) Method

Analyzes the input building geometry and determines its corresponding [BuildingShape](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingShape 'DiGi\.GIS\.Enums\.BuildingShape')\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a shape was successfully determined; otherwise, false\.

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions'></a>

## ComparisonTableConversionOptions Class

Provides options for the conversion of comparison tables\.

```csharp
public class ComparisonTableConversionOptions : DiGi.GIS.Classes.TableConversionOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [TableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.TableConversionOptions 'DiGi\.GIS\.Classes\.TableConversionOptions') → ComparisonTableConversionOptions
### Constructors

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions.ComparisonTableConversionOptions()'></a>

## ComparisonTableConversionOptions\(\) Constructor

Initializes a new instance of the [ComparisonTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ComparisonTableConversionOptions 'DiGi\.GIS\.Classes\.ComparisonTableConversionOptions') class\.

```csharp
public ComparisonTableConversionOptions();
```

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions.ComparisonTableConversionOptions(DiGi.GIS.Classes.ComparisonTableConversionOptions)'></a>

## ComparisonTableConversionOptions\(ComparisonTableConversionOptions\) Constructor

Initializes a new instance of the [ComparisonTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ComparisonTableConversionOptions 'DiGi\.GIS\.Classes\.ComparisonTableConversionOptions') class using an existing instance of options\.

```csharp
public ComparisonTableConversionOptions(DiGi.GIS.Classes.ComparisonTableConversionOptions comparisonTableConversionOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions.ComparisonTableConversionOptions(DiGi.GIS.Classes.ComparisonTableConversionOptions).comparisonTableConversionOptions'></a>

`comparisonTableConversionOptions` [ComparisonTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ComparisonTableConversionOptions 'DiGi\.GIS\.Classes\.ComparisonTableConversionOptions')

The source conversion options to copy values from\.

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions.ComparisonTableConversionOptions(System.Text.Json.Nodes.JsonObject)'></a>

## ComparisonTableConversionOptions\(JsonObject\) Constructor

Initializes a new instance of the [ComparisonTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ComparisonTableConversionOptions 'DiGi\.GIS\.Classes\.ComparisonTableConversionOptions') class from a JSON object\.

```csharp
public ComparisonTableConversionOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions.ComparisonTableConversionOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the conversion options\.
### Properties

<a name='DiGi.GIS.Classes.ComparisonTableConversionOptions.IncludeOrtoDatasComparison'></a>

## ComparisonTableConversionOptions\.IncludeOrtoDatasComparison Property

Gets or sets a value indicating whether to include orthodata comparisons in the table conversion\.

```csharp
public bool IncludeOrtoDatasComparison { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions'></a>

## DirectoryExtractOptions Class

Provides options for directory extraction processes, specifying source and destination paths along with file and directory naming conventions\.

```csharp
public class DirectoryExtractOptions : DiGi.GIS.Classes.ExtractOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions') → DirectoryExtractOptions
### Constructors

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DirectoryExtractOptions()'></a>

## DirectoryExtractOptions\(\) Constructor

Initializes a new instance of the [DirectoryExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryExtractOptions 'DiGi\.GIS\.Classes\.DirectoryExtractOptions') class\.

```csharp
public DirectoryExtractOptions();
```

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DirectoryExtractOptions(string,string)'></a>

## DirectoryExtractOptions\(string, string\) Constructor

Initializes a new instance of the [DirectoryExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryExtractOptions 'DiGi\.GIS\.Classes\.DirectoryExtractOptions') class with specified source and destination paths\.

```csharp
public DirectoryExtractOptions(string? sourcePath, string? destionationDirectory);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DirectoryExtractOptions(string,string).sourcePath'></a>

`sourcePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the source directory\.

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DirectoryExtractOptions(string,string).destionationDirectory'></a>

`destionationDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the destination directory\.

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DirectoryExtractOptions(System.Text.Json.Nodes.JsonObject)'></a>

## DirectoryExtractOptions\(JsonObject\) Constructor

Initializes a new instance of the [DirectoryExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryExtractOptions 'DiGi\.GIS\.Classes\.DirectoryExtractOptions') class using a JSON object\.

```csharp
public DirectoryExtractOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DirectoryExtractOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the configuration options\.
### Properties

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.AdministrativeAreal2DFileName'></a>

## DirectoryExtractOptions\.AdministrativeAreal2DFileName Property

Gets or sets the file name used for Administrative Areal 2D data extraction\.

```csharp
public string AdministrativeAreal2DFileName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.AdministrativeArealsDirectoryName'></a>

## DirectoryExtractOptions\.AdministrativeArealsDirectoryName Property

Gets or sets the directory name used for storing Administrative Areals data\.

```csharp
public string AdministrativeArealsDirectoryName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.Building2DFileName'></a>

## DirectoryExtractOptions\.Building2DFileName Property

Gets or sets the file name used for Building 2D data extraction\.

```csharp
public string Building2DFileName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.BuildingsDirectoryName'></a>

## DirectoryExtractOptions\.BuildingsDirectoryName Property

Gets or sets the directory name used for storing Buildings data\.

```csharp
public string BuildingsDirectoryName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.DestionationDirectory'></a>

## DirectoryExtractOptions\.DestionationDirectory Property

Gets or sets the path to the destination directory where extracted data will be stored\.

```csharp
public string? DestionationDirectory { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.SourcePath'></a>

## DirectoryExtractOptions\.SourcePath Property

Gets or sets the path to the source directory from which data is extracted\.

```csharp
public string? SourcePath { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.DirectoryExtractOptions.UpdateExisting'></a>

## DirectoryExtractOptions\.UpdateExisting Property

Gets or sets a value indicating whether existing files in the destination directory should be updated\.

```csharp
public bool UpdateExisting { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.DirectoryNamesOptions'></a>

## DirectoryNamesOptions Class

Provides options for specifying directory names\.

```csharp
public abstract class DirectoryNamesOptions : DiGi.Core.Classes.SerializableOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → DirectoryNamesOptions

Derived  
↳ [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions')
### Constructors

<a name='DiGi.GIS.Classes.DirectoryNamesOptions.DirectoryNamesOptions()'></a>

## DirectoryNamesOptions\(\) Constructor

Initializes a new instance of the [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') class\.

```csharp
public DirectoryNamesOptions();
```

<a name='DiGi.GIS.Classes.DirectoryNamesOptions.DirectoryNamesOptions(DiGi.GIS.Classes.DirectoryNamesOptions)'></a>

## DirectoryNamesOptions\(DirectoryNamesOptions\) Constructor

Initializes a new instance of the [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') class based on an existing [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') instance\.

```csharp
public DirectoryNamesOptions(DiGi.GIS.Classes.DirectoryNamesOptions? directoryNamesOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectoryNamesOptions.DirectoryNamesOptions(DiGi.GIS.Classes.DirectoryNamesOptions).directoryNamesOptions'></a>

`directoryNamesOptions` [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions')

The source options to copy from\.

<a name='DiGi.GIS.Classes.DirectoryNamesOptions.DirectoryNamesOptions(System.Text.Json.Nodes.JsonObject)'></a>

## DirectoryNamesOptions\(JsonObject\) Constructor

Initializes a new instance of the [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') class from a JSON object\.

```csharp
public DirectoryNamesOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectoryNamesOptions.DirectoryNamesOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the options data\.
### Properties

<a name='DiGi.GIS.Classes.DirectoryNamesOptions.DirectoryNames'></a>

## DirectoryNamesOptions\.DirectoryNames Property

Gets or sets the array of directory names\.

```csharp
public string[]? DirectoryNames { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Classes.DirectorySource'></a>

## DirectorySource Class

Represents a source that operates from a directory path

```csharp
public class DirectorySource : DiGi.GIS.Classes.Source, DiGi.GIS.Interfaces.ISource, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source') → DirectorySource

Implements [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.GIS.Classes.DirectorySource.DirectorySource(DiGi.GIS.Classes.DirectorySource)'></a>

## DirectorySource\(DirectorySource\) Constructor

Initializes a new instance of the DirectorySource class as a copy

```csharp
public DirectorySource(DiGi.GIS.Classes.DirectorySource? directorySource);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectorySource.DirectorySource(DiGi.GIS.Classes.DirectorySource).directorySource'></a>

`directorySource` [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')

The DirectorySource instance to copy from\.

<a name='DiGi.GIS.Classes.DirectorySource.DirectorySource(string)'></a>

## DirectorySource\(string\) Constructor

Initializes a new instance of the DirectorySource class

```csharp
public DirectorySource(string? directory);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectorySource.DirectorySource(string).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory\.

<a name='DiGi.GIS.Classes.DirectorySource.DirectorySource(System.Text.Json.Nodes.JsonObject)'></a>

## DirectorySource\(JsonObject\) Constructor

Initializes a new instance of the DirectorySource class from a JSON object

```csharp
public DirectorySource(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.DirectorySource.DirectorySource(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the instance\.
### Fields

<a name='DiGi.GIS.Classes.DirectorySource.directory'></a>

## DirectorySource\.directory Field

The internal storage for the directory path\.

```csharp
public string? directory;
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Properties

<a name='DiGi.GIS.Classes.DirectorySource.Directory'></a>

## DirectorySource\.Directory Property

Directory path

```csharp
public string? Directory { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.ExtractOptions'></a>

## ExtractOptions Class

Provides the base options used for data extraction processes\.

```csharp
public abstract class ExtractOptions : DiGi.Core.Classes.SerializableOptions, DiGi.GIS.Interfaces.IExtractOptions, DiGi.Core.Interfaces.IOptions, DiGi.Core.Interfaces.IObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → ExtractOptions

Derived  
↳ [DirectoryExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryExtractOptions 'DiGi\.GIS\.Classes\.DirectoryExtractOptions')

Implements [IExtractOptions](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IExtractOptions 'DiGi\.GIS\.Interfaces\.IExtractOptions'), [DiGi\.Core\.Interfaces\.IOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ioptions 'DiGi\.Core\.Interfaces\.IOptions'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.ExtractOptions.ExtractOptions()'></a>

## ExtractOptions\(\) Constructor

Initializes a new instance of the [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions') class\.

```csharp
public ExtractOptions();
```

<a name='DiGi.GIS.Classes.ExtractOptions.ExtractOptions(DiGi.GIS.Classes.ExtractOptions)'></a>

## ExtractOptions\(ExtractOptions\) Constructor

Initializes a new instance of the [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions') class using an existing options object\.

```csharp
public ExtractOptions(DiGi.GIS.Classes.ExtractOptions? extractOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.ExtractOptions.ExtractOptions(DiGi.GIS.Classes.ExtractOptions).extractOptions'></a>

`extractOptions` [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions')

The source extraction options to copy from\.

<a name='DiGi.GIS.Classes.ExtractOptions.ExtractOptions(System.Text.Json.Nodes.JsonObject)'></a>

## ExtractOptions\(JsonObject\) Constructor

Initializes a new instance of the [ExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ExtractOptions 'DiGi\.GIS\.Classes\.ExtractOptions') class from a JSON object\.

```csharp
public ExtractOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.ExtractOptions.ExtractOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the option values\.

<a name='DiGi.GIS.Classes.GISGuidObject2D'></a>

## GISGuidObject2D Class

Represents an abstract base class for 2D GIS objects that are identified by a GUID\.

```csharp
public abstract class GISGuidObject2D : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IGISGuidObject2D, DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → GISGuidObject2D

Derived  
↳ [Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D')

Implements [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D'), [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [IGISUniqueObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject2D 'DiGi\.GIS\.Interfaces\.IGISUniqueObject2D')
### Constructors

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(DiGi.GIS.Classes.GISGuidObject2D)'></a>

## GISGuidObject2D\(GISGuidObject2D\) Constructor

Initializes a new instance of the [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') class as a copy of an existing object\.

```csharp
public GISGuidObject2D(DiGi.GIS.Classes.GISGuidObject2D? gISGuidObject2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(DiGi.GIS.Classes.GISGuidObject2D).gISGuidObject2D'></a>

`gISGuidObject2D` [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')

The source object to copy from\.

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(System.Guid,string)'></a>

## GISGuidObject2D\(Guid, string\) Constructor

Initializes a new instance of the [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') class\.

```csharp
public GISGuidObject2D(System.Guid guid, string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(System.Guid,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(System.Guid,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string associated with the object\.

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(System.Text.Json.Nodes.JsonObject)'></a>

## GISGuidObject2D\(JsonObject\) Constructor

Initializes a new instance of the [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D') class from a JSON object\.

```csharp
public GISGuidObject2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISGuidObject2D.GISGuidObject2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.
### Properties

<a name='DiGi.GIS.Classes.GISGuidObject2D.Reference'></a>

## GISGuidObject2D\.Reference Property

Gets the reference identifier\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.GISModel'></a>

## GISModel Class

Represents a GIS model that manages unique objects such as Building2D, AdministrativeAreal2D and their relations

```csharp
public class GISModel : DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel<DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISRelation>, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidmodel 'DiGi\.Core\.Classes\.GuidModel') → [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationclustermodel-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\`2')[IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationclustermodel-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\`2')[IGISRelation](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISRelation 'DiGi\.GIS\.Interfaces\.IGISRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationclustermodel-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\`2') → GISModel

Implements [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.GIS.Classes.GISModel.GISModel()'></a>

## GISModel\(\) Constructor

Initializes a new instance of the GISModel class

```csharp
public GISModel();
```

<a name='DiGi.GIS.Classes.GISModel.GISModel(DiGi.GIS.Classes.GISModel)'></a>

## GISModel\(GISModel\) Constructor

Initializes a new instance of the GISModel class by copying another instance

```csharp
public GISModel(DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.GISModel(DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The instance to copy

<a name='DiGi.GIS.Classes.GISModel.GISModel(string,DiGi.GIS.Classes.GISModel)'></a>

## GISModel\(string, GISModel\) Constructor

Initializes a new instance of the GISModel class with a reference and a source model

```csharp
public GISModel(string? reference, DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.GISModel(string,DiGi.GIS.Classes.GISModel).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string

<a name='DiGi.GIS.Classes.GISModel.GISModel(string,DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

An optional GISModel to copy from

<a name='DiGi.GIS.Classes.GISModel.GISModel(string,DiGi.GIS.Interfaces.ISource)'></a>

## GISModel\(string, ISource\) Constructor

Initializes a new instance of the GISModel class with a reference and source

```csharp
public GISModel(string? reference, DiGi.GIS.Interfaces.ISource? source);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.GISModel(string,DiGi.GIS.Interfaces.ISource).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string

<a name='DiGi.GIS.Classes.GISModel.GISModel(string,DiGi.GIS.Interfaces.ISource).source'></a>

`source` [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource')

An optional source to update from

<a name='DiGi.GIS.Classes.GISModel.GISModel(System.Text.Json.Nodes.JsonObject)'></a>

## GISModel\(JsonObject\) Constructor

Initializes a new instance of the GISModel class from a JSON object

```csharp
public GISModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.GISModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from
### Properties

<a name='DiGi.GIS.Classes.GISModel.Reference'></a>

## GISModel\.Reference Property

Gets the reference string for this GIS model

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.GIS.Classes.GISModel.Contains(DiGi.GIS.Classes.AdministrativeAreal2D)'></a>

## GISModel\.Contains\(AdministrativeAreal2D\) Method

Determines whether the GIS model contains the specified administrative area\.

```csharp
public bool Contains(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Contains(DiGi.GIS.Classes.AdministrativeAreal2D).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative area to check for existence within the model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the administrative area is found in the model; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModel.Contains(DiGi.GIS.Classes.Building2D)'></a>

## GISModel\.Contains\(Building2D\) Method

Determines whether the GIS model contains the specified building\.

```csharp
public bool Contains(DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Contains(DiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building to check for existence within the model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the building is found in the model; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModel.GetObject_TGISGuidObject2D_(string)'></a>

## GISModel\.GetObject\<TGISGuidObject2D\>\(string\) Method

Retrieves a GIS object of the specified type by its reference string\.

```csharp
public TGISGuidObject2D? GetObject<TGISGuidObject2D>(string? reference)
    where TGISGuidObject2D : DiGi.GIS.Classes.GISGuidObject2D;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModel.GetObject_TGISGuidObject2D_(string).TGISGuidObject2D'></a>

`TGISGuidObject2D`

The type of GIS object to retrieve, which must derive from [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.GetObject_TGISGuidObject2D_(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string of the object to be retrieved\.

#### Returns
[TGISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel.GetObject_TGISGuidObject2D_(string).TGISGuidObject2D 'DiGi\.GIS\.Classes\.GISModel\.GetObject\<TGISGuidObject2D\>\(string\)\.TGISGuidObject2D')  
The matching GIS object if found; otherwise, null\.

<a name='DiGi.GIS.Classes.GISModel.GetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_)'></a>

## GISModel\.GetObjects\<TGISGuidObject2D\>\(IEnumerable\<string\>\) Method

Retrieves a list of GIS objects of the specified type that match the provided references\.

```csharp
public System.Collections.Generic.List<TGISGuidObject2D>? GetObjects<TGISGuidObject2D>(System.Collections.Generic.IEnumerable<string?>? references)
    where TGISGuidObject2D : DiGi.GIS.Classes.GISGuidObject2D;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModel.GetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_).TGISGuidObject2D'></a>

`TGISGuidObject2D`

The type of GIS object to retrieve, which must derive from [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.GetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of reference strings for the objects to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TGISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel.GetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_).TGISGuidObject2D 'DiGi\.GIS\.Classes\.GISModel\.GetObjects\<TGISGuidObject2D\>\(System\.Collections\.Generic\.IEnumerable\<string\>\)\.TGISGuidObject2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the matching GIS objects if found; otherwise, null\.

<a name='DiGi.GIS.Classes.GISModel.GetReferences_TGISGuidObject2D_()'></a>

## GISModel\.GetReferences\<TGISGuidObject2D\>\(\) Method

Gets the references of all GIS objects of the specified type within the model\.

```csharp
public System.Collections.Generic.HashSet<string>? GetReferences<TGISGuidObject2D>()
    where TGISGuidObject2D : DiGi.GIS.Classes.GISGuidObject2D;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModel.GetReferences_TGISGuidObject2D_().TGISGuidObject2D'></a>

`TGISGuidObject2D`

The type of GIS object to retrieve references for, which must derive from [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the reference strings of the objects if they exist; otherwise, null\.

<a name='DiGi.GIS.Classes.GISModel.TryGetObject_TGISGuidObject2D_(string,TGISGuidObject2D)'></a>

## GISModel\.TryGetObject\<TGISGuidObject2D\>\(string, TGISGuidObject2D\) Method

Tries to retrieve a single GIS object of the specified type using its reference\.

```csharp
public bool TryGetObject<TGISGuidObject2D>(string? reference, out TGISGuidObject2D? gISGuidObject2D)
    where TGISGuidObject2D : DiGi.GIS.Classes.GISGuidObject2D;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModel.TryGetObject_TGISGuidObject2D_(string,TGISGuidObject2D).TGISGuidObject2D'></a>

`TGISGuidObject2D`

The type of the GIS object to retrieve, which must derive from [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.TryGetObject_TGISGuidObject2D_(string,TGISGuidObject2D).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string used to identify the object to be retrieved\.

<a name='DiGi.GIS.Classes.GISModel.TryGetObject_TGISGuidObject2D_(string,TGISGuidObject2D).gISGuidObject2D'></a>

`gISGuidObject2D` [TGISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel.TryGetObject_TGISGuidObject2D_(string,TGISGuidObject2D).TGISGuidObject2D 'DiGi\.GIS\.Classes\.GISModel\.TryGetObject\<TGISGuidObject2D\>\(string, TGISGuidObject2D\)\.TGISGuidObject2D')

When this method returns, contains the retrieved object if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully found and assigned to [gISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel.TryGetObject_TGISGuidObject2D_(string,TGISGuidObject2D).gISGuidObject2D 'DiGi\.GIS\.Classes\.GISModel\.TryGetObject\<TGISGuidObject2D\>\(string, TGISGuidObject2D\)\.gISGuidObject2D'); otherwise, false\.

<a name='DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int)'></a>

## GISModel\.TryGetObjects\<TGISGuidObject2D\>\(IEnumerable\<string\>, List\<TGISGuidObject2D\>, int\) Method

Tries to retrieve a list of GIS objects of the specified type that match the provided references\.

```csharp
public virtual bool TryGetObjects<TGISGuidObject2D>(System.Collections.Generic.IEnumerable<string?>? references, out System.Collections.Generic.List<TGISGuidObject2D>? gISGuidObject2Ds, int maxCount=int.MaxValue)
    where TGISGuidObject2D : DiGi.GIS.Classes.GISGuidObject2D;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int).TGISGuidObject2D'></a>

`TGISGuidObject2D`

The type of GIS objects to retrieve, which must derive from [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings used to identify the objects to be retrieved\.

<a name='DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int).gISGuidObject2Ds'></a>

`gISGuidObject2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TGISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int).TGISGuidObject2D 'DiGi\.GIS\.Classes\.GISModel\.TryGetObjects\<TGISGuidObject2D\>\(System\.Collections\.Generic\.IEnumerable\<string\>, System\.Collections\.Generic\.List\<TGISGuidObject2D\>, int\)\.TGISGuidObject2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of the retrieved objects if successful; otherwise, null\.

<a name='DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of objects to retrieve from the model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more objects were successfully retrieved and assigned to [gISGuidObject2Ds](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel.TryGetObjects_TGISGuidObject2D_(System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.List_TGISGuidObject2D_,int).gISGuidObject2Ds 'DiGi\.GIS\.Classes\.GISModel\.TryGetObjects\<TGISGuidObject2D\>\(System\.Collections\.Generic\.IEnumerable\<string\>, System\.Collections\.Generic\.List\<TGISGuidObject2D\>, int\)\.gISGuidObject2Ds'); otherwise, false\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D)'></a>

## GISModel\.Update\(AdministrativeAreal2D\) Method

Updates the GIS model with the specified administrative area\.

```csharp
public bool Update(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D') object to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult)'></a>

## GISModel\.Update\(AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult\) Method

Updates the GIS model with the specified administrative area and its geometry calculation result, establishing a relationship between them in the relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D') object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult).administrativeAreal2DGeometryCalculationResult'></a>

`administrativeAreal2DGeometryCalculationResult` [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')

The [AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult') object to be associated with the administrative area\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update and relationship establishment were successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult)'></a>

## GISModel\.Update\(AdministrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult\) Method

Updates the GIS model with the specified administrative area and its corresponding statistical units calculation result, establishing a relationship between them in the relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult? administrativeAreal2DStatisticalUnitCalculcationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The `AdministrativeAreal2D` object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult).administrativeAreal2DStatisticalUnitCalculcationResult'></a>

`administrativeAreal2DStatisticalUnitCalculcationResult` [AdministrativeAreal2DStatisticalUnitsCalculcationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DStatisticalUnitsCalculcationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DStatisticalUnitsCalculcationResult')

The `AdministrativeAreal2DStatisticalUnitsCalculcationResult` object to be associated with the administrative area\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update and relationship establishment were successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.OccupancyCalculationResult)'></a>

## GISModel\.Update\(AdministrativeAreal2D, OccupancyCalculationResult\) Method

Updates the GIS model with the specified administrative area and its occupancy calculation result, establishing a relationship between them in the relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D, DiGi.GIS.Classes.OccupancyCalculationResult? occupancyCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.OccupancyCalculationResult).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The `AdministrativeAreal2D` object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.GIS.Classes.OccupancyCalculationResult).occupancyCalculationResult'></a>

`occupancyCalculationResult` [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')

The `OccupancyCalculationResult` object to be associated with the administrative area\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update and relationship establishment were successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_)'></a>

## GISModel\.Update\(AdministrativeAreal2D, IEnumerable\<AdministrativeAreal2D\>\) Method

Updates the relationship between a specific administrative area and its associated collection of related administrative areas within the GIS model's relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.AdministrativeAreal2D administrativeAreal2D, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.AdministrativeAreal2D> administrativeAreal2Ds);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The primary administrative area object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_).administrativeAreal2Ds'></a>

`administrativeAreal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of related administrative area objects to associate with the primary area\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the relationship was successfully updated or removed; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## GISModel\.Update\(AdministrativeAreal2D, IEnumerable\<Building2D\>\) Method

Updates the relationship between a specific administrative area and its associated collection of 2D buildings within the GIS model's relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative area object to be updated or used as the primary entity in the relation\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.AdministrativeAreal2D,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of 2D building objects associated with the specified administrative area\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the relationship was successfully updated or removed; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D)'></a>

## GISModel\.Update\(Building2D\) Method

Updates the GIS model with the specified building\.

```csharp
public bool Update(DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') object to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DConstructionDateCalculationResult)'></a>

## GISModel\.Update\(Building2D, Building2DConstructionDateCalculationResult\) Method

Updates the GIS model with the specified building and its associated construction date calculation result, establishing or updating the relation between them\.

```csharp
public bool Update(DiGi.GIS.Classes.Building2D? building2D, DiGi.GIS.Classes.Building2DConstructionDateCalculationResult? building2DConstructionDateCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DConstructionDateCalculationResult).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object to be updated in the model\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DConstructionDateCalculationResult).building2DConstructionDateCalculationResult'></a>

`building2DConstructionDateCalculationResult` [Building2DConstructionDateCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DConstructionDateCalculationResult 'DiGi\.GIS\.Classes\.Building2DConstructionDateCalculationResult')

The construction date calculation result to be associated with the building\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false` if either provided parameter is null\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DExternalReferenceGuidResult)'></a>

## GISModel\.Update\(Building2D, Building2DExternalReferenceGuidResult\) Method

Updates the GIS model with the specified building and its external reference GUID result, establishing or updating the relationship between them within the relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.Building2D? building2D, DiGi.GIS.Classes.Building2DExternalReferenceGuidResult? building2DExternalReferenceUniqueResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DExternalReferenceGuidResult).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DExternalReferenceGuidResult).building2DExternalReferenceUniqueResult'></a>

`building2DExternalReferenceUniqueResult` [Building2DExternalReferenceGuidResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DExternalReferenceGuidResult 'DiGi\.GIS\.Classes\.Building2DExternalReferenceGuidResult')

The unique external reference GUID result associated with the building\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## GISModel\.Update\(Building2D, Building2DGeometryCalculationResult\) Method

Updates the GIS model with the specified building and its geometry calculation result, establishing a relationship between them in the relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.Building2D? building2D, DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DGeometryCalculationResult).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The [Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult') object to be associated with the building\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update and relationship establishment were successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OccupancyCalculationResult)'></a>

## GISModel\.Update\(Building2D, OccupancyCalculationResult\) Method

Updates the GIS model with the specified building and its corresponding occupancy calculation result, establishing a relationship between them in the relation cluster\.

```csharp
public bool Update(DiGi.GIS.Classes.Building2D? building2D, DiGi.GIS.Classes.OccupancyCalculationResult? occupancyCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OccupancyCalculationResult).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The `Building2D` object to be updated\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OccupancyCalculationResult).occupancyCalculationResult'></a>

`occupancyCalculationResult` [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')

The `OccupancyCalculationResult` object to be associated with the building\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update and relationship establishment were successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Interfaces.ISource)'></a>

## GISModel\.Update\(ISource\) Method

Updates the GIS model using the specified source\.

```csharp
public bool Update(DiGi.GIS.Interfaces.ISource? source);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModel.Update(DiGi.GIS.Interfaces.ISource).source'></a>

`source` [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource')

The [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource') object to be updated in the model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false`\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference'></a>

## GISModelAreal2DReference Class

Represents a reference to an areal 2D object within a GIS model\.

```csharp
public class GISModelAreal2DReference : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.IReference, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GISModelAreal2DReference

Implements [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.ISerializableReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablereference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Constructors

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(DiGi.GIS.Classes.GISModelAreal2DReference)'></a>

## GISModelAreal2DReference\(GISModelAreal2DReference\) Constructor

Initializes a new instance of the GISModelAreal2DReference class as a copy of an existing instance\.

```csharp
public GISModelAreal2DReference(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference'></a>

`gISModelAreal2DReference` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The source instance to copy from\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(string,string)'></a>

## GISModelAreal2DReference\(string, string\) Constructor

Initializes a new instance of the GISModelAreal2DReference class\.

```csharp
public GISModelAreal2DReference(string? gISModelReference, string? areal2DReference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(string,string).gISModelReference'></a>

`gISModelReference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference to the GIS model\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(string,string).areal2DReference'></a>

`areal2DReference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference to the areal 2D object\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(System.Text.Json.Nodes.JsonObject)'></a>

## GISModelAreal2DReference\(JsonObject\) Constructor

Initializes a new instance of the GISModelAreal2DReference class from a JSON object\.

```csharp
public GISModelAreal2DReference(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelAreal2DReference(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the reference data\.
### Properties

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.Areal2DReference'></a>

## GISModelAreal2DReference\.Areal2DReference Property

Gets the reference to the areal 2D object\.

```csharp
public string? Areal2DReference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GISModelReference'></a>

## GISModelAreal2DReference\.GISModelReference Property

Gets the reference to the GIS model\.

```csharp
public string? GISModelReference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.Clone()'></a>

## GISModelAreal2DReference\.Clone\(\) Method

Creates a clone of this instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new GISModelAreal2DReference instance that is a copy of the current instance\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.Equals(DiGi.Core.Interfaces.IReference)'></a>

## GISModelAreal2DReference\.Equals\(IReference\) Method

Indicates whether this instance equals a given reference\.

```csharp
public bool Equals(DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.Equals(DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')

The reference to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the instances are equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.Equals(object)'></a>

## GISModelAreal2DReference\.Equals\(object\) Method

Indicates whether this instance equals a given object\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.GetHashCode()'></a>

## GISModelAreal2DReference\.GetHashCode\(\) Method

Returns the hash code for this instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.ToString()'></a>

## GISModelAreal2DReference\.ToString\(\) Method

Returns the string representation of this instance\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the GIS model and areal 2D references\.
### Operators

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.Core.Interfaces.ISerializableReference)'></a>

## GISModelAreal2DReference\.operator ==\(GISModelAreal2DReference, ISerializableReference\) Operator

Determines whether the specified GISModelAreal2DReference and ISerializableReference are equal\.

```csharp
public static bool operator ==(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1, DiGi.Core.Interfaces.ISerializableReference @object);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.Core.Interfaces.ISerializableReference).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The first reference\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.Core.Interfaces.ISerializableReference).object'></a>

`object` [DiGi\.Core\.Interfaces\.ISerializableReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablereference 'DiGi\.Core\.Interfaces\.ISerializableReference')

The second reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.GIS.Classes.GISModelAreal2DReference)'></a>

## GISModelAreal2DReference\.operator ==\(GISModelAreal2DReference, GISModelAreal2DReference\) Operator

Determines whether the specified two GISModelAreal2DReference instances are equal\.

```csharp
public static bool operator ==(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1, DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_2);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The first reference\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference_2'></a>

`gISModelAreal2DReference_2` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The second reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,object)'></a>

## GISModelAreal2DReference\.operator ==\(GISModelAreal2DReference, object\) Operator

Determines whether the specified GISModelAreal2DReference and object are equal\.

```csharp
public static bool operator ==(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1, object @object);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,object).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The first reference\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(DiGi.GIS.Classes.GISModelAreal2DReference,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The second object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(object,DiGi.GIS.Classes.GISModelAreal2DReference)'></a>

## GISModelAreal2DReference\.operator ==\(object, GISModelAreal2DReference\) Operator

Determines whether the specified object and GISModelAreal2DReference are equal\.

```csharp
public static bool operator ==(object serializableReference_1, DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(object,DiGi.GIS.Classes.GISModelAreal2DReference).serializableReference_1'></a>

`serializableReference_1` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The first object\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Equality(object,DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The second reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.Core.Interfaces.ISerializableReference)'></a>

## GISModelAreal2DReference\.operator \!=\(GISModelAreal2DReference, ISerializableReference\) Operator

Determines whether the specified GISModelAreal2DReference and ISerializableReference are not equal\.

```csharp
public static bool operator !=(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1, DiGi.Core.Interfaces.ISerializableReference @object);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.Core.Interfaces.ISerializableReference).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The first reference\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.Core.Interfaces.ISerializableReference).object'></a>

`object` [DiGi\.Core\.Interfaces\.ISerializableReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablereference 'DiGi\.Core\.Interfaces\.ISerializableReference')

The second reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are not equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.GIS.Classes.GISModelAreal2DReference)'></a>

## GISModelAreal2DReference\.operator \!=\(GISModelAreal2DReference, GISModelAreal2DReference\) Operator

Determines whether the specified two GISModelAreal2DReference instances are not equal\.

```csharp
public static bool operator !=(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1, DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_2);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The first reference\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference_2'></a>

`gISModelAreal2DReference_2` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The second reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are not equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,object)'></a>

## GISModelAreal2DReference\.operator \!=\(GISModelAreal2DReference, object\) Operator

Determines whether the specified GISModelAreal2DReference and object are not equal\.

```csharp
public static bool operator !=(DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_1, object @object);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,object).gISModelAreal2DReference_1'></a>

`gISModelAreal2DReference_1` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The first reference\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(DiGi.GIS.Classes.GISModelAreal2DReference,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The second object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are not equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(object,DiGi.GIS.Classes.GISModelAreal2DReference)'></a>

## GISModelAreal2DReference\.operator \!=\(object, GISModelAreal2DReference\) Operator

Determines whether the specified object and GISModelAreal2DReference are not equal\.

```csharp
public static bool operator !=(object serializableReference_1, DiGi.GIS.Classes.GISModelAreal2DReference gISModelAreal2DReference_2);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(object,DiGi.GIS.Classes.GISModelAreal2DReference).serializableReference_1'></a>

`serializableReference_1` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The first object\.

<a name='DiGi.GIS.Classes.GISModelAreal2DReference.op_Inequality(object,DiGi.GIS.Classes.GISModelAreal2DReference).gISModelAreal2DReference_2'></a>

`gISModelAreal2DReference_2` [GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')

The second reference\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the references are not equal; otherwise, false\.

<a name='DiGi.GIS.Classes.GISModelFile'></a>

## GISModelFile Class

Represents a GIS model file that stores GIS model data with external reference support

```csharp
public class GISModelFile : DiGi.Core.IO.File.Classes.ValueFile<DiGi.GIS.Classes.GISModel>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1')[GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1') → GISModelFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.GISModelFile.GISModelFile(DiGi.GIS.Classes.GISModelFile)'></a>

## GISModelFile\(GISModelFile\) Constructor

Initializes a new instance of the GISModelFile class by copying another instance

```csharp
public GISModelFile(DiGi.GIS.Classes.GISModelFile? gISModelFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFile.GISModelFile(DiGi.GIS.Classes.GISModelFile).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The source GIS model file to copy from\.

<a name='DiGi.GIS.Classes.GISModelFile.GISModelFile(string)'></a>

## GISModelFile\(string\) Constructor

Initializes a new instance of the GISModelFile class from the specified path

```csharp
public GISModelFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFile.GISModelFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the GIS model file\.

<a name='DiGi.GIS.Classes.GISModelFile.GISModelFile(System.Text.Json.Nodes.JsonObject)'></a>

## GISModelFile\(JsonObject\) Constructor

Initializes a new instance of the GISModelFile class from a JSON object

```csharp
public GISModelFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFile.GISModelFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for the GIS model file\.
### Properties

<a name='DiGi.GIS.Classes.GISModelFile.GuidExternalReference'></a>

## GISModelFile\.GuidExternalReference Property

Gets the external reference for this GIS model file

```csharp
public DiGi.Core.Classes.GuidExternalReference? GuidExternalReference { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

<a name='DiGi.GIS.Classes.GISModelFileGuidObjectReference'></a>

## GISModelFileGuidObjectReference Class

Represents a reference to a GUID object within a GIS model file

```csharp
public class GISModelFileGuidObjectReference : DiGi.Core.Classes.SerializableReference, DiGi.Core.Interfaces.IComplexReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializablereference 'DiGi\.Core\.Classes\.SerializableReference') → GISModelFileGuidObjectReference

Implements [DiGi\.Core\.Interfaces\.IComplexReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icomplexreference 'DiGi\.Core\.Interfaces\.IComplexReference'), [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Constructors

<a name='DiGi.GIS.Classes.GISModelFileGuidObjectReference.GISModelFileGuidObjectReference(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference)'></a>

## GISModelFileGuidObjectReference\(GuidExternalReference, GuidReference\) Constructor

Represents a reference to a GUID object within a GIS model file

```csharp
public GISModelFileGuidObjectReference(DiGi.Core.Classes.GuidExternalReference? guidExternalReference, DiGi.Core.Classes.GuidReference? guidReference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileGuidObjectReference.GISModelFileGuidObjectReference(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

<a name='DiGi.GIS.Classes.GISModelFileGuidObjectReference.GISModelFileGuidObjectReference(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')
### Properties

<a name='DiGi.GIS.Classes.GISModelFileGuidObjectReference.GuidExternalReference'></a>

## GISModelFileGuidObjectReference\.GuidExternalReference Property

External GUID reference

```csharp
public DiGi.Core.Classes.GuidExternalReference? GuidExternalReference { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

<a name='DiGi.GIS.Classes.GISModelFileGuidObjectReference.GuidReference'></a>

## GISModelFileGuidObjectReference\.GuidReference Property

Internal GUID reference within the GIS model

```csharp
public DiGi.Core.Classes.GuidReference? GuidReference { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

<a name='DiGi.GIS.Classes.GISModelFileManager'></a>

## GISModelFileManager Class

Provides functionality for managing GIS model files and implements the [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject') interface\.

```csharp
public class GISModelFileManager : DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GISModelFileManager

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.GISModelFileManager.GISModelFileManager()'></a>

## GISModelFileManager\(\) Constructor

Initializes a new instance of the GISModelFileManager class

```csharp
public GISModelFileManager();
```
### Methods

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGISModel(DiGi.Core.Classes.GuidExternalReference)'></a>

## GISModelFileManager\.GetGISModel\(GuidExternalReference\) Method

Retrieves the GIS model associated with the specified external reference\.

```csharp
public DiGi.GIS.Classes.GISModel? GetGISModel(DiGi.Core.Classes.GuidExternalReference? guidExternalReference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGISModel(DiGi.Core.Classes.GuidExternalReference).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference used to identify the GIS model\.

#### Returns
[GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')  
The matching [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel') if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGuidExternalReference(DiGi.GIS.Classes.GISModel)'></a>

## GISModelFileManager\.GetGuidExternalReference\(GISModel\) Method

Retrieves the external reference associated with the specified GIS model\.

```csharp
public DiGi.Core.Classes.GuidExternalReference? GetGuidExternalReference(DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGuidExternalReference(DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel') for which the external reference is being retrieved\.

#### Returns
[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')  
The matching [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference') if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGuidExternalReference(string)'></a>

## GISModelFileManager\.GetGuidExternalReference\(string\) Method

Retrieves the external reference associated with the specified file path\.

```csharp
public DiGi.Core.Classes.GuidExternalReference? GetGuidExternalReference(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGuidExternalReference(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to search for\.

#### Returns
[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')  
The matching [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference') if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.GetGuidExternalReferences()'></a>

## GISModelFileManager\.GetGuidExternalReferences\(\) Method

Retrieves all external reference identifiers currently managed by the GIS model file manager\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Core.Classes.GuidExternalReference>? GetGuidExternalReferences();
```

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing all [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference') keys, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no references are available\.

<a name='DiGi.GIS.Classes.GISModelFileManager.GetPath(DiGi.GIS.Classes.GISModel)'></a>

## GISModelFileManager\.GetPath\(GISModel\) Method

Retrieves the file path associated with the specified GIS model\.

```csharp
public string? GetPath(DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.GetPath(DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel') for which to retrieve the file path\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The file path of the GIS model if it exists in the manager; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.Open(string)'></a>

## GISModelFileManager\.Open\(string\) Method

Opens a GIS model file from the specified path and adds it to the manager's collection\.

```csharp
public DiGi.Core.Classes.GuidExternalReference? Open(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.Open(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path of the GIS model file to open\.

#### Returns
[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')  
The [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference') of the opened GIS model file if successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.Remove(DiGi.Core.Classes.GuidExternalReference)'></a>

## GISModelFileManager\.Remove\(GuidExternalReference\) Method

Removes the GIS model file associated with the specified external reference\.

```csharp
public bool Remove(DiGi.Core.Classes.GuidExternalReference? guidExternalReference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.Remove(DiGi.Core.Classes.GuidExternalReference).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference of the GIS model file to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the GIS model file was successfully removed; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.RemoveAll()'></a>

## GISModelFileManager\.RemoveAll\(\) Method

Removes all GIS model files from the manager\.

```csharp
public bool RemoveAll();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if one or more GIS model files were successfully removed; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.Save(DiGi.Core.Classes.GuidExternalReference)'></a>

## GISModelFileManager\.Save\(GuidExternalReference\) Method

Saves the GIS model file associated with the specified external reference\.

```csharp
public bool Save(DiGi.Core.Classes.GuidExternalReference? guidExternalReference);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.Save(DiGi.Core.Classes.GuidExternalReference).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference of the GIS model file to save\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the GIS model file was successfully saved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.SaveAs(DiGi.Core.Classes.GuidExternalReference,string)'></a>

## GISModelFileManager\.SaveAs\(GuidExternalReference, string\) Method

Saves the GIS model file associated with the specified external reference to the given path and updates its reference in the manager\.

```csharp
public DiGi.Core.Classes.GuidExternalReference? SaveAs(DiGi.Core.Classes.GuidExternalReference? guidExternalReference, string path);
```
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.SaveAs(DiGi.Core.Classes.GuidExternalReference,string).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference of the GIS model file to save\.

<a name='DiGi.GIS.Classes.GISModelFileManager.SaveAs(DiGi.Core.Classes.GuidExternalReference,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The destination file path where the GIS model file will be saved\.

#### Returns
[DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')  
The new [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference') if the operation was successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel)'></a>

## GISModelFileManager\.TryGetObject\<TGISGuidObject2D\>\(GuidExternalReference, string, TGISGuidObject2D, GISModel\) Method

Tries to retrieve a GIS unique object of the specified type and its associated GIS model using the provided external reference and reference string\.

```csharp
public bool TryGetObject<TGISGuidObject2D>(DiGi.Core.Classes.GuidExternalReference? guidExternalReference, string reference, out TGISGuidObject2D? gISUniqueObject, out DiGi.GIS.Classes.GISModel? gISModel)
    where TGISGuidObject2D : DiGi.GIS.Classes.GISGuidObject2D;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel).TGISGuidObject2D'></a>

`TGISGuidObject2D`

The type of the GIS unique object to retrieve, which must derive from [GISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISGuidObject2D 'DiGi\.GIS\.Classes\.GISGuidObject2D')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference GUID used to locate the GIS model\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string used to identify the specific object within the model\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel).gISUniqueObject'></a>

`gISUniqueObject` [TGISGuidObject2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel).TGISGuidObject2D 'DiGi\.GIS\.Classes\.GISModelFileManager\.TryGetObject\<TGISGuidObject2D\>\(DiGi\.Core\.Classes\.GuidExternalReference, string, TGISGuidObject2D, DiGi\.GIS\.Classes\.GISModel\)\.TGISGuidObject2D')

When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_TGISGuidObject2D_(DiGi.Core.Classes.GuidExternalReference,string,TGISGuidObject2D,DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

When this method returns, contains the retrieved GIS model if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object and its associated model were successfully found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject)'></a>

## GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(GuidExternalReference, GuidReference, YIGISUniqueObject\) Method

Tries to retrieve a GIS unique object of the specified type using the provided external reference and internal reference GUIDs\.

```csharp
public bool TryGetObject<YIGISUniqueObject>(DiGi.Core.Classes.GuidExternalReference? guidExternalReference, DiGi.Core.Classes.GuidReference? guidReference, out YIGISUniqueObject? gISUniqueObject)
    where YIGISUniqueObject : DiGi.GIS.Interfaces.IGISUniqueObject;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject).YIGISUniqueObject'></a>

`YIGISUniqueObject`

The type of the GIS unique object to retrieve, which must implement [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference GUID used to locate the GIS model containing the object\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The internal reference GUID used to identify the specific object within the model\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject).gISUniqueObject'></a>

`gISUniqueObject` [YIGISUniqueObject](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject).YIGISUniqueObject 'DiGi\.GIS\.Classes\.GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(DiGi\.Core\.Classes\.GuidExternalReference, DiGi\.Core\.Classes\.GuidReference, YIGISUniqueObject\)\.YIGISUniqueObject')

When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object was successfully found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel)'></a>

## GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(GuidExternalReference, GuidReference, YIGISUniqueObject, GISModel\) Method

Tries to retrieve a GIS unique object of the specified type and its associated GIS model using the provided external reference and internal reference GUIDs\.

```csharp
public bool TryGetObject<YIGISUniqueObject>(DiGi.Core.Classes.GuidExternalReference? guidExternalReference, DiGi.Core.Classes.GuidReference? guidReference, out YIGISUniqueObject? gISUniqueObject, out DiGi.GIS.Classes.GISModel? gISModel)
    where YIGISUniqueObject : DiGi.GIS.Interfaces.IGISUniqueObject;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).YIGISUniqueObject'></a>

`YIGISUniqueObject`

The type of the GIS unique object to retrieve, which must implement [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).guidExternalReference'></a>

`guidExternalReference` [DiGi\.Core\.Classes\.GuidExternalReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidexternalreference 'DiGi\.Core\.Classes\.GuidExternalReference')

The external reference GUID used to locate the GIS model\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The internal reference GUID used to identify the specific object within the model\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).gISUniqueObject'></a>

`gISUniqueObject` [YIGISUniqueObject](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).YIGISUniqueObject 'DiGi\.GIS\.Classes\.GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(DiGi\.Core\.Classes\.GuidExternalReference, DiGi\.Core\.Classes\.GuidReference, YIGISUniqueObject, DiGi\.GIS\.Classes\.GISModel\)\.YIGISUniqueObject')

When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.Core.Classes.GuidExternalReference,DiGi.Core.Classes.GuidReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

When this method returns, contains the retrieved GIS model if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object and its associated model were successfully found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject)'></a>

## GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(GISModelFileGuidObjectReference, YIGISUniqueObject\) Method

Tries to retrieve a GIS unique object of the specified type using the provided file and object reference\.

```csharp
public bool TryGetObject<YIGISUniqueObject>(DiGi.GIS.Classes.GISModelFileGuidObjectReference? gISModelFileUniqueObjectReference, out YIGISUniqueObject? gISUniqueObject)
    where YIGISUniqueObject : DiGi.GIS.Interfaces.IGISUniqueObject;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject).YIGISUniqueObject'></a>

`YIGISUniqueObject`

The type of the GIS unique object to retrieve, which must implement [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject).gISModelFileUniqueObjectReference'></a>

`gISModelFileUniqueObjectReference` [GISModelFileGuidObjectReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileGuidObjectReference 'DiGi\.GIS\.Classes\.GISModelFileGuidObjectReference')

The reference containing the external and internal GUIDs used to locate the object\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject).gISUniqueObject'></a>

`gISUniqueObject` [YIGISUniqueObject](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject).YIGISUniqueObject 'DiGi\.GIS\.Classes\.GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(DiGi\.GIS\.Classes\.GISModelFileGuidObjectReference, YIGISUniqueObject\)\.YIGISUniqueObject')

When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object was successfully found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel)'></a>

## GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(GISModelFileGuidObjectReference, YIGISUniqueObject, GISModel\) Method

Tries to retrieve a GIS unique object of the specified type and its associated GIS model using the provided file and object reference\.

```csharp
public bool TryGetObject<YIGISUniqueObject>(DiGi.GIS.Classes.GISModelFileGuidObjectReference? gISModelFileUniqueObjectReference, out YIGISUniqueObject? gISUniqueObject, out DiGi.GIS.Classes.GISModel? gISModel)
    where YIGISUniqueObject : DiGi.GIS.Interfaces.IGISUniqueObject;
```
#### Type parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).YIGISUniqueObject'></a>

`YIGISUniqueObject`

The type of the GIS unique object to retrieve, which must implement [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject')\.
#### Parameters

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).gISModelFileUniqueObjectReference'></a>

`gISModelFileUniqueObjectReference` [GISModelFileGuidObjectReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileGuidObjectReference 'DiGi\.GIS\.Classes\.GISModelFileGuidObjectReference')

The reference containing the external and internal GUIDs used to locate the object\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).gISUniqueObject'></a>

`gISUniqueObject` [YIGISUniqueObject](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).YIGISUniqueObject 'DiGi\.GIS\.Classes\.GISModelFileManager\.TryGetObject\<YIGISUniqueObject\>\(DiGi\.GIS\.Classes\.GISModelFileGuidObjectReference, YIGISUniqueObject, DiGi\.GIS\.Classes\.GISModel\)\.YIGISUniqueObject')

When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value\.

<a name='DiGi.GIS.Classes.GISModelFileManager.TryGetObject_YIGISUniqueObject_(DiGi.GIS.Classes.GISModelFileGuidObjectReference,YIGISUniqueObject,DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

When this method returns, contains the retrieved GIS model if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the object and its associated model were successfully found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.Classes.IndexData'></a>

## IndexData Class

Represents index data with an index value, reference, and name

```csharp
public class IndexData : DiGi.Core.Classes.UniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → IndexData

Implements [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.GIS.Classes.IndexData.IndexData(DiGi.GIS.Classes.IndexData)'></a>

## IndexData\(IndexData\) Constructor

Initializes a new instance of the IndexData class by copying another instance

```csharp
public IndexData(DiGi.GIS.Classes.IndexData? indexData);
```
#### Parameters

<a name='DiGi.GIS.Classes.IndexData.IndexData(DiGi.GIS.Classes.IndexData).indexData'></a>

`indexData` [IndexData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexData 'DiGi\.GIS\.Classes\.IndexData')

The source IndexData instance to copy from\.

<a name='DiGi.GIS.Classes.IndexData.IndexData(int,string,string)'></a>

## IndexData\(int, string, string\) Constructor

Initializes a new instance of the IndexData class with the specified index, reference, and name

```csharp
public IndexData(int index, string? reference, string? name);
```
#### Parameters

<a name='DiGi.GIS.Classes.IndexData.IndexData(int,string,string).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The numeric index value\.

<a name='DiGi.GIS.Classes.IndexData.IndexData(int,string,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier string\.

<a name='DiGi.GIS.Classes.IndexData.IndexData(int,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name string\.

<a name='DiGi.GIS.Classes.IndexData.IndexData(System.Text.Json.Nodes.JsonObject)'></a>

## IndexData\(JsonObject\) Constructor

Initializes a new instance of the IndexData class from a JSON object

```csharp
public IndexData(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.IndexData.IndexData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize this instance\.
### Properties

<a name='DiGi.GIS.Classes.IndexData.Index'></a>

## IndexData\.Index Property

Gets the index value

```csharp
public int Index { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.Classes.IndexData.Name'></a>

## IndexData\.Name Property

Gets the name string

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.IndexData.Reference'></a>

## IndexData\.Reference Property

Gets the reference string

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.IndexData.UniqueId'></a>

## IndexData\.UniqueId Property

Gets the unique identifier for this instance \(the index value as a string\)

```csharp
public override string? UniqueId { get; }
```

Implements [UniqueId](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject.uniqueid 'DiGi\.Core\.Interfaces\.IUniqueObject\.UniqueId')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.GIS.Classes.IndexData.ToString()'></a>

## IndexData\.ToString\(\) Method

Returns the string representation of this instance

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A tab\-separated string containing the index, reference, and name\.

<a name='DiGi.GIS.Classes.IndexDataFile'></a>

## IndexDataFile Class

Represents an index data file that stores mappings of index values to references and names

```csharp
public class IndexDataFile : System.Collections.Generic.List<DiGi.GIS.Classes.IndexData>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IndexData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexData 'DiGi\.GIS\.Classes\.IndexData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') → IndexDataFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.IndexDataFile.IndexDataFile()'></a>

## IndexDataFile\(\) Constructor

Initializes a new instance of the IndexDataFile class

```csharp
public IndexDataFile();
```
### Methods

<a name='DiGi.GIS.Classes.IndexDataFile.Read(string)'></a>

## IndexDataFile\.Read\(string\) Method

Reads index data from the specified file path

```csharp
public bool Read(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.IndexDataFile.Read(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file containing index data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was read successfully; otherwise, false\.

<a name='DiGi.GIS.Classes.IndexDataFile.ToString()'></a>

## IndexDataFile\.ToString\(\) Method

Returns a string representation of all index data entries

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A newline\-separated string containing the string representations of each IndexData entry\.

<a name='DiGi.GIS.Classes.IndexDataFile.TryGetIndex(string,int)'></a>

## IndexDataFile\.TryGetIndex\(string, int\) Method

Tries to get the index value associated with the given reference

```csharp
public bool TryGetIndex(string? reference, out int index);
```
#### Parameters

<a name='DiGi.GIS.Classes.IndexDataFile.TryGetIndex(string,int).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string to search for\.

<a name='DiGi.GIS.Classes.IndexDataFile.TryGetIndex(string,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the index value if found; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the index was successfully retrieved; otherwise, false\.

<a name='DiGi.GIS.Classes.IndexDataFile.Write(string)'></a>

## IndexDataFile\.Write\(string\) Method

Writes index data to the specified file path

```csharp
public bool Write(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.IndexDataFile.Write(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path where the index data should be written\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was written successfully; otherwise, false\.

<a name='DiGi.GIS.Classes.OccupancyCalculationResult'></a>

## OccupancyCalculationResult Class

Represents the result of an occupancy calculation, containing area and count information\.

```csharp
public class OccupancyCalculationResult : DiGi.Core.Classes.GuidResult<DiGi.GIS.Classes.Areal2D>, DiGi.GIS.Interfaces.IGISGuidResult, DiGi.GIS.Interfaces.IGISUniqueResult, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult 'DiGi\.Core\.Classes\.GuidResult') → [DiGi\.Core\.Classes\.GuidResult&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1')[Areal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Areal2D 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidresult-1 'DiGi\.Core\.Classes\.GuidResult\`1') → OccupancyCalculationResult

Implements [IGISGuidResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidResult 'DiGi\.GIS\.Interfaces\.IGISGuidResult'), [IGISUniqueResult](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueResult 'DiGi\.GIS\.Interfaces\.IGISUniqueResult'), [DiGi\.Core\.Interfaces\.IUniqueResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueresult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject')
### Constructors

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(DiGi.GIS.Classes.OccupancyCalculationResult)'></a>

## OccupancyCalculationResult\(OccupancyCalculationResult\) Constructor

Initializes a new instance of the OccupancyCalculationResult class as a copy\.

```csharp
public OccupancyCalculationResult(DiGi.GIS.Classes.OccupancyCalculationResult occupancyCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(DiGi.GIS.Classes.OccupancyCalculationResult).occupancyCalculationResult'></a>

`occupancyCalculationResult` [OccupancyCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyCalculationResult 'DiGi\.GIS\.Classes\.OccupancyCalculationResult')

The source result object to copy from\.

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(System.Nullable_double_,System.Nullable_uint_)'></a>

## OccupancyCalculationResult\(Nullable\<double\>, Nullable\<uint\>\) Constructor

Initializes a new instance of the OccupancyCalculationResult class\.

```csharp
public OccupancyCalculationResult(System.Nullable<double> occupancyArea, System.Nullable<uint> occupancy);
```
#### Parameters

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(System.Nullable_double_,System.Nullable_uint_).occupancyArea'></a>

`occupancyArea` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The calculated occupancy area\.

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(System.Nullable_double_,System.Nullable_uint_).occupancy'></a>

`occupancy` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The calculated occupancy count\.

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(System.Text.Json.Nodes.JsonObject)'></a>

## OccupancyCalculationResult\(JsonObject\) Constructor

Initializes a new instance of the OccupancyCalculationResult class from a JSON object\.

```csharp
public OccupancyCalculationResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyCalculationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.Occupancy'></a>

## OccupancyCalculationResult\.Occupancy Property

Gets the occupancy count\.

```csharp
public System.Nullable<uint> Occupancy { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.OccupancyCalculationResult.OccupancyArea'></a>

## OccupancyCalculationResult\.OccupancyArea Property

Gets the occupancy area\.

```csharp
public System.Nullable<double> OccupancyArea { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.OccupancyData'></a>

## OccupancyData Class

Represents occupancy data with occupancy count, area, and reference information

```csharp
public class OccupancyData : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IOccupancyData, DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → OccupancyData

Implements [IOccupancyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IOccupancyData 'DiGi\.GIS\.Interfaces\.IOccupancyData'), [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(DiGi.GIS.Classes.OccupancyData)'></a>

## OccupancyData\(OccupancyData\) Constructor

Initializes a new instance of the OccupancyData class by copying another instance

```csharp
public OccupancyData(DiGi.GIS.Classes.OccupancyData occupancyData);
```
#### Parameters

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(DiGi.GIS.Classes.OccupancyData).occupancyData'></a>

`occupancyData` [OccupancyData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OccupancyData 'DiGi\.GIS\.Classes\.OccupancyData')

The source instance to copy data from\.

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(string,System.Nullable_double_,System.Nullable_uint_)'></a>

## OccupancyData\(string, Nullable\<double\>, Nullable\<uint\>\) Constructor

Initializes a new instance of the OccupancyData class with the specified reference, occupancy area, and occupancy

```csharp
public OccupancyData(string? reference, System.Nullable<double> occupancyArea, System.Nullable<uint> occupancy);
```
#### Parameters

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(string,System.Nullable_double_,System.Nullable_uint_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the occupancy data\.

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(string,System.Nullable_double_,System.Nullable_uint_).occupancyArea'></a>

`occupancyArea` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The total area associated with the occupancy\.

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(string,System.Nullable_double_,System.Nullable_uint_).occupancy'></a>

`occupancy` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The count of occupants\.

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(System.Text.Json.Nodes.JsonObject)'></a>

## OccupancyData\(JsonObject\) Constructor

Initializes a new instance of the OccupancyData class from a JSON object

```csharp
public OccupancyData(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.
### Properties

<a name='DiGi.GIS.Classes.OccupancyData.Occupancy'></a>

## OccupancyData\.Occupancy Property

Gets the occupancy count

```csharp
public System.Nullable<uint> Occupancy { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.OccupancyData.OccupancyArea'></a>

## OccupancyData\.OccupancyArea Property

Gets the occupancy area

```csharp
public System.Nullable<double> OccupancyArea { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.Classes.OccupancyData.Reference'></a>

## OccupancyData\.Reference Property

Gets the reference string

```csharp
public string? Reference { get; }
```

Implements [Reference](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IOccupancyData.Reference 'DiGi\.GIS\.Interfaces\.IOccupancyData\.Reference')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.OrtoData'></a>

## OrtoData Class

Represents orthophoto data, containing the image bytes, timestamp, location, and scale factor\.

```csharp
public class OrtoData : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → OrtoData

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(DiGi.GIS.Classes.OrtoData)'></a>

## OrtoData\(OrtoData\) Constructor

Initializes a new instance of the [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData') class by copying an existing instance\.

```csharp
public OrtoData(DiGi.GIS.Classes.OrtoData? ortoData);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(DiGi.GIS.Classes.OrtoData).ortoData'></a>

`ortoData` [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')

The source orthophoto data to copy from\.

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.DateTime,byte[],double,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## OrtoData\(DateTime, byte\[\], double, Point2D\) Constructor

Initializes a new instance of the [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData') class\.

```csharp
public OrtoData(System.DateTime dateTime, byte[]? bytes, double scale, DiGi.Geometry.Planar.Classes.Point2D? location);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.DateTime,byte[],double,DiGi.Geometry.Planar.Classes.Point2D).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time associated with the orthophoto data\.

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.DateTime,byte[],double,DiGi.Geometry.Planar.Classes.Point2D).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The bitmap image stored as bytes\.

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.DateTime,byte[],double,DiGi.Geometry.Planar.Classes.Point2D).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor of the image\.

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.DateTime,byte[],double,DiGi.Geometry.Planar.Classes.Point2D).location'></a>

`location` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The top\-left corner coordinates of the picture\.

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoData\(JsonObject\) Constructor

Initializes a new instance of the [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData') class from a JSON object\.

```csharp
public OrtoData(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.OrtoData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing orthophoto data\.
### Properties

<a name='DiGi.GIS.Classes.OrtoData.Bytes'></a>

## OrtoData\.Bytes Property

Bitmap image stored in bytes

```csharp
public byte[]? Bytes { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Classes.OrtoData.DateTime'></a>

## OrtoData\.DateTime Property

Gets the date and time associated with the orthophoto data\.

```csharp
public System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.GIS.Classes.OrtoData.Location'></a>

## OrtoData\.Location Property

Top left corner of picture stored in bytes

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Location { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.GIS.Classes.OrtoData.Scale'></a>

## OrtoData\.Scale Property

Gets the scale factor of the orthophoto\.

```csharp
public double Scale { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.GIS.Classes.OrtoData.FromOrto(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## OrtoData\.FromOrto\(Point2D\) Method

Transforms a point from orthophoto coordinates to world/GIS coordinates\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? FromOrto(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.FromOrto(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point in orthophoto coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The transformed point in world/GIS coordinates, or null if the input is null\.

<a name='DiGi.GIS.Classes.OrtoData.FromOrto(DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## OrtoData\.FromOrto\(PolygonalFace2D\) Method

Transforms a polygonal face from orthophoto coordinates to world/GIS coordinates\.

```csharp
public DiGi.Geometry.Planar.Classes.PolygonalFace2D? FromOrto(DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.FromOrto(DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face in orthophoto coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
The transformed polygonal face in world/GIS coordinates, or null if the input is null\.

<a name='DiGi.GIS.Classes.OrtoData.FromOrto(DiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## OrtoData\.FromOrto\(IPolygonal2D\) Method

Transforms a polygonal object from orthophoto coordinates to world/GIS coordinates\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IPolygonal2D? FromOrto(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.FromOrto(DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal object in orthophoto coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
The transformed polygonal object in world/GIS coordinates, or null if the input is null\.

<a name='DiGi.GIS.Classes.OrtoData.GetBoundingBox(DiGi.GIS.Enums.GeometryContext)'></a>

## OrtoData\.GetBoundingBox\(GeometryContext\) Method

Calculates the bounding box of the orthophoto data based on the specified geometry context\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox(DiGi.GIS.Enums.GeometryContext geometryContext);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.GetBoundingBox(DiGi.GIS.Enums.GeometryContext).geometryContext'></a>

`geometryContext` [GeometryContext](DiGi.GIS.Enums.md#DiGi.GIS.Enums.GeometryContext 'DiGi\.GIS\.Enums\.GeometryContext')

The coordinate system context \(Local or Global\) for the bounding box\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') representing the area, or null if location is missing or context is undefined\.

<a name='DiGi.GIS.Classes.OrtoData.GetSize(DiGi.GIS.Enums.GeometryContext)'></a>

## OrtoData\.GetSize\(GeometryContext\) Method

Retrieves the dimensions of the orthophoto image, adjusted for the specified geometry context\.

```csharp
public DiGi.Core.Classes.Size? GetSize(DiGi.GIS.Enums.GeometryContext geometryContext);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.GetSize(DiGi.GIS.Enums.GeometryContext).geometryContext'></a>

`geometryContext` [GeometryContext](DiGi.GIS.Enums.md#DiGi.GIS.Enums.GeometryContext 'DiGi\.GIS\.Enums\.GeometryContext')

The coordinate system context \(Local or Global\) to determine scaling\.

#### Returns
[DiGi\.Core\.Classes\.Size](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.size 'DiGi\.Core\.Classes\.Size')  
A [DiGi\.Core\.Classes\.Size](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.size 'DiGi\.Core\.Classes\.Size') object containing width and height, or null if undefined or bytes are missing\.

<a name='DiGi.GIS.Classes.OrtoData.ToOrto(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## OrtoData\.ToOrto\(Point2D\) Method

Transforms a point from world/GIS coordinates to orthophoto coordinates\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ToOrto(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.ToOrto(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point in world/GIS coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The transformed point in orthophoto coordinates, or null if the input is null\.

<a name='DiGi.GIS.Classes.OrtoData.ToOrto(DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## OrtoData\.ToOrto\(PolygonalFace2D\) Method

Transforms a polygonal face from world/GIS coordinates to orthophoto coordinates\.

```csharp
public DiGi.Geometry.Planar.Classes.PolygonalFace2D? ToOrto(DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.ToOrto(DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face in world/GIS coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
The transformed polygonal face in orthophoto coordinates, or null if the input is null\.

<a name='DiGi.GIS.Classes.OrtoData.ToOrto(DiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## OrtoData\.ToOrto\(IPolygonal2D\) Method

Transforms a polygonal object from world/GIS coordinates to orthophoto coordinates\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IPolygonal2D? ToOrto(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoData.ToOrto(DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal object in world/GIS coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
The transformed polygonal object in orthophoto coordinates, or null if the input is null\.

<a name='DiGi.GIS.Classes.OrtoDatas'></a>

## OrtoDatas Class

Represents a collection of orthophoto data, providing functionality to manage and retrieve spatial and temporal information\.

```csharp
public class OrtoDatas : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoData>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → OrtoDatas

Implements [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(DiGi.GIS.Classes.OrtoDatas)'></a>

## OrtoDatas\(OrtoDatas\) Constructor

Initializes a new instance of the OrtoDatas class by copying an existing instance\.

```csharp
public OrtoDatas(DiGi.GIS.Classes.OrtoDatas? ortoDatas);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(DiGi.GIS.Classes.OrtoDatas).ortoDatas'></a>

`ortoDatas` [OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')

The source orthophoto data collection to copy from\.

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoData_)'></a>

## OrtoDatas\(string, IEnumerable\<OrtoData\>\) Constructor

Initializes a new instance of the OrtoDatas class with a specified reference and values\.

```csharp
public OrtoDatas(string? reference, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoData>? values);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoData_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the orthophoto data\.

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoData_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of orthophoto data entries\.

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatas\(JsonObject\) Constructor

Initializes a new instance of the OrtoDatas class from a JSON object\.

```csharp
public OrtoDatas(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.OrtoDatas(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the orthophoto data\.
### Properties

<a name='DiGi.GIS.Classes.OrtoDatas.Reference'></a>

## OrtoDatas\.Reference Property

Gets the reference identifier associated with the orthophoto data collection\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.GIS.Classes.OrtoDatas.GetBoundingBox(DiGi.GIS.Enums.GeometryContext)'></a>

## OrtoDatas\.GetBoundingBox\(GeometryContext\) Method

Calculates the bounding box that encompasses all orthophoto data in the collection based on the provided geometry context\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox(DiGi.GIS.Enums.GeometryContext geometryContext);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.GetBoundingBox(DiGi.GIS.Enums.GeometryContext).geometryContext'></a>

`geometryContext` [GeometryContext](DiGi.GIS.Enums.md#DiGi.GIS.Enums.GeometryContext 'DiGi\.GIS\.Enums\.GeometryContext')

The context used to determine the coordinate system or projection for the bounding box\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') containing all entries, or null if no valid data exists or the context is undefined\.

<a name='DiGi.GIS.Classes.OrtoDatas.GetBytes(System.DateTime)'></a>

## OrtoDatas\.GetBytes\(DateTime\) Method

Retrieves the raw bytes of the orthophoto data for a specific date\.

```csharp
public byte[]? GetBytes(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.GetBytes(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date for which to retrieve the bytes\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array containing the orthophoto data, or null if no data is found for the specified date\.

<a name='DiGi.GIS.Classes.OrtoDatas.GetEnumerator()'></a>

## OrtoDatas\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')\.

```csharp
public System.Collections.Generic.IEnumerator<DiGi.GIS.Classes.OrtoData> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the orthophoto data collection\.

<a name='DiGi.GIS.Classes.OrtoDatas.GetOrtoData(System.DateTime)'></a>

## OrtoDatas\.GetOrtoData\(DateTime\) Method

Retrieves the orthophoto data object for a specific date, or the closest available entry preceding that date\.

```csharp
public DiGi.GIS.Classes.OrtoData? GetOrtoData(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.GetOrtoData(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The target date to search for\.

#### Returns
[OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData')  
The [OrtoData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoData 'DiGi\.GIS\.Classes\.OrtoData') object associated with the specified date or the nearest lower value; otherwise, null\.

<a name='DiGi.GIS.Classes.OrtoDatas.Reduce()'></a>

## OrtoDatas\.Reduce\(\) Method

Reduces the collection by removing redundant entries where the binary data is identical to the preceding entry\.

```csharp
public void Reduce();
```

<a name='DiGi.GIS.Classes.OrtoDatas.TryGetDateTime(System.DateTime,System.DateTime)'></a>

## OrtoDatas\.TryGetDateTime\(DateTime, DateTime\) Method

Attempts to retrieve the minimum and maximum dates present in the orthophoto data collection\.

```csharp
public bool TryGetDateTime(out System.DateTime dateTime_Min, out System.DateTime dateTime_Max);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.TryGetDateTime(System.DateTime,System.DateTime).dateTime_Min'></a>

`dateTime_Min` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

When this method returns, contains the earliest date in the collection if successful\.

<a name='DiGi.GIS.Classes.OrtoDatas.TryGetDateTime(System.DateTime,System.DateTime).dateTime_Max'></a>

`dateTime_Max` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

When this method returns, contains the latest date in the collection if successful\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the dates were successfully retrieved; otherwise, false\.

<a name='DiGi.GIS.Classes.OrtoDatas.TryGetYears(System.Collections.Generic.HashSet_int_)'></a>

## OrtoDatas\.TryGetYears\(HashSet\<int\>\) Method

Attempts to retrieve the set of years covered by the orthophoto data collection\.

```csharp
public bool TryGetYears(out System.Collections.Generic.HashSet<int>? years);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatas.TryGetYears(System.Collections.Generic.HashSet_int_).years'></a>

`years` [System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

When this method returns, contains a hash set of all years between the minimum and maximum dates in the collection, or null if retrieval fails\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the range of years was successfully determined; otherwise, false\.
### Explicit Interface Implementations

<a name='DiGi.GIS.Classes.OrtoDatas.System.Collections.IEnumerable.GetEnumerator()'></a>

## System\.Collections\.IEnumerable\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection\.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions'></a>

## OrtoDatasBuilding2DOptions Class

Provides configuration options for 2D building ortho data\.

```csharp
public class OrtoDatasBuilding2DOptions : DiGi.GIS.Classes.OrtoDatasOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') → [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') → OrtoDatasBuilding2DOptions
### Constructors

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions()'></a>

## OrtoDatasBuilding2DOptions\(\) Constructor

Initializes a new instance of the [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions') class using default settings and building\-specific directory names\.

```csharp
public OrtoDatasBuilding2DOptions();
```

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range_int_,double,double,bool,ulong)'></a>

## OrtoDatasBuilding2DOptions\(Range\<int\>, double, double, bool, ulong\) Constructor

Initializes a new instance of the [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions') class with specified parameters\.

```csharp
public OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range<int> years, double offset, double width, bool reduce, ulong maxFileSize);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range_int_,double,double,bool,ulong).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years to consider\.

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range_int_,double,double,bool,ulong).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset value\.

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range_int_,double,double,bool,ulong).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width value\.

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range_int_,double,double,bool,ulong).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the data\.

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.Core.Classes.Range_int_,double,double,bool,ulong).maxFileSize'></a>

`maxFileSize` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The maximum allowed file size\.

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.GIS.Classes.OrtoDatasBuilding2DOptions)'></a>

## OrtoDatasBuilding2DOptions\(OrtoDatasBuilding2DOptions\) Constructor

Initializes a new instance of the [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions') class by copying values from another instance\.

```csharp
public OrtoDatasBuilding2DOptions(DiGi.GIS.Classes.OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(DiGi.GIS.Classes.OrtoDatasBuilding2DOptions).ortoDatasBuilding2DOptions'></a>

`ortoDatasBuilding2DOptions` [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions')

The source options instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasBuilding2DOptions\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions') class from a JSON object\.

```csharp
public OrtoDatasBuilding2DOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.OrtoDatasBuilding2DOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the configuration data\.
### Properties

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.Offset'></a>

## OrtoDatasBuilding2DOptions\.Offset Property

Gets or sets the offset value for the 2D building ortho data\.

```csharp
public double Offset { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.OrtoDatasBuilding2DOptions.Width'></a>

## OrtoDatasBuilding2DOptions\.Width Property

Gets or sets the width value for the 2D building ortho data\.

```csharp
public double Width { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.OrtoDatasFile'></a>

## OrtoDatasFile Class

Represents a storage file for orthodata information, providing functionality to manage and reference orthodata files\.

```csharp
public class OrtoDatasFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.GIS.Classes.OrtoDatas>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → OrtoDatasFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.OrtoDatasFile.OrtoDatasFile(DiGi.GIS.Classes.OrtoDatasFile)'></a>

## OrtoDatasFile\(OrtoDatasFile\) Constructor

Initializes a new instance of the [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile') class by copying an existing instance\.

```csharp
public OrtoDatasFile(DiGi.GIS.Classes.OrtoDatasFile? ortoDatasFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasFile.OrtoDatasFile(DiGi.GIS.Classes.OrtoDatasFile).ortoDatasFile'></a>

`ortoDatasFile` [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile')

The source [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile') instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoDatasFile.OrtoDatasFile(string)'></a>

## OrtoDatasFile\(string\) Constructor

Initializes a new instance of the [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile') class using the specified file path\.

```csharp
public OrtoDatasFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasFile.OrtoDatasFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The system path to the orthodata storage file\.

<a name='DiGi.GIS.Classes.OrtoDatasFile.OrtoDatasFile(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasFile\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile') class using data from a JSON object\.

```csharp
public OrtoDatasFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasFile.OrtoDatasFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the file data\.
### Methods

<a name='DiGi.GIS.Classes.OrtoDatasFile.GetUniqueReference(DiGi.GIS.Classes.OrtoDatas)'></a>

## OrtoDatasFile\.GetUniqueReference\(OrtoDatas\) Method

Gets the unique reference associated with the specified orthodata object\.

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.GIS.Classes.OrtoDatas? ortoDatas);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasFile.GetUniqueReference(DiGi.GIS.Classes.OrtoDatas).ortoDatas'></a>

`ortoDatas` [OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')

The orthodata object for which to retrieve the unique reference\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') if the orthodata is provided; otherwise, null\.

<a name='DiGi.GIS.Classes.OrtoDatasFile.GetUniqueReference(string)'></a>

## OrtoDatasFile\.GetUniqueReference\(string\) Method

Creates a unique reference based on the provided string identifier\.

```csharp
public static DiGi.Core.Classes.UniqueReference? GetUniqueReference(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasFile.GetUniqueReference(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string identifier used to create the unique reference\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') if the reference is not null; otherwise, null\.

<a name='DiGi.GIS.Classes.OrtoDatasOptions'></a>

## OrtoDatasOptions Class

Provides options for configuring orthophoto data retrieval and processing settings\.

```csharp
public abstract class OrtoDatasOptions : DiGi.GIS.Classes.DirectoryNamesOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') → OrtoDatasOptions

Derived  
↳ [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions')  
↳ [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions')
### Constructors

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions()'></a>

## OrtoDatasOptions\(\) Constructor

Initializes a new instance of the [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') class\.

```csharp
public OrtoDatasOptions();
```

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(DiGi.Core.Classes.Range_int_,bool,ulong)'></a>

## OrtoDatasOptions\(Range\<int\>, bool, ulong\) Constructor

Initializes a new instance of the [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') class with specified years, reduction flag, and maximum file size\.

```csharp
public OrtoDatasOptions(DiGi.Core.Classes.Range<int> years, bool reduce, ulong maxFileSize);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(DiGi.Core.Classes.Range_int_,bool,ulong).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years to be considered\.

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(DiGi.Core.Classes.Range_int_,bool,ulong).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce data\.

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(DiGi.Core.Classes.Range_int_,bool,ulong).maxFileSize'></a>

`maxFileSize` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The maximum allowed file size in bytes\.

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(DiGi.GIS.Classes.OrtoDatasOptions)'></a>

## OrtoDatasOptions\(OrtoDatasOptions\) Constructor

Initializes a new instance of the [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') class by copying values from an existing [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') instance\.

```csharp
public OrtoDatasOptions(DiGi.GIS.Classes.OrtoDatasOptions ortoDatasOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(DiGi.GIS.Classes.OrtoDatasOptions).ortoDatasOptions'></a>

`ortoDatasOptions` [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions')

The source options instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasOptions\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') class using a JSON object\.

```csharp
public OrtoDatasOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasOptions.OrtoDatasOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing configuration data\.
### Properties

<a name='DiGi.GIS.Classes.OrtoDatasOptions.MaxFileSize'></a>

## OrtoDatasOptions\.MaxFileSize Property

Max file size in bytes\. ulong\.MaxValue value will keep one file

```csharp
public ulong MaxFileSize { get; set; }
```

#### Property Value
[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

<a name='DiGi.GIS.Classes.OrtoDatasOptions.Reduce'></a>

## OrtoDatasOptions\.Reduce Property

Gets or sets a value indicating whether to reduce the data size or resolution\.

```csharp
public bool Reduce { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.OrtoDatasOptions.Years'></a>

## OrtoDatasOptions\.Years Property

Gets or sets the range of years to be considered for orthophoto data\.

```csharp
public DiGi.Core.Classes.Range<int> Years { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions'></a>

## OrtoDatasOrtoRangeOptions Class

Represents the options used for filtering and retrieving orthodata within a specific range, including scale settings\.

```csharp
public class OrtoDatasOrtoRangeOptions : DiGi.GIS.Classes.OrtoDatasOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') → [OrtoDatasOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOptions 'DiGi\.GIS\.Classes\.OrtoDatasOptions') → OrtoDatasOrtoRangeOptions
### Constructors

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions()'></a>

## OrtoDatasOrtoRangeOptions\(\) Constructor

Initializes a new instance of the [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions') class with default values and initializes directory names\.

```csharp
public OrtoDatasOrtoRangeOptions();
```

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.Core.Classes.Range_int_,double,bool,ulong)'></a>

## OrtoDatasOrtoRangeOptions\(Range\<int\>, double, bool, ulong\) Constructor

Initializes a new instance of the [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions') class with specified year range, scale, reduction preference, and maximum file size\.

```csharp
public OrtoDatasOrtoRangeOptions(DiGi.Core.Classes.Range<int> years, double scale, bool reduce, ulong maxFileSize);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.Core.Classes.Range_int_,double,bool,ulong).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years to filter the orthodata\.

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.Core.Classes.Range_int_,double,bool,ulong).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor for the orthodata\.

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.Core.Classes.Range_int_,double,bool,ulong).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the data\.

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.Core.Classes.Range_int_,double,bool,ulong).maxFileSize'></a>

`maxFileSize` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The maximum allowed file size\.

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions)'></a>

## OrtoDatasOrtoRangeOptions\(OrtoDatasOrtoRangeOptions\) Constructor

Initializes a new instance of the [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions') class by copying values from an existing options instance\.

```csharp
public OrtoDatasOrtoRangeOptions(DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions ortoDatasOrtoRangeOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions).ortoDatasOrtoRangeOptions'></a>

`ortoDatasOrtoRangeOptions` [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions')

The source options instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasOrtoRangeOptions\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions') class from a JSON object\.

```csharp
public OrtoDatasOrtoRangeOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.OrtoDatasOrtoRangeOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the options data\.
### Properties

<a name='DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions.Scale'></a>

## OrtoDatasOrtoRangeOptions\.Scale Property

Gets or sets the scale factor applied to the orthodata range\.

```csharp
public double Scale { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.OrtoRange'></a>

## OrtoRange Class

Represents an [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') object that inherits from [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') and implements the [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject') interface\.

```csharp
public class OrtoRange : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → OrtoRange

Implements [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_)'></a>

## OrtoRange\(BoundingBox2D, IEnumerable\<string\>, IEnumerable\<string\>\) Constructor

Initializes a new instance of the [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') class\.

```csharp
public OrtoRange(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<string>? references_Inside, System.Collections.Generic.IEnumerable<string>? references_Intersect);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The optional [BoundingBox2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange.BoundingBox2D 'DiGi\.GIS\.Classes\.OrtoRange\.BoundingBox2D') that defines the spatial boundaries of the range\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).references_Inside'></a>

`references_Inside` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') containing references located inside the range\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).references_Intersect'></a>

`references_Intersect` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') containing references that intersect with the range\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(DiGi.GIS.Classes.OrtoRange)'></a>

## OrtoRange\(OrtoRange\) Constructor

Initializes a new instance of the [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') class using the specified [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') instance\.

```csharp
public OrtoRange(DiGi.GIS.Classes.OrtoRange? ortoRange);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(DiGi.GIS.Classes.OrtoRange).ortoRange'></a>

`ortoRange` [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')

The [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Guid,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_)'></a>

## OrtoRange\(Guid, BoundingBox2D, IEnumerable\<string\>, IEnumerable\<string\>\) Constructor

Initializes a new instance of the [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') class\.

```csharp
public OrtoRange(System.Guid guid, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<string>? references_Inside, System.Collections.Generic.IEnumerable<string>? references_Intersect);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Guid,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Guid,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The optional [BoundingBox2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange.BoundingBox2D 'DiGi\.GIS\.Classes\.OrtoRange\.BoundingBox2D') that defines the spatial boundaries of the range\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Guid,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).references_Inside'></a>

`references_Inside` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') references located inside the range\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Guid,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_).references_Intersect'></a>

`references_Intersect` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') references that intersect with the range\.

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoRange\(JsonObject\) Constructor

Initializes a new instance of the [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public OrtoRange(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.OrtoRange(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Properties

<a name='DiGi.GIS.Classes.OrtoRange.BoundingBox2D'></a>

## OrtoRange\.BoundingBox2D Property

Gets or sets the [BoundingBox2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange.BoundingBox2D 'DiGi\.GIS\.Classes\.OrtoRange\.BoundingBox2D') that defines the axis\-aligned bounding box of the object in two\-dimensional space\.
This value is null if no bounding box is defined\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox2D { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

<a name='DiGi.GIS.Classes.OrtoRange.References_InRange'></a>

## OrtoRange\.References\_InRange Property

Gets or sets the [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') references that are within the specified range\.

```csharp
public System.Collections.Generic.HashSet<string>? References_InRange { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing string references, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no references are in range\.

<a name='DiGi.GIS.Classes.OrtoRange.References_Inside'></a>

## OrtoRange\.References\_Inside Property

Gets or sets a [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') values representing the references contained inside the current object\.

```csharp
public System.Collections.Generic.HashSet<string>? References_Inside { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.GIS.Classes.OrtoRange.References_Intersect'></a>

## OrtoRange\.References\_Intersect Property

Gets or sets a [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') of [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') objects representing the intersection of references\.

```csharp
public System.Collections.Generic.HashSet<string>? References_Intersect { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.GIS.Classes.OrtoRange.Contains(string)'></a>

## OrtoRange\.Contains\(string\) Method

Determines whether the collection contains a specific string reference\.

```csharp
public bool Contains(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.Contains(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') reference to locate in the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the specified [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') was found\.

<a name='DiGi.GIS.Classes.OrtoRange.InRange(string)'></a>

## OrtoRange\.InRange\(string\) Method

Determines whether the specified reference is within the valid range\.

```csharp
public bool InRange(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.InRange(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') reference to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') reference is in range\.

<a name='DiGi.GIS.Classes.OrtoRange.Inside(string)'></a>

## OrtoRange\.Inside\(string\) Method

Determines whether the specified reference is contained within the current context\.

```csharp
public bool Inside(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.Inside(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string reference to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A boolean value indicating true if the reference is inside; otherwise, false\.

<a name='DiGi.GIS.Classes.OrtoRange.Intersect(string)'></a>

## OrtoRange\.Intersect\(string\) Method

Determines whether there is an intersection with the specified reference string\.

```csharp
public bool Intersect(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRange.Intersect(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The nullable [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') reference to intersect with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the intersection occurred\.

<a name='DiGi.GIS.Classes.OrtoRangeFile'></a>

## OrtoRangeFile Class

Represents a file storage object specifically for OrtoRange data, providing functionality to manage and reference OrtoRange files\.

```csharp
public class OrtoRangeFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.GIS.Classes.OrtoRange>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → OrtoRangeFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.OrtoRangeFile.OrtoRangeFile(DiGi.GIS.Classes.OrtoRangeFile)'></a>

## OrtoRangeFile\(OrtoRangeFile\) Constructor

Initializes a new instance of the [OrtoRangeFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeFile 'DiGi\.GIS\.Classes\.OrtoRangeFile') class by copying an existing OrtoRangeFile instance\.

```csharp
public OrtoRangeFile(DiGi.GIS.Classes.OrtoRangeFile? ortoRangeFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeFile.OrtoRangeFile(DiGi.GIS.Classes.OrtoRangeFile).ortoRangeFile'></a>

`ortoRangeFile` [OrtoRangeFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeFile 'DiGi\.GIS\.Classes\.OrtoRangeFile')

The source [OrtoRangeFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeFile 'DiGi\.GIS\.Classes\.OrtoRangeFile') instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoRangeFile.OrtoRangeFile(string)'></a>

## OrtoRangeFile\(string\) Constructor

Initializes a new instance of the [OrtoRangeFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeFile 'DiGi\.GIS\.Classes\.OrtoRangeFile') class using a specified file path\.

```csharp
public OrtoRangeFile(string path);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeFile.OrtoRangeFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The system path to the OrtoRange file\.

<a name='DiGi.GIS.Classes.OrtoRangeFile.OrtoRangeFile(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoRangeFile\(JsonObject\) Constructor

Initializes a new instance of the [OrtoRangeFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeFile 'DiGi\.GIS\.Classes\.OrtoRangeFile') class using data from a JSON object\.

```csharp
public OrtoRangeFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeFile.OrtoRangeFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the file information\.
### Methods

<a name='DiGi.GIS.Classes.OrtoRangeFile.GetUniqueReference(DiGi.GIS.Classes.OrtoRange)'></a>

## OrtoRangeFile\.GetUniqueReference\(OrtoRange\) Method

Gets the unique reference for the specified OrtoRange object\.

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.GIS.Classes.OrtoRange? ortoRange);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeFile.GetUniqueReference(DiGi.GIS.Classes.OrtoRange).ortoRange'></a>

`ortoRange` [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')

The OrtoRange object to retrieve the unique reference from\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') associated with the OrtoRange object, or null if the provided object is null\.

<a name='DiGi.GIS.Classes.OrtoRangeFile.GetUniqueReference(string)'></a>

## OrtoRangeFile\.GetUniqueReference\(string\) Method

Gets the unique reference based on a string identifier\.

```csharp
public static DiGi.Core.Classes.UniqueReference? GetUniqueReference(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeFile.GetUniqueReference(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string identifier used to create the unique reference\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') created from the provided string, or null if the reference is null\.

<a name='DiGi.GIS.Classes.OrtoRangeOptions'></a>

## OrtoRangeOptions Class

Provides options for specifying the range of an orthophoto, including width and height dimensions\.

```csharp
public class OrtoRangeOptions : DiGi.Core.Classes.SerializableOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → OrtoRangeOptions
### Constructors

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions()'></a>

## OrtoRangeOptions\(\) Constructor

Initializes a new instance of the [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions') class\.

```csharp
public OrtoRangeOptions();
```

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(DiGi.GIS.Classes.OrtoRangeOptions)'></a>

## OrtoRangeOptions\(OrtoRangeOptions\) Constructor

Initializes a new instance of the [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions') class by copying values from an existing [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions') instance\.

```csharp
public OrtoRangeOptions(DiGi.GIS.Classes.OrtoRangeOptions ortoRangeOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(DiGi.GIS.Classes.OrtoRangeOptions).ortoRangeOptions'></a>

`ortoRangeOptions` [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions')

The source options instance to copy from\.

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(double,double)'></a>

## OrtoRangeOptions\(double, double\) Constructor

Initializes a new instance of the [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions') class with specified width and height\.

```csharp
public OrtoRangeOptions(double width, double height);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the orthophoto range\.

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the orthophoto range\.

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoRangeOptions\(JsonObject\) Constructor

Initializes a new instance of the [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions') class using a JSON object\.

```csharp
public OrtoRangeOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OrtoRangeOptions.OrtoRangeOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the range options data\.
### Properties

<a name='DiGi.GIS.Classes.OrtoRangeOptions.Height'></a>

## OrtoRangeOptions\.Height Property

Gets or sets the height of the orthophoto range\.

```csharp
public double Height { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.OrtoRangeOptions.Width'></a>

## OrtoRangeOptions\.Width Property

Gets or sets the width of the orthophoto range\.

```csharp
public double Width { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.OtherYearBuilt'></a>

## OtherYearBuilt Class

Represents a year built value where the source is categorized as other\.

```csharp
public abstract class OtherYearBuilt : DiGi.GIS.Classes.YearBuilt
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') → OtherYearBuilt
### Constructors

<a name='DiGi.GIS.Classes.OtherYearBuilt.OtherYearBuilt(short)'></a>

## OtherYearBuilt\(short\) Constructor

Initializes a new instance of the [OtherYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OtherYearBuilt 'DiGi\.GIS\.Classes\.OtherYearBuilt') class with the specified year\.

```csharp
public OtherYearBuilt(short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.OtherYearBuilt.OtherYearBuilt(short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year to be assigned\.

<a name='DiGi.GIS.Classes.OtherYearBuilt.OtherYearBuilt(System.Text.Json.Nodes.JsonObject)'></a>

## OtherYearBuilt\(JsonObject\) Constructor

Initializes a new instance of the [OtherYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OtherYearBuilt 'DiGi\.GIS\.Classes\.OtherYearBuilt') class using the provided JSON object\.

```csharp
public OtherYearBuilt(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.OtherYearBuilt.OtherYearBuilt(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing year built data\.
### Properties

<a name='DiGi.GIS.Classes.OtherYearBuilt.YearBuiltSource'></a>

## OtherYearBuilt\.YearBuiltSource Property

Gets the source of the year built, which is always set to [Other](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource.Other 'DiGi\.GIS\.Enums\.YearBuiltSource\.Other')\.

```csharp
public override DiGi.GIS.Enums.YearBuiltSource YearBuiltSource { get; }
```

Implements [YearBuiltSource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.YearBuiltSource 'DiGi\.GIS\.Interfaces\.IYearBuilt\.YearBuiltSource')

#### Property Value
[YearBuiltSource](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource 'DiGi\.GIS\.Enums\.YearBuiltSource')

<a name='DiGi.GIS.Classes.PredictedYearBuilt'></a>

## PredictedYearBuilt Class

Represents a year built value that has been predicted, including the date and time of the prediction\.

```csharp
public sealed class PredictedYearBuilt : DiGi.GIS.Classes.YearBuilt
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') → PredictedYearBuilt
### Constructors

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(DiGi.GIS.Classes.PredictedYearBuilt)'></a>

## PredictedYearBuilt\(PredictedYearBuilt\) Constructor

Initializes a new instance of the [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt') class by copying another instance\.

```csharp
public PredictedYearBuilt(DiGi.GIS.Classes.PredictedYearBuilt predictedYearBuilt);
```
#### Parameters

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(DiGi.GIS.Classes.PredictedYearBuilt).predictedYearBuilt'></a>

`predictedYearBuilt` [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt')

The existing predicted year built instance to copy from\.

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(System.DateTime,short)'></a>

## PredictedYearBuilt\(DateTime, short\) Constructor

Initializes a new instance of the [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt') class with a specific date time and year\.

```csharp
public PredictedYearBuilt(System.DateTime dateTime, short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(System.DateTime,short).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time when the prediction was made\.

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(System.DateTime,short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The predicted year built\.

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(System.Text.Json.Nodes.JsonObject)'></a>

## PredictedYearBuilt\(JsonObject\) Constructor

Initializes a new instance of the [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt') class from a JSON object\.

```csharp
public PredictedYearBuilt(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.PredictedYearBuilt.PredictedYearBuilt(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for initialization\.
### Properties

<a name='DiGi.GIS.Classes.PredictedYearBuilt.DateTime'></a>

## PredictedYearBuilt\.DateTime Property

Gets the date and time when the prediction was made\.

```csharp
public System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.GIS.Classes.PredictedYearBuilt.Source'></a>

## PredictedYearBuilt\.Source Property

Gets the source identifier for the predicted year built, combining the source type and ticks of the prediction date\.

```csharp
public override string Source { get; }
```

Implements [Source](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.Source 'DiGi\.GIS\.Interfaces\.IYearBuilt\.Source')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.PredictedYearBuilt.YearBuiltSource'></a>

## PredictedYearBuilt\.YearBuiltSource Property

Gets the source of the year built value, which is always set to prediction\.

```csharp
public override DiGi.GIS.Enums.YearBuiltSource YearBuiltSource { get; }
```

Implements [YearBuiltSource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.YearBuiltSource 'DiGi\.GIS\.Interfaces\.IYearBuilt\.YearBuiltSource')

#### Property Value
[YearBuiltSource](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource 'DiGi\.GIS\.Enums\.YearBuiltSource')

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions'></a>

## PredictionTableConversionOptions Class

Provides options for the conversion of prediction tables\.

```csharp
public class PredictionTableConversionOptions : DiGi.GIS.Classes.TableConversionOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [TableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.TableConversionOptions 'DiGi\.GIS\.Classes\.TableConversionOptions') → PredictionTableConversionOptions
### Constructors

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.PredictionTableConversionOptions()'></a>

## PredictionTableConversionOptions\(\) Constructor

Initializes a new instance of the [PredictionTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictionTableConversionOptions 'DiGi\.GIS\.Classes\.PredictionTableConversionOptions') class\.

```csharp
public PredictionTableConversionOptions();
```

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.PredictionTableConversionOptions(DiGi.GIS.Classes.PredictionTableConversionOptions)'></a>

## PredictionTableConversionOptions\(PredictionTableConversionOptions\) Constructor

Initializes a new instance of the [PredictionTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictionTableConversionOptions 'DiGi\.GIS\.Classes\.PredictionTableConversionOptions') class using an existing options object\.

```csharp
public PredictionTableConversionOptions(DiGi.GIS.Classes.PredictionTableConversionOptions predictionTableConversionOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.PredictionTableConversionOptions(DiGi.GIS.Classes.PredictionTableConversionOptions).predictionTableConversionOptions'></a>

`predictionTableConversionOptions` [PredictionTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictionTableConversionOptions 'DiGi\.GIS\.Classes\.PredictionTableConversionOptions')

The source options instance to copy values from\.

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.PredictionTableConversionOptions(System.Text.Json.Nodes.JsonObject)'></a>

## PredictionTableConversionOptions\(JsonObject\) Constructor

Initializes a new instance of the [PredictionTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictionTableConversionOptions 'DiGi\.GIS\.Classes\.PredictionTableConversionOptions') class from a JSON object\.

```csharp
public PredictionTableConversionOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.PredictionTableConversionOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the configuration data\.
### Properties

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.AdministrativeAreal2DsIndexDataFilePath'></a>

## PredictionTableConversionOptions\.AdministrativeAreal2DsIndexDataFilePath Property

Gets or sets the file path to the administrative areal 2D index data\.

```csharp
public string? AdministrativeAreal2DsIndexDataFilePath { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.PredictionTableConversionOptions.IncludeYearBuiltPredictions'></a>

## PredictionTableConversionOptions\.IncludeYearBuiltPredictions Property

Gets or sets a value indicating whether year built predictions should be included in the conversion process\.

```csharp
public bool IncludeYearBuiltPredictions { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.Source'></a>

## Source Class

Represents an abstract base class for source objects within the GIS system\.

```csharp
public abstract class Source : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.ISource, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → Source

Derived  
↳ [DirectorySource](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectorySource 'DiGi\.GIS\.Classes\.DirectorySource')

Implements [ISource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.ISource 'DiGi\.GIS\.Interfaces\.ISource'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.GIS.Classes.Source.Source()'></a>

## Source\(\) Constructor

Initializes a new instance of the [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source') class\.

```csharp
public Source();
```

<a name='DiGi.GIS.Classes.Source.Source(DiGi.GIS.Classes.Source)'></a>

## Source\(Source\) Constructor

Initializes a new instance of the [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source') class as a copy of an existing source\.

```csharp
public Source(DiGi.GIS.Classes.Source? source);
```
#### Parameters

<a name='DiGi.GIS.Classes.Source.Source(DiGi.GIS.Classes.Source).source'></a>

`source` [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source')

The source object to copy from\.

<a name='DiGi.GIS.Classes.Source.Source(System.Text.Json.Nodes.JsonObject)'></a>

## Source\(JsonObject\) Constructor

Initializes a new instance of the [Source](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Source 'DiGi\.GIS\.Classes\.Source') class from a JSON object\.

```csharp
public Source(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.Source.Source(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the source data\.

<a name='DiGi.GIS.Classes.StatisticalData'></a>

## StatisticalData Class

Represents the base class for statistical data, providing common properties such as name and reference\.

```csharp
public abstract class StatisticalData : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IStatisticalData, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → StatisticalData

Derived  
↳ [StatisticalYearlyData&lt;T&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')

Implements [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(DiGi.GIS.Classes.StatisticalData)'></a>

## StatisticalData\(StatisticalData\) Constructor

Initializes a new instance of the [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData') class by copying an existing statistical data object\.

```csharp
public StatisticalData(DiGi.GIS.Classes.StatisticalData? statisticalData);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(DiGi.GIS.Classes.StatisticalData).statisticalData'></a>

`statisticalData` [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData')

The source statistical data object to copy from\.

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(string,string)'></a>

## StatisticalData\(string, string\) Constructor

Initializes a new instance of the [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData') class\.

```csharp
public StatisticalData(string? name, string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(string,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalData\(JsonObject\) Constructor

Initializes a new instance of the [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData') class using a JSON object\.

```csharp
public StatisticalData(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalData.StatisticalData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.
### Properties

<a name='DiGi.GIS.Classes.StatisticalData.Name'></a>

## StatisticalData\.Name Property

Gets the name of the statistical data\.

```csharp
public string? Name { get; }
```

Implements [Name](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData.Name 'DiGi\.GIS\.Interfaces\.IStatisticalData\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.StatisticalData.Reference'></a>

## StatisticalData\.Reference Property

Gets the reference identifier of the statistical data\.

```csharp
public string? Reference { get; }
```

Implements [Reference](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData.Reference 'DiGi\.GIS\.Interfaces\.IStatisticalData\.Reference')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.StatisticalDataCollection'></a>

## StatisticalDataCollection Class

Represents a collection of statistical data associated with a specific unit code and identifier\.

```csharp
public class StatisticalDataCollection : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IGISGuidObject2D, DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → StatisticalDataCollection

Implements [IGISGuidObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject2D 'DiGi\.GIS\.Interfaces\.IGISGuidObject2D'), [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [IGISUniqueObject2D](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject2D 'DiGi\.GIS\.Interfaces\.IGISUniqueObject2D')
### Constructors

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(DiGi.GIS.Classes.StatisticalDataCollection)'></a>

## StatisticalDataCollection\(StatisticalDataCollection\) Constructor

Initializes a new instance of the [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection') class by copying another collection\.

```csharp
public StatisticalDataCollection(DiGi.GIS.Classes.StatisticalDataCollection? statisticalDataCollection);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(DiGi.GIS.Classes.StatisticalDataCollection).statisticalDataCollection'></a>

`statisticalDataCollection` [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')

The source collection to copy from\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode)'></a>

## StatisticalDataCollection\(Guid, UnitCode\) Constructor

Initializes a new instance of the [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection') class with a specified identifier and unit code\.

```csharp
public StatisticalDataCollection(System.Guid guid, DiGi.GIS.Classes.UnitCode? unitCode);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the collection\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode).unitCode'></a>

`unitCode` [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')

The unit code associated with this collection\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode,System.Collections.Generic.IEnumerable_DiGi.GIS.Interfaces.IStatisticalData_)'></a>

## StatisticalDataCollection\(Guid, UnitCode, IEnumerable\<IStatisticalData\>\) Constructor

Initializes a new instance of the [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection') class with a specified identifier, unit code, and initial statistical data\.

```csharp
public StatisticalDataCollection(System.Guid guid, DiGi.GIS.Classes.UnitCode? unitCode, System.Collections.Generic.IEnumerable<DiGi.GIS.Interfaces.IStatisticalData>? statisticalDatas);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode,System.Collections.Generic.IEnumerable_DiGi.GIS.Interfaces.IStatisticalData_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the collection\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode,System.Collections.Generic.IEnumerable_DiGi.GIS.Interfaces.IStatisticalData_).unitCode'></a>

`unitCode` [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')

The unit code associated with this collection\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Guid,DiGi.GIS.Classes.UnitCode,System.Collections.Generic.IEnumerable_DiGi.GIS.Interfaces.IStatisticalData_).statisticalDatas'></a>

`statisticalDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional sequence of statistical data items to populate the collection\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalDataCollection\(JsonObject\) Constructor

Initializes a new instance of the [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection') class from a JSON object\.

```csharp
public StatisticalDataCollection(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDataCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the collection data\.
### Properties

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Code'></a>

## StatisticalDataCollection\.Code Property

Gets or sets the code associated with the unit code of this collection\.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Names'></a>

## StatisticalDataCollection\.Names Property

Gets the names of all statistical data items currently stored in the collection\.

```csharp
public System.Collections.Generic.IEnumerable<string> Names { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Classes.StatisticalDataCollection.StatisticalDatas'></a>

## StatisticalDataCollection\.StatisticalDatas Property

Gets or sets the sequence of statistical data items contained in this collection\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Interfaces.IStatisticalData>? StatisticalDatas { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Classes.StatisticalDataCollection.this[string]'></a>

## StatisticalDataCollection\.this\[string\] Property

Gets the statistical data item associated with the specified name\.

```csharp
public DiGi.GIS.Interfaces.IStatisticalData? this[string name] { get; }
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.this[string].name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data item to retrieve\.

#### Property Value
[IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')

<a name='DiGi.GIS.Classes.StatisticalDataCollection.UnitCode'></a>

## StatisticalDataCollection\.UnitCode Property

Gets the unit code associated with this collection\.

```csharp
public DiGi.GIS.Classes.UnitCode? UnitCode { get; }
```

#### Property Value
[UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')
### Methods

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Add(DiGi.GIS.Interfaces.IStatisticalData)'></a>

## StatisticalDataCollection\.Add\(IStatisticalData\) Method

Adds a statistical data item to the collection\.

```csharp
public bool Add(DiGi.GIS.Interfaces.IStatisticalData? statisticalData);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Add(DiGi.GIS.Interfaces.IStatisticalData).statisticalData'></a>

`statisticalData` [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')

The statistical data item to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item was successfully added; false if the item is null or has no name\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Contains(string)'></a>

## StatisticalDataCollection\.Contains\(string\) Method

Determines whether the collection contains a statistical data item with the specified name\.

```csharp
public bool Contains(string name);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Contains(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item to locate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an item with the specified name exists; otherwise, false\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Find_TStatisticalData_(System.Func_TStatisticalData,bool_)'></a>

## StatisticalDataCollection\.Find\<TStatisticalData\>\(Func\<TStatisticalData,bool\>\) Method

Searches for a statistical data item of a specific type that satisfies the provided predicate\.

```csharp
public TStatisticalData? Find<TStatisticalData>(System.Func<TStatisticalData?,bool>? func)
    where TStatisticalData : DiGi.GIS.Interfaces.IStatisticalData;
```
#### Type parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Find_TStatisticalData_(System.Func_TStatisticalData,bool_).TStatisticalData'></a>

`TStatisticalData`

The type of statistical data to search for\.
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Find_TStatisticalData_(System.Func_TStatisticalData,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TStatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection.Find_TStatisticalData_(System.Func_TStatisticalData,bool_).TStatisticalData 'DiGi\.GIS\.Classes\.StatisticalDataCollection\.Find\<TStatisticalData\>\(System\.Func\<TStatisticalData,bool\>\)\.TStatisticalData')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function used to test each element for a match\.

#### Returns
[TStatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection.Find_TStatisticalData_(System.Func_TStatisticalData,bool_).TStatisticalData 'DiGi\.GIS\.Classes\.StatisticalDataCollection\.Find\<TStatisticalData\>\(System\.Func\<TStatisticalData,bool\>\)\.TStatisticalData')  
The first item that matches the criteria, or the default value if no match is found or the predicate is null\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.GetStatisticalData(string)'></a>

## StatisticalDataCollection\.GetStatisticalData\(string\) Method

Retrieves the statistical data item associated with the specified name\.

```csharp
public DiGi.GIS.Interfaces.IStatisticalData? GetStatisticalData(string? name);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.GetStatisticalData(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data item to retrieve\.

#### Returns
[IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')  
The matching [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData') if found; otherwise, null\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.GetStatisticalDatas_UStatisticalData_()'></a>

## StatisticalDataCollection\.GetStatisticalDatas\<UStatisticalData\>\(\) Method

Retrieves all statistical data items in the collection that are of a specific type\.

```csharp
public System.Collections.Generic.IEnumerable<UStatisticalData> GetStatisticalDatas<UStatisticalData>()
    where UStatisticalData : DiGi.GIS.Interfaces.IStatisticalData;
```
#### Type parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.GetStatisticalDatas_UStatisticalData_().UStatisticalData'></a>

`UStatisticalData`

The type of statistical data to filter by\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[UStatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection.GetStatisticalDatas_UStatisticalData_().UStatisticalData 'DiGi\.GIS\.Classes\.StatisticalDataCollection\.GetStatisticalDatas\<UStatisticalData\>\(\)\.UStatisticalData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A sequence containing all items of the specified type\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Remove(string)'></a>

## StatisticalDataCollection\.Remove\(string\) Method

Removes the statistical data item with the specified name from the collection\.

```csharp
public bool Remove(string? name);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.Remove(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item was successfully removed; false if the name is null or the item does not exist\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.TryGetStatisticalData(string,DiGi.GIS.Interfaces.IStatisticalData)'></a>

## StatisticalDataCollection\.TryGetStatisticalData\(string, IStatisticalData\) Method

Attempts to retrieve a statistical data item by its name\.

```csharp
public bool TryGetStatisticalData(string? name, out DiGi.GIS.Interfaces.IStatisticalData? statisticalData);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollection.TryGetStatisticalData(string,DiGi.GIS.Interfaces.IStatisticalData).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item to search for\.

<a name='DiGi.GIS.Classes.StatisticalDataCollection.TryGetStatisticalData(string,DiGi.GIS.Interfaces.IStatisticalData).statisticalData'></a>

`statisticalData` [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')

When this method returns, contains the found item if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item was found; otherwise, false\.

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile'></a>

## StatisticalDataCollectionFile Class

Represents a file for storing and loading statistical data collections

```csharp
public class StatisticalDataCollectionFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.GIS.Classes.StatisticalDataCollection>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → StatisticalDataCollectionFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.StatisticalDataCollectionFile(DiGi.GIS.Classes.StatisticalDataCollectionFile)'></a>

## StatisticalDataCollectionFile\(StatisticalDataCollectionFile\) Constructor

Initializes a new instance of the StatisticalDataCollectionFile class by copying another instance

```csharp
public StatisticalDataCollectionFile(DiGi.GIS.Classes.StatisticalDataCollectionFile? statisticalDataCollectionFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.StatisticalDataCollectionFile(DiGi.GIS.Classes.StatisticalDataCollectionFile).statisticalDataCollectionFile'></a>

`statisticalDataCollectionFile` [StatisticalDataCollectionFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollectionFile 'DiGi\.GIS\.Classes\.StatisticalDataCollectionFile')

The source file instance to copy from\.

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.StatisticalDataCollectionFile(string)'></a>

## StatisticalDataCollectionFile\(string\) Constructor

Initializes a new instance of the StatisticalDataCollectionFile class from the specified path

```csharp
public StatisticalDataCollectionFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.StatisticalDataCollectionFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the statistical data collection file\.

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.StatisticalDataCollectionFile(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalDataCollectionFile\(JsonObject\) Constructor

Initializes a new instance of the StatisticalDataCollectionFile class from a JSON object

```csharp
public StatisticalDataCollectionFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.StatisticalDataCollectionFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for the file\.
### Methods

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.GetUniqueReference(DiGi.GIS.Classes.StatisticalDataCollection)'></a>

## StatisticalDataCollectionFile\.GetUniqueReference\(StatisticalDataCollection\) Method

Gets the unique reference for the given statistical data collection

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.GIS.Classes.StatisticalDataCollection? statisticalDataCollection);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.GetUniqueReference(DiGi.GIS.Classes.StatisticalDataCollection).statisticalDataCollection'></a>

`statisticalDataCollection` [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')

The statistical data collection to retrieve the unique reference for\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference associated with the statistical data collection, or null if the provided collection is null\.

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.GetUniqueReference(string)'></a>

## StatisticalDataCollectionFile\.GetUniqueReference\(string\) Method

Gets the unique reference for the given reference string

```csharp
public static DiGi.Core.Classes.UniqueReference? GetUniqueReference(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalDataCollectionFile.GetUniqueReference(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string used to create the unique reference\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A new UniqueReference instance based on the provided string, or null if the reference is null\.

<a name='DiGi.GIS.Classes.StatisticalUnit'></a>

## StatisticalUnit Class

Represents a statistical unit within the GIS system, providing hierarchical organization and identification via unit codes\.

```csharp
public class StatisticalUnit : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → StatisticalUnit

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(DiGi.GIS.Classes.StatisticalUnit)'></a>

## StatisticalUnit\(StatisticalUnit\) Constructor

Initializes a new instance of the [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') class by copying another statistical unit\.

```csharp
public StatisticalUnit(DiGi.GIS.Classes.StatisticalUnit? statisticalUnit);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(DiGi.GIS.Classes.StatisticalUnit).statisticalUnit'></a>

`statisticalUnit` [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')

The source statistical unit to copy from\.

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Guid,DiGi.GIS.Classes.UnitCode,string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_)'></a>

## StatisticalUnit\(Guid, UnitCode, string, IEnumerable\<StatisticalUnit\>\) Constructor

Initializes a new instance of the [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') class\.

```csharp
public StatisticalUnit(System.Guid guid, DiGi.GIS.Classes.UnitCode? unitCode, string? name, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.StatisticalUnit>? statisticalUnits);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Guid,DiGi.GIS.Classes.UnitCode,string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the statistical unit\.

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Guid,DiGi.GIS.Classes.UnitCode,string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_).unitCode'></a>

`unitCode` [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')

The code associated with the statistical unit\.

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Guid,DiGi.GIS.Classes.UnitCode,string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the statistical unit\.

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Guid,DiGi.GIS.Classes.UnitCode,string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.StatisticalUnit_).statisticalUnits'></a>

`statisticalUnits` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of child statistical units\.

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalUnit\(JsonObject\) Constructor

Initializes a new instance of the [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') class from a JSON object\.

```csharp
public StatisticalUnit(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnit(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the statistical unit data\.
### Properties

<a name='DiGi.GIS.Classes.StatisticalUnit.Code'></a>

## StatisticalUnit\.Code Property

Gets or sets the code of the statistical unit\.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.StatisticalUnit.Name'></a>

## StatisticalUnit\.Name Property

Gets the name of the statistical unit\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.StatisticalUnit.StatisticalUnits'></a>

## StatisticalUnit\.StatisticalUnits Property

Gets the collection of child statistical units associated with this unit\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.StatisticalUnit>? StatisticalUnits { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Classes.StatisticalUnit.UnitCode'></a>

## StatisticalUnit\.UnitCode Property

Gets the unit code associated with this statistical unit\.

```csharp
public DiGi.GIS.Classes.UnitCode? UnitCode { get; }
```

#### Property Value
[UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')
### Methods

<a name='DiGi.GIS.Classes.StatisticalUnit.Find(DiGi.GIS.Classes.UnitCode,bool)'></a>

## StatisticalUnit\.Find\(UnitCode, bool\) Method

Searches for a statistical unit that matches the specified unit code\.

```csharp
public DiGi.GIS.Classes.StatisticalUnit? Find(DiGi.GIS.Classes.UnitCode? unitCode, bool includeNested);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnit.Find(DiGi.GIS.Classes.UnitCode,bool).unitCode'></a>

`unitCode` [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')

The unit code to search for\.

<a name='DiGi.GIS.Classes.StatisticalUnit.Find(DiGi.GIS.Classes.UnitCode,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, searches recursively through child units\.

#### Returns
[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')  
The matching [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') if found; otherwise, null\.

<a name='DiGi.GIS.Classes.StatisticalUnit.GetStatisticalUnits(bool,System.Func_DiGi.GIS.Classes.StatisticalUnit,bool_)'></a>

## StatisticalUnit\.GetStatisticalUnits\(bool, Func\<StatisticalUnit,bool\>\) Method

Retrieves a collection of statistical units, optionally including nested children and filtered by a predicate\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.StatisticalUnit>? GetStatisticalUnits(bool includeNested, System.Func<DiGi.GIS.Classes.StatisticalUnit?,bool>? func=null);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnit.GetStatisticalUnits(bool,System.Func_DiGi.GIS.Classes.StatisticalUnit,bool_).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, recursively includes all child statistical units\.

<a name='DiGi.GIS.Classes.StatisticalUnit.GetStatisticalUnits(bool,System.Func_DiGi.GIS.Classes.StatisticalUnit,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional filter function to determine which units should be included in the result\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of matching [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') objects, or null if no dictionary exists\.

<a name='DiGi.GIS.Classes.StatisticalUnit.GetStatisticalUnitType()'></a>

## StatisticalUnit\.GetStatisticalUnitType\(\) Method

Gets the statistical unit type based on the current unit code\.

```csharp
public System.Nullable<DiGi.GIS.Enums.StatisticalUnitType> GetStatisticalUnitType();
```

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[StatisticalUnitType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.StatisticalUnitType 'DiGi\.GIS\.Enums\.StatisticalUnitType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The [StatisticalUnitType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.StatisticalUnitType 'DiGi\.GIS\.Enums\.StatisticalUnitType') of this unit, or null if the unit code is not defined\.

<a name='DiGi.GIS.Classes.StatisticalUnit.ToString()'></a>

## StatisticalUnit\.ToString\(\) Method

Returns a string representation of the statistical unit, combining its code and name\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the unit's code and name\.

<a name='DiGi.GIS.Classes.StatisticalUnitFile'></a>

## StatisticalUnitFile Class

Represents a file containing statistical unit data\.

```csharp
public class StatisticalUnitFile : DiGi.Core.IO.File.Classes.ValueFile<DiGi.GIS.Classes.StatisticalUnit>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1')[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1') → StatisticalUnitFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.StatisticalUnitFile.StatisticalUnitFile(DiGi.GIS.Classes.StatisticalUnitFile)'></a>

## StatisticalUnitFile\(StatisticalUnitFile\) Constructor

Initializes a new instance of the [StatisticalUnitFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnitFile 'DiGi\.GIS\.Classes\.StatisticalUnitFile') class based on an existing instance\.

```csharp
public StatisticalUnitFile(DiGi.GIS.Classes.StatisticalUnitFile? statisticalUnitFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnitFile.StatisticalUnitFile(DiGi.GIS.Classes.StatisticalUnitFile).statisticalUnitFile'></a>

`statisticalUnitFile` [StatisticalUnitFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnitFile 'DiGi\.GIS\.Classes\.StatisticalUnitFile')

The source StatisticalUnitFile instance to copy from\.

<a name='DiGi.GIS.Classes.StatisticalUnitFile.StatisticalUnitFile(string)'></a>

## StatisticalUnitFile\(string\) Constructor

Initializes a new instance of the [StatisticalUnitFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnitFile 'DiGi\.GIS\.Classes\.StatisticalUnitFile') class from the specified path\.

```csharp
public StatisticalUnitFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnitFile.StatisticalUnitFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the statistical unit file\.

<a name='DiGi.GIS.Classes.StatisticalUnitFile.StatisticalUnitFile(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalUnitFile\(JsonObject\) Constructor

Initializes a new instance of the [StatisticalUnitFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnitFile 'DiGi\.GIS\.Classes\.StatisticalUnitFile') class using a JSON object\.

```csharp
public StatisticalUnitFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalUnitFile.StatisticalUnitFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the file data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_'></a>

## StatisticalYearlyData\<T\> Class

Provides a base class for statistical data organized by year

```csharp
public abstract class StatisticalYearlyData<T> : DiGi.GIS.Classes.StatisticalData, DiGi.GIS.Interfaces.IStatisticalYearlyData<T>, DiGi.GIS.Interfaces.IStatisticalYearlyData, DiGi.GIS.Interfaces.IStatisticalData, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```
#### Type parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.T'></a>

`T`

The type of the value associated with each year\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData') → StatisticalYearlyData\<T\>

Derived  
↳ [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData')

Implements [DiGi\.GIS\.Interfaces\.IStatisticalYearlyData&lt;](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_ 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>')[T](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_.T 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>\.T')[&gt;](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_ 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>'), [IStatisticalYearlyData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData'), [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(DiGi.GIS.Classes.StatisticalYearlyData_T_)'></a>

## StatisticalYearlyData\(StatisticalYearlyData\<T\>\) Constructor

Initializes a new instance of the StatisticalYearlyData class by copying another instance

```csharp
public StatisticalYearlyData(DiGi.GIS.Classes.StatisticalYearlyData<T>? statisticalYearlyData);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(DiGi.GIS.Classes.StatisticalYearlyData_T_).statisticalYearlyData'></a>

`statisticalYearlyData` [DiGi\.GIS\.Classes\.StatisticalYearlyData&lt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')[T](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_.T 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>\.T')[&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')

The source instance to copy from\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string)'></a>

## StatisticalYearlyData\(string, string\) Constructor

Initializes a new instance of the StatisticalYearlyData class with the specified name and reference

```csharp
public StatisticalYearlyData(string? name, string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,T__)'></a>

## StatisticalYearlyData\(string, string, IEnumerable\<KeyValuePair\<short,T\>\>\) Constructor

Initializes a new instance of the StatisticalYearlyData class with the specified name, reference, and values

```csharp
public StatisticalYearlyData(string? name, string? reference, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<short,T>>? values);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,T__).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,T__).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,T__).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[T](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_.T 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of key\-value pairs where the key is the year and the value is the data for that year\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalYearlyData\(JsonObject\) Constructor

Initializes a new instance of the StatisticalYearlyData class from a JSON object

```csharp
public StatisticalYearlyData(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.StatisticalYearlyData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the statistical yearly data\.
### Properties

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.this[short]'></a>

## StatisticalYearlyData\<T\>\.this\[short\] Property

Gets or sets the value for the specified year

```csharp
public T? this[short year] { get; set; }
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.this[short].year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year for which to get or set the value\.

Implements [this\[short\]](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData_T_.this[short] 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\<T\>\.this\[short\]')

#### Property Value
[T](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_.T 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>\.T')

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.Years'></a>

## StatisticalYearlyData\<T\>\.Years Property

Gets all years available in the data

```csharp
public System.Collections.Generic.IEnumerable<short> Years { get; }
```

Implements [Years](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalYearlyData.Years 'DiGi\.GIS\.Interfaces\.IStatisticalYearlyData\.Years')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.Clear()'></a>

## StatisticalYearlyData\<T\>\.Clear\(\) Method

Clears all year values

```csharp
public void Clear();
```

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.Remove(short)'></a>

## StatisticalYearlyData\<T\>\.Remove\(short\) Method

Removes the value for the specified year

```csharp
public bool Remove(short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.Remove(short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year whose value should be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value for the specified year was successfully removed; otherwise, false\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.TryGetValue(short,T)'></a>

## StatisticalYearlyData\<T\>\.TryGetValue\(short, T\) Method

Tries to get the value for the specified year

```csharp
public bool TryGetValue(short year, out T value);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.TryGetValue(short,T).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year to look for\.

<a name='DiGi.GIS.Classes.StatisticalYearlyData_T_.TryGetValue(short,T).value'></a>

`value` [T](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_.T 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>\.T')

When this method returns, contains the value associated with the specified year if found; otherwise, the default value of [T](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_.T 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>\.T')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified year was found in the data; otherwise, false\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData'></a>

## StatisticalYearlyDoubleData Class

Represents statistical yearly data with double values\.

```csharp
public class StatisticalYearlyDoubleData : DiGi.GIS.Classes.StatisticalYearlyData<double>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [StatisticalData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalData 'DiGi\.GIS\.Classes\.StatisticalData') → [DiGi\.GIS\.Classes\.StatisticalYearlyData&lt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyData_T_ 'DiGi\.GIS\.Classes\.StatisticalYearlyData\<T\>') → StatisticalYearlyDoubleData
### Constructors

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(DiGi.GIS.Classes.StatisticalYearlyDoubleData)'></a>

## StatisticalYearlyDoubleData\(StatisticalYearlyDoubleData\) Constructor

Initializes a new instance of the [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData') class by copying another instance\.

```csharp
public StatisticalYearlyDoubleData(DiGi.GIS.Classes.StatisticalYearlyDoubleData? statisticalYearlyDoubleData);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(DiGi.GIS.Classes.StatisticalYearlyDoubleData).statisticalYearlyDoubleData'></a>

`statisticalYearlyDoubleData` [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData')

The source instance to copy from\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string)'></a>

## StatisticalYearlyDoubleData\(string, string\) Constructor

Initializes a new instance of the [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData') class with the specified name and reference\.

```csharp
public StatisticalYearlyDoubleData(string? name, string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,double__)'></a>

## StatisticalYearlyDoubleData\(string, string, IEnumerable\<KeyValuePair\<short,double\>\>\) Constructor

Initializes a new instance of the [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData') class with the specified name, reference, and values\.

```csharp
public StatisticalYearlyDoubleData(string? name, string? reference, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<short,double>>? values);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,double__).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,double__).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the statistical data\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(string,string,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_short,double__).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of key\-value pairs where the key is the year and the value is the double precision data point\.

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(System.Text.Json.Nodes.JsonObject)'></a>

## StatisticalYearlyDoubleData\(JsonObject\) Constructor

Initializes a new instance of the [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData') class from a JSON object\.

```csharp
public StatisticalYearlyDoubleData(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.StatisticalYearlyDoubleData.StatisticalYearlyDoubleData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for initialization\.

<a name='DiGi.GIS.Classes.TableConversionOptions'></a>

## TableConversionOptions Class

Provides options for table conversion processes\.

```csharp
public abstract class TableConversionOptions : DiGi.Core.Classes.SerializableOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → TableConversionOptions

Derived  
↳ [ComparisonTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.ComparisonTableConversionOptions 'DiGi\.GIS\.Classes\.ComparisonTableConversionOptions')  
↳ [PredictionTableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictionTableConversionOptions 'DiGi\.GIS\.Classes\.PredictionTableConversionOptions')
### Constructors

<a name='DiGi.GIS.Classes.TableConversionOptions.TableConversionOptions()'></a>

## TableConversionOptions\(\) Constructor

Initializes a new instance of the [TableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.TableConversionOptions 'DiGi\.GIS\.Classes\.TableConversionOptions') class\.

```csharp
public TableConversionOptions();
```

<a name='DiGi.GIS.Classes.TableConversionOptions.TableConversionOptions(DiGi.GIS.Classes.TableConversionOptions)'></a>

## TableConversionOptions\(TableConversionOptions\) Constructor

Initializes a new instance of the [TableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.TableConversionOptions 'DiGi\.GIS\.Classes\.TableConversionOptions') class by copying values from an existing options object\.

```csharp
public TableConversionOptions(DiGi.GIS.Classes.TableConversionOptions? tableConversionOptions);
```
#### Parameters

<a name='DiGi.GIS.Classes.TableConversionOptions.TableConversionOptions(DiGi.GIS.Classes.TableConversionOptions).tableConversionOptions'></a>

`tableConversionOptions` [TableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.TableConversionOptions 'DiGi\.GIS\.Classes\.TableConversionOptions')

The source options object to copy from\.

<a name='DiGi.GIS.Classes.TableConversionOptions.TableConversionOptions(System.Text.Json.Nodes.JsonObject)'></a>

## TableConversionOptions\(JsonObject\) Constructor

Initializes a new instance of the [TableConversionOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.TableConversionOptions 'DiGi\.GIS\.Classes\.TableConversionOptions') class using data from a JSON object\.

```csharp
public TableConversionOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.TableConversionOptions.TableConversionOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the configuration settings\.
### Properties

<a name='DiGi.GIS.Classes.TableConversionOptions.IncludeModel'></a>

## TableConversionOptions\.IncludeModel Property

Gets or sets a value indicating whether the model should be included in the conversion\.

```csharp
public bool IncludeModel { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.TableConversionOptions.IncludeStatistical'></a>

## TableConversionOptions\.IncludeStatistical Property

Gets or sets a value indicating whether statistical data should be included in the conversion\.

```csharp
public bool IncludeStatistical { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.TableConversionOptions.IncludeYearBuilt'></a>

## TableConversionOptions\.IncludeYearBuilt Property

Gets or sets a value indicating whether year built data should be included in the conversion\.

```csharp
public bool IncludeYearBuilt { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.TableConversionOptions.StatisticalDirectory'></a>

## TableConversionOptions\.StatisticalDirectory Property

Gets or sets the directory path used for statistical data retrieval\.

```csharp
public string? StatisticalDirectory { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.TableConversionOptions.YearBuiltOnly'></a>

## TableConversionOptions\.YearBuiltOnly Property

Gets or sets a value indicating whether only year built data should be processed\.

```csharp
public bool YearBuiltOnly { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Classes.TableConversionOptions.Years'></a>

## TableConversionOptions\.Years Property

Gets or sets the range of years to be considered during the conversion process\.

```csharp
public DiGi.Core.Classes.Range<int> Years { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

<a name='DiGi.GIS.Classes.UnitCode'></a>

## UnitCode Class

Represents a statistical unit code with hierarchical location identification

```csharp
public class UnitCode : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → UnitCode

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.UnitCode.UnitCode(DiGi.GIS.Classes.UnitCode)'></a>

## UnitCode\(UnitCode\) Constructor

Initializes a new instance of the UnitCode class by copying another instance

```csharp
public UnitCode(DiGi.GIS.Classes.UnitCode? unitCode);
```
#### Parameters

<a name='DiGi.GIS.Classes.UnitCode.UnitCode(DiGi.GIS.Classes.UnitCode).unitCode'></a>

`unitCode` [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')

The source unit code instance to copy from\.

<a name='DiGi.GIS.Classes.UnitCode.UnitCode(string)'></a>

## UnitCode\(string\) Constructor

Initializes a new instance of the UnitCode class with the specified code

```csharp
public UnitCode(string? code);
```
#### Parameters

<a name='DiGi.GIS.Classes.UnitCode.UnitCode(string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unit code string to assign\.

<a name='DiGi.GIS.Classes.UnitCode.UnitCode(System.Text.Json.Nodes.JsonObject)'></a>

## UnitCode\(JsonObject\) Constructor

Initializes a new instance of the UnitCode class from a JSON object

```csharp
public UnitCode(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.UnitCode.UnitCode(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the unit code data\.
### Properties

<a name='DiGi.GIS.Classes.UnitCode.Code'></a>

## UnitCode\.Code Property

Gets the code value

```csharp
public string? Code { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.GIS.Classes.UnitCode.Clone()'></a>

## UnitCode\.Clone\(\) Method

Creates a shallow copy of this unit code

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new ISerializableObject instance that is a clone of the current object\.

<a name='DiGi.GIS.Classes.UnitCode.Equals(object)'></a>

## UnitCode\.Equals\(object\) Method

Determines whether the specified object equals this unit code

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.GIS.Classes.UnitCode.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current unit code\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified object is equal to the current unit code; otherwise, false\.

<a name='DiGi.GIS.Classes.UnitCode.GetHashCode()'></a>

## UnitCode\.GetHashCode\(\) Method

Returns the hash code for this unit code

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code for the current object\.

<a name='DiGi.GIS.Classes.UnitCode.GetParent()'></a>

## UnitCode\.GetParent\(\) Method

Gets the parent unit code based on the hierarchical structure

```csharp
public DiGi.GIS.Classes.UnitCode? GetParent();
```

#### Returns
[UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')  
The UnitCode of the parent entity if it exists; otherwise, null\.

<a name='DiGi.GIS.Classes.UnitCode.GetPrefix()'></a>

## UnitCode\.GetPrefix\(\) Method

Gets the prefix of the code by removing trailing zeros

```csharp
public string? GetPrefix();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The processed prefix string, or null if the original code is null or whitespace\.

<a name='DiGi.GIS.Classes.UnitCode.GetStatisticalUnitType()'></a>

## UnitCode\.GetStatisticalUnitType\(\) Method

Gets the statistical unit type represented by this code

```csharp
public System.Nullable<DiGi.GIS.Enums.StatisticalUnitType> GetStatisticalUnitType();
```

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[StatisticalUnitType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.StatisticalUnitType 'DiGi\.GIS\.Enums\.StatisticalUnitType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The StatisticalUnitType associated with the current code, or null if no matching type is found\.

<a name='DiGi.GIS.Classes.UnitCode.GetUnitCode(DiGi.GIS.Enums.StatisticalUnitType)'></a>

## UnitCode\.GetUnitCode\(StatisticalUnitType\) Method

Gets the unit code for the specified statistical unit type

```csharp
public DiGi.GIS.Classes.UnitCode? GetUnitCode(DiGi.GIS.Enums.StatisticalUnitType statisticalUnitType);
```
#### Parameters

<a name='DiGi.GIS.Classes.UnitCode.GetUnitCode(DiGi.GIS.Enums.StatisticalUnitType).statisticalUnitType'></a>

`statisticalUnitType` [StatisticalUnitType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.StatisticalUnitType 'DiGi\.GIS\.Enums\.StatisticalUnitType')

The target statistical unit type\.

#### Returns
[UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')  
A UnitCode instance corresponding to the requested type, or null if it cannot be determined\.

<a name='DiGi.GIS.Classes.UnitCode.IsValid()'></a>

## UnitCode\.IsValid\(\) Method

Determines whether this code is valid \(12 digits\)

```csharp
public bool IsValid();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the code consists of exactly 12 numeric digits; otherwise, false\.

<a name='DiGi.GIS.Classes.UnitCode.ToString()'></a>

## UnitCode\.ToString\(\) Method

Returns the code as a string

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string representation of the unit code\.

<a name='DiGi.GIS.Classes.UserYearBuilt'></a>

## UserYearBuilt Class

Represents a year built value that is provided by the user\.

```csharp
public sealed class UserYearBuilt : DiGi.GIS.Classes.YearBuilt
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') → UserYearBuilt
### Constructors

<a name='DiGi.GIS.Classes.UserYearBuilt.UserYearBuilt(DiGi.GIS.Classes.UserYearBuilt)'></a>

## UserYearBuilt\(UserYearBuilt\) Constructor

Initializes a new instance of the [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt') class by copying an existing [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt') instance\.

```csharp
public UserYearBuilt(DiGi.GIS.Classes.UserYearBuilt? userYearBuilt);
```
#### Parameters

<a name='DiGi.GIS.Classes.UserYearBuilt.UserYearBuilt(DiGi.GIS.Classes.UserYearBuilt).userYearBuilt'></a>

`userYearBuilt` [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt')

The source [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt') instance to copy from\.

<a name='DiGi.GIS.Classes.UserYearBuilt.UserYearBuilt(short)'></a>

## UserYearBuilt\(short\) Constructor

Initializes a new instance of the [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt') class using a specified year\.

```csharp
public UserYearBuilt(short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.UserYearBuilt.UserYearBuilt(short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year value to initialize with\.

<a name='DiGi.GIS.Classes.UserYearBuilt.UserYearBuilt(System.Text.Json.Nodes.JsonObject)'></a>

## UserYearBuilt\(JsonObject\) Constructor

Initializes a new instance of the [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt') class using data from a JSON object\.

```csharp
public UserYearBuilt(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.UserYearBuilt.UserYearBuilt(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the year built data\.
### Properties

<a name='DiGi.GIS.Classes.UserYearBuilt.Source'></a>

## UserYearBuilt\.Source Property

Gets the description of the source for this year built value\.

```csharp
public override string? Source { get; }
```

Implements [Source](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.Source 'DiGi\.GIS\.Interfaces\.IYearBuilt\.Source')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.UserYearBuilt.YearBuiltSource'></a>

## UserYearBuilt\.YearBuiltSource Property

Gets the source type for this year built value, which is always [User](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource.User 'DiGi\.GIS\.Enums\.YearBuiltSource\.User')\.

```csharp
public override DiGi.GIS.Enums.YearBuiltSource YearBuiltSource { get; }
```

Implements [YearBuiltSource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.YearBuiltSource 'DiGi\.GIS\.Interfaces\.IYearBuilt\.YearBuiltSource')

#### Property Value
[YearBuiltSource](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource 'DiGi\.GIS\.Enums\.YearBuiltSource')

<a name='DiGi.GIS.Classes.YearBuilt'></a>

## YearBuilt Class

Represents the year a structure was built\.

```csharp
public abstract class YearBuilt : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IYearBuilt, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → YearBuilt

Derived  
↳ [OtherYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OtherYearBuilt 'DiGi\.GIS\.Classes\.OtherYearBuilt')  
↳ [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt')  
↳ [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt')

Implements [IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GIS.Classes.YearBuilt.YearBuilt(DiGi.GIS.Classes.YearBuilt)'></a>

## YearBuilt\(YearBuilt\) Constructor

Initializes a new instance of the [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') class using another [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') instance\.

```csharp
public YearBuilt(DiGi.GIS.Classes.YearBuilt? yearBuilt);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuilt.YearBuilt(DiGi.GIS.Classes.YearBuilt).yearBuilt'></a>

`yearBuilt` [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt')

The existing [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') instance to copy from\.

<a name='DiGi.GIS.Classes.YearBuilt.YearBuilt(short)'></a>

## YearBuilt\(short\) Constructor

Initializes a new instance of the [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') class with the specified year\.

```csharp
public YearBuilt(short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuilt.YearBuilt(short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year the structure was built\.

<a name='DiGi.GIS.Classes.YearBuilt.YearBuilt(System.Text.Json.Nodes.JsonObject)'></a>

## YearBuilt\(JsonObject\) Constructor

Initializes a new instance of the [YearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuilt 'DiGi\.GIS\.Classes\.YearBuilt') class using a JSON object\.

```csharp
public YearBuilt(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuilt.YearBuilt(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data\.
### Properties

<a name='DiGi.GIS.Classes.YearBuilt.Source'></a>

## YearBuilt\.Source Property

Gets the source of the year built information\.

```csharp
public abstract string? Source { get; }
```

Implements [Source](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.Source 'DiGi\.GIS\.Interfaces\.IYearBuilt\.Source')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.YearBuilt.Year'></a>

## YearBuilt\.Year Property

Gets the year the structure was built\.

```csharp
public short Year { get; }
```

Implements [Year](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.Year 'DiGi\.GIS\.Interfaces\.IYearBuilt\.Year')

#### Property Value
[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

<a name='DiGi.GIS.Classes.YearBuilt.YearBuiltSource'></a>

## YearBuilt\.YearBuiltSource Property

Gets the source type for the year built value\.

```csharp
public abstract DiGi.GIS.Enums.YearBuiltSource YearBuiltSource { get; }
```

Implements [YearBuiltSource](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt.YearBuiltSource 'DiGi\.GIS\.Interfaces\.IYearBuilt\.YearBuiltSource')

#### Property Value
[YearBuiltSource](DiGi.GIS.Enums.md#DiGi.GIS.Enums.YearBuiltSource 'DiGi\.GIS\.Enums\.YearBuiltSource')

<a name='DiGi.GIS.Classes.YearBuiltData'></a>

## YearBuiltData Class

Represents data related to the year a building was constructed, supporting multiple sources of information\.

```csharp
public class YearBuiltData : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IYearBuiltData, DiGi.GIS.Interfaces.IGISGuidObject, DiGi.GIS.Interfaces.IGISUniqueObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → YearBuiltData

Implements [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData'), [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject'), [IGISUniqueObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISUniqueObject 'DiGi\.GIS\.Interfaces\.IGISUniqueObject'), [IGISSerializableObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISSerializableObject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')
### Constructors

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuiltData(DiGi.GIS.Classes.YearBuiltData)'></a>

## YearBuiltData\(YearBuiltData\) Constructor

Initializes a new instance of the [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData') class by copying values from an existing instance\.

```csharp
public YearBuiltData(DiGi.GIS.Classes.YearBuiltData? yearBuiltData);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuiltData(DiGi.GIS.Classes.YearBuiltData).yearBuiltData'></a>

`yearBuiltData` [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData')

The source [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData') object to copy data from\.

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuiltData(string)'></a>

## YearBuiltData\(string\) Constructor

Initializes a new instance of the [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData') class with a specified reference\.

```csharp
public YearBuiltData(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuiltData(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for this data object\.

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuiltData(System.Text.Json.Nodes.JsonObject)'></a>

## YearBuiltData\(JsonObject\) Constructor

Initializes a new instance of the [YearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltData') class from a JSON object\.

```csharp
public YearBuiltData(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuiltData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data\.
### Properties

<a name='DiGi.GIS.Classes.YearBuiltData.Reference'></a>

## YearBuiltData\.Reference Property

Gets the reference identifier associated with the year built data\.

```csharp
public string? Reference { get; }
```

Implements [Reference](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData.Reference 'DiGi\.GIS\.Interfaces\.IYearBuiltData\.Reference')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Classes.YearBuiltData.YearBuilts'></a>

## YearBuiltData\.YearBuilts Property

Gets or sets the collection of year built entries from various sources\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Interfaces.IYearBuilt>? YearBuilts { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.GIS.Classes.YearBuiltData.Add(DiGi.GIS.Interfaces.IYearBuilt)'></a>

## YearBuiltData\.Add\(IYearBuilt\) Method

Adds a specific year built entry to the collection\.

```csharp
public bool Add(DiGi.GIS.Interfaces.IYearBuilt yearBuilt);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.Add(DiGi.GIS.Interfaces.IYearBuilt).yearBuilt'></a>

`yearBuilt` [IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt')

The [IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt') entry to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the entry was successfully added; otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltData.GetLatestPredictedYearBuilt()'></a>

## YearBuiltData\.GetLatestPredictedYearBuilt\(\) Method

Retrieves the most recent predicted year built entry based on its date\.

```csharp
public DiGi.GIS.Classes.PredictedYearBuilt? GetLatestPredictedYearBuilt();
```

#### Returns
[PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt')  
The latest [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt') instance, or null if no predictions exist\.

<a name='DiGi.GIS.Classes.YearBuiltData.GetPredictedYearBuilt(System.DateTime)'></a>

## YearBuiltData\.GetPredictedYearBuilt\(DateTime\) Method

Retrieves a predicted year built entry that matches the specified date\.

```csharp
public DiGi.GIS.Classes.PredictedYearBuilt? GetPredictedYearBuilt(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.GetPredictedYearBuilt(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date to search for\.

#### Returns
[PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt')  
The matching [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt') instance, or null if not found\.

<a name='DiGi.GIS.Classes.YearBuiltData.GetPredictedYearBuilts()'></a>

## YearBuiltData\.GetPredictedYearBuilts\(\) Method

Retrieves all predicted year built entries available in the collection\.

```csharp
public System.Collections.Generic.List<DiGi.GIS.Classes.PredictedYearBuilt>? GetPredictedYearBuilts();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [PredictedYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.PredictedYearBuilt 'DiGi\.GIS\.Classes\.PredictedYearBuilt') objects, or null if the collection is uninitialized\.

<a name='DiGi.GIS.Classes.YearBuiltData.GetUserYearBuilt()'></a>

## YearBuiltData\.GetUserYearBuilt\(\) Method

Retrieves the year built entry provided by the user\.

```csharp
public DiGi.GIS.Classes.UserYearBuilt? GetUserYearBuilt();
```

#### Returns
[UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt')  
The [UserYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UserYearBuilt 'DiGi\.GIS\.Classes\.UserYearBuilt') instance, or null if no user\-provided data exists\.

<a name='DiGi.GIS.Classes.YearBuiltData.GetYearBuilts_TYearBuilt_()'></a>

## YearBuiltData\.GetYearBuilts\<TYearBuilt\>\(\) Method

Retrieves all year built entries of a specific type\.

```csharp
public System.Collections.Generic.List<TYearBuilt>? GetYearBuilts<TYearBuilt>()
    where TYearBuilt : DiGi.GIS.Interfaces.IYearBuilt;
```
#### Type parameters

<a name='DiGi.GIS.Classes.YearBuiltData.GetYearBuilts_TYearBuilt_().TYearBuilt'></a>

`TYearBuilt`

The type of [IYearBuilt](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuilt 'DiGi\.GIS\.Interfaces\.IYearBuilt') to filter for\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData.GetYearBuilts_TYearBuilt_().TYearBuilt 'DiGi\.GIS\.Classes\.YearBuiltData\.GetYearBuilts\<TYearBuilt\>\(\)\.TYearBuilt')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of entries of type [TYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData.GetYearBuilts_TYearBuilt_().TYearBuilt 'DiGi\.GIS\.Classes\.YearBuiltData\.GetYearBuilts\<TYearBuilt\>\(\)\.TYearBuilt'), or null if the collection is uninitialized\.

<a name='DiGi.GIS.Classes.YearBuiltData.Remove(string)'></a>

## YearBuiltData\.Remove\(string\) Method

Removes a year built entry from the collection based on its source identifier\.

```csharp
public bool Remove(string? source);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.Remove(string).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the source to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the entry was successfully removed; otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltData.RemovePredictedYearBuilts()'></a>

## YearBuiltData\.RemovePredictedYearBuilts\(\) Method

Removes all predicted year built entries from the collection\.

```csharp
public bool RemovePredictedYearBuilts();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more predicted entries were removed; otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltData.RemoveUserYearBuilt()'></a>

## YearBuiltData\.RemoveUserYearBuilt\(\) Method

Removes the year built entry provided by the user\.

```csharp
public bool RemoveUserYearBuilt();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the user entry was successfully removed; otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltData.SetPredictedYearBuilt(System.DateTime,short)'></a>

## YearBuiltData\.SetPredictedYearBuilt\(DateTime, short\) Method

Sets a new predicted year built entry in the collection\.

```csharp
public bool SetPredictedYearBuilt(System.DateTime dateTime, short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.SetPredictedYearBuilt(System.DateTime,short).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date of the prediction\.

<a name='DiGi.GIS.Classes.YearBuiltData.SetPredictedYearBuilt(System.DateTime,short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The predicted construction year\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the prediction was successfully added; otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltData.SetUserYearBuilt(short)'></a>

## YearBuiltData\.SetUserYearBuilt\(short\) Method

Sets a new user\-provided year built entry in the collection\.

```csharp
public bool SetUserYearBuilt(short year);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.SetUserYearBuilt(short).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The construction year provided by the user\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the user entry was successfully added; otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltData.TryGetYearBuilt_TYearBuilt_(string,TYearBuilt)'></a>

## YearBuiltData\.TryGetYearBuilt\<TYearBuilt\>\(string, TYearBuilt\) Method

Attempts to retrieve a year built entry of a specific type from a given source\.

```csharp
public bool TryGetYearBuilt<TYearBuilt>(string? source, out TYearBuilt? yearBuilt)
    where TYearBuilt : DiGi.GIS.Interfaces.IYearBuilt;
```
#### Type parameters

<a name='DiGi.GIS.Classes.YearBuiltData.TryGetYearBuilt_TYearBuilt_(string,TYearBuilt).TYearBuilt'></a>

`TYearBuilt`

The expected type of the year built entry\.
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltData.TryGetYearBuilt_TYearBuilt_(string,TYearBuilt).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the source\.

<a name='DiGi.GIS.Classes.YearBuiltData.TryGetYearBuilt_TYearBuilt_(string,TYearBuilt).yearBuilt'></a>

`yearBuilt` [TYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData.TryGetYearBuilt_TYearBuilt_(string,TYearBuilt).TYearBuilt 'DiGi\.GIS\.Classes\.YearBuiltData\.TryGetYearBuilt\<TYearBuilt\>\(string, TYearBuilt\)\.TYearBuilt')

When this method returns, contains the retrieved entry if successful; otherwise, default\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the entry was found and is of type [TYearBuilt](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltData.TryGetYearBuilt_TYearBuilt_(string,TYearBuilt).TYearBuilt 'DiGi\.GIS\.Classes\.YearBuiltData\.TryGetYearBuilt\<TYearBuilt\>\(string, TYearBuilt\)\.TYearBuilt'); otherwise, false\.

<a name='DiGi.GIS.Classes.YearBuiltDataFile'></a>

## YearBuiltDataFile Class

Represents a storage file for year built data\.

```csharp
public class YearBuiltDataFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.GIS.Interfaces.IYearBuiltData>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → YearBuiltDataFile

Implements [IGISObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISObject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Classes.YearBuiltDataFile.YearBuiltDataFile(DiGi.GIS.Classes.YearBuiltDataFile)'></a>

## YearBuiltDataFile\(YearBuiltDataFile\) Constructor

Initializes a new instance of the [YearBuiltDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile 'DiGi\.GIS\.Classes\.YearBuiltDataFile') class using another instance\.

```csharp
public YearBuiltDataFile(DiGi.GIS.Classes.YearBuiltDataFile? yearBuiltDataFile);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.YearBuiltDataFile(DiGi.GIS.Classes.YearBuiltDataFile).yearBuiltDataFile'></a>

`yearBuiltDataFile` [YearBuiltDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile 'DiGi\.GIS\.Classes\.YearBuiltDataFile')

The source instance to copy from\.

<a name='DiGi.GIS.Classes.YearBuiltDataFile.YearBuiltDataFile(string)'></a>

## YearBuiltDataFile\(string\) Constructor

Initializes a new instance of the [YearBuiltDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile 'DiGi\.GIS\.Classes\.YearBuiltDataFile') class using a path\.

```csharp
public YearBuiltDataFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.YearBuiltDataFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the storage file\.

<a name='DiGi.GIS.Classes.YearBuiltDataFile.YearBuiltDataFile(System.Text.Json.Nodes.JsonObject)'></a>

## YearBuiltDataFile\(JsonObject\) Constructor

Initializes a new instance of the [YearBuiltDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile 'DiGi\.GIS\.Classes\.YearBuiltDataFile') class using a JSON object\.

```csharp
public YearBuiltDataFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.YearBuiltDataFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing file data\.
### Methods

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetUniqueReference(DiGi.GIS.Interfaces.IYearBuiltData)'></a>

## YearBuiltDataFile\.GetUniqueReference\(IYearBuiltData\) Method

Gets the unique reference for a specific year built data instance\.

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.GIS.Interfaces.IYearBuiltData? yearBuiltData);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetUniqueReference(DiGi.GIS.Interfaces.IYearBuiltData).yearBuiltData'></a>

`yearBuiltData` [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')

The year built data object\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') if successful; otherwise, null\.

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetUniqueReference_UYearBuiltData_(string)'></a>

## YearBuiltDataFile\.GetUniqueReference\<UYearBuiltData\>\(string\) Method

Gets the unique reference for a specific type and reference string\.

```csharp
public static DiGi.Core.Classes.UniqueReference? GetUniqueReference<UYearBuiltData>(string? reference)
    where UYearBuiltData : DiGi.GIS.Interfaces.IYearBuiltData;
```
#### Type parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetUniqueReference_UYearBuiltData_(string).UYearBuiltData'></a>

`UYearBuiltData`

The type of year built data\.
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetUniqueReference_UYearBuiltData_(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier string\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') if successful; otherwise, null\.

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetValue_UYearBuiltData_(string)'></a>

## YearBuiltDataFile\.GetValue\<UYearBuiltData\>\(string\) Method

Gets the value associated with the specified reference\.

```csharp
public UYearBuiltData? GetValue<UYearBuiltData>(string? reference)
    where UYearBuiltData : DiGi.GIS.Interfaces.IYearBuiltData;
```
#### Type parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetValue_UYearBuiltData_(string).UYearBuiltData'></a>

`UYearBuiltData`

The type of year built data to retrieve\.
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltDataFile.GetValue_UYearBuiltData_(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier string\.

#### Returns
[UYearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile.GetValue_UYearBuiltData_(string).UYearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltDataFile\.GetValue\<UYearBuiltData\>\(string\)\.UYearBuiltData')  
The retrieved value of type [UYearBuiltData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile.GetValue_UYearBuiltData_(string).UYearBuiltData 'DiGi\.GIS\.Classes\.YearBuiltDataFile\.GetValue\<UYearBuiltData\>\(string\)\.UYearBuiltData'), or the default value if not found\.

<a name='DiGi.GIS.Classes.YearBuiltPrediction'></a>

## YearBuiltPrediction Class

Represents a prediction for the year a building was constructed, including spatial boundaries and confidence metrics\.

```csharp
public class YearBuiltPrediction : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → YearBuiltPrediction
### Constructors

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(DiGi.GIS.Classes.YearBuiltPrediction)'></a>

## YearBuiltPrediction\(YearBuiltPrediction\) Constructor

Initializes a new instance of the [YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction') class by copying values from an existing prediction\.

```csharp
public YearBuiltPrediction(DiGi.GIS.Classes.YearBuiltPrediction? yearBuiltPrediction);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(DiGi.GIS.Classes.YearBuiltPrediction).yearBuiltPrediction'></a>

`yearBuiltPrediction` [YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction')

The source prediction object to copy data from\.

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(System.Text.Json.Nodes.JsonObject)'></a>

## YearBuiltPrediction\(JsonObject\) Constructor

Initializes a new instance of the [YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction') class from a JSON object\.

```csharp
public YearBuiltPrediction(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing prediction data\.

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(ushort,DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## YearBuiltPrediction\(ushort, BoundingBox2D, double\) Constructor

Initializes a new instance of the [YearBuiltPrediction](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltPrediction 'DiGi\.GIS\.Classes\.YearBuiltPrediction') class with specified construction year, bounding box, and confidence\.

```csharp
public YearBuiltPrediction(ushort year, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox, double confidence);
```
#### Parameters

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(ushort,DiGi.Geometry.Planar.Classes.BoundingBox2D,double).year'></a>

`year` [System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')

The predicted year the building was built\.

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(ushort,DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox'></a>

`boundingBox` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The spatial bounding box associated with this prediction\.

<a name='DiGi.GIS.Classes.YearBuiltPrediction.YearBuiltPrediction(ushort,DiGi.Geometry.Planar.Classes.BoundingBox2D,double).confidence'></a>

`confidence` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The confidence level of the prediction\.
### Properties

<a name='DiGi.GIS.Classes.YearBuiltPrediction.BoundingBox'></a>

## YearBuiltPrediction\.BoundingBox Property

Gets the spatial bounding box associated with the year built prediction\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

<a name='DiGi.GIS.Classes.YearBuiltPrediction.Confidence'></a>

## YearBuiltPrediction\.Confidence Property

Gets the confidence score of the prediction\.

```csharp
public double Confidence { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Classes.YearBuiltPrediction.Year'></a>

## YearBuiltPrediction\.Year Property

Gets the predicted year the building was constructed\.

```csharp
public ushort Year { get; }
```

#### Property Value
[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')