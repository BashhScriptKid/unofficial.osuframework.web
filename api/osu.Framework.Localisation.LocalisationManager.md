# <a id="osu_Framework_Localisation_LocalisationManager"></a> Class LocalisationManager

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

```csharp
public class LocalisationManager : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisationManager](osu.Framework.Localisation.LocalisationManager.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LocalisationManager\>\(LocalisationManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisationManager\>\(LocalisationManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisationManager\>\(LocalisationManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisationManager\>\(LocalisationManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LocalisationManager, TChild\>\(LocalisationManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisationManager, TChild\>\(LocalisationManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisationManager, TChild\>\(LocalisationManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisationManager\>\(LocalisationManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_LocalisationManager__ctor_osu_Framework_Configuration_FrameworkConfigManager_"></a> LocalisationManager\(FrameworkConfigManager\)

```csharp
public LocalisationManager(FrameworkConfigManager config)
```

#### Parameters

`config` [FrameworkConfigManager](osu.Framework.Configuration.FrameworkConfigManager.md)

## Properties

### <a id="osu_Framework_Localisation_LocalisationManager_CurrentParameters"></a> CurrentParameters

```csharp
public IBindable<LocalisationParameters> CurrentParameters { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)\>

### <a id="osu_Framework_Localisation_LocalisationManager_SystemDefaultLocaleMapping"></a> SystemDefaultLocaleMapping

The <xref href="osu.Framework.Localisation.LocaleMapping" data-throw-if-not-resolved="false"></xref> that most closely matches the <xref href="osu.Framework.Localisation.CultureInfoHelper.SystemUICulture" data-throw-if-not-resolved="false"></xref>, or null iff <xref href="osu.Framework.Localisation.LocalisationManager.locales" data-throw-if-not-resolved="false"></xref> is empty.

```csharp
public LocaleMapping? SystemDefaultLocaleMapping { get; }
```

#### Property Value

 [LocaleMapping](osu.Framework.Localisation.LocaleMapping.md)?

#### Remarks

This property is cached.

## Methods

### <a id="osu_Framework_Localisation_LocalisationManager_AddLanguage_System_String_osu_Framework_Localisation_ILocalisationStore_"></a> AddLanguage\(string, ILocalisationStore\)

Add a single language to this manager.

```csharp
public void AddLanguage(string language, ILocalisationStore storage)
```

#### Parameters

`language` [string](https://learn.microsoft.com/dotnet/api/system.string)

The culture name to be added. Generally should match <xref href="System.Globalization.CultureInfo.Name" data-throw-if-not-resolved="false"></xref>.

`storage` [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)

A storage providing localisations for the specified language.

#### Remarks

Use <xref href="osu.Framework.Localisation.LocalisationManager.AddLocaleMappings(System.Collections.Generic.IEnumerable%7bosu.Framework.Localisation.LocaleMapping%7d)" data-throw-if-not-resolved="false"></xref> as a more efficient way of bootstrapping all available locales.

### <a id="osu_Framework_Localisation_LocalisationManager_AddLocaleMappings_System_Collections_Generic_IEnumerable_osu_Framework_Localisation_LocaleMapping__"></a> AddLocaleMappings\(IEnumerable<LocaleMapping\>\)

Add multiple locale mappings. Should be used to add all available languages at initialisation.

```csharp
public void AddLocaleMappings(IEnumerable<LocaleMapping> mappings)
```

#### Parameters

`mappings` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[LocaleMapping](osu.Framework.Localisation.LocaleMapping.md)\>

All available locale mappings.

### <a id="osu_Framework_Localisation_LocalisationManager_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Localisation_LocalisationManager_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Localisation_LocalisationManager_GetLocalisedBindableString_osu_Framework_Localisation_LocalisableString_"></a> GetLocalisedBindableString\(LocalisableString\)

Creates an <xref href="osu.Framework.Localisation.ILocalisedBindableString" data-throw-if-not-resolved="false"></xref> which automatically updates its text according to information provided in <xref href="osu.Framework.Localisation.ILocalisedBindableString.Text" data-throw-if-not-resolved="false"></xref>.

```csharp
public ILocalisedBindableString GetLocalisedBindableString(LocalisableString original)
```

#### Parameters

`original` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

#### Returns

 [ILocalisedBindableString](osu.Framework.Localisation.ILocalisedBindableString.md)

The <xref href="osu.Framework.Localisation.ILocalisedBindableString" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Localisation_LocalisationManager_GetLocalisedString_osu_Framework_Localisation_LocalisableString_"></a> GetLocalisedString\(LocalisableString\)

Returns the appropriate <xref href="System.String" data-throw-if-not-resolved="false"></xref> value for a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> given the currently valid <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref>.

```csharp
public string GetLocalisedString(LocalisableString text)
```

#### Parameters

`text` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

The returned value is only valid until the next change to <xref href="osu.Framework.Localisation.LocalisationManager.CurrentParameters" data-throw-if-not-resolved="false"></xref>.
To facilitate tracking changes to the localised value across <xref href="osu.Framework.Localisation.LocalisationManager.CurrentParameters" data-throw-if-not-resolved="false"></xref> changes, use <xref href="osu.Framework.Localisation.LocalisationManager.GetLocalisedBindableString(osu.Framework.Localisation.LocalisableString)" data-throw-if-not-resolved="false"></xref>
and subscribe to its <xref href="osu.Framework.Bindables.Bindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> instead.

