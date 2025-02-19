# <a id="osu_Framework_Benchmarks_BenchmarkTest"></a> Class BenchmarkTest

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
[TestFixture]
[MemoryDiagnoser(true)]
public abstract class BenchmarkTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkTest](osu.Framework.Benchmarks.BenchmarkTest.md)

#### Derived

[BenchmarkFontLoading](osu.Framework.Benchmarks.BenchmarkFontLoading.md), 
[BenchmarkInterpolation](osu.Framework.Benchmarks.BenchmarkInterpolation.md), 
[BenchmarkPiecewiseLinearToBezier](osu.Framework.Benchmarks.BenchmarkPiecewiseLinearToBezier.md), 
[BenchmarkSRGBColourMultiplication](osu.Framework.Benchmarks.BenchmarkSRGBColourMultiplication.md), 
[BenchmarkScheduler](osu.Framework.Benchmarks.BenchmarkScheduler.md), 
[BenchmarkTransform](osu.Framework.Benchmarks.BenchmarkTransform.md), 
[BenchmarkTransformUpdate](osu.Framework.Benchmarks.BenchmarkTransformUpdate.md), 
[BenchmarkWaveform](osu.Framework.Benchmarks.BenchmarkWaveform.md), 
[BenchmarkWeakList](osu.Framework.Benchmarks.BenchmarkWeakList.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BenchmarkTest\>\(BenchmarkTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkTest\>\(BenchmarkTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkTest\>\(BenchmarkTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkTest\>\(BenchmarkTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkTest, TChild\>\(BenchmarkTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkTest, TChild\>\(BenchmarkTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkTest, TChild\>\(BenchmarkTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkTest\>\(BenchmarkTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkTest_RunBenchmark"></a> RunBenchmark\(\)

```csharp
[Test]
public void RunBenchmark()
```

### <a id="osu_Framework_Benchmarks_BenchmarkTest_SetUp"></a> SetUp\(\)

```csharp
[GlobalSetup]
[OneTimeSetUp]
public virtual void SetUp()
```

