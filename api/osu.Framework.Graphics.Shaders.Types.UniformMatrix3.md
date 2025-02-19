# <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix3"></a> Struct UniformMatrix3

Namespace: [osu.Framework.Graphics.Shaders.Types](osu.Framework.Graphics.Shaders.Types.md)  
Assembly: osu.Framework.dll  

Must be aligned to a 16-byte boundary.

```csharp
public record struct UniformMatrix3 : IEquatable<UniformMatrix3>
```

#### Implements

[IEquatable<UniformMatrix3\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UniformMatrix3\>\(UniformMatrix3\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UniformMatrix3\>\(UniformMatrix3\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UniformMatrix3\>\(UniformMatrix3\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UniformMatrix3\>\(UniformMatrix3\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UniformMatrix3, TChild\>\(UniformMatrix3, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UniformMatrix3, TChild\>\(UniformMatrix3, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UniformMatrix3, TChild\>\(UniformMatrix3, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UniformMatrix3\>\(UniformMatrix3\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix3_Row0"></a> Row0

```csharp
public UniformVector3 Row0
```

#### Field Value

 [UniformVector3](osu.Framework.Graphics.Shaders.Types.UniformVector3.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix3_Row1"></a> Row1

```csharp
public UniformVector3 Row1
```

#### Field Value

 [UniformVector3](osu.Framework.Graphics.Shaders.Types.UniformVector3.md)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix3_Row2"></a> Row2

```csharp
public UniformVector3 Row2
```

#### Field Value

 [UniformVector3](osu.Framework.Graphics.Shaders.Types.UniformVector3.md)

## Operators

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix3_op_Implicit_osu_Framework_Graphics_Shaders_Types_UniformMatrix3__osuTK_Matrix3"></a> implicit operator Matrix3\(UniformMatrix3\)

```csharp
public static implicit operator Matrix3(UniformMatrix3 matrix)
```

#### Parameters

`matrix` [UniformMatrix3](osu.Framework.Graphics.Shaders.Types.UniformMatrix3.md)

#### Returns

 Matrix3

### <a id="osu_Framework_Graphics_Shaders_Types_UniformMatrix3_op_Implicit_osuTK_Matrix3__osu_Framework_Graphics_Shaders_Types_UniformMatrix3"></a> implicit operator UniformMatrix3\(Matrix3\)

```csharp
public static implicit operator UniformMatrix3(Matrix3 matrix)
```

#### Parameters

`matrix` Matrix3

#### Returns

 [UniformMatrix3](osu.Framework.Graphics.Shaders.Types.UniformMatrix3.md)

