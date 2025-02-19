# <a id="osu_Framework_Threading_ScheduledDelegate"></a> Class ScheduledDelegate

Namespace: [osu.Framework.Threading](osu.Framework.Threading.md)  
Assembly: osu.Framework.dll  

```csharp
public class ScheduledDelegate : IComparable<ScheduledDelegate>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

#### Implements

[IComparable<ScheduledDelegate\>](https://learn.microsoft.com/dotnet/api/system.icomparable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ScheduledDelegate\>\(ScheduledDelegate?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ScheduledDelegate\>\(ScheduledDelegate\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ScheduledDelegate\>\(ScheduledDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ScheduledDelegate\>\(ScheduledDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ScheduledDelegate, TChild\>\(ScheduledDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ScheduledDelegate, TChild\>\(ScheduledDelegate, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ScheduledDelegate, TChild\>\(ScheduledDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ScheduledDelegate\>\(ScheduledDelegate\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Threading_ScheduledDelegate__ctor_System_Action_System_Double_System_Double_"></a> ScheduledDelegate\(Action, double, double\)

```csharp
public ScheduledDelegate(Action task, double executionTime = 0, double repeatInterval = -1)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action)

`executionTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`repeatInterval` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Threading_ScheduledDelegate__ctor_System_Double_System_Double_"></a> ScheduledDelegate\(double, double\)

```csharp
protected ScheduledDelegate(double executionTime = 0, double repeatInterval = -1)
```

#### Parameters

`executionTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`repeatInterval` [double](https://learn.microsoft.com/dotnet/api/system.double)

## Fields

### <a id="osu_Framework_Threading_ScheduledDelegate_PerformRepeatCatchUpExecutions"></a> PerformRepeatCatchUpExecutions

In the case of a repeating execution, setting this to true will allow the delegate to run more than once at already elapsed points in time in order to catch up to current.
This will ensure a consistent number of runs over real-time, even if the <xref href="osu.Framework.Threading.Scheduler" data-throw-if-not-resolved="false"></xref> running the delegate is suspended.
Setting to false will skip catch-up executions, ensuring a future time is used after each execution.

```csharp
public bool PerformRepeatCatchUpExecutions
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_ScheduledDelegate_RepeatInterval"></a> RepeatInterval

Time in milliseconds between repeats of this task. -1 means no repeats.

```csharp
public readonly double RepeatInterval
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Properties

### <a id="osu_Framework_Threading_ScheduledDelegate_Cancelled"></a> Cancelled

Whether this task has been cancelled.

```csharp
public bool Cancelled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_ScheduledDelegate_Completed"></a> Completed

Whether this task has finished running.

```csharp
public bool Completed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_ScheduledDelegate_ExecutionTime"></a> ExecutionTime

The earliest ElapsedTime value at which this task will be executed via a <xref href="osu.Framework.Threading.Scheduler" data-throw-if-not-resolved="false"></xref>.

```csharp
public double ExecutionTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Threading_ScheduledDelegate_State"></a> State

```csharp
public ScheduledDelegate.RunState State { get; }
```

#### Property Value

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md).[RunState](osu.Framework.Threading.ScheduledDelegate.RunState.md)

## Methods

### <a id="osu_Framework_Threading_ScheduledDelegate_Cancel"></a> Cancel\(\)

Cancel a task.

```csharp
public void Cancel()
```

#### Remarks

This call may block if the task is currently being run on another thread.

### <a id="osu_Framework_Threading_ScheduledDelegate_CompareTo_osu_Framework_Threading_ScheduledDelegate_"></a> CompareTo\(ScheduledDelegate?\)

Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.

```csharp
public int CompareTo(ScheduledDelegate? other)
```

#### Parameters

`other` [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)?

An object to compare with this instance.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A value that indicates the relative order of the objects being compared. The return value has these meanings:  

 <table><thead><tr><th class="term"> Value</th><th class="description"> Meaning</th></tr></thead><tbody><tr><td class="term"> Less than zero</td><td class="description"> This instance precedes <code class="paramref">other</code> in the sort order.</td></tr><tr><td class="term"> Zero</td><td class="description"> This instance occurs in the same position in the sort order as <code class="paramref">other</code>.</td></tr><tr><td class="term"> Greater than zero</td><td class="description"> This instance follows <code class="paramref">other</code> in the sort order.</td></tr></tbody></table>

### <a id="osu_Framework_Threading_ScheduledDelegate_InvokeTask"></a> InvokeTask\(\)

```csharp
protected virtual void InvokeTask()
```

### <a id="osu_Framework_Threading_ScheduledDelegate_RunTask"></a> RunTask\(\)

Invokes the scheduled task.

```csharp
public void RunTask()
```

#### Remarks

This call may block if the task is currently being run on another thread.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to run a task that has been cancelled or already completed.

### <a id="osu_Framework_Threading_ScheduledDelegate_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

