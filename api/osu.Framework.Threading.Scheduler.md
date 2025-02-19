# <a id="osu_Framework_Threading_Scheduler"></a> Class Scheduler

Namespace: [osu.Framework.Threading](osu.Framework.Threading.md)  
Assembly: osu.Framework.dll  

Marshals delegates to run from the Scheduler's base thread in a threadsafe manner

```csharp
public class Scheduler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Scheduler](osu.Framework.Threading.Scheduler.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Scheduler\>\(Scheduler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Scheduler\>\(Scheduler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Scheduler\>\(Scheduler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Scheduler\>\(Scheduler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Scheduler, TChild\>\(Scheduler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Scheduler, TChild\>\(Scheduler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Scheduler, TChild\>\(Scheduler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Scheduler\>\(Scheduler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Threading_Scheduler__ctor"></a> Scheduler\(\)

The base thread is assumed to be the thread on which the constructor is run.

```csharp
public Scheduler()
```

### <a id="osu_Framework_Threading_Scheduler__ctor_System_Func_System_Boolean__osu_Framework_Timing_IClock_"></a> Scheduler\(Func<bool\>?, IClock?\)

The base thread is assumed to be the thread on which the constructor is run.

```csharp
public Scheduler(Func<bool>? isCurrentThread, IClock? clock)
```

#### Parameters

`isCurrentThread` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

`clock` [IClock](osu.Framework.Timing.IClock.md)?

## Properties

### <a id="osu_Framework_Threading_Scheduler_HasPendingTasks"></a> HasPendingTasks

Whether there are any tasks queued to run (including delayed tasks in the future).

```csharp
public bool HasPendingTasks { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_Scheduler_TotalTasksRun"></a> TotalTasksRun

The total tasks this scheduler instance has run.

```csharp
public int TotalTasksRun { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Threading_Scheduler_Add__1_System_Action___0____0_System_Boolean_"></a> Add<T\>\(Action<T\>, T, bool\)

Add a task to be scheduled.

```csharp
public ScheduledDelegate? Add<T>(Action<T> task, T data, bool forceScheduled = true)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The work to be done.

`data` T

The data to be passed to the task.

`forceScheduled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If set to false, the task will be executed immediately if we are on the main thread.

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)?

The scheduled task, or <code>null</code> if the task was executed immediately.

#### Type Parameters

`T` 

#### Remarks

If scheduled, the task will be run on the next <xref href="osu.Framework.Threading.Scheduler.Update" data-throw-if-not-resolved="false"></xref> independent of the current clock time.

### <a id="osu_Framework_Threading_Scheduler_Add_System_Action_System_Boolean_"></a> Add\(Action, bool\)

Add a task to be scheduled.

```csharp
public ScheduledDelegate? Add(Action task, bool forceScheduled = true)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The work to be done.

`forceScheduled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If set to false, the task will be executed immediately if we are on the main thread.

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)?

The scheduled task, or <code>null</code> if the task was executed immediately.

#### Remarks

If scheduled, the task will be run on the next <xref href="osu.Framework.Threading.Scheduler.Update" data-throw-if-not-resolved="false"></xref> independent of the current clock time.

### <a id="osu_Framework_Threading_Scheduler_Add_osu_Framework_Threading_ScheduledDelegate_"></a> Add\(ScheduledDelegate\)

Add a task to be scheduled.

```csharp
public void Add(ScheduledDelegate task)
```

#### Parameters

`task` [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

The scheduled delegate to add.

#### Remarks

The task will be run on the next <xref href="osu.Framework.Threading.Scheduler.Update" data-throw-if-not-resolved="false"></xref> independent of the current clock time.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to add a scheduled delegate that has been already completed.

### <a id="osu_Framework_Threading_Scheduler_AddDelayed__1_System_Action___0____0_System_Double_System_Boolean_"></a> AddDelayed<T\>\(Action<T\>, T, double, bool\)

Add a task which will be run after a specified delay from the current clock time.

```csharp
public ScheduledDelegate AddDelayed<T>(Action<T> task, T data, double timeUntilRun, bool repeat = false)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The work to be done.

`data` T

The data to be passed to the task.

`timeUntilRun` [double](https://learn.microsoft.com/dotnet/api/system.double)

Milliseconds until run.

`repeat` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this task should repeat.

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

Whether this is the first queue attempt of this work.

#### Type Parameters

`T` 

### <a id="osu_Framework_Threading_Scheduler_AddDelayed_System_Action_System_Double_System_Boolean_"></a> AddDelayed\(Action, double, bool\)

Add a task which will be run after a specified delay from the current clock time.

```csharp
public ScheduledDelegate AddDelayed(Action task, double timeUntilRun, bool repeat = false)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The work to be done.

`timeUntilRun` [double](https://learn.microsoft.com/dotnet/api/system.double)

Milliseconds until run.

`repeat` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this task should repeat.

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

The scheduled task.

### <a id="osu_Framework_Threading_Scheduler_AddOnce__1_System_Action___0____0_"></a> AddOnce<T\>\(Action<T\>, T\)

Adds a task which will only be run once per frame, no matter how many times it was scheduled in the previous frame.

```csharp
public bool AddOnce<T>(Action<T> task, T data)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The work to be done.

`data` T

The data to be passed to the task. Note that duplicate schedules may result in previous data never being run.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this is the first queue attempt of this work.

#### Type Parameters

`T` 

#### Remarks

The task will be run on the next <xref href="osu.Framework.Threading.Scheduler.Update" data-throw-if-not-resolved="false"></xref> independent of the current clock time.

### <a id="osu_Framework_Threading_Scheduler_AddOnce_System_Action_"></a> AddOnce\(Action\)

Adds a task which will only be run once per frame, no matter how many times it was scheduled in the previous frame.

```csharp
public bool AddOnce(Action task)
```

#### Parameters

`task` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The work to be done. Avoid using inline delegates as they may not be cached, bypassing the once-per-frame guarantee.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this is the first queue attempt of this work.

#### Remarks

The task will be run on the next <xref href="osu.Framework.Threading.Scheduler.Update" data-throw-if-not-resolved="false"></xref> independent of the current clock time.

### <a id="osu_Framework_Threading_Scheduler_CancelDelayedTasks"></a> CancelDelayedTasks\(\)

Cancel any pending work tasks.

```csharp
public void CancelDelayedTasks()
```

### <a id="osu_Framework_Threading_Scheduler_Update"></a> Update\(\)

Run any pending work tasks.

```csharp
public int Update()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of tasks that were run.

### <a id="osu_Framework_Threading_Scheduler_UpdateClock_osu_Framework_Timing_IClock_"></a> UpdateClock\(IClock\)

```csharp
public void UpdateClock(IClock newClock)
```

#### Parameters

`newClock` [IClock](osu.Framework.Timing.IClock.md)

