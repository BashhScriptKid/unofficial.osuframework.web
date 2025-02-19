# <a id="osu_Framework_Tests_Audio_AudioThreadTest"></a> Class AudioThreadTest

Namespace: [osu.Framework.Tests.Audio](osu.Framework.Tests.Audio.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public abstract class AudioThreadTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioThreadTest](osu.Framework.Tests.Audio.AudioThreadTest.md)

#### Derived

[AudioComponentTest](osu.Framework.Tests.Audio.AudioComponentTest.md), 
[DeviceLosingAudioTest](osu.Framework.Tests.Audio.DeviceLosingAudioTest.md), 
[DevicelessAudioTest](osu.Framework.Tests.Audio.DevicelessAudioTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AudioThreadTest\>\(AudioThreadTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AudioThreadTest\>\(AudioThreadTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AudioThreadTest\>\(AudioThreadTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AudioThreadTest\>\(AudioThreadTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AudioThreadTest, TChild\>\(AudioThreadTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AudioThreadTest, TChild\>\(AudioThreadTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AudioThreadTest, TChild\>\(AudioThreadTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AudioThreadTest\>\(AudioThreadTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_CheckTrackIsProgressing_osu_Framework_Audio_Track_Track_"></a> CheckTrackIsProgressing\(Track\)

```csharp
public void CheckTrackIsProgressing(Track track)
```

#### Parameters

`track` [Track](osu.Framework.Audio.Track.Track.md)

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_CheckTrackIsProgressing_osu_Framework_Audio_Track_Track_"></a> CheckTrackIsProgressing\(Track\)

```csharp
public void CheckTrackIsProgressing(Track track)
```

#### Parameters

`track` Track

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_CheckTrackIsProgressing_osu_Framework_Audio_Track_Track_"></a> CheckTrackIsProgressing\(Track\)

```csharp
public void CheckTrackIsProgressing(Track track)
```

#### Parameters

`track` Track

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_SetUp"></a> SetUp\(\)

```csharp
[SetUp]
public virtual void SetUp()
```

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_SetUp"></a> SetUp\(\)

```csharp
[SetUp]
public virtual void SetUp()
```

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_SetUp"></a> SetUp\(\)

```csharp
[SetUp]
public virtual void SetUp()
```

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_TearDown"></a> TearDown\(\)

```csharp
[TearDown]
public void TearDown()
```

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_TearDown"></a> TearDown\(\)

```csharp
[TearDown]
public void TearDown()
```

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_TearDown"></a> TearDown\(\)

```csharp
[TearDown]
public void TearDown()
```

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_WaitAudioFrame_System_Int32_"></a> WaitAudioFrame\(int\)

Block for a specified number of audio thread frames.

```csharp
protected void WaitAudioFrame(int count = 2)
```

#### Parameters

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of frames to wait for. Two frames is generally considered safest.

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_WaitAudioFrame_System_Int32_"></a> WaitAudioFrame\(int\)

Block for a specified number of audio thread frames.

```csharp
protected void WaitAudioFrame(int count = 2)
```

#### Parameters

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of frames to wait for. Two frames is generally considered safest.

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_WaitAudioFrame_System_Int32_"></a> WaitAudioFrame\(int\)

Block for a specified number of audio thread frames.

```csharp
protected void WaitAudioFrame(int count = 2)
```

#### Parameters

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of frames to wait for. Two frames is generally considered safest.

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_WaitForOrAssert_System_Func_System_Boolean__System_String_System_Int32_"></a> WaitForOrAssert\(Func<bool\>, string, int\)

Waits for a specified condition to become true, or timeout reached.

```csharp
public static void WaitForOrAssert(Func<bool> condition, string message, int timeout = 60000)
```

#### Parameters

`condition` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The condition which should become true.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

A message to display on timeout.

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Timeout in milliseconds.

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_WaitForOrAssert_System_Func_System_Boolean__System_String_System_Int32_"></a> WaitForOrAssert\(Func<bool\>, string, int\)

Waits for a specified condition to become true, or timeout reached.

```csharp
public static void WaitForOrAssert(Func<bool> condition, string message, int timeout = 60000)
```

#### Parameters

`condition` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The condition which should become true.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

A message to display on timeout.

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Timeout in milliseconds.

### <a id="osu_Framework_Tests_Audio_AudioThreadTest_WaitForOrAssert_System_Func_System_Boolean__System_String_System_Int32_"></a> WaitForOrAssert\(Func<bool\>, string, int\)

Waits for a specified condition to become true, or timeout reached.

```csharp
public static void WaitForOrAssert(Func<bool> condition, string message, int timeout = 60000)
```

#### Parameters

`condition` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The condition which should become true.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

A message to display on timeout.

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Timeout in milliseconds.

