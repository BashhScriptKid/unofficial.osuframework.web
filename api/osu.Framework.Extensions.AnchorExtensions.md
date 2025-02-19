# <a id="osu_Framework_Extensions_AnchorExtensions"></a> Class AnchorExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

Extension methods for the <xref href="osu.Framework.Graphics.Anchor" data-throw-if-not-resolved="false"></xref> enumeration type.

```csharp
public static class AnchorExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AnchorExtensions](osu.Framework.Extensions.AnchorExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Extensions_AnchorExtensions_Opposite_osu_Framework_Graphics_Anchor_"></a> Opposite\(Anchor\)

Returns the <xref href="osu.Framework.Graphics.Anchor" data-throw-if-not-resolved="false"></xref> exactly opposite the given <code class="paramref">anchor</code>.

```csharp
public static Anchor Opposite(this Anchor anchor)
```

#### Parameters

`anchor` [Anchor](osu.Framework.Graphics.Anchor.md)

#### Returns

 [Anchor](osu.Framework.Graphics.Anchor.md)

### <a id="osu_Framework_Extensions_AnchorExtensions_PositionOnQuad_osu_Framework_Graphics_Anchor_osu_Framework_Graphics_Primitives_Quad_"></a> PositionOnQuad\(Anchor, Quad\)

Returns the position of the given <xref href="osu.Framework.Graphics.Anchor" data-throw-if-not-resolved="false"></xref> on the given <xref href="osu.Framework.Graphics.Primitives.Quad" data-throw-if-not-resolved="false"></xref>.

```csharp
public static Vector2 PositionOnQuad(this Anchor anchor, Quad quad)
```

#### Parameters

`anchor` [Anchor](osu.Framework.Graphics.Anchor.md)

`quad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

#### Returns

 Vector2

