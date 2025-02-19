# <a id="osu_Framework_Platform_NativeMemoryTracker"></a> Class NativeMemoryTracker

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Track native memory allocations via <xref href="osu.Framework.Statistics.GlobalStatistics" data-throw-if-not-resolved="false"></xref>.
Also adds memory pressure automatically.

```csharp
public static class NativeMemoryTracker
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NativeMemoryTracker](osu.Framework.Platform.NativeMemoryTracker.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Platform_NativeMemoryTracker_AddMemory_System_Object_System_Int64_"></a> AddMemory\(object, long\)

Add new tracked native memory.

```csharp
public static NativeMemoryTracker.NativeMemoryLease AddMemory(object source, long amount)
```

#### Parameters

`source` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object responsible for this allocation.

`amount` [long](https://learn.microsoft.com/dotnet/api/system.int64)

The number of bytes allocated.

#### Returns

 [NativeMemoryTracker](osu.Framework.Platform.NativeMemoryTracker.md).[NativeMemoryLease](osu.Framework.Platform.NativeMemoryTracker.NativeMemoryLease.md)

A lease which should be disposed when memory is released.

