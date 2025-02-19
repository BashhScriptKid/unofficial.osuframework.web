# <a id="osu_Framework_Graphics_Transforms_Transformable"></a> Class Transformable

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

A type of object which can have <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s operating upon it.
An implementer of this class must call <xref href="osu.Framework.Graphics.Transforms.Transformable.UpdateTransforms" data-throw-if-not-resolved="false"></xref> to
update and apply its <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

```csharp
public abstract class Transformable : ITransformable, IDependencyInjectionCandidate, ISourceGeneratedDependencyActivator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md)

#### Derived

[Drawable](osu.Framework.Graphics.Drawable.md)

#### Implements

[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[TransformableExtensions.Animate<Transformable\>\(Transformable, params TransformSequence<Transformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<Transformable\>\(Transformable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<Transformable\>\(Transformable, double, params TransformSequence<Transformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<Transformable\>\(Transformable\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Transformable\>\(Transformable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Transformable\>\(Transformable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Transformable\>\(Transformable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<Transformable\>\(Transformable, double, int, params TransformSequence<Transformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<Transformable\>\(Transformable, double, params TransformSequence<Transformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<Transformable\>\(Transformable, params TransformSequence<Transformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<Transformable\>\(Transformable, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<Transformable, TValue\>\(Transformable, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<Transformable, TEasing, TValue\>\(Transformable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, Transformable\>\(Transformable, Transform<TValue, DefaultEasingFunction, Transformable\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, Transformable\>\(Transformable, Transform<TValue, TEasing, Transformable\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<Transformable, TValue\>\(Transformable, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<Transformable, TValue, TEasing\>\(Transformable, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<Transformable, TValue\>\(Transformable, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<Transformable, TValue, TEasing\>\(Transformable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<Transformable\>\(Transformable, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<Transformable, TChild\>\(Transformable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Transformable, TChild\>\(Transformable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Transformable, TChild\>\(Transformable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Transformable\>\(Transformable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Transforms_Transformable_Clock"></a> Clock

The clock that is used to provide the timing for this object's <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

```csharp
public abstract IFrameBasedClock Clock { get; set; }
```

#### Property Value

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

### <a id="osu_Framework_Graphics_Transforms_Transformable_LatestTransformEndTime"></a> LatestTransformEndTime

The end time in milliseconds of the latest transform enqueued for this <xref href="osu.Framework.Graphics.Transforms.Transformable" data-throw-if-not-resolved="false"></xref>.
Will return the current time value if no transforms are present.

```csharp
public double LatestTransformEndTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transformable_RemoveCompletedTransforms"></a> RemoveCompletedTransforms

Whether to remove completed transforms from the list of applicable transforms. Setting this to false allows for rewinding transforms.

```csharp
public virtual bool RemoveCompletedTransforms { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Transforms_Transformable_Time"></a> Time

The current frame's time as observed by this class's <xref href="osu.Framework.Graphics.Transforms.Transformable.Clock" data-throw-if-not-resolved="false"></xref>.

```csharp
public FrameTimeInfo Time { get; }
```

#### Property Value

 [FrameTimeInfo](osu.Framework.Timing.FrameTimeInfo.md)

### <a id="osu_Framework_Graphics_Transforms_Transformable_TransformDelay"></a> TransformDelay

Delay from the current time until new <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s are started, in milliseconds.

```csharp
protected double TransformDelay { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transformable_TransformStartTime"></a> TransformStartTime

The starting time to use for new <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

```csharp
public double TransformStartTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transformable_Transforms"></a> Transforms

A lazily-initialized list of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s applied to this object.

```csharp
public IEnumerable<Transform> Transforms { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Transform](osu.Framework.Graphics.Transforms.Transform.md)\>

## Methods

### <a id="osu_Framework_Graphics_Transforms_Transformable_AddTransform_osu_Framework_Graphics_Transforms_Transform_System_Nullable_System_UInt64__"></a> AddTransform\(Transform, ulong?\)

Adds to this object a <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> which was previously populated using this object via
<xref href="osu.Framework.Graphics.TransformableExtensions.PopulateTransform%60%603(%60%602%2cosu.Framework.Graphics.Transforms.Transform%7b%60%600%2c%60%601%2c%60%602%7d%2c%60%600%2cSystem.Double%2c%60%601%40)" data-throw-if-not-resolved="false"></xref>.
Added <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s are immediately applied, and therefore have an immediate effect on this object if the current time of this
object falls within <xref href="osu.Framework.Graphics.Transforms.Transform.StartTime" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Transforms.Transform.EndTime" data-throw-if-not-resolved="false"></xref>.
If <xref href="osu.Framework.Graphics.Transforms.Transformable.Clock" data-throw-if-not-resolved="false"></xref> is null, e.g. because this object has just been constructed, then the given transform will be finished instantaneously.

```csharp
public void AddTransform(Transform transform, ulong? customTransformID = null)
```

#### Parameters

`transform` [Transform](osu.Framework.Graphics.Transforms.Transform.md)

The <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> to be added.

`customTransformID` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)?

