# <a id="osu_Framework_Input_ButtonEventManager_1"></a> Class ButtonEventManager<TButton\>

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

Manages state and events for a single button.

```csharp
public abstract class ButtonEventManager<TButton>
```

#### Type Parameters

`TButton` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonEventManager<TButton\>](osu.Framework.Input.ButtonEventManager\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ButtonEventManager<TButton\>\>\(ButtonEventManager<TButton\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ButtonEventManager<TButton\>\>\(ButtonEventManager<TButton\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ButtonEventManager<TButton\>\>\(ButtonEventManager<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ButtonEventManager<TButton\>\>\(ButtonEventManager<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ButtonEventManager<TButton\>, TChild\>\(ButtonEventManager<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ButtonEventManager<TButton\>, TChild\>\(ButtonEventManager<TButton\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ButtonEventManager<TButton\>, TChild\>\(ButtonEventManager<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ButtonEventManager<TButton\>\>\(ButtonEventManager<TButton\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_ButtonEventManager_1__ctor__0_"></a> ButtonEventManager\(TButton\)

```csharp
protected ButtonEventManager(TButton button)
```

#### Parameters

`button` TButton

## Fields

### <a id="osu_Framework_Input_ButtonEventManager_1_Button"></a> Button

The button this <xref href="osu.Framework.Input.ButtonEventManager%601" data-throw-if-not-resolved="false"></xref> manages.

```csharp
public readonly TButton Button
```

#### Field Value

 TButton

## Properties

### <a id="osu_Framework_Input_ButtonEventManager_1_ButtonDownInputQueue"></a> ButtonDownInputQueue

The input queue for propagating button up events.
This is created from <xref href="osu.Framework.Input.ButtonEventManager%601.InputQueue" data-throw-if-not-resolved="false"></xref> when the button is pressed.

```csharp
protected List<Drawable>? ButtonDownInputQueue { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>?

### <a id="osu_Framework_Input_ButtonEventManager_1_InputQueue"></a> InputQueue

The input queue.

```csharp
protected IEnumerable<Drawable> InputQueue { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

## Methods

### <a id="osu_Framework_Input_ButtonEventManager_1_HandleButtonDown_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonDown\(InputState, List<Drawable\>\)

Handles the button being pressed.

```csharp
protected abstract Drawable? HandleButtonDown(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of possible targets that can handle the event.

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)?

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that handled the event.

### <a id="osu_Framework_Input_ButtonEventManager_1_HandleButtonStateChange_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_ButtonStateChangeKind_"></a> HandleButtonStateChange\(InputState, ButtonStateChangeKind\)

Handles the button state changing.

```csharp
public void HandleButtonStateChange(InputState state, ButtonStateChangeKind kind)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`kind` [ButtonStateChangeKind](osu.Framework.Input.StateChanges.ButtonStateChangeKind.md)

The type of change in the button's state.

### <a id="osu_Framework_Input_ButtonEventManager_1_HandleButtonUp_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonUp\(InputState, List<Drawable\>\)

Handles the button being released.

```csharp
protected abstract void HandleButtonUp(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of targets that must handle the event. This will contain targets up to the target that handled the button down event.

### <a id="osu_Framework_Input_ButtonEventManager_1_PropagateButtonEvent_System_Collections_Generic_IEnumerable_osu_Framework_Graphics_Drawable__osu_Framework_Input_Events_UIEvent_"></a> PropagateButtonEvent\(IEnumerable<Drawable\>, UIEvent\)

Triggers events on drawables in <code class="paramref">drawables</code> until it is handled.

```csharp
protected Drawable? PropagateButtonEvent(IEnumerable<Drawable> drawables, UIEvent e)
```

#### Parameters

`drawables` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The drawables in the queue.

`e` [UIEvent](osu.Framework.Input.Events.UIEvent.md)

The event.

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)?

The drawable which handled the event or null if none.

### <a id="osu_Framework_Input_ButtonEventManager_1_SuppressLoggingEventInformation_osu_Framework_Graphics_Drawable_"></a> SuppressLoggingEventInformation\(Drawable\)

Whether information about the event should be suppressed from logging for the given drawable.

```csharp
protected virtual bool SuppressLoggingEventInformation(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

