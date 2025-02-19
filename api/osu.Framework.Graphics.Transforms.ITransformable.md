# <a id="osu_Framework_Graphics_Transforms_ITransformable"></a> Interface ITransformable

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ITransformable
```

#### Extension Methods

[TransformableExtensions.Animate<ITransformable\>\(ITransformable, params TransformSequence<ITransformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<ITransformable\>\(ITransformable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<ITransformable\>\(ITransformable, double, params TransformSequence<ITransformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITransformable\>\(ITransformable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITransformable\>\(ITransformable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITransformable\>\(ITransformable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<ITransformable\>\(ITransformable, double, int, params TransformSequence<ITransformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ITransformable\>\(ITransformable, double, params TransformSequence<ITransformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ITransformable\>\(ITransformable, params TransformSequence<ITransformable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ITransformable\>\(ITransformable, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<ITransformable, TValue\>\(ITransformable, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<ITransformable, TEasing, TValue\>\(ITransformable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, ITransformable\>\(ITransformable, Transform<TValue, DefaultEasingFunction, ITransformable\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, ITransformable\>\(ITransformable, Transform<TValue, TEasing, ITransformable\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<ITransformable, TValue\>\(ITransformable, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<ITransformable, TValue, TEasing\>\(ITransformable, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<ITransformable, TValue\>\(ITransformable, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<ITransformable, TValue, TEasing\>\(ITransformable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<ITransformable\>\(ITransformable, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<ITransformable, TChild\>\(ITransformable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITransformable, TChild\>\(ITransformable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITransformable, TChild\>\(ITransformable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITransformable\>\(ITransformable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Transforms_ITransformable_Time"></a> Time

The current frame's time as observed by this class's <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

```csharp
FrameTimeInfo Time { get; }
```

#### Property Value

 [FrameTimeInfo](osu.Framework.Timing.FrameTimeInfo.md)

### <a id="osu_Framework_Graphics_Transforms_ITransformable_TransformStartTime"></a> TransformStartTime

```csharp
double TransformStartTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Graphics_Transforms_ITransformable_AddTransform_osu_Framework_Graphics_Transforms_Transform_System_Nullable_System_UInt64__"></a> AddTransform\(Transform, ulong?\)

```csharp
void AddTransform(Transform transform, ulong? customTransformID = null)
```

#### Parameters

`transform` [Transform](osu.Framework.Graphics.Transforms.Transform.md)

`customTransformID` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)?

### <a id="osu_Framework_Graphics_Transforms_ITransformable_BeginAbsoluteSequence_System_Double_System_Boolean_"></a> BeginAbsoluteSequence\(double, bool\)

Start a sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s from an absolute time value (adjusts <xref href="osu.Framework.Graphics.Transforms.ITransformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>).

```csharp
IDisposable BeginAbsoluteSequence(double newTransformStartTime, bool recursive = true)
```

#### Parameters

`newTransformStartTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The new value for <xref href="osu.Framework.Graphics.Transforms.ITransformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>.

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this should be applied to all children. True by default.

#### Returns

 [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

An <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used in a using() statement.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Absolute sequences should never be nested inside another existing sequence.

### <a id="osu_Framework_Graphics_Transforms_ITransformable_BeginDelayedSequence_System_Double_System_Boolean_"></a> BeginDelayedSequence\(double, bool\)

Start a sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s with a (cumulative) relative delay applied.

```csharp
IDisposable BeginDelayedSequence(double delay, bool recursive = true)
```

#### Parameters

`delay` [double](https://learn.microsoft.com/dotnet/api/system.double)

The offset in milliseconds from current time. Note that this stacks with other nested sequences.

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this should be applied to all children. True by default.

#### Returns

 [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

An <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used in a using() statement.

### <a id="osu_Framework_Graphics_Transforms_ITransformable_RemoveTransform_osu_Framework_Graphics_Transforms_Transform_"></a> RemoveTransform\(Transform\)

```csharp
void RemoveTransform(Transform toRemove)
```

#### Parameters

`toRemove` [Transform](osu.Framework.Graphics.Transforms.Transform.md)

