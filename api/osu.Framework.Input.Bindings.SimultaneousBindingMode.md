# <a id="osu_Framework_Input_Bindings_SimultaneousBindingMode"></a> Enum SimultaneousBindingMode

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

```csharp
public enum SimultaneousBindingMode
```

#### Extension Methods

[ObjectExtensions.AsNonNull<SimultaneousBindingMode\>\(SimultaneousBindingMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SimultaneousBindingMode\>\(SimultaneousBindingMode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<SimultaneousBindingMode\>\(SimultaneousBindingMode, SimultaneousBindingMode\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SimultaneousBindingMode\>\(SimultaneousBindingMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SimultaneousBindingMode\>\(SimultaneousBindingMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<SimultaneousBindingMode, TChild\>\(SimultaneousBindingMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SimultaneousBindingMode, TChild\>\(SimultaneousBindingMode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SimultaneousBindingMode, TChild\>\(SimultaneousBindingMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SimultaneousBindingMode\>\(SimultaneousBindingMode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`All = 2` 

Unique actions are allowed to be pressed at the same time, as well as multiple times from different bindings. There may therefore be
more than one action in an pressed state at once, as well as multiple consecutive <xref href="osu.Framework.Input.Bindings.IKeyBindingHandler%601.OnPressed(osu.Framework.Input.Events.KeyBindingPressEvent%7b%600%7d)" data-throw-if-not-resolved="false"></xref> events
for a single action (followed by an eventual balancing number of <xref href="osu.Framework.Input.Bindings.IKeyBindingHandler%601.OnReleased(osu.Framework.Input.Events.KeyBindingReleaseEvent%7b%600%7d)" data-throw-if-not-resolved="false"></xref> events).



`None = 0` 

One action can be in a pressed state at once.
If a new matching binding is encountered, any existing binding is first released.



`Unique = 1` 

Unique actions are allowed to be pressed at the same time. There may therefore be more than one action in an actuated state at once.
If one action has multiple bindings, only the first will trigger an <xref href="osu.Framework.Input.Bindings.IKeyBindingHandler%601.OnPressed(osu.Framework.Input.Events.KeyBindingPressEvent%7b%600%7d)" data-throw-if-not-resolved="false"></xref>.
The last binding to be released will trigger an <xref href="osu.Framework.Input.Bindings.IKeyBindingHandler%601.OnReleased(osu.Framework.Input.Events.KeyBindingReleaseEvent%7b%600%7d)" data-throw-if-not-resolved="false"></xref>.



