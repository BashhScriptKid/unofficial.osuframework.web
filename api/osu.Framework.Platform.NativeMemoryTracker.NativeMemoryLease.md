# <a id="osu_Framework_Platform_NativeMemoryTracker_NativeMemoryLease"></a> Class NativeMemoryTracker.NativeMemoryLease

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

A leased on a native memory allocation. Should be disposed when the associated memory is freed.

```csharp
public class NativeMemoryTracker.NativeMemoryLease : InvokeOnDisposal<(object source, long amount)>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvokeOnDisposal<\(object source, long amount\)\>](osu.Framework.Allocation.InvokeOnDisposal\-1.md) ← 
[NativeMemoryTracker.NativeMemoryLease](osu.Framework.Platform.NativeMemoryTracker.NativeMemoryLease.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[InvokeOnDisposal<\(object source, long amount\)\>.Dispose\(\)](osu.Framework.Allocation.InvokeOnDisposal\-1.md\#osu\_Framework\_Allocation\_InvokeOnDisposal\_1\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<NativeMemoryTracker.NativeMemoryLease\>\(NativeMemoryTracker.NativeMemoryLease?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<NativeMemoryTracker.NativeMemoryLease\>\(NativeMemoryTracker.NativeMemoryLease\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<NativeMemoryTracker.NativeMemoryLease\>\(NativeMemoryTracker.NativeMemoryLease\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<NativeMemoryTracker.NativeMemoryLease\>\(NativeMemoryTracker.NativeMemoryLease\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<NativeMemoryTracker.NativeMemoryLease, TChild\>\(NativeMemoryTracker.NativeMemoryLease, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<NativeMemoryTracker.NativeMemoryLease, TChild\>\(NativeMemoryTracker.NativeMemoryLease, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<NativeMemoryTracker.NativeMemoryLease, TChild\>\(NativeMemoryTracker.NativeMemoryLease, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<NativeMemoryTracker.NativeMemoryLease\>\(NativeMemoryTracker.NativeMemoryLease\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Platform_NativeMemoryTracker_NativeMemoryLease_Dispose"></a> Dispose\(\)

Disposes this instance, calling the initially captured action.

```csharp
public override void Dispose()
```

