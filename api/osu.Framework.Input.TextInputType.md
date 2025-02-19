# <a id="osu_Framework_Input_TextInputType"></a> Enum TextInputType

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public enum TextInputType
```

#### Extension Methods

[ObjectExtensions.AsNonNull<TextInputType\>\(TextInputType\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextInputType\>\(TextInputType\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<TextInputType\>\(TextInputType, TextInputType\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextInputType\>\(TextInputType\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextInputType\>\(TextInputType\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TextInputTypeExtensions.IsPassword\(TextInputType\)](osu.Framework.Input.TextInputTypeExtensions.md\#osu\_Framework\_Input\_TextInputTypeExtensions\_IsPassword\_osu\_Framework\_Input\_TextInputType\_), 
[TextInputTypeExtensions.SupportsIme\(TextInputType\)](osu.Framework.Input.TextInputTypeExtensions.md\#osu\_Framework\_Input\_TextInputTypeExtensions\_SupportsIme\_osu\_Framework\_Input\_TextInputType\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[SDL3Extensions.ToSDLTextInputType\(TextInputType\)](osu.Framework.Platform.SDL3.SDL3Extensions.md\#osu\_Framework\_Platform\_SDL3\_SDL3Extensions\_ToSDLTextInputType\_osu\_Framework\_Input\_TextInputType\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<TextInputType, TChild\>\(TextInputType, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextInputType, TChild\>\(TextInputType, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextInputType, TChild\>\(TextInputType, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextInputType\>\(TextInputType\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Code = 2` 

The text input is an alphanumeric code which can be visible to the user.



`Decimal = 4` 

The text input is numerical with decimal point.



`EmailAddress = 5` 

The text input is an email address.



`Name = 1` 

The text input is a person's name.



`Number = 3` 

The text input is a whole number.



`NumericalPassword = 8` 

The text input is a numerical password hidden from the user.



`Password = 7` 

The text input is a password hidden from the user. This may hint the operating system to provide a shortcut to a credentials manager for autofill.



`Text = 0` 

Plain text, default type of text input.



`Username = 6` 

The text input is a username. This may hint the operating system to provide a shortcut to a credentials manager for autofill.



