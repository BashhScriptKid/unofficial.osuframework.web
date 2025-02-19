# <a id="osu_Framework_Threading_InputThread"></a> Class InputThread

Namespace: [osu.Framework.Threading](osu.Framework.Threading.md)  
Assembly: osu.Framework.dll  

```csharp
public class InputThread : GameThread
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameThread](osu.Framework.Threading.GameThread.md) ← 
[InputThread](osu.Framework.Threading.InputThread.md)

#### Inherited Members

[GameThread.Name](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Name), 
[GameThread.IsActive](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_IsActive), 
[GameThread.State](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_State), 
[GameThread.Running](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Running), 
[GameThread.Exited](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Exited), 
[GameThread.IsCurrent](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_IsCurrent), 
[GameThread.Clock](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Clock), 
[GameThread.Thread](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Thread), 
[GameThread.Scheduler](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Scheduler), 
[GameThread.UnhandledException](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_UnhandledException), 
[GameThread.SynchronizationContext](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_SynchronizationContext), 
[GameThread.CurrentCulture](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_CurrentCulture), 
[GameThread.ActiveHz](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_ActiveHz), 
[GameThread.InactiveHz](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_InactiveHz), 
[GameThread.OnNewFrame](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_OnNewFrame), 
[GameThread.WaitUntilInitialized\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_WaitUntilInitialized), 
[GameThread.SuffixedThreadNameFor\(string\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_SuffixedThreadNameFor\_System\_String\_), 
[GameThread.Start\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Start), 
[GameThread.Exit\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_Exit), 
[GameThread.PrepareForWork\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_PrepareForWork), 
[GameThread.OnInitialize\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_OnInitialize), 
[GameThread.OnSuspended\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_OnSuspended), 
[GameThread.OnExit\(\)](osu.Framework.Threading.GameThread.md\#osu\_Framework\_Threading\_GameThread\_OnExit), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<InputThread\>\(InputThread?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InputThread\>\(InputThread\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InputThread\>\(InputThread\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InputThread\>\(InputThread\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InputThread, TChild\>\(InputThread, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InputThread, TChild\>\(InputThread, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InputThread, TChild\>\(InputThread, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InputThread\>\(InputThread\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Threading_InputThread__ctor"></a> InputThread\(\)

```csharp
public InputThread()
```

## Properties

### <a id="osu_Framework_Threading_InputThread_IsCurrent"></a> IsCurrent

Whether currently executing on this thread (from the point of invocation).

```csharp
public override bool IsCurrent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Threading_InputThread_PrepareForWork"></a> PrepareForWork\(\)

Prepares this game thread for work. Should block until <xref href="osu.Framework.Threading.GameThread.Initialize(System.Boolean)" data-throw-if-not-resolved="false"></xref> has been run.

```csharp
protected override void PrepareForWork()
```

