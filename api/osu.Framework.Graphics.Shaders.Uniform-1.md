# <a id="osu_Framework_Graphics_Shaders_Uniform_1"></a> Class Uniform<T\>

Namespace: [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)  
Assembly: osu.Framework.dll  

```csharp
public class Uniform<T> : IUniformWithValue<T>, IUniform where T : unmanaged, IEquatable<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Uniform<T\>](osu.Framework.Graphics.Shaders.Uniform\-1.md)

#### Implements

[IUniformWithValue<T\>](osu.Framework.Graphics.Shaders.IUniformWithValue\-1.md), 
[IUniform](osu.Framework.Graphics.Shaders.IUniform.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Uniform<T\>\>\(Uniform<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Uniform<T\>\>\(Uniform<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Uniform<T\>\>\(Uniform<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Uniform<T\>\>\(Uniform<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Uniform<T\>, TChild\>\(Uniform<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Uniform<T\>, TChild\>\(Uniform<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Uniform<T\>, TChild\>\(Uniform<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Uniform<T\>\>\(Uniform<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Shaders_Uniform_1__ctor_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_Graphics_Shaders_IShader_System_String_System_Int32_"></a> Uniform\(IRenderer, IShader, string, int\)

```csharp
public Uniform(IRenderer renderer, IShader owner, string name, int uniformLocation)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`owner` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`uniformLocation` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_HasChanged"></a> HasChanged

```csharp
public bool HasChanged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_Location"></a> Location

The location of this uniform in relation to all other uniforms in the shader.

```csharp
public int Location { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

Depending on the renderer used, this could either be zero-based index number or location in bytes.

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_Owner"></a> Owner

The shader which this uniform was declared in.

```csharp
public IShader Owner { get; }
```

#### Property Value

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_Value"></a> Value

```csharp
public T Value { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_Update"></a> Update\(\)

Updates the renderer with the current value of this uniform.

```csharp
public void Update()
```

### <a id="osu_Framework_Graphics_Shaders_Uniform_1_UpdateValue__0__"></a> UpdateValue\(ref T\)

```csharp
public void UpdateValue(ref T newValue)
```

#### Parameters

`newValue` T

