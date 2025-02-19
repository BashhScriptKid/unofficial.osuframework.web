# <a id="osu_Framework_Statistics_IGlobalStatistic"></a> Interface IGlobalStatistic

Namespace: [osu.Framework.Statistics](osu.Framework.Statistics.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IGlobalStatistic
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IGlobalStatistic\>\(IGlobalStatistic?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IGlobalStatistic\>\(IGlobalStatistic\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IGlobalStatistic\>\(IGlobalStatistic\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IGlobalStatistic\>\(IGlobalStatistic\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IGlobalStatistic, TChild\>\(IGlobalStatistic, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IGlobalStatistic, TChild\>\(IGlobalStatistic, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IGlobalStatistic, TChild\>\(IGlobalStatistic, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IGlobalStatistic\>\(IGlobalStatistic\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Statistics_IGlobalStatistic_DisplayValue"></a> DisplayValue

Human readable value.

```csharp
string DisplayValue { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Statistics_IGlobalStatistic_Group"></a> Group

Statistic's visual grouping.

```csharp
string Group { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Statistics_IGlobalStatistic_Name"></a> Name

Statistic's identifier.

```csharp
string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Statistics_IGlobalStatistic_Clear"></a> Clear\(\)

Clear the value of this statistic.

```csharp
void Clear()
```

