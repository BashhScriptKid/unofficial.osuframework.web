# <a id="osu_Framework_Configuration_FrameworkConfigManager"></a> Class FrameworkConfigManager

Namespace: [osu.Framework.Configuration](osu.Framework.Configuration.md)  
Assembly: osu.Framework.dll  

```csharp
public class FrameworkConfigManager : IniConfigManager<FrameworkSetting>, IDisposable, ITrackableConfigManager, IConfigManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConfigManager](osu.Framework.Configuration.ConfigManager.md) ← 
[ConfigManager<FrameworkSetting\>](osu.Framework.Configuration.ConfigManager\-1.md) ← 
[IniConfigManager<FrameworkSetting\>](osu.Framework.Configuration.IniConfigManager\-1.md) ← 
[FrameworkConfigManager](osu.Framework.Configuration.FrameworkConfigManager.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[ITrackableConfigManager](osu.Framework.Configuration.Tracking.ITrackableConfigManager.md), 
[IConfigManager](osu.Framework.Configuration.IConfigManager.md)

#### Inherited Members

[IniConfigManager<FrameworkSetting\>.Filename](osu.Framework.Configuration.IniConfigManager\-1.md\#osu\_Framework\_Configuration\_IniConfigManager\_1\_Filename), 
[IniConfigManager<FrameworkSetting\>.PerformLoad\(\)](osu.Framework.Configuration.IniConfigManager\-1.md\#osu\_Framework\_Configuration\_IniConfigManager\_1\_PerformLoad), 
[IniConfigManager<FrameworkSetting\>.PerformSave\(\)](osu.Framework.Configuration.IniConfigManager\-1.md\#osu\_Framework\_Configuration\_IniConfigManager\_1\_PerformSave), 
[ConfigManager<FrameworkSetting\>.AddMissingEntries](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_AddMissingEntries), 
[ConfigManager<FrameworkSetting\>.ConfigStore](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_ConfigStore), 
[ConfigManager<FrameworkSetting\>.GetCurrentConfigurationForLogging\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetCurrentConfigurationForLogging), 
[ConfigManager<FrameworkSetting\>.CheckLookupContainsPrivateInformation\(FrameworkSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_CheckLookupContainsPrivateInformation\_\_0\_), 
[ConfigManager<FrameworkSetting\>.InitialiseDefaults\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_InitialiseDefaults), 
[ConfigManager<FrameworkSetting\>.SetValue<TValue\>\(FrameworkSetting, TValue\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetValue\_\_1\_\_0\_\_\_0\_), 
[ConfigManager<FrameworkSetting\>.SetDefault\(FrameworkSetting, double, double?, double?, double?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Double\_System\_Nullable\_System\_Double\_\_System\_Nullable\_System\_Double\_\_System\_Nullable\_System\_Double\_\_), 
[ConfigManager<FrameworkSetting\>.SetDefault\(FrameworkSetting, float, float?, float?, float?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Single\_System\_Nullable\_System\_Single\_\_System\_Nullable\_System\_Single\_\_System\_Nullable\_System\_Single\_\_), 
[ConfigManager<FrameworkSetting\>.SetDefault\(FrameworkSetting, int, int?, int?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Int32\_System\_Nullable\_System\_Int32\_\_System\_Nullable\_System\_Int32\_\_), 
[ConfigManager<FrameworkSetting\>.SetDefault\(FrameworkSetting, bool\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Boolean\_), 
[ConfigManager<FrameworkSetting\>.SetDefault\(FrameworkSetting, Size, Size?, Size?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Drawing\_Size\_System\_Nullable\_System\_Drawing\_Size\_\_System\_Nullable\_System\_Drawing\_Size\_\_), 
[ConfigManager<FrameworkSetting\>.SetDefault\(FrameworkSetting, Colour4\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_osu\_Framework\_Graphics\_Colour4\_), 
[ConfigManager<FrameworkSetting\>.SetDefault<TValue\>\(FrameworkSetting, TValue\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_1\_\_0\_\_\_0\_), 
[ConfigManager<FrameworkSetting\>.AddBindable<TBindable\>\(FrameworkSetting, Bindable<TBindable\>\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_AddBindable\_\_1\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_0\_\_), 
[ConfigManager<FrameworkSetting\>.Get<TValue\>\(FrameworkSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_Get\_\_1\_\_0\_), 
[ConfigManager<FrameworkSetting\>.GetOriginalBindable<TValue\>\(FrameworkSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetOriginalBindable\_\_1\_\_0\_), 
[ConfigManager<FrameworkSetting\>.GetBindable<TValue\>\(FrameworkSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetBindable\_\_1\_\_0\_), 
[ConfigManager<FrameworkSetting\>.BindWith<TValue\>\(FrameworkSetting, Bindable<TValue\>\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_BindWith\_\_1\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_0\_\_), 
[ConfigManager<FrameworkSetting\>.CreateTrackedSettings\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_CreateTrackedSettings), 
[ConfigManager<FrameworkSetting\>.LoadInto\(TrackedSettings\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_LoadInto\_osu\_Framework\_Configuration\_Tracking\_TrackedSettings\_), 
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

[ObjectExtensions.AsNonNull<FrameworkConfigManager\>\(FrameworkConfigManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FrameworkConfigManager\>\(FrameworkConfigManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FrameworkConfigManager\>\(FrameworkConfigManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FrameworkConfigManager\>\(FrameworkConfigManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FrameworkConfigManager, TChild\>\(FrameworkConfigManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FrameworkConfigManager, TChild\>\(FrameworkConfigManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FrameworkConfigManager, TChild\>\(FrameworkConfigManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FrameworkConfigManager\>\(FrameworkConfigManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_FrameworkConfigManager__ctor_osu_Framework_Platform_Storage_System_Collections_Generic_IDictionary_osu_Framework_Configuration_FrameworkSetting_System_Object__"></a> FrameworkConfigManager\(Storage, IDictionary<FrameworkSetting, object\>\)

```csharp
public FrameworkConfigManager(Storage storage, IDictionary<FrameworkSetting, object> defaultOverrides = null)
```

#### Parameters

`storage` [Storage](osu.Framework.Platform.Storage.md)

`defaultOverrides` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<[FrameworkSetting](osu.Framework.Configuration.FrameworkSetting.md), [object](https://learn.microsoft.com/dotnet/api/system.object)\>

## Properties

### <a id="osu_Framework_Configuration_FrameworkConfigManager_Filename"></a> Filename

The backing file used to store the config. Null means no persistent storage.

```csharp
protected override string Filename { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Configuration_FrameworkConfigManager_CreateTrackedSettings"></a> CreateTrackedSettings\(\)

Retrieves all the settings of this <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref> that are to be tracked for changes.

```csharp
public override TrackedSettings CreateTrackedSettings()
```

#### Returns

 [TrackedSettings](osu.Framework.Configuration.Tracking.TrackedSettings.md)

A list of <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Configuration_FrameworkConfigManager_InitialiseDefaults"></a> InitialiseDefaults\(\)

Set all required default values via Set() calls.
Note that defaults set here may be overridden by <xref href="osu.Framework.Configuration.ConfigManager%601.defaultOverrides" data-throw-if-not-resolved="false"></xref> provided in the constructor.

```csharp
protected override void InitialiseDefaults()
```

