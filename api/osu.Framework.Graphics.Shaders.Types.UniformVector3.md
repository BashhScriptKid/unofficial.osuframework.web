# <a id="osu_Framework_Graphics_Shaders_Types_UniformVector3"></a> Struct UniformVector3

Namespace: [osu.Framework.Graphics.Shaders.Types](osu.Framework.Graphics.Shaders.Types.md)  
Assembly: osu.Framework.dll  

Must be aligned to a 16-byte boundary. Is equivalent to a <xref href="osu.Framework.Graphics.Shaders.Types.UniformVector4" data-throw-if-not-resolved="false"></xref>.

```csharp
public record struct UniformVector3 : IEquatable<UniformVector3>
```

#### Implements

[IEquatable<UniformVector3\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UniformVector3\>\(UniformVector3\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UniformVector3\>\(UniformVector3\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UniformVector3\>\(UniformVector3\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UniformVector3\>\(UniformVector3\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UniformVector3, TChild\>\(UniformVector3, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UniformVector3, TChild\>\(UniformVector3, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UniformVector3, TChild\>\(UniformVector3, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UniformVector3\>\(UniformVector3\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector3_Value"></a> Value

```csharp
public UniformVector4 Value
```

#### Field Value

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

## Operators

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector3_op_Implicit_osu_Framework_Graphics_Shaders_Types_UniformVector3__osuTK_Vector3"></a> implicit operator Vector3\(UniformVector3\)

```csharp
public static implicit operator Vector3(UniformVector3 value)
```

#### Parameters

`value` [UniformVector3](osu.Framework.Graphics.Shaders.Types.UniformVector3.md)

#### Returns

 Vector3

### <a id="osu_Framework_Graphics_Shaders_Types_UniformVector3_op_Implicit_osuTK_Vector3__osu_Framework_Graphics_Shaders_Types_UniformVector3"></a> implicit operator UniformVector3\(Vector3\)

```csharp
public static implicit operator UniformVector3(Vector3 value)
```

#### Parameters

`value` Vector3

#### Returns

 [UniformVector3](osu.Framework.Graphics.Shaders.Types.UniformVector3.md)

