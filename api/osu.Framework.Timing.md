# <a id="osu_Framework_Timing"></a> Namespace osu.Framework.Timing

### Classes

 [DecoupleableInterpolatingFramedClock](osu.Framework.Timing.DecoupleableInterpolatingFramedClock.md)

Adds the ability to keep the clock running even when the underlying source has stopped or cannot handle the current time range.
This is handled by performing seeks on the underlying source and checking whether they were successful or not.
On failure to seek, we take over with an internal clock until control can be returned to the actual source.

This clock type removes the requirement of having a source set.

If a <xref href="osu.Framework.Timing.InterpolatingFramedClock.Source" data-throw-if-not-resolved="false"></xref> is set, it is presumed that we have exclusive control over operations on it.
This is used to our advantage to allow correct <xref href="osu.Framework.Timing.DecoupleableInterpolatingFramedClock.IsRunning" data-throw-if-not-resolved="false"></xref> state tracking in the event of cross-thread communication delays (with an audio thread, for instance).

 [DecouplingFramedClock](osu.Framework.Timing.DecouplingFramedClock.md)

A decoupling clock allows taking an existing clock which has seek limitations and provides
a controllable encapsulated view of that clock with the ability to seek and track time
outside of the normally seekable bounds.

Put simply, it will take a Track which can only track time from 0..trackLength and allow
both negative seeks and seeks beyond trackLength. It will also allow time to continue counting
beyond the end of the track even when not explicitly seeked.

 [FramedClock](osu.Framework.Timing.FramedClock.md)

Takes a clock source and separates time reading on a per-frame level.
The CurrentTime value will only change on initial construction and whenever ProcessFrame is run.

 [FramedOffsetClock](osu.Framework.Timing.FramedOffsetClock.md)

A framed clock which allows an offset to be added or subtracted from an underlying source clock's time.

 [InterpolatingFramedClock](osu.Framework.Timing.InterpolatingFramedClock.md)

A clock which uses an internal stopwatch to interpolate (smooth out) a source.

 [ManualClock](osu.Framework.Timing.ManualClock.md)

A completely manual clock implementation. Everything is settable.

 [ManualFramedClock](osu.Framework.Timing.ManualFramedClock.md)

A completely manual framed clock implementation. Everything is settable.

 [OffsetClock](osu.Framework.Timing.OffsetClock.md)

 [StopwatchClock](osu.Framework.Timing.StopwatchClock.md)

 [ThrottledFrameClock](osu.Framework.Timing.ThrottledFrameClock.md)

A FrameClock which will limit the number of frames processed by adding Thread.Sleep calls on each ProcessFrame.

### Structs

 [FrameTimeInfo](osu.Framework.Timing.FrameTimeInfo.md)

### Interfaces

 [IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md)

A clock that can be started, stopped, reset etc.

 [IClock](osu.Framework.Timing.IClock.md)

A basic clock for keeping time.

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

A clock which will only update its current time when a frame process is triggered.
Useful for keeping a consistent time state across an individual update.

 [ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md)

A clock which has a source that can be changed.

