# <a id="osu_Framework_Graphics_Performance_LifetimeEntryState"></a> Enum LifetimeEntryState

Namespace: [osu.Framework.Graphics.Performance](osu.Framework.Graphics.Performance.md)  
Assembly: osu.Framework.dll  

The state of a <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref>.

```csharp
public enum LifetimeEntryState
```

#### Extension Methods

[ObjectExtensions.AsNonNull<LifetimeEntryState\>\(LifetimeEntryState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LifetimeEntryState\>\(LifetimeEntryState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<LifetimeEntryState\>\(LifetimeEntryState, LifetimeEntryState\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LifetimeEntryState\>\(LifetimeEntryState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LifetimeEntryState\>\(LifetimeEntryState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<LifetimeEntryState, TChild\>\(LifetimeEntryState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LifetimeEntryState, TChild\>\(LifetimeEntryState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LifetimeEntryState, TChild\>\(LifetimeEntryState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LifetimeEntryState\>\(LifetimeEntryState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Current = 2` 

The <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> is currently alive.



`Future = 1` 

The <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> is currently dead and becomes alive when current time &gt;= <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeStart" data-throw-if-not-resolved="false"></xref>.



`New = 0` 

The <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> hasn't been processed within the <xref href="osu.Framework.Graphics.Performance.LifetimeEntryManager" data-throw-if-not-resolved="false"></xref> yet.



`Past = 3` 

The <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> is currently dead and becomes alive when current time &lt; <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeEnd" data-throw-if-not-resolved="false"></xref>.



