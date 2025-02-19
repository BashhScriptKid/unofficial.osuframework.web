# <a id="osu_Framework_Android_AndroidGameHost"></a> Class AndroidGameHost

Namespace: [osu.Framework.Android](osu.Framework.Android.md)  
Assembly: osu.Framework.Android.dll  

```csharp
public class AndroidGameHost : SDLGameHost, IIpcHost, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
GameHost ← 
SDLGameHost ← 
[AndroidGameHost](osu.Framework.Android.AndroidGameHost.md)

#### Implements

IIpcHost, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

SDLGameHost.CapsLockEnabled, 
SDLGameHost.OnScreenKeyboardOverlapsGameWindow, 
SDLGameHost.CreateTextInput\(\), 
SDLGameHost.CreateClipboard\(\), 
SDLGameHost.CreateAvailableInputHandlers\(\), 
GameHost.Window, 
GameHost.RequireWindowExists, 
GameHost.Renderer, 
GameHost.RendererInfo, 
GameHost.AllowBenchmarkUnlimitedFrames, 
GameHost.DebugConfig, 
GameHost.Config, 
GameHost.IsActive, 
GameHost.AllowScreenSuspension, 
GameHost.IsPrimaryInstance, 
GameHost.Activated, 
GameHost.Deactivated, 
GameHost.ExitRequested, 
GameHost.Exited, 
GameHost.ExceptionThrown, 
GameHost.MessageReceived, 
GameHost.OnScreenKeyboardOverlapsGameWindow, 
GameHost.CanExit, 
GameHost.CanSuspendToBackground, 
GameHost.OnMessageReceived\(IpcMessage\), 
GameHost.SendMessageAsync\(IpcMessage\), 
GameHost.SendMessageWithResponseAsync\(IpcMessage\), 
GameHost.OpenFileExternally\(string\), 
GameHost.PresentFileExternally\(string\), 
GameHost.OpenUrlExternally\(string\), 
GameHost.CreateWindow\(GraphicsSurfaceType\), 
GameHost.GetClipboard\(\), 
GameHost.CreateClipboard\(\), 
GameHost.CreateReadableKeyCombinationProvider\(\), 
GameHost.InitialFileSelectorPath, 
GameHost.CreateSystemFileSelector\(string\[\]\), 
GameHost.GetStorage\(string\), 
GameHost.UserStoragePaths, 
GameHost.Storage, 
GameHost.CacheStorage, 
GameHost.CapsLockEnabled, 
GameHost.Threads, 
GameHost.RegisterThread\(GameThread\), 
GameHost.UnregisterThread\(GameThread\), 
GameHost.DrawThread, 
GameHost.UpdateThread, 
GameHost.InputThread, 
GameHost.AudioThread, 
GameHost.MaximumUpdateHz, 
GameHost.MaximumDrawHz, 
GameHost.MaximumInactiveHz, 
GameHost.FullPath, 
GameHost.Name, 
GameHost.Options, 
GameHost.Dependencies, 
GameHost.CreateGLRenderer\(\), 
GameHost.Collect\(\), 
GameHost.OnActivated\(\), 
GameHost.OnDeactivated\(\), 
GameHost.OnExitRequested\(\), 
GameHost.OnExited\(\), 
GameHost.UpdateFrame\(\), 
GameHost.DrawFrame\(\), 
GameHost.Swap\(\), 
GameHost.TakeScreenshotAsync\(\), 
GameHost.ExecutionState, 
GameHost.Exit\(\), 
GameHost.SuspendToBackground\(\), 
GameHost.PerformExit\(bool\), 
GameHost.Run\(Game\), 
GameHost.ResolvedRenderer, 
GameHost.GetPreferredRenderersForCurrentPlatform\(\), 
GameHost.ChooseAndSetupRenderer\(\), 
GameHost.SetupRendererAndWindow\(string, GraphicsSurfaceType\), 
GameHost.SetupRendererAndWindow\(IRenderer, GraphicsSurfaceType\), 
GameHost.GetDefaultGameStorage\(\), 
GameHost.Suspend\(\), 
GameHost.Resume\(\), 
GameHost.SetupForRun\(\), 
GameHost.ResetInputHandlers\(\), 
GameHost.SceneGraphClock, 
GameHost.PerformanceLogging, 
GameHost.SetupConfig\(IDictionary<FrameworkSetting, object\>\), 
GameHost.CreateAvailableInputHandlers\(\), 
GameHost.AvailableInputHandlers, 
GameHost.CreateTextInput\(\), 
GameHost.Dispose\(bool\), 
GameHost.Dispose\(\), 
GameHost.PlatformKeyBindings, 
GameHost.CreateTextureLoaderStore\(IResourceStore<byte\[\]\>\), 
GameHost.CreateVideoDecoder\(Stream\), 
GameHost.CreateThreadRunner\(InputThread\), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AndroidGameHost\>\(AndroidGameHost?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AndroidGameHost\>\(AndroidGameHost\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AndroidGameHost\>\(AndroidGameHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AndroidGameHost\>\(AndroidGameHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AndroidGameHost, TChild\>\(AndroidGameHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AndroidGameHost, TChild\>\(AndroidGameHost, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AndroidGameHost, TChild\>\(AndroidGameHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AndroidGameHost\>\(AndroidGameHost\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Android_AndroidGameHost__ctor_osu_Framework_Android_AndroidGameActivity_"></a> AndroidGameHost\(AndroidGameActivity\)

```csharp
public AndroidGameHost(AndroidGameActivity activity)
```

#### Parameters

`activity` [AndroidGameActivity](osu.Framework.Android.AndroidGameActivity.md)

## Properties

### <a id="osu_Framework_Android_AndroidGameHost_CanExit"></a> CanExit

Whether this host can exit (mobile platforms, for instance, do not support exiting the app).

```csharp
public override bool CanExit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

