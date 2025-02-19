# <a id="osu_Framework_Platform_SDL3_SDL3Extensions"></a> Class SDL3Extensions

Namespace: [osu.Framework.Platform.SDL3](osu.Framework.Platform.SDL3.md)  
Assembly: osu.Framework.dll  

```csharp
public static class SDL3Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SDL3Extensions](osu.Framework.Platform.SDL3.SDL3Extensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_GetAndClearError"></a> GetAndClearError\(\)

Gets the SDL error, and then clears it.

```csharp
public static string? GetAndClearError()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ReadableName_SDL_SDL_LogCategory_"></a> ReadableName\(SDL\_LogCategory\)

```csharp
public static string ReadableName(this SDL_LogCategory category)
```

#### Parameters

`category` SDL\_LogCategory

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ReadableName_SDL_SDL_LogPriority_"></a> ReadableName\(SDL\_LogPriority\)

```csharp
public static string ReadableName(this SDL_LogPriority priority)
```

#### Parameters

`priority` SDL\_LogPriority

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ReadableString_SDL_SDL_DisplayMode_"></a> ReadableString\(SDL\_DisplayMode\)

Gets the readable string for this <xref href="SDL.SDL_DisplayMode" data-throw-if-not-resolved="false"></xref>.

```csharp
public static string ReadableString(this SDL_DisplayMode mode)
```

#### Parameters

`mode` SDL\_DisplayMode

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

<code>string</code> in the format of <code>1920x1080@60</code>.

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToDisplayMode_SDL_SDL_DisplayMode_System_Int32_"></a> ToDisplayMode\(SDL\_DisplayMode, int\)

```csharp
public static DisplayMode ToDisplayMode(this SDL_DisplayMode mode, int displayIndex)
```

#### Parameters

`mode` SDL\_DisplayMode

`displayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [DisplayMode](osu.Framework.Platform.DisplayMode.md)

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToFlags_osu_Framework_Platform_WindowState_"></a> ToFlags\(WindowState\)

```csharp
public static SDL_WindowFlags ToFlags(this WindowState state)
```

#### Parameters

`state` [WindowState](osu.Framework.Platform.WindowState.md)

#### Returns

 SDL\_WindowFlags

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToFlags_osu_Framework_Platform_GraphicsSurfaceType_"></a> ToFlags\(GraphicsSurfaceType\)

```csharp
public static SDL_WindowFlags ToFlags(this GraphicsSurfaceType surfaceType)
```

#### Parameters

`surfaceType` [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

#### Returns

 SDL\_WindowFlags

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToJoystickAxisSource_SDL_SDL_GamepadAxis_"></a> ToJoystickAxisSource\(SDL\_GamepadAxis\)

```csharp
public static JoystickAxisSource ToJoystickAxisSource(this SDL_GamepadAxis axis)
```

#### Parameters

`axis` SDL\_GamepadAxis

#### Returns

 [JoystickAxisSource](osu.Framework.Input.JoystickAxisSource.md)

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToJoystickButton_SDL_SDL_GamepadButton_"></a> ToJoystickButton\(SDL\_GamepadButton\)

```csharp
public static JoystickButton ToJoystickButton(this SDL_GamepadButton button)
```

#### Parameters

`button` SDL\_GamepadButton

#### Returns

 [JoystickButton](osu.Framework.Input.JoystickButton.md)

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToKey_SDL_SDL_KeyboardEvent_"></a> ToKey\(SDL\_KeyboardEvent\)

```csharp
public static Key ToKey(this SDL_KeyboardEvent sdlKeyboardEvent)
```

#### Parameters

`sdlKeyboardEvent` SDL\_KeyboardEvent

#### Returns

 Key

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToSDLRect_osu_Framework_Graphics_Primitives_RectangleI_"></a> ToSDLRect\(RectangleI\)

```csharp
public static SDL_Rect ToSDLRect(this RectangleI rectangle)
```

#### Parameters

`rectangle` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

#### Returns

 SDL\_Rect

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToSDLTextInputType_osu_Framework_Input_TextInputType_"></a> ToSDLTextInputType\(TextInputType\)

```csharp
public static SDL_TextInputType ToSDLTextInputType(this TextInputType type)
```

#### Parameters

`type` [TextInputType](osu.Framework.Input.TextInputType.md)

#### Returns

 SDL\_TextInputType

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToScancode_osu_Framework_Input_Bindings_InputKey_"></a> ToScancode\(InputKey\)

Returns the corresponding <xref href="SDL.SDL_Scancode" data-throw-if-not-resolved="false"></xref> for a given <xref href="osu.Framework.Input.Bindings.InputKey" data-throw-if-not-resolved="false"></xref>.

```csharp
public static SDL_Scancode ToScancode(this InputKey inputKey)
```

#### Parameters

`inputKey` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

Should be a keyboard key.

#### Returns

 SDL\_Scancode

The corresponding <xref href="SDL.SDL_Scancode" data-throw-if-not-resolved="false"></xref> if the <xref href="osu.Framework.Input.Bindings.InputKey" data-throw-if-not-resolved="false"></xref> is valid.
<xref href="SDL.SDL_Scancode.SDL_SCANCODE_UNKNOWN" data-throw-if-not-resolved="false"></xref> otherwise.

### <a id="osu_Framework_Platform_SDL3_SDL3Extensions_ToWindowState_SDL_SDL_WindowFlags_System_Boolean_"></a> ToWindowState\(SDL\_WindowFlags, bool\)

```csharp
public static WindowState ToWindowState(this SDL_WindowFlags windowFlags, bool isFullscreenBorderless)
```

#### Parameters

`windowFlags` SDL\_WindowFlags

`isFullscreenBorderless` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [WindowState](osu.Framework.Platform.WindowState.md)

