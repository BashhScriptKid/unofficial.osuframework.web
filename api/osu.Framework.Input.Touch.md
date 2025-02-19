# <a id="osu_Framework_Input_Touch"></a> Struct Touch

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

Represents a touch structure that provides a touch source and current position.

```csharp
public readonly struct Touch : IEquatable<Touch>
```

#### Implements

[IEquatable<Touch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Touch\>\(Touch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Touch\>\(Touch\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Touch\>\(Touch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Touch\>\(Touch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Touch, TChild\>\(Touch, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Touch, TChild\>\(Touch, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Touch, TChild\>\(Touch, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Touch\>\(Touch\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Touch__ctor_osu_Framework_Input_TouchSource_osuTK_Vector2_"></a> Touch\(TouchSource, Vector2\)

```csharp
public Touch(TouchSource source, Vector2 position)
```

#### Parameters

`source` [TouchSource](osu.Framework.Input.TouchSource.md)

`position` Vector2

## Fields

### <a id="osu_Framework_Input_Touch_Position"></a> Position

The current position of this touch.

```csharp
public readonly Vector2 Position
```

#### Field Value

 Vector2

### <a id="osu_Framework_Input_Touch_Source"></a> Source

The source of this touch.

```csharp
public readonly TouchSource Source
```

#### Field Value

 [TouchSource](osu.Framework.Input.TouchSource.md)

## Methods

### <a id="osu_Framework_Input_Touch_Equals_osu_Framework_Input_Touch_"></a> Equals\(Touch\)

Indicates whether the <xref href="osu.Framework.Input.Touch.Source" data-throw-if-not-resolved="false"></xref> of this touch is equal to <xref href="osu.Framework.Input.Touch.Source" data-throw-if-not-resolved="false"></xref> of the other touch.

```csharp
public bool Equals(Touch other)
```

#### Parameters

`other` [Touch](osu.Framework.Input.Touch.md)

The other touch.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Touch_Equals_System_Object_"></a> Equals\(object\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Input_Touch_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

## Operators

### <a id="osu_Framework_Input_Touch_op_Equality_osu_Framework_Input_Touch_osu_Framework_Input_Touch_"></a> operator ==\(Touch, Touch\)

```csharp
public static bool operator ==(Touch left, Touch right)
```

#### Parameters

`left` [Touch](osu.Framework.Input.Touch.md)

`right` [Touch](osu.Framework.Input.Touch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Touch_op_Inequality_osu_Framework_Input_Touch_osu_Framework_Input_Touch_"></a> operator \!=\(Touch, Touch\)

```csharp
public static bool operator !=(Touch left, Touch right)
```

#### Parameters

`left` [Touch](osu.Framework.Input.Touch.md)

`right` [Touch](osu.Framework.Input.Touch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

