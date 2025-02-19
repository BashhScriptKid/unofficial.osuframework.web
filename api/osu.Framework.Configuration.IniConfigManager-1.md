# <a id="osu_Framework_Configuration_IniConfigManager_1"></a> Class IniConfigManager<TLookup\>

Namespace: [osu.Framework.Configuration](osu.Framework.Configuration.md)  
Assembly: osu.Framework.dll  

```csharp
public class IniConfigManager<TLookup> : ConfigManager<TLookup>, IDisposable, ITrackableConfigManager, IConfigManager where TLookup : struct, Enum
```

#### Type Parameters

`TLookup` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConfigManager](osu.Framework.Configuration.ConfigManager.md) ← 
[ConfigManager<TLookup\>](osu.Framework.Configuration.ConfigManager\-1.md) ← 
[IniConfigManager<TLookup\>](osu.Framework.Configuration.IniConfigManager\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[ITrackableConfigManager](osu.Framework.Configuration.Tracking.ITrackableConfigManager.md), 
[IConfigManager](osu.Framework.Configuration.IConfigManager.md)

#### Inherited Members

[ConfigManager<TLookup\>.AddMissingEntries](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_AddMissingEntries), 
[ConfigManager<TLookup\>.ConfigStore](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_ConfigStore), 
[ConfigManager<TLookup\>.GetCurrentConfigurationForLogging\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetCurrentConfigurationForLogging), 
[ConfigManager<TLookup\>.CheckLookupContainsPrivateInformation\(TLookup\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_CheckLookupContainsPrivateInformation\_\_0\_), 
[ConfigManager<TLookup\>.InitialiseDefaults\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_InitialiseDefaults), 
[ConfigManager<TLookup\>.SetValue<TValue\>\(TLookup, TValue\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetValue\_\_1\_\_0\_\_\_0\_), 
[ConfigManager<TLookup\>.SetDefault\(TLookup, double, double?, double?, double?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Double\_System\_Nullable\_System\_Double\_\_System\_Nullable\_System\_Double\_\_System\_Nullable\_System\_Double\_\_), 
[ConfigManager<TLookup\>.SetDefault\(TLookup, float, float?, float?, float?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Single\_System\_Nullable\_System\_Single\_\_System\_Nullable\_System\_Single\_\_System\_Nullable\_System\_Single\_\_), 
[ConfigManager<TLookup\>.SetDefault\(TLookup, int, int?, int?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Int32\_System\_Nullable\_System\_Int32\_\_System\_Nullable\_System\_Int32\_\_), 
[ConfigManager<TLookup\>.SetDefault\(TLookup, bool\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Boolean\_), 
[ConfigManager<TLookup\>.SetDefault\(TLookup, Size, Size?, Size?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Drawing\_Size\_System\_Nullable\_System\_Drawing\_Size\_\_System\_Nullable\_System\_Drawing\_Size\_\_), 
[ConfigManager<TLookup\>.SetDefault\(TLookup, Colour4\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_osu\_Framework\_Graphics\_Colour4\_), 
[ConfigManager<TLookup\>.SetDefault<TValue\>\(TLookup, TValue\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_1\_\_0\_\_\_0\_), 
[ConfigManager<TLookup\>.AddBindable<TBindable\>\(TLookup, Bindable<TBindable\>\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_AddBindable\_\_1\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_0\_\_), 
[ConfigManager<TLookup\>.Get<TValue\>\(TLookup\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_Get\_\_1\_\_0\_), 
[ConfigManager<TLookup\>.GetOriginalBindable<TValue\>\(TLookup\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetOriginalBindable\_\_1\_\_0\_), 
[ConfigManager<TLookup\>.GetBindable<TValue\>\(TLookup\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetBindable\_\_1\_\_0\_), 
[ConfigManager<TLookup\>.BindWith<TValue\>\(TLookup, Bindable<TValue\>\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_BindWith\_\_1\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_0\_\_), 
[ConfigManager<TLookup\>.CreateTrackedSettings\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_CreateTrackedSettings), 
[ConfigManager<TLookup\>.LoadInto\(TrackedSettings\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_LoadInto\_osu\_Framework\_Configuration\_Tracking\_TrackedSettings\_), 
[ConfigManager.Load\(\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_Load), 
[ConfigManager.QueueBackgroundSave\(\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_QueueBackgroundSave), 
[ConfigManager.Save\(\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_Save), 
[ConfigManager.PerformLoad\(\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_PerformLoad), 
[ConfigManager.PerformSave\(\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_PerformSave), 
[ConfigManager.Dispose\(bool\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_Dispose\_System\_Boolean\_), 
[ConfigManager.Dispose\(\)](osu.Framework.Configuration.ConfigManager.md\#osu\_Framework\_Configuration\_ConfigManager\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IniConfigManager<TLookup\>\>\(IniConfigManager<TLookup\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IniConfigManager<TLookup\>\>\(IniConfigManager<TLookup\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IniConfigManager<TLookup\>\>\(IniConfigManager<TLookup\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IniConfigManager<TLookup\>\>\(IniConfigManager<TLookup\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IniConfigManager<TLookup\>, TChild\>\(IniConfigManager<TLookup\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IniConfigManager<TLookup\>, TChild\>\(IniConfigManager<TLookup\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IniConfigManager<TLookup\>, TChild\>\(IniConfigManager<TLookup\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IniConfigManager<TLookup\>\>\(IniConfigManager<TLookup\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_IniConfigManager_1__ctor_osu_Framework_Platform_Storage_System_Collections_Generic_IDictionary__0_System_Object__"></a> IniConfigManager\(Storage, IDictionary<TLookup, object\>\)

```csharp
public IniConfigManager(Storage storage, IDictionary<TLookup, object> defaultOverrides = null)
```

#### Parameters

`storage` [Storage](osu.Framework.Platform.Storage.md)

`defaultOverrides` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<TLookup, [object](https://learn.microsoft.com/dotnet/api/system.object)\>

## Properties

### <a id="osu_Framework_Configuration_IniConfigManager_1_Filename"></a> Filename

The backing file used to store the config. Null means no persistent storage.

```csharp
protected virtual string Filename { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Configuration_IniConfigManager_1_PerformLoad"></a> PerformLoad\(\)

```csharp
protected override void PerformLoad()
```

### <a id="osu_Framework_Configuration_IniConfigManager_1_PerformSave"></a> PerformSave\(\)

```csharp
protected override bool PerformSave()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

