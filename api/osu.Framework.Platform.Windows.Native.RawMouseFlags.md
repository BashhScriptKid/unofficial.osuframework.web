# <a id="osu_Framework_Platform_Windows_Native_RawMouseFlags"></a> Enum RawMouseFlags

Namespace: [osu.Framework.Platform.Windows.Native](osu.Framework.Platform.Windows.Native.md)  
Assembly: osu.Framework.dll  

Enumeration containing the flags for raw mouse data.

```csharp
[Flags]
public enum RawMouseFlags : ushort
```

#### Extension Methods

[ObjectExtensions.AsNonNull<RawMouseFlags\>\(RawMouseFlags\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RawMouseFlags\>\(RawMouseFlags\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<RawMouseFlags\>\(RawMouseFlags, RawMouseFlags\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RawMouseFlags\>\(RawMouseFlags\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RawMouseFlags\>\(RawMouseFlags\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<RawMouseFlags, TChild\>\(RawMouseFlags, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RawMouseFlags, TChild\>\(RawMouseFlags, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RawMouseFlags, TChild\>\(RawMouseFlags, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RawMouseFlags\>\(RawMouseFlags\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`AttributesChanged = 4` 

Attributes for the mouse have changed.



`MoveAbsolute = 1` 

Absolute positioning.



`MoveNoCoalesce = 8` 

WM_MOUSEMOVE and WM_INPUT don't coalesce



`MoveRelative = 0` 

Relative to the last position.



`VirtualDesktop = 2` 

Coordinate data is mapped to a virtual desktop.



