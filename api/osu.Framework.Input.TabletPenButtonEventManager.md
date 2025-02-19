# <a id="osu_Framework_Input_TabletPenButtonEventManager"></a> Class TabletPenButtonEventManager

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public class TabletPenButtonEventManager : ButtonEventManager<TabletPenButton>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonEventManager<TabletPenButton\>](osu.Framework.Input.ButtonEventManager\-1.md) ← 
[TabletPenButtonEventManager](osu.Framework.Input.TabletPenButtonEventManager.md)

#### Inherited Members

[ButtonEventManager<TabletPenButton\>.Button](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_Button), 
[ButtonEventManager<TabletPenButton\>.ButtonDownInputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_ButtonDownInputQueue), 
[ButtonEventManager<TabletPenButton\>.InputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_InputQueue), 
[ButtonEventManager<TabletPenButton\>.HandleButtonStateChange\(InputState, ButtonStateChangeKind\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonStateChange\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonEventManager<TabletPenButton\>.HandleButtonDown\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonDown\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<TabletPenButton\>.HandleButtonUp\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonUp\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<TabletPenButton\>.PropagateButtonEvent\(IEnumerable<Drawable\>, UIEvent\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_PropagateButtonEvent\_System\_Collections\_Generic\_IEnumerable\_osu\_Framework\_Graphics\_Drawable\_\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[ButtonEventManager<TabletPenButton\>.SuppressLoggingEventInformation\(Drawable\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_SuppressLoggingEventInformation\_osu\_Framework\_Graphics\_Drawable\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TabletPenButtonEventManager\>\(TabletPenButtonEventManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletPenButtonEventManager\>\(TabletPenButtonEventManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletPenButtonEventManager\>\(TabletPenButtonEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletPenButtonEventManager\>\(TabletPenButtonEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletPenButtonEventManager, TChild\>\(TabletPenButtonEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletPenButtonEventManager, TChild\>\(TabletPenButtonEventManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletPenButtonEventManager, TChild\>\(TabletPenButtonEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletPenButtonEventManager\>\(TabletPenButtonEventManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_TabletPenButtonEventManager__ctor_osu_Framework_Input_TabletPenButton_"></a> TabletPenButtonEventManager\(TabletPenButton\)

```csharp
public TabletPenButtonEventManager(TabletPenButton button)
```

#### Parameters

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

## Methods

### <a id="osu_Framework_Input_TabletPenButtonEventManager_HandleButtonDown_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonDown\(InputState, List<Drawable\>\)

Handles the button being pressed.

```csharp
protected override Drawable? HandleButtonDown(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of possible targets that can handle the event.

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)?

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that handled the event.

### <a id="osu_Framework_Input_TabletPenButtonEventManager_HandleButtonUp_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonUp\(InputState, List<Drawable\>\)

Handles the button being released.

```csharp
protected override void HandleButtonUp(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of targets that must handle the event. This will contain targets up to the target that handled the button down event.

