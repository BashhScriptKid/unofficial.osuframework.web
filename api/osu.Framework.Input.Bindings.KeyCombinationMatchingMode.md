# <a id="osu_Framework_Input_Bindings_KeyCombinationMatchingMode"></a> Enum KeyCombinationMatchingMode

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

```csharp
public enum KeyCombinationMatchingMode
```

#### Extension Methods

[ObjectExtensions.AsNonNull<KeyCombinationMatchingMode\>\(KeyCombinationMatchingMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<KeyCombinationMatchingMode\>\(KeyCombinationMatchingMode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<KeyCombinationMatchingMode\>\(KeyCombinationMatchingMode, KeyCombinationMatchingMode\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<KeyCombinationMatchingMode\>\(KeyCombinationMatchingMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<KeyCombinationMatchingMode\>\(KeyCombinationMatchingMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<KeyCombinationMatchingMode, TChild\>\(KeyCombinationMatchingMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<KeyCombinationMatchingMode, TChild\>\(KeyCombinationMatchingMode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<KeyCombinationMatchingMode, TChild\>\(KeyCombinationMatchingMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<KeyCombinationMatchingMode\>\(KeyCombinationMatchingMode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Any = 0` 

Matches a <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> regardless of any additional key presses.



`Exact = 1` 

Matches a <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> if there are no additional key presses.



`Modifiers = 2` 

Matches a <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> regardless of any additional key presses, however key modifiers must match exactly.



