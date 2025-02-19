# <a id="osu_Framework_Platform_ThreadRunner"></a> Class ThreadRunner

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Runs a game host in a specific threading mode.

```csharp
public class ThreadRunner
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ThreadRunner](osu.Framework.Platform.ThreadRunner.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ThreadRunner\>\(ThreadRunner?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ThreadRunner\>\(ThreadRunner\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ThreadRunner\>\(ThreadRunner\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ThreadRunner\>\(ThreadRunner\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ThreadRunner, TChild\>\(ThreadRunner, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ThreadRunner, TChild\>\(ThreadRunner, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ThreadRunner, TChild\>\(ThreadRunner, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ThreadRunner\>\(ThreadRunner\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_ThreadRunner__ctor_osu_Framework_Threading_InputThread_"></a> ThreadRunner\(InputThread\)

Construct a new ThreadRunner instance.

```csharp
public ThreadRunner(InputThread mainThread)
```

#### Parameters

`mainThread` [InputThread](osu.Framework.Threading.InputThread.md)

The main window thread. Used for input in multi-threaded execution; all game logic in single-threaded execution.

#### Exceptions

 [NotImplementedException](https://learn.microsoft.com/dotnet/api/system.notimplementedexception)

## Properties

### <a id="osu_Framework_Platform_ThreadRunner_ExecutionMode"></a> ExecutionMode

```csharp
public ExecutionMode ExecutionMode { set; }
```

#### Property Value

 [ExecutionMode](osu.Framework.Platform.ExecutionMode.md)

### <a id="osu_Framework_Platform_ThreadRunner_MaximumInactiveHz"></a> MaximumInactiveHz

```csharp
public double MaximumInactiveHz { set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Platform_ThreadRunner_MaximumUpdateHz"></a> MaximumUpdateHz

```csharp
public double MaximumUpdateHz { set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Platform_ThreadRunner_Threads"></a> Threads

```csharp
public IReadOnlyCollection<GameThread> Threads { get; }
```

#### Property Value

 [IReadOnlyCollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1)<[GameThread](osu.Framework.Threading.GameThread.md)\>

## Methods

### <a id="osu_Framework_Platform_ThreadRunner_AddThread_osu_Framework_Threading_GameThread_"></a> AddThread\(GameThread\)

Add a new non-main thread. In single-threaded execution, threads will be executed in the order they are added.

```csharp
public void AddThread(GameThread thread)
```

#### Parameters

`thread` [GameThread](osu.Framework.Threading.GameThread.md)

### <a id="osu_Framework_Platform_ThreadRunner_RemoveThread_osu_Framework_Threading_GameThread_"></a> RemoveThread\(GameThread\)

Remove a non-main thread.

```csharp
public void RemoveThread(GameThread thread)
```

#### Parameters

`thread` [GameThread](osu.Framework.Threading.GameThread.md)

### <a id="osu_Framework_Platform_ThreadRunner_RunMainLoop"></a> RunMainLoop\(\)

```csharp
public virtual void RunMainLoop()
```

### <a id="osu_Framework_Platform_ThreadRunner_SetCulture_System_Globalization_CultureInfo_"></a> SetCulture\(CultureInfo\)

Sets the current culture of all threads to the supplied <code class="paramref">culture</code>.

```csharp
public void SetCulture(CultureInfo culture)
```

#### Parameters

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

### <a id="osu_Framework_Platform_ThreadRunner_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="osu_Framework_Platform_ThreadRunner_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

### <a id="osu_Framework_Platform_ThreadRunner_Suspend"></a> Suspend\(\)

```csharp
public void Suspend()
```

