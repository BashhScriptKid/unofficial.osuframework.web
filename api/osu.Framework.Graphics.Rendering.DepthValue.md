# <a id="osu_Framework_Graphics_Rendering_DepthValue"></a> Class DepthValue

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

The depth value used to draw 2D objects to the screen.
Starts at -1f and increments to 1f for each <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which draws a opaque interior through <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref>.

```csharp
public class DepthValue
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DepthValue](osu.Framework.Graphics.Rendering.DepthValue.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DepthValue\>\(DepthValue?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DepthValue\>\(DepthValue\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DepthValue\>\(DepthValue\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DepthValue\>\(DepthValue\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DepthValue, TChild\>\(DepthValue, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DepthValue, TChild\>\(DepthValue, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DepthValue, TChild\>\(DepthValue, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DepthValue\>\(DepthValue\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_DepthValue__ctor"></a> DepthValue\(\)

```csharp
public DepthValue()
```

## Methods

### <a id="osu_Framework_Graphics_Rendering_DepthValue_Set_System_Single_"></a> Set\(float\)

Sets the depth to a given value. After this, the depth value can no longer be incremented.

```csharp
public void Set(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The new depth value.

## Operators

### <a id="osu_Framework_Graphics_Rendering_DepthValue_op_Implicit_osu_Framework_Graphics_Rendering_DepthValue__System_Single"></a> implicit operator float\(DepthValue\)

```csharp
public static implicit operator float(DepthValue d)
```

#### Parameters

`d` [DepthValue](osu.Framework.Graphics.Rendering.DepthValue.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

