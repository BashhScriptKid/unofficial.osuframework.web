# <a id="osu_Framework_Tests_Audio_SampleBassTest"></a> Class SampleBassTest

Namespace: [osu.Framework.Tests.Audio](osu.Framework.Tests.Audio.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class SampleBassTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SampleBassTest](osu.Framework.Tests.Audio.SampleBassTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SampleBassTest\>\(SampleBassTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SampleBassTest\>\(SampleBassTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SampleBassTest\>\(SampleBassTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SampleBassTest\>\(SampleBassTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SampleBassTest, TChild\>\(SampleBassTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SampleBassTest, TChild\>\(SampleBassTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SampleBassTest, TChild\>\(SampleBassTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SampleBassTest\>\(SampleBassTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Audio_SampleBassTest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestGetChannelOnDisposed"></a> TestGetChannelOnDisposed\(\)

```csharp
[Test]
public void TestGetChannelOnDisposed()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestGetChannelOnDisposed"></a> TestGetChannelOnDisposed\(\)

```csharp
[Test]
public void TestGetChannelOnDisposed()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestGetChannelOnDisposed"></a> TestGetChannelOnDisposed\(\)

```csharp
[Test]
public void TestGetChannelOnDisposed()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestPlayingUpdatedAfterInlinePlay"></a> TestPlayingUpdatedAfterInlinePlay\(\)

Tests the case where a play call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestPlayingUpdatedAfterInlinePlay()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestPlayingUpdatedAfterInlinePlay"></a> TestPlayingUpdatedAfterInlinePlay\(\)

Tests the case where a play call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestPlayingUpdatedAfterInlinePlay()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestPlayingUpdatedAfterInlinePlay"></a> TestPlayingUpdatedAfterInlinePlay\(\)

Tests the case where a play call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestPlayingUpdatedAfterInlinePlay()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestPlayingUpdatedAfterInlineStop"></a> TestPlayingUpdatedAfterInlineStop\(\)

Tests the case where a stop call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestPlayingUpdatedAfterInlineStop()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestPlayingUpdatedAfterInlineStop"></a> TestPlayingUpdatedAfterInlineStop\(\)

Tests the case where a stop call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestPlayingUpdatedAfterInlineStop()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestPlayingUpdatedAfterInlineStop"></a> TestPlayingUpdatedAfterInlineStop\(\)

Tests the case where a stop call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestPlayingUpdatedAfterInlineStop()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStart"></a> TestStart\(\)

```csharp
[Test]
public void TestStart()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStart"></a> TestStart\(\)

```csharp
[Test]
public void TestStart()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStart"></a> TestStart\(\)

```csharp
[Test]
public void TestStart()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStop"></a> TestStop\(\)

```csharp
[Test]
public void TestStop()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStop"></a> TestStop\(\)

```csharp
[Test]
public void TestStop()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStop"></a> TestStop\(\)

```csharp
[Test]
public void TestStop()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStopBeforeLoadFinished"></a> TestStopBeforeLoadFinished\(\)

```csharp
[Test]
public void TestStopBeforeLoadFinished()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStopBeforeLoadFinished"></a> TestStopBeforeLoadFinished\(\)

```csharp
[Test]
public void TestStopBeforeLoadFinished()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStopBeforeLoadFinished"></a> TestStopBeforeLoadFinished\(\)

```csharp
[Test]
public void TestStopBeforeLoadFinished()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStopsWhenFactoryDisposed"></a> TestStopsWhenFactoryDisposed\(\)

```csharp
[Test]
public void TestStopsWhenFactoryDisposed()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStopsWhenFactoryDisposed"></a> TestStopsWhenFactoryDisposed\(\)

```csharp
[Test]
public void TestStopsWhenFactoryDisposed()
```

### <a id="osu_Framework_Tests_Audio_SampleBassTest_TestStopsWhenFactoryDisposed"></a> TestStopsWhenFactoryDisposed\(\)

```csharp
[Test]
public void TestStopsWhenFactoryDisposed()
```

