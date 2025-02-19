# <a id="osu_Framework_Benchmarks_GameBenchmark"></a> Class GameBenchmark

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
[TestFixture]
[MemoryDiagnoser(true)]
public abstract class GameBenchmark
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameBenchmark](osu.Framework.Benchmarks.GameBenchmark.md)

#### Derived

[BenchmarkBeginAbsoluteSequence](osu.Framework.Benchmarks.BenchmarkBeginAbsoluteSequence.md), 
[BenchmarkCompositeDrawableAllocations](osu.Framework.Benchmarks.BenchmarkCompositeDrawableAllocations.md), 
[BenchmarkDependencyContainer](osu.Framework.Benchmarks.BenchmarkDependencyContainer.md), 
[BenchmarkDrawableAudioWrapper](osu.Framework.Benchmarks.BenchmarkDrawableAudioWrapper.md), 
[BenchmarkDrawableLoad](osu.Framework.Benchmarks.BenchmarkDrawableLoad.md), 
[BenchmarkFillFlowContainerAllocations](osu.Framework.Benchmarks.BenchmarkFillFlowContainerAllocations.md), 
[BenchmarkInvalidationWithManyNotAlive](osu.Framework.Benchmarks.BenchmarkInvalidationWithManyNotAlive.md), 
[BenchmarkMakeChildAlive](osu.Framework.Benchmarks.BenchmarkMakeChildAlive.md), 
[BenchmarkManySpinningBoxes](osu.Framework.Benchmarks.BenchmarkManySpinningBoxes.md), 
[BenchmarkScreenExtensions](osu.Framework.Benchmarks.BenchmarkScreenExtensions.md), 
[BenchmarkSpinningParentWithManyAlive](osu.Framework.Benchmarks.BenchmarkSpinningParentWithManyAlive.md), 
[BenchmarkSpriteText](osu.Framework.Benchmarks.BenchmarkSpriteText.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GameBenchmark\>\(GameBenchmark?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GameBenchmark\>\(GameBenchmark\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GameBenchmark\>\(GameBenchmark\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GameBenchmark\>\(GameBenchmark\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GameBenchmark, TChild\>\(GameBenchmark, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GameBenchmark, TChild\>\(GameBenchmark, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GameBenchmark, TChild\>\(GameBenchmark, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GameBenchmark\>\(GameBenchmark\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Benchmarks_GameBenchmark_Game"></a> Game

```csharp
protected Game Game { get; }
```

#### Property Value

 Game

## Methods

### <a id="osu_Framework_Benchmarks_GameBenchmark_CreateGame"></a> CreateGame\(\)

Creates the game.

```csharp
protected abstract Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_Benchmarks_GameBenchmark_RunSingleFrame"></a> RunSingleFrame\(\)

Runs a single game frame.

```csharp
protected void RunSingleFrame()
```

### <a id="osu_Framework_Benchmarks_GameBenchmark_SetUp"></a> SetUp\(\)

```csharp
[GlobalSetup]
[OneTimeSetUp]
public virtual void SetUp()
```

### <a id="osu_Framework_Benchmarks_GameBenchmark_TearDown"></a> TearDown\(\)

```csharp
[GlobalCleanup]
[OneTimeTearDown]
public virtual void TearDown()
```

