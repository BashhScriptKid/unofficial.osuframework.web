# <a id="osu_Framework_Graphics_Primitives_Vector2I"></a> Struct Vector2I

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

```csharp
[Serializable]
public struct Vector2I : IEquatable<Vector2I>
```

#### Implements

[IEquatable<Vector2I\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Vector2I\>\(Vector2I\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Vector2I\>\(Vector2I\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Vector2I\>\(Vector2I\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Vector2I\>\(Vector2I\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Vector2I, TChild\>\(Vector2I, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Vector2I, TChild\>\(Vector2I, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Vector2I, TChild\>\(Vector2I, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Vector2I\>\(Vector2I\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_Vector2I__ctor_System_Int32_"></a> Vector2I\(int\)

```csharp
public Vector2I(int val)
```

#### Parameters

`val` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_Vector2I__ctor_System_Int32_System_Int32_"></a> Vector2I\(int, int\)

```csharp
public Vector2I(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="osu_Framework_Graphics_Primitives_Vector2I_X"></a> X

```csharp
public int X
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_Vector2I_Y"></a> Y

```csharp
public int Y
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Primitives_Vector2I_One"></a> One

```csharp
public static Vector2I One { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_Vector2I_Zero"></a> Zero

```csharp
public static Vector2I Zero { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

## Methods

### <a id="osu_Framework_Graphics_Primitives_Vector2I_Equals_osu_Framework_Graphics_Primitives_Vector2I_"></a> Equals\(Vector2I\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(Vector2I other)
```

#### Parameters

`other` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Primitives_Vector2I_Equals_System_Object_"></a> Equals\(object\)

Indicates whether this instance and a specified object are equal.

```csharp
public override readonly bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Primitives_Vector2I_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

## Operators

### <a id="osu_Framework_Graphics_Primitives_Vector2I_op_Addition_osu_Framework_Graphics_Primitives_Vector2I_osu_Framework_Graphics_Primitives_Vector2I_"></a> operator \+\(Vector2I, Vector2I\)

```csharp
public static Vector2I operator +(Vector2I left, Vector2I right)
```

#### Parameters

`left` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

`right` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_Vector2I_op_Equality_osu_Framework_Graphics_Primitives_Vector2I_osu_Framework_Graphics_Primitives_Vector2I_"></a> operator ==\(Vector2I, Vector2I\)

```csharp
public static bool operator ==(Vector2I left, Vector2I right)
```

#### Parameters

`left` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

`right` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_Vector2I_op_Implicit_osu_Framework_Graphics_Primitives_Vector2I__osuTK_Vector2"></a> implicit operator Vector2\(Vector2I\)

```csharp
public static implicit operator Vector2(Vector2I r)
```

#### Parameters

`r` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Vector2I_op_Inequality_osu_Framework_Graphics_Primitives_Vector2I_osu_Framework_Graphics_Primitives_Vector2I_"></a> operator \!=\(Vector2I, Vector2I\)

```csharp
public static bool operator !=(Vector2I left, Vector2I right)
```

#### Parameters

`left` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

`right` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_Vector2I_op_Subtraction_osu_Framework_Graphics_Primitives_Vector2I_osu_Framework_Graphics_Primitives_Vector2I_"></a> operator \-\(Vector2I, Vector2I\)

```csharp
public static Vector2I operator -(Vector2I left, Vector2I right)
```

#### Parameters

`left` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

`right` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

