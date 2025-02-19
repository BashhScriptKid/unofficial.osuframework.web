# <a id="osu_Framework_Platform_HeadlessGameHost"></a> Class HeadlessGameHost

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

A GameHost which doesn't require a graphical or sound device.

```csharp
public class HeadlessGameHost : DesktopGameHost, IIpcHost, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameHost](osu.Framework.Platform.GameHost.md) ← 
[SDLGameHost](osu.Framework.Platform.SDLGameHost.md) ← 
[DesktopGameHost](osu.Framework.Platform.DesktopGameHost.md) ← 
[HeadlessGameHost](osu.Framework.Platform.HeadlessGameHost.md)

#### Derived

[TestRunHeadlessGameHost](osu.Framework.Testing.TestRunHeadlessGameHost.md)

#### Implements

[IIpcHost](osu.Framework.Platform.IIpcHost.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[DesktopGameHost.GetDefaultGameStorage\(\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_GetDefaultGameStorage), 
[DesktopGameHost.GetStorage\(string\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_GetStorage\_System\_String\_), 
[DesktopGameHost.IsPrimaryInstance](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_IsPrimaryInstance), 
[DesktopGameHost.SetupForRun\(\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_SetupForRun), 
[DesktopGameHost.IsPortableInstallation](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_IsPortableInstallation), 
[DesktopGameHost.OpenFileExternally\(string\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_OpenFileExternally\_System\_String\_), 
[DesktopGameHost.OpenUrlExternally\(string\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_OpenUrlExternally\_System\_String\_), 
[DesktopGameHost.PresentFileExternally\(string\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_PresentFileExternally\_System\_String\_), 
[DesktopGameHost.SendMessageAsync\(IpcMessage\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_SendMessageAsync\_osu\_Framework\_Platform\_IpcMessage\_), 
[DesktopGameHost.SendMessageWithResponseAsync\(IpcMessage\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_SendMessageWithResponseAsync\_osu\_Framework\_Platform\_IpcMessage\_), 
[DesktopGameHost.Dispose\(bool\)](osu.Framework.Platform.DesktopGameHost.md\#osu\_Framework\_Platform\_DesktopGameHost\_Dispose\_System\_Boolean\_), 
[SDLGameHost.CapsLockEnabled](osu.Framework.Platform.SDLGameHost.md\#osu\_Framework\_Platform\_SDLGameHost\_CapsLockEnabled), 
[SDLGameHost.OnScreenKeyboardOverlapsGameWindow](osu.Framework.Platform.SDLGameHost.md\#osu\_Framework\_Platform\_SDLGameHost\_OnScreenKeyboardOverlapsGameWindow), 
[SDLGameHost.CreateTextInput\(\)](osu.Framework.Platform.SDLGameHost.md\#osu\_Framework\_Platform\_SDLGameHost\_CreateTextInput), 
[SDLGameHost.CreateClipboard\(\)](osu.Framework.Platform.SDLGameHost.md\#osu\_Framework\_Platform\_SDLGameHost\_CreateClipboard), 
[SDLGameHost.CreateAvailableInputHandlers\(\)](osu.Framework.Platform.SDLGameHost.md\#osu\_Framework\_Platform\_SDLGameHost\_CreateAvailableInputHandlers), 
[GameHost.Window](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Window), 
[GameHost.RequireWindowExists](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_RequireWindowExists), 
[GameHost.Renderer](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Renderer), 
[GameHost.RendererInfo](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_RendererInfo), 
[GameHost.AllowBenchmarkUnlimitedFrames](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_AllowBenchmarkUnlimitedFrames), 
[GameHost.DebugConfig](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_DebugConfig), 
[GameHost.Config](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Config), 
[GameHost.IsActive](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_IsActive), 
[GameHost.AllowScreenSuspension](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_AllowScreenSuspension), 
[GameHost.IsPrimaryInstance](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_IsPrimaryInstance), 
[GameHost.Activated](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Activated), 
[GameHost.Deactivated](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Deactivated), 
[GameHost.ExitRequested](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_ExitRequested), 
[GameHost.Exited](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Exited), 
[GameHost.ExceptionThrown](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_ExceptionThrown), 
[GameHost.MessageReceived](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_MessageReceived), 
[GameHost.OnScreenKeyboardOverlapsGameWindow](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OnScreenKeyboardOverlapsGameWindow), 
[GameHost.CanExit](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CanExit), 
[GameHost.CanSuspendToBackground](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CanSuspendToBackground), 
[GameHost.OnMessageReceived\(IpcMessage\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OnMessageReceived\_osu\_Framework\_Platform\_IpcMessage\_), 
[GameHost.SendMessageAsync\(IpcMessage\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SendMessageAsync\_osu\_Framework\_Platform\_IpcMessage\_), 
[GameHost.SendMessageWithResponseAsync\(IpcMessage\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SendMessageWithResponseAsync\_osu\_Framework\_Platform\_IpcMessage\_), 
[GameHost.OpenFileExternally\(string\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OpenFileExternally\_System\_String\_), 
[GameHost.PresentFileExternally\(string\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_PresentFileExternally\_System\_String\_), 
[GameHost.OpenUrlExternally\(string\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OpenUrlExternally\_System\_String\_), 
[GameHost.CreateWindow\(GraphicsSurfaceType\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateWindow\_osu\_Framework\_Platform\_GraphicsSurfaceType\_), 
[GameHost.GetClipboard\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_GetClipboard), 
[GameHost.CreateClipboard\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateClipboard), 
[GameHost.CreateReadableKeyCombinationProvider\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateReadableKeyCombinationProvider), 
[GameHost.InitialFileSelectorPath](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_InitialFileSelectorPath), 
[GameHost.CreateSystemFileSelector\(string\[\]\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateSystemFileSelector\_System\_String\_\_\_), 
[GameHost.GetStorage\(string\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_GetStorage\_System\_String\_), 
[GameHost.UserStoragePaths](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_UserStoragePaths), 
[GameHost.Storage](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Storage), 
[GameHost.CacheStorage](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CacheStorage), 
[GameHost.CapsLockEnabled](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CapsLockEnabled), 
[GameHost.Threads](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Threads), 
[GameHost.RegisterThread\(GameThread\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_RegisterThread\_osu\_Framework\_Threading\_GameThread\_), 
[GameHost.UnregisterThread\(GameThread\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_UnregisterThread\_osu\_Framework\_Threading\_GameThread\_), 
[GameHost.DrawThread](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_DrawThread), 
[GameHost.UpdateThread](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_UpdateThread), 
[GameHost.InputThread](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_InputThread), 
[GameHost.AudioThread](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_AudioThread), 
[GameHost.MaximumUpdateHz](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_MaximumUpdateHz), 
[GameHost.MaximumDrawHz](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_MaximumDrawHz), 
[GameHost.MaximumInactiveHz](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_MaximumInactiveHz), 
[GameHost.FullPath](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_FullPath), 
[GameHost.Name](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Name), 
[GameHost.Options](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Options), 
[GameHost.Dependencies](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Dependencies), 
[GameHost.CreateGLRenderer\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateGLRenderer), 
[GameHost.Collect\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Collect), 
[GameHost.OnActivated\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OnActivated), 
[GameHost.OnDeactivated\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OnDeactivated), 
[GameHost.OnExitRequested\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OnExitRequested), 
[GameHost.OnExited\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_OnExited), 
[GameHost.UpdateFrame\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_UpdateFrame), 
[GameHost.DrawFrame\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_DrawFrame), 
[GameHost.Swap\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Swap), 
[GameHost.TakeScreenshotAsync\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_TakeScreenshotAsync), 
[GameHost.ExecutionState](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_ExecutionState), 
[GameHost.Exit\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Exit), 
[GameHost.SuspendToBackground\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SuspendToBackground), 
[GameHost.PerformExit\(bool\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_PerformExit\_System\_Boolean\_), 
[GameHost.Run\(Game\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Run\_osu\_Framework\_Game\_), 
[GameHost.ResolvedRenderer](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_ResolvedRenderer), 
[GameHost.GetPreferredRenderersForCurrentPlatform\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_GetPreferredRenderersForCurrentPlatform), 
[GameHost.ChooseAndSetupRenderer\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_ChooseAndSetupRenderer), 
[GameHost.SetupRendererAndWindow\(string, GraphicsSurfaceType\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SetupRendererAndWindow\_System\_String\_osu\_Framework\_Platform\_GraphicsSurfaceType\_), 
[GameHost.SetupRendererAndWindow\(IRenderer, GraphicsSurfaceType\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SetupRendererAndWindow\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Platform\_GraphicsSurfaceType\_), 
[GameHost.GetDefaultGameStorage\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_GetDefaultGameStorage), 
[GameHost.Suspend\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Suspend), 
[GameHost.Resume\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Resume), 
[GameHost.SetupForRun\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SetupForRun), 
[GameHost.ResetInputHandlers\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_ResetInputHandlers), 
[GameHost.SceneGraphClock](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SceneGraphClock), 
[GameHost.PerformanceLogging](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_PerformanceLogging), 
[GameHost.SetupConfig\(IDictionary<FrameworkSetting, object\>\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_SetupConfig\_System\_Collections\_Generic\_IDictionary\_osu\_Framework\_Configuration\_FrameworkSetting\_System\_Object\_\_), 
[GameHost.CreateAvailableInputHandlers\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateAvailableInputHandlers), 
[GameHost.AvailableInputHandlers](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_AvailableInputHandlers), 
[GameHost.CreateTextInput\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateTextInput), 
[GameHost.Dispose\(bool\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Dispose\_System\_Boolean\_), 
[GameHost.Dispose\(\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_Dispose), 
[GameHost.PlatformKeyBindings](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_PlatformKeyBindings), 
[GameHost.CreateTextureLoaderStore\(IResourceStore<byte\[\]\>\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateTextureLoaderStore\_osu\_Framework\_IO\_Stores\_IResourceStore\_System\_Byte\_\_\_\_), 
[GameHost.CreateVideoDecoder\(Stream\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateVideoDecoder\_System\_IO\_Stream\_), 
[GameHost.CreateThreadRunner\(InputThread\)](osu.Framework.Platform.GameHost.md\#osu\_Framework\_Platform\_GameHost\_CreateThreadRunner\_osu\_Framework\_Threading\_InputThread\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HeadlessGameHost\>\(HeadlessGameHost?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HeadlessGameHost\>\(HeadlessGameHost\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HeadlessGameHost\>\(HeadlessGameHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HeadlessGameHost\>\(HeadlessGameHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HeadlessGameHost, TChild\>\(HeadlessGameHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HeadlessGameHost, TChild\>\(HeadlessGameHost, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HeadlessGameHost, TChild\>\(HeadlessGameHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HeadlessGameHost\>\(HeadlessGameHost\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_HeadlessGameHost__ctor_System_String_osu_Framework_HostOptions_System_Boolean_"></a> HeadlessGameHost\(string?, HostOptions?, bool\)

```csharp
public HeadlessGameHost(string? gameName = null, HostOptions? options = null, bool realtime = true)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`options` [HostOptions](osu.Framework.HostOptions.md)?

