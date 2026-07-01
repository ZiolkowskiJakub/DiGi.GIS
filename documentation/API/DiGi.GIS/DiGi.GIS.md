#### [DiGi\.GIS](index.md 'index')

## DiGi\.GIS Namespace
### Classes

<a name='DiGi.GIS.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDL.Classes.UnitYearlyValues)'></a>

## Convert\.ToDiGi\(this UnitYearlyValues\) Method

Converts a [DiGi\.BDL\.Classes\.UnitYearlyValues](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.classes.unityearlyvalues 'DiGi\.BDL\.Classes\.UnitYearlyValues') instance to a [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')\.

```csharp
public static DiGi.GIS.Classes.StatisticalDataCollection? ToDiGi(this DiGi.BDL.Classes.UnitYearlyValues? unitYearlyValues);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDL.Classes.UnitYearlyValues).unitYearlyValues'></a>

`unitYearlyValues` [DiGi\.BDL\.Classes\.UnitYearlyValues](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.classes.unityearlyvalues 'DiGi\.BDL\.Classes\.UnitYearlyValues')

The yearly values for the unit to be converted\.

#### Returns
[StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')  
A [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection') containing the data, or `null` if the input is null or a valid unit code cannot be created\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_ADJA_A,System.Nullable_System.Guid_)'></a>

## Convert\.ToDiGi\(this OT\_ADJA\_A, Nullable\<Guid\>\) Method

Converts an [DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adja_a 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A') object to a [AdministrativeDivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeDivision 'DiGi\.GIS\.Classes\.AdministrativeDivision') instance\.

```csharp
public static DiGi.GIS.Classes.AdministrativeDivision? ToDiGi(this DiGi.BDOT10k.Classes.OT_ADJA_A? oT_ADJA_A, System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_ADJA_A,System.Nullable_System.Guid_).oT_ADJA_A'></a>

`oT_ADJA_A` [DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adja_a 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')

The source [DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adja_a 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A') object to convert\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_ADJA_A,System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') to assign as the identifier for the resulting administrative division\. If null, a new GUID will be generated\.

#### Returns
[AdministrativeDivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeDivision 'DiGi\.GIS\.Classes\.AdministrativeDivision')  
The converted [AdministrativeDivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeDivision 'DiGi\.GIS\.Classes\.AdministrativeDivision') instance, or null if the source object is null\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_ADMS_A,System.Nullable_System.Guid_)'></a>

## Convert\.ToDiGi\(this OT\_ADMS\_A, Nullable\<Guid\>\) Method

Converts an [DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adms_a 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A') instance to a [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision') instance\.

```csharp
public static DiGi.GIS.Classes.AdministrativeSubdivision? ToDiGi(this DiGi.BDOT10k.Classes.OT_ADMS_A? oT_ADMS_A, System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_ADMS_A,System.Nullable_System.Guid_).oT_ADMS_A'></a>

`oT_ADMS_A` [DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adms_a 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')

The source [DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adms_a 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A') object to convert\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_ADMS_A,System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional unique identifier for the resulting [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')\. If not provided, a new [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') will be generated\.

#### Returns
[AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')  
A [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision') instance if the source object is not null; otherwise, null\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_BUBD_A)'></a>

## Convert\.ToDiGi\(this OT\_BUBD\_A\) Method

Converts an [DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_bubd_a 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A') object to a [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') object\.

```csharp
public static DiGi.GIS.Classes.Building2D? ToDiGi(this DiGi.BDOT10k.Classes.OT_BUBD_A? oT_BUBD_A);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Classes.OT_BUBD_A).oT_BUBD_A'></a>

