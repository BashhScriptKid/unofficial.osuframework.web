# <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4"></a> Struct UniformMatrix4

Namespace: [osu.Framework.Graphics.Shaders.Types](osu.Framework.Graphics.Shaders.Types.md)  
Assembly: osu.Framework.dll  

Must be aligned to a 16-byte boundary.

```csharp
public record struct UniformMatrix4 : IEquatable<UniformMatrix4>
```

#### Implements

[IEquatable<UniformMatrix4\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UniformMatrix4\>\(UniformMatrix4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UniformMatrix4\>\(UniformMatrix4\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UniformMatrix4\>\(UniformMatrix4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UniformMatrix4\>\(UniformMatrix4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UniformMatrix4, TChild\>\(UniformMatrix4, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UniformMatrix4, TChild\>\(UniformMatrix4, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UniformMatrix4, TChild\>\(UniformMatrix4, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UniformMatrix4\>\(UniformMatrix4\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4_Row0"></a> Row0

```csharp
public UniformVector4 Row0
```

#### Field Value

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4_Row1"></a> Row1

```csharp
public UniformVector4 Row1
```

#### Field Value

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4_Row2"></a> Row2

```csharp
public UniformVector4 Row2
```

#### Field Value

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4_Row3"></a> Row3

```csharp
public UniformVector4 Row3
```

#### Field Value

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

## Operators

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4_op_Implicit_osu_Framework_Graphics_Shaders_Types_UniformMatrix4__osuTK_Matrix4"></a> implicit operator Matrix4\(UniformMatrix4\)

```csharp
public static implicit operator Matrix4(UniformMatrix4 matrix)
```

#### Parameters

`matrix` [UniformMatrix4](osu.Framework.Graphics.Shaders.Types.UniformMatrix4.md)

#### Returns

 Matrix4

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix4_op_Implicit_osuTK_Matrix4__osu_Framework_Graphics_Shaders_Types_UniformMatrix4"></a> implicit operator UniformMatrix4\(Matrix4\)

```csharp
public static implicit operator UniformMatrix4(Matrix4 matrix)
```

#### Parameters

`matrix` Matrix4

#### Returns

 [UniformMatrix4](osu.Framework.Graphics.Shaders.Types.UniformMatrix4.md)

