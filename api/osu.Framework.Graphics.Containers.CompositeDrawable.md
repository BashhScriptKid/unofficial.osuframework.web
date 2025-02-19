# <a id="osu_Framework_Graphics_Containers_CompositeDrawable"></a> Class CompositeDrawable

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

A drawable consisting of a composite of child drawables which are
managed by the composite object itself. Transformations applied to
a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> are also applied to its children.
Additionally, <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>s support various effects, such as masking, edge effect,
padding, and automatic sizing depending on their children.

```csharp
public abstract class CompositeDrawable : Drawable, IDependencyInjectionCandidate, IDisposable, IDrawable, ITransformable, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedDependencyActivator, ISourceGeneratedHandleInputCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)

#### Derived

[AudioChannelDisplay](osu.Framework.Graphics.Visualisation.Audio.AudioChannelDisplay.md), 
[BasicHSVColourPicker.BasicHueSelectorNub](osu.Framework.Graphics.UserInterface.BasicHSVColourPicker.BasicHueSelectorNub.md), 
[Caret](osu.Framework.Graphics.UserInterface.Caret.md), 
[ColourPicker](osu.Framework.Graphics.UserInterface.ColourPicker.md), 
[HexColourPicker.ColourPreview](osu.Framework.Graphics.UserInterface.HexColourPicker.ColourPreview.md), 
[CompositeComponent](osu.Framework.Graphics.Containers.CompositeComponent.md), 
[Container<T\>](osu.Framework.Graphics.Containers.Container\-1.md), 
[Counter](osu.Framework.Graphics.UserInterface.Counter.md), 
[CustomisableSizeCompositeDrawable](osu.Framework.Graphics.Animations.CustomisableSizeCompositeDrawable.md), 
[TestSceneDelayedLoadUnloadWrapper.DelayedLoadTestDrawable](osu.Framework.Tests.Visual.Drawables.TestSceneDelayedLoadUnloadWrapper.DelayedLoadTestDrawable.md), 
[DelayedLoadWrapper](osu.Framework.Graphics.Containers.DelayedLoadWrapper.md), 
[DirectorySelector](osu.Framework.Graphics.UserInterface.DirectorySelector.md), 
[DirectorySelectorBreadcrumbDisplay](osu.Framework.Graphics.UserInterface.DirectorySelectorBreadcrumbDisplay.md), 
[DirectorySelectorItem](osu.Framework.Graphics.UserInterface.DirectorySelectorItem.md), 
[TestSceneActiveState.DisplayBox](osu.Framework.Tests.Visual.Platform.TestSceneActiveState.DisplayBox.md), 
[DrawableAudioWrapper](osu.Framework.Graphics.Audio.DrawableAudioWrapper.md), 
[Menu.DrawableMenuItem](osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem.md), 
[DrawablePool<T\>](osu.Framework.Graphics.Pooling.DrawablePool\-1.md), 
[Dropdown<T\>](osu.Framework.Graphics.UserInterface.Dropdown\-1.md), 
[TestSceneMouseStates.StateTracker.EventCounter](osu.Framework.Tests.Visual.Input.TestSceneMouseStates.StateTracker.EventCounter.md), 
[TestSceneFocus.FocusBox](osu.Framework.Tests.Visual.Drawables.TestSceneFocus.FocusBox.md), 
[TestSceneSamples.Grid](osu.Framework.Tests.Visual.Audio.TestSceneSamples.Grid.md), 
[GridContainer](osu.Framework.Graphics.Containers.GridContainer.md), 
[HSVColourPicker](osu.Framework.Graphics.UserInterface.HSVColourPicker.md), 
[HexColourPicker](osu.Framework.Graphics.UserInterface.HexColourPicker.md), 
[HSVColourPicker.HueSelector](osu.Framework.Graphics.UserInterface.HSVColourPicker.HueSelector.md), 
[MarkdownImage.ImageContainer](osu.Framework.Graphics.Containers.Markdown.MarkdownImage.ImageContainer.md), 
[VirtualisedListContainer<TData, TDrawable\>.ItemRow](osu.Framework.Graphics.Containers.VirtualisedListContainer\-2.ItemRow.md), 
[TestSceneReadableKeyCombinationProvider.Key](osu.Framework.Tests.Visual.Input.TestSceneReadableKeyCombinationProvider.Key.md), 
[LifetimeManagementContainer](osu.Framework.Graphics.Containers.LifetimeManagementContainer.md), 
[MarkdownCodeBlock](osu.Framework.Graphics.Containers.Markdown.MarkdownCodeBlock.md), 
[MarkdownContainer](osu.Framework.Graphics.Containers.Markdown.MarkdownContainer.md), 
[MarkdownFootnote](osu.Framework.Graphics.Containers.Markdown.Footnotes.MarkdownFootnote.md), 
[MarkdownFootnoteBacklink](osu.Framework.Graphics.Containers.Markdown.Footnotes.MarkdownFootnoteBacklink.md), 
[MarkdownFootnoteLink](osu.Framework.Graphics.Containers.Markdown.Footnotes.MarkdownFootnoteLink.md), 
[MarkdownHeading](osu.Framework.Graphics.Containers.Markdown.MarkdownHeading.md), 
[MarkdownImage](osu.Framework.Graphics.Containers.Markdown.MarkdownImage.md), 
[MarkdownLinkText](osu.Framework.Graphics.Containers.Markdown.MarkdownLinkText.md), 
[MarkdownParagraph](osu.Framework.Graphics.Containers.Markdown.MarkdownParagraph.md), 
[MarkdownQuoteBlock](osu.Framework.Graphics.Containers.Markdown.MarkdownQuoteBlock.md), 
[MarkdownSeparator](osu.Framework.Graphics.Containers.Markdown.MarkdownSeparator.md), 
[MarkdownTable](osu.Framework.Graphics.Containers.Markdown.MarkdownTable.md), 
[MarkdownTableCell](osu.Framework.Graphics.Containers.Markdown.MarkdownTableCell.md), 
[HSVColourPicker.SaturationValueSelector.Marker](osu.Framework.Graphics.UserInterface.HSVColourPicker.SaturationValueSelector.Marker.md), 
[Menu](osu.Framework.Graphics.UserInterface.Menu.md), 
[MixerDisplay](osu.Framework.Graphics.Visualisation.Audio.MixerDisplay.md), 
[ModelBackedDrawable<T\>](osu.Framework.Graphics.Containers.ModelBackedDrawable\-1.md), 
[NotImplementedMarkdown](osu.Framework.Graphics.Containers.Markdown.NotImplementedMarkdown.md), 
[TestSceneDrawableLoadCancellation.PausableLoadDrawable](osu.Framework.Tests.Visual.Drawables.TestSceneDrawableLoadCancellation.PausableLoadDrawable.md), 
[PoolableDrawable](osu.Framework.Graphics.Pooling.PoolableDrawable.md), 
[TestSceneReadableKeyCombinationProvider.PressedKeyCombinationDisplay](osu.Framework.Tests.Visual.Input.TestSceneReadableKeyCombinationProvider.PressedKeyCombinationDisplay.md), 
[RearrangeableListContainer<TModel\>](osu.Framework.Graphics.Containers.RearrangeableListContainer\-1.md), 
[RearrangeableListItem<TModel\>](osu.Framework.Graphics.Containers.RearrangeableListItem\-1.md), 
[HSVColourPicker.SaturationValueSelector](osu.Framework.Graphics.UserInterface.HSVColourPicker.SaturationValueSelector.md), 
[Screen](osu.Framework.Screens.Screen.md), 
[ScreenStack](osu.Framework.Screens.ScreenStack.md), 
[TestSceneDrawableLoadCancellation.SlowLoader](osu.Framework.Tests.Visual.Drawables.TestSceneDrawableLoadCancellation.SlowLoader.md), 
[StepButton](osu.Framework.Testing.Drawables.Steps.StepButton.md), 
[TabControl<T\>](osu.Framework.Graphics.UserInterface.TabControl\-1.md), 
[TableContainer](osu.Framework.Graphics.Containers.TableContainer.md), 
[TestBrowserTestRunner](osu.Framework.Testing.TestBrowserTestRunner.md), 
[TestSceneBindableAutoUnbinding.TestExposedBindableDrawable](osu.Framework.Tests.Visual.Bindables.TestSceneBindableAutoUnbinding.TestExposedBindableDrawable.md), 
[TestSceneTestRunner.TestRunner](osu.Framework.Testing.TestSceneTestRunner.TestRunner.md), 
[ToolbarSection](osu.Framework.Testing.Drawables.ToolbarSection.md), 
[TouchLongPressFeedback](osu.Framework.Graphics.Cursor.TouchLongPressFeedback.md), 
[TestSceneTouchVisualiser.TouchVisualiser](osu.Framework.Tests.Visual.Input.TestSceneTouchVisualiser.TouchVisualiser.md), 
[VirtualisedListContainer<TData, TDrawable\>](osu.Framework.Graphics.Containers.VirtualisedListContainer\-2.md), 
[TestSceneClock.VisualClock](osu.Framework.Tests.Visual.Clocks.TestSceneClock.VisualClock.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

#### Inherited Members

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

[TransformableExtensions.Animate<CompositeDrawable\>\(CompositeDrawable, params TransformSequence<CompositeDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<CompositeDrawable\>\(CompositeDrawable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<CompositeDrawable\>\(CompositeDrawable, double, params TransformSequence<CompositeDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<CompositeDrawable\>\(CompositeDrawable\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<CompositeDrawable\>\(CompositeDrawable, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<CompositeDrawable, TEasing\>\(CompositeDrawable, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<CompositeDrawable\>\(CompositeDrawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<CompositeDrawable, TEasing\>\(CompositeDrawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<CompositeDrawable\>\(CompositeDrawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<CompositeDrawable, TEasing\>\(CompositeDrawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<CompositeDrawable\>\(CompositeDrawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<CompositeDrawable, TEasing\>\(CompositeDrawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<CompositeDrawable\>\(CompositeDrawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<CompositeDrawable, TEasing\>\(CompositeDrawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<CompositeDrawable\>\(CompositeDrawable, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<CompositeDrawable, TEasing\>\(CompositeDrawable, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CompositeDrawable\>\(CompositeDrawable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<CompositeDrawable\>\(CompositeDrawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CompositeDrawable\>\(CompositeDrawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<CompositeDrawable\>\(CompositeDrawable, double, int, params TransformSequence<CompositeDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<CompositeDrawable\>\(CompositeDrawable, double, params TransformSequence<CompositeDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<CompositeDrawable\>\(CompositeDrawable, params TransformSequence<CompositeDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<CompositeDrawable\>\(CompositeDrawable, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<CompositeDrawable, TValue\>\(CompositeDrawable, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<CompositeDrawable, TEasing, TValue\>\(CompositeDrawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<CompositeDrawable\>\(CompositeDrawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<CompositeDrawable\>\(CompositeDrawable, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<CompositeDrawable, TEasing\>\(CompositeDrawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<CompositeDrawable, TEasing\>\(CompositeDrawable, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<CompositeDrawable\>\(CompositeDrawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<CompositeDrawable, TEasing\>\(CompositeDrawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, CompositeDrawable\>\(CompositeDrawable, Transform<TValue, DefaultEasingFunction, CompositeDrawable\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, CompositeDrawable\>\(CompositeDrawable, Transform<TValue, TEasing, CompositeDrawable\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<CompositeDrawable\>\(CompositeDrawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<CompositeDrawable, TEasing\>\(CompositeDrawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<CompositeDrawable\>\(CompositeDrawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<CompositeDrawable\>\(CompositeDrawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<CompositeDrawable, TEasing\>\(CompositeDrawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<CompositeDrawable, TEasing\>\(CompositeDrawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<CompositeDrawable\>\(CompositeDrawable, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<CompositeDrawable\>\(CompositeDrawable, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<CompositeDrawable, TValue\>\(CompositeDrawable, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<CompositeDrawable, TValue, TEasing\>\(CompositeDrawable, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<CompositeDrawable, TValue\>\(CompositeDrawable, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<CompositeDrawable, TValue, TEasing\>\(CompositeDrawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<CompositeDrawable\>\(CompositeDrawable, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[DrawableExtensions.With<CompositeDrawable\>\(CompositeDrawable, Action<CompositeDrawable\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<CompositeDrawable, TChild\>\(CompositeDrawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CompositeDrawable, TChild\>\(CompositeDrawable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CompositeDrawable, TChild\>\(CompositeDrawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CompositeDrawable\>\(CompositeDrawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable__ctor"></a> CompositeDrawable\(\)

Constructs a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> that stores children.

```csharp
protected CompositeDrawable()
```

## Properties

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_AliveInternalChildren"></a> AliveInternalChildren

```csharp
protected IReadOnlyList<Drawable> AliveInternalChildren { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_AutoSizeAxes"></a> AutoSizeAxes

Controls which <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> are automatically sized w.r.t. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
Children's <xref href="osu.Framework.Graphics.Drawable.BypassAutoSizeAxes" data-throw-if-not-resolved="false"></xref> are ignored for automatic sizing.
Most notably, <xref href="osu.Framework.Graphics.Drawable.RelativePositionAxes" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> of children
do not affect automatic sizing to avoid circular size dependencies.
It is not allowed to manually set <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Size" data-throw-if-not-resolved="false"></xref> (or <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Width" data-throw-if-not-resolved="false"></xref> / <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Height" data-throw-if-not-resolved="false"></xref>)
on any <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> which are automatically sized.

```csharp
public virtual Axes AutoSizeAxes { get; protected set; }
```

#### Property Value

 [Axes](osu.Framework.Graphics.Axes.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_AutoSizeDuration"></a> AutoSizeDuration

The duration which automatic sizing should take. If zero, then it is instantaneous.
Otherwise, this is equivalent to applying an automatic size via a resize transform.

```csharp
public float AutoSizeDuration { get; protected set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_AutoSizeEasing"></a> AutoSizeEasing

The type of easing which should be used for smooth automatic sizing when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AutoSizeDuration" data-throw-if-not-resolved="false"></xref>
is non-zero.

```csharp
public Easing AutoSizeEasing { get; protected set; }
```

#### Property Value

 [Easing](osu.Framework.Graphics.Easing.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_BorderColour"></a> BorderColour

Determines the color of the border controlled by <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.BorderThickness" data-throw-if-not-resolved="false"></xref>.
Only has an effect when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Masking" data-throw-if-not-resolved="false"></xref> is true.

```csharp
public ColourInfo BorderColour { get; protected set; }
```

#### Property Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_BorderThickness"></a> BorderThickness

Determines how thick of a border to draw around the inside of the masked region.
Only has an effect when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Masking" data-throw-if-not-resolved="false"></xref> is true.
The border only is drawn on top of children using a sprite shader.

```csharp
public float BorderThickness { get; protected set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Remarks

Drawing borders is optimized heavily into our sprite shaders. As a consequence
borders are only drawn correctly on top of quad-shaped children using our sprite
shaders.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_BoundingBox"></a> BoundingBox

Computes the bounding box of this drawable in its parent's space.

```csharp
public override RectangleF BoundingBox { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CanBeFlattened"></a> CanBeFlattened

A flattened <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> has its <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> merged into its parents'.
In some cases, the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> must always be generated and flattening should not occur.

```csharp
protected virtual bool CanBeFlattened { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChildMaskingBounds"></a> ChildMaskingBounds

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> to be used as the masking bounds for all <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AliveInternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
public RectangleF ChildMaskingBounds { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChildOffset"></a> ChildOffset

Positional offset applied to <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
Captures the effect of e.g. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Padding" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 ChildOffset { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChildSize"></a> ChildSize

The size of the coordinate space revealed to <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
Captures the effect of e.g. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Padding" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 ChildSize { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CornerExponent"></a> CornerExponent

Determines how gentle the curve of the corner straightens. A value of 2 (default) results in
circular arcs, a value of 2.5 results in something closer to apple's "continuous corner".
Values between 2 and 10 result in varying degrees of "continuousness", where larger values are smoother.
Values between 1 and 2 result in a "flatter" appearance than round corners.
Values between 0 and 1 result in a concave, round corner as opposed to a convex round corner,
where a value of 0.5 is a circular concave arc.
Only has an effect when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Masking" data-throw-if-not-resolved="false"></xref> is true and <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.CornerRadius" data-throw-if-not-resolved="false"></xref> is non-zero.

```csharp
public float CornerExponent { get; protected set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CornerRadius"></a> CornerRadius

Determines how large of a radius is masked away around the corners.
Only has an effect when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Masking" data-throw-if-not-resolved="false"></xref> is true.

```csharp
public float CornerRadius { get; protected set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Dependencies"></a> Dependencies

Contains all dependencies that can be injected into this CompositeDrawable's children using <xref href="osu.Framework.Allocation.BackgroundDependencyLoaderAttribute" data-throw-if-not-resolved="false"></xref>.
Add or override dependencies by calling <xref href="osu.Framework.Allocation.DependencyContainer.Cache(System.Object)" data-throw-if-not-resolved="false"></xref>.

```csharp
public IReadOnlyDependencyContainer Dependencies { get; }
```

#### Property Value

 [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_EdgeEffect"></a> EdgeEffect

Determines an edge effect of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.
Edge effects are e.g. glow or a shadow.
Only has an effect when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Masking" data-throw-if-not-resolved="false"></xref> is true.

```csharp
public EdgeEffectParameters EdgeEffect { get; protected set; }
```

#### Property Value

 [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ForceLocalVertexBatch"></a> ForceLocalVertexBatch

Whether to use a local vertex batch for rendering. If false, a parenting vertex batch will be used.

```csharp
public bool ForceLocalVertexBatch { get; protected set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Height"></a> Height

Y component of <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
public override float Height { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_InternalChild"></a> InternalChild

Gets or sets the only child in <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected Drawable InternalChild { get; set; }
```

#### Property Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_InternalChildren"></a> InternalChildren

This <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> list of children. Assigning to this property will dispose all existing children of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected IReadOnlyList<Drawable> InternalChildren { get; set; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_InternalChildrenEnumerable"></a> InternalChildrenEnumerable

Replaces all internal children of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> with the elements contained in the enumerable.

```csharp
protected IEnumerable<Drawable> InternalChildrenEnumerable { set; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Masking"></a> Masking

If enabled, only the portion of children that falls within this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>'s
shape is drawn to the screen.

```csharp
public bool Masking { get; protected set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_MaskingSmoothness"></a> MaskingSmoothness

Determines over how many pixels the alpha component smoothly fades out.
Only has an effect when <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Masking" data-throw-if-not-resolved="false"></xref> is true.

```csharp
public float MaskingSmoothness { get; protected set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Padding"></a> Padding

Shrinks the space children may occupy within this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>
by the specified amount on each side.

```csharp
public MarginPadding Padding { get; protected set; }
```

#### Property Value

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RelativeChildOffset"></a> RelativeChildOffset

The offset of the relative position/size coordinate space of children of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.
Children positioned at this offset will appear as if they were positioned at <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> = <xref href="osuTK.Vector2.Zero" data-throw-if-not-resolved="false"></xref> in this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 RelativeChildOffset { get; protected set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RelativeChildSize"></a> RelativeChildSize

The size of the relative position/size coordinate space of children of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.
Children positioned at this size will appear as if they were positioned at <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> = <xref href="osuTK.Vector2.One" data-throw-if-not-resolved="false"></xref> in this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 RelativeChildSize { get; protected set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RelativeSizeAxes"></a> RelativeSizeAxes

Controls which <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> are relative sizes w.r.t. <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s size
(from 0 to 1) in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system, rather than absolute sizes.
The <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> set in this property are ignored by automatically sizing
parents.

```csharp
public override Axes RelativeSizeAxes { get; set; }
```

#### Property Value

 [Axes](osu.Framework.Graphics.Axes.md)

#### Remarks

If an axis becomes relatively sized and its component of <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> was previously 0,
then it automatically becomes 1. In all other cases <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> is converted such that
<xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref> remains invariant across changes of this property.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RelativeToAbsoluteFactor"></a> RelativeToAbsoluteFactor

Conversion factor from relative to absolute coordinates in our space.

```csharp
public Vector2 RelativeToAbsoluteFactor { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RemoveCompletedTransforms"></a> RemoveCompletedTransforms

Whether to remove completed transforms from the list of applicable transforms. Setting this to false allows for rewinding transforms.
<p>
This value is passed down to children.
</p>

```csharp
public override bool RemoveCompletedTransforms { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RequiresChildrenUpdate"></a> RequiresChildrenUpdate

Specifies whether this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> requires an update of its children.
If the return value is false, then children are not updated and
<xref href="osu.Framework.Graphics.Containers.CompositeDrawable.UpdateAfterChildren" data-throw-if-not-resolved="false"></xref> is not called.

```csharp
protected virtual bool RequiresChildrenUpdate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_SchedulerAfterChildren"></a> SchedulerAfterChildren

A lazily-initialized scheduler used to schedule tasks to be invoked in future <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.UpdateAfterChildren" data-throw-if-not-resolved="false"></xref>s calls.
The tasks are invoked at the beginning of the <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.UpdateAfterChildren" data-throw-if-not-resolved="false"></xref> method before anything else.

```csharp
protected Scheduler SchedulerAfterChildren { get; }
```

#### Property Value

 [Scheduler](osu.Framework.Threading.Scheduler.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Size"></a> Size

Size of this Drawable in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.
May be in absolute or relative units (controlled by <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref>).

```csharp
public override Vector2 Size { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Width"></a> Width

X component of <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
public override float Width { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_AddInternal_osu_Framework_Graphics_Drawable_"></a> AddInternal\(Drawable\)

Adds a child to <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void AddInternal(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_AddRangeInternal_System_Collections_Generic_IEnumerable_osu_Framework_Graphics_Drawable__"></a> AddRangeInternal\(IEnumerable<Drawable\>\)

Adds a range of children to <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>. This is equivalent to calling
<xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AddInternal(osu.Framework.Graphics.Drawable)" data-throw-if-not-resolved="false"></xref> on each element of the range in order.

```csharp
protected void AddRangeInternal(IEnumerable<Drawable> range)
```

#### Parameters

`range` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ApplyTransformsAt_System_Double_System_Boolean_"></a> ApplyTransformsAt\(double, bool\)

Applies <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s at a point in time. This may only be called if <xref href="osu.Framework.Graphics.Transforms.Transformable.RemoveCompletedTransforms" data-throw-if-not-resolved="false"></xref> is set to false.
<p>
This does not change the clock time.
</p>

```csharp
public override void ApplyTransformsAt(double time, bool propagateChildren = false)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time to apply <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s at.

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to also apply children's <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s at <code class="paramref">time</code>.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_BeginAbsoluteSequence_System_Double_System_Boolean_"></a> BeginAbsoluteSequence\(double, bool\)

Start a sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s from an absolute time value (adjusts <xref href="osu.Framework.Graphics.Transforms.Transformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>).

```csharp
public override IDisposable BeginAbsoluteSequence(double newTransformStartTime, bool recursive = true)
```

#### Parameters

`newTransformStartTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The new value for <xref href="osu.Framework.Graphics.Transforms.Transformable.TransformStartTime" data-throw-if-not-resolved="false"></xref>.

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this should be applied to all children. True by default.

#### Returns

 [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

An <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used in a using() statement.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Absolute sequences should never be nested inside another existing sequence.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChangeInternalChildDepth_osu_Framework_Graphics_Drawable_System_Single_"></a> ChangeInternalChildDepth\(Drawable, float\)

Changes the depth of an internal child. This affects ordering of <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected void ChangeInternalChildDepth(Drawable child, float newDepth)
```

#### Parameters

`child` [Drawable](osu.Framework.Graphics.Drawable.md)

The child whose depth is to be changed.

`newDepth` [float](https://learn.microsoft.com/dotnet/api/system.single)

The new depth value to be set.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CheckChildrenLife"></a> CheckChildrenLife\(\)

Checks whether the alive state of any child has changed and processes it. This will add or remove
children from <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.aliveInternalChildren" data-throw-if-not-resolved="false"></xref> depending on their alive states.
<p>Note that this does NOT check the load state of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> to check if it can hold any alive children.</p>

```csharp
protected virtual bool CheckChildrenLife()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether any child's alive state has changed.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ClearInternal_System_Boolean_"></a> ClearInternal\(bool\)

Clear all of <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void ClearInternal(bool disposeChildren = true)
```

#### Parameters

`disposeChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether removed children should also get disposed.
Disposal will be recursive.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ClearTransformsAfter_System_Double_System_Boolean_System_String_"></a> ClearTransformsAfter\(double, bool, string\)

Removes <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s that start after <code class="paramref">time</code>.

```csharp
public override void ClearTransformsAfter(double time, bool propagateChildren = false, string targetMember = null)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time to clear <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s after.

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to also clear such <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s of children.

`targetMember` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional <xref href="osu.Framework.Graphics.Transforms.Transform.TargetMember" data-throw-if-not-resolved="false"></xref> name of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s to clear.
Null for clearing all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Compare_osu_Framework_Graphics_Drawable_osu_Framework_Graphics_Drawable_"></a> Compare\(Drawable, Drawable\)

Compares two <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref> to determine their sorting.

```csharp
protected virtual int Compare(Drawable x, Drawable y)
```

#### Parameters

`x` [Drawable](osu.Framework.Graphics.Drawable.md)

The first child to compare.

`y` [Drawable](osu.Framework.Graphics.Drawable.md)

The second child to compare.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

-1 if <code class="paramref">x</code> comes before <code class="paramref">y</code>, and 1 otherwise.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompareReverseChildID_osu_Framework_Graphics_Drawable_osu_Framework_Graphics_Drawable_"></a> CompareReverseChildID\(Drawable, Drawable\)

Helper method comparing children by their depth first, and then by their reversed child ID.

```csharp
protected int CompareReverseChildID(Drawable x, Drawable y)
```

#### Parameters

`x` [Drawable](osu.Framework.Graphics.Drawable.md)

The first child to compare.

`y` [Drawable](osu.Framework.Graphics.Drawable.md)

The second child to compare.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

-1 if <code class="paramref">x</code> comes before <code class="paramref">y</code>, and 1 otherwise.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ComputeChildMaskingBounds"></a> ComputeChildMaskingBounds\(\)

Computes the <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> to be used as the masking bounds for all <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AliveInternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual RectangleF ComputeChildMaskingBounds()
```

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> to be used as the masking bounds for <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AliveInternalChildren" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ComputeIsMaskedAway_osu_Framework_Graphics_Primitives_RectangleF_"></a> ComputeIsMaskedAway\(RectangleF\)

Computes whether this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is masked away.

```csharp
protected override bool ComputeIsMaskedAway(RectangleF maskingBounds)
```

#### Parameters

`maskingBounds` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> that defines the masking bounds.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is currently masked away.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Contains_osuTK_Vector2_"></a> Contains\(Vector2\)

Computes whether a given screen-space position is contained within this drawable.
Mouse input events are only received when this function is true, or when the drawable
is in focus.

```csharp
public override bool Contains(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

The screen space position to be checked against this drawable.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ContainsInternal_osu_Framework_Graphics_Drawable_"></a> ContainsInternal\(Drawable\)

Checks whether a given child is contained within <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected bool ContainsInternal(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CreateChildDependencies_osu_Framework_Allocation_IReadOnlyDependencyContainer_"></a> CreateChildDependencies\(IReadOnlyDependencyContainer\)

Create a local dependency container which will be used by our nested children.
If not overridden, the load-time parent's dependency tree will be used.

```csharp
protected virtual IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
```

#### Parameters

`parent` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The parent <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> which should be passed through if we want fallback lookups to work.

#### Returns

 [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

A new dependency container to be stored for this Drawable.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CreateDrawNode"></a> CreateDrawNode\(\)

Creates a draw node capable of containing all information required to draw this drawable.

```csharp
protected override DrawNode CreateDrawNode()
```

#### Returns

 [DrawNode](osu.Framework.Graphics.DrawNode.md)

The created draw node.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_Dispose_System_Boolean_"></a> Dispose\(bool\)

Disposes this drawable.

```csharp
protected override void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_FadeEdgeEffectTo_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> FadeEdgeEffectTo\(float, double, Easing\)

Helper function for creating and adding a <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> that fades the current <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.EdgeEffect" data-throw-if-not-resolved="false"></xref>.

```csharp
protected TransformSequence<CompositeDrawable> FadeEdgeEffectTo(float newAlpha, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_FadeEdgeEffectTo_osuTK_Graphics_Color4_System_Double_osu_Framework_Graphics_Easing_"></a> FadeEdgeEffectTo\(Color4, double, Easing\)

Helper function for creating and adding a <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> that fades the current <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.EdgeEffect" data-throw-if-not-resolved="false"></xref>.

```csharp
protected TransformSequence<CompositeDrawable> FadeEdgeEffectTo(Color4 newColour, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`newColour` Color4

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_FinishTransforms_System_Boolean_System_String_"></a> FinishTransforms\(bool, string\)

Finishes specified <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s, using their <xref href="osu.Framework.Graphics.Transforms.Transform%601.EndValue" data-throw-if-not-resolved="false"></xref>.

```csharp
public override void FinishTransforms(bool propagateChildren = false, string targetMember = null)
```

#### Parameters

`propagateChildren` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether we also finish the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s of children.

`targetMember` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional <xref href="osu.Framework.Graphics.Transforms.Transform.TargetMember" data-throw-if-not-resolved="false"></xref> name of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s to finish.
Null for finishing all <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_IndexOfInternal_osu_Framework_Graphics_Drawable_"></a> IndexOfInternal\(Drawable\)

The index of a given child within <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected int IndexOfInternal(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

If the child is found, its index. Otherwise, the negated index it would obtain
if it were added to <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

<ul><li>If the supplied <code class="paramref">drawable</code> is already attached to another <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>.</li><li>If a child drawable was matched using <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Compare(osu.Framework.Graphics.Drawable%2cosu.Framework.Graphics.Drawable)" data-throw-if-not-resolved="false"></xref>, but that child drawable was not the supplied <code class="paramref">drawable</code>.</li></ul>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_InjectDependencies_osu_Framework_Allocation_IReadOnlyDependencyContainer_"></a> InjectDependencies\(IReadOnlyDependencyContainer\)

Injects dependencies from an <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> into this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override sealed void InjectDependencies(IReadOnlyDependencyContainer dependencies)
```

#### Parameters

`dependencies` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The dependencies to inject.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_LoadAsyncComplete"></a> LoadAsyncComplete\(\)

Invoked after dependency injection has completed for this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> and all
children if this is a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void LoadAsyncComplete()
```

#### Remarks

This method is invoked in the potentially asynchronous context of <xref href="osu.Framework.Graphics.Drawable.Load(osu.Framework.Timing.IFrameBasedClock%2cosu.Framework.Allocation.IReadOnlyDependencyContainer%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref> prior to
this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> becoming <xref href="osu.Framework.Graphics.Drawable.IsLoaded" data-throw-if-not-resolved="false"></xref> = true.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_LoadComponent__1___0_"></a> LoadComponent<TLoadable\>\(TLoadable\)

Loads a future child or grand-child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> synchronously and immediately. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Dependencies" data-throw-if-not-resolved="false"></xref>
and <xref href="osu.Framework.Graphics.Drawable.Clock" data-throw-if-not-resolved="false"></xref> are inherited from this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.
<remarks>
This is generally useful if already in an asynchronous context and requiring forcefully (pre)loading content without adding it to the hierarchy.
</remarks>

```csharp
protected void LoadComponent<TLoadable>(TLoadable component) where TLoadable : Drawable
```

#### Parameters

`component` TLoadable

The child or grand-child to be loaded.

#### Type Parameters

`TLoadable` 

The type of the future future child or grand-child to be loaded.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_LoadComponentAsync__1___0_System_Action___0__System_Threading_CancellationToken_osu_Framework_Threading_Scheduler_"></a> LoadComponentAsync<TLoadable\>\(TLoadable, Action<TLoadable\>, CancellationToken, Scheduler\)

Loads a future child or grand-child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> asynchronously. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Dependencies" data-throw-if-not-resolved="false"></xref>
and <xref href="osu.Framework.Graphics.Drawable.Clock" data-throw-if-not-resolved="false"></xref> are inherited from this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

Note that this will always use the dependencies and clock from this instance. If you must load to a nested container level,
consider using <xref href="osu.Framework.Graphics.Containers.DelayedLoadWrapper" data-throw-if-not-resolved="false"></xref>

```csharp
protected Task LoadComponentAsync<TLoadable>(TLoadable component, Action<TLoadable> onLoaded = null, CancellationToken cancellation = default, Scheduler scheduler = null) where TLoadable : Drawable
```

#### Parameters

`component` TLoadable

The child or grand-child to be loaded.

`onLoaded` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TLoadable\>

Callback to be invoked on the update thread after loading is complete.

`cancellation` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

An optional cancellation token.

`scheduler` [Scheduler](osu.Framework.Threading.Scheduler.md)

The scheduler for <code class="paramref">onLoaded</code> to be invoked on. If null, the local scheduler will be used.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

The task which is used for loading and callbacks.

#### Type Parameters

`TLoadable` 

The type of the future future child or grand-child to be loaded.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_LoadComponents__1_System_Collections_Generic_IEnumerable___0__"></a> LoadComponents<TLoadable\>\(IEnumerable<TLoadable\>\)

Loads several future child or grand-child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> synchronously and immediately. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Dependencies" data-throw-if-not-resolved="false"></xref>
and <xref href="osu.Framework.Graphics.Drawable.Clock" data-throw-if-not-resolved="false"></xref> are inherited from this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.
<remarks>
This is generally useful if already in an asynchronous context and requiring forcefully (pre)loading content without adding it to the hierarchy.
</remarks>

```csharp
protected void LoadComponents<TLoadable>(IEnumerable<TLoadable> components) where TLoadable : Drawable
```

#### Parameters

`components` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TLoadable\>

The children or grand-children to be loaded.

#### Type Parameters

`TLoadable` 

The type of the future future child or grand-child to be loaded.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_LoadComponentsAsync__1_System_Collections_Generic_IEnumerable___0__System_Action_System_Collections_Generic_IEnumerable___0___System_Threading_CancellationToken_osu_Framework_Threading_Scheduler_"></a> LoadComponentsAsync<TLoadable\>\(IEnumerable<TLoadable\>, Action<IEnumerable<TLoadable\>\>, CancellationToken, Scheduler\)

Loads several future child or grand-child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> asynchronously. <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Dependencies" data-throw-if-not-resolved="false"></xref>
and <xref href="osu.Framework.Graphics.Drawable.Clock" data-throw-if-not-resolved="false"></xref> are inherited from this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

Note that this will always use the dependencies and clock from this instance. If you must load to a nested container level,
consider using <xref href="osu.Framework.Graphics.Containers.DelayedLoadWrapper" data-throw-if-not-resolved="false"></xref>

```csharp
protected Task LoadComponentsAsync<TLoadable>(IEnumerable<TLoadable> components, Action<IEnumerable<TLoadable>> onLoaded = null, CancellationToken cancellation = default, Scheduler scheduler = null) where TLoadable : Drawable
```

#### Parameters

`components` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TLoadable\>

The children or grand-children to be loaded.

`onLoaded` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TLoadable\>\>

Callback to be invoked on the update thread after loading is complete.

`cancellation` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

An optional cancellation token.

`scheduler` [Scheduler](osu.Framework.Threading.Scheduler.md)

The scheduler for <code class="paramref">onLoaded</code> to be invoked on. If null, the local scheduler will be used.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

The task which is used for loading and callbacks.

#### Type Parameters

`TLoadable` 

The type of the future future child or grand-child to be loaded.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_MakeChildAlive_osu_Framework_Graphics_Drawable_"></a> MakeChildAlive\(Drawable\)

Makes a child alive.

```csharp
protected void MakeChildAlive(Drawable child)
```

#### Parameters

`child` [Drawable](osu.Framework.Graphics.Drawable.md)

The child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>&gt; to make alive.

#### Remarks

Callers have to ensure that <code class="paramref">child</code> is of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>'s non-alive <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.LoadState" data-throw-if-not-resolved="false"></xref> of the <code class="paramref">child</code> is at least <xref href="osu.Framework.Graphics.LoadState.Ready" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_MakeChildDead_osu_Framework_Graphics_Drawable_"></a> MakeChildDead\(Drawable\)

Makes a child dead (not alive) and removes it if <xref href="osu.Framework.Graphics.Drawable.RemoveWhenNotAlive" data-throw-if-not-resolved="false"></xref> of the <code class="paramref">child</code> is set.

```csharp
protected bool MakeChildDead(Drawable child)
```

#### Parameters

`child` [Drawable](osu.Framework.Graphics.Drawable.md)

The child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>&gt; to make dead.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">child</code> has been removed by death.

#### Remarks

Callers have to ensure that <code class="paramref">child</code> is of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AliveInternalChildren" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_OnInvalidate_osu_Framework_Graphics_Invalidation_osu_Framework_Layout_InvalidationSource_"></a> OnInvalidate\(Invalidation, InvalidationSource\)

Invoked when the layout of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> was invalidated.

```csharp
protected override bool OnInvalidate(Invalidation invalidation, InvalidationSource source)
```

#### Parameters

`invalidation` [Invalidation](osu.Framework.Graphics.Invalidation.md)

The flags that the this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> was invalidated with.

`source` [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

The source that triggered the invalidation.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether any custom invalidation was performed. Must be true if the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is to be invalidated.

#### Remarks

This should be used to perform any custom invalidation logic that cannot be described as a layout.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ReceivePositionalInputAtSubTree_osuTK_Vector2_"></a> ReceivePositionalInputAtSubTree\(Vector2\)

Determines whether the subtree of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> should receive positional input when the mouse is at the given screen-space position.

```csharp
protected virtual bool ReceivePositionalInputAtSubTree(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

The screen-space position where input could be received.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if the subtree should receive input at the given screen-space position.

#### Remarks

By default, the subtree of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> always receives input when masking is turned off, and only receives input if this
<xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> also receives input when masking is turned on.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_RemoveInternal_osu_Framework_Graphics_Drawable_System_Boolean_"></a> RemoveInternal\(Drawable, bool\)

Removes a given child from this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool RemoveInternal(Drawable drawable, bool disposeImmediately)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to be removed.

`disposeImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether removed item should be immediately disposed.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

False if <code class="paramref">drawable</code> was not a child of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> and true otherwise.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ScheduleAfterChildren__1_System_Action___0____0_"></a> ScheduleAfterChildren<T\>\(Action<T\>, T\)

```csharp
protected ScheduledDelegate ScheduleAfterChildren<T>(Action<T> action, T data)
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

`data` T

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ScheduleAfterChildren_System_Action_"></a> ScheduleAfterChildren\(Action\)

```csharp
protected ScheduledDelegate ScheduleAfterChildren(Action action)
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ShouldBeConsideredForInput_osu_Framework_Graphics_Drawable_"></a> ShouldBeConsideredForInput\(Drawable\)

Check whether a child should be considered for inclusion in <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.BuildNonPositionalInputQueue(System.Collections.Generic.List%7bosu.Framework.Graphics.Drawable%7d%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.BuildPositionalInputQueue(osuTK.Vector2%2cSystem.Collections.Generic.List%7bosu.Framework.Graphics.Drawable%7d)" data-throw-if-not-resolved="false"></xref>

```csharp
protected virtual bool ShouldBeConsideredForInput(Drawable child)
```

#### Parameters

`child` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to be evaluated.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether or not the specified drawable should be considered when building input queues.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_SortInternal"></a> SortInternal\(\)

Sorts all children of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected void SortInternal()
```

#### Remarks

This can be used to re-sort the children if the result of <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.Compare(osu.Framework.Graphics.Drawable%2cosu.Framework.Graphics.Drawable)" data-throw-if-not-resolved="false"></xref> has changed.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_TransformRelativeChildOffsetTo_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformRelativeChildOffsetTo\(Vector2, double, Easing\)

Tweens the <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.RelativeChildOffset" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected TransformSequence<CompositeDrawable> TransformRelativeChildOffsetTo(Vector2 newOffset, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`newOffset` Vector2

The coordinate space to tween to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The tween duration.

`easing` [Easing](osu.Framework.Graphics.Easing.md)

The tween easing.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_TransformRelativeChildSizeTo_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformRelativeChildSizeTo\(Vector2, double, Easing\)

Tweens the <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.RelativeChildSize" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected TransformSequence<CompositeDrawable> TransformRelativeChildSizeTo(Vector2 newSize, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`newSize` Vector2

The coordinate space to tween to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The tween duration.

`easing` [Easing](osu.Framework.Graphics.Easing.md)

The tween easing.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_TweenEdgeEffectTo_osu_Framework_Graphics_Effects_EdgeEffectParameters_System_Double_osu_Framework_Graphics_Easing_"></a> TweenEdgeEffectTo\(EdgeEffectParameters, double, Easing\)

Helper function for creating and adding a <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> that tweens the current <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.EdgeEffect" data-throw-if-not-resolved="false"></xref>.

```csharp
protected TransformSequence<CompositeDrawable> TweenEdgeEffectTo(EdgeEffectParameters newParams, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`newParams` [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_UpdateAfterAutoSize"></a> UpdateAfterAutoSize\(\)

Invoked after all autosize calculations have taken place.

```csharp
protected virtual void UpdateAfterAutoSize()
```

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_UpdateAfterChildren"></a> UpdateAfterChildren\(\)

An opportunity to update state once-per-frame after <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref> has been called
for all <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
This is invoked prior to any autosize calculations of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void UpdateAfterChildren()
```

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_UpdateAfterChildrenLife"></a> UpdateAfterChildrenLife\(\)

Invoked after <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.UpdateChildrenLife" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Drawable.IsPresent" data-throw-if-not-resolved="false"></xref> state checks have taken place,
but before <xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref> is invoked for all <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
This occurs after <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref> has been invoked on this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>

```csharp
protected virtual void UpdateAfterChildrenLife()
```

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_UpdateChildrenLife"></a> UpdateChildrenLife\(\)

Updates the life status of <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref> according to their
<xref href="osu.Framework.Graphics.Drawable.ShouldBeAlive" data-throw-if-not-resolved="false"></xref> property.

```csharp
protected virtual bool UpdateChildrenLife()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True iff the life status of at least one child changed.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_UpdateSubTree"></a> UpdateSubTree\(\)

Updates this Drawable and all Drawables further down the scene graph.
Called once every frame.

```csharp
public override bool UpdateSubTree()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

False if the drawable should not be updated.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_UpdateSubTreeMasking"></a> UpdateSubTreeMasking\(\)

Updates all masking calculations for this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> and its <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AliveInternalChildren" data-throw-if-not-resolved="false"></xref>.
This occurs post-<xref href="osu.Framework.Graphics.Containers.CompositeDrawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref> to ensure that all <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> updates have taken place.

```csharp
public override bool UpdateSubTreeMasking()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether masking calculations have taken place.

