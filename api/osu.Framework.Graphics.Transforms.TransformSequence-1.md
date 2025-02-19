# <a id="osu_Framework_Graphics_Transforms_TransformSequence_1"></a> Class TransformSequence<T\>

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

A sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s all operating upon the same <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref>
of type <code class="typeparamref">T</code>.
Exposes various operations to extend the sequence by additional <xref href="osu.Framework.Graphics.Transforms" data-throw-if-not-resolved="false"></xref> such as
delays, loops, continuations, and events.

```csharp
public class TransformSequence<T> : ITransformSequence where T : class, ITransformable
```

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s in this sequence operate upon.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TransformSequence<T\>](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)

#### Implements

[ITransformSequence](osu.Framework.Graphics.Transforms.ITransformSequence.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TransformSequence<T\>\>\(TransformSequence<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TransformSequence<T\>\>\(TransformSequence<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TransformSequence<T\>\>\(TransformSequence<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TransformSequence<T\>\>\(TransformSequence<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformSequenceExtensions.TransformBindableTo<T, TValue\>\(TransformSequence<T\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformSequenceExtensions.md\#osu\_Framework\_Graphics\_TransformSequenceExtensions\_TransformBindableTo\_\_2\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformSequenceExtensions.TransformBindableTo<T, TValue, TEasing\>\(TransformSequence<T\>, Bindable<TValue\>, TValue, double, TEasing\)](osu.Framework.Graphics.TransformSequenceExtensions.md\#osu\_Framework\_Graphics\_TransformSequenceExtensions\_TransformBindableTo\_\_3\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_), 
[ContainerExtensions.WithChild<TransformSequence<T\>, TChild\>\(TransformSequence<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TransformSequence<T\>, TChild\>\(TransformSequence<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TransformSequence<T\>, TChild\>\(TransformSequence<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TransformSequence<T\>\>\(TransformSequence<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1__ctor__0_"></a> TransformSequence\(T\)

Creates a new empty <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> attached to a given <code class="paramref">origin</code>.

```csharp
public TransformSequence(T origin)
```

#### Parameters

`origin` T

The <code class="typeparamref">T</code> to attach the new <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to.

## Methods

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Append_System_Collections_Generic_IEnumerable_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator__"></a> Append\(IEnumerable<Generator\>\)

Appends multiple <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref>s to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Append(IEnumerable<TransformSequence<T>.Generator> childGenerators)
```

#### Parameters

`childGenerators` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\>

The <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref>s to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Append_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator_"></a> Append\(Generator\)

Appends a <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref>s to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
The <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref> is invoked within a <xref href="osu.Framework.Graphics.Transforms.Transformable.BeginAbsoluteSequence(System.Double%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>
such that the generated <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> starts at the correct point in time.
Its <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s are then merged into this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Append(TransformSequence<T>.Generator childGenerator)
```

#### Parameters

`childGenerator` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)

The <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref> to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Append__1_System_Func__0___0____0__"></a> Append<TResult\>\(Func<T, TResult\>, out TResult\)

Invokes <code class="paramref">originFunc</code> inside a <xref href="osu.Framework.Graphics.Transforms.Transformable.BeginAbsoluteSequence(System.Double%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>
such that <xref href="osu.Framework.Graphics.Transforms.ITransformable.TransformStartTime" data-throw-if-not-resolved="false"></xref> is the current time of this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
It is the responsibility of <code class="paramref">originFunc</code> to make appropriate use of <xref href="osu.Framework.Graphics.Transforms.ITransformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Append<TResult>(Func<T, TResult> originFunc, out TResult result)
```

#### Parameters

`originFunc` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<T, TResult\>

The function to be invoked.

`result` TResult

The resulting value of the invocation of <code class="paramref">originFunc</code>.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`TResult` 

The return type of <code class="paramref">originFunc</code>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Append_System_Action__0__"></a> Append\(Action<T\>\)

Invokes <code class="paramref">originAction</code> inside a <xref href="osu.Framework.Graphics.Transforms.Transformable.BeginAbsoluteSequence(System.Double%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>
such that <xref href="osu.Framework.Graphics.Transforms.ITransformable.TransformStartTime" data-throw-if-not-resolved="false"></xref> is the current time of this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
It is the responsibility of <code class="paramref">originAction</code> to make appropriate use of <xref href="osu.Framework.Graphics.Transforms.ITransformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Append(Action<T> originAction)
```

#### Parameters

`originAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The function to be invoked.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Delay_System_Double_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator___"></a> Delay\(double, params Generator\[\]\)

Advances the start time of future appended <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s by <code class="paramref">delay</code> milliseconds.
Then, <code class="paramref">childGenerators</code> are appended via <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Append(System.Collections.Generic.IEnumerable%7bosu.Framework.Graphics.Transforms.TransformSequence%7b%600%7d.Generator%7d)" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Delay(double delay, params TransformSequence<T>.Generator[] childGenerators)
```

#### Parameters

`delay` [double](https://learn.microsoft.com/dotnet/api/system.double)

The delay to advance the start time by.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The optional <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref>s for <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Finally_System_Action__0__"></a> Finally\(Action<T\>\)

Registers a callback <code class="paramref">function</code> which is triggered once any <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> in this
<xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> is aborted or when all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s complete successfully.
This is equivalent with calling both <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.OnComplete(System.Action%7b%600%7d)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.OnAbort(System.Action%7b%600%7d)" data-throw-if-not-resolved="false"></xref>.
Only a single callback function may be registered.

```csharp
public void Finally(Action<T> function)
```

#### Parameters

`function` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The callback function.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Loop_System_Double_System_Int32_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator___"></a> Loop\(double, int, params Generator\[\]\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
All <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s generated by <code class="paramref">childGenerators</code> are appended to
this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> and then repeated <code class="paramref">numIters</code> times
with <code class="paramref">pause</code> milliseconds between iterations.

```csharp
public TransformSequence<T> Loop(double pause, int numIters, params TransformSequence<T>.Generator[] childGenerators)
```

#### Parameters

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

`numIters` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of iterations.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The functions to generate the <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be looped.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Loop_System_Double_System_Int32_"></a> Loop\(double, int\)

Repeats all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s within this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref><code class="paramref">numIters</code> times with <code class="paramref">pause</code> milliseconds between iterations.

```csharp
public TransformSequence<T> Loop(double pause, int numIters)
```

#### Parameters

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

`numIters` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of iterations.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Loop_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator___"></a> Loop\(params Generator\[\]\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
All <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s generated by <code class="paramref">childGenerators</code> are appended to
this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> and then repeated indefinitely.

```csharp
public TransformSequence<T> Loop(params TransformSequence<T>.Generator[] childGenerators)
```

#### Parameters

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The functions to generate the <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be looped.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Loop_System_Double_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator___"></a> Loop\(double, params Generator\[\]\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
All <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s generated by <code class="paramref">childGenerators</code> are appended to
this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> and then repeated indefinitely with <code class="paramref">pause</code>
milliseconds between iterations.

```csharp
public TransformSequence<T> Loop(double pause, params TransformSequence<T>.Generator[] childGenerators)
```

#### Parameters

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The functions to generate the <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be looped.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Loop_System_Double_"></a> Loop\(double\)

Repeats all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s within this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> indefinitely.

```csharp
public TransformSequence<T> Loop(double pause = 0)
```

#### Parameters

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_OnAbort_System_Action__0__"></a> OnAbort\(Action<T\>\)

Registers a callback <code class="paramref">function</code> which is triggered once any <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> in this
<xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> is aborted (e.g. by another <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> overriding it).
Only a single callback function may be registered.

```csharp
public void OnAbort(Action<T> function)
```

#### Parameters

`function` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The callback function.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_OnComplete_System_Action__0__"></a> OnComplete\(Action<T\>\)

Registers a callback <code class="paramref">function</code> which is triggered once all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s in this
<xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> complete successfully.
If all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s already completed successfully at the point of this call, then
<code class="paramref">function</code> is triggered immediately.
Only a single callback function may be registered.

```csharp
public void OnComplete(Action<T> function)
```

#### Parameters

`function` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The callback function.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Then_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator___"></a> Then\(params Generator\[\]\)

Advances the start time of future appended <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to the latest end time of all
<xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s in this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
Then, <code class="paramref">childGenerators</code> are appended via <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Append(System.Collections.Generic.IEnumerable%7bosu.Framework.Graphics.Transforms.TransformSequence%7b%600%7d.Generator%7d)" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Then(params TransformSequence<T>.Generator[] childGenerators)
```

#### Parameters

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The optional <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref>s for <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Then_System_Double_osu_Framework_Graphics_Transforms_TransformSequence__0__Generator___"></a> Then\(double, params Generator\[\]\)

Advances the start time of future appended <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to the latest end time of all
<xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s in this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> plus <code class="paramref">delay</code> milliseconds.
Then, <code class="paramref">childGenerators</code> are appended via <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Append(System.Collections.Generic.IEnumerable%7bosu.Framework.Graphics.Transforms.TransformSequence%7b%600%7d.Generator%7d)" data-throw-if-not-resolved="false"></xref>.

```csharp
public TransformSequence<T> Then(double delay, params TransformSequence<T>.Generator[] childGenerators)
```

#### Parameters

`delay` [double](https://learn.microsoft.com/dotnet/api/system.double)

The delay after the latest end time of all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The optional <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601.Generator" data-throw-if-not-resolved="false"></xref>s for <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_TransformTo__1_System_String___0_System_Double_osu_Framework_Graphics_Easing_"></a> TransformTo<TValue\>\(string, TValue, double, Easing\)

```csharp
public TransformSequence<T> TransformTo<TValue>(string propertyOrFieldName, TValue newValue, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`propertyOrFieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`newValue` TValue

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`TValue` 

