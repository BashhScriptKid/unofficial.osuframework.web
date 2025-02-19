# <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence"></a> Class BenchmarkBeginAbsoluteSequence

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
[MemoryDiagnoser(true)]
public class BenchmarkBeginAbsoluteSequence : GameBenchmark
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameBenchmark](osu.Framework.Benchmarks.GameBenchmark.md) ← 
[BenchmarkBeginAbsoluteSequence](osu.Framework.Benchmarks.BenchmarkBeginAbsoluteSequence.md)

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

[ObjectExtensions.AsNonNull<BenchmarkBeginAbsoluteSequence\>\(BenchmarkBeginAbsoluteSequence?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkBeginAbsoluteSequence\>\(BenchmarkBeginAbsoluteSequence\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkBeginAbsoluteSequence\>\(BenchmarkBeginAbsoluteSequence\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkBeginAbsoluteSequence\>\(BenchmarkBeginAbsoluteSequence\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkBeginAbsoluteSequence, TChild\>\(BenchmarkBeginAbsoluteSequence, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkBeginAbsoluteSequence, TChild\>\(BenchmarkBeginAbsoluteSequence, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkBeginAbsoluteSequence, TChild\>\(BenchmarkBeginAbsoluteSequence, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkBeginAbsoluteSequence\>\(BenchmarkBeginAbsoluteSequence\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_CreateGame"></a> CreateGame\(\)

Creates the game.

```csharp
protected override Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_NonRecursive"></a> NonRecursive\(\)

```csharp
[Test]
[Benchmark(20, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkBeginAbsoluteSequence.cs")]
public void NonRecursive()
```

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_Recursive"></a> Recursive\(\)

```csharp
[Test]
[Benchmark(34, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkBeginAbsoluteSequence.cs")]
public void Recursive()
```

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_SlightlyNestedNonRecursive"></a> SlightlyNestedNonRecursive\(\)

```csharp
[Test]
[Benchmark(48, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkBeginAbsoluteSequence.cs")]
public void SlightlyNestedNonRecursive()
```

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_SlightlyNestedRecursive"></a> SlightlyNestedRecursive\(\)

```csharp
[Test]
[Benchmark(62, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkBeginAbsoluteSequence.cs")]
public void SlightlyNestedRecursive()
```

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_VeryNestedNonRecursive"></a> VeryNestedNonRecursive\(\)

```csharp
[Test]
[Benchmark(76, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkBeginAbsoluteSequence.cs")]
public void VeryNestedNonRecursive()
```

### <a id="osu_Framework_Benchmarks_BenchmarkBeginAbsoluteSequence_VeryNestedRecursive"></a> VeryNestedRecursive\(\)

```csharp
[Test]
[Benchmark(90, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkBeginAbsoluteSequence.cs")]
public void VeryNestedRecursive()
```

