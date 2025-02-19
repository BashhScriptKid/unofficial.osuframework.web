# <a id="osu_Framework_Graphics_Shaders_Types_UniformVector2"></a> Struct UniformVector2

Namespace: [osu.Framework.Graphics.Shaders.Types](osu.Framework.Graphics.Shaders.Types.md)  
Assembly: osu.Framework.dll  

Must be aligned to an 8-byte boundary.

```csharp
public record struct UniformVector2 : IEquatable<UniformVector2>
```

#### Implements

[IEquatable<UniformVector2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UniformVector2\>\(UniformVector2\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UniformVector2\>\(UniformVector2\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UniformVector2\>\(UniformVector2\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UniformVector2\>\(UniformVector2\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UniformVector2, TChild\>\(UniformVector2, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UniformVector2, TChild\>\(UniformVector2, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UniformVector2, TChild\>\(UniformVector2, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UniformVector2\>\(UniformVector2\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector2_X"></a> X

```csharp
public UniformFloat X
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector2_Y"></a> Y

```csharp
public UniformFloat Y
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

## Operators

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector2_op_Implicit_osu_Framework_Graphics_Shaders_Types_UniformVector2__osuTK_Vector2"></a> implicit operator Vector2\(UniformVector2\)

```csharp
public static implicit operator Vector2(UniformVector2 value)
```

#### Parameters

`value` [UniformVector2](osu.Framework.Graphics.Shaders.Types.UniformVector2.md)

#### Returns

 Vector2

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector2_op_Implicit_osuTK_Vector2__osu_Framework_Graphics_Shaders_Types_UniformVector2"></a> implicit operator UniformVector2\(Vector2\)

```csharp
public static implicit operator UniformVector2(Vector2 value)
```

#### Parameters

`value` Vector2

#### Returns

 [UniformVector2](osu.Framework.Graphics.Shaders.Types.UniformVector2.md)

