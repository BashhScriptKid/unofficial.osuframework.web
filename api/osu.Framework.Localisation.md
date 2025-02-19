# <a id="osu_Framework_Localisation"></a> Namespace osu.Framework.Localisation

### Classes

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A string which can apply case transformations to underlying localisable string.

 [CultureInfoHelper](osu.Framework.Localisation.CultureInfoHelper.md)

 [LocaleMapping](osu.Framework.Localisation.LocaleMapping.md)

Maps a localisation store to a lookup string.
Used by <xref href="osu.Framework.Localisation.LocalisationManager" data-throw-if-not-resolved="false"></xref>.

 [LocalisableDescriptionAttribute](osu.Framework.Localisation.LocalisableDescriptionAttribute.md)

Specifies a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref>-based description for the target element.
The description can be retrieved through <xref href="osu.Framework.Extensions.ExtensionMethods.GetLocalisableDescription%60%601(%60%600)" data-throw-if-not-resolved="false"></xref>.

 [LocalisableFormattableString](osu.Framework.Localisation.LocalisableFormattableString.md)

A localisable string with formatting support.

 [LocalisableStringEqualityComparer](osu.Framework.Localisation.LocalisableStringEqualityComparer.md)

An equality comparer for the <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> type.

 [LocalisationManager](osu.Framework.Localisation.LocalisationManager.md)

 [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

A set of parameters that control the way strings are localised.

 [RomanisableString](osu.Framework.Localisation.RomanisableString.md)

A string that has a romanised fallback to allow a better experience for users that potentially can't read the original script.
See <xref href="osu.Framework.Configuration.FrameworkSetting.ShowUnicode" data-throw-if-not-resolved="false"></xref>, which can toggle the display of romanised variants.

 [TranslatableString](osu.Framework.Localisation.TranslatableString.md)

A string which can be translated using a key lookup.

### Structs

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

A descriptor representing text that can be localised and formatted.

### Interfaces

 [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)

An interface for <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref>'s data.

 [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)

 [ILocalisedBindableString](osu.Framework.Localisation.ILocalisedBindableString.md)

An <xref href="osu.Framework.Bindables.IBindable%601" data-throw-if-not-resolved="false"></xref> which has its value set depending on the current locale of the <xref href="osu.Framework.Localisation.LocalisationManager" data-throw-if-not-resolved="false"></xref>.

### Enums

 [Casing](osu.Framework.Localisation.Casing.md)

Case applicable to the underlying localisable string of a <xref href="osu.Framework.Localisation.CaseTransformableString" data-throw-if-not-resolved="false"></xref>.

