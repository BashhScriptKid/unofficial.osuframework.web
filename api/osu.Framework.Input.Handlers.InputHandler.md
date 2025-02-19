# <a id="osu_Framework_Input_Handlers_InputHandler"></a> Class InputHandler

Namespace: [osu.Framework.Input.Handlers](osu.Framework.Input.Handlers.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class InputHandler : IDisposable, IHasDescription
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputHandler](osu.Framework.Input.Handlers.InputHandler.md)

#### Derived

[JoystickHandler](osu.Framework.Input.Handlers.Joystick.JoystickHandler.md), 
[KeyboardHandler](osu.Framework.Input.Handlers.Keyboard.KeyboardHandler.md), 
[MidiHandler](osu.Framework.Input.Handlers.Midi.MidiHandler.md), 
[MouseHandler](osu.Framework.Input.Handlers.Mouse.MouseHandler.md), 
[OpenTabletDriverHandler](osu.Framework.Input.Handlers.Tablet.OpenTabletDriverHandler.md), 
[PenHandler](osu.Framework.Input.Handlers.Pen.PenHandler.md), 
[TouchHandler](osu.Framework.Input.Handlers.Touch.TouchHandler.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<InputHandler\>\(InputHandler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InputHandler\>\(InputHandler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InputHandler\>\(InputHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InputHandler\>\(InputHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InputHandler, TChild\>\(InputHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InputHandler, TChild\>\(InputHandler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InputHandler, TChild\>\(InputHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InputHandler\>\(InputHandler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Input_Handlers_InputHandler_IsDisposed"></a> IsDisposed

```csharp
protected bool IsDisposed
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Handlers_InputHandler_PendingInputs"></a> PendingInputs

```csharp
protected ConcurrentQueue<IInput> PendingInputs
```

#### Field Value

 [ConcurrentQueue](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.concurrentqueue\-1)<[IInput](osu.Framework.Input.StateChanges.IInput.md)\>

### <a id="osu_Framework_Input_Handlers_InputHandler_STATISTIC_GROUP"></a> STATISTIC\_GROUP

Base category to use for input-related <xref href="osu.Framework.Statistics.GlobalStatistics" data-throw-if-not-resolved="false"></xref>.

```csharp
public const string STATISTIC_GROUP = "Input"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_Input_Handlers_InputHandler_Description"></a> Description

A user-readable description of this input handler, for display in settings and logs.

```csharp
public virtual string Description { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Input_Handlers_InputHandler_Enabled"></a> Enabled

Whether this InputHandler should be collecting <xref href="osu.Framework.Input.StateChanges.IInput" data-throw-if-not-resolved="false"></xref>s to return on the next <xref href="osu.Framework.Input.Handlers.InputHandler.CollectPendingInputs(System.Collections.Generic.List%7bosu.Framework.Input.StateChanges.IInput%7d)" data-throw-if-not-resolved="false"></xref> call

```csharp
public BindableBool Enabled { get; }
```

#### Property Value

 [BindableBool](osu.Framework.Bindables.BindableBool.md)

### <a id="osu_Framework_Input_Handlers_InputHandler_IsActive"></a> IsActive

Indicates whether this InputHandler is currently delivering input by the user. When handling input the OsuGame uses the first InputHandler which is active.

```csharp
public abstract bool IsActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Input_Handlers_InputHandler_CollectPendingInputs_System_Collections_Generic_List_osu_Framework_Input_StateChanges_IInput__"></a> CollectPendingInputs\(List<IInput\>\)

Add all pending states since the last call to this method to a provided list.

```csharp
public virtual void CollectPendingInputs(List<IInput> inputs)
```

#### Parameters

`inputs` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IInput](osu.Framework.Input.StateChanges.IInput.md)\>

The list for pending inputs to be added to.

### <a id="osu_Framework_Input_Handlers_InputHandler_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Handlers_InputHandler_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Input_Handlers_InputHandler_Initialize_osu_Framework_Platform_GameHost_"></a> Initialize\(GameHost\)

Used to initialize resources specific to this InputHandler. It gets called once.

```csharp
public virtual bool Initialize(GameHost host)
```

#### Parameters

`host` [GameHost](osu.Framework.Platform.GameHost.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Success of the initialization.

### <a id="osu_Framework_Input_Handlers_InputHandler_Log_System_String_osu_Framework_Logging_LogLevel_System_Exception_"></a> Log\(string, LogLevel, Exception\)

Logs an arbitrary string prefixed by the name of this input handler.

```csharp
protected void Log(string message, LogLevel level = LogLevel.Verbose, Exception exception = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message to log. Can include newline (\n) characters to split into multiple lines.

`level` [LogLevel](osu.Framework.Logging.LogLevel.md)

The verbosity level.

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

An optional related exception.

### <a id="osu_Framework_Input_Handlers_InputHandler_Reset"></a> Reset\(\)

Reset this handler to a sane default state. This should reset any settings a consumer or user may have changed in order to attempt to make the handler usable again.

```csharp
public virtual void Reset()
```

#### Remarks

An example would be a user setting the sensitivity too high to turn it back down, or restricting the navigable screen area too small.
Calling this would attempt to return the user to a sane state so they could re-attempt configuration changes.

### <a id="osu_Framework_Input_Handlers_InputHandler_StatisticGroupFor__1"></a> StatisticGroupFor<T\>\(\)

Gets the appropriate statistic group for use in <xref href="osu.Framework.Statistics.GlobalStatistics.Get%60%601(System.String%2cSystem.String)" data-throw-if-not-resolved="false"></xref>.

```csharp
protected static string StatisticGroupFor<T>() where T : InputHandler
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Type Parameters

`T` 

Calling class

### <a id="osu_Framework_Input_Handlers_InputHandler_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

