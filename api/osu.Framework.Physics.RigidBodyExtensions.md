# <a id="osu_Framework_Physics_RigidBodyExtensions"></a> Class RigidBodyExtensions

Namespace: [osu.Framework.Physics](osu.Framework.Physics.md)  
Assembly: osu.Framework.dll  

Helper extension methods operating on <xref href="osu.Framework.Physics.IRigidBody" data-throw-if-not-resolved="false"></xref>.

```csharp
public static class RigidBodyExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RigidBodyExtensions](osu.Framework.Physics.RigidBodyExtensions.md)

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

### <a id="osu_Framework_Physics_RigidBodyExtensions_ComputeImpulse_osu_Framework_Physics_IRigidBody_osu_Framework_Physics_IRigidBody_osuTK_Vector2_osuTK_Vector2_"></a> ComputeImpulse\(IRigidBody, IRigidBody, Vector2, Vector2\)

Computes the impulse of a collision of 2 rigid bodies, given the other body, the impact position,
and the surface normal of this body at the impact position.

```csharp
public static Vector2 ComputeImpulse(this IRigidBody body, IRigidBody other, Vector2 pos, Vector2 normal)
```

#### Parameters

`body` [IRigidBody](osu.Framework.Physics.IRigidBody.md)

`other` [IRigidBody](osu.Framework.Physics.IRigidBody.md)

`pos` Vector2

`normal` Vector2

#### Returns

 Vector2

### <a id="osu_Framework_Physics_RigidBodyExtensions_ImpulseDenominator_osu_Framework_Physics_IRigidBody_osuTK_Vector2_osuTK_Vector2_"></a> ImpulseDenominator\(IRigidBody, Vector2, Vector2\)

Helper function for code brevity in <xref href="osu.Framework.Physics.RigidBodyExtensions.ComputeImpulse(osu.Framework.Physics.IRigidBody%2cosu.Framework.Physics.IRigidBody%2cosuTK.Vector2%2cosuTK.Vector2)" data-throw-if-not-resolved="false"></xref>.
Can be moved into the function as a nested method once C# 7 is out.

```csharp
public static float ImpulseDenominator(this IRigidBody body, Vector2 pos, Vector2 normal)
```

#### Parameters

`body` [IRigidBody](osu.Framework.Physics.IRigidBody.md)

`pos` Vector2

`normal` Vector2

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

