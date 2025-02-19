# <a id="osu_Framework_Graphics_Rendering_IShaderStorageBufferObject_1"></a> Interface IShaderStorageBufferObject<TData\>

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

A buffer which stores an array of data for use in a shader.

```csharp
public interface IShaderStorageBufferObject<TData> : IUniformBuffer, IDisposable where TData : unmanaged, IEquatable<TData>
```

#### Type Parameters

`TData` 

The type of data contained.

#### Implements

[IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IShaderStorageBufferObject<TData\>\>\(IShaderStorageBufferObject<TData\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IShaderStorageBufferObject<TData\>\>\(IShaderStorageBufferObject<TData\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IShaderStorageBufferObject<TData\>\>\(IShaderStorageBufferObject<TData\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IShaderStorageBufferObject<TData\>\>\(IShaderStorageBufferObject<TData\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IShaderStorageBufferObject<TData\>, TChild\>\(IShaderStorageBufferObject<TData\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IShaderStorageBufferObject<TData\>, TChild\>\(IShaderStorageBufferObject<TData\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IShaderStorageBufferObject<TData\>, TChild\>\(IShaderStorageBufferObject<TData\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IShaderStorageBufferObject<TData\>\>\(IShaderStorageBufferObject<TData\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Rendering_IShaderStorageBufferObject_1_Size"></a> Size

The size of this buffer.

```csharp
int Size { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IShaderStorageBufferObject_1_Item_System_Int32_"></a> this\[int\]

The data contained by this <xref href="osu.Framework.Graphics.Rendering.IShaderStorageBufferObject%601" data-throw-if-not-resolved="false"></xref>.

```csharp
TData this[int index] { get; set; }
```

#### Property Value

 TData

