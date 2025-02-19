# <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore"></a> Class LocalisationTestScene.TestLocalisationStore

Namespace: [osu.Framework.Tests.Visual.Localisation](osu.Framework.Tests.Visual.Localisation.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
protected class LocalisationTestScene.TestLocalisationStore : ILocalisationStore, IResourceStore<string>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisationTestScene.TestLocalisationStore](osu.Framework.Tests.Visual.Localisation.LocalisationTestScene.TestLocalisationStore.md)

#### Implements

[ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md), 
[IResourceStore<string\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
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

[ObjectExtensions.AsNonNull<LocalisationTestScene.TestLocalisationStore\>\(LocalisationTestScene.TestLocalisationStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisationTestScene.TestLocalisationStore\>\(LocalisationTestScene.TestLocalisationStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisationTestScene.TestLocalisationStore\>\(LocalisationTestScene.TestLocalisationStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisationTestScene.TestLocalisationStore\>\(LocalisationTestScene.TestLocalisationStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LocalisationTestScene.TestLocalisationStore, TChild\>\(LocalisationTestScene.TestLocalisationStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisationTestScene.TestLocalisationStore, TChild\>\(LocalisationTestScene.TestLocalisationStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisationTestScene.TestLocalisationStore, TChild\>\(LocalisationTestScene.TestLocalisationStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisationTestScene.TestLocalisationStore\>\(LocalisationTestScene.TestLocalisationStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore__ctor_System_Globalization_CultureInfo_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__"></a> TestLocalisationStore\(CultureInfo, IReadOnlyDictionary<string, string\>\)

```csharp
public TestLocalisationStore(CultureInfo culture, IReadOnlyDictionary<string, string> translations)
```

#### Parameters

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

`translations` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore__ctor_System_String_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__"></a> TestLocalisationStore\(string, IReadOnlyDictionary<string, string\>\)

```csharp
public TestLocalisationStore(string locale, IReadOnlyDictionary<string, string> translations)
```

#### Parameters

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`translations` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore__ctor_System_Globalization_CultureInfo_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__"></a> TestLocalisationStore\(CultureInfo, IReadOnlyDictionary<string, string\>\)

```csharp
public TestLocalisationStore(CultureInfo culture, IReadOnlyDictionary<string, string> translations)
```

#### Parameters

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

`translations` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore__ctor_System_String_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__"></a> TestLocalisationStore\(string, IReadOnlyDictionary<string, string\>\)

```csharp
public TestLocalisationStore(string locale, IReadOnlyDictionary<string, string> translations)
```

#### Parameters

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`translations` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore__ctor_System_Globalization_CultureInfo_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__"></a> TestLocalisationStore\(CultureInfo, IReadOnlyDictionary<string, string\>\)

```csharp
public TestLocalisationStore(CultureInfo culture, IReadOnlyDictionary<string, string> translations)
```

#### Parameters

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

`translations` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore__ctor_System_String_System_Collections_Generic_IReadOnlyDictionary_System_String_System_String__"></a> TestLocalisationStore\(string, IReadOnlyDictionary<string, string\>\)

```csharp
public TestLocalisationStore(string locale, IReadOnlyDictionary<string, string> translations)
```

#### Parameters

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`translations` [IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Properties

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_EffectiveCulture"></a> EffectiveCulture

The <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> corresponding to the content of this <xref href="osu.Framework.Localisation.ILocalisationStore" data-throw-if-not-resolved="false"></xref>
and can be used for formatting numbers etc.

```csharp
public CultureInfo EffectiveCulture { get; }
```

#### Property Value

 [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_EffectiveCulture"></a> EffectiveCulture

The <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> corresponding to the content of this <xref href="osu.Framework.Localisation.ILocalisationStore" data-throw-if-not-resolved="false"></xref>
and can be used for formatting numbers etc.

```csharp
public CultureInfo EffectiveCulture { get; }
```

#### Property Value

 [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_EffectiveCulture"></a> EffectiveCulture

The <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> corresponding to the content of this <xref href="osu.Framework.Localisation.ILocalisationStore" data-throw-if-not-resolved="false"></xref>
and can be used for formatting numbers etc.

```csharp
public CultureInfo EffectiveCulture { get; }
```

#### Property Value

 [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

## Methods

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
public string? Get(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

The object.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
public string? Get(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

The object.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
public string? Get(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

The object.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public Task<string?> GetAsync(string key, CancellationToken cancellationToken = default)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)?\>

The object.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public Task<string?> GetAsync(string key, CancellationToken cancellationToken = default)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)?\>

The object.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public Task<string?> GetAsync(string key, CancellationToken cancellationToken = default)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)?\>

The object.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_Tests_Visual_Localisation_LocalisationTestScene_TestLocalisationStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

