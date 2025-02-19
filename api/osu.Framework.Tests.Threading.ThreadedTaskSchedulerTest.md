# <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest"></a> Class ThreadedTaskSchedulerTest

Namespace: [osu.Framework.Tests.Threading](osu.Framework.Tests.Threading.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class ThreadedTaskSchedulerTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ThreadedTaskSchedulerTest](osu.Framework.Tests.Threading.ThreadedTaskSchedulerTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ThreadedTaskSchedulerTest\>\(ThreadedTaskSchedulerTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ThreadedTaskSchedulerTest\>\(ThreadedTaskSchedulerTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ThreadedTaskSchedulerTest\>\(ThreadedTaskSchedulerTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ThreadedTaskSchedulerTest\>\(ThreadedTaskSchedulerTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ThreadedTaskSchedulerTest, TChild\>\(ThreadedTaskSchedulerTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ThreadedTaskSchedulerTest, TChild\>\(ThreadedTaskSchedulerTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ThreadedTaskSchedulerTest, TChild\>\(ThreadedTaskSchedulerTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ThreadedTaskSchedulerTest\>\(ThreadedTaskSchedulerTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureEventualDisposalWithStuckTasks"></a> EnsureEventualDisposalWithStuckTasks\(\)

```csharp
[Test]
public void EnsureEventualDisposalWithStuckTasks()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureEventualDisposalWithStuckTasks"></a> EnsureEventualDisposalWithStuckTasks\(\)

```csharp
[Test]
public void EnsureEventualDisposalWithStuckTasks()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureEventualDisposalWithStuckTasks"></a> EnsureEventualDisposalWithStuckTasks\(\)

```csharp
[Test]
public void EnsureEventualDisposalWithStuckTasks()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureScheduledTaskReturnsOnDisposal"></a> EnsureScheduledTaskReturnsOnDisposal\(\)

```csharp
[Test]
public void EnsureScheduledTaskReturnsOnDisposal()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureScheduledTaskReturnsOnDisposal"></a> EnsureScheduledTaskReturnsOnDisposal\(\)

```csharp
[Test]
public void EnsureScheduledTaskReturnsOnDisposal()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureScheduledTaskReturnsOnDisposal"></a> EnsureScheduledTaskReturnsOnDisposal\(\)

```csharp
[Test]
public void EnsureScheduledTaskReturnsOnDisposal()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureThreadedTaskSchedulerProcessesBeforeDispose"></a> EnsureThreadedTaskSchedulerProcessesBeforeDispose\(\)

On disposal, <xref href="osu.Framework.Threading.ThreadedTaskScheduler" data-throw-if-not-resolved="false"></xref> does a blocking shutdown sequence.
This asserts all outstanding tasks are run before the shutdown completes.

```csharp
[Test]
public void EnsureThreadedTaskSchedulerProcessesBeforeDispose()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureThreadedTaskSchedulerProcessesBeforeDispose"></a> EnsureThreadedTaskSchedulerProcessesBeforeDispose\(\)

On disposal, <xref href="osu.Framework.Threading.ThreadedTaskScheduler" data-throw-if-not-resolved="false"></xref> does a blocking shutdown sequence.
This asserts all outstanding tasks are run before the shutdown completes.

```csharp
[Test]
public void EnsureThreadedTaskSchedulerProcessesBeforeDispose()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_EnsureThreadedTaskSchedulerProcessesBeforeDispose"></a> EnsureThreadedTaskSchedulerProcessesBeforeDispose\(\)

On disposal, <xref href="osu.Framework.Threading.ThreadedTaskScheduler" data-throw-if-not-resolved="false"></xref> does a blocking shutdown sequence.
This asserts all outstanding tasks are run before the shutdown completes.

```csharp
[Test]
public void EnsureThreadedTaskSchedulerProcessesBeforeDispose()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_QueueAndDisposeStressTest"></a> QueueAndDisposeStressTest\(\)

```csharp
[Test]
[Repeat(1000)]
public void QueueAndDisposeStressTest()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_QueueAndDisposeStressTest"></a> QueueAndDisposeStressTest\(\)

```csharp
[Test]
[Repeat(1000)]
public void QueueAndDisposeStressTest()
```

### <a id="osu_Framework_Tests_Threading_ThreadedTaskSchedulerTest_QueueAndDisposeStressTest"></a> QueueAndDisposeStressTest\(\)

```csharp
[Test]
[Repeat(1000)]
public void QueueAndDisposeStressTest()
```

