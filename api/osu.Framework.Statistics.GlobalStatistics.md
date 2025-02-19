# <a id="osu_Framework_Statistics_GlobalStatistics"></a> Class GlobalStatistics

Namespace: [osu.Framework.Statistics](osu.Framework.Statistics.md)  
Assembly: osu.Framework.dll  

A store that can be used to track application-wide statistics and monitor runtime components.

```csharp
public static class GlobalStatistics
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GlobalStatistics](osu.Framework.Statistics.GlobalStatistics.md)

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

### <a id="osu_Framework_Statistics_GlobalStatistics_Clear_System_String_"></a> Clear\(string\)

Clear all statistics.

```csharp
public static void Clear(string group = null)
```

#### Parameters

`group` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional group identifier, limiting the clear operation to the matching group.

### <a id="osu_Framework_Statistics_GlobalStatistics_Get__1_System_String_System_String_"></a> Get<T\>\(string, string\)

Retrieve a <xref href="osu.Framework.Statistics.IGlobalStatistic" data-throw-if-not-resolved="false"></xref> of specified type.
If no matching statistic already exists, a new instance is created and registered automatically.

```csharp
public static GlobalStatistic<T> Get<T>(string group, string name)
```

#### Parameters

`group` [string](https://learn.microsoft.com/dotnet/api/system.string)

The group specification.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name specification.

#### Returns

 [GlobalStatistic](osu.Framework.Statistics.GlobalStatistic\-1.md)<T\>

#### Type Parameters

`T` 

The type.

### <a id="osu_Framework_Statistics_GlobalStatistics_GetStatistics"></a> GetStatistics\(\)

```csharp
public static IGlobalStatistic[] GetStatistics()
```

#### Returns

 [IGlobalStatistic](osu.Framework.Statistics.IGlobalStatistic.md)\[\]

### <a id="osu_Framework_Statistics_GlobalStatistics_OutputToLog"></a> OutputToLog\(\)

```csharp
public static void OutputToLog()
```

### <a id="osu_Framework_Statistics_GlobalStatistics_Remove_osu_Framework_Statistics_IGlobalStatistic_"></a> Remove\(IGlobalStatistic\)

Remove a specific statistic.

```csharp
public static void Remove(IGlobalStatistic statistic)
```

#### Parameters

`statistic` [IGlobalStatistic](osu.Framework.Statistics.IGlobalStatistic.md)

The statistic to remove.

