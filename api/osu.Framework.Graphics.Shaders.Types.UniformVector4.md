# <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4"></a> Struct UniformVector4

Namespace: [osu.Framework.Graphics.Shaders.Types](osu.Framework.Graphics.Shaders.Types.md)  
Assembly: osu.Framework.dll  

Must be aligned to a 16-byte boundary.

```csharp
public record struct UniformVector4 : IEquatable<UniformVector4>
```

#### Implements

[IEquatable<UniformVector4\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UniformVector4\>\(UniformVector4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UniformVector4\>\(UniformVector4\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UniformVector4\>\(UniformVector4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UniformVector4\>\(UniformVector4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UniformVector4, TChild\>\(UniformVector4, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UniformVector4, TChild\>\(UniformVector4, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UniformVector4, TChild\>\(UniformVector4, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UniformVector4\>\(UniformVector4\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4_W"></a> W

```csharp
public UniformFloat W
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4_X"></a> X

```csharp
public UniformFloat X
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4_Y"></a> Y

```csharp
public UniformFloat Y
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4_Z"></a> Z

```csharp
public UniformFloat Z
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

## Operators

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4_op_Implicit_osu_Framework_Graphics_Shaders_Types_UniformVector4__osuTK_Vector4"></a> implicit operator Vector4\(UniformVector4\)

```csharp
public static implicit operator Vector4(UniformVector4 value)
```

#### Parameters

`value` [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

#### Returns

 Vector4

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector4_op_Implicit_osuTK_Vector4__osu_Framework_Graphics_Shaders_Types_UniformVector4"></a> implicit operator UniformVector4\(Vector4\)

```csharp
public static implicit operator UniformVector4(Vector4 value)
```

#### Parameters

`value` Vector4

#### Returns

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

