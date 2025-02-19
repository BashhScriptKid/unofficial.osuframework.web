# <a id="osu_Framework_Platform_IWindow"></a> Interface IWindow

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Interface representation of the game window, intended to hide any implementation-specific code.

```csharp
public interface IWindow : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IWindow\>\(IWindow?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IWindow\>\(IWindow\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IWindow\>\(IWindow\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IWindow\>\(IWindow\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IWindow, TChild\>\(IWindow, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IWindow, TChild\>\(IWindow, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IWindow, TChild\>\(IWindow, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IWindow\>\(IWindow\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Platform_IWindow_ClientSize"></a> ClientSize

The client size of the window in pixels (excluding any window decoration/border).

```csharp
Size ClientSize { get; }
```

#### Property Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

### <a id="osu_Framework_Platform_IWindow_CurrentDisplayBindable"></a> CurrentDisplayBindable

Exposes the <xref href="osu.Framework.Platform.Display" data-throw-if-not-resolved="false"></xref> that this window is currently on as a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref>.

```csharp
Bindable<Display> CurrentDisplayBindable { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[Display](osu.Framework.Platform.Display.md)\>

### <a id="osu_Framework_Platform_IWindow_CurrentDisplayMode"></a> CurrentDisplayMode

The <xref href="osu.Framework.Platform.DisplayMode" data-throw-if-not-resolved="false"></xref> for the display that this window is currently on.

```csharp
IBindable<DisplayMode> CurrentDisplayMode { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[DisplayMode](osu.Framework.Platform.DisplayMode.md)\>

### <a id="osu_Framework_Platform_IWindow_CursorConfineRect"></a> CursorConfineRect

Area to which the mouse cursor is confined to when <xref href="osu.Framework.Platform.IWindow.CursorState" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Platform.CursorState.Confined" data-throw-if-not-resolved="false"></xref>.

```csharp
RectangleF? CursorConfineRect { get; set; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

#### Remarks

Will confine to the whole window by default (or when set to <code>null</code>).
Supported fully on desktop platforms, and on Android when relative mode is enabled.

### <a id="osu_Framework_Platform_IWindow_CursorInWindow"></a> CursorInWindow

Whether the OS cursor is currently contained within the game window.

```csharp
IBindable<bool> CursorInWindow { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Platform_IWindow_CursorState"></a> CursorState

Controls the state of the OS cursor.

```csharp
CursorState CursorState { get; set; }
```

#### Property Value

 [CursorState](osu.Framework.Platform.CursorState.md)

#### Remarks

If the cursor is <xref href="osu.Framework.Platform.CursorState.Confined" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Platform.IWindow.CursorConfineRect" data-throw-if-not-resolved="false"></xref> will be used.

### <a id="osu_Framework_Platform_IWindow_DefaultWindowMode"></a> DefaultWindowMode

Returns the default <xref href="osu.Framework.Platform.IWindow.WindowMode" data-throw-if-not-resolved="false"></xref> for the implementation.

```csharp
WindowMode DefaultWindowMode { get; }
```

#### Property Value

 [WindowMode](osu.Framework.Configuration.WindowMode.md)

### <a id="osu_Framework_Platform_IWindow_Displays"></a> Displays

Contains information about the current physical displays.

```csharp
ImmutableArray<Display> Displays { get; }
```

#### Property Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[Display](osu.Framework.Platform.Display.md)\>

### <a id="osu_Framework_Platform_IWindow_Focused"></a> Focused

Whether the window currently has focus.

```csharp
[Obsolete("Use IWindow.IsActive.Value instead.")]
bool Focused { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_IWindow_IsActive"></a> IsActive

Whether this <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> is active (in the foreground).

```csharp
IBindable<bool> IsActive { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Platform_IWindow_MaxSize"></a> MaxSize

The maximum size of the window.

```csharp
Size MaxSize { get; set; }
```

#### Property Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when setting a negative or zero size, or a size less than <xref href="osu.Framework.Platform.IWindow.MinSize" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_IWindow_MinSize"></a> MinSize

The minimum size of the window.

```csharp
Size MinSize { get; set; }
```

#### Property Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when setting a negative size, or a size greater than <xref href="osu.Framework.Platform.IWindow.MaxSize" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_IWindow_Position"></a> Position

The position of the window.

```csharp
Point Position { get; }
```

#### Property Value

 [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

### <a id="osu_Framework_Platform_IWindow_PrimaryDisplay"></a> PrimaryDisplay

Gets the <xref href="osu.Framework.Platform.Display" data-throw-if-not-resolved="false"></xref> that has been set as "primary" or "default" in the operating system.

```csharp
Display PrimaryDisplay { get; }
```

#### Property Value

 [Display](osu.Framework.Platform.Display.md)

### <a id="osu_Framework_Platform_IWindow_Resizable"></a> Resizable

Gets or sets whether the window is user-resizable.

```csharp
bool Resizable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_IWindow_SafeAreaPadding"></a> SafeAreaPadding

Provides a <xref href="osu.Framework.Bindables.BindableSafeArea" data-throw-if-not-resolved="false"></xref> that can be used to keep track of the "safe area" insets on mobile
devices. This usually corresponds to areas of the screen hidden under notches and rounded corners.
The safe area insets are provided by the operating system and dynamically change as the user rotates the device.

```csharp
BindableSafeArea SafeAreaPadding { get; }
```

#### Property Value

 [BindableSafeArea](osu.Framework.Bindables.BindableSafeArea.md)

### <a id="osu_Framework_Platform_IWindow_Scale"></a> Scale

The ratio of <xref href="osu.Framework.Platform.IWindow.ClientSize" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Platform.IWindow.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
float Scale { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Platform_IWindow_Size"></a> Size

The size of the window in scaled pixels (excluding any window decoration/border).

```csharp
Size Size { get; }
```

#### Property Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

### <a id="osu_Framework_Platform_IWindow_SupportedWindowModes"></a> SupportedWindowModes

The <xref href="osu.Framework.Platform.IWindow.WindowMode" data-throw-if-not-resolved="false"></xref>s supported by this <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> implementation.

```csharp
IEnumerable<WindowMode> SupportedWindowModes { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[WindowMode](osu.Framework.Configuration.WindowMode.md)\>

### <a id="osu_Framework_Platform_IWindow_Title"></a> Title

The window title.

```csharp
string Title { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_IWindow_WindowMode"></a> WindowMode

Provides a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> that manages the current window mode.
Supported window modes for the current platform can be retrieved via <xref href="osu.Framework.Platform.IWindow.SupportedWindowModes" data-throw-if-not-resolved="false"></xref>.

```csharp
Bindable<WindowMode> WindowMode { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[WindowMode](osu.Framework.Configuration.WindowMode.md)\>

### <a id="osu_Framework_Platform_IWindow_WindowState"></a> WindowState

Controls the state of the window.

```csharp
WindowState WindowState { get; set; }
```

#### Property Value

 [WindowState](osu.Framework.Platform.WindowState.md)

## Methods

### <a id="osu_Framework_Platform_IWindow_CancelFlash"></a> CancelFlash\(\)

Attempts to cancel any window flash requested with <xref href="osu.Framework.Platform.IWindow.Flash(System.Boolean)" data-throw-if-not-resolved="false"></xref>.

```csharp
void CancelFlash()
```

#### Remarks

On platforms which don't support any kind of flashing (ie. mobile), this will be a no-op.

### <a id="osu_Framework_Platform_IWindow_Close"></a> Close\(\)

Forcefully closes the window.

```csharp
void Close()
```

### <a id="osu_Framework_Platform_IWindow_Create"></a> Create\(\)

Creates the concrete window implementation.

```csharp
void Create()
```

### <a id="osu_Framework_Platform_IWindow_CycleMode"></a> CycleMode\(\)

Cycles through the available <xref href="osu.Framework.Platform.IWindow.WindowMode" data-throw-if-not-resolved="false"></xref>s as determined by <xref href="osu.Framework.Platform.IWindow.SupportedWindowModes" data-throw-if-not-resolved="false"></xref>.

```csharp
void CycleMode()
```

### <a id="osu_Framework_Platform_IWindow_DisableScreenSuspension"></a> DisableScreenSuspension\(\)

Disable any system level timers that might dim or turn off the screen.

```csharp
void DisableScreenSuspension()
```

### <a id="osu_Framework_Platform_IWindow_EnableScreenSuspension"></a> EnableScreenSuspension\(\)

Enable any system level timers that might dim or turn off the screen.

```csharp
void EnableScreenSuspension()
```

### <a id="osu_Framework_Platform_IWindow_Flash_System_Boolean_"></a> Flash\(bool\)

Attempts to flash the window in order to request the user's attention.

```csharp
void Flash(bool flashUntilFocused = false)
```

#### Parameters

`flashUntilFocused` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

When <code>true</code>, the window will flash until it is focused again.
When <code>false</code> it will only flash momentarily.

#### Remarks

On platforms which don't support any kind of flashing (ie. mobile), this will be a no-op.

### <a id="osu_Framework_Platform_IWindow_Hide"></a> Hide\(\)

Attempts to hide the window, making it invisible and hidden from the taskbar.

```csharp
void Hide()
```

### <a id="osu_Framework_Platform_IWindow_OnDraw"></a> OnDraw\(\)

Invoked once a draw session has finished.

```csharp
void OnDraw()
```

### <a id="osu_Framework_Platform_IWindow_PointToClient_System_Drawing_Point_"></a> PointToClient\(Point\)

Convert a screen based coordinate to local window space.

```csharp
[Obsolete("This member should not be used. It was never properly implemented for cross-platform use.")]
Point PointToClient(Point point)
```

#### Parameters

`point` [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

#### Returns

 [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

### <a id="osu_Framework_Platform_IWindow_PointToScreen_System_Drawing_Point_"></a> PointToScreen\(Point\)

Convert a window based coordinate to global screen space.

```csharp
[Obsolete("This member should not be used. It was never properly implemented for cross-platform use.")]
Point PointToScreen(Point point)
```

#### Parameters

`point` [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

#### Returns

 [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

### <a id="osu_Framework_Platform_IWindow_Raise"></a> Raise\(\)

Attempts to raise the window, bringing it above other windows and requesting input focus.

```csharp
void Raise()
```

### <a id="osu_Framework_Platform_IWindow_Run"></a> Run\(\)

Start the window's run loop.
Is a blocking call on desktop platforms, and a non-blocking call on mobile platforms.

```csharp
void Run()
```

### <a id="osu_Framework_Platform_IWindow_SetIconFromStream_System_IO_Stream_"></a> SetIconFromStream\(Stream\)

Sets the window icon to the provided <code class="paramref">imageStream</code>.

```csharp
void SetIconFromStream(Stream imageStream)
```

#### Parameters

`imageStream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_Platform_IWindow_SetupWindow_osu_Framework_Configuration_FrameworkConfigManager_"></a> SetupWindow\(FrameworkConfigManager\)

Configures the <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> based on the provided <xref href="osu.Framework.Configuration.FrameworkConfigManager" data-throw-if-not-resolved="false"></xref>.

```csharp
void SetupWindow(FrameworkConfigManager config)
```

#### Parameters

`config` [FrameworkConfigManager](osu.Framework.Configuration.FrameworkConfigManager.md)

The configuration manager to use.

### <a id="osu_Framework_Platform_IWindow_Show"></a> Show\(\)

Attempts to show the window, making it visible.

```csharp
void Show()
```

### <a id="osu_Framework_Platform_IWindow_DisplaysChanged"></a> DisplaysChanged

Invoked when <xref href="osu.Framework.Platform.IWindow.Displays" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
event Action<IEnumerable<Display>>? DisplaysChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Display](osu.Framework.Platform.Display.md)\>\>?

### <a id="osu_Framework_Platform_IWindow_DragDrop"></a> DragDrop

Invoked when the user drops a file into the window.

```csharp
event Action<string>? DragDrop
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>?

### <a id="osu_Framework_Platform_IWindow_ExitRequested"></a> ExitRequested

Invoked when the window close (X) button or another platform-native exit action has been pressed.

```csharp
event Action? ExitRequested
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_Exited"></a> Exited

Invoked when the <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> has closed.

```csharp
event Action? Exited
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_KeymapChanged"></a> KeymapChanged

Invoked when the system keyboard layout has changed.

```csharp
event Action? KeymapChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_LowOnMemory"></a> LowOnMemory

Invoked when the operating system is low on memory, in order for the application to free some.

```csharp
event Action? LowOnMemory
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_Resized"></a> Resized

Invoked when the <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> client size has changed.

```csharp
event Action? Resized
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_Resumed"></a> Resumed

Invoked when the application associated with this <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> has been resumed from suspension.

```csharp
event Action? Resumed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_Suspended"></a> Suspended

Invoked when the application associated with this <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> has been suspended.

```csharp
event Action? Suspended
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_Update"></a> Update

Invoked once every window event loop.

```csharp
event Action? Update
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Platform_IWindow_WindowStateChanged"></a> WindowStateChanged

Invoked when <xref href="osu.Framework.Platform.IWindow.WindowState" data-throw-if-not-resolved="false"></xref> changes.

```csharp
event Action<WindowState>? WindowStateChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[WindowState](osu.Framework.Platform.WindowState.md)\>?