`oT_BUBD_A` [DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_bubd_a 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')

The source [DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_bubd_a 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A') object to convert\.

#### Returns
[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')  
A [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') instance if the input is not null; otherwise, null\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_FunOgolnaBudynku)'></a>

## Convert\.ToDiGi\(this OT\_FunOgolnaBudynku\) Method

Converts an [DiGi\.BDOT10k\.Enums\.OT\_FunOgolnaBudynku](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_funogolnabudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunOgolnaBudynku') enumeration value to its corresponding [BuildingGeneralFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingGeneralFunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction') equivalent\.

```csharp
public static DiGi.GIS.Enums.BuildingGeneralFunction ToDiGi(this DiGi.BDOT10k.Enums.OT_FunOgolnaBudynku oT_FunOgolnaBudynku);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_FunOgolnaBudynku).oT_FunOgolnaBudynku'></a>

`oT_FunOgolnaBudynku` [DiGi\.BDOT10k\.Enums\.OT\_FunOgolnaBudynku](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_funogolnabudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunOgolnaBudynku')

The source building general function value from the OT domain\.

#### Returns
[BuildingGeneralFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingGeneralFunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction')  
The mapped [BuildingGeneralFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingGeneralFunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction') value\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku)'></a>

## Convert\.ToDiGi\(this OT\_FunSzczegolowaBudynku\) Method

Converts an [DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_funszczegolowabudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku') instance to a [BuildingSpecificFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingSpecificFunction 'DiGi\.GIS\.Enums\.BuildingSpecificFunction')\.

```csharp
public static DiGi.GIS.Enums.BuildingSpecificFunction ToDiGi(this DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku oT_FunSzczegolowaBudynku);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku).oT_FunSzczegolowaBudynku'></a>

`oT_FunSzczegolowaBudynku` [DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_funszczegolowabudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku')

The [DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_funszczegolowabudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku') instance to convert\.

#### Returns
[BuildingSpecificFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingSpecificFunction 'DiGi\.GIS\.Enums\.BuildingSpecificFunction')  
A [BuildingSpecificFunction](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingSpecificFunction 'DiGi\.GIS\.Enums\.BuildingSpecificFunction') object converted from the source [DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_funszczegolowabudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku')\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_KatIstnienia)'></a>

## Convert\.ToDiGi\(this OT\_KatIstnienia\) Method

Converts an [DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_katistnienia 'DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia') enumeration value to its corresponding [BuildingPhase](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingPhase 'DiGi\.GIS\.Enums\.BuildingPhase') value\.

```csharp
public static DiGi.GIS.Enums.BuildingPhase ToDiGi(this DiGi.BDOT10k.Enums.OT_KatIstnienia oT_KatIstnienia);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_KatIstnienia).oT_KatIstnienia'></a>

`oT_KatIstnienia` [DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_katistnienia 'DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia')

The source [DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_katistnienia 'DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia') value to convert\.

#### Returns
[BuildingPhase](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingPhase 'DiGi\.GIS\.Enums\.BuildingPhase')  
The equivalent [BuildingPhase](DiGi.GIS.Enums.md#DiGi.GIS.Enums.BuildingPhase 'DiGi\.GIS\.Enums\.BuildingPhase') value\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej)'></a>

## Convert\.ToDiGi\(this OT\_RodzajJednostkiAdministracyjnej\) Method

Converts an [DiGi\.BDOT10k\.Enums\.OT\_RodzajJednostkiAdministracyjnej](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_rodzajjednostkiadministracyjnej 'DiGi\.BDOT10k\.Enums\.OT\_RodzajJednostkiAdministracyjnej') value to its corresponding [AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType')\.

```csharp
public static DiGi.GIS.Enums.AdministrativeDivisionType ToDiGi(this DiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej oT_RodzajJednostkiAdministracyjnej);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej).oT_RodzajJednostkiAdministracyjnej'></a>

`oT_RodzajJednostkiAdministracyjnej` [DiGi\.BDOT10k\.Enums\.OT\_RodzajJednostkiAdministracyjnej](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_rodzajjednostkiadministracyjnej 'DiGi\.BDOT10k\.Enums\.OT\_RodzajJednostkiAdministracyjnej')

The administrative unit type from the OT source\.

#### Returns
[AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType')  
The equivalent [AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType')\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_RodzajMiejscowosci)'></a>

## Convert\.ToDiGi\(this OT\_RodzajMiejscowosci\) Method

Converts an [DiGi\.BDOT10k\.Enums\.OT\_RodzajMiejscowosci](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_rodzajmiejscowosci 'DiGi\.BDOT10k\.Enums\.OT\_RodzajMiejscowosci') enumeration value to its corresponding [AdministrativeSubdivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeSubdivisionType 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')\.

```csharp
public static DiGi.GIS.Enums.AdministrativeSubdivisionType ToDiGi(this DiGi.BDOT10k.Enums.OT_RodzajMiejscowosci oT_RodzajMiejscowosci);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.BDOT10k.Enums.OT_RodzajMiejscowosci).oT_RodzajMiejscowosci'></a>

`oT_RodzajMiejscowosci` [DiGi\.BDOT10k\.Enums\.OT\_RodzajMiejscowosci](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.enums.ot_rodzajmiejscowosci 'DiGi\.BDOT10k\.Enums\.OT\_RodzajMiejscowosci')

The source locality type from the BDOT10k system\.

#### Returns
[AdministrativeSubdivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeSubdivisionType 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')  
The equivalent administrative subdivision type in the DiGi GIS system\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.GIS.Enums.StatisticalUnitType)'></a>

## Convert\.ToDiGi\(this StatisticalUnitType\) Method

Converts a [StatisticalUnitType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.StatisticalUnitType 'DiGi\.GIS\.Enums\.StatisticalUnitType') value to its corresponding [AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType'), or null if no mapping exists\.

```csharp
public static System.Nullable<DiGi.GIS.Enums.AdministrativeDivisionType> ToDiGi(this DiGi.GIS.Enums.StatisticalUnitType statisticalUnitType);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.GIS.Enums.StatisticalUnitType).statisticalUnitType'></a>

`statisticalUnitType` [StatisticalUnitType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.StatisticalUnitType 'DiGi\.GIS\.Enums\.StatisticalUnitType')

The statistical unit type to convert\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The equivalent [AdministrativeDivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeDivisionType 'DiGi\.GIS\.Enums\.AdministrativeDivisionType') if found; otherwise, null\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.GML.Classes.LinearRing)'></a>

## Convert\.ToDiGi\(this LinearRing\) Method

Converts a GML LinearRing to a DiGi Polygon2D object\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? ToDiGi(this DiGi.GML.Classes.LinearRing? linearRing);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.GML.Classes.LinearRing).linearRing'></a>

`linearRing` [DiGi\.GML\.Classes\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.linearring 'DiGi\.GML\.Classes\.LinearRing')

The linear ring instance to convert\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') object if the conversion is successful; otherwise, null\.

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.GML.Classes.Surface)'></a>

## Convert\.ToDiGi\(this Surface\) Method

Converts a GML Surface to a DiGi PolygonalFace2D representation\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? ToDiGi(this DiGi.GML.Classes.Surface? surface);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisDiGi.GML.Classes.Surface).surface'></a>

`surface` [DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

The surface instance to be converted\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') object if the conversion is successful; otherwise, null\.

<a name='DiGi.GIS.Convert.ToDiGi(thisstring,string,bool,bool,bool)'></a>

## Convert\.ToDiGi\(this string, string, bool, bool, bool\) Method

Converts from geoportal zip GML file to DiGi\.GIS objects\.

```csharp
public static System.Collections.Generic.List<string>? ToDiGi(this string? path_Input, string? directory_Output, bool oT_ADJA_A=true, bool oT_ADMS_A=true, bool oT_BUBD_A=true);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToDiGi(thisstring,string,bool,bool,bool).path_Input'></a>

`path_Input` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the source zip GML file\.

<a name='DiGi.GIS.Convert.ToDiGi(thisstring,string,bool,bool,bool).directory_Output'></a>

`directory_Output` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory where the converted files will be saved\.

<a name='DiGi.GIS.Convert.ToDiGi(thisstring,string,bool,bool,bool).oT_ADJA_A'></a>

`oT_ADJA_A` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether to convert OT\_ADJA\_A\.xml files \(AdministrativeSubdivision\)\.

<a name='DiGi.GIS.Convert.ToDiGi(thisstring,string,bool,bool,bool).oT_ADMS_A'></a>

`oT_ADMS_A` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether to convert OT\_ADMS\_A\.xml files \(AdministrativeDivision\)\.

<a name='DiGi.GIS.Convert.ToDiGi(thisstring,string,bool,bool,bool).oT_BUBD_A'></a>

`oT_BUBD_A` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether to convert OT\_BUBD\_A\.xml files \(Building2D\)\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of paths to the created output files, or null if the input is invalid or no files were processed\.

<a name='DiGi.GIS.Convert.ToEPSG2180(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Convert\.ToEPSG2180\(this Point3D\) Method

Converts a 3D point from geographic coordinates \(WGS 84\) to the Polish coordinate system EPSG:2180\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ToEPSG2180(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToEPSG2180(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source 3D point to be converted\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A 2D point in the EPSG:2180 coordinate system, or null if the input point is null or conversion fails\.

<a name='DiGi.GIS.Convert.ToEPSG4326(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Convert\.ToEPSG4326\(this BoundingBox2D\) Method

Converts a 2D bounding box to a 3D bounding box in the EPSG:4326 coordinate system\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? ToEPSG4326(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToEPSG4326(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the converted coordinates, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input bounding box is null\.

<a name='DiGi.GIS.Convert.ToEPSG4326(thisDiGi.Geometry.Planar.Classes.Point2D)'></a>

## Convert\.ToEPSG4326\(this Point2D\) Method

Converts from EPSG:2180 to EPSG:4326 Coordinate System

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ToEPSG4326(this DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToEPSG4326(thisDiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Point2D in EPSG:2180 Coordinate System

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
Point3D in EPSG:4326 Coordinate System

<a name='DiGi.GIS.Convert.ToSystem_String(string,string)'></a>

## Convert\.ToSystem\_String\(string, string\) Method

Converts the GIS model reference and areal 2D reference into a formatted system string\.

```csharp
public static string? ToSystem_String(string? gISModelReference, string? areal2DReference);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToSystem_String(string,string).gISModelReference'></a>

`gISModelReference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The GIS model reference identifier\.

<a name='DiGi.GIS.Convert.ToSystem_String(string,string).areal2DReference'></a>

`areal2DReference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The areal 2D reference identifier\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string combining the references, or null if the areal 2D reference is null or whitespace\.

<a name='DiGi.GIS.Convert.ToSystem_Strings(thisDiGi.Typology.Classes.Typology)'></a>

## Convert\.ToSystem\_Strings\(this Typology\) Method

Converts the specified typology into an array of strings, where each string represents a row
in a tab\-separated format containing the hierarchy path and associated metadata\.

```csharp
public static string[]? ToSystem_Strings(this DiGi.Typology.Classes.Typology? typology);
```
#### Parameters

<a name='DiGi.GIS.Convert.ToSystem_Strings(thisDiGi.Typology.Classes.Typology).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typology 'DiGi\.Typology\.Classes\.Typology')

The typology instance to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of tab\-separated strings representing the typology structure, or an empty array if no data is found\.

<a name='DiGi.GIS.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GIS.Create.AdministrativeAreal2DGeometryCalculationResult(thisDiGi.GIS.Classes.AdministrativeAreal2D,double)'></a>

## Create\.AdministrativeAreal2DGeometryCalculationResult\(this AdministrativeAreal2D, double\) Method

Calculates the geometry calculation results for the specified administrative areal 2D object\.

```csharp
public static DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult? AdministrativeAreal2DGeometryCalculationResult(this DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Create.AdministrativeAreal2DGeometryCalculationResult(thisDiGi.GIS.Classes.AdministrativeAreal2D,double).administrativeAreal2D'></a>

`administrativeAreal2D` [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative areal 2D object to calculate results for\.

<a name='DiGi.GIS.Create.AdministrativeAreal2DGeometryCalculationResult(thisDiGi.GIS.Classes.AdministrativeAreal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used in the geometric calculations\.

#### Returns
[AdministrativeAreal2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.AdministrativeAreal2DGeometryCalculationResult')  
An [AdministrativeAreal2DGeometryCalculationResult\(this AdministrativeAreal2D, double\)](DiGi.GIS.md#DiGi.GIS.Create.AdministrativeAreal2DGeometryCalculationResult(thisDiGi.GIS.Classes.AdministrativeAreal2D,double) 'DiGi\.GIS\.Create\.AdministrativeAreal2DGeometryCalculationResult\(this DiGi\.GIS\.Classes\.AdministrativeAreal2D, double\)') containing the calculated geometry data, or null if the input is null or does not have a valid polygonal face\.

<a name='DiGi.GIS.Create.Building2DGeometryCalculationResult(thisDiGi.GIS.Classes.Building2D,double)'></a>

## Create\.Building2DGeometryCalculationResult\(this Building2D, double\) Method

Calculates the 2D geometry results for a given building\.

```csharp
public static DiGi.GIS.Classes.Building2DGeometryCalculationResult? Building2DGeometryCalculationResult(this DiGi.GIS.Classes.Building2D? building2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Create.Building2DGeometryCalculationResult(thisDiGi.GIS.Classes.Building2D,double).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object to calculate geometry for\.

<a name='DiGi.GIS.Create.Building2DGeometryCalculationResult(thisDiGi.GIS.Classes.Building2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used in geometric calculations\.

#### Returns
[Building2DGeometryCalculationResult](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')  
A [Building2DGeometryCalculationResult\(this Building2D, double\)](DiGi.GIS.md#DiGi.GIS.Create.Building2DGeometryCalculationResult(thisDiGi.GIS.Classes.Building2D,double) 'DiGi\.GIS\.Create\.Building2DGeometryCalculationResult\(this DiGi\.GIS\.Classes\.Building2D, double\)') containing the calculated values, or null if calculation is not possible\.

<a name='DiGi.GIS.Create.GISModelAreal2DReference(thisstring)'></a>

## Create\.GISModelAreal2DReference\(this string\) Method

Parses a string reference to create a [GISModelAreal2DReference\(this string\)](DiGi.GIS.md#DiGi.GIS.Create.GISModelAreal2DReference(thisstring) 'DiGi\.GIS\.Create\.GISModelAreal2DReference\(this string\)') instance\.

```csharp
public static DiGi.GIS.Classes.GISModelAreal2DReference? GISModelAreal2DReference(this string reference);
```
#### Parameters

<a name='DiGi.GIS.Create.GISModelAreal2DReference(thisstring).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string representation of the reference to be parsed\.

#### Returns
[GISModelAreal2DReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelAreal2DReference 'DiGi\.GIS\.Classes\.GISModelAreal2DReference')  
A [GISModelAreal2DReference\(this string\)](DiGi.GIS.md#DiGi.GIS.Create.GISModelAreal2DReference(thisstring) 'DiGi\.GIS\.Create\.GISModelAreal2DReference\(this string\)') object if the input is valid; otherwise, null\.

<a name='DiGi.GIS.Create.GISModelFileUniqueObjectReference(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Interfaces.IGISGuidObject)'></a>

## Create\.GISModelFileUniqueObjectReference\(this GISModelFile, IGISGuidObject\) Method

Creates a unique object reference for a GIS model file using the provided GUID object\.

```csharp
public static DiGi.GIS.Classes.GISModelFileGuidObjectReference? GISModelFileUniqueObjectReference(this DiGi.GIS.Classes.GISModelFile? gISModelFile, DiGi.GIS.Interfaces.IGISGuidObject? gISGuidObject);
```
#### Parameters

<a name='DiGi.GIS.Create.GISModelFileUniqueObjectReference(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Interfaces.IGISGuidObject).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file instance\.

<a name='DiGi.GIS.Create.GISModelFileUniqueObjectReference(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Interfaces.IGISGuidObject).gISGuidObject'></a>

`gISGuidObject` [IGISGuidObject](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IGISGuidObject 'DiGi\.GIS\.Interfaces\.IGISGuidObject')

The GUID object to be used as a reference\.

#### Returns
[GISModelFileGuidObjectReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileGuidObjectReference 'DiGi\.GIS\.Classes\.GISModelFileGuidObjectReference')  
A [GISModelFileGuidObjectReference](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFileGuidObjectReference 'DiGi\.GIS\.Classes\.GISModelFileGuidObjectReference') if both inputs and the external reference are valid; otherwise, null\.

<a name='DiGi.GIS.Create.Hash(DiGi.GML.Classes.LinearRing)'></a>

## Create\.Hash\(LinearRing\) Method

Computes a hash value for the specified linear ring\.

```csharp
public static long Hash(DiGi.GML.Classes.LinearRing? linearRing);
```
#### Parameters

<a name='DiGi.GIS.Create.Hash(DiGi.GML.Classes.LinearRing).linearRing'></a>

`linearRing` [DiGi\.GML\.Classes\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.linearring 'DiGi\.GML\.Classes\.LinearRing')

The linear ring to be hashed\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
A long integer representing the computed hash of the linear ring; returns 0 if the object is null\.

<a name='DiGi.GIS.Create.Hash(DiGi.GML.Classes.Polygon)'></a>

## Create\.Hash\(Polygon\) Method

Computes a hash value for the specified polygon\.

```csharp
public static long Hash(DiGi.GML.Classes.Polygon? polygon);
```
#### Parameters

<a name='DiGi.GIS.Create.Hash(DiGi.GML.Classes.Polygon).polygon'></a>

`polygon` [DiGi\.GML\.Classes\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.polygon 'DiGi\.GML\.Classes\.Polygon')

The polygon to be hashed\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
A long integer representing the computed hash of the polygon; returns 0 if the object is null\.

<a name='DiGi.GIS.Create.Hash(string)'></a>

## Create\.Hash\(string\) Method

Computes a hash value for the specified string\.

```csharp
public static long Hash(string? @string);
```
#### Parameters

<a name='DiGi.GIS.Create.Hash(string).string'></a>

`string` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to be hashed\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
A long integer representing the computed hash of the string; returns 0 if the string is null or empty\.

<a name='DiGi.GIS.Create.Hash(System.Collections.Generic.IEnumerable_double_)'></a>

## Create\.Hash\(IEnumerable\<double\>\) Method

Computes a hash value for the specified collection of double\-precision floating\-point numbers\.

```csharp
public static long Hash(System.Collections.Generic.IEnumerable<double>? doubles);
```
#### Parameters

<a name='DiGi.GIS.Create.Hash(System.Collections.Generic.IEnumerable_double_).doubles'></a>

`doubles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of doubles to be hashed\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
A long integer representing the computed hash of the collection; returns 0 if the collection is null or empty\.

<a name='DiGi.GIS.Create.Hash(System.Collections.Generic.IEnumerable_long_)'></a>

## Create\.Hash\(IEnumerable\<long\>\) Method

Computes a hash value for the specified collection of long integers\.

```csharp
public static long Hash(System.Collections.Generic.IEnumerable<long>? longs);
```
#### Parameters

<a name='DiGi.GIS.Create.Hash(System.Collections.Generic.IEnumerable_long_).longs'></a>

`longs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of longs to be hashed\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
A long integer representing the computed hash of the collection; returns 0 if the collection is null or empty\.

<a name='DiGi.GIS.Create.Hash_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## Create\.Hash\<T\>\(IEnumerable\<T\>\) Method

Computes a hash value for the specified collection of geometry objects\.

```csharp
public static long Hash<T>(System.Collections.Generic.IEnumerable<T>? geometries)
    where T : DiGi.GML.Classes.Geometry;
```
#### Type parameters

<a name='DiGi.GIS.Create.Hash_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of geometry object, which must derive from [DiGi\.GML\.Classes\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.geometry 'DiGi\.GML\.Classes\.Geometry')\.
#### Parameters

<a name='DiGi.GIS.Create.Hash_T_(System.Collections.Generic.IEnumerable_T_).geometries'></a>

`geometries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.GIS.md#DiGi.GIS.Create.Hash_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.GIS\.Create\.Hash\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries to be hashed\.

#### Returns
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
A long integer representing the computed hash of the geometry collection; returns 0 if the collection is null or empty\.

<a name='DiGi.GIS.Create.IndexDataFile_TAdministrativeAreal2D_(thisSystem.Collections.Generic.IEnumerable_TAdministrativeAreal2D_)'></a>

## Create\.IndexDataFile\<TAdministrativeAreal2D\>\(this IEnumerable\<TAdministrativeAreal2D\>\) Method

Creates an IndexDataFile from a collection of administrative areal entities\.

```csharp
public static DiGi.GIS.Classes.IndexDataFile? IndexDataFile<TAdministrativeAreal2D>(this System.Collections.Generic.IEnumerable<TAdministrativeAreal2D>? administrativeAreal2Ds)
    where TAdministrativeAreal2D : DiGi.GIS.Classes.AdministrativeAreal2D;
```
#### Type parameters

<a name='DiGi.GIS.Create.IndexDataFile_TAdministrativeAreal2D_(thisSystem.Collections.Generic.IEnumerable_TAdministrativeAreal2D_).TAdministrativeAreal2D'></a>

`TAdministrativeAreal2D`

The type of the administrative areal entity, which must inherit from AdministrativeAreal2D\.
#### Parameters

<a name='DiGi.GIS.Create.IndexDataFile_TAdministrativeAreal2D_(thisSystem.Collections.Generic.IEnumerable_TAdministrativeAreal2D_).administrativeAreal2Ds'></a>

`administrativeAreal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TAdministrativeAreal2D](DiGi.GIS.md#DiGi.GIS.Create.IndexDataFile_TAdministrativeAreal2D_(thisSystem.Collections.Generic.IEnumerable_TAdministrativeAreal2D_).TAdministrativeAreal2D 'DiGi\.GIS\.Create\.IndexDataFile\<TAdministrativeAreal2D\>\(this System\.Collections\.Generic\.IEnumerable\<TAdministrativeAreal2D\>\)\.TAdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of administrative areal entities to be indexed\.

#### Returns
[IndexDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.IndexDataFile 'DiGi\.GIS\.Classes\.IndexDataFile')  
An IndexDataFile containing the indexed data, or null if the input collection is null\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool)'></a>

## Create\.OrtoDatas\(this BoundingBox2D, string, Range\<int\>, double, bool\) Method

Asynchronously retrieves orthophoto data for a specific bounding box and year range\.

```csharp
public static System.Threading.Tasks.Task<DiGi.GIS.Classes.OrtoDatas?> OrtoDatas(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, string? reference, DiGi.Core.Classes.Range<int>? years, double scale, bool reduce=true);
```
#### Parameters

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The geographic area to retrieve data for\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A reference string associated with the requested data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which to retrieve orthophoto data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor used for the image request\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the result set\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the OrtoDatas if successful; otherwise, null\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool)'></a>

## Create\.OrtoDatas\(this Building2D, Range\<int\>, double, double, bool, bool\) Method

Asynchronously retrieves orthophoto data for a specified building within a given range of years\.

```csharp
public static System.Threading.Tasks.Task<DiGi.GIS.Classes.OrtoDatas?> OrtoDatas(this DiGi.GIS.Classes.Building2D? building2D, DiGi.Core.Classes.Range<int>? years, double offset=5.0, double width=320.0, bool reduce=true, bool squared=false);
```
#### Parameters

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object used to determine the area of interest\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which to retrieve orthophoto data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset distance to expand the bounding box around the building\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The desired width of the resulting image data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the result set\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool).squared'></a>

`squared` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the requested area should be forced into a square shape\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the OrtoDatas if successful; otherwise, null\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,DiGi.Core.Classes.Range_int_,double,bool,bool)'></a>

## Create\.OrtoDatas\(this OrtoRange, Range\<int\>, double, bool, bool\) Method

Asynchronously retrieves orthophoto data based on an existing OrtoRange and a specified year range\.

```csharp
public static System.Threading.Tasks.Task<DiGi.GIS.Classes.OrtoDatas?> OrtoDatas(this DiGi.GIS.Classes.OrtoRange? ortoRange, DiGi.Core.Classes.Range<int>? years, double scale, bool reduce=true, bool squared=false);
```
#### Parameters

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,DiGi.Core.Classes.Range_int_,double,bool,bool).ortoRange'></a>

`ortoRange` [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')

The source range containing the bounding box and unique identifier\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,DiGi.Core.Classes.Range_int_,double,bool,bool).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which to retrieve orthophoto data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,DiGi.Core.Classes.Range_int_,double,bool,bool).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor used for the image request\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,DiGi.Core.Classes.Range_int_,double,bool,bool).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the result set\.

<a name='DiGi.GIS.Create.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,DiGi.Core.Classes.Range_int_,double,bool,bool).squared'></a>

`squared` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the requested area should be forced into a square shape\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the OrtoDatas if successful; otherwise, null\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int)'></a>

## Create\.OrtoDatas\(this HttpClient, BoundingBox2D, string, Range\<int\>, double, bool, int\) Method

Asynchronously retrieves orthophoto data for a specific bounding box using a provided HttpClient and year range\.

```csharp
public static System.Threading.Tasks.Task<DiGi.GIS.Classes.OrtoDatas?> OrtoDatas(this System.Net.Http.HttpClient httpClient, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, string? reference, DiGi.Core.Classes.Range<int>? years, double scale, bool reduce=true, int initialRequestCount=8);
```
#### Parameters

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client used to perform the network requests\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The geographic area to retrieve data for\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A reference string associated with the requested data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which to retrieve orthophoto data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor used for the image request\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the result set\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,string,DiGi.Core.Classes.Range_int_,double,bool,int).initialRequestCount'></a>

`initialRequestCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The initial number of requests to perform when querying data\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the OrtoDatas if successful; otherwise, null\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int)'></a>

## Create\.OrtoDatas\(this HttpClient, Building2D, Range\<int\>, double, double, bool, bool, int\) Method

Asynchronously retrieves orthophoto data for a specified building using a provided HttpClient and within a given range of years\.

```csharp
public static System.Threading.Tasks.Task<DiGi.GIS.Classes.OrtoDatas?> OrtoDatas(this System.Net.Http.HttpClient httpClient, DiGi.GIS.Classes.Building2D? building2D, DiGi.Core.Classes.Range<int>? years, double offset=5.0, double width=320.0, bool reduce=true, bool squared=false, int initialRequestCount=8);
```
#### Parameters

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client used to perform the network requests\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object used to determine the area of interest\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which to retrieve orthophoto data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset distance to expand the bounding box around the building\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The desired width of the resulting image data\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).reduce'></a>

`reduce` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to reduce the result set\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).squared'></a>

`squared` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the requested area should be forced into a square shape\.

<a name='DiGi.GIS.Create.OrtoDatas(thisSystem.Net.Http.HttpClient,DiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool,bool,int).initialRequestCount'></a>

`initialRequestCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The initial number of requests to perform when querying data\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the OrtoDatas if successful; otherwise, null\.

<a name='DiGi.GIS.Create.OrtoRanges(DiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_string_,DiGi.GIS.Classes.OrtoRangeOptions,double)'></a>

## Create\.OrtoRanges\(GISModel, IEnumerable\<string\>, OrtoRangeOptions, double\) Method

Generates a list of ortho ranges based on the provided GIS model and options\.

