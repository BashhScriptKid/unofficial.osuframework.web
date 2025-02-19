# <a id="osu_Framework_Graphics_Containers_Dimension"></a> Class Dimension

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Defines the size of a row or column in a <xref href="osu.Framework.Graphics.Containers.GridContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public class Dimension
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Dimension](osu.Framework.Graphics.Containers.Dimension.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Dimension\>\(Dimension?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Dimension\>\(Dimension\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Dimension\>\(Dimension\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Dimension\>\(Dimension\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Dimension, TChild\>\(Dimension, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Dimension, TChild\>\(Dimension, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Dimension, TChild\>\(Dimension, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Dimension\>\(Dimension\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_Dimension__ctor_osu_Framework_Graphics_Containers_GridSizeMode_System_Single_System_Single_System_Single_"></a> Dimension\(GridSizeMode, float, float, float\)

Constructs a new <xref href="osu.Framework.Graphics.Containers.Dimension" data-throw-if-not-resolved="false"></xref>.

```csharp
public Dimension(GridSizeMode mode = GridSizeMode.Distributed, float size = 0, float minSize = 0, float maxSize = 3.4028235E+38)
```

#### Parameters

`mode` [GridSizeMode](osu.Framework.Graphics.Containers.GridSizeMode.md)

The sizing mode to use.

`size` [float](https://learn.microsoft.com/dotnet/api/system.single)

The size of this row or column. This only has an effect if <code class="paramref">mode</code> is not <xref href="osu.Framework.Graphics.Containers.GridSizeMode.Distributed" data-throw-if-not-resolved="false"></xref>.

`minSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

The minimum size of this row or column.

`maxSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

The maximum size of this row or column.

## Fields

### <a id="osu_Framework_Graphics_Containers_Dimension_MaxSize"></a> MaxSize

The maximum size of the row or column which this <xref href="osu.Framework.Graphics.Containers.Dimension" data-throw-if-not-resolved="false"></xref> applies to.

```csharp
public readonly float MaxSize
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_Dimension_MinSize"></a> MinSize

The minimum size of the row or column which this <xref href="osu.Framework.Graphics.Containers.Dimension" data-throw-if-not-resolved="false"></xref> applies to.

```csharp
public readonly float MinSize
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_Dimension_Mode"></a> Mode

The mode in which this row or column <xref href="osu.Framework.Graphics.Containers.GridContainer" data-throw-if-not-resolved="false"></xref> is sized.

```csharp
public readonly GridSizeMode Mode
```

#### Field Value

 [GridSizeMode](osu.Framework.Graphics.Containers.GridSizeMode.md)

### <a id="osu_Framework_Graphics_Containers_Dimension_Size"></a> Size

The size of the row or column which this <xref href="osu.Framework.Graphics.Containers.Dimension" data-throw-if-not-resolved="false"></xref> applies to.
Only has an effect if <xref href="osu.Framework.Graphics.Containers.Dimension.Mode" data-throw-if-not-resolved="false"></xref> is not <xref href="osu.Framework.Graphics.Containers.GridSizeMode.Distributed" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly float Size
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

