# <a id="osu_Framework_Input_StateChanges_TouchInput"></a> Class TouchInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

Denotes a change of a touch input.

```csharp
public class TouchInput : IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TouchInput](osu.Framework.Input.StateChanges.TouchInput.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TouchInput\>\(TouchInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TouchInput\>\(TouchInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TouchInput\>\(TouchInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TouchInput\>\(TouchInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TouchInput, TChild\>\(TouchInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TouchInput, TChild\>\(TouchInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TouchInput, TChild\>\(TouchInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TouchInput\>\(TouchInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_TouchInput__ctor_osu_Framework_Input_Touch_System_Boolean_"></a> TouchInput\(Touch, bool\)

Constructs a new <xref href="osu.Framework.Input.StateChanges.TouchInput" data-throw-if-not-resolved="false"></xref>.

```csharp
public TouchInput(Touch touch, bool activate)
```

#### Parameters

`touch` [Touch](osu.Framework.Input.Touch.md)

The <xref href="osu.Framework.Input.Touch" data-throw-if-not-resolved="false"></xref>.

`activate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to activate the provided <param ref="touch" />, must be true if changing position only.

### <a id="osu_Framework_Input_StateChanges_TouchInput__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Input_Touch__System_Boolean_"></a> TouchInput\(IEnumerable<Touch\>, bool\)

Constructs a new <xref href="osu.Framework.Input.StateChanges.TouchInput" data-throw-if-not-resolved="false"></xref>.

```csharp
public TouchInput(IEnumerable<Touch> touches, bool activate)
```

#### Parameters

`touches` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Touch](osu.Framework.Input.Touch.md)\>

The list of <xref href="osu.Framework.Input.Touch" data-throw-if-not-resolved="false"></xref>es.

`activate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to activate the provided <param ref="touches" />, must be true if changing position only.

## Fields

### <a id="osu_Framework_Input_StateChanges_TouchInput_Activate"></a> Activate

Whether to activate the provided <xref href="osu.Framework.Input.StateChanges.TouchInput.Touches" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly bool Activate
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_StateChanges_TouchInput_Touches"></a> Touches

The list of touch structures each providing the source and position to move to.

```csharp
public readonly IEnumerable<Touch> Touches
```

#### Field Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Touch](osu.Framework.Input.Touch.md)\>

## Methods

### <a id="osu_Framework_Input_StateChanges_TouchInput_Apply_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInputStateChangeHandler_"></a> Apply\(InputState, IInputStateChangeHandler\)

Applies input to an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.
This alters the <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> and propagates the change to an <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Apply(InputState state, IInputStateChangeHandler handler)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> to apply changes to.

`handler` [IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md)

The <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref> to handle changes to <code class="paramref">state</code>.

