# <a id="osu_Framework_Graphics_Rendering_StencilInfo"></a> Struct StencilInfo

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly struct StencilInfo : IEquatable<StencilInfo>
```

#### Implements

[IEquatable<StencilInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<StencilInfo\>\(StencilInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<StencilInfo\>\(StencilInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<StencilInfo\>\(StencilInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<StencilInfo\>\(StencilInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<StencilInfo, TChild\>\(StencilInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<StencilInfo, TChild\>\(StencilInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<StencilInfo, TChild\>\(StencilInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<StencilInfo\>\(StencilInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_StencilInfo__ctor_System_Boolean_osu_Framework_Graphics_Rendering_BufferTestFunction_System_Int32_System_Int32_osu_Framework_Graphics_Rendering_StencilOperation_osu_Framework_Graphics_Rendering_StencilOperation_osu_Framework_Graphics_Rendering_StencilOperation_"></a> StencilInfo\(bool, BufferTestFunction, int, int, StencilOperation, StencilOperation, StencilOperation\)

```csharp
public StencilInfo(bool stencilTest = true, BufferTestFunction testFunction = BufferTestFunction.Always, int testValue = 1, int mask = 255, StencilOperation stencilFailed = StencilOperation.Keep, StencilOperation depthFailed = StencilOperation.Keep, StencilOperation passed = StencilOperation.Replace)
```

#### Parameters

`stencilTest` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`testFunction` [BufferTestFunction](osu.Framework.Graphics.Rendering.BufferTestFunction.md)

`testValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`mask` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stencilFailed` [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

`depthFailed` [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

`passed` [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

## Fields

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_DepthTestFailOperation"></a> DepthTestFailOperation

The operation to perform on the stencil buffer when the depth test fails.

```csharp
public readonly StencilOperation DepthTestFailOperation
```

#### Field Value

 [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_Mask"></a> Mask

The stencil mask.

```csharp
public readonly int Mask
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_StencilTest"></a> StencilTest

Whether stencil testing should occur.
If this is false, no <xref href="osu.Framework.Graphics.Rendering.StencilOperation" data-throw-if-not-resolved="false"></xref> will occur (use <xref href="osu.Framework.Graphics.Rendering.BufferTestFunction.Always" data-throw-if-not-resolved="false"></xref> instead).

```csharp
public readonly bool StencilTest
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_StencilTestFailOperation"></a> StencilTestFailOperation

The operation to perform on the stencil buffer when the stencil test fails.

```csharp
public readonly StencilOperation StencilTestFailOperation
```

#### Field Value

 [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_TestFunction"></a> TestFunction

The stencil test function.

```csharp
public readonly BufferTestFunction TestFunction
```

#### Field Value

 [BufferTestFunction](osu.Framework.Graphics.Rendering.BufferTestFunction.md)

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_TestPassedOperation"></a> TestPassedOperation

The operation to perform on the stencil buffer when both the stencil and depth tests pass.

```csharp
public readonly StencilOperation TestPassedOperation
```

#### Field Value

 [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_TestValue"></a> TestValue

The stencil test value to compare against.

```csharp
public readonly int TestValue
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_Default"></a> Default

The default stencil properties.

```csharp
public static StencilInfo Default { get; }
```

#### Property Value

 [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

## Methods

### <a id="osu_Framework_Graphics_Rendering_StencilInfo_Equals_osu_Framework_Graphics_Rendering_StencilInfo_"></a> Equals\(StencilInfo\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(StencilInfo other)
```

#### Parameters

`other` [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

