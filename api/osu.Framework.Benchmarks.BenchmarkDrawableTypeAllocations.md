# <a id="osu_Framework_Benchmarks_BenchmarkDrawableTypeAllocations"></a> Class BenchmarkDrawableTypeAllocations

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
[MemoryDiagnoser(true)]
public class BenchmarkDrawableTypeAllocations
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkDrawableTypeAllocations](osu.Framework.Benchmarks.BenchmarkDrawableTypeAllocations.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BenchmarkDrawableTypeAllocations\>\(BenchmarkDrawableTypeAllocations?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkDrawableTypeAllocations\>\(BenchmarkDrawableTypeAllocations\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkDrawableTypeAllocations\>\(BenchmarkDrawableTypeAllocations\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkDrawableTypeAllocations\>\(BenchmarkDrawableTypeAllocations\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkDrawableTypeAllocations, TChild\>\(BenchmarkDrawableTypeAllocations, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkDrawableTypeAllocations, TChild\>\(BenchmarkDrawableTypeAllocations, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkDrawableTypeAllocations, TChild\>\(BenchmarkDrawableTypeAllocations, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkDrawableTypeAllocations\>\(BenchmarkDrawableTypeAllocations\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkDrawableTypeAllocations_TestBaseline"></a> TestBaseline\(\)

```csharp
[Test]
[Benchmark(15, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDrawableTypeAllocations.cs")]
public void TestBaseline()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDrawableTypeAllocations_TestCompositeDrawable"></a> TestCompositeDrawable\(\)

```csharp
[Test]
[Benchmark(29, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDrawableTypeAllocations.cs")]
public void TestCompositeDrawable()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDrawableTypeAllocations_TestContainer"></a> TestContainer\(\)

```csharp
[Test]
[Benchmark(36, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDrawableTypeAllocations.cs")]
public void TestContainer()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDrawableTypeAllocations_TestSprite"></a> TestSprite\(\)

```csharp
[Test]
[Benchmark(22, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDrawableTypeAllocations.cs")]
public void TestSprite()
```

### <a id="osu_Framework_Benchmarks_BenchmarkDrawableTypeAllocations_TestSpriteText"></a> TestSpriteText\(\)

```csharp
[Test]
[Benchmark(43, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkDrawableTypeAllocations.cs")]
public void TestSpriteText()
```

