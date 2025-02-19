# <a id="osu_Framework_Statistics_GlobalStatistic_1"></a> Class GlobalStatistic<T\>

Namespace: [osu.Framework.Statistics](osu.Framework.Statistics.md)  
Assembly: osu.Framework.dll  

```csharp
public class GlobalStatistic<T> : IGlobalStatistic
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GlobalStatistic<T\>](osu.Framework.Statistics.GlobalStatistic\-1.md)

#### Implements

[IGlobalStatistic](osu.Framework.Statistics.IGlobalStatistic.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GlobalStatistic<T\>\>\(GlobalStatistic<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GlobalStatistic<T\>\>\(GlobalStatistic<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GlobalStatistic<T\>\>\(GlobalStatistic<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GlobalStatistic<T\>\>\(GlobalStatistic<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GlobalStatistic<T\>, TChild\>\(GlobalStatistic<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GlobalStatistic<T\>, TChild\>\(GlobalStatistic<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GlobalStatistic<T\>, TChild\>\(GlobalStatistic<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GlobalStatistic<T\>\>\(GlobalStatistic<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Statistics_GlobalStatistic_1__ctor_System_String_System_String_"></a> GlobalStatistic\(string, string\)

```csharp
public GlobalStatistic(string group, string name)
```

#### Parameters

`group` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_Statistics_GlobalStatistic_1_DisplayValue"></a> DisplayValue

Human readable value.

```csharp
public string DisplayValue { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Statistics_GlobalStatistic_1_Group"></a> Group

Statistic's visual grouping.

```csharp
public string Group { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Statistics_GlobalStatistic_1_Name"></a> Name

Statistic's identifier.

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Statistics_GlobalStatistic_1_Value"></a> Value

```csharp
public T Value { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Statistics_GlobalStatistic_1_Clear"></a> Clear\(\)

Clear the value of this statistic.

```csharp
public virtual void Clear()
```

