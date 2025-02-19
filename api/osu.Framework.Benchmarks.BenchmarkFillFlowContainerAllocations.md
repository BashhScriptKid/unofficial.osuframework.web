# <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations"></a> Class BenchmarkFillFlowContainerAllocations

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkFillFlowContainerAllocations : GameBenchmark
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameBenchmark](osu.Framework.Benchmarks.GameBenchmark.md) ← 
[BenchmarkFillFlowContainerAllocations](osu.Framework.Benchmarks.BenchmarkFillFlowContainerAllocations.md)

#### Inherited Members

[GameBenchmark.Game](osu.Framework.Benchmarks.GameBenchmark.md\#osu\_Framework\_Benchmarks\_GameBenchmark\_Game), 
[GameBenchmark.SetUp\(\)](osu.Framework.Benchmarks.GameBenchmark.md\#osu\_Framework\_Benchmarks\_GameBenchmark\_SetUp), 
[GameBenchmark.TearDown\(\)](osu.Framework.Benchmarks.GameBenchmark.md\#osu\_Framework\_Benchmarks\_GameBenchmark\_TearDown), 
[GameBenchmark.RunSingleFrame\(\)](osu.Framework.Benchmarks.GameBenchmark.md\#osu\_Framework\_Benchmarks\_GameBenchmark\_RunSingleFrame), 
[GameBenchmark.CreateGame\(\)](osu.Framework.Benchmarks.GameBenchmark.md\#osu\_Framework\_Benchmarks\_GameBenchmark\_CreateGame), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BenchmarkFillFlowContainerAllocations\>\(BenchmarkFillFlowContainerAllocations?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkFillFlowContainerAllocations\>\(BenchmarkFillFlowContainerAllocations\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkFillFlowContainerAllocations\>\(BenchmarkFillFlowContainerAllocations\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkFillFlowContainerAllocations\>\(BenchmarkFillFlowContainerAllocations\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkFillFlowContainerAllocations, TChild\>\(BenchmarkFillFlowContainerAllocations, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkFillFlowContainerAllocations, TChild\>\(BenchmarkFillFlowContainerAllocations, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkFillFlowContainerAllocations, TChild\>\(BenchmarkFillFlowContainerAllocations, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkFillFlowContainerAllocations\>\(BenchmarkFillFlowContainerAllocations\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_CreateGame"></a> CreateGame\(\)

Creates the game.

```csharp
protected override Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_MultipleComputeLayoutPositions"></a> MultipleComputeLayoutPositions\(\)

```csharp
[Benchmark(17, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFillFlowContainerAllocations.cs")]
public void MultipleComputeLayoutPositions()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_MultiplePerformLayout"></a> MultiplePerformLayout\(\)

```csharp
[Benchmark(46, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFillFlowContainerAllocations.cs")]
public void MultiplePerformLayout()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_MultipleWholeLayout"></a> MultipleWholeLayout\(\)

```csharp
[Benchmark(32, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFillFlowContainerAllocations.cs")]
public void MultipleWholeLayout()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_SingleComputeLayoutPositions"></a> SingleComputeLayoutPositions\(\)

```csharp
[Benchmark(26, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFillFlowContainerAllocations.cs")]
public void SingleComputeLayoutPositions()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_SinglePerformLayout"></a> SinglePerformLayout\(\)

```csharp
[Benchmark(55, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFillFlowContainerAllocations.cs")]
public void SinglePerformLayout()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFillFlowContainerAllocations_SingleWholeLayout"></a> SingleWholeLayout\(\)

```csharp
[Benchmark(39, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFillFlowContainerAllocations.cs")]
public void SingleWholeLayout()
```

