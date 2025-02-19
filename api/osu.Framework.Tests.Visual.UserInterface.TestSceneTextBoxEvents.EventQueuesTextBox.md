# <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox"></a> Class TestSceneTextBoxEvents.EventQueuesTextBox

Namespace: [osu.Framework.Tests.Visual.UserInterface](osu.Framework.Tests.Visual.UserInterface.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class TestSceneTextBoxEvents.EventQueuesTextBox : TestSceneTextBox.InsertableTextBox, IDependencyInjectionCandidate, IDisposable, IContainerEnumerable<Drawable>, IContainerCollection<Drawable>, IContainer, ICollection<Drawable>, IReadOnlyList<Drawable>, IReadOnlyCollection<Drawable>, IEnumerable<Drawable>, IEnumerable, ITabbableContainer, IHasCurrentValue<string>, IKeyBindingHandler<PlatformAction>, IKeyBindingHandler, IDrawable, ITransformable, ICanSuppressKeyEventLogging, ISourceGeneratedDependencyActivator, ISourceGeneratedHandleInputCache, ISourceGeneratedLongRunningLoadCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md) ← 
[Container<Drawable\>](osu.Framework.Graphics.Containers.Container\-1.md) ← 
[TabbableContainer<Drawable\>](osu.Framework.Graphics.Containers.TabbableContainer\-1.md) ← 
[TabbableContainer](osu.Framework.Graphics.Containers.TabbableContainer.md) ← 
[TextBox](osu.Framework.Graphics.UserInterface.TextBox.md) ← 
[BasicTextBox](osu.Framework.Graphics.UserInterface.BasicTextBox.md) ← 
[TestSceneTextBox.InsertableTextBox](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBox.InsertableTextBox.md) ← 
[TestSceneTextBoxEvents.EventQueuesTextBox](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.EventQueuesTextBox.md)

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
[ITabbableContainer](osu.Framework.Graphics.Containers.ITabbableContainer.md), 
[IHasCurrentValue<string\>](osu.Framework.Graphics.UserInterface.IHasCurrentValue\-1.md), 
[IKeyBindingHandler<PlatformAction\>](osu.Framework.Input.Bindings.IKeyBindingHandler\-1.md), 
[IKeyBindingHandler](osu.Framework.Input.Bindings.IKeyBindingHandler.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[ICanSuppressKeyEventLogging](osu.Framework.Input.ICanSuppressKeyEventLogging.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md)

#### Inherited Members

[TestSceneTextBox.InsertableTextBox.FlowingText](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBox.InsertableTextBox.md\#osu\_Framework\_Tests\_Visual\_UserInterface\_TestSceneTextBox\_InsertableTextBox\_FlowingText), 
[TestSceneTextBox.InsertableTextBox.InsertString\(string\)](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBox.InsertableTextBox.md\#osu\_Framework\_Tests\_Visual\_UserInterface\_TestSceneTextBox\_InsertableTextBox\_InsertString\_System\_String\_), 
[TestSceneTextBox.InsertableTextBox.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBox.InsertableTextBox.md\#osu\_Framework\_Tests\_Visual\_UserInterface\_TestSceneTextBox\_InsertableTextBox\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[BasicTextBox.CaretWidth](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_CaretWidth), 
[BasicTextBox.SelectionColour](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_SelectionColour), 
[BasicTextBox.BackgroundCommit](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_BackgroundCommit), 
[BasicTextBox.BackgroundFocused](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_BackgroundFocused), 
[BasicTextBox.BackgroundUnfocused](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_BackgroundUnfocused), 
[BasicTextBox.InputErrorColour](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_InputErrorColour), 
[BasicTextBox.NotifyInputError\(\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_NotifyInputError), 
[BasicTextBox.OnTextCommitted\(bool\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_OnTextCommitted\_System\_Boolean\_), 
[BasicTextBox.OnFocusLost\(FocusLostEvent\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_OnFocusLost\_osu\_Framework\_Input\_Events\_FocusLostEvent\_), 
[BasicTextBox.OnFocus\(FocusEvent\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_OnFocus\_osu\_Framework\_Input\_Events\_FocusEvent\_), 
[BasicTextBox.GetDrawableCharacter\(char\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_GetDrawableCharacter\_System\_Char\_), 
[BasicTextBox.CreatePlaceholder\(\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_CreatePlaceholder), 
[BasicTextBox.CreateCaret\(\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_CreateCaret), 
[BasicTextBox.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.UserInterface.BasicTextBox.md\#osu\_Framework\_Graphics\_UserInterface\_BasicTextBox\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[TextBox.TextFlow](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_TextFlow), 
[TextBox.TextContainer](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_TextContainer), 
[TextBox.HandleNonPositionalInput](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_HandleNonPositionalInput), 
[TextBox.MaskCharacter](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_MaskCharacter), 
[TextBox.LeftRightPadding](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_LeftRightPadding), 
[TextBox.LengthLimit](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_LengthLimit), 
[TextBox.AllowClipboardExport](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_AllowClipboardExport), 
[TextBox.AllowWordNavigation](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_AllowWordNavigation), 
[TextBox.HandleLeftRightArrows](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_HandleLeftRightArrows), 
[TextBox.AllowIme](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_AllowIme), 
[TextBox.InputProperties](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_InputProperties), 
[TextBox.CanAddCharacter\(char\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_CanAddCharacter\_System\_Char\_), 
[TextBox.ReadOnly](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_ReadOnly), 
[TextBox.ReleaseFocusOnCommit](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_ReleaseFocusOnCommit), 
[TextBox.CommitOnFocusLost](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_CommitOnFocusLost), 
[TextBox.CanBeTabbedTo](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_CanBeTabbedTo), 
[TextBox.OnCommit](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnCommit), 
[TextBox.LoadComplete\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_LoadComplete), 
[TextBox.OnPressed\(KeyBindingPressEvent<PlatformAction\>\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnPressed\_osu\_Framework\_Input\_Events\_KeyBindingPressEvent\_osu\_Framework\_Input\_PlatformAction\_\_), 
[TextBox.OnReleased\(KeyBindingReleaseEvent<PlatformAction\>\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnReleased\_osu\_Framework\_Input\_Events\_KeyBindingReleaseEvent\_osu\_Framework\_Input\_PlatformAction\_\_), 
[TextBox.SelectAll\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_SelectAll), 
[TextBox.GetBackwardWordAmount\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_GetBackwardWordAmount), 
[TextBox.GetForwardWordAmount\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_GetForwardWordAmount), 
[TextBox.GetBackwardLineAmount\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_GetBackwardLineAmount), 
[TextBox.GetForwardLineAmount\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_GetForwardLineAmount), 
[TextBox.MoveCursorBy\(int\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_MoveCursorBy\_System\_Int32\_), 
[TextBox.ExpandSelectionBy\(int\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_ExpandSelectionBy\_System\_Int32\_), 
[TextBox.DeleteBy\(int\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_DeleteBy\_System\_Int32\_), 
[TextBox.FinalizeImeComposition\(bool\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_FinalizeImeComposition\_System\_Boolean\_), 
[TextBox.CancelImeComposition\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_CancelImeComposition), 
[TextBox.Dispose\(bool\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_Dispose\_System\_Boolean\_), 
[TextBox.Update\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_Update), 
[TextBox.UpdateAfterChildren\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_UpdateAfterChildren), 
[TextBox.GetDrawableCharacter\(char\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_GetDrawableCharacter\_System\_Char\_), 
[TextBox.AddCharacterToFlow\(char\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_AddCharacterToFlow\_System\_Char\_), 
[TextBox.FontSize](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_FontSize), 
[TextBox.InsertString\(string\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_InsertString\_System\_String\_), 
[TextBox.NotifyInputError\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_NotifyInputError), 
[TextBox.OnUserTextAdded\(string\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnUserTextAdded\_System\_String\_), 
[TextBox.OnUserTextRemoved\(string\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnUserTextRemoved\_System\_String\_), 
[TextBox.OnTextCommitted\(bool\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnTextCommitted\_System\_Boolean\_), 
[TextBox.OnCaretMoved\(bool\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnCaretMoved\_System\_Boolean\_), 
[TextBox.OnTextSelectionChanged\(TextBox.TextSelectionType\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnTextSelectionChanged\_osu\_Framework\_Graphics\_UserInterface\_TextBox\_TextSelectionType\_), 
[TextBox.OnTextDeselected\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnTextDeselected), 
[TextBox.OnImeComposition\(string, int, int, bool\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnImeComposition\_System\_String\_System\_Int32\_System\_Int32\_System\_Boolean\_), 
[TextBox.OnImeResult\(string, bool\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnImeResult\_System\_String\_System\_Boolean\_), 
[TextBox.CreatePlaceholder\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_CreatePlaceholder), 
[TextBox.Placeholder](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_Placeholder), 
[TextBox.PlaceholderText](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_PlaceholderText), 
[TextBox.CreateCaret\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_CreateCaret), 
[TextBox.Current](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_Current), 
[TextBox.Text](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_Text), 
[TextBox.SelectedText](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_SelectedText), 
[TextBox.ImeCompositionActive](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_ImeCompositionActive), 
[TextBox.OnKeyDown\(KeyDownEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnKeyDown\_osu\_Framework\_Input\_Events\_KeyDownEvent\_), 
[TextBox.KillFocus\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_KillFocus), 
[TextBox.Commit\(\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_Commit), 
[TextBox.OnKeyUp\(KeyUpEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnKeyUp\_osu\_Framework\_Input\_Events\_KeyUpEvent\_), 
[TextBox.OnDragStart\(DragStartEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnDragStart\_osu\_Framework\_Input\_Events\_DragStartEvent\_), 
[TextBox.OnDrag\(DragEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnDrag\_osu\_Framework\_Input\_Events\_DragEvent\_), 
[TextBox.OnDoubleClick\(DoubleClickEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnDoubleClick\_osu\_Framework\_Input\_Events\_DoubleClickEvent\_), 
[TextBox.OnMouseDown\(MouseDownEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnMouseDown\_osu\_Framework\_Input\_Events\_MouseDownEvent\_), 
[TextBox.OnMouseUp\(MouseUpEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnMouseUp\_osu\_Framework\_Input\_Events\_MouseUpEvent\_), 
[TextBox.OnFocusLost\(FocusLostEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnFocusLost\_osu\_Framework\_Input\_Events\_FocusLostEvent\_), 
[TextBox.AcceptsFocus](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_AcceptsFocus), 
[TextBox.OnClick\(ClickEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnClick\_osu\_Framework\_Input\_Events\_ClickEvent\_), 
[TextBox.OnFocus\(FocusEvent\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_OnFocus\_osu\_Framework\_Input\_Events\_FocusEvent\_), 
[TextBox.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.UserInterface.TextBox.md\#osu\_Framework\_Graphics\_UserInterface\_TextBox\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[TabbableContainer.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.TabbableContainer.md\#osu\_Framework\_Graphics\_Containers\_TabbableContainer\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[TabbableContainer<Drawable\>.CanBeTabbedTo](osu.Framework.Graphics.Containers.TabbableContainer\-1.md\#osu\_Framework\_Graphics\_Containers\_TabbableContainer\_1\_CanBeTabbedTo), 
[TabbableContainer<Drawable\>.TabbableContentContainer](osu.Framework.Graphics.Containers.TabbableContainer\-1.md\#osu\_Framework\_Graphics\_Containers\_TabbableContainer\_1\_TabbableContentContainer), 
[TabbableContainer<Drawable\>.OnKeyDown\(KeyDownEvent\)](osu.Framework.Graphics.Containers.TabbableContainer\-1.md\#osu\_Framework\_Graphics\_Containers\_TabbableContainer\_1\_OnKeyDown\_osu\_Framework\_Input\_Events\_KeyDownEvent\_), 
[TabbableContainer<Drawable\>.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.TabbableContainer\-1.md\#osu\_Framework\_Graphics\_Containers\_TabbableContainer\_1\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
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

[TransformableExtensions.Animate<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, params TransformSequence<TestSceneTextBoxEvents.EventQueuesTextBox\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, params TransformSequence<TestSceneTextBoxEvents.EventQueuesTextBox\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Color4, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Color4, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[EnumerableExtensions.ForEach<Drawable\>\(IEnumerable<Drawable\>, Action<Drawable\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<Drawable\>\(IEnumerable<Drawable\>, Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<Drawable\>\(IEnumerable<Drawable\>, Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<Drawable\>\(IEnumerable<Drawable\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, int, params TransformSequence<TestSceneTextBoxEvents.EventQueuesTextBox\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, params TransformSequence<TestSceneTextBoxEvents.EventQueuesTextBox\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, params TransformSequence<TestSceneTextBoxEvents.EventQueuesTextBox\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<TestSceneTextBoxEvents.EventQueuesTextBox, TValue\>\(TestSceneTextBoxEvents.EventQueuesTextBox, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing, TValue\>\(TestSceneTextBoxEvents.EventQueuesTextBox, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Transform<TValue, DefaultEasingFunction, TestSceneTextBoxEvents.EventQueuesTextBox\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Transform<TValue, TEasing, TestSceneTextBoxEvents.EventQueuesTextBox\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<TestSceneTextBoxEvents.EventQueuesTextBox, TValue\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<TestSceneTextBoxEvents.EventQueuesTextBox, TValue, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformTo<TestSceneTextBoxEvents.EventQueuesTextBox, TValue\>\(TestSceneTextBoxEvents.EventQueuesTextBox, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<TestSceneTextBoxEvents.EventQueuesTextBox, TValue, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[TransformableExtensions.TweenEdgeEffectTo<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TweenEdgeEffectTo<TestSceneTextBoxEvents.EventQueuesTextBox, TEasing\>\(TestSceneTextBoxEvents.EventQueuesTextBox, EdgeEffectParameters, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.With<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox, Action<TestSceneTextBoxEvents.EventQueuesTextBox\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<TestSceneTextBoxEvents.EventQueuesTextBox, TChild\>\(TestSceneTextBoxEvents.EventQueuesTextBox, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestSceneTextBoxEvents.EventQueuesTextBox, TChild\>\(TestSceneTextBoxEvents.EventQueuesTextBox, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestSceneTextBoxEvents.EventQueuesTextBox, TChild\>\(TestSceneTextBoxEvents.EventQueuesTextBox, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestSceneTextBoxEvents.EventQueuesTextBox\>\(TestSceneTextBoxEvents.EventQueuesTextBox\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_CaretMovedQueue"></a> CaretMovedQueue

```csharp
public readonly Queue<bool> CaretMovedQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_CaretMovedQueue"></a> CaretMovedQueue

```csharp
public readonly Queue<bool> CaretMovedQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_CaretMovedQueue"></a> CaretMovedQueue

```csharp
public readonly Queue<bool> CaretMovedQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_CommittedTextQueue"></a> CommittedTextQueue

```csharp
public readonly Queue<bool> CommittedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_CommittedTextQueue"></a> CommittedTextQueue

```csharp
public readonly Queue<bool> CommittedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_CommittedTextQueue"></a> CommittedTextQueue

```csharp
public readonly Queue<bool> CommittedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeCompositionQueue"></a> ImeCompositionQueue

```csharp
public readonly Queue<TestSceneTextBoxEvents.ImeCompositionEvent> ImeCompositionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TestSceneTextBoxEvents](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.md).[ImeCompositionEvent](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.ImeCompositionEvent.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeCompositionQueue"></a> ImeCompositionQueue

```csharp
public readonly Queue<TestSceneTextBoxEvents.ImeCompositionEvent> ImeCompositionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TestSceneTextBoxEvents](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.md).[ImeCompositionEvent](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.ImeCompositionEvent.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeCompositionQueue"></a> ImeCompositionQueue

```csharp
public readonly Queue<TestSceneTextBoxEvents.ImeCompositionEvent> ImeCompositionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TestSceneTextBoxEvents](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.md).[ImeCompositionEvent](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.ImeCompositionEvent.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeResultQueue"></a> ImeResultQueue

```csharp
public readonly Queue<TestSceneTextBoxEvents.ImeResultEvent> ImeResultQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TestSceneTextBoxEvents](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.md).[ImeResultEvent](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.ImeResultEvent.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeResultQueue"></a> ImeResultQueue

```csharp
public readonly Queue<TestSceneTextBoxEvents.ImeResultEvent> ImeResultQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TestSceneTextBoxEvents](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.md).[ImeResultEvent](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.ImeResultEvent.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeResultQueue"></a> ImeResultQueue

```csharp
public readonly Queue<TestSceneTextBoxEvents.ImeResultEvent> ImeResultQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TestSceneTextBoxEvents](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.md).[ImeResultEvent](osu.Framework.Tests.Visual.UserInterface.TestSceneTextBoxEvents.ImeResultEvent.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_InputErrorQueue"></a> InputErrorQueue

```csharp
public readonly Queue<bool> InputErrorQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_InputErrorQueue"></a> InputErrorQueue

```csharp
public readonly Queue<bool> InputErrorQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_InputErrorQueue"></a> InputErrorQueue

```csharp
public readonly Queue<bool> InputErrorQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_TextDeselectionQueue"></a> TextDeselectionQueue

```csharp
public readonly Queue<bool> TextDeselectionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_TextDeselectionQueue"></a> TextDeselectionQueue

```csharp
public readonly Queue<bool> TextDeselectionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_TextDeselectionQueue"></a> TextDeselectionQueue

```csharp
public readonly Queue<bool> TextDeselectionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_TextSelectionQueue"></a> TextSelectionQueue

```csharp
public readonly Queue<TextBox.TextSelectionType> TextSelectionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TextBox](osu.Framework.Graphics.UserInterface.TextBox.md).[TextSelectionType](osu.Framework.Graphics.UserInterface.TextBox.TextSelectionType.md)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_TextSelectionQueue"></a> TextSelectionQueue

```csharp
public readonly Queue<TextBox.TextSelectionType> TextSelectionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<TextBox.TextSelectionType\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_TextSelectionQueue"></a> TextSelectionQueue

```csharp
public readonly Queue<TextBox.TextSelectionType> TextSelectionQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<TextBox.TextSelectionType\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_UserConsumedTextQueue"></a> UserConsumedTextQueue

```csharp
public readonly Queue<string> UserConsumedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_UserConsumedTextQueue"></a> UserConsumedTextQueue

```csharp
public readonly Queue<string> UserConsumedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_UserConsumedTextQueue"></a> UserConsumedTextQueue

```csharp
public readonly Queue<string> UserConsumedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_UserRemovedTextQueue"></a> UserRemovedTextQueue

```csharp
public readonly Queue<string> UserRemovedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_UserRemovedTextQueue"></a> UserRemovedTextQueue

```csharp
public readonly Queue<string> UserRemovedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_UserRemovedTextQueue"></a> UserRemovedTextQueue

```csharp
public readonly Queue<string> UserRemovedTextQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Properties

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeCompositionActive"></a> ImeCompositionActive

```csharp
public bool ImeCompositionActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeCompositionActive"></a> ImeCompositionActive

```csharp
public bool ImeCompositionActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_ImeCompositionActive"></a> ImeCompositionActive

```csharp
public bool ImeCompositionActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_NotifyInputError"></a> NotifyInputError\(\)

Called whenever an invalid character has been entered

```csharp
protected override void NotifyInputError()
```

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_NotifyInputError"></a> NotifyInputError\(\)

Called whenever an invalid character has been entered

```csharp
protected override void NotifyInputError()
```

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_NotifyInputError"></a> NotifyInputError\(\)

Called whenever an invalid character has been entered

```csharp
protected override void NotifyInputError()
```

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnCaretMoved_System_Boolean_"></a> OnCaretMoved\(bool\)

Invoked whenever the caret has moved from its position.

```csharp
protected override void OnCaretMoved(bool selecting)
```

#### Parameters

`selecting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the caret is selecting text while moving.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnCaretMoved_System_Boolean_"></a> OnCaretMoved\(bool\)

Invoked whenever the caret has moved from its position.

```csharp
protected override void OnCaretMoved(bool selecting)
```

#### Parameters

`selecting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the caret is selecting text while moving.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnCaretMoved_System_Boolean_"></a> OnCaretMoved\(bool\)

Invoked whenever the caret has moved from its position.

```csharp
protected override void OnCaretMoved(bool selecting)
```

#### Parameters

`selecting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the caret is selecting text while moving.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnImeComposition_System_String_System_Int32_System_Int32_System_Boolean_"></a> OnImeComposition\(string, int, int, bool\)

Invoked whenever the IME composition has changed.

```csharp
protected override void OnImeComposition(string newComposition, int removedTextLength, int addedTextLength, bool selectionMoved)
```

#### Parameters

`newComposition` [string](https://learn.microsoft.com/dotnet/api/system.string)

The current text of the composition.

`removedTextLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of characters that have been replaced by new ones.

`addedTextLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of characters that have replaced the old ones.

`selectionMoved` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the selection/caret has moved.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnImeComposition_System_String_System_Int32_System_Int32_System_Boolean_"></a> OnImeComposition\(string, int, int, bool\)

Invoked whenever the IME composition has changed.

```csharp
protected override void OnImeComposition(string newComposition, int removedTextLength, int addedTextLength, bool selectionMoved)
```

#### Parameters

`newComposition` [string](https://learn.microsoft.com/dotnet/api/system.string)

The current text of the composition.

`removedTextLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of characters that have been replaced by new ones.

`addedTextLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of characters that have replaced the old ones.

`selectionMoved` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the selection/caret has moved.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnImeComposition_System_String_System_Int32_System_Int32_System_Boolean_"></a> OnImeComposition\(string, int, int, bool\)

Invoked whenever the IME composition has changed.

```csharp
protected override void OnImeComposition(string newComposition, int removedTextLength, int addedTextLength, bool selectionMoved)
```

#### Parameters

`newComposition` [string](https://learn.microsoft.com/dotnet/api/system.string)

The current text of the composition.

`removedTextLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of characters that have been replaced by new ones.

`addedTextLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of characters that have replaced the old ones.

`selectionMoved` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the selection/caret has moved.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnImeResult_System_String_System_Boolean_"></a> OnImeResult\(string, bool\)

Invoked when the IME has finished compositing.

```csharp
protected override void OnImeResult(string result, bool successful)
```

#### Parameters

`result` [string](https://learn.microsoft.com/dotnet/api/system.string)

The result of the composition.

`successful` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this composition was finished trough normal means (eg. user normally finished compositing trough the IME).
<code>false</code> if ended prematurely.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnImeResult_System_String_System_Boolean_"></a> OnImeResult\(string, bool\)

Invoked when the IME has finished compositing.

```csharp
protected override void OnImeResult(string result, bool successful)
```

#### Parameters

`result` [string](https://learn.microsoft.com/dotnet/api/system.string)

The result of the composition.

`successful` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this composition was finished trough normal means (eg. user normally finished compositing trough the IME).
<code>false</code> if ended prematurely.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnImeResult_System_String_System_Boolean_"></a> OnImeResult\(string, bool\)

Invoked when the IME has finished compositing.

```csharp
protected override void OnImeResult(string result, bool successful)
```

#### Parameters

`result` [string](https://learn.microsoft.com/dotnet/api/system.string)

The result of the composition.

`successful` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this composition was finished trough normal means (eg. user normally finished compositing trough the IME).
<code>false</code> if ended prematurely.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextCommitted_System_Boolean_"></a> OnTextCommitted\(bool\)

Invoked whenever a text string has been committed to the textbox.

```csharp
protected override void OnTextCommitted(bool textChanged)
```

#### Parameters

`textChanged` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the current text string is different than the last committed.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextCommitted_System_Boolean_"></a> OnTextCommitted\(bool\)

Invoked whenever a text string has been committed to the textbox.

```csharp
protected override void OnTextCommitted(bool textChanged)
```

#### Parameters

`textChanged` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the current text string is different than the last committed.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextCommitted_System_Boolean_"></a> OnTextCommitted\(bool\)

Invoked whenever a text string has been committed to the textbox.

```csharp
protected override void OnTextCommitted(bool textChanged)
```

#### Parameters

`textChanged` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the current text string is different than the last committed.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextDeselected"></a> OnTextDeselected\(\)

Invoked whenever selected text is deselected. For selection, see <xref href="osu.Framework.Graphics.UserInterface.TextBox.OnTextSelectionChanged(osu.Framework.Graphics.UserInterface.TextBox.TextSelectionType)" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnTextDeselected()
```

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextDeselected"></a> OnTextDeselected\(\)

Invoked whenever selected text is deselected. For selection, see <xref href="osu.Framework.Graphics.UserInterface.TextBox.OnTextSelectionChanged(osu.Framework.Graphics.UserInterface.TextBox.TextSelectionType)" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnTextDeselected()
```

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextDeselected"></a> OnTextDeselected\(\)

Invoked whenever selected text is deselected. For selection, see <xref href="osu.Framework.Graphics.UserInterface.TextBox.OnTextSelectionChanged(osu.Framework.Graphics.UserInterface.TextBox.TextSelectionType)" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnTextDeselected()
```

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextSelectionChanged_osu_Framework_Graphics_UserInterface_TextBox_TextSelectionType_"></a> OnTextSelectionChanged\(TextSelectionType\)

Invoked whenever text selection changes. For deselection, see <xref href="osu.Framework.Graphics.UserInterface.TextBox.OnTextDeselected" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnTextSelectionChanged(TextBox.TextSelectionType selectionType)
```

#### Parameters

`selectionType` [TextBox](osu.Framework.Graphics.UserInterface.TextBox.md).[TextSelectionType](osu.Framework.Graphics.UserInterface.TextBox.TextSelectionType.md)

The type of selection change that occured.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextSelectionChanged_osu_Framework_Graphics_UserInterface_TextBox_TextSelectionType_"></a> OnTextSelectionChanged\(TextSelectionType\)

Invoked whenever text selection changes. For deselection, see <xref href="osu.Framework.Graphics.UserInterface.TextBox.OnTextDeselected" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnTextSelectionChanged(TextBox.TextSelectionType selectionType)
```

#### Parameters

`selectionType` TextBox.TextSelectionType

The type of selection change that occured.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnTextSelectionChanged_osu_Framework_Graphics_UserInterface_TextBox_TextSelectionType_"></a> OnTextSelectionChanged\(TextSelectionType\)

Invoked whenever text selection changes. For deselection, see <xref href="osu.Framework.Graphics.UserInterface.TextBox.OnTextDeselected" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnTextSelectionChanged(TextBox.TextSelectionType selectionType)
```

#### Parameters

`selectionType` TextBox.TextSelectionType

The type of selection change that occured.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnUserTextAdded_System_String_"></a> OnUserTextAdded\(string\)

Invoked when new text is added via user input.

```csharp
protected override void OnUserTextAdded(string consumed)
```

#### Parameters

`consumed` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnUserTextAdded_System_String_"></a> OnUserTextAdded\(string\)

Invoked when new text is added via user input.

```csharp
protected override void OnUserTextAdded(string consumed)
```

#### Parameters

`consumed` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnUserTextAdded_System_String_"></a> OnUserTextAdded\(string\)

Invoked when new text is added via user input.

```csharp
protected override void OnUserTextAdded(string consumed)
```

#### Parameters

`consumed` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnUserTextRemoved_System_String_"></a> OnUserTextRemoved\(string\)

Invoked when text is removed via user input.

```csharp
protected override void OnUserTextRemoved(string removed)
```

#### Parameters

`removed` [string](https://learn.microsoft.com/dotnet/api/system.string)

The text which was removed.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnUserTextRemoved_System_String_"></a> OnUserTextRemoved\(string\)

Invoked when text is removed via user input.

```csharp
protected override void OnUserTextRemoved(string removed)
```

#### Parameters

`removed` [string](https://learn.microsoft.com/dotnet/api/system.string)

The text which was removed.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_OnUserTextRemoved_System_String_"></a> OnUserTextRemoved\(string\)

Invoked when text is removed via user input.

```csharp
protected override void OnUserTextRemoved(string removed)
```

#### Parameters

`removed` [string](https://learn.microsoft.com/dotnet/api/system.string)

The text which was removed.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Tests_Visual_UserInterface_TestSceneTextBoxEvents_EventQueuesTextBox_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

