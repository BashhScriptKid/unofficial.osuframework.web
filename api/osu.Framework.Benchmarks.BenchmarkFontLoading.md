# <a id="osu_Framework_Benchmarks_BenchmarkFontLoading"></a> Class BenchmarkFontLoading

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkFontLoading : BenchmarkTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkTest](osu.Framework.Benchmarks.BenchmarkTest.md) ← 
[BenchmarkFontLoading](osu.Framework.Benchmarks.BenchmarkFontLoading.md)

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

[ObjectExtensions.AsNonNull<BenchmarkFontLoading\>\(BenchmarkFontLoading?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkFontLoading\>\(BenchmarkFontLoading\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkFontLoading\>\(BenchmarkFontLoading\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkFontLoading\>\(BenchmarkFontLoading\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkFontLoading, TChild\>\(BenchmarkFontLoading, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkFontLoading, TChild\>\(BenchmarkFontLoading, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkFontLoading, TChild\>\(BenchmarkFontLoading, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkFontLoading\>\(BenchmarkFontLoading\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_FetchCount"></a> FetchCount

```csharp
[Params(new object[] { 1, 10, 100, 1000, 10000 })]
public int FetchCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_BenchmarkNoCache"></a> BenchmarkNoCache\(\)

```csharp
[Benchmark(62, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFontLoading.cs")]
public void BenchmarkNoCache()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_BenchmarkRawCaching"></a> BenchmarkRawCaching\(\)

```csharp
[Benchmark(51, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFontLoading.cs", Baseline = true)]
public void BenchmarkRawCaching()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_BenchmarkRawCachingReuse"></a> BenchmarkRawCachingReuse\(\)

```csharp
[Benchmark(41, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFontLoading.cs")]
public void BenchmarkRawCachingReuse()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_BenchmarkTimedExpiry"></a> BenchmarkTimedExpiry\(\)

```csharp
[Benchmark(72, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFontLoading.cs")]
public void BenchmarkTimedExpiry()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_BenchmarkTimedExpiryMemoryPooling"></a> BenchmarkTimedExpiryMemoryPooling\(\)

```csharp
[Benchmark(81, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkFontLoading.cs")]
public void BenchmarkTimedExpiryMemoryPooling()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

### <a id="osu_Framework_Benchmarks_BenchmarkFontLoading_TearDown"></a> TearDown\(\)

```csharp
[OneTimeTearDown]
public void TearDown()
```

