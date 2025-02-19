# <a id="osu_Framework_Audio_Callbacks_BassCallback"></a> Class BassCallback

Namespace: [osu.Framework.Audio.Callbacks](osu.Framework.Audio.Callbacks.md)  
Assembly: osu.Framework.dll  

Abstract class that provides an optional pinned <xref href="osu.Framework.Allocation.ObjectHandle%601" data-throw-if-not-resolved="false"></xref>, used for callbacks to
the Bass library.

```csharp
public abstract class BassCallback : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BassCallback](osu.Framework.Audio.Callbacks.BassCallback.md)

#### Derived

[FileCallbacks](osu.Framework.Audio.Callbacks.FileCallbacks.md), 
[SyncCallback](osu.Framework.Audio.Callbacks.SyncCallback.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BassCallback\>\(BassCallback?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BassCallback\>\(BassCallback\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BassCallback\>\(BassCallback\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BassCallback\>\(BassCallback\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BassCallback, TChild\>\(BassCallback, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BassCallback, TChild\>\(BassCallback, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BassCallback, TChild\>\(BassCallback, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BassCallback\>\(BassCallback\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Callbacks_BassCallback__ctor"></a> BassCallback\(\)

```csharp
protected BassCallback()
```

## Properties

### <a id="osu_Framework_Audio_Callbacks_BassCallback_Handle"></a> Handle

The callback handle, or <xref href="System.IntPtr.Zero" data-throw-if-not-resolved="false"></xref> if the object is not pinned.

```csharp
public nint Handle { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

## Methods

### <a id="osu_Framework_Audio_Callbacks_BassCallback_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Callbacks_BassCallback_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Audio_Callbacks_BassCallback_Finalize"></a> \~BassCallback\(\)

```csharp
protected ~BassCallback()
```

