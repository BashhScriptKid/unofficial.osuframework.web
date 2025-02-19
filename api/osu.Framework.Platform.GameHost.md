# <a id="osu_Framework_Platform_GameHost"></a> Class GameHost

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class GameHost : IIpcHost, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameHost](osu.Framework.Platform.GameHost.md)

#### Derived

[SDLGameHost](osu.Framework.Platform.SDLGameHost.md)

#### Implements

[IIpcHost](osu.Framework.Platform.IIpcHost.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GameHost\>\(GameHost?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GameHost\>\(GameHost\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GameHost\>\(GameHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GameHost\>\(GameHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GameHost, TChild\>\(GameHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GameHost, TChild\>\(GameHost, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GameHost, TChild\>\(GameHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GameHost\>\(GameHost\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_GameHost__ctor_System_String_osu_Framework_HostOptions_"></a> GameHost\(string, HostOptions\)

```csharp
protected GameHost(string gameName, HostOptions options = null)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`options` [HostOptions](osu.Framework.HostOptions.md)

## Fields

### <a id="osu_Framework_Platform_GameHost_AllowScreenSuspension"></a> AllowScreenSuspension

Disable any system level timers that might dim or turn off the screen.

```csharp
public readonly AggregateBindable<bool> AllowScreenSuspension
```

#### Field Value

 [AggregateBindable](osu.Framework.Bindables.AggregateBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Remarks

To preserve battery life on mobile devices, this should be left on whenever possible.

### <a id="osu_Framework_Platform_GameHost_IsActive"></a> IsActive

Whether the <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> is active (in the foreground).

```csharp
public readonly IBindable<bool> IsActive
```

#### Field Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Platform_GameHost_PerformanceLogging"></a> PerformanceLogging

```csharp
public readonly Bindable<bool> PerformanceLogging
```

#### Field Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

## Properties

### <a id="osu_Framework_Platform_GameHost_AllowBenchmarkUnlimitedFrames"></a> AllowBenchmarkUnlimitedFrames

Whether "unlimited" frame limiter should be allowed to exceed sane limits.
Only use this for benchmarking purposes (see <xref href="osu.Framework.Platform.GameHost.maximum_sane_fps" data-throw-if-not-resolved="false"></xref> for further reasoning).

```csharp
public bool AllowBenchmarkUnlimitedFrames { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_GameHost_AudioThread"></a> AudioThread

```csharp
public AudioThread AudioThread { get; }
```

#### Property Value

 [AudioThread](osu.Framework.Threading.AudioThread.md)

### <a id="osu_Framework_Platform_GameHost_AvailableInputHandlers"></a> AvailableInputHandlers

```csharp
public ImmutableArray<InputHandler> AvailableInputHandlers { get; }
```

#### Property Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[InputHandler](osu.Framework.Input.Handlers.InputHandler.md)\>

### <a id="osu_Framework_Platform_GameHost_CacheStorage"></a> CacheStorage

An auxiliary cache storage which is fixed in the default game directory.

```csharp
public Storage CacheStorage { get; protected set; }
```

#### Property Value

 [Storage](osu.Framework.Platform.Storage.md)

### <a id="osu_Framework_Platform_GameHost_CanExit"></a> CanExit

Whether this host can exit (mobile platforms, for instance, do not support exiting the app).

```csharp
public virtual bool CanExit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

Also see <xref href="osu.Framework.Platform.GameHost.CanSuspendToBackground" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_CanSuspendToBackground"></a> CanSuspendToBackground

Whether this host can suspend and minimize to background.

```csharp
public virtual bool CanSuspendToBackground { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This and <xref href="osu.Framework.Platform.GameHost.SuspendToBackground" data-throw-if-not-resolved="false"></xref> are an alternative way to exit on hosts that have <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref><code>false</code>.

### <a id="osu_Framework_Platform_GameHost_CapsLockEnabled"></a> CapsLockEnabled

If caps-lock is enabled on the system, false if not overwritten by a subclass

```csharp
public virtual bool CapsLockEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_GameHost_Config"></a> Config

```csharp
protected FrameworkConfigManager Config { get; }
```

#### Property Value

 [FrameworkConfigManager](osu.Framework.Configuration.FrameworkConfigManager.md)

### <a id="osu_Framework_Platform_GameHost_DebugConfig"></a> DebugConfig

```csharp
protected FrameworkDebugConfigManager DebugConfig { get; }
```

#### Property Value

 [FrameworkDebugConfigManager](osu.Framework.Configuration.FrameworkDebugConfigManager.md)

### <a id="osu_Framework_Platform_GameHost_Dependencies"></a> Dependencies

```csharp
public DependencyContainer Dependencies { get; }
```

#### Property Value

 [DependencyContainer](osu.Framework.Allocation.DependencyContainer.md)

### <a id="osu_Framework_Platform_GameHost_DrawThread"></a> DrawThread

```csharp
public DrawThread DrawThread { get; }
```

#### Property Value

 [DrawThread](osu.Framework.Threading.DrawThread.md)

### <a id="osu_Framework_Platform_GameHost_ExecutionState"></a> ExecutionState

```csharp
public ExecutionState ExecutionState { get; }
```

#### Property Value

 [ExecutionState](osu.Framework.Platform.ExecutionState.md)

### <a id="osu_Framework_Platform_GameHost_FullPath"></a> FullPath

```csharp
public string FullPath { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_GameHost_InitialFileSelectorPath"></a> InitialFileSelectorPath

The default initial path when requesting a user to select a file/folder.

```csharp
public virtual string InitialFileSelectorPath { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

Provides a sane starting point for user-accessible storage.

### <a id="osu_Framework_Platform_GameHost_InputThread"></a> InputThread

```csharp
public InputThread InputThread { get; }
```

#### Property Value

 [InputThread](osu.Framework.Threading.InputThread.md)

### <a id="osu_Framework_Platform_GameHost_IsPrimaryInstance"></a> IsPrimaryInstance

For IPC messaging purposes, whether this <xref href="osu.Framework.Platform.GameHost" data-throw-if-not-resolved="false"></xref> is the primary (bound) host.

```csharp
public virtual bool IsPrimaryInstance { get; protected set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_GameHost_MaximumDrawHz"></a> MaximumDrawHz

The target number of draw frames per second when the game window is active.

```csharp
public double MaximumDrawHz { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A value of 0 is treated the same as "unlimited" or <xref href="System.Double.MaxValue" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_MaximumInactiveHz"></a> MaximumInactiveHz

The target number of updates per second when the game window is inactive.
This is applied to all threads.

```csharp
public double MaximumInactiveHz { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A value of 0 is treated the same as "unlimited" or <xref href="System.Double.MaxValue" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_MaximumUpdateHz"></a> MaximumUpdateHz

The target number of update frames per second when the game window is active.

```csharp
public double MaximumUpdateHz { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A value of 0 is treated the same as "unlimited" or <xref href="System.Double.MaxValue" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_Name"></a> Name

The name of the game to be hosted.

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_GameHost_OnScreenKeyboardOverlapsGameWindow"></a> OnScreenKeyboardOverlapsGameWindow

Whether the on-screen keyboard covers a portion of the game window when presented to the user.

```csharp
public virtual bool OnScreenKeyboardOverlapsGameWindow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_GameHost_Options"></a> Options

```csharp
[NotNull]
public HostOptions Options { get; }
```

#### Property Value

 [HostOptions](osu.Framework.HostOptions.md)

### <a id="osu_Framework_Platform_GameHost_PlatformKeyBindings"></a> PlatformKeyBindings

Defines the platform-specific key bindings that will be used by <xref href="osu.Framework.Input.PlatformActionContainer" data-throw-if-not-resolved="false"></xref>.
Should be overridden per-platform to provide native key bindings.

```csharp
public virtual IEnumerable<KeyBinding> PlatformKeyBindings { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[KeyBinding](osu.Framework.Input.Bindings.KeyBinding.md)\>

### <a id="osu_Framework_Platform_GameHost_Renderer"></a> Renderer

```csharp
public IRenderer Renderer { get; }
```

#### Property Value

 [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Platform_GameHost_RendererInfo"></a> RendererInfo

```csharp
public string RendererInfo { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_GameHost_RequireWindowExists"></a> RequireWindowExists

Whether <xref href="osu.Framework.Platform.GameHost.Window" data-throw-if-not-resolved="false"></xref> needs to be non-null for startup to succeed.

```csharp
protected virtual bool RequireWindowExists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_GameHost_ResolvedRenderer"></a> ResolvedRenderer

The renderer which the game host is currently running with.

```csharp
public RendererType ResolvedRenderer { get; }
```

#### Property Value

 [RendererType](osu.Framework.Configuration.RendererType.md)

#### Remarks

This is similar to <xref href="osu.Framework.Platform.IGraphicsSurface.Type" data-throw-if-not-resolved="false"></xref> except that this is expressed as a <xref href="osu.Framework.Configuration.RendererType" data-throw-if-not-resolved="false"></xref> rather than a <xref href="osu.Framework.Platform.GraphicsSurfaceType" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_SceneGraphClock"></a> SceneGraphClock

The clock which is to be used by the scene graph (will be assigned to <xref href="osu.Framework.Platform.GameHost.Root" data-throw-if-not-resolved="false"></xref>).

```csharp
protected virtual IFrameBasedClock SceneGraphClock { get; }
```

#### Property Value

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

### <a id="osu_Framework_Platform_GameHost_Storage"></a> Storage

The main storage as proposed by the host game.

```csharp
public Storage Storage { get; protected set; }
```

#### Property Value

 [Storage](osu.Framework.Platform.Storage.md)

### <a id="osu_Framework_Platform_GameHost_Threads"></a> Threads

```csharp
public IEnumerable<GameThread> Threads { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[GameThread](osu.Framework.Threading.GameThread.md)\>

### <a id="osu_Framework_Platform_GameHost_UpdateThread"></a> UpdateThread

```csharp
public GameThread UpdateThread { get; }
```

#### Property Value

 [GameThread](osu.Framework.Threading.GameThread.md)

### <a id="osu_Framework_Platform_GameHost_UserStoragePaths"></a> UserStoragePaths

All valid user storage paths in order of usage priority.

```csharp
public virtual IEnumerable<string> UserStoragePaths { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Platform_GameHost_Window"></a> Window

```csharp
public IWindow Window { get; }
```

#### Property Value

 [IWindow](osu.Framework.Platform.IWindow.md)

## Methods

### <a id="osu_Framework_Platform_GameHost_ChooseAndSetupRenderer"></a> ChooseAndSetupRenderer\(\)

```csharp
protected virtual void ChooseAndSetupRenderer()
```

### <a id="osu_Framework_Platform_GameHost_Collect"></a> Collect\(\)

Performs a GC collection and frees all framework caches.
This is a blocking call and should not be invoked during periods of user activity unless memory is critical.

```csharp
public void Collect()
```

### <a id="osu_Framework_Platform_GameHost_CreateAvailableInputHandlers"></a> CreateAvailableInputHandlers\(\)

Construct all input handlers for this host. The order here decides the priority given to handlers, with the earliest occurring having higher priority.

```csharp
protected abstract IEnumerable<InputHandler> CreateAvailableInputHandlers()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[InputHandler](osu.Framework.Input.Handlers.InputHandler.md)\>

### <a id="osu_Framework_Platform_GameHost_CreateClipboard"></a> CreateClipboard\(\)

```csharp
protected abstract Clipboard CreateClipboard()
```

#### Returns

 [Clipboard](osu.Framework.Platform.Clipboard.md)

### <a id="osu_Framework_Platform_GameHost_CreateGLRenderer"></a> CreateGLRenderer\(\)

```csharp
protected virtual IRenderer CreateGLRenderer()
```

#### Returns

 [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Platform_GameHost_CreateReadableKeyCombinationProvider"></a> CreateReadableKeyCombinationProvider\(\)

```csharp
protected virtual ReadableKeyCombinationProvider CreateReadableKeyCombinationProvider()
```

#### Returns

 [ReadableKeyCombinationProvider](osu.Framework.Input.ReadableKeyCombinationProvider.md)

### <a id="osu_Framework_Platform_GameHost_CreateSystemFileSelector_System_String___"></a> CreateSystemFileSelector\(string\[\]\)

Creates a provider component for interacting with a system-provided file selector.

```csharp
[CanBeNull]
public virtual ISystemFileSelector CreateSystemFileSelector(string[] allowedExtensions)
```

#### Parameters

`allowedExtensions` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

The list of extensions allowed to be selected, or empty to allow all files.

#### Returns

 [ISystemFileSelector](osu.Framework.Platform.ISystemFileSelector.md)

### <a id="osu_Framework_Platform_GameHost_CreateTextInput"></a> CreateTextInput\(\)

```csharp
protected virtual TextInputSource CreateTextInput()
```

#### Returns

 [TextInputSource](osu.Framework.Input.TextInputSource.md)

### <a id="osu_Framework_Platform_GameHost_CreateTextureLoaderStore_osu_Framework_IO_Stores_IResourceStore_System_Byte____"></a> CreateTextureLoaderStore\(IResourceStore<byte\[\]\>\)

Create a texture loader store based on an underlying data store.

```csharp
public virtual IResourceStore<TextureUpload> CreateTextureLoaderStore(IResourceStore<byte[]> underlyingStore)
```

#### Parameters

`underlyingStore` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The underlying provider of texture data (in arbitrary image formats).

#### Returns

 [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

A texture loader store.

### <a id="osu_Framework_Platform_GameHost_CreateThreadRunner_osu_Framework_Threading_InputThread_"></a> CreateThreadRunner\(InputThread\)

Creates the <xref href="osu.Framework.Platform.ThreadRunner" data-throw-if-not-resolved="false"></xref> to run the threads of this <xref href="osu.Framework.Platform.GameHost" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual ThreadRunner CreateThreadRunner(InputThread mainThread)
```

#### Parameters

`mainThread` [InputThread](osu.Framework.Threading.InputThread.md)

The main thread.

#### Returns

 [ThreadRunner](osu.Framework.Platform.ThreadRunner.md)

The <xref href="osu.Framework.Platform.ThreadRunner" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_CreateVideoDecoder_System_IO_Stream_"></a> CreateVideoDecoder\(Stream\)

Create a <xref href="osu.Framework.Graphics.Video.VideoDecoder" data-throw-if-not-resolved="false"></xref> with the given stream. May be overridden by platforms that require a different
decoder implementation.

```csharp
public virtual VideoDecoder CreateVideoDecoder(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref> to decode.

#### Returns

 [VideoDecoder](osu.Framework.Graphics.Video.VideoDecoder.md)

An instance of <xref href="osu.Framework.Graphics.Video.VideoDecoder" data-throw-if-not-resolved="false"></xref> initialised with the given stream.

### <a id="osu_Framework_Platform_GameHost_CreateWindow_osu_Framework_Platform_GraphicsSurfaceType_"></a> CreateWindow\(GraphicsSurfaceType\)

Creates the game window for the host.

```csharp
protected abstract IWindow CreateWindow(GraphicsSurfaceType preferredSurface)
```

#### Parameters

`preferredSurface` [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

#### Returns

 [IWindow](osu.Framework.Platform.IWindow.md)

### <a id="osu_Framework_Platform_GameHost_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_GameHost_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Platform_GameHost_DrawFrame"></a> DrawFrame\(\)

```csharp
protected virtual void DrawFrame()
```

### <a id="osu_Framework_Platform_GameHost_Exit"></a> Exit\(\)

Schedules the game to exit in the next frame.

```csharp
public void Exit()
```

#### Remarks

Consider using <xref href="osu.Framework.Platform.GameHost.SuspendToBackground" data-throw-if-not-resolved="false"></xref> on mobile platforms that can't exit normally.

### <a id="osu_Framework_Platform_GameHost_GetClipboard"></a> GetClipboard\(\)

```csharp
[Obsolete("Resolve Clipboard via DI.")]
public Clipboard GetClipboard()
```

#### Returns

 [Clipboard](osu.Framework.Platform.Clipboard.md)

### <a id="osu_Framework_Platform_GameHost_GetDefaultGameStorage"></a> GetDefaultGameStorage\(\)

Finds the default <xref href="osu.Framework.Platform.GameHost.Storage" data-throw-if-not-resolved="false"></xref> for the game to be used if <xref href="osu.Framework.Game.CreateStorage(osu.Framework.Platform.GameHost%2cosu.Framework.Platform.Storage)" data-throw-if-not-resolved="false"></xref> is not overridden.

```csharp
protected virtual Storage GetDefaultGameStorage()
```

#### Returns

 [Storage](osu.Framework.Platform.Storage.md)

The <xref href="osu.Framework.Platform.GameHost.Storage" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_GetPreferredRenderersForCurrentPlatform"></a> GetPreferredRenderersForCurrentPlatform\(\)

All valid <xref href="osu.Framework.Configuration.RendererType" data-throw-if-not-resolved="false"></xref>s for the current platform, in order of how stable and performant they are deemed to be.

```csharp
public IEnumerable<RendererType> GetPreferredRenderersForCurrentPlatform()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[RendererType](osu.Framework.Configuration.RendererType.md)\>

### <a id="osu_Framework_Platform_GameHost_GetStorage_System_String_"></a> GetStorage\(string\)

Retrieve a storage for the specified location.

```csharp
public abstract Storage GetStorage(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The absolute path to be used as a root for the storage.

#### Returns

 [Storage](osu.Framework.Platform.Storage.md)

### <a id="osu_Framework_Platform_GameHost_OnActivated"></a> OnActivated\(\)

```csharp
protected virtual void OnActivated()
```

### <a id="osu_Framework_Platform_GameHost_OnDeactivated"></a> OnDeactivated\(\)

```csharp
protected virtual void OnDeactivated()
```

### <a id="osu_Framework_Platform_GameHost_OnExitRequested"></a> OnExitRequested\(\)

```csharp
protected void OnExitRequested()
```

### <a id="osu_Framework_Platform_GameHost_OnExited"></a> OnExited\(\)

```csharp
protected virtual void OnExited()
```

### <a id="osu_Framework_Platform_GameHost_OnMessageReceived_osu_Framework_Platform_IpcMessage_"></a> OnMessageReceived\(IpcMessage\)

```csharp
protected IpcMessage OnMessageReceived(IpcMessage message)
```

#### Parameters

`message` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

#### Returns

 [IpcMessage](osu.Framework.Platform.IpcMessage.md)

### <a id="osu_Framework_Platform_GameHost_OpenFileExternally_System_String_"></a> OpenFileExternally\(string\)

Requests that a file or folder be opened externally with an associated application, if available.

```csharp
public abstract bool OpenFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The absolute path to the file which should be opened.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully opened.

#### Remarks

Some platforms do not support interacting with files externally (ie. mobile or sandboxed platforms), check the return value to discern whether it succeeded.

### <a id="osu_Framework_Platform_GameHost_OpenUrlExternally_System_String_"></a> OpenUrlExternally\(string\)

Requests that a URL be opened externally in a web browser, if available.

```csharp
public abstract void OpenUrlExternally(string url)
```

#### Parameters

`url` [string](https://learn.microsoft.com/dotnet/api/system.string)

The URL of the page which should be opened.

### <a id="osu_Framework_Platform_GameHost_PerformExit_System_Boolean_"></a> PerformExit\(bool\)

Schedules the game to exit in the next frame (or immediately if <code class="paramref">immediately</code> is true).

```csharp
protected virtual void PerformExit(bool immediately)
```

#### Parameters

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If true, exits the game immediately.  If false (default), schedules the game to exit in the next frame.

#### Remarks

Will never be called if <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Platform_GameHost_PresentFileExternally_System_String_"></a> PresentFileExternally\(string\)

Requests to present a file externally in the platform's native file browser.

```csharp
public abstract bool PresentFileExternally(string filename)
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

### <a id="osu_Framework_Platform_GameHost_RegisterThread_osu_Framework_Threading_GameThread_"></a> RegisterThread\(GameThread\)

Register a thread to be monitored and tracked by this <xref href="osu.Framework.Platform.GameHost" data-throw-if-not-resolved="false"></xref>

```csharp
public void RegisterThread(GameThread thread)
```

#### Parameters

`thread` [GameThread](osu.Framework.Threading.GameThread.md)

The thread.

### <a id="osu_Framework_Platform_GameHost_ResetInputHandlers"></a> ResetInputHandlers\(\)

Reset all input handlers' settings to a default state.

```csharp
public void ResetInputHandlers()
```

### <a id="osu_Framework_Platform_GameHost_Resume"></a> Resume\(\)

Resumes all of the current paused threads after <xref href="osu.Framework.Platform.GameHost.Suspend" data-throw-if-not-resolved="false"></xref> was called.

```csharp
public void Resume()
```

### <a id="osu_Framework_Platform_GameHost_Run_osu_Framework_Game_"></a> Run\(Game\)

```csharp
public void Run(Game game)
```

#### Parameters

`game` [Game](osu.Framework.Game.md)

### <a id="osu_Framework_Platform_GameHost_SendMessageAsync_osu_Framework_Platform_IpcMessage_"></a> SendMessageAsync\(IpcMessage\)

Asynchronously send a message to the IPC server.

```csharp
public virtual Task SendMessageAsync(IpcMessage message)
```

#### Parameters

`message` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Platform_GameHost_SendMessageWithResponseAsync_osu_Framework_Platform_IpcMessage_"></a> SendMessageWithResponseAsync\(IpcMessage\)

Asynchronously send a message to the IPC server and receive a response.

```csharp
public virtual Task<IpcMessage> SendMessageWithResponseAsync(IpcMessage message)
```

#### Parameters

`message` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

The message to send.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[IpcMessage](osu.Framework.Platform.IpcMessage.md)\>

The response from the server.

### <a id="osu_Framework_Platform_GameHost_SetupConfig_System_Collections_Generic_IDictionary_osu_Framework_Configuration_FrameworkSetting_System_Object__"></a> SetupConfig\(IDictionary<FrameworkSetting, object\>\)

```csharp
protected virtual void SetupConfig(IDictionary<FrameworkSetting, object> defaultOverrides)
```

#### Parameters

`defaultOverrides` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<[FrameworkSetting](osu.Framework.Configuration.FrameworkSetting.md), [object](https://learn.microsoft.com/dotnet/api/system.object)\>

### <a id="osu_Framework_Platform_GameHost_SetupForRun"></a> SetupForRun\(\)

Prepare this game host for <xref href="osu.Framework.Platform.GameHost.Run(osu.Framework.Game)" data-throw-if-not-resolved="false"></xref>.
<remarks><xref href="osu.Framework.Platform.GameHost.Storage" data-throw-if-not-resolved="false"></xref> is available here.
</remarks>

```csharp
protected virtual void SetupForRun()
```

### <a id="osu_Framework_Platform_GameHost_SetupRendererAndWindow_System_String_osu_Framework_Platform_GraphicsSurfaceType_"></a> SetupRendererAndWindow\(string, GraphicsSurfaceType\)

```csharp
protected void SetupRendererAndWindow(string renderer, GraphicsSurfaceType surfaceType)
```

#### Parameters

`renderer` [string](https://learn.microsoft.com/dotnet/api/system.string)

`surfaceType` [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

### <a id="osu_Framework_Platform_GameHost_SetupRendererAndWindow_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_Platform_GraphicsSurfaceType_"></a> SetupRendererAndWindow\(IRenderer, GraphicsSurfaceType\)

```csharp
protected void SetupRendererAndWindow(IRenderer renderer, GraphicsSurfaceType surfaceType)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`surfaceType` [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

### <a id="osu_Framework_Platform_GameHost_Suspend"></a> Suspend\(\)

Pauses all active threads. Call <xref href="osu.Framework.Platform.GameHost.Resume" data-throw-if-not-resolved="false"></xref> to resume execution.

```csharp
public void Suspend()
```

### <a id="osu_Framework_Platform_GameHost_SuspendToBackground"></a> SuspendToBackground\(\)

Suspends and minimizes the game to background.

```csharp
public virtual bool SuspendToBackground()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<code>true</code> if the game was successfully suspended and minimized.

#### Remarks

This is provided as an alternative to <xref href="osu.Framework.Platform.GameHost.Exit" data-throw-if-not-resolved="false"></xref> on hosts that can't exit (see <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref>).
Should only be called if <xref href="osu.Framework.Platform.GameHost.CanSuspendToBackground" data-throw-if-not-resolved="false"></xref> is <code>true</code>.

### <a id="osu_Framework_Platform_GameHost_Swap"></a> Swap\(\)

Swap the buffers.

```csharp
protected virtual void Swap()
```

### <a id="osu_Framework_Platform_GameHost_TakeScreenshotAsync"></a> TakeScreenshotAsync\(\)

Takes a screenshot of the game. The returned <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref> must be disposed by the caller when applicable.

```csharp
public Task<Image<Rgba32>> TakeScreenshotAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<Image<Rgba32\>\>

The screenshot as an <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Platform_GameHost_UnregisterThread_osu_Framework_Threading_GameThread_"></a> UnregisterThread\(GameThread\)

Unregister a previously registered thread.<xref href="osu.Framework.Platform.GameHost" data-throw-if-not-resolved="false"></xref>

```csharp
public void UnregisterThread(GameThread thread)
```

#### Parameters

`thread` [GameThread](osu.Framework.Threading.GameThread.md)

The thread.

### <a id="osu_Framework_Platform_GameHost_UpdateFrame"></a> UpdateFrame\(\)

```csharp
protected virtual void UpdateFrame()
```

### <a id="osu_Framework_Platform_GameHost_Activated"></a> Activated

Invoked when the game window is activated. Always invoked from the update thread.

```csharp
public event Action Activated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="osu_Framework_Platform_GameHost_Deactivated"></a> Deactivated

Invoked when the game window is deactivated. Always invoked from the update thread.

```csharp
public event Action Deactivated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="osu_Framework_Platform_GameHost_ExceptionThrown"></a> ExceptionThrown

An unhandled exception was thrown. Return true to ignore and continue running.

```csharp
public event Func<Exception, bool> ExceptionThrown
```

#### Event Type

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[Exception](https://learn.microsoft.com/dotnet/api/system.exception), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Platform_GameHost_ExitRequested"></a> ExitRequested

Invoked when an exit was requested. Always invoked from the update thread.

```csharp
public event Action ExitRequested
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Remarks

Usually invoked when the window close (X) button or another platform-native exit action has been pressed.

### <a id="osu_Framework_Platform_GameHost_Exited"></a> Exited

```csharp
public event Action Exited
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="osu_Framework_Platform_GameHost_MessageReceived"></a> MessageReceived

Invoked when a message is received by this IPC server.
Returns either a response in the form of an <xref href="osu.Framework.Platform.IpcMessage" data-throw-if-not-resolved="false"></xref>, or <code>null</code> for no response.

```csharp
[CanBeNull]
public event Func<IpcMessage, IpcMessage> MessageReceived
```

#### Event Type

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IpcMessage](osu.Framework.Platform.IpcMessage.md), [IpcMessage](osu.Framework.Platform.IpcMessage.md)\>

