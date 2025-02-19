# <a id="osu_Framework_Benchmarks_BenchmarkPiecewiseLinearToBezier"></a> Class BenchmarkPiecewiseLinearToBezier

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkPiecewiseLinearToBezier : BenchmarkTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkTest](osu.Framework.Benchmarks.BenchmarkTest.md) ← 
[BenchmarkPiecewiseLinearToBezier](osu.Framework.Benchmarks.BenchmarkPiecewiseLinearToBezier.md)

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

[ObjectExtensions.AsNonNull<BenchmarkPiecewiseLinearToBezier\>\(BenchmarkPiecewiseLinearToBezier?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkPiecewiseLinearToBezier\>\(BenchmarkPiecewiseLinearToBezier\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkPiecewiseLinearToBezier\>\(BenchmarkPiecewiseLinearToBezier\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkPiecewiseLinearToBezier\>\(BenchmarkPiecewiseLinearToBezier\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkPiecewiseLinearToBezier, TChild\>\(BenchmarkPiecewiseLinearToBezier, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkPiecewiseLinearToBezier, TChild\>\(BenchmarkPiecewiseLinearToBezier, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkPiecewiseLinearToBezier, TChild\>\(BenchmarkPiecewiseLinearToBezier, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkPiecewiseLinearToBezier\>\(BenchmarkPiecewiseLinearToBezier\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Benchmarks_BenchmarkPiecewiseLinearToBezier_MaxIterations"></a> MaxIterations

```csharp
[Params(new object[] { 0, 100, 200 })]
public int MaxIterations
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkPiecewiseLinearToBezier_NumControlPoints"></a> NumControlPoints

```csharp
[Params(new object[] { 5, 25 })]
public int NumControlPoints
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkPiecewiseLinearToBezier_NumTestPoints"></a> NumTestPoints

```csharp
[Params(new object[] { 5, 200 })]
public int NumTestPoints
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkPiecewiseLinearToBezier_PiecewiseLinearToBezier"></a> PiecewiseLinearToBezier\(\)

```csharp
[Benchmark(37, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkPiecewiseLinearToBezier.cs")]
public List<Vector2> PiecewiseLinearToBezier()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

### <a id="osu_Framework_Benchmarks_BenchmarkPiecewiseLinearToBezier_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

