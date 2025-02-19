# <a id="osu_Framework_Graphics_Shaders_ShaderCompilationStore"></a> Class ShaderCompilationStore

Namespace: [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)  
Assembly: osu.Framework.dll  

```csharp
public class ShaderCompilationStore
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ShaderCompilationStore](osu.Framework.Graphics.Shaders.ShaderCompilationStore.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ShaderCompilationStore\>\(ShaderCompilationStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ShaderCompilationStore\>\(ShaderCompilationStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ShaderCompilationStore\>\(ShaderCompilationStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ShaderCompilationStore\>\(ShaderCompilationStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ShaderCompilationStore, TChild\>\(ShaderCompilationStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ShaderCompilationStore, TChild\>\(ShaderCompilationStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ShaderCompilationStore, TChild\>\(ShaderCompilationStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ShaderCompilationStore\>\(ShaderCompilationStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Shaders_ShaderCompilationStore_CacheStorage"></a> CacheStorage

```csharp
public Storage? CacheStorage { set; }
```

#### Property Value

 [Storage](osu.Framework.Platform.Storage.md)?

## Methods

### <a id="osu_Framework_Graphics_Shaders_ShaderCompilationStore_CompileCompute_System_String_Veldrid_SPIRV_CrossCompileTarget_"></a> CompileCompute\(string, CrossCompileTarget\)

```csharp
public ComputeProgramCompilation CompileCompute(string programText, CrossCompileTarget target)
```

#### Parameters

`programText` [string](https://learn.microsoft.com/dotnet/api/system.string)

`target` CrossCompileTarget

#### Returns

 [ComputeProgramCompilation](osu.Framework.Graphics.Shaders.ComputeProgramCompilation.md)

### <a id="osu_Framework_Graphics_Shaders_ShaderCompilationStore_CompileVertexFragment_System_String_System_String_Veldrid_SPIRV_CrossCompileTarget_"></a> CompileVertexFragment\(string, string, CrossCompileTarget\)

```csharp
public VertexFragmentShaderCompilation CompileVertexFragment(string vertexText, string fragmentText, CrossCompileTarget target)
```

#### Parameters

`vertexText` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentText` [string](https://learn.microsoft.com/dotnet/api/system.string)

`target` CrossCompileTarget

#### Returns

 [VertexFragmentShaderCompilation](osu.Framework.Graphics.Shaders.VertexFragmentShaderCompilation.md)

