# <a id="osu_Framework_Input_States_TouchState"></a> Class TouchState

Namespace: [osu.Framework.Input.States](osu.Framework.Input.States.md)  
Assembly: osu.Framework.dll  

```csharp
public class TouchState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TouchState](osu.Framework.Input.States.TouchState.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TouchState\>\(TouchState?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TouchState\>\(TouchState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TouchState\>\(TouchState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TouchState\>\(TouchState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TouchState, TChild\>\(TouchState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TouchState, TChild\>\(TouchState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TouchState, TChild\>\(TouchState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TouchState\>\(TouchState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Input_States_TouchState_ActiveSources"></a> ActiveSources

The list of currently active touch sources.

```csharp
public readonly ButtonStates<TouchSource> ActiveSources
```

#### Field Value

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TouchSource](osu.Framework.Input.TouchSource.md)\>

### <a id="osu_Framework_Input_States_TouchState_MAX_TOUCH_COUNT"></a> MAX\_TOUCH\_COUNT

The maximum amount of touches this can handle.

```csharp
public static readonly int MAX_TOUCH_COUNT
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Input_States_TouchState_TouchPositions"></a> TouchPositions

The array to retrieve current touch positions from and set them.

```csharp
public readonly Vector2[] TouchPositions
```

#### Field Value

 Vector2\[\]

#### Remarks

Using <xref href="osu.Framework.Input.States.TouchState.GetTouchPosition(osu.Framework.Input.TouchSource)" data-throw-if-not-resolved="false"></xref> is recommended for retrieving
logically correct values, as this may contain already stale values.

## Methods

### <a id="osu_Framework_Input_States_TouchState_EnumerateDifference_osu_Framework_Input_States_TouchState_"></a> EnumerateDifference\(TouchState\)

Enumerates the difference between this state and a <param ref="previous" /> state.

```csharp
public (Touch[] deactivated, Touch[] activated) EnumerateDifference(TouchState previous)
```

#### Parameters

`previous` [TouchState](osu.Framework.Input.States.TouchState.md)

The previous state.

#### Returns

 \([Touch](osu.Framework.Input.Touch.md)\[\] [deactivated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-osu.framework.input.touch\[\],osu.framework.input.touch\[\]\-.deactivated), [Touch](osu.Framework.Input.Touch.md)\[\] [activated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-osu.framework.input.touch\[\],osu.framework.input.touch\[\]\-.activated)\)

### <a id="osu_Framework_Input_States_TouchState_GetTouchPosition_osu_Framework_Input_TouchSource_"></a> GetTouchPosition\(TouchSource\)

Retrieves the current touch position of a specified <code class="paramref">source</code>.

```csharp
public Vector2? GetTouchPosition(TouchSource source)
```

#### Parameters

`source` [TouchSource](osu.Framework.Input.TouchSource.md)

The touch source.

#### Returns

 Vector2?

The touch position, or null if provided <code class="paramref">source</code> is not currently active.

### <a id="osu_Framework_Input_States_TouchState_IsActive_osu_Framework_Input_TouchSource_"></a> IsActive\(TouchSource\)

Whether the provided touch <code class="paramref">source</code> is active.

```csharp
public bool IsActive(TouchSource source)
```

#### Parameters

`source` [TouchSource](osu.Framework.Input.TouchSource.md)

The touch source to check for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

