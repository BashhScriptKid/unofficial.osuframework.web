# <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation"></a> Class VertexFragmentShaderCompilation

Namespace: [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)  
Assembly: osu.Framework.dll  

```csharp
public class VertexFragmentShaderCompilation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[VertexFragmentShaderCompilation](osu.Framework.Graphics.Shaders.VertexFragmentShaderCompilation.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<VertexFragmentShaderCompilation\>\(VertexFragmentShaderCompilation?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<VertexFragmentShaderCompilation\>\(VertexFragmentShaderCompilation\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<VertexFragmentShaderCompilation\>\(VertexFragmentShaderCompilation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<VertexFragmentShaderCompilation\>\(VertexFragmentShaderCompilation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<VertexFragmentShaderCompilation, TChild\>\(VertexFragmentShaderCompilation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<VertexFragmentShaderCompilation, TChild\>\(VertexFragmentShaderCompilation, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<VertexFragmentShaderCompilation, TChild\>\(VertexFragmentShaderCompilation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<VertexFragmentShaderCompilation\>\(VertexFragmentShaderCompilation\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation_FragmentBytes"></a> FragmentBytes

The SpirV bytes for the fragment shader.

```csharp
public byte[] FragmentBytes { get; set; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation_FragmentText"></a> FragmentText

The cross-compiled fragment shader text.

```csharp
public string FragmentText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation_Reflection"></a> Reflection

A reflection of the shader program, describing the layout of resources.

```csharp
public SpirvReflection Reflection { get; set; }
```

#### Property Value

 SpirvReflection

### <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation_VertexBytes"></a> VertexBytes

The SpirV bytes for the vertex shader.

```csharp
public byte[] VertexBytes { get; set; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation_VertexText"></a> VertexText

The cross-compiled vertex shader text.

```csharp
public string VertexText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Shaders_VertexFragmentShaderCompilation_WasCached"></a> WasCached

Whether this compilation was retrieved from cache.

```csharp
public bool WasCached { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

