# <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager"></a> Class TestScenePassThroughInputManager.TestInputManager

Namespace: [osu.Framework.Tests.Visual.Input](osu.Framework.Tests.Visual.Input.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class TestScenePassThroughInputManager.TestInputManager : ManualInputManager, IDependencyInjectionCandidate, IDisposable, IContainerEnumerable<Drawable>, IContainerCollection<Drawable>, IContainer, ICollection<Drawable>, IReadOnlyList<Drawable>, IReadOnlyCollection<Drawable>, IEnumerable<Drawable>, IEnumerable, IInputStateChangeHandler, IFocusManager, IRequireHighFrequencyMousePosition, IDrawable, ITransformable, ISourceGeneratedDependencyActivator, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedHandleInputCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md) ← 
[Container<Drawable\>](osu.Framework.Graphics.Containers.Container\-1.md) ← 
[Container](osu.Framework.Graphics.Containers.Container.md) ← 
[InputManager](osu.Framework.Input.InputManager.md) ← 
[CustomInputManager](osu.Framework.Input.CustomInputManager.md) ← 
[PassThroughInputManager](osu.Framework.Input.PassThroughInputManager.md) ← 
[ManualInputManager](osu.Framework.Testing.Input.ManualInputManager.md) ← 
[TestScenePassThroughInputManager.TestInputManager](osu.Framework.Tests.Visual.Input.TestScenePassThroughInputManager.TestInputManager.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IContainerEnumerable<Drawable\>](osu.Framework.Graphics.Containers.IContainerEnumerable\-1.md), 
[IContainerCollection<Drawable\>](osu.Framework.Graphics.Containers.IContainerCollection\-1.md), 
[IContainer](osu.Framework.Graphics.Containers.IContainer.md), 
[ICollection<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md), 
[IFocusManager](osu.Framework.Input.IFocusManager.md), 
[IRequireHighFrequencyMousePosition](osu.Framework.Input.IRequireHighFrequencyMousePosition.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

#### Inherited Members

[ManualInputManager.Content](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_Content), 
[ManualInputManager.ShowVisualCursorGuide](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ShowVisualCursorGuide), 
[ManualInputManager.UseParentInput](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_UseParentInput), 
[ManualInputManager.AllowRightClickFromLongTouch](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_AllowRightClickFromLongTouch), 
[ManualInputManager.RightClickFromLongTouch](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_RightClickFromLongTouch), 
[ManualInputManager.Input\(IInput\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_Input\_osu\_Framework\_Input\_StateChanges\_IInput\_), 
[ManualInputManager.PressKey\(Key\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressKey\_osuTK\_Input\_Key\_), 
[ManualInputManager.ReleaseKey\(Key\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleaseKey\_osuTK\_Input\_Key\_), 
[ManualInputManager.Key\(Key\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_Key\_osuTK\_Input\_Key\_), 
[ManualInputManager.Keys\(PlatformAction\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_Keys\_osu\_Framework\_Input\_PlatformAction\_), 
[ManualInputManager.ScrollBy\(Vector2, bool\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ScrollBy\_osuTK\_Vector2\_System\_Boolean\_), 
[ManualInputManager.ScrollHorizontalBy\(float, bool\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ScrollHorizontalBy\_System\_Single\_System\_Boolean\_), 
[ManualInputManager.ScrollVerticalBy\(float, bool\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ScrollVerticalBy\_System\_Single\_System\_Boolean\_), 
[ManualInputManager.MoveMouseTo\(Drawable, Vector2?\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_MoveMouseTo\_osu\_Framework\_Graphics\_Drawable\_System\_Nullable\_osuTK\_Vector2\_\_), 
[ManualInputManager.MoveMouseTo\(Vector2\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_MoveMouseTo\_osuTK\_Vector2\_), 
[ManualInputManager.MoveTouchTo\(Touch\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_MoveTouchTo\_osu\_Framework\_Input\_Touch\_), 
[ManualInputManager.MovePenTo\(Drawable, Vector2?, TabletPenDeviceType\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_MovePenTo\_osu\_Framework\_Graphics\_Drawable\_System\_Nullable\_osuTK\_Vector2\_\_osu\_Framework\_Input\_StateChanges\_TabletPenDeviceType\_), 
[ManualInputManager.MovePenTo\(Vector2, TabletPenDeviceType\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_MovePenTo\_osuTK\_Vector2\_osu\_Framework\_Input\_StateChanges\_TabletPenDeviceType\_), 
[ManualInputManager.TriggerClick\(\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_TriggerClick), 
[ManualInputManager.Click\(MouseButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_Click\_osuTK\_Input\_MouseButton\_), 
[ManualInputManager.PressButton\(MouseButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressButton\_osuTK\_Input\_MouseButton\_), 
[ManualInputManager.ReleaseButton\(MouseButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleaseButton\_osuTK\_Input\_MouseButton\_), 
[ManualInputManager.PressJoystickButton\(JoystickButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressJoystickButton\_osu\_Framework\_Input\_JoystickButton\_), 
[ManualInputManager.ReleaseJoystickButton\(JoystickButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleaseJoystickButton\_osu\_Framework\_Input\_JoystickButton\_), 
[ManualInputManager.BeginTouch\(Touch\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_BeginTouch\_osu\_Framework\_Input\_Touch\_), 
[ManualInputManager.EndTouch\(Touch\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_EndTouch\_osu\_Framework\_Input\_Touch\_), 
[ManualInputManager.PressMidiKey\(MidiKey, byte\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressMidiKey\_osu\_Framework\_Input\_MidiKey\_System\_Byte\_), 
[ManualInputManager.ReleaseMidiKey\(MidiKey, byte\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleaseMidiKey\_osu\_Framework\_Input\_MidiKey\_System\_Byte\_), 
[ManualInputManager.PressPen\(TabletPenDeviceType\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressPen\_osu\_Framework\_Input\_StateChanges\_TabletPenDeviceType\_), 
[ManualInputManager.ReleasePen\(TabletPenDeviceType\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleasePen\_osu\_Framework\_Input\_StateChanges\_TabletPenDeviceType\_), 
[ManualInputManager.PressTabletPenButton\(TabletPenButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressTabletPenButton\_osu\_Framework\_Input\_TabletPenButton\_), 
[ManualInputManager.ReleaseTabletPenButton\(TabletPenButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleaseTabletPenButton\_osu\_Framework\_Input\_TabletPenButton\_), 
[ManualInputManager.PressTabletAuxiliaryButton\(TabletAuxiliaryButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_PressTabletAuxiliaryButton\_osu\_Framework\_Input\_TabletAuxiliaryButton\_), 
[ManualInputManager.ReleaseTabletAuxiliaryButton\(TabletAuxiliaryButton\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_ReleaseTabletAuxiliaryButton\_osu\_Framework\_Input\_TabletAuxiliaryButton\_), 
[ManualInputManager.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Testing.Input.ManualInputManager.md\#osu\_Framework\_Testing\_Input\_ManualInputManager\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[PassThroughInputManager.UseParentInput](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_UseParentInput), 
[PassThroughInputManager.LoadComplete\(\)](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_LoadComplete), 
[PassThroughInputManager.HandleHoverEvents](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_HandleHoverEvents), 
[PassThroughInputManager.GetPendingInputs\(\)](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_GetPendingInputs), 
[PassThroughInputManager.Handle\(UIEvent\)](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_Handle\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[PassThroughInputManager.Update\(\)](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_Update), 
[PassThroughInputManager.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Input.PassThroughInputManager.md\#osu\_Framework\_Input\_PassThroughInputManager\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[CustomInputManager.InputHandlers](osu.Framework.Input.CustomInputManager.md\#osu\_Framework\_Input\_CustomInputManager\_InputHandlers), 
[CustomInputManager.AddHandler\(InputHandler\)](osu.Framework.Input.CustomInputManager.md\#osu\_Framework\_Input\_CustomInputManager\_AddHandler\_osu\_Framework\_Input\_Handlers\_InputHandler\_), 
[CustomInputManager.RemoveHandler\(InputHandler\)](osu.Framework.Input.CustomInputManager.md\#osu\_Framework\_Input\_CustomInputManager\_RemoveHandler\_osu\_Framework\_Input\_Handlers\_InputHandler\_), 
[CustomInputManager.Dispose\(bool\)](osu.Framework.Input.CustomInputManager.md\#osu\_Framework\_Input\_CustomInputManager\_Dispose\_System\_Boolean\_), 
[CustomInputManager.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Input.CustomInputManager.md\#osu\_Framework\_Input\_CustomInputManager\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[InputManager.Host](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_Host), 
[InputManager.FocusedDrawable](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_FocusedDrawable), 
[InputManager.InputHandlers](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_InputHandlers), 
[InputManager.CreateInitialState\(\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateInitialState), 
[InputManager.CurrentState](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CurrentState), 
[InputManager.DraggedDrawable](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_DraggedDrawable), 
[InputManager.HoveredDrawables](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HoveredDrawables), 
[InputManager.PositionalInputQueue](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_PositionalInputQueue), 
[InputManager.NonPositionalInputQueue](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_NonPositionalInputQueue), 
[InputManager.MapMouseToLatestTouch](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_MapMouseToLatestTouch), 
[InputManager.AllowRightClickFromLongTouch](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_AllowRightClickFromLongTouch), 
[InputManager.LoadComplete\(\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_LoadComplete), 
[InputManager.CreateButtonEventManagerFor\(MouseButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osuTK\_Input\_MouseButton\_), 
[InputManager.GetButtonEventManagerFor\(MouseButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osuTK\_Input\_MouseButton\_), 
[InputManager.CreateButtonEventManagerFor\(Key\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osuTK\_Input\_Key\_), 
[InputManager.GetButtonEventManagerFor\(Key\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osuTK\_Input\_Key\_), 
[InputManager.CreateButtonEventManagerFor\(TouchSource\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osu\_Framework\_Input\_TouchSource\_), 
[InputManager.GetButtonEventManagerFor\(TouchSource\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osu\_Framework\_Input\_TouchSource\_), 
[InputManager.CreateButtonEventManagerFor\(TabletPenButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osu\_Framework\_Input\_TabletPenButton\_), 
[InputManager.GetButtonEventManagerFor\(TabletPenButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osu\_Framework\_Input\_TabletPenButton\_), 
[InputManager.CreateButtonEventManagerFor\(TabletAuxiliaryButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osu\_Framework\_Input\_TabletAuxiliaryButton\_), 
[InputManager.GetButtonEventManagerFor\(TabletAuxiliaryButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osu\_Framework\_Input\_TabletAuxiliaryButton\_), 
[InputManager.CreateButtonEventManagerFor\(JoystickButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osu\_Framework\_Input\_JoystickButton\_), 
[InputManager.GetButtonEventManagerFor\(JoystickButton\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osu\_Framework\_Input\_JoystickButton\_), 
[InputManager.CreateButtonEventManagerFor\(MidiKey\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateButtonEventManagerFor\_osu\_Framework\_Input\_MidiKey\_), 
[InputManager.GetButtonEventManagerFor\(MidiKey\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetButtonEventManagerFor\_osu\_Framework\_Input\_MidiKey\_), 
[InputManager.CreateJoystickAxisEventManagerFor\(JoystickAxisSource\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_CreateJoystickAxisEventManagerFor\_osu\_Framework\_Input\_JoystickAxisSource\_), 
[InputManager.GetJoystickAxisEventManagerFor\(JoystickAxisSource\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetJoystickAxisEventManagerFor\_osu\_Framework\_Input\_JoystickAxisSource\_), 
[InputManager.TriggerFocusContention\(Drawable\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_TriggerFocusContention\_osu\_Framework\_Graphics\_Drawable\_), 
[InputManager.ChangeFocus\(Drawable\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_ChangeFocus\_osu\_Framework\_Graphics\_Drawable\_), 
[InputManager.ChangeFocus\(Drawable, InputState\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_ChangeFocus\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Input\_States\_InputState\_), 
[InputManager.Update\(\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_Update), 
[InputManager.GetPendingInputs\(\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_GetPendingInputs), 
[InputManager.HandleHoverEvents](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleHoverEvents), 
[InputManager.HandleKeyboardKeyStateChange\(ButtonStateChangeEvent<Key\>\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleKeyboardKeyStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_ButtonStateChangeEvent\_osuTK\_Input\_Key\_\_), 
[InputManager.HandleTouchStateChange\(TouchStateChangeEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleTouchStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_TouchStateChangeEvent\_), 
[InputManager.TouchLongPressBegan](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_TouchLongPressBegan), 
[InputManager.TouchLongPressCancelled](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_TouchLongPressCancelled), 
[InputManager.HandleMouseTouchStateChange\(TouchStateChangeEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleMouseTouchStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_TouchStateChangeEvent\_), 
[InputManager.HandleTabletPenButtonStateChange\(ButtonStateChangeEvent<TabletPenButton\>\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleTabletPenButtonStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_ButtonStateChangeEvent\_osu\_Framework\_Input\_TabletPenButton\_\_), 
[InputManager.HandleTabletAuxiliaryButtonStateChange\(ButtonStateChangeEvent<TabletAuxiliaryButton\>\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleTabletAuxiliaryButtonStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_ButtonStateChangeEvent\_osu\_Framework\_Input\_TabletAuxiliaryButton\_\_), 
[InputManager.HandleJoystickButtonStateChange\(ButtonStateChangeEvent<JoystickButton\>\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleJoystickButtonStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_ButtonStateChangeEvent\_osu\_Framework\_Input\_JoystickButton\_\_), 
[InputManager.HandleMidiKeyStateChange\(ButtonStateChangeEvent<MidiKey\>\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleMidiKeyStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_ButtonStateChangeEvent\_osu\_Framework\_Input\_MidiKey\_\_), 
[InputManager.HandleInputStateChange\(InputStateChangeEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleInputStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_InputStateChangeEvent\_), 
[InputManager.HandleJoystickAxisChange\(JoystickAxisChangeEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleJoystickAxisChange\_osu\_Framework\_Input\_StateChanges\_Events\_JoystickAxisChangeEvent\_), 
[InputManager.HandleMousePositionChange\(MousePositionChangeEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleMousePositionChange\_osu\_Framework\_Input\_StateChanges\_Events\_MousePositionChangeEvent\_), 
[InputManager.HandleMouseScrollChange\(MouseScrollChangeEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleMouseScrollChange\_osu\_Framework\_Input\_StateChanges\_Events\_MouseScrollChangeEvent\_), 
[InputManager.HandleMouseButtonStateChange\(ButtonStateChangeEvent<MouseButton\>\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_HandleMouseButtonStateChange\_osu\_Framework\_Input\_StateChanges\_Events\_ButtonStateChangeEvent\_osuTK\_Input\_MouseButton\_\_), 
[InputManager.PropagateBlockableEvent\(SlimReadOnlyListWrapper<Drawable\>, UIEvent\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_PropagateBlockableEvent\_osu\_Framework\_Lists\_SlimReadOnlyListWrapper\_osu\_Framework\_Graphics\_Drawable\_\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[InputManager.ChangeFocusFromClick\(Drawable\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_ChangeFocusFromClick\_osu\_Framework\_Graphics\_Drawable\_), 
[InputManager.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Input.InputManager.md\#osu\_Framework\_Input\_InputManager\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[Container.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.Container.md\#osu\_Framework\_Graphics\_Containers\_Container\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[Container<Drawable\>.Content](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Content), 
[Container<Drawable\>.Children](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Children), 
[Container<Drawable\>.AliveChildren](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AliveChildren), 
[Container<Drawable\>.this\[int\]](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Item\_System\_Int32\_), 
[Container<Drawable\>.Count](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Count), 
[Container<Drawable\>.IsReadOnly](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_IsReadOnly), 
[Container<Drawable\>.CopyTo\(Drawable\[\], int\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CopyTo\_\_0\_\_\_System\_Int32\_), 
[Container<Drawable\>.GetEnumerator\(\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_GetEnumerator), 
[Container<Drawable\>.ChildrenEnumerable](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ChildrenEnumerable), 
[Container<Drawable\>.Child](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Child), 
[Container<Drawable\>.IndexOf\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_IndexOf\_\_0\_), 
[Container<Drawable\>.Contains\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Contains\_\_0\_), 
[Container<Drawable\>.Add\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Add\_\_0\_), 
[Container<Drawable\>.AddRange\(IEnumerable<Drawable\>\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AddRange\_System\_Collections\_Generic\_IEnumerable\_\_0\_\_), 
[Container<Drawable\>.AddInternal\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AddInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[Container<Drawable\>.Remove\(Drawable, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Remove\_\_0\_System\_Boolean\_), 
[Container<Drawable\>.RemoveAll\(Predicate<Drawable\>, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveAll\_System\_Predicate\_\_0\_\_System\_Boolean\_), 
[Container<Drawable\>.RemoveRange\(IEnumerable<Drawable\>, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveRange\_System\_Collections\_Generic\_IEnumerable\_\_0\_\_System\_Boolean\_), 
[Container<Drawable\>.RemoveInternal\(Drawable, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveInternal\_osu\_Framework\_Graphics\_Drawable\_System\_Boolean\_), 
[Container<Drawable\>.Clear\(\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Clear), 
[Container<Drawable\>.Clear\(bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Clear\_System\_Boolean\_), 
[Container<Drawable\>.ClearInternal\(bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ClearInternal\_System\_Boolean\_), 
[Container<Drawable\>.ChangeChildDepth\(Drawable, float\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ChangeChildDepth\_\_0\_System\_Single\_), 
[Container<Drawable\>.Masking](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Masking), 
[Container<Drawable\>.MaskingSmoothness](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_MaskingSmoothness), 
[Container<Drawable\>.CornerRadius](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CornerRadius), 
[Container<Drawable\>.CornerExponent](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CornerExponent), 
[Container<Drawable\>.BorderThickness](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_BorderThickness), 
[Container<Drawable\>.BorderColour](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_BorderColour), 
[Container<Drawable\>.EdgeEffect](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_EdgeEffect), 
[Container<Drawable\>.Padding](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Padding), 
[Container<Drawable\>.ForceLocalVertexBatch](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ForceLocalVertexBatch), 
[Container<Drawable\>.RelativeChildSize](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RelativeChildSize), 
[Container<Drawable\>.RelativeChildOffset](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RelativeChildOffset), 
[Container<Drawable\>.AutoSizeAxes](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeAxes), 
[Container<Drawable\>.AutoSizeDuration](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeDuration), 
[Container<Drawable\>.AutoSizeEasing](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeEasing), 
[Container<Drawable\>.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[CompositeDrawable.CreateChildDependencies\(IReadOnlyDependencyContainer\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CreateChildDependencies\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[CompositeDrawable.Dependencies](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Dependencies), 
[CompositeDrawable.InjectDependencies\(IReadOnlyDependencyContainer\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InjectDependencies\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[CompositeDrawable.LoadComponentAsync<TLoadable\>\(TLoadable, Action<TLoadable\>, CancellationToken, Scheduler\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponentAsync\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_System\_Threading\_CancellationToken\_osu\_Framework\_Threading\_Scheduler\_), 
[CompositeDrawable.LoadComponent<TLoadable\>\(TLoadable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponent\_\_1\_\_\_0\_), 
[CompositeDrawable.LoadComponentsAsync<TLoadable\>\(IEnumerable<TLoadable\>, Action<IEnumerable<TLoadable\>\>, CancellationToken, Scheduler\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponentsAsync\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_System\_Threading\_CancellationToken\_osu\_Framework\_Threading\_Scheduler\_), 
[CompositeDrawable.LoadComponents<TLoadable\>\(IEnumerable<TLoadable\>\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponents\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[CompositeDrawable.LoadAsyncComplete\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadAsyncComplete), 
[CompositeDrawable.Dispose\(bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Dispose\_System\_Boolean\_), 
[CompositeDrawable.InternalChild](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InternalChild), 
[CompositeDrawable.Compare\(Drawable, Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Compare\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.CompareReverseChildID\(Drawable, Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CompareReverseChildID\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.InternalChildren](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InternalChildren), 
[CompositeDrawable.InternalChildrenEnumerable](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InternalChildrenEnumerable), 
[CompositeDrawable.AliveInternalChildren](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AliveInternalChildren), 
[CompositeDrawable.IndexOfInternal\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_IndexOfInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.ContainsInternal\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ContainsInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.RemoveInternal\(Drawable, bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RemoveInternal\_osu\_Framework\_Graphics\_Drawable\_System\_Boolean\_), 
[CompositeDrawable.ClearInternal\(bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ClearInternal\_System\_Boolean\_), 
[CompositeDrawable.AddInternal\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AddInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.AddRangeInternal\(IEnumerable<Drawable\>\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AddRangeInternal\_System\_Collections\_Generic\_IEnumerable\_osu\_Framework\_Graphics\_Drawable\_\_), 
[CompositeDrawable.ChangeInternalChildDepth\(Drawable, float\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChangeInternalChildDepth\_osu\_Framework\_Graphics\_Drawable\_System\_Single\_), 
[CompositeDrawable.SortInternal\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_SortInternal), 
[CompositeDrawable.SchedulerAfterChildren](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_SchedulerAfterChildren), 
[CompositeDrawable.UpdateChildrenLife\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateChildrenLife), 
[CompositeDrawable.CheckChildrenLife\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CheckChildrenLife), 
[CompositeDrawable.MakeChildAlive\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_MakeChildAlive\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.MakeChildDead\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_MakeChildDead\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.RequiresChildrenUpdate](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RequiresChildrenUpdate), 
[CompositeDrawable.UpdateSubTree\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateSubTree), 
[CompositeDrawable.UpdateSubTreeMasking\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateSubTreeMasking), 
[CompositeDrawable.ComputeIsMaskedAway\(RectangleF\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ComputeIsMaskedAway\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[CompositeDrawable.ComputeChildMaskingBounds\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ComputeChildMaskingBounds), 
[CompositeDrawable.ChildMaskingBounds](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChildMaskingBounds), 
[CompositeDrawable.UpdateAfterChildrenLife\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateAfterChildrenLife), 
[CompositeDrawable.UpdateAfterChildren\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateAfterChildren), 
[CompositeDrawable.UpdateAfterAutoSize\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateAfterAutoSize), 
[CompositeDrawable.OnInvalidate\(Invalidation, InvalidationSource\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_OnInvalidate\_osu\_Framework\_Graphics\_Invalidation\_osu\_Framework\_Layout\_InvalidationSource\_), 
[CompositeDrawable.CreateDrawNode\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CreateDrawNode), 
[CompositeDrawable.ForceLocalVertexBatch](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ForceLocalVertexBatch), 
[CompositeDrawable.CanBeFlattened](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CanBeFlattened), 
[CompositeDrawable.RemoveCompletedTransforms](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RemoveCompletedTransforms), 
[CompositeDrawable.ApplyTransformsAt\(double, bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ApplyTransformsAt\_System\_Double\_System\_Boolean\_), 
[CompositeDrawable.ClearTransformsAfter\(double, bool, string\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ClearTransformsAfter\_System\_Double\_System\_Boolean\_System\_String\_), 
[CompositeDrawable.ScheduleAfterChildren<T\>\(Action<T\>, T\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ScheduleAfterChildren\_\_1\_System\_Action\_\_\_0\_\_\_\_0\_), 
[CompositeDrawable.ScheduleAfterChildren\(Action\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ScheduleAfterChildren\_System\_Action\_), 
[CompositeDrawable.BeginAbsoluteSequence\(double, bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BeginAbsoluteSequence\_System\_Double\_System\_Boolean\_), 
[CompositeDrawable.FinishTransforms\(bool, string\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_FinishTransforms\_System\_Boolean\_System\_String\_), 
[CompositeDrawable.FadeEdgeEffectTo\(float, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_FadeEdgeEffectTo\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.FadeEdgeEffectTo\(Color4, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_FadeEdgeEffectTo\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.TweenEdgeEffectTo\(EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_TweenEdgeEffectTo\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.Contains\(Vector2\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Contains\_osuTK\_Vector2\_), 
[CompositeDrawable.ShouldBeConsideredForInput\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ShouldBeConsideredForInput\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.ReceivePositionalInputAtSubTree\(Vector2\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ReceivePositionalInputAtSubTree\_osuTK\_Vector2\_), 
[CompositeDrawable.Masking](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Masking), 
[CompositeDrawable.MaskingSmoothness](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_MaskingSmoothness), 
[CompositeDrawable.CornerRadius](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CornerRadius), 
[CompositeDrawable.CornerExponent](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CornerExponent), 
[CompositeDrawable.BorderThickness](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BorderThickness), 
[CompositeDrawable.BorderColour](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BorderColour), 
[CompositeDrawable.EdgeEffect](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_EdgeEffect), 
[CompositeDrawable.BoundingBox](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BoundingBox), 
[CompositeDrawable.Padding](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Padding), 
[CompositeDrawable.ChildSize](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChildSize), 
[CompositeDrawable.ChildOffset](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChildOffset), 
[CompositeDrawable.RelativeChildSize](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeChildSize), 
[CompositeDrawable.RelativeChildOffset](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeChildOffset), 
[CompositeDrawable.RelativeToAbsoluteFactor](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeToAbsoluteFactor), 
[CompositeDrawable.TransformRelativeChildSizeTo\(Vector2, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_TransformRelativeChildSizeTo\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.TransformRelativeChildOffsetTo\(Vector2, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_TransformRelativeChildOffsetTo\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.RelativeSizeAxes](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeSizeAxes), 
[CompositeDrawable.AutoSizeAxes](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AutoSizeAxes), 
[CompositeDrawable.AutoSizeDuration](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AutoSizeDuration), 
[CompositeDrawable.AutoSizeEasing](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AutoSizeEasing), 
[CompositeDrawable.Width](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Width), 
[CompositeDrawable.Height](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Height), 
[CompositeDrawable.Size](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Size), 
[CompositeDrawable.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[Drawable.Dispose\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Dispose), 
[Drawable.IsDisposed](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsDisposed), 
[Drawable.Dispose\(bool\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Dispose\_System\_Boolean\_), 
[Drawable.DisposeOnDeathRemoval](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DisposeOnDeathRemoval), 
[Drawable.IsLoaded](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsLoaded), 
[Drawable.LoadState](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LoadState), 
[Drawable.InjectDependencies\(IReadOnlyDependencyContainer\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_InjectDependencies\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[Drawable.LoadAsyncComplete\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LoadAsyncComplete), 
[Drawable.LoadComplete\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LoadComplete), 
[Drawable.IsAlive](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsAlive), 
[Drawable.Depth](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Depth), 
[Drawable.OnUpdate](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnUpdate), 
[Drawable.OnLoadComplete](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnLoadComplete), 
[Drawable.Scheduler](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Scheduler), 
[Drawable.UpdateSubTree\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_UpdateSubTree), 
[Drawable.ComputeMaskingBounds\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ComputeMaskingBounds), 
[Drawable.UpdateSubTreeMasking\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_UpdateSubTreeMasking), 
[Drawable.ComputeIsMaskedAway\(RectangleF\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ComputeIsMaskedAway\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[Drawable.Update\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Update), 
[Drawable.Position](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Position), 
[Drawable.X](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_X), 
[Drawable.Y](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Y), 
[Drawable.RelativePositionAxes](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativePositionAxes), 
[Drawable.DrawPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawPosition), 
[Drawable.Size](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Size), 
[Drawable.Width](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Width), 
[Drawable.Height](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Height), 
[Drawable.RelativeSizeAxes](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativeSizeAxes), 
[Drawable.DrawSize](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawSize), 
[Drawable.DrawWidth](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawWidth), 
[Drawable.DrawHeight](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawHeight), 
[Drawable.Margin](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Margin), 
[Drawable.LayoutSize](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LayoutSize), 
[Drawable.DrawRectangle](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawRectangle), 
[Drawable.LayoutRectangle](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LayoutRectangle), 
[Drawable.ApplyRelativeAxes\(Axes, Vector2, FillMode\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ApplyRelativeAxes\_osu\_Framework\_Graphics\_Axes\_osuTK\_Vector2\_osu\_Framework\_Graphics\_FillMode\_), 
[Drawable.BypassAutoSizeAxes](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_BypassAutoSizeAxes), 
[Drawable.BoundingBox](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_BoundingBox), 
[Drawable.OnSizingChanged\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnSizingChanged), 
[Drawable.Scale](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Scale), 
[Drawable.FillAspectRatio](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_FillAspectRatio), 
[Drawable.FillMode](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_FillMode), 
[Drawable.DrawScale](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawScale), 
[Drawable.Shear](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Shear), 
[Drawable.Rotation](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Rotation), 
[Drawable.Origin](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Origin), 
[Drawable.RelativeOriginPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativeOriginPosition), 
[Drawable.OriginPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OriginPosition), 
[Drawable.Anchor](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Anchor), 
[Drawable.RelativeAnchorPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativeAnchorPosition), 
[Drawable.AnchorPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AnchorPosition), 
[Drawable.Colour](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Colour), 
[Drawable.Alpha](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Alpha), 
[Drawable.IsPresent](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsPresent), 
[Drawable.AlwaysPresent](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AlwaysPresent), 
[Drawable.Blending](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Blending), 
[Drawable.Clock](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Clock), 
[Drawable.ProcessCustomClock](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ProcessCustomClock), 
[Drawable.LifetimeStart](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LifetimeStart), 
[Drawable.LifetimeEnd](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LifetimeEnd), 
[Drawable.ShouldBeAlive](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ShouldBeAlive), 
[Drawable.RemoveWhenNotAlive](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RemoveWhenNotAlive), 
[Drawable.GetContainingInputManager\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_GetContainingInputManager), 
[Drawable.GetContainingFocusManager\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_GetContainingFocusManager), 
[Drawable.Parent](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Parent), 
[Drawable.HasProxy](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HasProxy), 
[Drawable.IsProxy](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsProxy), 
[Drawable.CreateProxy\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_CreateProxy), 
[Drawable.ComputeScreenSpaceDrawQuad\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ComputeScreenSpaceDrawQuad), 
[Drawable.ScreenSpaceDrawQuad](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ScreenSpaceDrawQuad), 
[Drawable.DrawInfo](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawInfo), 
[Drawable.DrawColourInfo](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawColourInfo), 
[Drawable.AddLayout\(LayoutMember\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AddLayout\_osu\_Framework\_Layout\_LayoutMember\_), 
[Drawable.InvalidationID](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_InvalidationID), 
[Drawable.Invalidate\(Invalidation, InvalidationSource\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Invalidate\_osu\_Framework\_Graphics\_Invalidation\_osu\_Framework\_Layout\_InvalidationSource\_), 
[Drawable.OnInvalidate\(Invalidation, InvalidationSource\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnInvalidate\_osu\_Framework\_Graphics\_Invalidation\_osu\_Framework\_Layout\_InvalidationSource\_), 
[Drawable.InvalidationFromParentSize](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_InvalidationFromParentSize), 
[Drawable.CreateDrawNode\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_CreateDrawNode), 
[Drawable.ToSpaceOfOtherDrawable\(Vector2, IDrawable\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToSpaceOfOtherDrawable\_osuTK\_Vector2\_osu\_Framework\_Graphics\_IDrawable\_), 
[Drawable.ToSpaceOfOtherDrawable\(RectangleF, IDrawable\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToSpaceOfOtherDrawable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_osu\_Framework\_Graphics\_IDrawable\_), 
[Drawable.ToParentSpace\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToParentSpace\_osuTK\_Vector2\_), 
[Drawable.ToParentSpace\(RectangleF\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToParentSpace\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[Drawable.ToScreenSpace\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToScreenSpace\_osuTK\_Vector2\_), 
[Drawable.ToScreenSpace\(RectangleF\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToScreenSpace\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[Drawable.ToLocalSpace\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToLocalSpace\_osuTK\_Vector2\_), 
[Drawable.ToLocalSpace\(Quad\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToLocalSpace\_osu\_Framework\_Graphics\_Primitives\_Quad\_), 
[Drawable.Handle\(UIEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Handle\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[Drawable.TriggerEvent\(UIEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_TriggerEvent\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[Drawable.TriggerClick\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_TriggerClick), 
[Drawable.OnMouseMove\(MouseMoveEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMouseMove\_osu\_Framework\_Input\_Events\_MouseMoveEvent\_), 
[Drawable.OnHover\(HoverEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnHover\_osu\_Framework\_Input\_Events\_HoverEvent\_), 
[Drawable.OnHoverLost\(HoverLostEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnHoverLost\_osu\_Framework\_Input\_Events\_HoverLostEvent\_), 
[Drawable.OnMouseDown\(MouseDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMouseDown\_osu\_Framework\_Input\_Events\_MouseDownEvent\_), 
[Drawable.OnMouseUp\(MouseUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMouseUp\_osu\_Framework\_Input\_Events\_MouseUpEvent\_), 
[Drawable.OnClick\(ClickEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnClick\_osu\_Framework\_Input\_Events\_ClickEvent\_), 
[Drawable.OnDoubleClick\(DoubleClickEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDoubleClick\_osu\_Framework\_Input\_Events\_DoubleClickEvent\_), 
[Drawable.OnDragStart\(DragStartEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDragStart\_osu\_Framework\_Input\_Events\_DragStartEvent\_), 
[Drawable.OnDrag\(DragEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDrag\_osu\_Framework\_Input\_Events\_DragEvent\_), 
[Drawable.OnDragEnd\(DragEndEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDragEnd\_osu\_Framework\_Input\_Events\_DragEndEvent\_), 
[Drawable.OnScroll\(ScrollEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnScroll\_osu\_Framework\_Input\_Events\_ScrollEvent\_), 
[Drawable.OnFocus\(FocusEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnFocus\_osu\_Framework\_Input\_Events\_FocusEvent\_), 
[Drawable.OnFocusLost\(FocusLostEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnFocusLost\_osu\_Framework\_Input\_Events\_FocusLostEvent\_), 
[Drawable.OnKeyDown\(KeyDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnKeyDown\_osu\_Framework\_Input\_Events\_KeyDownEvent\_), 
[Drawable.OnKeyUp\(KeyUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnKeyUp\_osu\_Framework\_Input\_Events\_KeyUpEvent\_), 
[Drawable.OnTouchDown\(TouchDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTouchDown\_osu\_Framework\_Input\_Events\_TouchDownEvent\_), 
[Drawable.OnTouchMove\(TouchMoveEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTouchMove\_osu\_Framework\_Input\_Events\_TouchMoveEvent\_), 
[Drawable.OnTouchUp\(TouchUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTouchUp\_osu\_Framework\_Input\_Events\_TouchUpEvent\_), 
[Drawable.OnJoystickPress\(JoystickPressEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnJoystickPress\_osu\_Framework\_Input\_Events\_JoystickPressEvent\_), 
[Drawable.OnJoystickRelease\(JoystickReleaseEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnJoystickRelease\_osu\_Framework\_Input\_Events\_JoystickReleaseEvent\_), 
[Drawable.OnJoystickAxisMove\(JoystickAxisMoveEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnJoystickAxisMove\_osu\_Framework\_Input\_Events\_JoystickAxisMoveEvent\_), 
[Drawable.OnMidiDown\(MidiDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMidiDown\_osu\_Framework\_Input\_Events\_MidiDownEvent\_), 
[Drawable.OnMidiUp\(MidiUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMidiUp\_osu\_Framework\_Input\_Events\_MidiUpEvent\_), 
[Drawable.OnTabletPenButtonPress\(TabletPenButtonPressEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletPenButtonPress\_osu\_Framework\_Input\_Events\_TabletPenButtonPressEvent\_), 
[Drawable.OnTabletPenButtonRelease\(TabletPenButtonReleaseEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletPenButtonRelease\_osu\_Framework\_Input\_Events\_TabletPenButtonReleaseEvent\_), 
[Drawable.OnTabletAuxiliaryButtonPress\(TabletAuxiliaryButtonPressEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletAuxiliaryButtonPress\_osu\_Framework\_Input\_Events\_TabletAuxiliaryButtonPressEvent\_), 
[Drawable.OnTabletAuxiliaryButtonRelease\(TabletAuxiliaryButtonReleaseEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletAuxiliaryButtonRelease\_osu\_Framework\_Input\_Events\_TabletAuxiliaryButtonReleaseEvent\_), 
[Drawable.HandleNonPositionalInput](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HandleNonPositionalInput), 
[Drawable.HandlePositionalInput](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HandlePositionalInput), 
[Drawable.HasFocus](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HasFocus), 
[Drawable.RequestsFocus](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RequestsFocus), 
[Drawable.AcceptsFocus](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AcceptsFocus), 
[Drawable.ChangeFocusOnClick](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ChangeFocusOnClick), 
[Drawable.IsHovered](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsHovered), 
[Drawable.IsDragged](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsDragged), 
[Drawable.ReceivePositionalInputAt\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ReceivePositionalInputAt\_osuTK\_Vector2\_), 
[Drawable.Contains\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Contains\_osuTK\_Vector2\_), 
[Drawable.PropagateNonPositionalInputSubTree](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_PropagateNonPositionalInputSubTree), 
[Drawable.PropagatePositionalInputSubTree](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_PropagatePositionalInputSubTree), 
[Drawable.DragBlocksClick](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DragBlocksClick), 
[Drawable.Schedule<T\>\(Action<T\>, T\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Schedule\_\_1\_System\_Action\_\_\_0\_\_\_\_0\_), 
[Drawable.Schedule\(Action\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Schedule\_System\_Action\_), 
[Drawable.Expire\(bool\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Expire\_System\_Boolean\_), 
[Drawable.Hide\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Hide), 
[Drawable.Show\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Show), 
[Drawable.WithEffect<T\>\(IEffect<T\>, Action<T\>\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_WithEffect\_\_1\_osu\_Framework\_Graphics\_Effects\_IEffect\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[Drawable.Name](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Name), 
[Drawable.ToString\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToString), 
[Drawable.Empty\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Empty), 
[Drawable.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[Transformable.Clock](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_Clock), 
[Transformable.Time](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_Time), 
[Transformable.TransformStartTime](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_TransformStartTime), 
[Transformable.TransformDelay](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_TransformDelay), 
[Transformable.Transforms](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_Transforms), 
[Transformable.TransformsForTargetMember\(string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_TransformsForTargetMember\_System\_String\_), 
[Transformable.LatestTransformEndTime](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_LatestTransformEndTime), 
[Transformable.RemoveCompletedTransforms](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_RemoveCompletedTransforms), 
[Transformable.UpdateTransforms\(\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_UpdateTransforms), 
[Transformable.RemoveTransform\(Transform\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_RemoveTransform\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[Transformable.ClearTransforms\(bool, string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_ClearTransforms\_System\_Boolean\_System\_String\_), 
[Transformable.ClearTransformsAfter\(double, bool, string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_ClearTransformsAfter\_System\_Double\_System\_Boolean\_System\_String\_), 
[Transformable.ApplyTransformsAt\(double, bool\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_ApplyTransformsAt\_System\_Double\_System\_Boolean\_), 
[Transformable.FinishTransforms\(bool, string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_FinishTransforms\_System\_Boolean\_System\_String\_), 
[Transformable.BeginDelayedSequence\(double, bool\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_BeginDelayedSequence\_System\_Double\_System\_Boolean\_), 
[Transformable.BeginAbsoluteSequence\(double, bool\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_BeginAbsoluteSequence\_System\_Double\_System\_Boolean\_), 
[Transformable.AddTransform\(Transform, ulong?\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_AddTransform\_osu\_Framework\_Graphics\_Transforms\_Transform\_System\_Nullable\_System\_UInt64\_\_), 
[Transformable.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[TransformableExtensions.Animate<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, params TransformSequence<TestScenePassThroughInputManager.TestInputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, params TransformSequence<TestScenePassThroughInputManager.TestInputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Color4, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Color4, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[EnumerableExtensions.ForEach<Drawable\>\(IEnumerable<Drawable\>, Action<Drawable\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<Drawable\>\(IEnumerable<Drawable\>, Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<Drawable\>\(IEnumerable<Drawable\>, Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<Drawable\>\(IEnumerable<Drawable\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, int, params TransformSequence<TestScenePassThroughInputManager.TestInputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, params TransformSequence<TestScenePassThroughInputManager.TestInputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, params TransformSequence<TestScenePassThroughInputManager.TestInputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<TestScenePassThroughInputManager.TestInputManager, TValue\>\(TestScenePassThroughInputManager.TestInputManager, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<TestScenePassThroughInputManager.TestInputManager, TEasing, TValue\>\(TestScenePassThroughInputManager.TestInputManager, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Transform<TValue, DefaultEasingFunction, TestScenePassThroughInputManager.TestInputManager\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Transform<TValue, TEasing, TestScenePassThroughInputManager.TestInputManager\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<TestScenePassThroughInputManager.TestInputManager, TValue\>\(TestScenePassThroughInputManager.TestInputManager, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<TestScenePassThroughInputManager.TestInputManager, TValue, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformTo<TestScenePassThroughInputManager.TestInputManager, TValue\>\(TestScenePassThroughInputManager.TestInputManager, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<TestScenePassThroughInputManager.TestInputManager, TValue, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[TransformableExtensions.TweenEdgeEffectTo<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TweenEdgeEffectTo<TestScenePassThroughInputManager.TestInputManager, TEasing\>\(TestScenePassThroughInputManager.TestInputManager, EdgeEffectParameters, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.With<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager, Action<TestScenePassThroughInputManager.TestInputManager\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<TestScenePassThroughInputManager.TestInputManager, TChild\>\(TestScenePassThroughInputManager.TestInputManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestScenePassThroughInputManager.TestInputManager, TChild\>\(TestScenePassThroughInputManager.TestInputManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestScenePassThroughInputManager.TestInputManager, TChild\>\(TestScenePassThroughInputManager.TestInputManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestScenePassThroughInputManager.TestInputManager\>\(TestScenePassThroughInputManager.TestInputManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager__ctor"></a> TestInputManager\(\)

```csharp
public TestInputManager()
```

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager__ctor"></a> TestInputManager\(\)

```csharp
public TestInputManager()
```

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager__ctor"></a> TestInputManager\(\)

```csharp
public TestInputManager()
```

## Fields

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager_Status"></a> Status

```csharp
public readonly TestSceneInputManager.ContainingInputManagerStatusText Status
```

#### Field Value

 [TestSceneInputManager](osu.Framework.Tests.Visual.Input.TestSceneInputManager.md).[ContainingInputManagerStatusText](osu.Framework.Tests.Visual.Input.TestSceneInputManager.ContainingInputManagerStatusText.md)

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager_Status"></a> Status

```csharp
public readonly TestSceneInputManager.ContainingInputManagerStatusText Status
```

#### Field Value

 [TestSceneInputManager](osu.Framework.Tests.Visual.Input.TestSceneInputManager.md).[ContainingInputManagerStatusText](osu.Framework.Tests.Visual.Input.TestSceneInputManager.ContainingInputManagerStatusText.md)

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager_Status"></a> Status

```csharp
public readonly TestSceneInputManager.ContainingInputManagerStatusText Status
```

#### Field Value

 [TestSceneInputManager](osu.Framework.Tests.Visual.Input.TestSceneInputManager.md).[ContainingInputManagerStatusText](osu.Framework.Tests.Visual.Input.TestSceneInputManager.ContainingInputManagerStatusText.md)

## Methods

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_Input_TestScenePassThroughInputManager_TestInputManager_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

