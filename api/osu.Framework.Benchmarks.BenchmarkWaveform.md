# <a id="osu_Framework_Benchmarks_BenchmarkWaveform"></a> Class BenchmarkWaveform

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
[MemoryDiagnoser(true)]
public class BenchmarkWaveform : BenchmarkTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkTest](osu.Framework.Benchmarks.BenchmarkTest.md) ← 
[BenchmarkWaveform](osu.Framework.Benchmarks.BenchmarkWaveform.md)

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

[ObjectExtensions.AsNonNull<BenchmarkWaveform\>\(BenchmarkWaveform?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkWaveform\>\(BenchmarkWaveform\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkWaveform\>\(BenchmarkWaveform\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkWaveform\>\(BenchmarkWaveform\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkWaveform, TChild\>\(BenchmarkWaveform, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkWaveform, TChild\>\(BenchmarkWaveform, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkWaveform, TChild\>\(BenchmarkWaveform, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkWaveform\>\(BenchmarkWaveform\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkWaveform_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWaveform_TestCreate"></a> TestCreate\(\)

```csharp
[Benchmark(39, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWaveform.cs")]
[Test]
public Task TestCreate()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Benchmarks_BenchmarkWaveform_TestResample_System_Int32_"></a> TestResample\(int\)

```csharp
[Arguments(new object[] { 1024 })]
[TestCase(1024)]
[Arguments(new object[] { 32768 })]
[TestCase(32768)]
[Benchmark(53, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWaveform.cs")]
public Task TestResample(int size)
```

#### Parameters

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

