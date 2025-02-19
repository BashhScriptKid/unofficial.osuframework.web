# <a id="osu_Framework_Input_Handlers_Joystick_JoystickHandler"></a> Class JoystickHandler

Namespace: [osu.Framework.Input.Handlers.Joystick](osu.Framework.Input.Handlers.Joystick.md)  
Assembly: osu.Framework.dll  

```csharp
public class JoystickHandler : InputHandler, IDisposable, IHasDescription
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputHandler](osu.Framework.Input.Handlers.InputHandler.md) ← 
[JoystickHandler](osu.Framework.Input.Handlers.Joystick.JoystickHandler.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md)

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

[ObjectExtensions.AsNonNull<JoystickHandler\>\(JoystickHandler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<JoystickHandler\>\(JoystickHandler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<JoystickHandler\>\(JoystickHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<JoystickHandler\>\(JoystickHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<JoystickHandler, TChild\>\(JoystickHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<JoystickHandler, TChild\>\(JoystickHandler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<JoystickHandler, TChild\>\(JoystickHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<JoystickHandler\>\(JoystickHandler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_Handlers_Joystick_JoystickHandler_DeadzoneThreshold"></a> DeadzoneThreshold

```csharp
public BindableFloat DeadzoneThreshold { get; }
```

#### Property Value

 [BindableFloat](osu.Framework.Bindables.BindableFloat.md)

### <a id="osu_Framework_Input_Handlers_Joystick_JoystickHandler_Description"></a> Description

A user-readable description of this input handler, for display in settings and logs.

```csharp
public override string Description { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Input_Handlers_Joystick_JoystickHandler_IsActive"></a> IsActive

Indicates whether this InputHandler is currently delivering input by the user. When handling input the OsuGame uses the first InputHandler which is active.

```csharp
public override bool IsActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Input_Handlers_Joystick_JoystickHandler_Initialize_osu_Framework_Platform_GameHost_"></a> Initialize\(GameHost\)

Used to initialize resources specific to this InputHandler. It gets called once.

```csharp
public override bool Initialize(GameHost host)
```

#### Parameters

`host` [GameHost](osu.Framework.Platform.GameHost.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Success of the initialization.