When not null, the <xref href="osu.Framework.Graphics.Transforms.Transform.TransformID" data-throw-if-not-resolved="false"></xref> to assign for ordering.

### <a id="osu_Framework_Graphics_Transforms_Transformable_ApplyTransformsAt_System_Double_System_Boolean_"></a> ApplyTransformsAt\(double, bool\)

Applies <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s at a point in time. This may only be called if <xref href="osu.Framework.Graphics.Transforms.Transformable.RemoveCompletedTransforms" data-throw-if-not-resolved="false"></xref> is set to false.
<p>
This does not change the clock time.
</p>

```csharp
public virtual void ApplyTransformsAt(double time, bool propagateChildren = false)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time to apply <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s at.

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to also apply children's <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s at <code class="paramref">time</code>.

### <a id="osu_Framework_Graphics_Transforms_Transformable_BeginAbsoluteSequence_System_Double_System_Boolean_"></a> BeginAbsoluteSequence\(double, bool\)

Start a sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s from an absolute time value (adjusts <xref href="osu.Framework.Graphics.Transforms.Transformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>).

```csharp
public virtual IDisposable BeginAbsoluteSequence(double newTransformStartTime, bool recursive = true)
```

#### Parameters

`newTransformStartTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The new value for <xref href="osu.Framework.Graphics.Transforms.Transformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>.

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this should be applied to all children. True by default.

#### Returns

 [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

An <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used in a using() statement.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Absolute sequences should never be nested inside another existing sequence.

### <a id="osu_Framework_Graphics_Transforms_Transformable_BeginDelayedSequence_System_Double_System_Boolean_"></a> BeginDelayedSequence\(double, bool\)

Start a sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s with a (cumulative) relative delay applied.

```csharp
public IDisposable BeginDelayedSequence(double delay, bool recursive = true)
```

#### Parameters

`delay` [double](https://learn.microsoft.com/dotnet/api/system.double)

The offset in milliseconds from current time. Note that this stacks with other nested sequences.

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this should be applied to all children. True by default.

#### Returns

 [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

An <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used in a using() statement.

### <a id="osu_Framework_Graphics_Transforms_Transformable_ClearTransforms_System_Boolean_System_String_"></a> ClearTransforms\(bool, string\)

Clears <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

```csharp
public virtual void ClearTransforms(bool propagateChildren = false, string targetMember = null)
```

#### Parameters

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether we also clear the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s of children.

`targetMember` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional <xref href="osu.Framework.Graphics.Transforms.Transform.TargetMember" data-throw-if-not-resolved="false"></xref> name of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s to clear.
Null for clearing all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

### <a id="osu_Framework_Graphics_Transforms_Transformable_ClearTransformsAfter_System_Double_System_Boolean_System_String_"></a> ClearTransformsAfter\(double, bool, string\)

Removes <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s that start after <code class="paramref">time</code>.

```csharp
public virtual void ClearTransformsAfter(double time, bool propagateChildren = false, string targetMember = null)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time to clear <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s after.

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to also clear such <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s of children.

`targetMember` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional <xref href="osu.Framework.Graphics.Transforms.Transform.TargetMember" data-throw-if-not-resolved="false"></xref> name of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s to clear.
Null for clearing all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

### <a id="osu_Framework_Graphics_Transforms_Transformable_FinishTransforms_System_Boolean_System_String_"></a> FinishTransforms\(bool, string\)

Finishes specified <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s, using their <xref href="osu.Framework.Graphics.Transforms.Transform%601.EndValue" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual void FinishTransforms(bool propagateChildren = false, string targetMember = null)
```

#### Parameters

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether we also finish the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s of children.

`targetMember` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional <xref href="osu.Framework.Graphics.Transforms.Transform.TargetMember" data-throw-if-not-resolved="false"></xref> name of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s to finish.
Null for finishing all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

### <a id="osu_Framework_Graphics_Transforms_Transformable_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public virtual void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Graphics_Transforms_Transformable_RemoveTransform_osu_Framework_Graphics_Transforms_Transform_"></a> RemoveTransform\(Transform\)

Removes a <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>.

```csharp
public void RemoveTransform(Transform toRemove)
```

#### Parameters

`toRemove` [Transform](osu.Framework.Graphics.Transforms.Transform.md)

The <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> to remove.

### <a id="osu_Framework_Graphics_Transforms_Transformable_TransformsForTargetMember_System_String_"></a> TransformsForTargetMember\(string\)

Retrieves the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s for a given target member.

```csharp
public IEnumerable<Transform> TransformsForTargetMember(string targetMember)
```

#### Parameters

`targetMember` [string](https://learn.microsoft.com/dotnet/api/system.string)

The target member to find the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s for.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Transform](osu.Framework.Graphics.Transforms.Transform.md)\>

An enumeration over the transforms for the target member.

### <a id="osu_Framework_Graphics_Transforms_Transformable_UpdateTransforms"></a> UpdateTransforms\(\)

Resets <xref href="osu.Framework.Graphics.Transforms.Transformable.TransformDelay" data-throw-if-not-resolved="false"></xref> and processes updates to this class based on loaded <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

```csharp
protected void UpdateTransforms()
```

