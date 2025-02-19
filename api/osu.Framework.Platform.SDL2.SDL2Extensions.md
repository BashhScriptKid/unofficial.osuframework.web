# <a id="osu_Framework_Platform_SDL2_SDL2Extensions"></a> Class SDL2Extensions

Namespace: [osu.Framework.Platform.SDL2](osu.Framework.Platform.SDL2.md)  
Assembly: osu.Framework.dll  

```csharp
public static class SDL2Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SDL2Extensions](osu.Framework.Platform.SDL2.SDL2Extensions.md)

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

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_GetAndClearError"></a> GetAndClearError\(\)

Gets the SDL error, and then clears it.

```csharp
public static string GetAndClearError()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ReadableName_SDL2_SDL_SDL_LogCategory_"></a> ReadableName\(SDL\_LogCategory\)

```csharp
public static string ReadableName(this SDL.SDL_LogCategory category)
```

#### Parameters

`category` SDL.SDL\_LogCategory

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ReadableName_SDL2_SDL_SDL_LogPriority_"></a> ReadableName\(SDL\_LogPriority\)

```csharp
public static string ReadableName(this SDL.SDL_LogPriority priority)
```

#### Parameters

`priority` SDL.SDL\_LogPriority

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ReadableString_SDL2_SDL_SDL_DisplayMode_"></a> ReadableString\(SDL\_DisplayMode\)

Gets the readable string for this <xref href="SDL2.SDL.SDL_DisplayMode" data-throw-if-not-resolved="false"></xref>.

```csharp
public static string ReadableString(this SDL.SDL_DisplayMode mode)
```

#### Parameters

`mode` SDL.SDL\_DisplayMode

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

<code>string</code> in the format of <code>1920x1080@60</code>.

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToDisplayMode_SDL2_SDL_SDL_DisplayMode_System_Int32_"></a> ToDisplayMode\(SDL\_DisplayMode, int\)

```csharp
public static DisplayMode ToDisplayMode(this SDL.SDL_DisplayMode mode, int displayIndex)
```

#### Parameters

`mode` SDL.SDL\_DisplayMode

`displayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [DisplayMode](osu.Framework.Platform.DisplayMode.md)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToFlags_osu_Framework_Platform_WindowState_"></a> ToFlags\(WindowState\)

```csharp
public static SDL.SDL_WindowFlags ToFlags(this WindowState state)
```

#### Parameters

`state` [WindowState](osu.Framework.Platform.WindowState.md)

#### Returns

 SDL.SDL\_WindowFlags

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToFlags_osu_Framework_Platform_GraphicsSurfaceType_"></a> ToFlags\(GraphicsSurfaceType\)

```csharp
public static SDL.SDL_WindowFlags ToFlags(this GraphicsSurfaceType surfaceType)
```

#### Parameters

`surfaceType` [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

#### Returns

 SDL.SDL\_WindowFlags

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToJoystickAxisSource_SDL2_SDL_SDL_GameControllerAxis_"></a> ToJoystickAxisSource\(SDL\_GameControllerAxis\)

```csharp
public static JoystickAxisSource ToJoystickAxisSource(this SDL.SDL_GameControllerAxis axis)
```

#### Parameters

`axis` SDL.SDL\_GameControllerAxis

#### Returns

 [JoystickAxisSource](osu.Framework.Input.JoystickAxisSource.md)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToJoystickButton_SDL2_SDL_SDL_GameControllerButton_"></a> ToJoystickButton\(SDL\_GameControllerButton\)

```csharp
public static JoystickButton ToJoystickButton(this SDL.SDL_GameControllerButton button)
```

#### Parameters

`button` SDL.SDL\_GameControllerButton

#### Returns

 [JoystickButton](osu.Framework.Input.JoystickButton.md)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToKey_SDL2_SDL_SDL_Keysym_"></a> ToKey\(SDL\_Keysym\)

```csharp
public static Key ToKey(this SDL.SDL_Keysym sdlKeysym)
```

#### Parameters

`sdlKeysym` SDL.SDL\_Keysym

#### Returns

 Key

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToSDLRect_osu_Framework_Graphics_Primitives_RectangleI_"></a> ToSDLRect\(RectangleI\)

```csharp
public static SDL.SDL_Rect ToSDLRect(this RectangleI rectangle)
```

#### Parameters

`rectangle` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

#### Returns

 SDL.SDL\_Rect

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToScancode_osu_Framework_Input_Bindings_InputKey_"></a> ToScancode\(InputKey\)

Returns the corresponding <xref href="SDL2.SDL.SDL_Scancode" data-throw-if-not-resolved="false"></xref> for a given <xref href="osu.Framework.Input.Bindings.InputKey" data-throw-if-not-resolved="false"></xref>.

```csharp
public static SDL.SDL_Scancode ToScancode(this InputKey inputKey)
```

#### Parameters

`inputKey` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

Should be a keyboard key.

#### Returns

 SDL.SDL\_Scancode

The corresponding <xref href="SDL2.SDL.SDL_Scancode" data-throw-if-not-resolved="false"></xref> if the <xref href="osu.Framework.Input.Bindings.InputKey" data-throw-if-not-resolved="false"></xref> is valid.
<xref href="SDL2.SDL.SDL_Scancode.SDL_SCANCODE_UNKNOWN" data-throw-if-not-resolved="false"></xref> otherwise.

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_ToWindowState_SDL2_SDL_SDL_WindowFlags_"></a> ToWindowState\(SDL\_WindowFlags\)

```csharp
public static WindowState ToWindowState(this SDL.SDL_WindowFlags windowFlags)
```

#### Parameters

`windowFlags` SDL.SDL\_WindowFlags

#### Returns

 [WindowState](osu.Framework.Platform.WindowState.md)

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_TryGetStringFromBytePointer_System_Byte__System_String__"></a> TryGetStringFromBytePointer\(byte\*, out string\)

Converts a UTF-8 byte pointer to a string.

```csharp
public static bool TryGetStringFromBytePointer(byte* bytePointer, out string str)
```

#### Parameters

`bytePointer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

Pointer to UTF-8 encoded byte array.

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

The resulting string

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<code>true</code> if the <code class="paramref">bytePointer</code> was successfully converted to a string.

#### Remarks

Most commonly used with SDL text events.

### <a id="osu_Framework_Platform_SDL2_SDL2Extensions_TryGetTouchName_SDL2_SDL_SDL_TouchFingerEvent_System_String__"></a> TryGetTouchName\(SDL\_TouchFingerEvent, out string\)

Gets the <code class="paramref">name</code> of the touch device for this <xref href="SDL2.SDL.SDL_TouchFingerEvent" data-throw-if-not-resolved="false"></xref>.

```csharp
public static bool TryGetTouchName(this SDL.SDL_TouchFingerEvent e, out string name)
```

#### Parameters

`e` SDL.SDL\_TouchFingerEvent

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

On Windows, this will return <code>"touch"</code> for touchscreen events or <code>"pen"</code> for pen/tablet events.

