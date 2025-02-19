# <a id="osu_Framework_Graphics_Rendering_IUniformBuffer_1"></a> Interface IUniformBuffer<TData\>

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

A buffer which stores data for a uniform block.

```csharp
public interface IUniformBuffer<TData> : IUniformBuffer, IDisposable where TData : unmanaged, IEquatable<TData>
```

#### Type Parameters

`TData` 

The type of data in the buffer.

#### Implements

[IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IUniformBuffer<TData\>\>\(IUniformBuffer<TData\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IUniformBuffer<TData\>\>\(IUniformBuffer<TData\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IUniformBuffer<TData\>\>\(IUniformBuffer<TData\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IUniformBuffer<TData\>\>\(IUniformBuffer<TData\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IUniformBuffer<TData\>, TChild\>\(IUniformBuffer<TData\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IUniformBuffer<TData\>, TChild\>\(IUniformBuffer<TData\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IUniformBuffer<TData\>, TChild\>\(IUniformBuffer<TData\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IUniformBuffer<TData\>\>\(IUniformBuffer<TData\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Rendering_IUniformBuffer_1_Data"></a> Data

The data contained by this <xref href="osu.Framework.Graphics.Rendering.IUniformBuffer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
TData Data { get; set; }
```

#### Property Value

 TData

