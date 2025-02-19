# <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager"></a> Class LifetimeEntryManager

Namespace: [osu.Framework.Graphics.Performance](osu.Framework.Graphics.Performance.md)  
Assembly: osu.Framework.dll  

Provides time-optimised updates for lifetime change notifications.
This is used in specialised <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>s to optimise lifetime changes (see: <xref href="osu.Framework.Graphics.Containers.LifetimeManagementContainer" data-throw-if-not-resolved="false"></xref>).

```csharp
public class LifetimeEntryManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LifetimeEntryManager](osu.Framework.Graphics.Performance.LifetimeEntryManager.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LifetimeEntryManager\>\(LifetimeEntryManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LifetimeEntryManager\>\(LifetimeEntryManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LifetimeEntryManager\>\(LifetimeEntryManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LifetimeEntryManager\>\(LifetimeEntryManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LifetimeEntryManager, TChild\>\(LifetimeEntryManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LifetimeEntryManager, TChild\>\(LifetimeEntryManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LifetimeEntryManager, TChild\>\(LifetimeEntryManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LifetimeEntryManager\>\(LifetimeEntryManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

The time complexity of updating lifetimes is O(number of alive items).

## Methods

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_AddEntry_osu_Framework_Graphics_Performance_LifetimeEntry_"></a> AddEntry\(LifetimeEntry\)

Adds an entry.

```csharp
public void AddEntry(LifetimeEntry entry)
```

#### Parameters

`entry` [LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md)

The <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> to add.

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_ClearEntries"></a> ClearEntries\(\)

Removes all entries.

```csharp
public void ClearEntries()
```

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_RemoveEntry_osu_Framework_Graphics_Performance_LifetimeEntry_"></a> RemoveEntry\(LifetimeEntry\)

Removes an entry.

```csharp
public bool RemoveEntry(LifetimeEntry entry)
```

#### Parameters

`entry` [LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md)

The <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> to remove.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">entry</code> was contained by this <xref href="osu.Framework.Graphics.Performance.LifetimeEntryManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_Update_System_Double_"></a> Update\(double\)

Updates the lifetime of entries at a single time value.

```csharp
public bool Update(double time)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time to update at.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the state of any entries changed.

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_Update_System_Double_System_Double_"></a> Update\(double, double\)

Updates the lifetime of entries within a given time range.

```csharp
public bool Update(double startTime, double endTime)
```

#### Parameters

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The start of the time range.

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The end of the time range.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the state of any entries changed.

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_EntryBecameAlive"></a> EntryBecameAlive

Invoked immediately when a <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> becomes alive.

```csharp
public event Action<LifetimeEntry> EntryBecameAlive
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md)\>

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_EntryBecameDead"></a> EntryBecameDead

Invoked immediately when a <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> becomes dead.

```csharp
public event Action<LifetimeEntry> EntryBecameDead
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md)\>

### <a id="osu_Framework_Graphics_Performance_LifetimeEntryManager_EntryCrossedBoundary"></a> EntryCrossedBoundary

Invoked when a <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> crosses a lifetime boundary.

```csharp
public event Action<LifetimeEntry, LifetimeBoundaryKind, LifetimeBoundaryCrossingDirection> EntryCrossedBoundary
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-3)<[LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md), [LifetimeBoundaryKind](osu.Framework.Graphics.Performance.LifetimeBoundaryKind.md), [LifetimeBoundaryCrossingDirection](osu.Framework.Graphics.Performance.LifetimeBoundaryCrossingDirection.md)\>

