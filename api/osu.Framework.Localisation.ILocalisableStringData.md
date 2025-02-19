# <a id="osu_Framework_Localisation_ILocalisableStringData"></a> Interface ILocalisableStringData

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

An interface for <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref>'s data.

```csharp
public interface ILocalisableStringData : IEquatable<ILocalisableStringData>
```

#### Implements

[IEquatable<ILocalisableStringData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Extension Methods

[ObjectExtensions.AsNonNull<ILocalisableStringData\>\(ILocalisableStringData?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ILocalisableStringData\>\(ILocalisableStringData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ILocalisableStringData\>\(ILocalisableStringData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ILocalisableStringData\>\(ILocalisableStringData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLower\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLower\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToSentence\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToSentence\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToTitle\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToTitle\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToUpper\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToUpper\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[ContainerExtensions.WithChild<ILocalisableStringData, TChild\>\(ILocalisableStringData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ILocalisableStringData, TChild\>\(ILocalisableStringData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ILocalisableStringData, TChild\>\(ILocalisableStringData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ILocalisableStringData\>\(ILocalisableStringData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Localisation_ILocalisableStringData_GetLocalised_osu_Framework_Localisation_LocalisationParameters_"></a> GetLocalised\(LocalisationParameters\)

Gets a localised <xref href="System.String" data-throw-if-not-resolved="false"></xref> using the given localisation store and other required data.

```csharp
string GetLocalised(LocalisationParameters parameters)
```

#### Parameters

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

Any parameters that control the localisation method.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

