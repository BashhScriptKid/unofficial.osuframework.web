# <a id="osu_Framework_Graphics_LoadState"></a> Enum LoadState

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Possible states of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> within the loading pipeline.

```csharp
public enum LoadState
```

#### Extension Methods

[ObjectExtensions.AsNonNull<LoadState\>\(LoadState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LoadState\>\(LoadState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<LoadState\>\(LoadState, LoadState\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LoadState\>\(LoadState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LoadState\>\(LoadState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<LoadState, TChild\>\(LoadState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LoadState, TChild\>\(LoadState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LoadState, TChild\>\(LoadState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LoadState\>\(LoadState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Loaded = 3` 

Loading is fully completed and the Drawable is now part of the scene graph.



`Loading = 1` 

Currently loading (possibly and usually on a background thread via <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.LoadComponentAsync%60%601(%60%600%2cSystem.Action%7b%60%600%7d%2cSystem.Threading.CancellationToken%2cosu.Framework.Threading.Scheduler)" data-throw-if-not-resolved="false"></xref>).



`NotLoaded = 0` 

Not loaded, and no load has been initiated yet.



`Ready = 2` 

Loading is complete, but has not yet been finalized on the update thread
(<xref href="osu.Framework.Graphics.Drawable.LoadComplete" data-throw-if-not-resolved="false"></xref> has not been called yet, which
always runs on the update thread and requires <xref href="osu.Framework.Graphics.Drawable.IsAlive" data-throw-if-not-resolved="false"></xref>).



