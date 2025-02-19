# <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer"></a> Class BenchmarkDependencyContainer

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkDependencyContainer : GameBenchmark
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameBenchmark](osu.Framework.Benchmarks.GameBenchmark.md) ← 
[BenchmarkDependencyContainer](osu.Framework.Benchmarks.BenchmarkDependencyContainer.md)

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

[ObjectExtensions.AsNonNull<BenchmarkDependencyContainer\>\(BenchmarkDependencyContainer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkDependencyContainer\>\(BenchmarkDependencyContainer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkDependencyContainer\>\(BenchmarkDependencyContainer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkDependencyContainer\>\(BenchmarkDependencyContainer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkDependencyContainer, TChild\>\(BenchmarkDependencyContainer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkDependencyContainer, TChild\>\(BenchmarkDependencyContainer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkDependencyContainer, TChild\>\(BenchmarkDependencyContainer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkDependencyContainer\>\(BenchmarkDependencyContainer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer_CreateGame"></a> CreateGame\(\)

Creates the game.

```csharp
protected override Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer_Get"></a> Get\(\)

```csharp
[Test]
[Benchmark(39, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDependencyContainer.cs")]
public void Get()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer_GetNullable"></a> GetNullable\(\)

```csharp
[Test]
[Benchmark(43, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDependencyContainer.cs")]
public void GetNullable()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer_InjectBdl"></a> InjectBdl\(\)

```csharp
[Test]
[Benchmark(47, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDependencyContainer.cs")]
public void InjectBdl()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer_InjectCached"></a> InjectCached\(\)

```csharp
[Test]
[Benchmark(51, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDependencyContainer.cs")]
public void InjectCached()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDependencyContainer_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

