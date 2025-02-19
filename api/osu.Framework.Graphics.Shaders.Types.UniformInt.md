# <a id="osu_Framework_Graphics_Shaders_Types_UniformInt"></a> Struct UniformInt

Namespace: [osu.Framework.Graphics.Shaders.Types](osu.Framework.Graphics.Shaders.Types.md)  
Assembly: osu.Framework.dll  

Must be aligned to a 4-byte boundary.

```csharp
public record struct UniformInt : IEquatable<UniformInt>
```

#### Implements

[IEquatable<UniformInt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UniformInt\>\(UniformInt\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UniformInt\>\(UniformInt\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UniformInt\>\(UniformInt\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UniformInt\>\(UniformInt\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UniformInt, TChild\>\(UniformInt, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UniformInt, TChild\>\(UniformInt, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UniformInt, TChild\>\(UniformInt, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UniformInt\>\(UniformInt\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Shaders_Types_UniformInt_Value"></a> Value

```csharp
public int Value
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Operators

### <a id="osu_Framework_Graphics_Shaders_Types_UniformInt_op_Implicit_osu_Framework_Graphics_Shaders_Types_UniformInt__System_Int32"></a> implicit operator int\(UniformInt\)

```csharp
public static implicit operator int(UniformInt value)
```

#### Parameters

`value` [UniformInt](osu.Framework.Graphics.Shaders.Types.UniformInt.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Shaders_Types_UniformInt_op_Implicit_System_Int32__osu_Framework_Graphics_Shaders_Types_UniformInt"></a> implicit operator UniformInt\(int\)

```csharp
public static implicit operator UniformInt(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [UniformInt](osu.Framework.Graphics.Shaders.Types.UniformInt.md)