Also see <xref href="osu.Framework.Platform.GameHost.CanSuspendToBackground" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Android_AndroidGameHost_CanSuspendToBackground"></a> CanSuspendToBackground

Whether this host can suspend and minimize to background.

```csharp
public override bool CanSuspendToBackground { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This and <xref href="osu.Framework.Platform.GameHost.SuspendToBackground" data-throw-if-not-resolved="false"></xref> are an alternative way to exit on hosts that have <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref><code>false</code>.

### <a id="osu_Framework_Android_AndroidGameHost_InitialFileSelectorPath"></a> InitialFileSelectorPath

The default initial path when requesting a user to select a file/folder.

```csharp
public override string InitialFileSelectorPath { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

Provides a sane starting point for user-accessible storage.

### <a id="osu_Framework_Android_AndroidGameHost_OnScreenKeyboardOverlapsGameWindow"></a> OnScreenKeyboardOverlapsGameWindow

Whether the on-screen keyboard covers a portion of the game window when presented to the user.

```csharp
public override bool OnScreenKeyboardOverlapsGameWindow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Android_AndroidGameHost_UserStoragePaths"></a> UserStoragePaths

All valid user storage paths in order of usage priority.

```csharp
public override IEnumerable<string> UserStoragePaths { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="osu_Framework_Android_AndroidGameHost_CreateTextureLoaderStore_osu_Framework_IO_Stores_IResourceStore_System_Byte____"></a> CreateTextureLoaderStore\(IResourceStore<byte\[\]\>\)

Create a texture loader store based on an underlying data store.

```csharp
public override IResourceStore<TextureUpload> CreateTextureLoaderStore(IResourceStore<byte[]> underlyingStore)
```

#### Parameters

`underlyingStore` IResourceStore<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The underlying provider of texture data (in arbitrary image formats).

#### Returns

 IResourceStore<TextureUpload\>

A texture loader store.

### <a id="osu_Framework_Android_AndroidGameHost_CreateVideoDecoder_System_IO_Stream_"></a> CreateVideoDecoder\(Stream\)

Create a <xref href="osu.Framework.Graphics.Video.VideoDecoder" data-throw-if-not-resolved="false"></xref> with the given stream. May be overridden by platforms that require a different
decoder implementation.

```csharp
public override VideoDecoder CreateVideoDecoder(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref> to decode.

#### Returns

 VideoDecoder

An instance of <xref href="osu.Framework.Graphics.Video.VideoDecoder" data-throw-if-not-resolved="false"></xref> initialised with the given stream.

### <a id="osu_Framework_Android_AndroidGameHost_CreateWindow_osu_Framework_Platform_GraphicsSurfaceType_"></a> CreateWindow\(GraphicsSurfaceType\)

Creates the game window for the host.

```csharp
protected override IWindow CreateWindow(GraphicsSurfaceType preferredSurface)
```

#### Parameters

`preferredSurface` GraphicsSurfaceType

#### Returns

 IWindow

### <a id="osu_Framework_Android_AndroidGameHost_DrawFrame"></a> DrawFrame\(\)

```csharp
protected override void DrawFrame()
```

### <a id="osu_Framework_Android_AndroidGameHost_GetStorage_System_String_"></a> GetStorage\(string\)

Retrieve a storage for the specified location.

```csharp
public override Storage GetStorage(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The absolute path to be used as a root for the storage.

#### Returns

 Storage

### <a id="osu_Framework_Android_AndroidGameHost_OpenFileExternally_System_String_"></a> OpenFileExternally\(string\)

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

### <a id="osu_Framework_Android_AndroidGameHost_OpenUrlExternally_System_String_"></a> OpenUrlExternally\(string\)

Requests that a URL be opened externally in a web browser, if available.

```csharp
public override void OpenUrlExternally(string url)
```

#### Parameters

`url` [string](https://learn.microsoft.com/dotnet/api/system.string)

The URL of the page which should be opened.

### <a id="osu_Framework_Android_AndroidGameHost_PresentFileExternally_System_String_"></a> PresentFileExternally\(string\)

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

### <a id="osu_Framework_Android_AndroidGameHost_SetupConfig_System_Collections_Generic_IDictionary_osu_Framework_Configuration_FrameworkSetting_System_Object__"></a> SetupConfig\(IDictionary<FrameworkSetting, object\>\)

```csharp
protected override void SetupConfig(IDictionary<FrameworkSetting, object> defaultOverrides)
```

#### Parameters

`defaultOverrides` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<FrameworkSetting, [object](https://learn.microsoft.com/dotnet/api/system.object)\>

### <a id="osu_Framework_Android_AndroidGameHost_SuspendToBackground"></a> SuspendToBackground\(\)

Suspends and minimizes the game to background.

```csharp
public override bool SuspendToBackground()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<code>true</code> if the game was successfully suspended and minimized.

#### Remarks

This is provided as an alternative to <xref href="osu.Framework.Platform.GameHost.Exit" data-throw-if-not-resolved="false"></xref> on hosts that can't exit (see <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref>).
Should only be called if <xref href="osu.Framework.Platform.GameHost.CanSuspendToBackground" data-throw-if-not-resolved="false"></xref> is <code>true</code>.

