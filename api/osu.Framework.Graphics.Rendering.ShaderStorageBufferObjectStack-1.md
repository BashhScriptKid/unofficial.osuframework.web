# <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1"></a> Class ShaderStorageBufferObjectStack<TData\>

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

A wrapper around <xref href="osu.Framework.Graphics.Rendering.IShaderStorageBufferObject%601" data-throw-if-not-resolved="false"></xref> providing push/pop semantics for writing
an arbitrary amount of data to an unbounded set of shader storage buffer objects.

```csharp
public class ShaderStorageBufferObjectStack<TData> : IDisposable where TData : unmanaged, IEquatable<TData>
```

#### Type Parameters

`TData` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ShaderStorageBufferObjectStack<TData\>](osu.Framework.Graphics.Rendering.ShaderStorageBufferObjectStack\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ShaderStorageBufferObjectStack<TData\>\>\(ShaderStorageBufferObjectStack<TData\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ShaderStorageBufferObjectStack<TData\>\>\(ShaderStorageBufferObjectStack<TData\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ShaderStorageBufferObjectStack<TData\>\>\(ShaderStorageBufferObjectStack<TData\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ShaderStorageBufferObjectStack<TData\>\>\(ShaderStorageBufferObjectStack<TData\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ShaderStorageBufferObjectStack<TData\>, TChild\>\(ShaderStorageBufferObjectStack<TData\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ShaderStorageBufferObjectStack<TData\>, TChild\>\(ShaderStorageBufferObjectStack<TData\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ShaderStorageBufferObjectStack<TData\>, TChild\>\(ShaderStorageBufferObjectStack<TData\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ShaderStorageBufferObjectStack<TData\>\>\(ShaderStorageBufferObjectStack<TData\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_Int32_System_Int32_"></a> ShaderStorageBufferObjectStack\(IRenderer, int, int\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.ShaderStorageBufferObjectStack%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public ShaderStorageBufferObjectStack(IRenderer renderer, int uboSize, int ssboSize)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref>.

`uboSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Must be at least 2. See <xref href="osu.Framework.Graphics.Rendering.IRenderer.CreateShaderStorageBufferObject%60%601(System.Int32%2cSystem.Int32)" data-throw-if-not-resolved="false"></xref>

`ssboSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Must be at least 2. See <xref href="osu.Framework.Graphics.Rendering.IRenderer.CreateShaderStorageBufferObject%60%601(System.Int32%2cSystem.Int32)" data-throw-if-not-resolved="false"></xref>

## Properties

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1_CurrentBuffer"></a> CurrentBuffer

The buffer that contains the current object.

```csharp
public IShaderStorageBufferObject<TData> CurrentBuffer { get; }
```

#### Property Value

 [IShaderStorageBufferObject](osu.Framework.Graphics.Rendering.IShaderStorageBufferObject\-1.md)<TData\>

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1_CurrentOffset"></a> CurrentOffset

The index of the current item inside <xref href="osu.Framework.Graphics.Rendering.ShaderStorageBufferObjectStack%601.CurrentBuffer" data-throw-if-not-resolved="false"></xref>.

```csharp
public int CurrentOffset { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1_Clear"></a> Clear\(\)

Clears the stack. This should be called at the start of every frame to prevent runaway VRAM usage.

```csharp
public void Clear()
```

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1_Pop"></a> Pop\(\)

Pops the last item from the stack.

```csharp
public void Pop()
```

#### Remarks

This does not remove the item from the stack or the underlying buffer,
but adjusts <xref href="osu.Framework.Graphics.Rendering.ShaderStorageBufferObjectStack%601.CurrentOffset" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Rendering.ShaderStorageBufferObjectStack%601.CurrentBuffer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_ShaderStorageBufferObjectStack_1_Push__0_"></a> Push\(TData\)

Pushes a new item to this stack.

```csharp
public int Push(TData item)
```

#### Parameters

`item` TData

The item.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index inside the resulting buffer at which the item is located.

