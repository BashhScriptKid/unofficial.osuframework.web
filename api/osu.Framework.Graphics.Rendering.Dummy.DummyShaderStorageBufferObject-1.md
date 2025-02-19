# <a id="osu_Framework_Graphics_Rendering_Dummy_DummyShaderStorageBufferObject_1"></a> Class DummyShaderStorageBufferObject<T\>

Namespace: [osu.Framework.Graphics.Rendering.Dummy](osu.Framework.Graphics.Rendering.Dummy.md)  
Assembly: osu.Framework.dll  

```csharp
public class DummyShaderStorageBufferObject<T> : IShaderStorageBufferObject<T>, IUniformBuffer, IDisposable where T : unmanaged, IEquatable<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DummyShaderStorageBufferObject<T\>](osu.Framework.Graphics.Rendering.Dummy.DummyShaderStorageBufferObject\-1.md)

#### Implements

[IShaderStorageBufferObject<T\>](osu.Framework.Graphics.Rendering.IShaderStorageBufferObject\-1.md), 
[IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md), 
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

[ObjectExtensions.AsNonNull<DummyShaderStorageBufferObject<T\>\>\(DummyShaderStorageBufferObject<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DummyShaderStorageBufferObject<T\>\>\(DummyShaderStorageBufferObject<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DummyShaderStorageBufferObject<T\>\>\(DummyShaderStorageBufferObject<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DummyShaderStorageBufferObject<T\>\>\(DummyShaderStorageBufferObject<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DummyShaderStorageBufferObject<T\>, TChild\>\(DummyShaderStorageBufferObject<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DummyShaderStorageBufferObject<T\>, TChild\>\(DummyShaderStorageBufferObject<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DummyShaderStorageBufferObject<T\>, TChild\>\(DummyShaderStorageBufferObject<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DummyShaderStorageBufferObject<T\>\>\(DummyShaderStorageBufferObject<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyShaderStorageBufferObject_1__ctor_System_Int32_"></a> DummyShaderStorageBufferObject\(int\)

```csharp
public DummyShaderStorageBufferObject(int size)
```

#### Parameters

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyShaderStorageBufferObject_1_Size"></a> Size

The size of this buffer.

```csharp
public int Size { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyShaderStorageBufferObject_1_Item_System_Int32_"></a> this\[int\]

The data contained by this <xref href="osu.Framework.Graphics.Rendering.IShaderStorageBufferObject%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public T this[int index] { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyShaderStorageBufferObject_1_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

