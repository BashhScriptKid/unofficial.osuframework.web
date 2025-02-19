# <a id="osu_Framework_Input_ISourceGeneratedHandleInputCache"></a> Interface ISourceGeneratedHandleInputCache

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ISourceGeneratedHandleInputCache
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ISourceGeneratedHandleInputCache\>\(ISourceGeneratedHandleInputCache?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ISourceGeneratedHandleInputCache\>\(ISourceGeneratedHandleInputCache\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ISourceGeneratedHandleInputCache\>\(ISourceGeneratedHandleInputCache\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ISourceGeneratedHandleInputCache\>\(ISourceGeneratedHandleInputCache\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ISourceGeneratedHandleInputCache, TChild\>\(ISourceGeneratedHandleInputCache, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ISourceGeneratedHandleInputCache, TChild\>\(ISourceGeneratedHandleInputCache, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ISourceGeneratedHandleInputCache, TChild\>\(ISourceGeneratedHandleInputCache, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ISourceGeneratedHandleInputCache\>\(ISourceGeneratedHandleInputCache\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_ISourceGeneratedHandleInputCache_KnownType"></a> KnownType

The most-derived type that implements this interface.
This is used to handle non-partial leaf types that can't rely on the source-generated values and must fall back to reflection.

```csharp
Type KnownType { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="osu_Framework_Input_ISourceGeneratedHandleInputCache_RequestsNonPositionalInput"></a> RequestsNonPositionalInput

Whether this type or any of its base types request non-positional input.

```csharp
bool RequestsNonPositionalInput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_ISourceGeneratedHandleInputCache_RequestsPositionalInput"></a> RequestsPositionalInput

Whether this type or any of its base types request positional input.

```csharp
bool RequestsPositionalInput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

