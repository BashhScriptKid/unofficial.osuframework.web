# <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary"></a> Class BenchmarkSlimReadOnlyDictionary

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
[MemoryDiagnoser(true)]
public class BenchmarkSlimReadOnlyDictionary
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BenchmarkSlimReadOnlyDictionary](osu.Framework.Benchmarks.BenchmarkSlimReadOnlyDictionary.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BenchmarkSlimReadOnlyDictionary\>\(BenchmarkSlimReadOnlyDictionary?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BenchmarkSlimReadOnlyDictionary\>\(BenchmarkSlimReadOnlyDictionary\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BenchmarkSlimReadOnlyDictionary\>\(BenchmarkSlimReadOnlyDictionary\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BenchmarkSlimReadOnlyDictionary\>\(BenchmarkSlimReadOnlyDictionary\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BenchmarkSlimReadOnlyDictionary, TChild\>\(BenchmarkSlimReadOnlyDictionary, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BenchmarkSlimReadOnlyDictionary, TChild\>\(BenchmarkSlimReadOnlyDictionary, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BenchmarkSlimReadOnlyDictionary, TChild\>\(BenchmarkSlimReadOnlyDictionary, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BenchmarkSlimReadOnlyDictionary\>\(BenchmarkSlimReadOnlyDictionary\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_Dictionary"></a> Dictionary\(\)

```csharp
[Benchmark(27, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int Dictionary()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_DictionaryAsReadOnly"></a> DictionaryAsReadOnly\(\)

```csharp
[Benchmark(41, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int DictionaryAsReadOnly()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_DictionaryAsSlimReadOnly"></a> DictionaryAsSlimReadOnly\(\)

```csharp
[Benchmark(55, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int DictionaryAsSlimReadOnly()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_GlobalSetup"></a> GlobalSetup\(\)

```csharp
[GlobalSetup]
public void GlobalSetup()
```

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_Keys"></a> Keys\(\)

```csharp
[Benchmark(69, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int Keys()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_KeysAsReadOnly"></a> KeysAsReadOnly\(\)

```csharp
[Benchmark(83, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int KeysAsReadOnly()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_KeysAsSlimReadOnly"></a> KeysAsSlimReadOnly\(\)

```csharp
[Benchmark(97, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int KeysAsSlimReadOnly()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_Values"></a> Values\(\)

```csharp
[Benchmark(111, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int Values()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_ValuesAsReadOnly"></a> ValuesAsReadOnly\(\)

```csharp
[Benchmark(125, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int ValuesAsReadOnly()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Benchmarks_BenchmarkSlimReadOnlyDictionary_ValuesAsSlimReadOnly"></a> ValuesAsSlimReadOnly\(\)

```csharp
[Benchmark(139, "C:\\Users\\Bashh.DESKTOP-J6F27TL\\Documents\\! Codes\\unofficial.osuframework.web\\osu-framework\\osu.Framework.Benchmarks\\BenchmarkSlimReadOnlyDictionary.cs")]
public int ValuesAsSlimReadOnly()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

