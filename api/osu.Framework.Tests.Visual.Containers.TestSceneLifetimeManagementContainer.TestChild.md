# <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild"></a> Class TestSceneLifetimeManagementContainer.TestChild

Namespace: [osu.Framework.Tests.Visual.Containers](osu.Framework.Tests.Visual.Containers.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class TestSceneLifetimeManagementContainer.TestChild : SpriteText, IDependencyInjectionCandidate, IDisposable, IHasLineBaseHeight, ITexturedShaderDrawable, IHasText, IDrawable, IHasFilterTerms, IFillFlowContainer, ITransformable, IHasCurrentValue<string>, ISourceGeneratedDependencyActivator, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedHandleInputCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[SpriteText](osu.Framework.Graphics.Sprites.SpriteText.md) ← 
[TestSceneLifetimeManagementContainer.TestChild](osu.Framework.Tests.Visual.Containers.TestSceneLifetimeManagementContainer.TestChild.md)

#### Derived

[TestSceneLifetimeManagementContainer.TestLifetimeMutatingChild](osu.Framework.Tests.Visual.Containers.TestSceneLifetimeManagementContainer.TestLifetimeMutatingChild.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IHasLineBaseHeight](osu.Framework.Graphics.Sprites.IHasLineBaseHeight.md), 
[ITexturedShaderDrawable](osu.Framework.Graphics.ITexturedShaderDrawable.md), 
[IHasText](osu.Framework.Graphics.Sprites.IHasText.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[IHasFilterTerms](osu.Framework.Graphics.Containers.IHasFilterTerms.md), 
[IFillFlowContainer](osu.Framework.Graphics.Containers.IFillFlowContainer.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[IHasCurrentValue<string\>](osu.Framework.Graphics.UserInterface.IHasCurrentValue\-1.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

#### Inherited Members

[SpriteText.TextureShader](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_TextureShader), 
[SpriteText.LoadComplete\(\)](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_LoadComplete), 
[SpriteText.Text](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Text), 
[SpriteText.Current](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Current), 
[SpriteText.Font](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Font), 
[SpriteText.AllowMultiline](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_AllowMultiline), 
[SpriteText.Shadow](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Shadow), 
[SpriteText.ShadowColour](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_ShadowColour), 
[SpriteText.ShadowOffset](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_ShadowOffset), 
[SpriteText.UseFullGlyphHeight](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_UseFullGlyphHeight), 
[SpriteText.Truncate](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Truncate), 
[SpriteText.EllipsisString](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_EllipsisString), 
[SpriteText.IsTruncated](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_IsTruncated), 
[SpriteText.Width](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Width), 
[SpriteText.MaxWidth](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_MaxWidth), 
[SpriteText.Height](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Height), 
[SpriteText.Size](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Size), 
[SpriteText.Spacing](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Spacing), 
[SpriteText.Padding](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_Padding), 
[SpriteText.IsPresent](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_IsPresent), 
[SpriteText.CreateDrawNode\(\)](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_CreateDrawNode), 
[SpriteText.FixedWidthExcludeCharacters](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_FixedWidthExcludeCharacters), 
[SpriteText.FixedWidthReferenceCharacter](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_FixedWidthReferenceCharacter), 
[SpriteText.FallbackCharacter](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_FallbackCharacter), 
[SpriteText.InvalidateTextBuilder\(\)](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_InvalidateTextBuilder), 
[SpriteText.CreateTextBuilder\(ITexturedGlyphLookupStore\)](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_CreateTextBuilder\_osu\_Framework\_Text\_ITexturedGlyphLookupStore\_), 
[SpriteText.ToString\(\)](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_ToString), 
[SpriteText.LineBaseHeight](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_LineBaseHeight), 
[SpriteText.FilterTerms](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_FilterTerms), 
[SpriteText.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Sprites.SpriteText.md\#osu\_Framework\_Graphics\_Sprites\_SpriteText\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
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

[TransformableExtensions.Animate<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, params TransformSequence<TestSceneLifetimeManagementContainer.TestChild\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, params TransformSequence<TestSceneLifetimeManagementContainer.TestChild\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, int, params TransformSequence<TestSceneLifetimeManagementContainer.TestChild\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, params TransformSequence<TestSceneLifetimeManagementContainer.TestChild\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, params TransformSequence<TestSceneLifetimeManagementContainer.TestChild\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<TestSceneLifetimeManagementContainer.TestChild, TValue\>\(TestSceneLifetimeManagementContainer.TestChild, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<TestSceneLifetimeManagementContainer.TestChild, TEasing, TValue\>\(TestSceneLifetimeManagementContainer.TestChild, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Transform<TValue, DefaultEasingFunction, TestSceneLifetimeManagementContainer.TestChild\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Transform<TValue, TEasing, TestSceneLifetimeManagementContainer.TestChild\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<TestSceneLifetimeManagementContainer.TestChild, TValue\>\(TestSceneLifetimeManagementContainer.TestChild, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<TestSceneLifetimeManagementContainer.TestChild, TValue, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformSpacingTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformSpacingTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformSpacingTo<TestSceneLifetimeManagementContainer.TestChild, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformSpacingTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformTo<TestSceneLifetimeManagementContainer.TestChild, TValue\>\(TestSceneLifetimeManagementContainer.TestChild, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<TestSceneLifetimeManagementContainer.TestChild, TValue, TEasing\>\(TestSceneLifetimeManagementContainer.TestChild, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[DrawableExtensions.With<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild, Action<TestSceneLifetimeManagementContainer.TestChild\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<TestSceneLifetimeManagementContainer.TestChild, TChild\>\(TestSceneLifetimeManagementContainer.TestChild, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestSceneLifetimeManagementContainer.TestChild, TChild\>\(TestSceneLifetimeManagementContainer.TestChild, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestSceneLifetimeManagementContainer.TestChild, TChild\>\(TestSceneLifetimeManagementContainer.TestChild, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestSceneLifetimeManagementContainer.TestChild\>\(TestSceneLifetimeManagementContainer.TestChild\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild__ctor_System_Double_System_Double_"></a> TestChild\(double, double\)

```csharp
public TestChild(double lifetimeStart, double lifetimeEnd)
```

#### Parameters

`lifetimeStart` [double](https://learn.microsoft.com/dotnet/api/system.double)

`lifetimeEnd` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild__ctor_System_Double_System_Double_"></a> TestChild\(double, double\)

```csharp
public TestChild(double lifetimeStart, double lifetimeEnd)
```

#### Parameters

`lifetimeStart` [double](https://learn.microsoft.com/dotnet/api/system.double)

`lifetimeEnd` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild__ctor_System_Double_System_Double_"></a> TestChild\(double, double\)

```csharp
public TestChild(double lifetimeStart, double lifetimeEnd)
```

#### Parameters

`lifetimeStart` [double](https://learn.microsoft.com/dotnet/api/system.double)

`lifetimeEnd` [double](https://learn.microsoft.com/dotnet/api/system.double)

## Fields

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_Crossings"></a> Crossings

```csharp
public List<LifetimeBoundaryCrossedEvent> Crossings
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[LifetimeBoundaryCrossedEvent](osu.Framework.Graphics.Containers.LifetimeBoundaryCrossedEvent.md)\>

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_Crossings"></a> Crossings

```csharp
public List<LifetimeBoundaryCrossedEvent> Crossings
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<LifetimeBoundaryCrossedEvent\>

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_Crossings"></a> Crossings

```csharp
public List<LifetimeBoundaryCrossedEvent> Crossings
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<LifetimeBoundaryCrossedEvent\>

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_EndDelta"></a> EndDelta

```csharp
public int EndDelta
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_EndDelta"></a> EndDelta

```csharp
public int EndDelta
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_EndDelta"></a> EndDelta

```csharp
public int EndDelta
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_StartDelta"></a> StartDelta

```csharp
public int StartDelta
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_StartDelta"></a> StartDelta

```csharp
public int StartDelta
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_StartDelta"></a> StartDelta

```csharp
public int StartDelta
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_RemoveWhenNotAlive"></a> RemoveWhenNotAlive

Whether to remove the drawable from its parent's children when it's not alive.

```csharp
public override bool RemoveWhenNotAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_RemoveWhenNotAlive"></a> RemoveWhenNotAlive

Whether to remove the drawable from its parent's children when it's not alive.

```csharp
public override bool RemoveWhenNotAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_RemoveWhenNotAlive"></a> RemoveWhenNotAlive

Whether to remove the drawable from its parent's children when it's not alive.

```csharp
public override bool RemoveWhenNotAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_CheckCrossings_osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent___"></a> CheckCrossings\(params LifetimeBoundaryCrossedEvent\[\]\)

```csharp
public void CheckCrossings(params LifetimeBoundaryCrossedEvent[] expected)
```

#### Parameters

`expected` [LifetimeBoundaryCrossedEvent](osu.Framework.Graphics.Containers.LifetimeBoundaryCrossedEvent.md)\[\]

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_CheckCrossings_osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent___"></a> CheckCrossings\(params LifetimeBoundaryCrossedEvent\[\]\)

```csharp
public void CheckCrossings(params LifetimeBoundaryCrossedEvent[] expected)
```

#### Parameters

`expected` LifetimeBoundaryCrossedEvent\[\]

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_CheckCrossings_osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent___"></a> CheckCrossings\(params LifetimeBoundaryCrossedEvent\[\]\)

```csharp
public void CheckCrossings(params LifetimeBoundaryCrossedEvent[] expected)
```

#### Parameters

`expected` LifetimeBoundaryCrossedEvent\[\]

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_Update"></a> Update\(\)

Performs a once-per-frame update specific to this Drawable. A more elegant alternative to
<xref href="osu.Framework.Graphics.Drawable.OnUpdate" data-throw-if-not-resolved="false"></xref> when deriving from <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Note, that this
method is always called before Drawables further down the scene graph are updated.

```csharp
protected override void Update()
```

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_Update"></a> Update\(\)

Performs a once-per-frame update specific to this Drawable. A more elegant alternative to
<xref href="osu.Framework.Graphics.Drawable.OnUpdate" data-throw-if-not-resolved="false"></xref> when deriving from <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Note, that this
method is always called before Drawables further down the scene graph are updated.

```csharp
protected override void Update()
```

### <a id="osu_Framework_Tests_Visual_Containers_TestSceneLifetimeManagementContainer_TestChild_Update"></a> Update\(\)

Performs a once-per-frame update specific to this Drawable. A more elegant alternative to
<xref href="osu.Framework.Graphics.Drawable.OnUpdate" data-throw-if-not-resolved="false"></xref> when deriving from <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Note, that this
method is always called before Drawables further down the scene graph are updated.

```csharp
protected override void Update()
```

