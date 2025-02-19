# <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest"></a> Class DeviceLosingAudioTest

Namespace: [osu.Framework.Tests.Audio](osu.Framework.Tests.Audio.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class DeviceLosingAudioTest : AudioThreadTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioThreadTest](osu.Framework.Tests.Audio.AudioThreadTest.md) ← 
[DeviceLosingAudioTest](osu.Framework.Tests.Audio.DeviceLosingAudioTest.md)

#### Inherited Members

[AudioThreadTest.SetUp\(\)](osu.Framework.Tests.Audio.AudioThreadTest.md\#osu\_Framework\_Tests\_Audio\_AudioThreadTest\_SetUp), 
[AudioThreadTest.TearDown\(\)](osu.Framework.Tests.Audio.AudioThreadTest.md\#osu\_Framework\_Tests\_Audio\_AudioThreadTest\_TearDown), 
[AudioThreadTest.CheckTrackIsProgressing\(Track\)](osu.Framework.Tests.Audio.AudioThreadTest.md\#osu\_Framework\_Tests\_Audio\_AudioThreadTest\_CheckTrackIsProgressing\_osu\_Framework\_Audio\_Track\_Track\_), 
[AudioThreadTest.WaitForOrAssert\(Func<bool\>, string, int\)](osu.Framework.Tests.Audio.AudioThreadTest.md\#osu\_Framework\_Tests\_Audio\_AudioThreadTest\_WaitForOrAssert\_System\_Func\_System\_Boolean\_\_System\_String\_System\_Int32\_), 
[AudioThreadTest.WaitAudioFrame\(int\)](osu.Framework.Tests.Audio.AudioThreadTest.md\#osu\_Framework\_Tests\_Audio\_AudioThreadTest\_WaitAudioFrame\_System\_Int32\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DeviceLosingAudioTest\>\(DeviceLosingAudioTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DeviceLosingAudioTest\>\(DeviceLosingAudioTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DeviceLosingAudioTest\>\(DeviceLosingAudioTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DeviceLosingAudioTest\>\(DeviceLosingAudioTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DeviceLosingAudioTest, TChild\>\(DeviceLosingAudioTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DeviceLosingAudioTest, TChild\>\(DeviceLosingAudioTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DeviceLosingAudioTest, TChild\>\(DeviceLosingAudioTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DeviceLosingAudioTest\>\(DeviceLosingAudioTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

This unit will ALWAYS SKIP if the system does not have a physical audio device!!!
A physical audio device is required to simulate the "loss" of it during playback.

## Methods

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_SetUp"></a> SetUp\(\)

```csharp
public override void SetUp()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_TestPlaybackWithDeviceLoss"></a> TestPlaybackWithDeviceLoss\(\)

```csharp
[Test]
public void TestPlaybackWithDeviceLoss()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_TestPlaybackWithDeviceLoss"></a> TestPlaybackWithDeviceLoss\(\)

```csharp
[Test]
public void TestPlaybackWithDeviceLoss()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_TestPlaybackWithDeviceLoss"></a> TestPlaybackWithDeviceLoss\(\)

```csharp
[Test]
public void TestPlaybackWithDeviceLoss()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_TestPlaybackWithDeviceRestore"></a> TestPlaybackWithDeviceRestore\(\)

```csharp
[Test]
public void TestPlaybackWithDeviceRestore()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_TestPlaybackWithDeviceRestore"></a> TestPlaybackWithDeviceRestore\(\)

```csharp
[Test]
public void TestPlaybackWithDeviceRestore()
```

### <a id="osu_Framework_Tests_Audio_DeviceLosingAudioTest_TestPlaybackWithDeviceRestore"></a> TestPlaybackWithDeviceRestore\(\)

```csharp
[Test]
public void TestPlaybackWithDeviceRestore()
```

