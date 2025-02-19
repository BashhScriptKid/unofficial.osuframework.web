# <a id="osu_Framework_Allocation_TimedExpiryCache_2"></a> Class TimedExpiryCache<TKey, TValue\>

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

A key-value store which supports cleaning up items after a specified expiry time.

```csharp
public class TimedExpiryCache<TKey, TValue> : IDisposable
```

#### Type Parameters

`TKey` 

`TValue` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TimedExpiryCache<TKey, TValue\>](osu.Framework.Allocation.TimedExpiryCache\-2.md)

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

[ObjectExtensions.AsNonNull<TimedExpiryCache<TKey, TValue\>\>\(TimedExpiryCache<TKey, TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TimedExpiryCache<TKey, TValue\>\>\(TimedExpiryCache<TKey, TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TimedExpiryCache<TKey, TValue\>\>\(TimedExpiryCache<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TimedExpiryCache<TKey, TValue\>\>\(TimedExpiryCache<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TimedExpiryCache<TKey, TValue\>, TChild\>\(TimedExpiryCache<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TimedExpiryCache<TKey, TValue\>, TChild\>\(TimedExpiryCache<TKey, TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TimedExpiryCache<TKey, TValue\>, TChild\>\(TimedExpiryCache<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TimedExpiryCache<TKey, TValue\>\>\(TimedExpiryCache<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Allocation_TimedExpiryCache_2__ctor"></a> TimedExpiryCache\(\)

```csharp
public TimedExpiryCache()
```

## Fields

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_CheckPeriod"></a> CheckPeriod

The interval in milliseconds between checks for expiry.

```csharp
public readonly int CheckPeriod
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_DisposeOnRemoval"></a> DisposeOnRemoval

Whether <xref href="System.IDisposable" data-throw-if-not-resolved="false"></xref> items should be disposed on removal.

```csharp
public bool DisposeOnRemoval
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_ExpiryTime"></a> ExpiryTime

Time in milliseconds after last access after which items will be cleaned up.

```csharp
public int ExpiryTime
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_Add__0__1_"></a> Add\(TKey, TValue\)

```csharp
public void Add(TKey key, TValue value)
```

#### Parameters

`key` TKey

`value` TValue

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Allocation_TimedExpiryCache_2_TryGetValue__0__1__"></a> TryGetValue\(TKey, out TValue\)

```csharp
public bool TryGetValue(TKey key, out TValue value)
```

#### Parameters

`key` TKey

`value` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

