# <a id="osu_Framework_Threading_ThreadedTaskScheduler"></a> Class ThreadedTaskScheduler

Namespace: [osu.Framework.Threading](osu.Framework.Threading.md)  
Assembly: osu.Framework.dll  

Provides a scheduler that uses a managed thread "pool".

```csharp
public sealed class ThreadedTaskScheduler : TaskScheduler, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TaskScheduler](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler) ← 
[ThreadedTaskScheduler](osu.Framework.Threading.ThreadedTaskScheduler.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[TaskScheduler.FromCurrentSynchronizationContext\(\)](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler.fromcurrentsynchronizationcontext), 
[TaskScheduler.Current](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler.current), 
[TaskScheduler.Default](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler.default), 
[TaskScheduler.Id](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler.id), 
[TaskScheduler.MaximumConcurrencyLevel](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler.maximumconcurrencylevel), 
[TaskScheduler.UnobservedTaskException](https://learn.microsoft.com/dotnet/api/system.threading.tasks.taskscheduler.unobservedtaskexception), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ThreadedTaskScheduler\>\(ThreadedTaskScheduler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ThreadedTaskScheduler\>\(ThreadedTaskScheduler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ThreadedTaskScheduler\>\(ThreadedTaskScheduler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ThreadedTaskScheduler\>\(ThreadedTaskScheduler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ThreadedTaskScheduler, TChild\>\(ThreadedTaskScheduler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ThreadedTaskScheduler, TChild\>\(ThreadedTaskScheduler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ThreadedTaskScheduler, TChild\>\(ThreadedTaskScheduler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ThreadedTaskScheduler\>\(ThreadedTaskScheduler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Threading_ThreadedTaskScheduler__ctor_System_Int32_System_String_"></a> ThreadedTaskScheduler\(int, string\)

Initializes a new instance of the StaTaskScheduler class with the specified concurrency level.

```csharp
public ThreadedTaskScheduler(int numberOfThreads, string name)
```

#### Parameters

`numberOfThreads` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of threads that should be created and used by this scheduler.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The thread name to give threads in this pool.

## Properties

### <a id="osu_Framework_Threading_ThreadedTaskScheduler_MaximumConcurrencyLevel"></a> MaximumConcurrencyLevel

Gets the maximum concurrency level supported by this scheduler.

```csharp
public override int MaximumConcurrencyLevel { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Threading_ThreadedTaskScheduler_Dispose"></a> Dispose\(\)

Cleans up the scheduler by indicating that no more tasks will be queued.
This method blocks until all threads successfully shutdown.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Threading_ThreadedTaskScheduler_GetScheduledTasks"></a> GetScheduledTasks\(\)

Provides a list of the scheduled tasks for the debugger to consume.

```csharp
protected override IEnumerable<Task> GetScheduledTasks()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)\>

An enumerable of all tasks currently scheduled.

### <a id="osu_Framework_Threading_ThreadedTaskScheduler_GetStatusString"></a> GetStatusString\(\)

```csharp
public string GetStatusString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Threading_ThreadedTaskScheduler_QueueTask_System_Threading_Tasks_Task_"></a> QueueTask\(Task\)

Queues a Task to be executed by this scheduler.

```csharp
protected override void QueueTask(Task task)
```

#### Parameters

`task` [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

The task to be executed.

### <a id="osu_Framework_Threading_ThreadedTaskScheduler_TryExecuteTaskInline_System_Threading_Tasks_Task_System_Boolean_"></a> TryExecuteTaskInline\(Task, bool\)

Determines whether a Task may be inlined.

```csharp
protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
```

#### Parameters

`task` [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

The task to be executed.

`taskWasPreviouslyQueued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the task was previously queued.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

true if the task was successfully inlined; otherwise, false.