`realtime` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="osu_Framework_Platform_HeadlessGameHost_CLOCK_RATE"></a> CLOCK\_RATE

```csharp
public const double CLOCK_RATE = 33.333333333333336
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Properties

### <a id="osu_Framework_Platform_HeadlessGameHost_RequireWindowExists"></a> RequireWindowExists

Whether <xref href="osu.Framework.Platform.GameHost.Window" data-throw-if-not-resolved="false"></xref> needs to be non-null for startup to succeed.

```csharp
protected override bool RequireWindowExists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_HeadlessGameHost_SceneGraphClock"></a> SceneGraphClock

The clock which is to be used by the scene graph (will be assigned to <xref href="osu.Framework.Platform.GameHost.Root" data-throw-if-not-resolved="false"></xref>).

```csharp
protected override IFrameBasedClock SceneGraphClock { get; }
```

#### Property Value

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

### <a id="osu_Framework_Platform_HeadlessGameHost_UserStoragePaths"></a> UserStoragePaths

All valid user storage paths in order of usage priority.

```csharp
public override IEnumerable<string> UserStoragePaths { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="osu_Framework_Platform_HeadlessGameHost_ChooseAndSetupRenderer"></a> ChooseAndSetupRenderer\(\)

```csharp
protected override void ChooseAndSetupRenderer()
```

### <a id="osu_Framework_Platform_HeadlessGameHost_CreateAvailableInputHandlers"></a> CreateAvailableInputHandlers\(\)

Construct all input handlers for this host. The order here decides the priority given to handlers, with the earliest occurring having higher priority.

```csharp
protected override IEnumerable<InputHandler> CreateAvailableInputHandlers()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[InputHandler](osu.Framework.Input.Handlers.InputHandler.md)\>

