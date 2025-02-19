# <a id="osu_Framework_Audio_Callbacks_SyncCallback"></a> Class SyncCallback

Namespace: [osu.Framework.Audio.Callbacks](osu.Framework.Audio.Callbacks.md)  
Assembly: osu.Framework.dll  

Wrapper on <xref href="ManagedBass.SyncProcedure" data-throw-if-not-resolved="false"></xref> to provide functionality in <xref href="osu.Framework.Audio.Callbacks.BassCallback" data-throw-if-not-resolved="false"></xref>.

```csharp
public class SyncCallback : BassCallback, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BassCallback](osu.Framework.Audio.Callbacks.BassCallback.md) ← 
[SyncCallback](osu.Framework.Audio.Callbacks.SyncCallback.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[BassCallback.Handle](osu.Framework.Audio.Callbacks.BassCallback.md\#osu\_Framework\_Audio\_Callbacks\_BassCallback\_Handle), 
[BassCallback.Dispose\(bool\)](osu.Framework.Audio.Callbacks.BassCallback.md\#osu\_Framework\_Audio\_Callbacks\_BassCallback\_Dispose\_System\_Boolean\_), 
[BassCallback.Dispose\(\)](osu.Framework.Audio.Callbacks.BassCallback.md\#osu\_Framework\_Audio\_Callbacks\_BassCallback\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SyncCallback\>\(SyncCallback?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SyncCallback\>\(SyncCallback\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SyncCallback\>\(SyncCallback\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SyncCallback\>\(SyncCallback\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SyncCallback, TChild\>\(SyncCallback, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SyncCallback, TChild\>\(SyncCallback, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SyncCallback, TChild\>\(SyncCallback, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SyncCallback\>\(SyncCallback\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Callbacks_SyncCallback__ctor_ManagedBass_SyncProcedure_"></a> SyncCallback\(SyncProcedure\)

```csharp
public SyncCallback(SyncProcedure proc)
```

#### Parameters

`proc` SyncProcedure

## Fields

### <a id="osu_Framework_Audio_Callbacks_SyncCallback_Sync"></a> Sync

```csharp
public readonly SyncProcedure Sync
```

#### Field Value

 SyncProcedure

## Properties

### <a id="osu_Framework_Audio_Callbacks_SyncCallback_Callback"></a> Callback

```csharp
public SyncProcedure Callback { get; }
```

#### Property Value

 SyncProcedure

