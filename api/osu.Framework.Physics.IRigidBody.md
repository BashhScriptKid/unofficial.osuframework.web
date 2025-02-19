# <a id="osu_Framework_Physics_IRigidBody"></a> Interface IRigidBody

Namespace: [osu.Framework.Physics](osu.Framework.Physics.md)  
Assembly: osu.Framework.dll  

Contains physical state and methods necessary for rigid body simulation.

```csharp
public interface IRigidBody : IDrawable, ITransformable
```

#### Implements

[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IRigidBody\>\(IRigidBody, params TransformSequence<IRigidBody\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IRigidBody\>\(IRigidBody?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[RigidBodyExtensions.ComputeImpulse\(IRigidBody, IRigidBody, Vector2, Vector2\)](osu.Framework.Physics.RigidBodyExtensions.md\#osu\_Framework\_Physics\_RigidBodyExtensions\_ComputeImpulse\_osu\_Framework\_Physics\_IRigidBody\_osu\_Framework\_Physics\_IRigidBody\_osuTK\_Vector2\_osuTK\_Vector2\_), 
[TransformableExtensions.Delay<IRigidBody\>\(IRigidBody, double, params TransformSequence<IRigidBody\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IRigidBody\>\(IRigidBody\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[RigidBodyExtensions.ImpulseDenominator\(IRigidBody, Vector2, Vector2\)](osu.Framework.Physics.RigidBodyExtensions.md\#osu\_Framework\_Physics\_RigidBodyExtensions\_ImpulseDenominator\_osu\_Framework\_Physics\_IRigidBody\_osuTK\_Vector2\_osuTK\_Vector2\_), 
[ObjectExtensions.IsNotNull<IRigidBody\>\(IRigidBody\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IRigidBody\>\(IRigidBody\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IRigidBody\>\(IRigidBody, double, int, params TransformSequence<IRigidBody\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IRigidBody\>\(IRigidBody, double, params TransformSequence<IRigidBody\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IRigidBody\>\(IRigidBody, params TransformSequence<IRigidBody\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IRigidBody\>\(IRigidBody, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IRigidBody, TValue\>\(IRigidBody, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IRigidBody, TEasing, TValue\>\(IRigidBody, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IRigidBody\>\(IRigidBody, Transform<TValue, DefaultEasingFunction, IRigidBody\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IRigidBody\>\(IRigidBody, Transform<TValue, TEasing, IRigidBody\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IRigidBody, TValue\>\(IRigidBody, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IRigidBody, TValue, TEasing\>\(IRigidBody, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IRigidBody, TValue\>\(IRigidBody, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IRigidBody, TValue, TEasing\>\(IRigidBody, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IRigidBody\>\(IRigidBody, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IRigidBody, TChild\>\(IRigidBody, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IRigidBody, TChild\>\(IRigidBody, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IRigidBody, TChild\>\(IRigidBody, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IRigidBody\>\(IRigidBody\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Physics_IRigidBody_AngularMomentum"></a> AngularMomentum

```csharp
float AngularMomentum { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_AngularVelocity"></a> AngularVelocity

```csharp
float AngularVelocity { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_Centre"></a> Centre

```csharp
Vector2 Centre { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Physics_IRigidBody_FrictionCoefficient"></a> FrictionCoefficient

How much friction happens between objects.

```csharp
float FrictionCoefficient { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_Mass"></a> Mass

```csharp
float Mass { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_MomentOfInertia"></a> MomentOfInertia

```csharp
float MomentOfInertia { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_Momentum"></a> Momentum

```csharp
Vector2 Momentum { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Physics_IRigidBody_Restitution"></a> Restitution

Controls how elastic the material is. A value of 1 means perfect elasticity
(kinetic energy is fully preserved). A value of 0 means all energy is absorbed
on collision, i.e. no rebound occurs at all.

```csharp
float Restitution { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_RotationRadians"></a> RotationRadians

```csharp
float RotationRadians { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_Simulation"></a> Simulation

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which is currently performing a simulation on this <xref href="osu.Framework.Physics.IRigidBody" data-throw-if-not-resolved="false"></xref>.

```csharp
Drawable Simulation { get; set; }
```

#### Property Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Physics_IRigidBody_Velocity"></a> Velocity

```csharp
Vector2 Velocity { get; }
```

#### Property Value

 Vector2

## Methods

### <a id="osu_Framework_Physics_IRigidBody_ApplyImpulse_osuTK_Vector2_osuTK_Vector2_"></a> ApplyImpulse\(Vector2, Vector2\)

Applies a given impulse attacking at a given position.

```csharp
void ApplyImpulse(Vector2 impulse, Vector2 pos)
```

#### Parameters

`impulse` Vector2

`pos` Vector2

### <a id="osu_Framework_Physics_IRigidBody_ApplyState"></a> ApplyState\(\)

Applies the positional and rotational state of this rigid body to its source.

```csharp
void ApplyState()
```

### <a id="osu_Framework_Physics_IRigidBody_BodyContains_osuTK_Vector2_"></a> BodyContains\(Vector2\)

Whether the given screen-space position is contained within the rigid body.

```csharp
bool BodyContains(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Physics_IRigidBody_CheckAndHandleCollisionWith_osu_Framework_Physics_IRigidBody_"></a> CheckAndHandleCollisionWith\(IRigidBody\)

Checks for and records all collisions with another body. If collisions were found,
their aggregate is handled.

```csharp
bool CheckAndHandleCollisionWith(IRigidBody other)
```

#### Parameters

`other` [IRigidBody](osu.Framework.Physics.IRigidBody.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Physics_IRigidBody_Integrate_osuTK_Vector2_System_Single_System_Single_"></a> Integrate\(Vector2, float, float\)

Performs an integration step over time. More precisely, updates the
physical state as dependent on time according to the forces and torques
acting on this body.

```csharp
void Integrate(Vector2 force, float torque, float dt)
```

#### Parameters

`force` Vector2

`torque` [float](https://learn.microsoft.com/dotnet/api/system.single)

`dt` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Physics_IRigidBody_ReadState"></a> ReadState\(\)

Reads the positional and rotational state of this rigid body from its source.

```csharp
void ReadState()
```

### <a id="osu_Framework_Physics_IRigidBody_VelocityAt_osuTK_Vector2_"></a> VelocityAt\(Vector2\)

Total velocity at a given location. Includes angular velocity.

```csharp
Vector2 VelocityAt(Vector2 pos)
```

#### Parameters

`pos` Vector2

#### Returns

 Vector2