```csharp
public static System.Collections.Generic.List<DiGi.GIS.Classes.OrtoRange>? OrtoRanges(DiGi.GIS.Classes.GISModel? gISModel, System.Collections.Generic.IEnumerable<string>? references=null, DiGi.GIS.Classes.OrtoRangeOptions? ortoRangeOptions=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Create.OrtoRanges(DiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_string_,DiGi.GIS.Classes.OrtoRangeOptions,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model from which building data is retrieved\.

<a name='DiGi.GIS.Create.OrtoRanges(DiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_string_,DiGi.GIS.Classes.OrtoRangeOptions,double).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of references to filter the buildings included in the calculation\.

<a name='DiGi.GIS.Create.OrtoRanges(DiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_string_,DiGi.GIS.Classes.OrtoRangeOptions,double).ortoRangeOptions'></a>

`ortoRangeOptions` [OrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoRangeOptions')

Options specifying the dimensions for the ortho ranges\.

<a name='DiGi.GIS.Create.OrtoRanges(DiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_string_,DiGi.GIS.Classes.OrtoRangeOptions,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for range and intersection checks\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange') objects if successful; otherwise, null\.

<a name='DiGi.GIS.Create.Reference(string)'></a>

## Create\.Reference\(string\) Method

Sanitizes the provided text to ensure it contains only characters valid for a file name, replacing invalid characters with underscores\.

```csharp
public static string? Reference(string? text);
```
#### Parameters

<a name='DiGi.GIS.Create.Reference(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source text to be sanitized\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the sanitized text, or null if the input text is null or empty\.

<a name='DiGi.GIS.Create.StatisticalUnit(thisSystem.Collections.Generic.IEnumerable_DiGi.BDL.Classes.Unit_)'></a>

## Create\.StatisticalUnit\(this IEnumerable\<Unit\>\) Method

Processes a collection of units to determine and create the most appropriate statistical unit based on hierarchy levels and codes\.

```csharp
public static DiGi.GIS.Classes.StatisticalUnit? StatisticalUnit(this System.Collections.Generic.IEnumerable<DiGi.BDL.Classes.Unit>? units);
```
#### Parameters

<a name='DiGi.GIS.Create.StatisticalUnit(thisSystem.Collections.Generic.IEnumerable_DiGi.BDL.Classes.Unit_).units'></a>

`units` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.BDL\.Classes\.Unit](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.classes.unit 'DiGi\.BDL\.Classes\.Unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of units to be processed\.

#### Returns
[StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')  
The resulting [StatisticalUnit\(this IEnumerable&lt;Unit&gt;\)](DiGi.GIS.md#DiGi.GIS.Create.StatisticalUnit(thisSystem.Collections.Generic.IEnumerable_DiGi.BDL.Classes.Unit_) 'DiGi\.GIS\.Create\.StatisticalUnit\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.BDL\.Classes\.Unit\>\)') if found; otherwise, null\.

<a name='DiGi.GIS.Create.UnitCode(string)'></a>

## Create\.UnitCode\(string\) Method

Converts a string representation of a unit code into a [UnitCode\(string\)](DiGi.GIS.md#DiGi.GIS.Create.UnitCode(string) 'DiGi\.GIS\.Create\.UnitCode\(string\)') object, ensuring it is padded to 12 digits\.

```csharp
public static DiGi.GIS.Classes.UnitCode? UnitCode(string? code);
```
#### Parameters

<a name='DiGi.GIS.Create.UnitCode(string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The input string containing the unit code\.

#### Returns
[UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')  
A [UnitCode\(string\)](DiGi.GIS.md#DiGi.GIS.Create.UnitCode(string) 'DiGi\.GIS\.Create\.UnitCode\(string\)') instance if the input is valid and numeric; otherwise, null\.

<a name='DiGi.GIS.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.GISModel,DiGi.GML.Classes.FeatureCollection)'></a>

## Modify\.AddRange\(this GISModel, FeatureCollection\) Method

Adds a range of features from the specified feature collection to the GIS model, filtering for specific geometry types\.

```csharp
public static System.Collections.Generic.List<DiGi.Core.Classes.GuidReference>? AddRange(this DiGi.GIS.Classes.GISModel? gISModel, DiGi.GML.Classes.FeatureCollection? featureCollection);
```
#### Parameters

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.GISModel,DiGi.GML.Classes.FeatureCollection).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model instance to which the features should be added\.

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.GISModel,DiGi.GML.Classes.FeatureCollection).featureCollection'></a>

`featureCollection` [DiGi\.GML\.Classes\.FeatureCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.featurecollection 'DiGi\.GML\.Classes\.FeatureCollection')

The collection of GML features to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') for the successfully updated features, or null if the model or feature collection is null or contains no valid members\.

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.GISModel,System.IO.Stream)'></a>

## Modify\.AddRange\(this GISModel, Stream\) Method

Adds a range of features from the specified stream to the GIS model by converting the stream content to GML\.

```csharp
public static System.Collections.Generic.List<DiGi.Core.Classes.GuidReference>? AddRange(this DiGi.GIS.Classes.GISModel? gISModel, System.IO.Stream? stream);
```
#### Parameters

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.GISModel,System.IO.Stream).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model instance to which the features should be added\.

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.GISModel,System.IO.Stream).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The input stream containing the feature data in GML format\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') for the successfully added features, or null if the stream is null or no valid feature collection was found\.

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Classes.UnitYearlyValues)'></a>

## Modify\.AddRange\(this StatisticalDataCollection, UnitYearlyValues\) Method

Adds a range of yearly statistical values from the provided unit yearly values to the specified statistical data collection\.

```csharp
public static System.Collections.Generic.List<DiGi.GIS.Classes.StatisticalYearlyDoubleData>? AddRange(this DiGi.GIS.Classes.StatisticalDataCollection? statisticalDataCollection, DiGi.BDL.Classes.UnitYearlyValues? unitYearlyValues);
```
#### Parameters

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Classes.UnitYearlyValues).statisticalDataCollection'></a>

`statisticalDataCollection` [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')

The collection where the processed statistical data will be stored\.

<a name='DiGi.GIS.Modify.AddRange(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Classes.UnitYearlyValues).unitYearlyValues'></a>

`unitYearlyValues` [DiGi\.BDL\.Classes\.UnitYearlyValues](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.classes.unityearlyvalues 'DiGi\.BDL\.Classes\.UnitYearlyValues')

The source object containing results and yearly values for units\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [StatisticalYearlyDoubleData](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalYearlyDoubleData 'DiGi\.GIS\.Classes\.StatisticalYearlyDoubleData') that were processed, or null if either parameter is null\.

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions)'></a>

## Modify\.AddValue\(this OrtoDatasFile, Building2D, OrtoDatasBuilding2DOptions\) Method

Asynchronously adds a value to the specified OrtoDatasFile based on building data and provided options\.

```csharp
public static System.Threading.Tasks.Task<DiGi.Core.Classes.UniqueReference?> AddValue(this DiGi.GIS.Classes.OrtoDatasFile? ortoDatasFile, DiGi.GIS.Classes.Building2D? building2D, DiGi.GIS.Classes.OrtoDatasBuilding2DOptions? ortoDatasBuilding2DOptions=null);
```
#### Parameters

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions).ortoDatasFile'></a>

`ortoDatasFile` [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile')

The target file where the generated OrtoDatas value will be added\.

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object used as a source for creating the OrtoDatas\.

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions).ortoDatasBuilding2DOptions'></a>

`ortoDatasBuilding2DOptions` [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions')

Optional settings to configure how the OrtoDatas are generated from the building data\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the unique reference of the added value, or null if the input parameters were null or the creation process failed\.

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.OrtoRange,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions)'></a>

## Modify\.AddValue\(this OrtoDatasFile, OrtoRange, OrtoDatasOrtoRangeOptions\) Method

Asynchronously adds a value to the specified OrtoDatasFile based on range data and provided options\.

```csharp
public static System.Threading.Tasks.Task<DiGi.Core.Classes.UniqueReference?> AddValue(this DiGi.GIS.Classes.OrtoDatasFile? ortoDatasFile, DiGi.GIS.Classes.OrtoRange? ortoRange, DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions? ortoDatasOrtoRangeOptions=null);
```
#### Parameters

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.OrtoRange,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions).ortoDatasFile'></a>

`ortoDatasFile` [OrtoDatasFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasFile 'DiGi\.GIS\.Classes\.OrtoDatasFile')

The target file where the generated OrtoDatas value will be added\.

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.OrtoRange,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions).ortoRange'></a>

`ortoRange` [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')

The range object used as a source for creating the OrtoDatas\.

<a name='DiGi.GIS.Modify.AddValue(thisDiGi.GIS.Classes.OrtoDatasFile,DiGi.GIS.Classes.OrtoRange,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions).ortoDatasOrtoRangeOptions'></a>

`ortoDatasOrtoRangeOptions` [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions')

Optional settings to configure how the OrtoDatas are generated from the range data\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the unique reference of the added value, or null if the input parameters were null or the creation process failed\.

<a name='DiGi.GIS.Modify.Calculate(thisDiGi.GIS.Classes.GISModel,double)'></a>

## Modify\.Calculate\(this GISModel, double\) Method

Calculates various 2D geometries and occupancy for the provided GIS model based on a specified tolerance\.

```csharp
public static void Calculate(this DiGi.GIS.Classes.GISModel gISModel, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Modify.Calculate(thisDiGi.GIS.Classes.GISModel,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model instance to perform calculations on\.

<a name='DiGi.GIS.Modify.Calculate(thisDiGi.GIS.Classes.GISModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during geometry calculations\. Defaults to Core\.Constants\.Tolerance\.Distance\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DAdministrativeAreal2Ds(thisDiGi.GIS.Classes.GISModel,double)'></a>

## Modify\.CalculateAdministrativeAreal2DAdministrativeAreal2Ds\(this GISModel, double\) Method

Calculates and updates the relationships between administrative areal 2D objects based on their geometric properties, area sizes, and a specified tolerance\.

```csharp
public static void CalculateAdministrativeAreal2DAdministrativeAreal2Ds(this DiGi.GIS.Classes.GISModel gISModel, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DAdministrativeAreal2Ds(thisDiGi.GIS.Classes.GISModel,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model instance containing the administrative areal 2D objects to be processed\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DAdministrativeAreal2Ds(thisDiGi.GIS.Classes.GISModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for spatial range calculations\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DBuilding2Ds(thisDiGi.GIS.Classes.GISModel,double)'></a>

## Modify\.CalculateAdministrativeAreal2DBuilding2Ds\(this GISModel, double\) Method

Calculates and updates the relationship between administrative areal 2D objects and building 2D objects based on their geometric positions within the GIS model\.

```csharp
public static void CalculateAdministrativeAreal2DBuilding2Ds(this DiGi.GIS.Classes.GISModel? gISModel, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DBuilding2Ds(thisDiGi.GIS.Classes.GISModel,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model containing the buildings and administrative areas to be processed\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DBuilding2Ds(thisDiGi.GIS.Classes.GISModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for spatial calculations and point\-in\-polygon checks\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DGeometries(thisDiGi.GIS.Classes.GISModel,double)'></a>

## Modify\.CalculateAdministrativeAreal2DGeometries\(this GISModel, double\) Method

Calculates the 2D geometries for administrative areal objects within the provided GIS model\.

```csharp
public static void CalculateAdministrativeAreal2DGeometries(this DiGi.GIS.Classes.GISModel gISModel, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DGeometries(thisDiGi.GIS.Classes.GISModel,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model containing the administrative areal objects to be processed\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DGeometries(thisDiGi.GIS.Classes.GISModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during the geometry calculation process\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DStatisticalUnits(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.StatisticalUnit,System.Collections.Generic.List_DiGi.GIS.Classes.AdministrativeAreal2D_)'></a>

## Modify\.CalculateAdministrativeAreal2DStatisticalUnits\(this GISModel, StatisticalUnit, List\<AdministrativeAreal2D\>\) Method

Calculates the administrative areal 2D statistical units for a specified statistical unit using the provided GIS model\.

```csharp
public static void CalculateAdministrativeAreal2DStatisticalUnits(this DiGi.GIS.Classes.GISModel? gISModel, DiGi.GIS.Classes.StatisticalUnit? statisticalUnit, out System.Collections.Generic.List<DiGi.GIS.Classes.AdministrativeAreal2D>? invalidAdministrativeAreal2Ds);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DStatisticalUnits(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.StatisticalUnit,System.Collections.Generic.List_DiGi.GIS.Classes.AdministrativeAreal2D_).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel') instance used to perform the calculations\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DStatisticalUnits(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.StatisticalUnit,System.Collections.Generic.List_DiGi.GIS.Classes.AdministrativeAreal2D_).statisticalUnit'></a>

`statisticalUnit` [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')

The [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') for which the administrative areal 2D units are calculated\.

<a name='DiGi.GIS.Modify.CalculateAdministrativeAreal2DStatisticalUnits(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.StatisticalUnit,System.Collections.Generic.List_DiGi.GIS.Classes.AdministrativeAreal2D_).invalidAdministrativeAreal2Ds'></a>

`invalidAdministrativeAreal2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of invalid administrative areal 2D units identified during the calculation; otherwise, null\.

<a name='DiGi.GIS.Modify.CalculateBuilding2DGeometries(thisDiGi.GIS.Classes.GISModel,double)'></a>

## Modify\.CalculateBuilding2DGeometries\(this GISModel, double\) Method

Calculates the 2D geometries for all building objects within the provided GIS model\.

```csharp
public static void CalculateBuilding2DGeometries(this DiGi.GIS.Classes.GISModel? gISModel, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateBuilding2DGeometries(thisDiGi.GIS.Classes.GISModel,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model containing the buildings to process\.

<a name='DiGi.GIS.Modify.CalculateBuilding2DGeometries(thisDiGi.GIS.Classes.GISModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during geometry calculation\.

<a name='DiGi.GIS.Modify.CalculateOccupancy(thisDiGi.GIS.Classes.GISModel)'></a>

## Modify\.CalculateOccupancy\(this GISModel\) Method

Calculates the occupancy for the specified [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')\.

```csharp
public static void CalculateOccupancy(this DiGi.GIS.Classes.GISModel gISModel);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateOccupancy(thisDiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel') instance to calculate occupancy for\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions,bool)'></a>

## Modify\.CalculateOrtoDatas\(this IEnumerable\<Building2D\>, string, OrtoDatasBuilding2DOptions, bool\) Method

Calculates orthodata for the specified collection of building 2D objects and saves them to the provided path\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.HashSet<DiGi.Core.Classes.GuidReference>?> CalculateOrtoDatas(this System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, string? path, DiGi.GIS.Classes.OrtoDatasBuilding2DOptions? ortoDatasBuilding2DOptions, bool overrideExisting=false);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions,bool).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of Building2D objects to process\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions,bool).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path where the orthodata should be stored\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions,bool).ortoDatasBuilding2DOptions'></a>

`ortoDatasBuilding2DOptions` [OrtoDatasBuilding2DOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasBuilding2DOptions 'DiGi\.GIS\.Classes\.OrtoDatasBuilding2DOptions')

The options used for calculating orthodata for building 2D objects\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Classes.OrtoDatasBuilding2DOptions,bool).overrideExisting'></a>

`overrideExisting` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to override existing data in the target files\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a set of [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') for the processed buildings, or null if the input parameters are invalid\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_,string,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions,bool)'></a>

## Modify\.CalculateOrtoDatas\(this IEnumerable\<OrtoRange\>, string, OrtoDatasOrtoRangeOptions, bool\) Method

Calculates orthodata for the specified collection of ortho range objects and saves them to the provided path\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.HashSet<DiGi.Core.Classes.GuidReference>?> CalculateOrtoDatas(this System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoRange>? ortoRanges, string? path, DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions? ortoDatasOrtoRangeOptions, bool overrideExisting=false);
```
#### Parameters

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_,string,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions,bool).ortoRanges'></a>

`ortoRanges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of OrtoRange objects to process\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_,string,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions,bool).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path where the orthodata should be stored\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_,string,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions,bool).ortoDatasOrtoRangeOptions'></a>

`ortoDatasOrtoRangeOptions` [OrtoDatasOrtoRangeOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions 'DiGi\.GIS\.Classes\.OrtoDatasOrtoRangeOptions')

The options used for calculating orthodata for ortho range objects\.

<a name='DiGi.GIS.Modify.CalculateOrtoDatas(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_,string,DiGi.GIS.Classes.OrtoDatasOrtoRangeOptions,bool).overrideExisting'></a>

`overrideExisting` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to override existing data in the target files\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a set of [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') for the processed ranges, or null if the input parameters are invalid\.

<a name='DiGi.GIS.Modify.Extract(thisDiGi.GIS.Classes.DirectoryExtractOptions)'></a>

## Modify\.Extract\(this DirectoryExtractOptions\) Method

Extracts GIS data from a zip archive and organizes it into directories based on the provided options\.

```csharp
public static bool Extract(this DiGi.GIS.Classes.DirectoryExtractOptions? directoryExtractOptions);
```
#### Parameters

<a name='DiGi.GIS.Modify.Extract(thisDiGi.GIS.Classes.DirectoryExtractOptions).directoryExtractOptions'></a>

`directoryExtractOptions` [DirectoryExtractOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryExtractOptions 'DiGi\.GIS\.Classes\.DirectoryExtractOptions')

The options specifying the source path, destination directory, and extraction behavior\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the extraction process was successful; otherwise, false\.

<a name='DiGi.GIS.Modify.UpdateUserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D,System.Nullable_short_)'></a>

## Modify\.UpdateUserYearBuilt\(this GISModelFile, Building2D, Nullable\<short\>\) Method

Updates the user\-defined year built for a specific building within a GIS model file\.

```csharp
public static DiGi.Core.Classes.UniqueReference? UpdateUserYearBuilt(this DiGi.GIS.Classes.GISModelFile? gISModelFile, DiGi.GIS.Classes.Building2D? builidng2D, System.Nullable<short> yearBuilt);
```
#### Parameters

<a name='DiGi.GIS.Modify.UpdateUserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D,System.Nullable_short_).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file containing the data path\.

<a name='DiGi.GIS.Modify.UpdateUserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D,System.Nullable_short_).builidng2D'></a>

`builidng2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object whose reference is used to identify the record\.

<a name='DiGi.GIS.Modify.UpdateUserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D,System.Nullable_short_).yearBuilt'></a>

`yearBuilt` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The new year built value to set; if null, the user\-defined year built is removed\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') identifying the updated or removed record, or `null` if the operation could not be performed\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_)'></a>

## Modify\.Write\(this Building2D, string, Range\<int\>\) Method

Asynchronously writes the image data for a specific building to the specified directory within the given range\.

```csharp
public static System.Threading.Tasks.Task<bool> Write(this DiGi.GIS.Classes.Building2D? building2D, string? directory, DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') object containing the reference and data\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory path where the building's folder will be created\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of image indices to retrieve and save\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if the files were written or already existed; otherwise, false\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.StatisticalUnit,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,DiGi.Core.Classes.Range_int_)'></a>

## Modify\.Write\(this StatisticalUnit, string, IEnumerable\<Variable\>, Range\<int\>\) Method

Asynchronously writes statistical data for a specific unit to the specified path for a range of years\.

```csharp
public static System.Threading.Tasks.Task<bool> Write(this DiGi.GIS.Classes.StatisticalUnit? statisticalUnit, string? path, System.Collections.Generic.IEnumerable<DiGi.BDL.Enums.Variable>? variables, DiGi.Core.Classes.Range<int>? years);
```
#### Parameters

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.StatisticalUnit,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,DiGi.Core.Classes.Range_int_).statisticalUnit'></a>

`statisticalUnit` [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')

The [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit') object containing the unit code\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.StatisticalUnit,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,DiGi.Core.Classes.Range_int_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path where the statistical data collection is stored\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.StatisticalUnit,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,DiGi.Core.Classes.Range_int_).variables'></a>

`variables` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.BDL\.Enums\.Variable](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.enums.variable 'DiGi\.BDL\.Enums\.Variable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.BDL\.Enums\.Variable](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.enums.variable 'DiGi\.BDL\.Enums\.Variable') objects to write\.

<a name='DiGi.GIS.Modify.Write(thisDiGi.GIS.Classes.StatisticalUnit,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,DiGi.Core.Classes.Range_int_).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which data should be written\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if the data was successfully written; otherwise, false\.

<a name='DiGi.GIS.Modify.Write(thisstring,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,bool)'></a>

## Modify\.Write\(this string, string, IEnumerable\<Variable\>, IEnumerable\<int\>, bool\) Method

Asynchronously writes statistical data for a given code to the specified collection file\.

```csharp
public static System.Threading.Tasks.Task<bool> Write(this string? code, string? path, System.Collections.Generic.IEnumerable<DiGi.BDL.Enums.Variable>? variables, System.Collections.Generic.IEnumerable<int>? years, bool overrideExisting=false);
```
#### Parameters

<a name='DiGi.GIS.Modify.Write(thisstring,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,bool).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier code of the statistical unit\.

<a name='DiGi.GIS.Modify.Write(thisstring,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,bool).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the statistical data collection file\.

<a name='DiGi.GIS.Modify.Write(thisstring,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,bool).variables'></a>

`variables` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.BDL\.Enums\.Variable](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.enums.variable 'DiGi\.BDL\.Enums\.Variable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of variables to be processed and written\.

<a name='DiGi.GIS.Modify.Write(thisstring,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,bool).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The list of years for which values should be retrieved and saved\.

<a name='DiGi.GIS.Modify.Write(thisstring,string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,bool).overrideExisting'></a>

`overrideExisting` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to true, existing data in the collection will be overwritten; otherwise, only new variables are added\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if the file was successfully updated and saved; otherwise, false\.

<a name='DiGi.GIS.Modify.Write(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.Range_int_)'></a>

## Modify\.Write\(this IEnumerable\<Building2D\>, string, Range\<int\>\) Method

Asynchronously writes a collection of building data to the specified directory for a given range\.

```csharp
public static System.Threading.Tasks.Task<bool> Write(this System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, string? directory, DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.GIS.Modify.Write(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.Range_int_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') objects to write\.

<a name='DiGi.GIS.Modify.Write(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.Range_int_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The target directory path where files will be saved\.

<a name='DiGi.GIS.Modify.Write(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of indices to process for each building\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if the operation completed successfully; otherwise, false\.

<a name='DiGi.GIS.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GIS.Query.AdministrativeAreal2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.Building2D)'></a>

## Query\.AdministrativeAreal2Ds\<UAdministrativeAreal2D\>\(this GISModel, Building2D\) Method

Retrieves a list of administrative areal objects associated with the specified building within the GIS model\.

```csharp
public static System.Collections.Generic.List<UAdministrativeAreal2D>? AdministrativeAreal2Ds<UAdministrativeAreal2D>(this DiGi.GIS.Classes.GISModel? gISModel, DiGi.GIS.Classes.Building2D? building2D)
    where UAdministrativeAreal2D : DiGi.GIS.Classes.AdministrativeAreal2D;
```
#### Type parameters

<a name='DiGi.GIS.Query.AdministrativeAreal2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.Building2D).UAdministrativeAreal2D'></a>

`UAdministrativeAreal2D`

The type of the administrative areal object, which must derive from [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')\.
#### Parameters

<a name='DiGi.GIS.Query.AdministrativeAreal2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.Building2D).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model instance used to query relations and objects\.

<a name='DiGi.GIS.Query.AdministrativeAreal2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object for which associated administrative areals are retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UAdministrativeAreal2D](DiGi.GIS.md#DiGi.GIS.Query.AdministrativeAreal2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.Building2D).UAdministrativeAreal2D 'DiGi\.GIS\.Query\.AdministrativeAreal2Ds\<UAdministrativeAreal2D\>\(this DiGi\.GIS\.Classes\.GISModel, DiGi\.GIS\.Classes\.Building2D\)\.UAdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [UAdministrativeAreal2D](DiGi.GIS.md#DiGi.GIS.Query.AdministrativeAreal2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.GIS.Classes.Building2D).UAdministrativeAreal2D 'DiGi\.GIS\.Query\.AdministrativeAreal2Ds\<UAdministrativeAreal2D\>\(this DiGi\.GIS\.Classes\.GISModel, DiGi\.GIS\.Classes\.Building2D\)\.UAdministrativeAreal2D') objects if associations exist; otherwise, null\.

<a name='DiGi.GIS.Query.AdministrativeAreal2DsDictionary_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## Query\.AdministrativeAreal2DsDictionary\<UAdministrativeAreal2D\>\(this GISModel, IEnumerable\<Building2D\>\) Method

Retrieves a dictionary mapping building references to their associated administrative areal objects based on the provided GIS model and buildings collection\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,System.Collections.Generic.List<UAdministrativeAreal2D>?>? AdministrativeAreal2DsDictionary<UAdministrativeAreal2D>(this DiGi.GIS.Classes.GISModel? gISModel, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds)
    where UAdministrativeAreal2D : DiGi.GIS.Classes.AdministrativeAreal2D;
```
#### Type parameters

<a name='DiGi.GIS.Query.AdministrativeAreal2DsDictionary_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).UAdministrativeAreal2D'></a>

`UAdministrativeAreal2D`

The type of administrative areal object, which must derive from AdministrativeAreal2D\.
#### Parameters

<a name='DiGi.GIS.Query.AdministrativeAreal2DsDictionary_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model instance used to retrieve relations and objects\.

<a name='DiGi.GIS.Query.AdministrativeAreal2DsDictionary_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of building objects for which the administrative areals are being queried\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UAdministrativeAreal2D](DiGi.GIS.md#DiGi.GIS.Query.AdministrativeAreal2DsDictionary_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).UAdministrativeAreal2D 'DiGi\.GIS\.Query\.AdministrativeAreal2DsDictionary\<UAdministrativeAreal2D\>\(this DiGi\.GIS\.Classes\.GISModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.GIS\.Classes\.Building2D\>\)\.UAdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping each building's unique reference to a list of its associated administrative areal objects, or null if the model or buildings collection is null or empty\.

<a name='DiGi.GIS.Query.Azimuth(thisDiGi.GIS.Classes.Building2D,DiGi.Geometry.Planar.Classes.Vector2D,double)'></a>

## Query\.Azimuth\(this Building2D, Vector2D, double\) Method

Calculates the azimuth of a building relative to a reference direction\.

```csharp
public static double Azimuth(this DiGi.GIS.Classes.Building2D? builidng2D, DiGi.Geometry.Planar.Classes.Vector2D? referenceDirection=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GIS.Query.Azimuth(thisDiGi.GIS.Classes.Building2D,DiGi.Geometry.Planar.Classes.Vector2D,double).builidng2D'></a>

`builidng2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building for which the azimuth is calculated\.

<a name='DiGi.GIS.Query.Azimuth(thisDiGi.GIS.Classes.Building2D,DiGi.Geometry.Planar.Classes.Vector2D,double).referenceDirection'></a>

`referenceDirection` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The reference direction vector used as the baseline for the angle calculation\. Defaults to WorldY if not provided\.

<a name='DiGi.GIS.Query.Azimuth(thisDiGi.GIS.Classes.Building2D,DiGi.Geometry.Planar.Classes.Vector2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used when creating the bounding rectangle of the polygonal face\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The azimuth angle in degrees, ranging from 0 to 360\. Returns double\.NaN if calculations cannot be performed\.

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double)'></a>

## Query\.Building2Ds\<UAdministrativeAreal2D\>\(this GISModel, Point2D, List\<UAdministrativeAreal2D\>, double, double\) Method

Retrieves a list of building objects located within administrative areas that encompass the specified point, optionally filtered by distance\.

```csharp
public static System.Collections.Generic.List<DiGi.GIS.Classes.Building2D>? Building2Ds<UAdministrativeAreal2D>(this DiGi.GIS.Classes.GISModel? gISModel, DiGi.Geometry.Planar.Classes.Point2D? point2D, out System.Collections.Generic.List<UAdministrativeAreal2D>? administrativeAreal2Ds, double distance=0.0, double tolerance=1E-06)
    where UAdministrativeAreal2D : DiGi.GIS.Classes.AdministrativeAreal2D;
```
#### Type parameters

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).UAdministrativeAreal2D'></a>

`UAdministrativeAreal2D`

The type of administrative areal object, which must derive from [AdministrativeAreal2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeAreal2D 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')\.
#### Parameters

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).gISModel'></a>

`gISModel` [GISModel](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model used to perform the query\.

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point used as the center for the spatial query\.

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).administrativeAreal2Ds'></a>

`administrativeAreal2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UAdministrativeAreal2D](DiGi.GIS.md#DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).UAdministrativeAreal2D 'DiGi\.GIS\.Query\.Building2Ds\<UAdministrativeAreal2D\>\(this DiGi\.GIS\.Classes\.GISModel, DiGi\.Geometry\.Planar\.Classes\.Point2D, System\.Collections\.Generic\.List\<UAdministrativeAreal2D\>, double, double\)\.UAdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of administrative areal objects that contain the specified point\.

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance from the point to consider for building inclusion\. If 0, only buildings containing the point are considered\.

<a name='DiGi.GIS.Query.Building2Ds_UAdministrativeAreal2D_(thisDiGi.GIS.Classes.GISModel,DiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.List_UAdministrativeAreal2D_,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for spatial range calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') objects found within the matching administrative areas and meeting the distance criteria; otherwise, null if the model or point is null or no administrative areas are found\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.Building2DYearBuiltPredictionsDictionary\(Building2DYearBuiltPredictionsFile, IEnumerable\<string\>\) Method

Retrieves a dictionary of building 2D year built predictions from a specific prediction file for the given references\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile? building2DYearBuiltPredictionsFile, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile,System.Collections.Generic.IEnumerable_string_).building2DYearBuiltPredictionsFile'></a>

`building2DYearBuiltPredictionsFile` [Building2DYearBuiltPredictionsFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictionsFile')

The prediction file instance to read data from\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.Building2DYearBuiltPredictionsFile,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings to look up\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping unique IDs to building 2D year built predictions, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.Building2DYearBuiltPredictionsDictionary\(GISModelFile, IEnumerable\<string\>\) Method

Retrieves a dictionary of building 2D year built predictions based on the provided GIS model file and references\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.GISModelFile? gISModelFile, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file used to determine the location of the prediction data\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings to look up\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping unique IDs to building 2D year built predictions, or null if inputs are invalid or files are missing\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## Query\.Building2DYearBuiltPredictionsDictionary\(string, IEnumerable\<Building2D\>\) Method

Retrieves a dictionary of building 2D year built predictions for a set of building objects by searching the specified directory\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,DiGi.GIS.Classes.Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds);
```
#### Parameters

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory path containing the prediction files\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of Building2D objects to retrieve predictions for\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping GuidReferences to building 2D year built predictions, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(string,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.Building2DYearBuiltPredictionsDictionary\(string, IEnumerable\<string\>\) Method

Retrieves a dictionary of building 2D year built predictions by searching all prediction files within a specified directory for the given references\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(string? directory, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory path containing the prediction files\.

<a name='DiGi.GIS.Query.Building2DYearBuiltPredictionsDictionary(string,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings to look up\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Building2DYearBuiltPredictions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2DYearBuiltPredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping unique IDs to building 2D year built predictions, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double)'></a>

## Query\.BytesDictionary\(this BoundingBox2D, IEnumerable\<int\>, double\) Method

Asynchronously retrieves a dictionary of byte arrays for specified years within a bounding box at a given scale\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,byte[]>?> BytesDictionary(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<int>? years, double scale);
```
#### Parameters

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box defining the area of interest\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of years for which to retrieve data\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor used for the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if inputs are invalid or the bounding box area is too small\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool)'></a>

## Query\.BytesDictionary\(this Building2D, Range\<int\>, double, double, bool\) Method

Asynchronously retrieves a dictionary of byte arrays for a range of years based on the provided building's geometry and image parameters\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,byte[]>?> BytesDictionary(this DiGi.GIS.Classes.Building2D? building2D, DiGi.Core.Classes.Range<int>? years, double offset=5.0, double width=320.0, bool squared=false);
```
#### Parameters

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object used to determine the area of interest\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of years for which to retrieve data\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset value applied to the image capture\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The desired width of the retrieved images\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,DiGi.Core.Classes.Range_int_,double,double,bool).squared'></a>

`squared` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the resulting images should be squared\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if the building or range is null\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool)'></a>

## Query\.BytesDictionary\(this Building2D, IEnumerable\<int\>, double, double, bool\) Method

Asynchronously retrieves a dictionary of byte arrays for specified years based on the provided building's geometry and image parameters\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,byte[]>?> BytesDictionary(this DiGi.GIS.Classes.Building2D? building2D, System.Collections.Generic.IEnumerable<int>? years, double offset=5.0, double width=320.0, bool squared=false);
```
#### Parameters

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object used to determine the area of interest\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of years for which to retrieve data\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset value applied to the image capture\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The desired width of the retrieved images\.

<a name='DiGi.GIS.Query.BytesDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).squared'></a>

`squared` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the resulting images should be squared\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if the building or years collection is null\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Collections.Generic.Dictionary_int,string_)'></a>

## Query\.BytesDictionary\(this Dictionary\<int,string\>\) Method

Asynchronously downloads data from a dictionary of URLs and returns the results as byte arrays\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,byte[]>?> BytesDictionary(this System.Collections.Generic.Dictionary<int,string>? ortoDataUrlDictionary);
```
#### Parameters

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Collections.Generic.Dictionary_int,string_).ortoDataUrlDictionary'></a>

`ortoDataUrlDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

A dictionary mapping years to their respective data source URLs\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a dictionary mapping years to the downloaded byte arrays, or null if the input dictionary is null or empty\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double,int)'></a>

## Query\.BytesDictionary\(this HttpClient, BoundingBox2D, IEnumerable\<int\>, double, int\) Method

Asynchronously retrieves a dictionary of byte arrays for specified years within a bounding box using a provided HttpClient\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,byte[]>?> BytesDictionary(this System.Net.Http.HttpClient httpClient, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<int>? years, double scale, int initialRequestCount=8);
```
#### Parameters

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double,int).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client used to perform the network requests\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double,int).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box defining the area of interest\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double,int).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of years for which to retrieve data\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double,int).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor used for the request\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double,int).initialRequestCount'></a>

`initialRequestCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of concurrent network requests allowed\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_int,string_,int)'></a>

## Query\.BytesDictionary\(this HttpClient, Dictionary\<int,string\>, int\) Method

Asynchronously downloads data from a dictionary of URLs using a provided HttpClient and a concurrency limit\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,byte[]>?> BytesDictionary(this System.Net.Http.HttpClient httpClient, System.Collections.Generic.Dictionary<int,string>? ortoDataUrlDictionary, int initialRequestCount=8);
```
#### Parameters

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_int,string_,int).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client used to perform the network requests\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_int,string_,int).ortoDataUrlDictionary'></a>

`ortoDataUrlDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

A dictionary mapping years to their respective data source URLs\.

<a name='DiGi.GIS.Query.BytesDictionary(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_int,string_,int).initialRequestCount'></a>

`initialRequestCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of concurrent network requests allowed\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a dictionary mapping years to the downloaded byte arrays, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.CardinalDirection(thisdouble)'></a>

## Query\.CardinalDirection\(this double\) Method

Gets the cardinal direction for a given azimuth angle\.

```csharp
public static DiGi.GIS.Enums.CardinalDirection CardinalDirection(this double azimuth);
```
#### Parameters

<a name='DiGi.GIS.Query.CardinalDirection(thisdouble).azimuth'></a>

`azimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth angle in degrees, typically ranging from 0 to 360\.

#### Returns
[CardinalDirection](DiGi.GIS.Enums.md#DiGi.GIS.Enums.CardinalDirection 'DiGi\.GIS\.Enums\.CardinalDirection')  
The corresponding [CardinalDirection](DiGi.GIS.Enums.md#DiGi.GIS.Enums.CardinalDirection 'DiGi\.GIS\.Enums\.CardinalDirection') based on the provided azimuth\.

<a name='DiGi.GIS.Query.Contains(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable)'></a>

## Query\.Contains\(this StatisticalDataCollection, Variable\) Method

Determines whether the specified statistical data collection contains a record associated with the provided variable\.

```csharp
public static bool Contains(this DiGi.GIS.Classes.StatisticalDataCollection statisticalDataCollection, DiGi.BDL.Enums.Variable variable);
```
#### Parameters

<a name='DiGi.GIS.Query.Contains(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).statisticalDataCollection'></a>

`statisticalDataCollection` [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')

The statistical data collection to search\.

<a name='DiGi.GIS.Query.Contains(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).variable'></a>

`variable` [DiGi\.BDL\.Enums\.Variable](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.enums.variable 'DiGi\.BDL\.Enums\.Variable')

The variable used as a reference for searching within the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the collection contains a record matching the variable's reference; otherwise, false\.

<a name='DiGi.GIS.Query.Directory(string,System.Collections.Generic.IEnumerable_string_,bool)'></a>

## Query\.Directory\(string, IEnumerable\<string\>, bool\) Method

Combines a base directory with a collection of directory names to form a full path, optionally verifying if the resulting directory exists on the disk\.

```csharp
public static string? Directory(string? directory, System.Collections.Generic.IEnumerable<string>? directoryNames, bool checkIfExists=false);
```
#### Parameters

<a name='DiGi.GIS.Query.Directory(string,System.Collections.Generic.IEnumerable_string_,bool).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory path\.

<a name='DiGi.GIS.Query.Directory(string,System.Collections.Generic.IEnumerable_string_,bool).directoryNames'></a>

`directoryNames` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of additional directory names to append to the base path\.

<a name='DiGi.GIS.Query.Directory(string,System.Collections.Generic.IEnumerable_string_,bool).checkIfExists'></a>

`checkIfExists` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to verify the existence of the combined path; if set to true and the resulting path does not exist, the original base directory is returned\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The combined directory path if successful or valid, otherwise the original directory or null if the base directory is null or whitespace\.

<a name='DiGi.GIS.Query.Directory(thisDiGi.GIS.Classes.DirectoryNamesOptions,string,bool)'></a>

## Query\.Directory\(this DirectoryNamesOptions, string, bool\) Method

Combines a base directory with directory names provided via a [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') object, optionally verifying if the resulting directory exists on the disk\.

```csharp
public static string? Directory(this DiGi.GIS.Classes.DirectoryNamesOptions? directoryNamesOptions, string directory, bool checkIfExists=false);
```
#### Parameters

<a name='DiGi.GIS.Query.Directory(thisDiGi.GIS.Classes.DirectoryNamesOptions,string,bool).directoryNamesOptions'></a>

`directoryNamesOptions` [DirectoryNamesOptions](DiGi.GIS.Classes.md#DiGi.GIS.Classes.DirectoryNamesOptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions')

The options object containing the list of directory names to append\.

<a name='DiGi.GIS.Query.Directory(thisDiGi.GIS.Classes.DirectoryNamesOptions,string,bool).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory path\.

<a name='DiGi.GIS.Query.Directory(thisDiGi.GIS.Classes.DirectoryNamesOptions,string,bool).checkIfExists'></a>

`checkIfExists` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to verify the existence of the combined path; if set to true and the resulting path does not exist, the original base directory is returned\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The combined directory path if successful or valid, otherwise the original directory or null if the options object is null\.

<a name='DiGi.GIS.Query.Distance(double,double,double,double)'></a>

## Query\.Distance\(double, double, double, double\) Method

Calculates the great\-circle distance between two points on the Earth's surface using their latitude and longitude coordinates\.

```csharp
public static double Distance(double latitude_1, double longitude_1, double latitude_2, double longitude_2);
```
#### Parameters

<a name='DiGi.GIS.Query.Distance(double,double,double,double).latitude_1'></a>

`latitude_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The latitude of the first point in decimal degrees\.

<a name='DiGi.GIS.Query.Distance(double,double,double,double).longitude_1'></a>

`longitude_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The longitude of the first point in decimal degrees\.

<a name='DiGi.GIS.Query.Distance(double,double,double,double).latitude_2'></a>

`latitude_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The latitude of the second point in decimal degrees\.

<a name='DiGi.GIS.Query.Distance(double,double,double,double).longitude_2'></a>

`longitude_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The longitude of the second point in decimal degrees\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance between the two points in meters, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if any of the input coordinates are NaN\.

<a name='DiGi.GIS.Query.EPWFile(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,double)'></a>

## Query\.EPWFile\(this Point2D, IEnumerable\<EPWFile\>, double\) Method

Finds the nearest EPW file based on a given 2D point\.

```csharp
public static DiGi.EPW.Classes.EPWFile? EPWFile(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.EPW.Classes.EPWFile>? ePWFiles, out double distance);
```
#### Parameters

<a name='DiGi.GIS.Query.EPWFile(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,double).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source 2D coordinate to search from\.

<a name='DiGi.GIS.Query.EPWFile(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,double).ePWFiles'></a>

`ePWFiles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.EPW\.Classes\.EPWFile](https://learn.microsoft.com/en-us/dotnet/api/digi.epw.classes.epwfile 'DiGi\.EPW\.Classes\.EPWFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of available EPW files to evaluate\.

<a name='DiGi.GIS.Query.EPWFile(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the distance between the input point and the nearest EPW file; otherwise, NaN\.

#### Returns
[DiGi\.EPW\.Classes\.EPWFile](https://learn.microsoft.com/en-us/dotnet/api/digi.epw.classes.epwfile 'DiGi\.EPW\.Classes\.EPWFile')  
The closest [EPWFile\(this Point2D, IEnumerable&lt;EPWFile&gt;, double\)](DiGi.GIS.md#DiGi.GIS.Query.EPWFile(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,double) 'DiGi\.GIS\.Query\.EPWFile\(this DiGi\.Geometry\.Planar\.Classes\.Point2D, System\.Collections\.Generic\.IEnumerable\<DiGi\.EPW\.Classes\.EPWFile\>, double\)') found in the provided collection, or null if no suitable file is found or inputs are invalid\.

<a name='DiGi.GIS.Query.FileName(string,string,string,double)'></a>

## Query\.FileName\(string, string, string, double\) Method

Generates a unique filename by appending an incrementing index until a file that either does not exist or is smaller than the specified maximum size is found\.

```csharp
public static string? FileName(string? directory, string? fileName, string? extension, double maxFileSize);
```
#### Parameters

<a name='DiGi.GIS.Query.FileName(string,string,string,double).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory path where the files are located\.

<a name='DiGi.GIS.Query.FileName(string,string,string,double).fileName'></a>

`fileName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base name of the file\.

<a name='DiGi.GIS.Query.FileName(string,string,string,double).extension'></a>

`extension` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file extension to be appended to the filename\.

<a name='DiGi.GIS.Query.FileName(string,string,string,double).maxFileSize'></a>

`maxFileSize` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum allowable size of the file in bytes\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A unique filename string if successful; otherwise, null if the directory or fileName is null or whitespace\.

<a name='DiGi.GIS.Query.IsCity(thisDiGi.GIS.Classes.AdministrativeSubdivision)'></a>

## Query\.IsCity\(this AdministrativeSubdivision\) Method

Determines whether the specified administrative subdivision represents a city\.

```csharp
public static bool IsCity(this DiGi.GIS.Classes.AdministrativeSubdivision administrativeSubdivision);
```
#### Parameters

<a name='DiGi.GIS.Query.IsCity(thisDiGi.GIS.Classes.AdministrativeSubdivision).administrativeSubdivision'></a>

`administrativeSubdivision` [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The administrative subdivision to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the administrative subdivision is not null and its type is urban; otherwise, false\.

<a name='DiGi.GIS.Query.IsCity(thisDiGi.GIS.Enums.AdministrativeSubdivisionType)'></a>

## Query\.IsCity\(this AdministrativeSubdivisionType\) Method

Determines whether the specified administrative subdivision type represents a city\.

```csharp
public static bool IsCity(this DiGi.GIS.Enums.AdministrativeSubdivisionType administrativeSubdivisionType);
```
#### Parameters

<a name='DiGi.GIS.Query.IsCity(thisDiGi.GIS.Enums.AdministrativeSubdivisionType).administrativeSubdivisionType'></a>

`administrativeSubdivisionType` [AdministrativeSubdivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeSubdivisionType 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')

The administrative subdivision type to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the administrative subdivision type is urban; otherwise, false\.

<a name='DiGi.GIS.Query.IsOccupied(thisDiGi.GIS.Classes.Building2D)'></a>

## Query\.IsOccupied\(this Building2D\) Method

Determines whether a building is occupied based on its phase, general function, and specific functions\.

```csharp
public static bool IsOccupied(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Query.IsOccupied(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the building meets all occupancy criteria; otherwise, false\.

<a name='DiGi.GIS.Query.IsResidential(thisDiGi.GIS.Classes.Building2D)'></a>

## Query\.IsResidential\(this Building2D\) Method

Determines whether the specified building is a residential building based on its general and specific functions\.

```csharp
public static bool IsResidential(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Query.IsResidential(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the building is identified as residential; otherwise, false\.

<a name='DiGi.GIS.Query.IsUrban(thisDiGi.GIS.Enums.MunicipalityType)'></a>

## Query\.IsUrban\(this MunicipalityType\) Method

Determines whether the specified municipality type is considered urban\.

```csharp
public static bool IsUrban(this DiGi.GIS.Enums.MunicipalityType municipalityType);
```
#### Parameters

<a name='DiGi.GIS.Query.IsUrban(thisDiGi.GIS.Enums.MunicipalityType).municipalityType'></a>

`municipalityType` [MunicipalityType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.MunicipalityType 'DiGi\.GIS\.Enums\.MunicipalityType')

The municipality type to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the municipality type is urban; otherwise, false\.

<a name='DiGi.GIS.Query.LatestPredictedYearBuilt(string,DiGi.GIS.Classes.Building2D)'></a>

## Query\.LatestPredictedYearBuilt\(string, Building2D\) Method

Retrieves the latest predicted year built for a specific building from a specified directory\.

```csharp
public static System.Nullable<short> LatestPredictedYearBuilt(string? directory, DiGi.GIS.Classes.Building2D? builidng2D);
```
#### Parameters

<a name='DiGi.GIS.Query.LatestPredictedYearBuilt(string,DiGi.GIS.Classes.Building2D).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the data\.

<a name='DiGi.GIS.Query.LatestPredictedYearBuilt(string,DiGi.GIS.Classes.Building2D).builidng2D'></a>

`builidng2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object to query\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The latest predicted year built as a short, or null if not found or inputs are invalid\.

<a name='DiGi.GIS.Query.LatestPredictedYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D)'></a>

## Query\.LatestPredictedYearBuilt\(this GISModelFile, Building2D\) Method

Retrieves the latest predicted year built for a specific building from the GIS model file\.

```csharp
public static System.Nullable<short> LatestPredictedYearBuilt(this DiGi.GIS.Classes.GISModelFile? gISModelFile, DiGi.GIS.Classes.Building2D? builidng2D);
```
#### Parameters

<a name='DiGi.GIS.Query.LatestPredictedYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file containing the data\.

<a name='DiGi.GIS.Query.LatestPredictedYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D).builidng2D'></a>

`builidng2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object to query\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The latest predicted year built as a short, or null if not found or inputs are invalid\.

<a name='DiGi.GIS.Query.MunicipalityType(thisDiGi.GIS.Classes.StatisticalUnit)'></a>

## Query\.MunicipalityType\(this StatisticalUnit\) Method

Determines the municipality type based on the provided statistical unit\.

```csharp
public static System.Nullable<DiGi.GIS.Enums.MunicipalityType> MunicipalityType(this DiGi.GIS.Classes.StatisticalUnit statisticalUnit);
```
#### Parameters

<a name='DiGi.GIS.Query.MunicipalityType(thisDiGi.GIS.Classes.StatisticalUnit).statisticalUnit'></a>

`statisticalUnit` [StatisticalUnit](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalUnit 'DiGi\.GIS\.Classes\.StatisticalUnit')

The statistical unit to evaluate\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[MunicipalityType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.MunicipalityType 'DiGi\.GIS\.Enums\.MunicipalityType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The corresponding [MunicipalityType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.MunicipalityType 'DiGi\.GIS\.Enums\.MunicipalityType') if applicable; otherwise, null\.

<a name='DiGi.GIS.Query.MunicipalityType(thisDiGi.GIS.Classes.UnitCode)'></a>

## Query\.MunicipalityType\(this UnitCode\) Method

Determines the municipality type based on the provided unit code\.

```csharp
public static System.Nullable<DiGi.GIS.Enums.MunicipalityType> MunicipalityType(this DiGi.GIS.Classes.UnitCode? unitCode);
```
#### Parameters

<a name='DiGi.GIS.Query.MunicipalityType(thisDiGi.GIS.Classes.UnitCode).unitCode'></a>

`unitCode` [UnitCode](DiGi.GIS.Classes.md#DiGi.GIS.Classes.UnitCode 'DiGi\.GIS\.Classes\.UnitCode')

The unit code to evaluate\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[MunicipalityType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.MunicipalityType 'DiGi\.GIS\.Enums\.MunicipalityType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The corresponding [MunicipalityType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.MunicipalityType 'DiGi\.GIS\.Enums\.MunicipalityType') if applicable; otherwise, null\.

<a name='DiGi.GIS.Query.OrtoDatas(thisDiGi.GIS.Classes.Building2D,string)'></a>

## Query\.OrtoDatas\(this Building2D, string\) Method

Retrieves the orthodata associated with the specified building from the provided directory\.

```csharp
public static DiGi.GIS.Classes.OrtoDatas? OrtoDatas(this DiGi.GIS.Classes.Building2D? building2D, string? directory);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatas(thisDiGi.GIS.Classes.Building2D,string).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building for which to retrieve orthodata\.

<a name='DiGi.GIS.Query.OrtoDatas(thisDiGi.GIS.Classes.Building2D,string).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the orthodata files\.

#### Returns
[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')  
The OrtoDatas object if found; otherwise, null\.

<a name='DiGi.GIS.Query.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,string)'></a>

## Query\.OrtoDatas\(this OrtoRange, string\) Method

Retrieves the orthodata associated with the specified ortho range from the provided directory\.

```csharp
public static DiGi.GIS.Classes.OrtoDatas? OrtoDatas(this DiGi.GIS.Classes.OrtoRange? ortoRange, string? directory);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,string).ortoRange'></a>

`ortoRange` [OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')

The ortho range for which to retrieve orthodata\.

<a name='DiGi.GIS.Query.OrtoDatas(thisDiGi.GIS.Classes.OrtoRange,string).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the orthodata files\.

#### Returns
[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')  
The OrtoDatas object if found; otherwise, null\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## Query\.OrtoDatasDictionary\(string, IEnumerable\<Building2D\>\) Method

Retrieves a dictionary of OrtoDatas for a collection of Building2D objects from files in the specified directory\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,DiGi.GIS.Classes.OrtoDatas>? OrtoDatasDictionary(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the OrtoDatas files\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of Building2D objects used to derive references for lookup\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are GuidReference objects and values are the associated OrtoDatas objects; returns null if inputs are invalid\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.Dictionary_DiGi.Core.Classes.GuidReference,string_)'></a>

## Query\.OrtoDatasDictionary\(string, IEnumerable\<Building2D\>, Dictionary\<GuidReference,string\>\) Method

Retrieves a dictionary of OrtoDatas for a collection of Building2D objects from files in the specified directory, and optionally returns the file paths\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,DiGi.GIS.Classes.OrtoDatas>? OrtoDatasDictionary(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, out System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,string>? pathDictionary);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.Dictionary_DiGi.Core.Classes.GuidReference,string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the OrtoDatas files\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.Dictionary_DiGi.Core.Classes.GuidReference,string_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of Building2D objects used to derive references for lookup\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.Dictionary_DiGi.Core.Classes.GuidReference,string_).pathDictionary'></a>

`pathDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

When this method returns, contains a dictionary mapping GuidReference keys to their corresponding file paths\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are GuidReference objects and values are the associated OrtoDatas objects; returns null if inputs are invalid\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_)'></a>

## Query\.OrtoDatasDictionary\(string, IEnumerable\<OrtoRange\>\) Method

Retrieves a dictionary of OrtoDatas for a collection of OrtoRange objects from files in the specified directory\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,DiGi.GIS.Classes.OrtoDatas>? OrtoDatasDictionary(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoRange>? ortoRanges);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the OrtoDatas files\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoRange_).ortoRanges'></a>

`ortoRanges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoRange](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoRange 'DiGi\.GIS\.Classes\.OrtoRange')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of OrtoRange objects used to derive references for lookup\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are GuidReference objects and values are the associated OrtoDatas objects; returns null if inputs are invalid\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.OrtoDatasDictionary\(string, IEnumerable\<string\>\) Method

Retrieves a dictionary of OrtoDatas based on provided references from files in the specified directory\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.OrtoDatas>? OrtoDatasDictionary(string? directory, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the OrtoDatas files\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings used to identify the required data\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are unique identifiers and values are the associated OrtoDatas objects; returns null if the directory is invalid or references are null\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.Dictionary_string,string_)'></a>

## Query\.OrtoDatasDictionary\(string, IEnumerable\<string\>, Dictionary\<string,string\>\) Method

Retrieves a dictionary of OrtoDatas based on provided references from files in the specified directory, and optionally returns the file paths for each reference\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.OrtoDatas>? OrtoDatasDictionary(string? directory, System.Collections.Generic.IEnumerable<string>? references, out System.Collections.Generic.Dictionary<string,string>? pathDictionary);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.Dictionary_string,string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the OrtoDatas files\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.Dictionary_string,string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings used to identify the required data\.

<a name='DiGi.GIS.Query.OrtoDatasDictionary(string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.Dictionary_string,string_).pathDictionary'></a>

`pathDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

When this method returns, contains a dictionary mapping unique identifiers to their corresponding file paths\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatas](DiGi.GIS.Classes.md#DiGi.GIS.Classes.OrtoDatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are unique identifiers and values are the associated OrtoDatas objects; returns null if the directory is invalid or references are null\.

<a name='DiGi.GIS.Query.OrtoDatasDirectoryNames_Building2D()'></a>

## Query\.OrtoDatasDirectoryNames\_Building2D\(\) Method

Gets the directory names associated with Building 2D data\.

```csharp
public static string[] OrtoDatasDirectoryNames_Building2D();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of strings containing the directory names for Orto Data and Building 2D\.

<a name='DiGi.GIS.Query.OrtoDatasDirectoryNames_OrtoRange()'></a>

## Query\.OrtoDatasDirectoryNames\_OrtoRange\(\) Method

Gets the directory names associated with Orto Range data\.

```csharp
public static string[] OrtoDatasDirectoryNames_OrtoRange();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of strings containing the directory names for Orto Data and Orto Range\.

<a name='DiGi.GIS.Query.OrtoDatasDirectory_Building2D(string,bool)'></a>

## Query\.OrtoDatasDirectory\_Building2D\(string, bool\) Method

Retrieves the path to the Building 2D Orto data directory\.

```csharp
public static string? OrtoDatasDirectory_Building2D(string? directory, bool checkIfExists=false);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDirectory_Building2D(string,bool).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory path\.

<a name='DiGi.GIS.Query.OrtoDatasDirectory_Building2D(string,bool).checkIfExists'></a>

`checkIfExists` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to check if the directory exists\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full path to the Building 2D Orto data directory, or null if not found\.

<a name='DiGi.GIS.Query.OrtoDatasDirectory_OrtoRange(string,bool)'></a>

## Query\.OrtoDatasDirectory\_OrtoRange\(string, bool\) Method

Retrieves the path to the Orto Range Orto data directory\.

```csharp
public static string? OrtoDatasDirectory_OrtoRange(string? directory, bool checkIfExists=false);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDatasDirectory_OrtoRange(string,bool).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory path\.

<a name='DiGi.GIS.Query.OrtoDatasDirectory_OrtoRange(string,bool).checkIfExists'></a>

`checkIfExists` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to check if the directory exists\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full path to the Orto Range Orto data directory, or null if not found\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,double)'></a>

## Query\.OrtoDataUrl\(this BoundingBox2D, int, double\) Method

Generates a URL for orthophoto data based on a bounding box, year, and scale factor\.

```csharp
public static string? OrtoDataUrl(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int year, double scale);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box defining the geographic area\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The year of the orthophoto data to retrieve\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale used to calculate the pixel dimensions of the image\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the constructed URL, or null if the bounding box is null\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,int)'></a>

## Query\.OrtoDataUrl\(this BoundingBox2D, int, int, int\) Method

Generates a URL for orthophoto data based on a bounding box, year, and specific pixel dimensions\.

```csharp
public static string? OrtoDataUrl(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int year, int width, int height);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,int).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box defining the geographic area\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,int).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The year of the orthophoto data to retrieve\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,int).width'></a>

`width` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The width of the requested image in pixels\.

<a name='DiGi.GIS.Query.OrtoDataUrl(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,int).height'></a>

`height` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The height of the requested image in pixels\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the constructed URL, or null if the bounding box is null\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double)'></a>

## Query\.OrtoDataUrlDictionary\(this BoundingBox2D, IEnumerable\<int\>, double\) Method

Generates a dictionary of orthodata URLs for the specified bounding box and years based on a given scale\.

```csharp
public static System.Collections.Generic.Dictionary<int,string>? OrtoDataUrlDictionary(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<int>? years, double scale);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box area to query\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of years for which to retrieve data URLs\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_int_,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor used to calculate image dimensions\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping years to their corresponding orthodata URLs, or null if the input is invalid or the area is too small\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool)'></a>

## Query\.OrtoDataUrlDictionary\(this Building2D, IEnumerable\<int\>, double, double, bool\) Method

Generates a dictionary of orthodata URLs for the specified building across multiple years\.

```csharp
public static System.Collections.Generic.Dictionary<int,string>? OrtoDataUrlDictionary(this DiGi.GIS.Classes.Building2D? building2D, System.Collections.Generic.IEnumerable<int>? years, double offset=5.0, double width=320.0, bool squared=false);
```
#### Parameters

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).building2D'></a>

`building2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The building object to query\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of years for which to retrieve data URLs\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset distance to expand the bounding box around the building\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The desired width used to calculate the scale\.

<a name='DiGi.GIS.Query.OrtoDataUrlDictionary(thisDiGi.GIS.Classes.Building2D,System.Collections.Generic.IEnumerable_int_,double,double,bool).squared'></a>

`squared` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to force the resulting bounding box to be square\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping years to their corresponding orthodata URLs, or null if the building or years are null\.

<a name='DiGi.GIS.Query.Reference(thisDiGi.BDOT10k.Classes.OT_ADJA_A)'></a>

## Query\.Reference\(this OT\_ADJA\_A\) Method

Retrieves a reference identifier for the specified OT\_ADJA\_A object\.

```csharp
public static string? Reference(this DiGi.BDOT10k.Classes.OT_ADJA_A? oT_ADJA_A);
```
#### Parameters

<a name='DiGi.GIS.Query.Reference(thisDiGi.BDOT10k.Classes.OT_ADJA_A).oT_ADJA_A'></a>

`oT_ADJA_A` [DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adja_a 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')

The OT\_ADJA\_A object to retrieve the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the reference identifier, or null if no valid reference could be determined\.

<a name='DiGi.GIS.Query.Reference(thisDiGi.BDOT10k.Classes.OT_ADMS_A)'></a>

## Query\.Reference\(this OT\_ADMS\_A\) Method

Retrieves a reference identifier for the specified OT\_ADMS\_A object\.

```csharp
public static string? Reference(this DiGi.BDOT10k.Classes.OT_ADMS_A? oT_ADMS_A);
```
#### Parameters

<a name='DiGi.GIS.Query.Reference(thisDiGi.BDOT10k.Classes.OT_ADMS_A).oT_ADMS_A'></a>

`oT_ADMS_A` [DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adms_a 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')

The OT\_ADMS\_A object to retrieve the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the reference identifier, or null if no valid reference could be determined\.

<a name='DiGi.GIS.Query.Reference(thisDiGi.BDOT10k.Classes.OT_BUBD_A)'></a>

## Query\.Reference\(this OT\_BUBD\_A\) Method

Retrieves a reference identifier for the specified OT\_BUBD\_A object\.

```csharp
public static string? Reference(this DiGi.BDOT10k.Classes.OT_BUBD_A? oT_BUBD_A);
```
#### Parameters

<a name='DiGi.GIS.Query.Reference(thisDiGi.BDOT10k.Classes.OT_BUBD_A).oT_BUBD_A'></a>

`oT_BUBD_A` [DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_bubd_a 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')

The OT\_BUBD\_A object to retrieve the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the reference identifier, or null if no valid reference could be determined\.

<a name='DiGi.GIS.Query.Reference(thisDiGi.GML.Classes.Geometry)'></a>

## Query\.Reference\(this Geometry\) Method

Retrieves a reference identifier for the specified geometry object\.

```csharp
public static string? Reference(this DiGi.GML.Classes.Geometry? geometry);
```
#### Parameters

<a name='DiGi.GIS.Query.Reference(thisDiGi.GML.Classes.Geometry).geometry'></a>

`geometry` [DiGi\.GML\.Classes\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.geometry 'DiGi\.GML\.Classes\.Geometry')

The geometry object to retrieve the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the reference identifier, or null if no valid reference could be determined\.

<a name='DiGi.GIS.Query.Reference(thisDiGi.GML.Classes.LinearRing)'></a>

## Query\.Reference\(this LinearRing\) Method

Retrieves a reference identifier for the specified linear ring\.

```csharp
public static string? Reference(this DiGi.GML.Classes.LinearRing? linearRing);
```
#### Parameters

<a name='DiGi.GIS.Query.Reference(thisDiGi.GML.Classes.LinearRing).linearRing'></a>

`linearRing` [DiGi\.GML\.Classes\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.linearring 'DiGi\.GML\.Classes\.LinearRing')

The linear ring object to retrieve the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the reference identifier, or null if no valid reference could be determined\.

<a name='DiGi.GIS.Query.Reference(thisDiGi.GML.Classes.Polygon)'></a>

## Query\.Reference\(this Polygon\) Method

Retrieves a reference identifier for the specified polygon\.

```csharp
public static string? Reference(this DiGi.GML.Classes.Polygon? polygon);
```
#### Parameters

<a name='DiGi.GIS.Query.Reference(thisDiGi.GML.Classes.Polygon).polygon'></a>

`polygon` [DiGi\.GML\.Classes\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.polygon 'DiGi\.GML\.Classes\.Polygon')

The polygon object to retrieve the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the reference identifier, or null if no valid reference could be determined\.

<a name='DiGi.GIS.Query.SettlementType(thisDiGi.GIS.Classes.AdministrativeSubdivision)'></a>

## Query\.SettlementType\(this AdministrativeSubdivision\) Method

Maps an administrative subdivision object to a settlement type based on its type property\.

```csharp
public static DiGi.GIS.Enums.SettlementType SettlementType(this DiGi.GIS.Classes.AdministrativeSubdivision administrativeSubdivision);
```
#### Parameters

<a name='DiGi.GIS.Query.SettlementType(thisDiGi.GIS.Classes.AdministrativeSubdivision).administrativeSubdivision'></a>

`administrativeSubdivision` [AdministrativeSubdivision](DiGi.GIS.Classes.md#DiGi.GIS.Classes.AdministrativeSubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The administrative subdivision instance\.

#### Returns
[SettlementType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.SettlementType 'DiGi\.GIS\.Enums\.SettlementType')  
The corresponding [SettlementType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.SettlementType 'DiGi\.GIS\.Enums\.SettlementType')\.

<a name='DiGi.GIS.Query.SettlementType(thisDiGi.GIS.Enums.AdministrativeSubdivisionType)'></a>

## Query\.SettlementType\(this AdministrativeSubdivisionType\) Method

Maps an administrative subdivision type to a settlement type\.

```csharp
public static DiGi.GIS.Enums.SettlementType SettlementType(this DiGi.GIS.Enums.AdministrativeSubdivisionType administrativeSubdivisionType);
```
#### Parameters

<a name='DiGi.GIS.Query.SettlementType(thisDiGi.GIS.Enums.AdministrativeSubdivisionType).administrativeSubdivisionType'></a>

`administrativeSubdivisionType` [AdministrativeSubdivisionType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.AdministrativeSubdivisionType 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')

The administrative subdivision type to convert\.

#### Returns
[SettlementType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.SettlementType 'DiGi\.GIS\.Enums\.SettlementType')  
The corresponding [SettlementType](DiGi.GIS.Enums.md#DiGi.GIS.Enums.SettlementType 'DiGi\.GIS\.Enums\.SettlementType')\.

<a name='DiGi.GIS.Query.Size(byte[])'></a>

## Query\.Size\(byte\[\]\) Method

Determines the dimensions of an image from its byte array representation, supporting PNG and JPEG formats\.

```csharp
public static DiGi.Core.Classes.Size? Size(byte[]? bytes);
```
#### Parameters

<a name='DiGi.GIS.Query.Size(byte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array containing the raw image data\.

#### Returns
[DiGi\.Core\.Classes\.Size](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.size 'DiGi\.Core\.Classes\.Size')  
A [Size\(byte\[\]\)](DiGi.GIS.md#DiGi.GIS.Query.Size(byte[]) 'DiGi\.GIS\.Query\.Size\(byte\[\]\)') object containing the width and height if the format is supported and valid; otherwise, `null`\.

<a name='DiGi.GIS.Query.StatisticalData_TStatisticalData_(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable)'></a>

## Query\.StatisticalData\<TStatisticalData\>\(this StatisticalDataCollection, Variable\) Method

Retrieves a specific statistical data item from the collection based on the provided variable\.

```csharp
public static TStatisticalData? StatisticalData<TStatisticalData>(this DiGi.GIS.Classes.StatisticalDataCollection? statisticalDataCollection, DiGi.BDL.Enums.Variable variable)
    where TStatisticalData : DiGi.GIS.Interfaces.IStatisticalData;
```
#### Type parameters

<a name='DiGi.GIS.Query.StatisticalData_TStatisticalData_(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).TStatisticalData'></a>

`TStatisticalData`

The type of statistical data to retrieve, which must implement [IStatisticalData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IStatisticalData 'DiGi\.GIS\.Interfaces\.IStatisticalData')\.
#### Parameters

<a name='DiGi.GIS.Query.StatisticalData_TStatisticalData_(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).statisticalDataCollection'></a>

`statisticalDataCollection` [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')

The collection of statistical data to search within\.

<a name='DiGi.GIS.Query.StatisticalData_TStatisticalData_(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).variable'></a>

`variable` [DiGi\.BDL\.Enums\.Variable](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.enums.variable 'DiGi\.BDL\.Enums\.Variable')

The variable used as a reference key to find the specific statistical data item\.

#### Returns
[TStatisticalData](DiGi.GIS.md#DiGi.GIS.Query.StatisticalData_TStatisticalData_(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).TStatisticalData 'DiGi\.GIS\.Query\.StatisticalData\<TStatisticalData\>\(this DiGi\.GIS\.Classes\.StatisticalDataCollection, DiGi\.BDL\.Enums\.Variable\)\.TStatisticalData')  
The found statistical data item of type [TStatisticalData](DiGi.GIS.md#DiGi.GIS.Query.StatisticalData_TStatisticalData_(thisDiGi.GIS.Classes.StatisticalDataCollection,DiGi.BDL.Enums.Variable).TStatisticalData 'DiGi\.GIS\.Query\.StatisticalData\<TStatisticalData\>\(this DiGi\.GIS\.Classes\.StatisticalDataCollection, DiGi\.BDL\.Enums\.Variable\)\.TStatisticalData'), or default if not found or if the collection is null\.

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(DiGi.GIS.Classes.StatisticalDataCollectionFile,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.StatisticalDataCollectionDictionary\(StatisticalDataCollectionFile, IEnumerable\<string\>\) Method

Creates a dictionary of statistical data collections based on the provided file and a collection of references\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.StatisticalDataCollection>? StatisticalDataCollectionDictionary(DiGi.GIS.Classes.StatisticalDataCollectionFile? statisticalDataCollectionFile, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(DiGi.GIS.Classes.StatisticalDataCollectionFile,System.Collections.Generic.IEnumerable_string_).statisticalDataCollectionFile'></a>

`statisticalDataCollectionFile` [StatisticalDataCollectionFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollectionFile 'DiGi\.GIS\.Classes\.StatisticalDataCollectionFile')

The statistical data collection file to retrieve data from\.

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(DiGi.GIS.Classes.StatisticalDataCollectionFile,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of string references used to look up the statistical data\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping reference strings to their corresponding [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection'), or null if inputs are invalid\.

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## Query\.StatisticalDataCollectionDictionary\(string, IEnumerable\<Building2D\>\) Method

Creates a dictionary of statistical data collections mapped to [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') objects derived from the provided building entities\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,DiGi.GIS.Classes.StatisticalDataCollection>? StatisticalDataCollectionDictionary(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds);
```
#### Parameters

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing statistical data collection files\.

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D') objects used to generate references for lookup\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') to their corresponding [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection'), or null if the directory is invalid or building list is null\.

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(string,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.StatisticalDataCollectionDictionary\(string, IEnumerable\<string\>\) Method

Creates a dictionary of statistical data collections by searching for relevant files within a specified directory using the provided references\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Classes.StatisticalDataCollection>? StatisticalDataCollectionDictionary(string? directory, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing statistical data collection files\.

<a name='DiGi.GIS.Query.StatisticalDataCollectionDictionary(string,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of string references used to look up the statistical data\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping reference strings to their corresponding [StatisticalDataCollection](DiGi.GIS.Classes.md#DiGi.GIS.Classes.StatisticalDataCollection 'DiGi\.GIS\.Classes\.StatisticalDataCollection'), or null if the directory is invalid or references are null\.

<a name='DiGi.GIS.Query.UserYearBuilt(string,DiGi.GIS.Classes.Building2D)'></a>

## Query\.UserYearBuilt\(string, Building2D\) Method

Retrieves the user\-defined year built for the specified building using the provided directory path\.

```csharp
public static System.Nullable<short> UserYearBuilt(string? directory, DiGi.GIS.Classes.Building2D? builidng2D);
```
#### Parameters

<a name='DiGi.GIS.Query.UserYearBuilt(string,DiGi.GIS.Classes.Building2D).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory path where the data is located\.

<a name='DiGi.GIS.Query.UserYearBuilt(string,DiGi.GIS.Classes.Building2D).builidng2D'></a>

`builidng2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object to retrieve the year built for\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The user\-defined year built if found; otherwise, null\.

<a name='DiGi.GIS.Query.UserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D)'></a>

## Query\.UserYearBuilt\(this GISModelFile, Building2D\) Method

Retrieves the user\-defined year built for the specified building using the provided GIS model file\.

```csharp
public static System.Nullable<short> UserYearBuilt(this DiGi.GIS.Classes.GISModelFile? gISModelFile, DiGi.GIS.Classes.Building2D? builidng2D);
```
#### Parameters

<a name='DiGi.GIS.Query.UserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file containing the data\.

<a name='DiGi.GIS.Query.UserYearBuilt(thisDiGi.GIS.Classes.GISModelFile,DiGi.GIS.Classes.Building2D).builidng2D'></a>

`builidng2D` [Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object to retrieve the year built for\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The user\-defined year built if found; otherwise, null\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(GISModelFile, IEnumerable\<string\>\) Method

Retrieves a dictionary of year built data associated with the provided references, based on the GIS model file's location\.

```csharp
public static System.Collections.Generic.Dictionary<string,TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(DiGi.GIS.Classes.GISModelFile? gISModelFile, System.Collections.Generic.IEnumerable<string>? references)
    where TYearBuiltData : DiGi.GIS.Interfaces.IYearBuiltData;
```
#### Type parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_).TYearBuiltData'></a>

`TYearBuiltData`

The type of year built data, which must implement [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')\.
#### Parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_).gISModelFile'></a>

`gISModelFile` [GISModelFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.GISModelFile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file used to determine the path for the year built data file\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings to look up\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TYearBuiltData](DiGi.GIS.md#DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.GISModelFile,System.Collections.Generic.IEnumerable_string_).TYearBuiltData 'DiGi\.GIS\.Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(DiGi\.GIS\.Classes\.GISModelFile, System\.Collections\.Generic\.IEnumerable\<string\>\)\.TYearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping references to their corresponding year built data, or null if inputs are invalid or the associated data file is missing\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.YearBuiltDataFile,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(YearBuiltDataFile, IEnumerable\<string\>\) Method

Retrieves a dictionary of year built data from a specific year built data file for the provided references\.

```csharp
public static System.Collections.Generic.Dictionary<string,TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(DiGi.GIS.Classes.YearBuiltDataFile? yearBuiltDataFile, System.Collections.Generic.IEnumerable<string>? references)
    where TYearBuiltData : DiGi.GIS.Interfaces.IYearBuiltData;
```
#### Type parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.YearBuiltDataFile,System.Collections.Generic.IEnumerable_string_).TYearBuiltData'></a>

`TYearBuiltData`

The type of year built data, which must implement [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')\.
#### Parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.YearBuiltDataFile,System.Collections.Generic.IEnumerable_string_).yearBuiltDataFile'></a>

`yearBuiltDataFile` [YearBuiltDataFile](DiGi.GIS.Classes.md#DiGi.GIS.Classes.YearBuiltDataFile 'DiGi\.GIS\.Classes\.YearBuiltDataFile')

The year built data file to query\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.YearBuiltDataFile,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings to look up\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TYearBuiltData](DiGi.GIS.md#DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(DiGi.GIS.Classes.YearBuiltDataFile,System.Collections.Generic.IEnumerable_string_).TYearBuiltData 'DiGi\.GIS\.Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(DiGi\.GIS\.Classes\.YearBuiltDataFile, System\.Collections\.Generic\.IEnumerable\<string\>\)\.TYearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping references to their corresponding year built data, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(string, IEnumerable\<Building2D\>\) Method

Retrieves a dictionary of year built data keyed by GuidReference for the provided collection of Building2D objects within the specified directory\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds)
    where TYearBuiltData : DiGi.GIS.Interfaces.IYearBuiltData;
```
#### Type parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).TYearBuiltData'></a>

`TYearBuiltData`

The type of year built data, which must implement [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')\.
#### Parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory where YearBuiltDataFile \(\*\.ybdf\) files are located\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building2D](DiGi.GIS.Classes.md#DiGi.GIS.Classes.Building2D 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of Building2D objects to retrieve data for\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TYearBuiltData](DiGi.GIS.md#DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).TYearBuiltData 'DiGi\.GIS\.Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(string, System\.Collections\.Generic\.IEnumerable\<DiGi\.GIS\.Classes\.Building2D\>\)\.TYearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping GuidReferences to their corresponding year built data, or null if inputs are invalid\.

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(string, IEnumerable\<string\>\) Method

Retrieves a dictionary of year built data by searching all compatible files within the specified directory for the provided references\.

```csharp
public static System.Collections.Generic.Dictionary<string,TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(string? directory, System.Collections.Generic.IEnumerable<string>? references)
    where TYearBuiltData : DiGi.GIS.Interfaces.IYearBuiltData;
```
#### Type parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_string_).TYearBuiltData'></a>

`TYearBuiltData`

The type of year built data, which must implement [IYearBuiltData](DiGi.GIS.Interfaces.md#DiGi.GIS.Interfaces.IYearBuiltData 'DiGi\.GIS\.Interfaces\.IYearBuiltData')\.
#### Parameters

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Directory where YearBuiltDataFile \(\*\.ybdf\) is located

<a name='DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Building2D references

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TYearBuiltData](DiGi.GIS.md#DiGi.GIS.Query.YearBuiltDataDictionary_TYearBuiltData_(string,System.Collections.Generic.IEnumerable_string_).TYearBuiltData 'DiGi\.GIS\.Query\.YearBuiltDataDictionary\<TYearBuiltData\>\(string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.TYearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping references to their corresponding year built data, or null if the directory is invalid or references are null\.