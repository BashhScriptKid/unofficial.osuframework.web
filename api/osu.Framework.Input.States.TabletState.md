# <a id="osu_Framework_Input_States_TabletState"></a> Class TabletState

Namespace: [osu.Framework.Input.States](osu.Framework.Input.States.md)  
Assembly: osu.Framework.dll  

```csharp
public class TabletState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TabletState](osu.Framework.Input.States.TabletState.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TabletState\>\(TabletState?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletState\>\(TabletState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletState\>\(TabletState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletState\>\(TabletState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletState, TChild\>\(TabletState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletState, TChild\>\(TabletState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletState, TChild\>\(TabletState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletState\>\(TabletState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Input_States_TabletState_AuxiliaryButtons"></a> AuxiliaryButtons

```csharp
public readonly ButtonStates<TabletAuxiliaryButton> AuxiliaryButtons
```

#### Field Value

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)\>

### <a id="osu_Framework_Input_States_TabletState_PenButtons"></a> PenButtons

```csharp
public readonly ButtonStates<TabletPenButton> PenButtons
```

#### Field Value

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletPenButton](osu.Framework.Input.TabletPenButton.md)\>

## Properties

### <a id="osu_Framework_Input_States_TabletState_Position"></a> Position

```csharp
public Vector2 Position { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Input_States_TabletState_Pressure"></a> Pressure

```csharp
public double Pressure { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Input_States_TabletState_IsButtonPressed_osu_Framework_Input_TabletPenButton_"></a> IsButtonPressed\(TabletPenButton\)

```csharp
public bool IsButtonPressed(TabletPenButton button)
```

#### Parameters

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_TabletState_IsButtonPressed_osu_Framework_Input_TabletAuxiliaryButton_"></a> IsButtonPressed\(TabletAuxiliaryButton\)

```csharp
public bool IsButtonPressed(TabletAuxiliaryButton button)
```

#### Parameters

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_TabletState_SetButtonPressed_osu_Framework_Input_TabletPenButton_System_Boolean_"></a> SetButtonPressed\(TabletPenButton, bool\)

```csharp
public void SetButtonPressed(TabletPenButton button, bool pressed)
```

#### Parameters

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

`pressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_TabletState_SetButtonPressed_osu_Framework_Input_TabletAuxiliaryButton_System_Boolean_"></a> SetButtonPressed\(TabletAuxiliaryButton, bool\)

```csharp
public void SetButtonPressed(TabletAuxiliaryButton button, bool pressed)
```

#### Parameters

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

`pressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_TabletState_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

