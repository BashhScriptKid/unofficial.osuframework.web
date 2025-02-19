# <a id="osu_Framework_Platform"></a> Namespace osu.Framework.Platform

### Namespaces

 [osu.Framework.Platform.Linux](osu.Framework.Platform.Linux.md)

 [osu.Framework.Platform.MacOS](osu.Framework.Platform.MacOS.md)

 [osu.Framework.Platform.SDL2](osu.Framework.Platform.SDL2.md)

 [osu.Framework.Platform.SDL3](osu.Framework.Platform.SDL3.md)

 [osu.Framework.Platform.Windows](osu.Framework.Platform.Windows.md)

### Classes

 [Clipboard](osu.Framework.Platform.Clipboard.md)

This class allows placing and retrieving data from the clipboard

 [DesktopGameHost](osu.Framework.Platform.DesktopGameHost.md)

 [DesktopStorage](osu.Framework.Platform.DesktopStorage.md)

 [Display](osu.Framework.Platform.Display.md)

Represents a physical display device on the current system.

 [FlushingStream](osu.Framework.Platform.FlushingStream.md)

A <xref href="System.IO.FileStream" data-throw-if-not-resolved="false"></xref> which always flushes to disk on disposal.

 [GameHost](osu.Framework.Platform.GameHost.md)

 [HeadlessClipboard](osu.Framework.Platform.HeadlessClipboard.md)

Virtual clipboard for use in headless execution.

 [HeadlessGameHost](osu.Framework.Platform.HeadlessGameHost.md)

A GameHost which doesn't require a graphical or sound device.

 [IpcChannel<T\>](osu.Framework.Platform.IpcChannel\-1.md)

Define an IPC channel which supports sending a specific well-defined type.

 [IpcChannel<T, TResponse\>](osu.Framework.Platform.IpcChannel\-2.md)

Define an IPC channel which supports sending and receiving a specific well-defined type.

 [IpcMessage](osu.Framework.Platform.IpcMessage.md)

 [MonoPInvokeCallbackAttribute](osu.Framework.Platform.MonoPInvokeCallbackAttribute.md)

 [NamedPipeIpcProvider](osu.Framework.Platform.NamedPipeIpcProvider.md)

An inter-process communication provider that runs over a specified named pipe.
This single class handles both binding as a server, or messaging another bound instance that is acting as a server.

 [NativeMemoryTracker.NativeMemoryLease](osu.Framework.Platform.NativeMemoryTracker.NativeMemoryLease.md)

A leased on a native memory allocation. Should be disposed when the associated memory is freed.

 [NativeMemoryTracker](osu.Framework.Platform.NativeMemoryTracker.md)

Track native memory allocations via <xref href="osu.Framework.Statistics.GlobalStatistics" data-throw-if-not-resolved="false"></xref>.
Also adds memory pressure automatically.

 [NativeStorage](osu.Framework.Platform.NativeStorage.md)

 [SDLGameHost](osu.Framework.Platform.SDLGameHost.md)

 [Storage](osu.Framework.Platform.Storage.md)

 [TcpIpcProvider](osu.Framework.Platform.TcpIpcProvider.md)

An inter-process communication provider that runs over a specified TCP port, binding to the loopback address.
This single class handles both binding as a server, or messaging another bound instance that is acting as a server.

 [ThreadRunner](osu.Framework.Platform.ThreadRunner.md)

Runs a game host in a specific threading mode.

### Structs

 [DisplayMode](osu.Framework.Platform.DisplayMode.md)

Represents a display mode on a given <xref href="osu.Framework.Platform.Display" data-throw-if-not-resolved="false"></xref>.

### Interfaces

 [IAndroidGraphicsSurface](osu.Framework.Platform.IAndroidGraphicsSurface.md)

 [IGraphicsSurface](osu.Framework.Platform.IGraphicsSurface.md)

Represents the graphics API surface provided by an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

 [IIpcHost](osu.Framework.Platform.IIpcHost.md)

 [ILinuxGraphicsSurface](osu.Framework.Platform.ILinuxGraphicsSurface.md)

 [IMetalGraphicsSurface](osu.Framework.Platform.IMetalGraphicsSurface.md)

Represents Metal-specific graphics API provided by an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

 [IOpenGLGraphicsSurface](osu.Framework.Platform.IOpenGLGraphicsSurface.md)

Represents OpenGL-specific graphics API provided by an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

 [ISystemFileSelector](osu.Framework.Platform.ISystemFileSelector.md)

 [IWindow](osu.Framework.Platform.IWindow.md)

Interface representation of the game window, intended to hide any implementation-specific code.

### Enums

 [CursorState](osu.Framework.Platform.CursorState.md)

Describes our supported states of the OS cursor.

 [ExecutionMode](osu.Framework.Platform.ExecutionMode.md)

 [ExecutionState](osu.Framework.Platform.ExecutionState.md)

The game's execution states. All of these states can only be present once per <xref href="osu.Framework.Platform.GameHost" data-throw-if-not-resolved="false"></xref>.
Note: The order of values in this enum matters.

 [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

The graphics surface of an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

 [WindowState](osu.Framework.Platform.WindowState.md)

Enumerates the available window states in the operating system.

### Delegates

 [TextEditingDelegate](osu.Framework.Platform.TextEditingDelegate.md)

Fired when text is edited, usually via IME composition.

