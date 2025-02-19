# <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler"></a> Class MouseHandler

Namespace: [osu.Framework.Input.Handlers.Mouse](osu.Framework.Input.Handlers.Mouse.md)  
Assembly: osu.Framework.dll  

Handles mouse events from an <xref href="osu.Framework.Platform.ISDLWindow" data-throw-if-not-resolved="false"></xref>.
Will use relative mouse mode where possible.

```csharp
public class MouseHandler : InputHandler, IDisposable, IHasDescription, IHasCursorSensitivity, INeedsMousePositionFeedback
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputHandler](osu.Framework.Input.Handlers.InputHandler.md) ← 
[MouseHandler](osu.Framework.Input.Handlers.Mouse.MouseHandler.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IHasCursorSensitivity](osu.Framework.Input.Handlers.IHasCursorSensitivity.md), 
[INeedsMousePositionFeedback](osu.Framework.Input.Handlers.INeedsMousePositionFeedback.md)

#### Inherited Members

[InputHandler.STATISTIC\_GROUP](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_STATISTIC\_GROUP), 
[InputHandler.StatisticGroupFor<T\>\(\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_StatisticGroupFor\_\_1), 
[InputHandler.Initialize\(GameHost\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Initialize\_osu\_Framework\_Platform\_GameHost\_), 
[InputHandler.Reset\(\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Reset), 
[InputHandler.PendingInputs](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_PendingInputs), 
[InputHandler.CollectPendingInputs\(List<IInput\>\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_CollectPendingInputs\_System\_Collections\_Generic\_List\_osu\_Framework\_Input\_StateChanges\_IInput\_\_), 
[InputHandler.IsActive](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_IsActive), 
[InputHandler.Description](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Description), 
[InputHandler.Enabled](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Enabled), 
[InputHandler.Log\(string, LogLevel, Exception\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Log\_System\_String\_osu\_Framework\_Logging\_LogLevel\_System\_Exception\_), 
[InputHandler.ToString\(\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_ToString), 
[InputHandler.IsDisposed](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_IsDisposed), 
[InputHandler.Dispose\(bool\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Dispose\_System\_Boolean\_), 
[InputHandler.Dispose\(\)](osu.Framework.Input.Handlers.InputHandler.md\#osu\_Framework\_Input\_Handlers\_InputHandler\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MouseHandler\>\(MouseHandler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseHandler\>\(MouseHandler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseHandler\>\(MouseHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseHandler\>\(MouseHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseHandler, TChild\>\(MouseHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseHandler, TChild\>\(MouseHandler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseHandler, TChild\>\(MouseHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseHandler\>\(MouseHandler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_Description"></a> Description

A user-readable description of this input handler, for display in settings and logs.

```csharp
public override string Description { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_IsActive"></a> IsActive

Indicates whether this InputHandler is currently delivering input by the user. When handling input the OsuGame uses the first InputHandler which is active.

```csharp
public override bool IsActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_Sensitivity"></a> Sensitivity

```csharp
public BindableDouble Sensitivity { get; }
```

#### Property Value

 [BindableDouble](osu.Framework.Bindables.BindableDouble.md)

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_UseRelativeMode"></a> UseRelativeMode

Whether relative mode should be preferred when the window has focus, the cursor is contained and the OS cursor is not visible.

```csharp
public BindableBool UseRelativeMode { get; }
```

#### Property Value

 [BindableBool](osu.Framework.Bindables.BindableBool.md)

## Methods

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_FeedbackMousePositionChange_osuTK_Vector2_System_Boolean_"></a> FeedbackMousePositionChange\(Vector2, bool\)

Receives the final mouse position from an <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual void FeedbackMousePositionChange(Vector2 position, bool isSelfFeedback)
```

#### Parameters

`position` Vector2

The final mouse position.

`isSelfFeedback` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the feedback was triggered from this handler.

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_HandleMouseMove_osuTK_Vector2_"></a> HandleMouseMove\(Vector2\)

```csharp
protected virtual void HandleMouseMove(Vector2 position)
```

#### Parameters

`position` Vector2

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_HandleMouseMoveRelative_osuTK_Vector2_"></a> HandleMouseMoveRelative\(Vector2\)

```csharp
protected virtual void HandleMouseMoveRelative(Vector2 delta)
```

#### Parameters

`delta` Vector2

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_Initialize_osu_Framework_Platform_GameHost_"></a> Initialize\(GameHost\)

Used to initialize resources specific to this InputHandler. It gets called once.

```csharp
public override bool Initialize(GameHost host)
```

#### Parameters

`host` [GameHost](osu.Framework.Platform.GameHost.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Success of the initialization.

### <a id="osu_Framework_Input_Handlers_Mouse_MouseHandler_Reset"></a> Reset\(\)

Reset this handler to a sane default state. This should reset any settings a consumer or user may have changed in order to attempt to make the handler usable again.

```csharp
public override void Reset()
```

#### Remarks

An example would be a user setting the sensitivity too high to turn it back down, or restricting the navigable screen area too small.
Calling this would attempt to return the user to a sane state so they could re-attempt configuration changes.

