# <a id="osu_Framework_Graphics_Shaders_IUniformWithValue_1"></a> Interface IUniformWithValue<T\>

Namespace: [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IUniformWithValue<T> : IUniform where T : unmanaged, IEquatable<T>
```

#### Type Parameters

`T` 

#### Implements

[IUniform](osu.Framework.Graphics.Shaders.IUniform.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IUniformWithValue<T\>\>\(IUniformWithValue<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IUniformWithValue<T\>\>\(IUniformWithValue<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IUniformWithValue<T\>\>\(IUniformWithValue<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IUniformWithValue<T\>\>\(IUniformWithValue<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IUniformWithValue<T\>, TChild\>\(IUniformWithValue<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IUniformWithValue<T\>, TChild\>\(IUniformWithValue<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IUniformWithValue<T\>, TChild\>\(IUniformWithValue<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IUniformWithValue<T\>\>\(IUniformWithValue<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Shaders_IUniformWithValue_1_GetValue"></a> GetValue\(\)

Returns the current value of this uniform.

```csharp
T GetValue()
```

#### Returns

 T

### <a id="osu_Framework_Graphics_Shaders_IUniformWithValue_1_GetValueByRef"></a> GetValueByRef\(\)

Returns a reference to the current value of this uniform.

```csharp
ref T GetValueByRef()
```

#### Returns

 T

