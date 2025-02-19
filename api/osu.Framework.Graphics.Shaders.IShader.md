# <a id="osu_Framework_Graphics_Shaders_IShader"></a> Interface IShader

Namespace: [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IShader : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IShader\>\(IShader?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IShader\>\(IShader\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IShader\>\(IShader\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IShader\>\(IShader\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IShader, TChild\>\(IShader, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IShader, TChild\>\(IShader, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IShader, TChild\>\(IShader, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IShader\>\(IShader\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Shaders_IShader_IsBound"></a> IsBound

Whether this shader is currently bound.

```csharp
bool IsBound { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Shaders_IShader_IsLoaded"></a> IsLoaded

Whether this shader is ready for use.

```csharp
bool IsLoaded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Graphics_Shaders_IShader_Bind"></a> Bind\(\)

Binds this shader to be used for rendering.

```csharp
void Bind()
```

### <a id="osu_Framework_Graphics_Shaders_IShader_BindUniformBlock_System_String_osu_Framework_Graphics_Rendering_IUniformBuffer_"></a> BindUniformBlock\(string, IUniformBuffer\)

Binds an <xref href="osu.Framework.Graphics.Rendering.IUniformBuffer" data-throw-if-not-resolved="false"></xref> to a uniform block of the given name.

```csharp
void BindUniformBlock(string blockName, IUniformBuffer buffer)
```

#### Parameters

`blockName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The uniform block name.

`buffer` [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md)

The buffer to bind to the block.

### <a id="osu_Framework_Graphics_Shaders_IShader_GetUniform__1_System_String_"></a> GetUniform<T\>\(string\)

Retrieves a uniform from the shader.

```csharp
Uniform<T> GetUniform<T>(string name) where T : unmanaged, IEquatable<T>
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the uniform.

#### Returns

 [Uniform](osu.Framework.Graphics.Shaders.Uniform\-1.md)<T\>

The retrieved uniform.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Shaders_IShader_Unbind"></a> Unbind\(\)

Unbinds this shader.

```csharp
void Unbind()
```

