# <a id="osu_Framework_Graphics_Containers_TableColumn"></a> Class TableColumn

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Defines a column of the <xref href="osu.Framework.Graphics.Containers.TableContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public class TableColumn
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TableColumn](osu.Framework.Graphics.Containers.TableColumn.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TableColumn\>\(TableColumn?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TableColumn\>\(TableColumn\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TableColumn\>\(TableColumn\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TableColumn\>\(TableColumn\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TableColumn, TChild\>\(TableColumn, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TableColumn, TChild\>\(TableColumn, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TableColumn, TChild\>\(TableColumn, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TableColumn\>\(TableColumn\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_TableColumn__ctor_System_Nullable_osu_Framework_Localisation_LocalisableString__osu_Framework_Graphics_Anchor_osu_Framework_Graphics_Containers_Dimension_"></a> TableColumn\(LocalisableString?, Anchor, Dimension\)

Constructs a new <xref href="osu.Framework.Graphics.Containers.TableColumn" data-throw-if-not-resolved="false"></xref>.

```csharp
public TableColumn(LocalisableString? header = null, Anchor anchor = Anchor.TopLeft, Dimension dimension = null)
```

#### Parameters

`header` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)?

The localisable text to be displayed in the cell.

`anchor` [Anchor](osu.Framework.Graphics.Anchor.md)

The anchor of all cells in this column of the <xref href="osu.Framework.Graphics.Containers.TableContainer" data-throw-if-not-resolved="false"></xref>.

`dimension` [Dimension](osu.Framework.Graphics.Containers.Dimension.md)

The dimension of the column in the table.

## Fields

### <a id="osu_Framework_Graphics_Containers_TableColumn_Anchor"></a> Anchor

The anchor of all cells in this column of the <xref href="osu.Framework.Graphics.Containers.TableContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly Anchor Anchor
```

#### Field Value

 [Anchor](osu.Framework.Graphics.Anchor.md)

### <a id="osu_Framework_Graphics_Containers_TableColumn_Dimension"></a> Dimension

The dimension of the column in the table.

```csharp
public readonly Dimension Dimension
```

#### Field Value

 [Dimension](osu.Framework.Graphics.Containers.Dimension.md)

### <a id="osu_Framework_Graphics_Containers_TableColumn_Header"></a> Header

The localisable text to be displayed in the cell.

```csharp
public readonly LocalisableString Header
```

#### Field Value

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

