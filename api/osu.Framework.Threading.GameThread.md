# <a id="osu_Framework_Threading_GameThread"></a> Class GameThread

Namespace: [osu.Framework.Threading](osu.Framework.Threading.md)  
Assembly: osu.Framework.dll  

A conceptual thread used for running game work. May or may not be backed by a native thread.

```csharp
public class GameThread
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameThread](osu.Framework.Threading.GameThread.md)

#### Derived

[AudioThread](osu.Framework.Threading.AudioThread.md), 
[DrawThread](osu.Framework.Threading.DrawThread.md), 
[InputThread](osu.Framework.Threading.InputThread.md), 
[UpdateThread](osu.Framework.Threading.UpdateThread.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GameThread\>\(GameThread?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GameThread\>\(GameThread\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GameThread\>\(GameThread\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GameThread\>\(GameThread\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GameThread, TChild\>\(GameThread, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GameThread, TChild\>\(GameThread, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GameThread, TChild\>\(GameThread, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GameThread\>\(GameThread\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Threading_GameThread_IsActive"></a> IsActive

Whether the game is active (in the foreground).

```csharp
public readonly IBindable<bool> IsActive
```

#### Field Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Threading_GameThread_Name"></a> Name

The name of this thread.

```csharp
public readonly string Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Threading_GameThread_UnhandledException"></a> UnhandledException

Attach a handler to delegate responsibility for per-frame exceptions.
While attached, all exceptions will be caught and forwarded. Thread execution will continue indefinitely.

```csharp
public EventHandler<UnhandledExceptionEventArgs>? UnhandledException
```

#### Field Value

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-1)<[UnhandledExceptionEventArgs](https://learn.microsoft.com/dotnet/api/system.unhandledexceptioneventargs)\>?

## Properties

### <a id="osu_Framework_Threading_GameThread_ActiveHz"></a> ActiveHz

The target number of updates per second when the game window is active.

```csharp
public double ActiveHz { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A value of 0 is treated the same as "unlimited" or <xref href="System.Double.MaxValue" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Threading_GameThread_Clock"></a> Clock

The thread's clock. Responsible for timekeeping and throttling.

```csharp
public ThrottledFrameClock Clock { get; }
```

#### Property Value

 [ThrottledFrameClock](osu.Framework.Timing.ThrottledFrameClock.md)

### <a id="osu_Framework_Threading_GameThread_CurrentCulture"></a> CurrentCulture

The culture of this thread.

```csharp
public CultureInfo? CurrentCulture { get; set; }
```

#### Property Value

 [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)?

### <a id="osu_Framework_Threading_GameThread_Exited"></a> Exited

Whether this thread is exited.

```csharp
public bool Exited { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_GameThread_InactiveHz"></a> InactiveHz

The target number of updates per second when the game window is inactive.

```csharp
public double InactiveHz { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A value of 0 is treated the same as "unlimited" or <xref href="System.Double.MaxValue" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Threading_GameThread_IsCurrent"></a> IsCurrent

Whether currently executing on this thread (from the point of invocation).

```csharp
public virtual bool IsCurrent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_GameThread_Running"></a> Running

Whether this thread is currently running.

```csharp
public bool Running { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Threading_GameThread_Scheduler"></a> Scheduler

The thread's scheduler.

```csharp
public Scheduler Scheduler { get; }
```

#### Property Value

 [Scheduler](osu.Framework.Threading.Scheduler.md)

### <a id="osu_Framework_Threading_GameThread_State"></a> State

The current state of this thread.

```csharp
public IBindable<GameThreadState> State { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[GameThreadState](osu.Framework.Threading.GameThreadState.md)\>

### <a id="osu_Framework_Threading_GameThread_SynchronizationContext"></a> SynchronizationContext

A synchronisation context which posts to this thread.

```csharp
public SynchronizationContext SynchronizationContext { get; }
```

#### Property Value

 [SynchronizationContext](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext)

### <a id="osu_Framework_Threading_GameThread_Thread"></a> Thread

The current dedicated OS thread for this <xref href="osu.Framework.Threading.GameThread" data-throw-if-not-resolved="false"></xref>.
A value of <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> does not necessarily mean that this thread is not running;
in <xref href="osu.Framework.Platform.ExecutionMode.SingleThread" data-throw-if-not-resolved="false"></xref> execution mode <xref href="osu.Framework.Platform.ThreadRunner" data-throw-if-not-resolved="false"></xref> drives its <xref href="osu.Framework.Threading.GameThread" data-throw-if-not-resolved="false"></xref>s
manually and sequentially on the main OS thread of the game process.

```csharp
public Thread? Thread { get; }
```

#### Property Value

 [Thread](https://learn.microsoft.com/dotnet/api/system.threading.thread)?

## Methods

### <a id="osu_Framework_Threading_GameThread_Exit"></a> Exit\(\)

Request that this thread is exited.

```csharp
public void Exit()
```

#### Remarks

This does not block and will only queue an exit request, which is processed in the main frame loop.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to exit from an invalid state.

### <a id="osu_Framework_Threading_GameThread_OnExit"></a> OnExit\(\)

Called when the thread is exited. Should clean up any thread-specific resources.

```csharp
protected virtual void OnExit()
```

### <a id="osu_Framework_Threading_GameThread_OnInitialize"></a> OnInitialize\(\)

Called whenever the thread is initialised. Should prepare the thread for performing work.

```csharp
protected virtual void OnInitialize()
```

### <a id="osu_Framework_Threading_GameThread_OnSuspended"></a> OnSuspended\(\)

Called when a <xref href="osu.Framework.Threading.GameThread.Pause" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Threading.GameThread.Exit" data-throw-if-not-resolved="false"></xref> is requested on this <xref href="osu.Framework.Threading.GameThread" data-throw-if-not-resolved="false"></xref>.
Use this method to release exclusive resources that the thread could have been holding in its current execution mode,
like GL contexts or similar.

```csharp
protected virtual void OnSuspended()
```

### <a id="osu_Framework_Threading_GameThread_PrepareForWork"></a> PrepareForWork\(\)

Prepares this game thread for work. Should block until <xref href="osu.Framework.Threading.GameThread.Initialize(System.Boolean)" data-throw-if-not-resolved="false"></xref> has been run.

```csharp
protected virtual void PrepareForWork()
```

### <a id="osu_Framework_Threading_GameThread_Start"></a> Start\(\)

Start this thread.

```csharp
public void Start()
```

#### Remarks

This method blocks until in a running state.

### <a id="osu_Framework_Threading_GameThread_SuffixedThreadNameFor_System_String_"></a> SuffixedThreadNameFor\(string\)

Returns a string representation that is suffixed with a game thread identifier.

```csharp
public static string SuffixedThreadNameFor(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The content to suffix.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A suffixed string.

### <a id="osu_Framework_Threading_GameThread_WaitUntilInitialized"></a> WaitUntilInitialized\(\)

Block until this thread has entered an initialised state.

```csharp
public void WaitUntilInitialized()
```

### <a id="osu_Framework_Threading_GameThread_OnNewFrame"></a> OnNewFrame

The main work which is fired on each frame.

```csharp
protected event Action? OnNewFrame
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

