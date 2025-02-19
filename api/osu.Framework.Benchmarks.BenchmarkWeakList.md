# <a id="osu_Framework_Benchmarks_BenchmarkWeakList"></a> Class BenchmarkWeakList

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkWeakList : BenchmarkTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkTest](osu.Framework.Benchmarks.BenchmarkTest.md) ← 
[BenchmarkWeakList](osu.Framework.Benchmarks.BenchmarkWeakList.md)

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

[ObjectExtensions.AsNonNull<BenchmarkWeakList\>\(BenchmarkWeakList?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkWeakList\>\(BenchmarkWeakList\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkWeakList\>\(BenchmarkWeakList\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkWeakList\>\(BenchmarkWeakList\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkWeakList, TChild\>\(BenchmarkWeakList, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkWeakList, TChild\>\(BenchmarkWeakList, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkWeakList, TChild\>\(BenchmarkWeakList, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkWeakList\>\(BenchmarkWeakList\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_ItemCount"></a> ItemCount

```csharp
[Params(new object[] { 1, 10, 100, 1000 })]
public int ItemCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_Add"></a> Add\(\)

```csharp
[Benchmark(25, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs", Baseline = true)]
public void Add()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_AddAndEnumerate"></a> AddAndEnumerate\(\)

```csharp
[Benchmark(78, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public object[] AddAndEnumerate()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_Clear"></a> Clear\(\)

```csharp
[Benchmark(62, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void Clear()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_ClearAndEnumerate"></a> ClearAndEnumerate\(\)

```csharp
[Benchmark(86, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public object[] ClearAndEnumerate()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_Contains"></a> Contains\(\)

```csharp
[Benchmark(70, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public bool Contains()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_ManyAddsAndRemoveFromEndWithNoEnumeration"></a> ManyAddsAndRemoveFromEndWithNoEnumeration\(\)

```csharp
[Benchmark(113, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void ManyAddsAndRemoveFromEndWithNoEnumeration()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_ManyAddsAndRemoveFromMiddleWithNoEnumeration"></a> ManyAddsAndRemoveFromMiddleWithNoEnumeration\(\)

```csharp
[Benchmark(131, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void ManyAddsAndRemoveFromMiddleWithNoEnumeration()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_ManyAddsAndRemoveFromStartWithNoEnumeration"></a> ManyAddsAndRemoveFromStartWithNoEnumeration\(\)

```csharp
[Benchmark(95, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void ManyAddsAndRemoveFromStartWithNoEnumeration()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_RemoveAllIteratively"></a> RemoveAllIteratively\(\)

```csharp
[Benchmark(36, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void RemoveAllIteratively()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_RemoveAllStaggered"></a> RemoveAllStaggered\(\)

```csharp
[Benchmark(45, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void RemoveAllStaggered()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_RemoveOne"></a> RemoveOne\(\)

```csharp
[Benchmark(28, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkWeakList.cs")]
public void RemoveOne()
```

### <a id="osu_Framework_Benchmarks_BenchmarkWeakList_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

