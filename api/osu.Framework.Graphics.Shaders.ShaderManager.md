# <a id="osu_Framework_Graphics_Shaders_ShaderManager"></a> Class ShaderManager

Namespace: [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)  
Assembly: osu.Framework.dll  

```csharp
public class ShaderManager : IShaderStore, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ShaderManager](osu.Framework.Graphics.Shaders.ShaderManager.md)

#### Implements

[IShaderStore](osu.Framework.Graphics.Shaders.IShaderStore.md), 
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

[ObjectExtensions.AsNonNull<ShaderManager\>\(ShaderManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ShaderManager\>\(ShaderManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ShaderManager\>\(ShaderManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ShaderManager\>\(ShaderManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ShaderManager, TChild\>\(ShaderManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ShaderManager, TChild\>\(ShaderManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ShaderManager, TChild\>\(ShaderManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ShaderManager\>\(ShaderManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Shaders_ShaderManager__ctor_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_IO_Stores_IResourceStore_System_Byte____"></a> ShaderManager\(IRenderer, IResourceStore<byte\[\]\>\)

Constructs a new <xref href="osu.Framework.Graphics.Shaders.ShaderManager" data-throw-if-not-resolved="false"></xref>.

```csharp
public ShaderManager(IRenderer renderer, IResourceStore<byte[]> store)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

## Methods

### <a id="osu_Framework_Graphics_Shaders_ShaderManager_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Shaders_ShaderManager_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Shaders_ShaderManager_GetCachedShader_System_String_System_String_"></a> GetCachedShader\(string, string\)

Attempts to retrieve an already-cached shader.

```csharp
public virtual IShader? GetCachedShader(string vertex, string fragment)
```

#### Parameters

`vertex` [string](https://learn.microsoft.com/dotnet/api/system.string)

The vertex shader name.

`fragment` [string](https://learn.microsoft.com/dotnet/api/system.string)

The fragment shader name.

#### Returns

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)?

A cached <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref> instance, if existing.

### <a id="osu_Framework_Graphics_Shaders_ShaderManager_GetCachedShaderPart_System_String_"></a> GetCachedShaderPart\(string\)

Attempts to retrieve an already-cached shader part.

```csharp
public virtual IShaderPart? GetCachedShaderPart(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the shader part.

#### Returns

 [IShaderPart](osu.Framework.Graphics.Rendering.IShaderPart.md)?

A cached <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref> instance, if existing.

### <a id="osu_Framework_Graphics_Shaders_ShaderManager_GetRawData_System_String_"></a> GetRawData\(string\)

Attempts to retrieve the raw data for a shader file.

```csharp
public virtual byte[]? GetRawData(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The file name.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]?

### <a id="osu_Framework_Graphics_Shaders_ShaderManager_Load_System_String_System_String_"></a> Load\(string, string\)

Retrieves a usable <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref> given the vertex and fragment shaders.

```csharp
public IShader Load(string vertex, string fragment)
```

#### Parameters

`vertex` [string](https://learn.microsoft.com/dotnet/api/system.string)

The vertex shader name.

`fragment` [string](https://learn.microsoft.com/dotnet/api/system.string)

The fragment shader name.

#### Returns

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)