### <a id="osu_Framework_Platform_HeadlessGameHost_CreateClipboard"></a> CreateClipboard\(\)

```csharp
protected override Clipboard CreateClipboard()
```

#### Returns

 [Clipboard](osu.Framework.Platform.Clipboard.md)

### <a id="osu_Framework_Platform_HeadlessGameHost_CreateWindow_osu_Framework_Platform_GraphicsSurfaceType_"></a> CreateWindow\(GraphicsSurfaceType\)

Creates the game window for the host.

```csharp
protected override IWindow CreateWindow(GraphicsSurfaceType preferredSurface)
```

#### Parameters

`preferredSurface` [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

#### Returns

 [IWindow](osu.Framework.Platform.IWindow.md)

### <a id="osu_Framework_Platform_HeadlessGameHost_DrawFrame"></a> DrawFrame\(\)

```csharp
protected override void DrawFrame()
```

### <a id="osu_Framework_Platform_HeadlessGameHost_OpenFileExternally_System_String_"></a> OpenFileExternally\(string\)

Requests that a file or folder be opened externally with an associated application, if available.

```csharp
public override bool OpenFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The absolute path to the file which should be opened.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully opened.

#### Remarks

Some platforms do not support interacting with files externally (ie. mobile or sandboxed platforms), check the return value to discern whether it succeeded.

### <a id="osu_Framework_Platform_HeadlessGameHost_OpenUrlExternally_System_String_"></a> OpenUrlExternally\(string\)

Requests that a URL be opened externally in a web browser, if available.

```csharp
public override void OpenUrlExternally(string url)
```

#### Parameters

`url` [string](https://learn.microsoft.com/dotnet/api/system.string)

The URL of the page which should be opened.

### <a id="osu_Framework_Platform_HeadlessGameHost_PresentFileExternally_System_String_"></a> PresentFileExternally\(string\)

Requests to present a file externally in the platform's native file browser.

```csharp
public override bool PresentFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The absolute path to the file/folder to be shown in its parent folder.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully presented.

#### Examples

<p>"C:\Windows\explorer.exe" -&gt; opens 'C:\Windows' and highlights 'explorer.exe' in the window.</p>
<p>"C:\Windows\System32" -&gt; opens 'C:\Windows' and highlights 'System32' in the window.</p>

#### Remarks

This will open the parent folder and, (if available) highlight the file.
Some platforms do not support interacting with files externally (ie. mobile or sandboxed platforms), check the return value to discern whether it succeeded.

If a folder path is provided to this method, it will prefer highlighting the folder in the parent folder, rather than showing the contents.
To display the contents of a folder, use <xref href="osu.Framework.Platform.GameHost.OpenFileExternally(System.String)" data-throw-if-not-resolved="false"></xref> instead.

### <a id="osu_Framework_Platform_HeadlessGameHost_SetupConfig_System_Collections_Generic_IDictionary_osu_Framework_Configuration_FrameworkSetting_System_Object__"></a> SetupConfig\(IDictionary<FrameworkSetting, object\>\)

```csharp
protected override void SetupConfig(IDictionary<FrameworkSetting, object> defaultOverrides)
```

#### Parameters

`defaultOverrides` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<[FrameworkSetting](osu.Framework.Configuration.FrameworkSetting.md), [object](https://learn.microsoft.com/dotnet/api/system.object)\>

### <a id="osu_Framework_Platform_HeadlessGameHost_SetupForRun"></a> SetupForRun\(\)

Prepare this game host for <xref href="osu.Framework.Platform.GameHost.Run(osu.Framework.Game)" data-throw-if-not-resolved="false"></xref>.
<remarks><xref href="osu.Framework.Platform.GameHost.Storage" data-throw-if-not-resolved="false"></xref> is available here.
</remarks>

```csharp
protected override void SetupForRun()
```

### <a id="osu_Framework_Platform_HeadlessGameHost_UpdateFrame"></a> UpdateFrame\(\)

```csharp
protected override void UpdateFrame()
```

