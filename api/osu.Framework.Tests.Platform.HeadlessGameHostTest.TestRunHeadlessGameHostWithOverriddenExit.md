# <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit"></a> Class HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit

Namespace: [osu.Framework.Tests.Platform](osu.Framework.Tests.Platform.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit : TestRunHeadlessGameHost, IIpcHost, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameHost](osu.Framework.Platform.GameHost.md) ← 
[SDLGameHost](osu.Framework.Platform.SDLGameHost.md) ← 
[DesktopGameHost](osu.Framework.Platform.DesktopGameHost.md) ← 
[HeadlessGameHost](osu.Framework.Platform.HeadlessGameHost.md) ← 
[TestRunHeadlessGameHost](osu.Framework.Testing.TestRunHeadlessGameHost.md) ← 
[HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit](osu.Framework.Tests.Platform.HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit.md)

#### Implements

[IIpcHost](osu.Framework.Platform.IIpcHost.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[TestRunHeadlessGameHost.UserStoragePaths](osu.Framework.Testing.TestRunHeadlessGameHost.md\#osu\_Framework\_Testing\_TestRunHeadlessGameHost\_UserStoragePaths), 
[TestRunHeadlessGameHost.TemporaryTestDirectory](osu.Framework.Testing.TestRunHeadlessGameHost.md\#osu\_Framework\_Testing\_TestRunHeadlessGameHost\_TemporaryTestDirectory), 
[TestRunHeadlessGameHost.Dispose\(bool\)](osu.Framework.Testing.TestRunHeadlessGameHost.md\#osu\_Framework\_Testing\_TestRunHeadlessGameHost\_Dispose\_System\_Boolean\_), 
[HeadlessGameHost.CLOCK\_RATE](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_CLOCK\_RATE), 
[HeadlessGameHost.SceneGraphClock](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_SceneGraphClock), 
[HeadlessGameHost.OpenFileExternally\(string\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_OpenFileExternally\_System\_String\_), 
[HeadlessGameHost.PresentFileExternally\(string\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_PresentFileExternally\_System\_String\_), 
[HeadlessGameHost.OpenUrlExternally\(string\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_OpenUrlExternally\_System\_String\_), 
[HeadlessGameHost.UserStoragePaths](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_UserStoragePaths), 
[HeadlessGameHost.RequireWindowExists](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_RequireWindowExists), 
[HeadlessGameHost.CreateWindow\(GraphicsSurfaceType\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_CreateWindow\_osu\_Framework\_Platform\_GraphicsSurfaceType\_), 
[HeadlessGameHost.CreateClipboard\(\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_CreateClipboard), 
[HeadlessGameHost.ChooseAndSetupRenderer\(\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_ChooseAndSetupRenderer), 
[HeadlessGameHost.SetupConfig\(IDictionary<FrameworkSetting, object\>\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_SetupConfig\_System\_Collections\_Generic\_IDictionary\_osu\_Framework\_Configuration\_FrameworkSetting\_System\_Object\_\_), 
[HeadlessGameHost.SetupForRun\(\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_SetupForRun), 
[HeadlessGameHost.DrawFrame\(\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_DrawFrame), 
[HeadlessGameHost.UpdateFrame\(\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_UpdateFrame), 
[HeadlessGameHost.CreateAvailableInputHandlers\(\)](osu.Framework.Platform.HeadlessGameHost.md\#osu\_Framework\_Platform\_HeadlessGameHost\_CreateAvailableInputHandlers), 
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

[ObjectExtensions.AsNonNull<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit, TChild\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit, TChild\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit, TChild\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\>\(HeadlessGameHostTest.TestRunHeadlessGameHostWithOverriddenExit\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit__ctor_System_String_"></a> TestRunHeadlessGameHostWithOverriddenExit\(string\)

```csharp
public TestRunHeadlessGameHostWithOverriddenExit(string gameName)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit__ctor_System_String_"></a> TestRunHeadlessGameHostWithOverriddenExit\(string\)

```csharp
public TestRunHeadlessGameHostWithOverriddenExit(string gameName)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit__ctor_System_String_"></a> TestRunHeadlessGameHostWithOverriddenExit\(string\)

```csharp
public TestRunHeadlessGameHostWithOverriddenExit(string gameName)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit_PerformExit_System_Boolean_"></a> PerformExit\(bool\)

Schedules the game to exit in the next frame (or immediately if <code class="paramref">immediately</code> is true).

```csharp
protected override void PerformExit(bool immediately)
```

#### Parameters

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If true, exits the game immediately.  If false (default), schedules the game to exit in the next frame.

#### Remarks

Will never be called if <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit_PerformExit_System_Boolean_"></a> PerformExit\(bool\)

Schedules the game to exit in the next frame (or immediately if <code class="paramref">immediately</code> is true).

```csharp
protected override void PerformExit(bool immediately)
```

#### Parameters

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If true, exits the game immediately.  If false (default), schedules the game to exit in the next frame.

#### Remarks

Will never be called if <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestRunHeadlessGameHostWithOverriddenExit_PerformExit_System_Boolean_"></a> PerformExit\(bool\)

Schedules the game to exit in the next frame (or immediately if <code class="paramref">immediately</code> is true).

```csharp
protected override void PerformExit(bool immediately)
```

#### Parameters

`immediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If true, exits the game immediately.  If false (default), schedules the game to exit in the next frame.

#### Remarks

Will never be called if <xref href="osu.Framework.Platform.GameHost.CanExit" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

