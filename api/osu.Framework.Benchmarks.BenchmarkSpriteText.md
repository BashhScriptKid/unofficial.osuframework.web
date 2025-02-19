# <a id="osu_Framework_Benchmarks_BenchmarkSpriteText"></a> Class BenchmarkSpriteText

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class BenchmarkSpriteText : GameBenchmark
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameBenchmark](osu.Framework.Benchmarks.GameBenchmark.md) ← 
[BenchmarkSpriteText](osu.Framework.Benchmarks.BenchmarkSpriteText.md)

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

[ObjectExtensions.AsNonNull<BenchmarkSpriteText\>\(BenchmarkSpriteText?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkSpriteText\>\(BenchmarkSpriteText\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkSpriteText\>\(BenchmarkSpriteText\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkSpriteText\>\(BenchmarkSpriteText\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkSpriteText, TChild\>\(BenchmarkSpriteText, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkSpriteText, TChild\>\(BenchmarkSpriteText, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkSpriteText, TChild\>\(BenchmarkSpriteText, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkSpriteText\>\(BenchmarkSpriteText\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkSpriteText_CreateGame"></a> CreateGame\(\)

Creates the game.

```csharp
protected override Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_Benchmarks_BenchmarkSpriteText_TestChangingText"></a> TestChangingText\(\)

```csharp
[Test]
[Benchmark(37, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSpriteText.cs")]
public void TestChangingText()
```

### <a id="osu_Framework_Benchmarks_BenchmarkSpriteText_TestMovingText"></a> TestMovingText\(\)

```csharp
[Test]
[Benchmark(29, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSpriteText.cs")]
public void TestMovingText()
```

### <a id="osu_Framework_Benchmarks_BenchmarkSpriteText_TestStaticText"></a> TestStaticText\(\)

```csharp
[Test]
[Benchmark(21, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSpriteText.cs")]
public void TestStaticText()
```

