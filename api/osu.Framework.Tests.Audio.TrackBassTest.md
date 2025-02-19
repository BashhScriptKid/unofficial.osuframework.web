# <a id="osu_Framework_Tests_Audio_TrackBassTest"></a> Class TrackBassTest

Namespace: [osu.Framework.Tests.Audio](osu.Framework.Tests.Audio.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class TrackBassTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TrackBassTest](osu.Framework.Tests.Audio.TrackBassTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TrackBassTest\>\(TrackBassTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TrackBassTest\>\(TrackBassTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TrackBassTest\>\(TrackBassTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TrackBassTest\>\(TrackBassTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TrackBassTest, TChild\>\(TrackBassTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TrackBassTest, TChild\>\(TrackBassTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TrackBassTest, TChild\>\(TrackBassTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TrackBassTest\>\(TrackBassTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Audio_TrackBassTest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestBitrate"></a> TestBitrate\(\)

```csharp
[Test]
public void TestBitrate()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestBitrate"></a> TestBitrate\(\)

```csharp
[Test]
public void TestBitrate()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestBitrate"></a> TestBitrate\(\)

```csharp
[Test]
public void TestBitrate()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestCurrentTimeUpdatedAfterInlineSeek"></a> TestCurrentTimeUpdatedAfterInlineSeek\(\)

Tests the case where a seek call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestCurrentTimeUpdatedAfterInlineSeek()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestCurrentTimeUpdatedAfterInlineSeek"></a> TestCurrentTimeUpdatedAfterInlineSeek\(\)

Tests the case where a seek call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestCurrentTimeUpdatedAfterInlineSeek()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestCurrentTimeUpdatedAfterInlineSeek"></a> TestCurrentTimeUpdatedAfterInlineSeek\(\)

Tests the case where a seek call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestCurrentTimeUpdatedAfterInlineSeek()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestHasCompletedResetsOnSeekBack"></a> TestHasCompletedResetsOnSeekBack\(\)

```csharp
[Test]
public void TestHasCompletedResetsOnSeekBack()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestHasCompletedResetsOnSeekBack"></a> TestHasCompletedResetsOnSeekBack\(\)

```csharp
[Test]
public void TestHasCompletedResetsOnSeekBack()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestHasCompletedResetsOnSeekBack"></a> TestHasCompletedResetsOnSeekBack\(\)

```csharp
[Test]
public void TestHasCompletedResetsOnSeekBack()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestIsRunningUpdatedAfterInlineStart"></a> TestIsRunningUpdatedAfterInlineStart\(\)

Tests the case where a start call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestIsRunningUpdatedAfterInlineStart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestIsRunningUpdatedAfterInlineStart"></a> TestIsRunningUpdatedAfterInlineStart\(\)

Tests the case where a start call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestIsRunningUpdatedAfterInlineStart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestIsRunningUpdatedAfterInlineStart"></a> TestIsRunningUpdatedAfterInlineStart\(\)

Tests the case where a start call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestIsRunningUpdatedAfterInlineStart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestIsRunningUpdatedAfterInlineStop"></a> TestIsRunningUpdatedAfterInlineStop\(\)

Tests the case where a stop call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestIsRunningUpdatedAfterInlineStop()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestIsRunningUpdatedAfterInlineStop"></a> TestIsRunningUpdatedAfterInlineStop\(\)

Tests the case where a stop call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestIsRunningUpdatedAfterInlineStop()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestIsRunningUpdatedAfterInlineStop"></a> TestIsRunningUpdatedAfterInlineStop\(\)

Tests the case where a stop call can be run inline due to already being on the audio thread.
Because it's immediately executed, a `Bass.Update()` call is not required before the channel's state is updated.

```csharp
[Test]
public void TestIsRunningUpdatedAfterInlineStop()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestLoopingRestart_System_Double_"></a> TestLoopingRestart\(double\)

```csharp
[TestCase(0)]
[TestCase(1000)]
public void TestLoopingRestart(double restartPoint)
```

#### Parameters

`restartPoint` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestLoopingRestart_System_Double_"></a> TestLoopingRestart\(double\)

```csharp
[TestCase(0)]
[TestCase(1000)]
public void TestLoopingRestart(double restartPoint)
```

#### Parameters

`restartPoint` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestLoopingRestart_System_Double_"></a> TestLoopingRestart\(double\)

```csharp
[TestCase(0)]
[TestCase(1000)]
public void TestLoopingRestart(double restartPoint)
```

#### Parameters

`restartPoint` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestLoopingTrackDoesntSetCompleted"></a> TestLoopingTrackDoesntSetCompleted\(\)

```csharp
[Test]
public void TestLoopingTrackDoesntSetCompleted()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestLoopingTrackDoesntSetCompleted"></a> TestLoopingTrackDoesntSetCompleted\(\)

```csharp
[Test]
public void TestLoopingTrackDoesntSetCompleted()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestLoopingTrackDoesntSetCompleted"></a> TestLoopingTrackDoesntSetCompleted\(\)

```csharp
[Test]
public void TestLoopingTrackDoesntSetCompleted()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestPlaybackToEnd"></a> TestPlaybackToEnd\(\)

```csharp
[Test]
public void TestPlaybackToEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestPlaybackToEnd"></a> TestPlaybackToEnd\(\)

```csharp
[Test]
public void TestPlaybackToEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestPlaybackToEnd"></a> TestPlaybackToEnd\(\)

```csharp
[Test]
public void TestPlaybackToEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRateWithAggregateAdjustments"></a> TestRateWithAggregateAdjustments\(\)

```csharp
[Test]
public void TestRateWithAggregateAdjustments()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRateWithAggregateAdjustments"></a> TestRateWithAggregateAdjustments\(\)

```csharp
[Test]
public void TestRateWithAggregateAdjustments()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRateWithAggregateAdjustments"></a> TestRateWithAggregateAdjustments\(\)

```csharp
[Test]
public void TestRateWithAggregateAdjustments()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestart"></a> TestRestart\(\)

```csharp
[Test]
public void TestRestart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestart"></a> TestRestart\(\)

```csharp
[Test]
public void TestRestart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestart"></a> TestRestart\(\)

```csharp
[Test]
public void TestRestart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestartAtEnd"></a> TestRestartAtEnd\(\)

```csharp
[Test]
public void TestRestartAtEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestartAtEnd"></a> TestRestartAtEnd\(\)

```csharp
[Test]
public void TestRestartAtEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestartAtEnd"></a> TestRestartAtEnd\(\)

```csharp
[Test]
public void TestRestartAtEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestartFromRestartPoint"></a> TestRestartFromRestartPoint\(\)

```csharp
[Test]
public void TestRestartFromRestartPoint()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestartFromRestartPoint"></a> TestRestartFromRestartPoint\(\)

```csharp
[Test]
public void TestRestartFromRestartPoint()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestRestartFromRestartPoint"></a> TestRestartFromRestartPoint\(\)

```csharp
[Test]
public void TestRestartFromRestartPoint()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeek"></a> TestSeek\(\)

```csharp
[Test]
public void TestSeek()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeek"></a> TestSeek\(\)

```csharp
[Test]
public void TestSeek()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeek"></a> TestSeek\(\)

```csharp
[Test]
public void TestSeek()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekBackToSamePosition"></a> TestSeekBackToSamePosition\(\)

```csharp
[Test]
public void TestSeekBackToSamePosition()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekBackToSamePosition"></a> TestSeekBackToSamePosition\(\)

```csharp
[Test]
public void TestSeekBackToSamePosition()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekBackToSamePosition"></a> TestSeekBackToSamePosition\(\)

```csharp
[Test]
public void TestSeekBackToSamePosition()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekToEndFails"></a> TestSeekToEndFails\(\)

Bass does not allow seeking to the end of the track. It should fail and the current time should not change.

```csharp
[Test]
public void TestSeekToEndFails()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekToEndFails"></a> TestSeekToEndFails\(\)

Bass does not allow seeking to the end of the track. It should fail and the current time should not change.

```csharp
[Test]
public void TestSeekToEndFails()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekToEndFails"></a> TestSeekToEndFails\(\)

Bass does not allow seeking to the end of the track. It should fail and the current time should not change.

```csharp
[Test]
public void TestSeekToEndFails()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekWhileRunning"></a> TestSeekWhileRunning\(\)

```csharp
[Test]
public void TestSeekWhileRunning()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekWhileRunning"></a> TestSeekWhileRunning\(\)

```csharp
[Test]
public void TestSeekWhileRunning()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSeekWhileRunning"></a> TestSeekWhileRunning\(\)

```csharp
[Test]
public void TestSeekWhileRunning()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSetTempoNegative"></a> TestSetTempoNegative\(\)

```csharp
[Test]
public void TestSetTempoNegative()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSetTempoNegative"></a> TestSetTempoNegative\(\)

```csharp
[Test]
public void TestSetTempoNegative()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestSetTempoNegative"></a> TestSetTempoNegative\(\)

```csharp
[Test]
public void TestSetTempoNegative()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStart"></a> TestStart\(\)

```csharp
[Test]
public void TestStart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStart"></a> TestStart\(\)

```csharp
[Test]
public void TestStart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStart"></a> TestStart\(\)

```csharp
[Test]
public void TestStart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStartFromEndDoesNotRestart"></a> TestStartFromEndDoesNotRestart\(\)

Bass restarts the track from the beginning if Start is called when the track has been completed.
This is blocked locally in <xref href="osu.Framework.Audio.Track.TrackBass" data-throw-if-not-resolved="false"></xref>, so this test expects the track to not restart.

```csharp
[Test]
public void TestStartFromEndDoesNotRestart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStartFromEndDoesNotRestart"></a> TestStartFromEndDoesNotRestart\(\)

Bass restarts the track from the beginning if Start is called when the track has been completed.
This is blocked locally in <xref href="osu.Framework.Audio.Track.TrackBass" data-throw-if-not-resolved="false"></xref>, so this test expects the track to not restart.

```csharp
[Test]
public void TestStartFromEndDoesNotRestart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStartFromEndDoesNotRestart"></a> TestStartFromEndDoesNotRestart\(\)

Bass restarts the track from the beginning if Start is called when the track has been completed.
This is blocked locally in <xref href="osu.Framework.Audio.Track.TrackBass" data-throw-if-not-resolved="false"></xref>, so this test expects the track to not restart.

```csharp
[Test]
public void TestStartFromEndDoesNotRestart()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStop"></a> TestStop\(\)

```csharp
[Test]
public void TestStop()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStop"></a> TestStop\(\)

```csharp
[Test]
public void TestStop()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStop"></a> TestStop\(\)

```csharp
[Test]
public void TestStop()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStopAtEnd"></a> TestStopAtEnd\(\)

```csharp
[Test]
public void TestStopAtEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStopAtEnd"></a> TestStopAtEnd\(\)

```csharp
[Test]
public void TestStopAtEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStopAtEnd"></a> TestStopAtEnd\(\)

```csharp
[Test]
public void TestStopAtEnd()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStopWhenDisposed"></a> TestStopWhenDisposed\(\)

```csharp
[Test]
public void TestStopWhenDisposed()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStopWhenDisposed"></a> TestStopWhenDisposed\(\)

```csharp
[Test]
public void TestStopWhenDisposed()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestStopWhenDisposed"></a> TestStopWhenDisposed\(\)

```csharp
[Test]
public void TestStopWhenDisposed()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestZeroFrequencyDoesntResumeTrack"></a> TestZeroFrequencyDoesntResumeTrack\(\)

Ensure setting a paused (or not yet played) track's frequency from zero to one doesn't resume / play it.

```csharp
[Test]
public void TestZeroFrequencyDoesntResumeTrack()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestZeroFrequencyDoesntResumeTrack"></a> TestZeroFrequencyDoesntResumeTrack\(\)

Ensure setting a paused (or not yet played) track's frequency from zero to one doesn't resume / play it.

```csharp
[Test]
public void TestZeroFrequencyDoesntResumeTrack()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestZeroFrequencyDoesntResumeTrack"></a> TestZeroFrequencyDoesntResumeTrack\(\)

Ensure setting a paused (or not yet played) track's frequency from zero to one doesn't resume / play it.

```csharp
[Test]
public void TestZeroFrequencyDoesntResumeTrack()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestZeroFrequencyHandling"></a> TestZeroFrequencyHandling\(\)

```csharp
[Test]
public void TestZeroFrequencyHandling()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestZeroFrequencyHandling"></a> TestZeroFrequencyHandling\(\)

```csharp
[Test]
public void TestZeroFrequencyHandling()
```

### <a id="osu_Framework_Tests_Audio_TrackBassTest_TestZeroFrequencyHandling"></a> TestZeroFrequencyHandling\(\)

```csharp
[Test]
public void TestZeroFrequencyHandling()
```

