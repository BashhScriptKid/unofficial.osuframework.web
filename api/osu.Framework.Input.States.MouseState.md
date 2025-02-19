# <a id="osu_Framework_Input_States_MouseState"></a> Class MouseState

Namespace: [osu.Framework.Input.States](osu.Framework.Input.States.md)  
Assembly: osu.Framework.dll  

```csharp
public class MouseState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MouseState](osu.Framework.Input.States.MouseState.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MouseState\>\(MouseState?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseState\>\(MouseState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseState\>\(MouseState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseState\>\(MouseState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseState, TChild\>\(MouseState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseState, TChild\>\(MouseState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseState, TChild\>\(MouseState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseState\>\(MouseState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Input_States_MouseState_Buttons"></a> Buttons

```csharp
public readonly ButtonStates<MouseButton> Buttons
```

#### Field Value

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<MouseButton\>

## Properties

### <a id="osu_Framework_Input_States_MouseState_IsPositionValid"></a> IsPositionValid

```csharp
public bool IsPositionValid { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_MouseState_LastSource"></a> LastSource

The last input source to make a change to the state.

```csharp
public IInput LastSource { get; set; }
```

#### Property Value

 [IInput](osu.Framework.Input.StateChanges.IInput.md)

### <a id="osu_Framework_Input_States_MouseState_Position"></a> Position

```csharp
public Vector2 Position { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Input_States_MouseState_Scroll"></a> Scroll

```csharp
public Vector2 Scroll { get; set; }
```

#### Property Value

 Vector2

## Methods

### <a id="osu_Framework_Input_States_MouseState_IsPressed_osuTK_Input_MouseButton_"></a> IsPressed\(MouseButton\)

```csharp
public bool IsPressed(MouseButton button)
```

#### Parameters

`button` MouseButton

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_MouseState_SetPressed_osuTK_Input_MouseButton_System_Boolean_"></a> SetPressed\(MouseButton, bool\)

```csharp
public void SetPressed(MouseButton button, bool pressed)
```

#### Parameters

`button` MouseButton

`pressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_MouseState_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

