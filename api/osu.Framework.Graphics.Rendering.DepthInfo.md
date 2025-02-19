# <a id="osu_Framework_Graphics_Rendering_DepthInfo"></a> Struct DepthInfo

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

Information for how depth should be handled.

```csharp
public readonly struct DepthInfo : IEquatable<DepthInfo>
```

#### Implements

[IEquatable<DepthInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DepthInfo\>\(DepthInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DepthInfo\>\(DepthInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DepthInfo\>\(DepthInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DepthInfo\>\(DepthInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DepthInfo, TChild\>\(DepthInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DepthInfo, TChild\>\(DepthInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DepthInfo, TChild\>\(DepthInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DepthInfo\>\(DepthInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_DepthInfo__ctor_System_Boolean_System_Boolean_osu_Framework_Graphics_Rendering_BufferTestFunction_"></a> DepthInfo\(bool, bool, BufferTestFunction\)

```csharp
public DepthInfo(bool depthTest = true, bool writeDepth = true, BufferTestFunction function = BufferTestFunction.LessThan)
```

#### Parameters

`depthTest` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`writeDepth` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`function` [BufferTestFunction](osu.Framework.Graphics.Rendering.BufferTestFunction.md)

## Fields

### <a id="osu_Framework_Graphics_Rendering_DepthInfo_DepthTest"></a> DepthTest

Whether depth testing should occur.

```csharp
public readonly bool DepthTest
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_DepthInfo_Function"></a> Function

The depth test function.

```csharp
public readonly BufferTestFunction Function
```

#### Field Value

 [BufferTestFunction](osu.Framework.Graphics.Rendering.BufferTestFunction.md)

### <a id="osu_Framework_Graphics_Rendering_DepthInfo_WriteDepth"></a> WriteDepth

Whether to write to the depth buffer if the depth test passed.

```csharp
public readonly bool WriteDepth
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Graphics_Rendering_DepthInfo_Default"></a> Default

The default depth properties, as defined by OpenGL.

```csharp
public static DepthInfo Default { get; }
```

#### Property Value

 [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

## Methods

### <a id="osu_Framework_Graphics_Rendering_DepthInfo_Equals_osu_Framework_Graphics_Rendering_DepthInfo_"></a> Equals\(DepthInfo\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(DepthInfo other)
```

#### Parameters

`other` [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

