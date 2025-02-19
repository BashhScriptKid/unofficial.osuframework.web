# <a id="osu_Framework_Input_TabletAuxiliaryButtonEventManager"></a> Class TabletAuxiliaryButtonEventManager

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public class TabletAuxiliaryButtonEventManager : ButtonEventManager<TabletAuxiliaryButton>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonEventManager<TabletAuxiliaryButton\>](osu.Framework.Input.ButtonEventManager\-1.md) ← 
[TabletAuxiliaryButtonEventManager](osu.Framework.Input.TabletAuxiliaryButtonEventManager.md)

#### Inherited Members

[ButtonEventManager<TabletAuxiliaryButton\>.Button](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_Button), 
[ButtonEventManager<TabletAuxiliaryButton\>.ButtonDownInputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_ButtonDownInputQueue), 
[ButtonEventManager<TabletAuxiliaryButton\>.InputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_InputQueue), 
[ButtonEventManager<TabletAuxiliaryButton\>.HandleButtonStateChange\(InputState, ButtonStateChangeKind\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonStateChange\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonEventManager<TabletAuxiliaryButton\>.HandleButtonDown\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonDown\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<TabletAuxiliaryButton\>.HandleButtonUp\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonUp\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<TabletAuxiliaryButton\>.PropagateButtonEvent\(IEnumerable<Drawable\>, UIEvent\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_PropagateButtonEvent\_System\_Collections\_Generic\_IEnumerable\_osu\_Framework\_Graphics\_Drawable\_\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[ButtonEventManager<TabletAuxiliaryButton\>.SuppressLoggingEventInformation\(Drawable\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_SuppressLoggingEventInformation\_osu\_Framework\_Graphics\_Drawable\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TabletAuxiliaryButtonEventManager\>\(TabletAuxiliaryButtonEventManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletAuxiliaryButtonEventManager\>\(TabletAuxiliaryButtonEventManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletAuxiliaryButtonEventManager\>\(TabletAuxiliaryButtonEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletAuxiliaryButtonEventManager\>\(TabletAuxiliaryButtonEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletAuxiliaryButtonEventManager, TChild\>\(TabletAuxiliaryButtonEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletAuxiliaryButtonEventManager, TChild\>\(TabletAuxiliaryButtonEventManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletAuxiliaryButtonEventManager, TChild\>\(TabletAuxiliaryButtonEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletAuxiliaryButtonEventManager\>\(TabletAuxiliaryButtonEventManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_TabletAuxiliaryButtonEventManager__ctor_osu_Framework_Input_TabletAuxiliaryButton_"></a> TabletAuxiliaryButtonEventManager\(TabletAuxiliaryButton\)

```csharp
public TabletAuxiliaryButtonEventManager(TabletAuxiliaryButton button)
```

#### Parameters

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

## Methods

### <a id="osu_Framework_Input_TabletAuxiliaryButtonEventManager_HandleButtonDown_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonDown\(InputState, List<Drawable\>\)

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

### <a id="osu_Framework_Input_TabletAuxiliaryButtonEventManager_HandleButtonUp_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonUp\(InputState, List<Drawable\>\)

Handles the button being released.

```csharp
protected override void HandleButtonUp(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of targets that must handle the event. This will contain targets up to the target that handled the button down event.

