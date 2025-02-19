# <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations"></a> Class BenchmarkCompositeDrawableAllocations

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkCompositeDrawableAllocations : GameBenchmark
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameBenchmark](osu.Framework.Benchmarks.GameBenchmark.md) ← 
[BenchmarkCompositeDrawableAllocations](osu.Framework.Benchmarks.BenchmarkCompositeDrawableAllocations.md)

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

[ObjectExtensions.AsNonNull<BenchmarkCompositeDrawableAllocations\>\(BenchmarkCompositeDrawableAllocations?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkCompositeDrawableAllocations\>\(BenchmarkCompositeDrawableAllocations\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkCompositeDrawableAllocations\>\(BenchmarkCompositeDrawableAllocations\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkCompositeDrawableAllocations\>\(BenchmarkCompositeDrawableAllocations\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkCompositeDrawableAllocations, TChild\>\(BenchmarkCompositeDrawableAllocations, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkCompositeDrawableAllocations, TChild\>\(BenchmarkCompositeDrawableAllocations, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkCompositeDrawableAllocations, TChild\>\(BenchmarkCompositeDrawableAllocations, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkCompositeDrawableAllocations\>\(BenchmarkCompositeDrawableAllocations\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations_CreateGame"></a> CreateGame\(\)

Creates the game.

```csharp
protected override Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations_TestAllocContainer"></a> TestAllocContainer\(\)

```csharp
[Test]
[Benchmark(25, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkCompositeDrawableAllocations.cs")]
public void TestAllocContainer()
```

### <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations_TestAllocSprite"></a> TestAllocSprite\(\)

```csharp
[Test]
[Benchmark(41, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkCompositeDrawableAllocations.cs")]
public void TestAllocSprite()
```

### <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations_TestEmptyGameLoop"></a> TestEmptyGameLoop\(\)

```csharp
[Test]
[Benchmark(17, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkCompositeDrawableAllocations.cs")]
public void TestEmptyGameLoop()
```

### <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations_TestLoadedContainer"></a> TestLoadedContainer\(\)

```csharp
[Test]
[Benchmark(33, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkCompositeDrawableAllocations.cs")]
public void TestLoadedContainer()
```

### <a id="osu_Framework_Benchmarks_BenchmarkCompositeDrawableAllocations_TestLoadedSprite"></a> TestLoadedSprite\(\)

```csharp
[Test]
[Benchmark(49, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkCompositeDrawableAllocations.cs")]
public void TestLoadedSprite()
```

