# <a id="osu_Framework_Graphics_Rendering_IVertexBatch_1"></a> Interface IVertexBatch<TVertex\>

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IVertexBatch<in TVertex> : IVertexBatch, IDisposable where TVertex : unmanaged, IEquatable<in TVertex>, IVertex
```

#### Type Parameters

`TVertex` 

#### Implements

[IVertexBatch](osu.Framework.Graphics.Rendering.IVertexBatch.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IVertexBatch<TVertex\>\>\(IVertexBatch<TVertex\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IVertexBatch<TVertex\>\>\(IVertexBatch<TVertex\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IVertexBatch<TVertex\>\>\(IVertexBatch<TVertex\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IVertexBatch<TVertex\>\>\(IVertexBatch<TVertex\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IVertexBatch<TVertex\>, TChild\>\(IVertexBatch<TVertex\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IVertexBatch<TVertex\>, TChild\>\(IVertexBatch<TVertex\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IVertexBatch<TVertex\>, TChild\>\(IVertexBatch<TVertex\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IVertexBatch<TVertex\>\>\(IVertexBatch<TVertex\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Rendering_IVertexBatch_1_AddAction"></a> AddAction

Adds a vertex to this <xref href="osu.Framework.Graphics.Rendering.IVertexBatch%601" data-throw-if-not-resolved="false"></xref>.
This is a cached delegate of <xref href="osu.Framework.Graphics.Rendering.IVertexBatch%601.Add(%600)" data-throw-if-not-resolved="false"></xref> that should be used in memory-critical locations such as <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s.

```csharp
Action<in TVertex> AddAction { get; }
```

#### Property Value

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TVertex\>

## Methods

### <a id="osu_Framework_Graphics_Rendering_IVertexBatch_1_Add__0_"></a> Add\(TVertex\)

```csharp
void Add(TVertex vertex)
```

#### Parameters

`vertex` TVertex

