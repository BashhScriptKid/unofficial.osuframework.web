# <a id="osu_Framework_Benchmarks_BenchmarkScheduler"></a> Class BenchmarkScheduler

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkScheduler : BenchmarkTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkTest](osu.Framework.Benchmarks.BenchmarkTest.md) ← 
[BenchmarkScheduler](osu.Framework.Benchmarks.BenchmarkScheduler.md)

#### Inherited Members

[BenchmarkTest.SetUp\(\)](osu.Framework.Benchmarks.BenchmarkTest.md\#osu\_Framework\_Benchmarks\_BenchmarkTest\_SetUp), 
[BenchmarkTest.RunBenchmark\(\)](osu.Framework.Benchmarks.BenchmarkTest.md\#osu\_Framework\_Benchmarks\_BenchmarkTest\_RunBenchmark), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BenchmarkScheduler\>\(BenchmarkScheduler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkScheduler\>\(BenchmarkScheduler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkScheduler\>\(BenchmarkScheduler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkScheduler\>\(BenchmarkScheduler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkScheduler, TChild\>\(BenchmarkScheduler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkScheduler, TChild\>\(BenchmarkScheduler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkScheduler, TChild\>\(BenchmarkScheduler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkScheduler\>\(BenchmarkScheduler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkScheduler_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

### <a id="osu_Framework_Benchmarks_BenchmarkScheduler_UpdateEmptyScheduler"></a> UpdateEmptyScheduler\(\)

```csharp
[Benchmark(29, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkScheduler.cs")]
public void UpdateEmptyScheduler()
```

### <a id="osu_Framework_Benchmarks_BenchmarkScheduler_UpdateSchedulerWithEveryUpdate"></a> UpdateSchedulerWithEveryUpdate\(\)

```csharp
[Benchmark(43, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkScheduler.cs")]
public void UpdateSchedulerWithEveryUpdate()
```

### <a id="osu_Framework_Benchmarks_BenchmarkScheduler_UpdateSchedulerWithManyAdded"></a> UpdateSchedulerWithManyAdded\(\)

```csharp
[Benchmark(50, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkScheduler.cs")]
public void UpdateSchedulerWithManyAdded()
```

### <a id="osu_Framework_Benchmarks_BenchmarkScheduler_UpdateSchedulerWithManyDelayed"></a> UpdateSchedulerWithManyDelayed\(\)

```csharp
[Benchmark(36, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkScheduler.cs")]
public void UpdateSchedulerWithManyDelayed()
```

