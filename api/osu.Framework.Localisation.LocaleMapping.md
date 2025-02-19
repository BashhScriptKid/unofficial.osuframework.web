# <a id="osu_Framework_Localisation_LocaleMapping"></a> Class LocaleMapping

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

Maps a localisation store to a lookup string.
Used by <xref href="osu.Framework.Localisation.LocalisationManager" data-throw-if-not-resolved="false"></xref>.

```csharp
public class LocaleMapping
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocaleMapping](osu.Framework.Localisation.LocaleMapping.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LocaleMapping\>\(LocaleMapping?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocaleMapping\>\(LocaleMapping\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocaleMapping\>\(LocaleMapping\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocaleMapping\>\(LocaleMapping\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LocaleMapping, TChild\>\(LocaleMapping, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocaleMapping, TChild\>\(LocaleMapping, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocaleMapping, TChild\>\(LocaleMapping, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocaleMapping\>\(LocaleMapping\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_LocaleMapping__ctor_osu_Framework_Localisation_ILocalisationStore_"></a> LocaleMapping\(ILocalisationStore\)

Create a locale mapping from a localisation store.

```csharp
public LocaleMapping(ILocalisationStore store)
```

#### Parameters

`store` [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)

The store to be used.

### <a id="osu_Framework_Localisation_LocaleMapping__ctor_System_String_osu_Framework_Localisation_ILocalisationStore_"></a> LocaleMapping\(string, ILocalisationStore\)

Create a locale mapping with a custom lookup name.

```csharp
public LocaleMapping(string name, ILocalisationStore store)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`store` [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)

The store to be used.

## Fields

### <a id="osu_Framework_Localisation_LocaleMapping_Name"></a> Name

```csharp
public readonly string Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_LocaleMapping_Storage"></a> Storage

```csharp
public readonly ILocalisationStore Storage
```

#### Field Value

 [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)

