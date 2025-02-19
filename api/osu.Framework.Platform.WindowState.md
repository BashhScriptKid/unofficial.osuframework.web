# <a id="osu_Framework_Platform_WindowState"></a> Enum WindowState

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Enumerates the available window states in the operating system.

```csharp
public enum WindowState
```

#### Extension Methods

[ObjectExtensions.AsNonNull<WindowState\>\(WindowState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<WindowState\>\(WindowState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<WindowState\>\(WindowState, WindowState\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<WindowState\>\(WindowState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<WindowState\>\(WindowState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[SDL3Extensions.ToFlags\(WindowState\)](osu.Framework.Platform.SDL3.SDL3Extensions.md\#osu\_Framework\_Platform\_SDL3\_SDL3Extensions\_ToFlags\_osu\_Framework\_Platform\_WindowState\_), 
[SDL2Extensions.ToFlags\(WindowState\)](osu.Framework.Platform.SDL2.SDL2Extensions.md\#osu\_Framework\_Platform\_SDL2\_SDL2Extensions\_ToFlags\_osu\_Framework\_Platform\_WindowState\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<WindowState, TChild\>\(WindowState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<WindowState, TChild\>\(WindowState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<WindowState, TChild\>\(WindowState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<WindowState\>\(WindowState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Fullscreen = 1` 

The window is running in exclusive fullscreen and is potentially using a
different resolution to the desktop.



`FullscreenBorderless = 2` 

The window is running in non-exclusive fullscreen, where it expands to fill the screen
at the native desktop resolution.



`Maximised = 3` 

The window is running in maximised mode, usually triggered by clicking the operating
system's maximise button.



`Minimised = 4` 

The window is running in minimised mode, usually triggered by clicking the operating
system's minimise button.



`Normal = 0` 

The window is movable and takes up a subsection of the screen.
This is the default state.



