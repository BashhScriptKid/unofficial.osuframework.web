# <a id="osu_Framework_Graphics_BlendingParameters"></a> Struct BlendingParameters

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Contains information about how an <xref href="osu.Framework.Graphics.IDrawable" data-throw-if-not-resolved="false"></xref> should be blended into its destination.

```csharp
public struct BlendingParameters : IEquatable<BlendingParameters>
```

#### Implements

[IEquatable<BlendingParameters\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BlendingParameters\>\(BlendingParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BlendingParameters\>\(BlendingParameters\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BlendingParameters\>\(BlendingParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BlendingParameters\>\(BlendingParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BlendingParameters, TChild\>\(BlendingParameters, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BlendingParameters, TChild\>\(BlendingParameters, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BlendingParameters, TChild\>\(BlendingParameters, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BlendingParameters\>\(BlendingParameters\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_BlendingParameters_AlphaEquation"></a> AlphaEquation

Gets or sets the <xref href="osu.Framework.Graphics.BlendingEquation" data-throw-if-not-resolved="false"></xref> to use for the alpha component of the blend.

```csharp
public BlendingEquation AlphaEquation
```

#### Field Value

 [BlendingEquation](osu.Framework.Graphics.BlendingEquation.md)

### <a id="osu_Framework_Graphics_BlendingParameters_Destination"></a> Destination

The blending factor for the destination color of the blend.

```csharp
public BlendingType Destination
```

#### Field Value

 [BlendingType](osu.Framework.Graphics.BlendingType.md)

### <a id="osu_Framework_Graphics_BlendingParameters_DestinationAlpha"></a> DestinationAlpha

The blending factor for the destination alpha of the blend.

```csharp
public BlendingType DestinationAlpha
```

#### Field Value

 [BlendingType](osu.Framework.Graphics.BlendingType.md)

### <a id="osu_Framework_Graphics_BlendingParameters_RGBEquation"></a> RGBEquation

Gets or sets the <xref href="osu.Framework.Graphics.BlendingEquation" data-throw-if-not-resolved="false"></xref> to use for the RGB components of the blend.

```csharp
public BlendingEquation RGBEquation
```

#### Field Value

 [BlendingEquation](osu.Framework.Graphics.BlendingEquation.md)

### <a id="osu_Framework_Graphics_BlendingParameters_Source"></a> Source

The blending factor for the source color of the blend.

```csharp
public BlendingType Source
```

#### Field Value

 [BlendingType](osu.Framework.Graphics.BlendingType.md)

### <a id="osu_Framework_Graphics_BlendingParameters_SourceAlpha"></a> SourceAlpha

The blending factor for the source alpha of the blend.

```csharp
public BlendingType SourceAlpha
```

#### Field Value

 [BlendingType](osu.Framework.Graphics.BlendingType.md)

## Properties

### <a id="osu_Framework_Graphics_BlendingParameters_Additive"></a> Additive

```csharp
public static BlendingParameters Additive { get; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_BlendingParameters_AlphaEquationMode"></a> AlphaEquationMode

Gets the <xref href="osuTK.Graphics.ES30.BlendEquationMode" data-throw-if-not-resolved="false"></xref> for the currently specified Alpha Equation.

```csharp
public readonly BlendEquationMode AlphaEquationMode { get; }
```

#### Property Value

 BlendEquationMode

### <a id="osu_Framework_Graphics_BlendingParameters_DestinationAlphaBlendingFactor"></a> DestinationAlphaBlendingFactor

Gets the <xref href="osuTK.Graphics.ES30.BlendingFactorDest" data-throw-if-not-resolved="false"></xref> for the currently specified destination alpha mode.

```csharp
public readonly BlendingFactorDest DestinationAlphaBlendingFactor { get; }
```

#### Property Value

 BlendingFactorDest

### <a id="osu_Framework_Graphics_BlendingParameters_DestinationBlendingFactor"></a> DestinationBlendingFactor

Gets the <xref href="osuTK.Graphics.ES30.BlendingFactorDest" data-throw-if-not-resolved="false"></xref> for the currently specified destination blending mode.

```csharp
public readonly BlendingFactorDest DestinationBlendingFactor { get; }
```

#### Property Value

 BlendingFactorDest

### <a id="osu_Framework_Graphics_BlendingParameters_Inherit"></a> Inherit

```csharp
public static BlendingParameters Inherit { get; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_BlendingParameters_IsDisabled"></a> IsDisabled

```csharp
public readonly bool IsDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BlendingParameters_Mixture"></a> Mixture

```csharp
public static BlendingParameters Mixture { get; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_BlendingParameters_None"></a> None

```csharp
public static BlendingParameters None { get; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_BlendingParameters_RGBEquationMode"></a> RGBEquationMode

Gets the <xref href="osuTK.Graphics.ES30.BlendEquationMode" data-throw-if-not-resolved="false"></xref> for the currently specified RGB Equation.

```csharp
public readonly BlendEquationMode RGBEquationMode { get; }
```

#### Property Value

 BlendEquationMode

### <a id="osu_Framework_Graphics_BlendingParameters_SourceAlphaBlendingFactor"></a> SourceAlphaBlendingFactor

Gets the <xref href="osuTK.Graphics.ES30.BlendingFactorSrc" data-throw-if-not-resolved="false"></xref> for the currently specified source alpha mode.

```csharp
public readonly BlendingFactorSrc SourceAlphaBlendingFactor { get; }
```

#### Property Value

 BlendingFactorSrc

### <a id="osu_Framework_Graphics_BlendingParameters_SourceBlendingFactor"></a> SourceBlendingFactor

Gets the <xref href="osuTK.Graphics.ES30.BlendingFactorSrc" data-throw-if-not-resolved="false"></xref> for the currently specified source blending mode.

```csharp
public readonly BlendingFactorSrc SourceBlendingFactor { get; }
```

#### Property Value

 BlendingFactorSrc

## Methods

### <a id="osu_Framework_Graphics_BlendingParameters_ApplyDefaultToInherited"></a> ApplyDefaultToInherited\(\)

Any properties marked as inherited will have their blending mode changed to the default type. This can occur when a root element is set to inherited.

```csharp
public void ApplyDefaultToInherited()
```

### <a id="osu_Framework_Graphics_BlendingParameters_CopyFromParent_osu_Framework_Graphics_BlendingParameters_"></a> CopyFromParent\(BlendingParameters\)

Copy all properties that are marked as inherited from a parent <xref href="osu.Framework.Graphics.BlendingParameters" data-throw-if-not-resolved="false"></xref> object.

```csharp
public void CopyFromParent(BlendingParameters parent)
```

#### Parameters

`parent` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

The parent <xref href="osu.Framework.Graphics.BlendingParameters" data-throw-if-not-resolved="false"></xref> from which to copy inherited properties.

### <a id="osu_Framework_Graphics_BlendingParameters_Equals_osu_Framework_Graphics_BlendingParameters_"></a> Equals\(BlendingParameters\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(BlendingParameters other)
```

#### Parameters

`other` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_BlendingParameters_Equals_System_Object_"></a> Equals\(object\)

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

### <a id="osu_Framework_Graphics_BlendingParameters_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Graphics_BlendingParameters_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="osu_Framework_Graphics_BlendingParameters_op_Equality_osu_Framework_Graphics_BlendingParameters__osu_Framework_Graphics_BlendingParameters__"></a> operator ==\(in BlendingParameters, in BlendingParameters\)

```csharp
public static bool operator ==(in BlendingParameters left, in BlendingParameters right)
```

#### Parameters

`left` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

`right` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BlendingParameters_op_Inequality_osu_Framework_Graphics_BlendingParameters__osu_Framework_Graphics_BlendingParameters__"></a> operator \!=\(in BlendingParameters, in BlendingParameters\)

```csharp
public static bool operator !=(in BlendingParameters left, in BlendingParameters right)
```

#### Parameters

`left` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

`right` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

