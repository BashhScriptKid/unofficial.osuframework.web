# <a id="osu_Framework_Configuration_FrameworkDebugConfigManager"></a> Class FrameworkDebugConfigManager

Namespace: [osu.Framework.Configuration](osu.Framework.Configuration.md)  
Assembly: osu.Framework.dll  

```csharp
public class FrameworkDebugConfigManager : IniConfigManager<DebugSetting>, IDisposable, ITrackableConfigManager, IConfigManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConfigManager](osu.Framework.Configuration.ConfigManager.md) ← 
[ConfigManager<DebugSetting\>](osu.Framework.Configuration.ConfigManager\-1.md) ← 
[IniConfigManager<DebugSetting\>](osu.Framework.Configuration.IniConfigManager\-1.md) ← 
[FrameworkDebugConfigManager](osu.Framework.Configuration.FrameworkDebugConfigManager.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[ITrackableConfigManager](osu.Framework.Configuration.Tracking.ITrackableConfigManager.md), 
[IConfigManager](osu.Framework.Configuration.IConfigManager.md)

#### Inherited Members

[IniConfigManager<DebugSetting\>.Filename](osu.Framework.Configuration.IniConfigManager\-1.md\#osu\_Framework\_Configuration\_IniConfigManager\_1\_Filename), 
[IniConfigManager<DebugSetting\>.PerformLoad\(\)](osu.Framework.Configuration.IniConfigManager\-1.md\#osu\_Framework\_Configuration\_IniConfigManager\_1\_PerformLoad), 
[IniConfigManager<DebugSetting\>.PerformSave\(\)](osu.Framework.Configuration.IniConfigManager\-1.md\#osu\_Framework\_Configuration\_IniConfigManager\_1\_PerformSave), 
[ConfigManager<DebugSetting\>.AddMissingEntries](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_AddMissingEntries), 
[ConfigManager<DebugSetting\>.ConfigStore](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_ConfigStore), 
[ConfigManager<DebugSetting\>.GetCurrentConfigurationForLogging\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetCurrentConfigurationForLogging), 
[ConfigManager<DebugSetting\>.CheckLookupContainsPrivateInformation\(DebugSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_CheckLookupContainsPrivateInformation\_\_0\_), 
[ConfigManager<DebugSetting\>.InitialiseDefaults\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_InitialiseDefaults), 
[ConfigManager<DebugSetting\>.SetValue<TValue\>\(DebugSetting, TValue\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetValue\_\_1\_\_0\_\_\_0\_), 
[ConfigManager<DebugSetting\>.SetDefault\(DebugSetting, double, double?, double?, double?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Double\_System\_Nullable\_System\_Double\_\_System\_Nullable\_System\_Double\_\_System\_Nullable\_System\_Double\_\_), 
[ConfigManager<DebugSetting\>.SetDefault\(DebugSetting, float, float?, float?, float?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Single\_System\_Nullable\_System\_Single\_\_System\_Nullable\_System\_Single\_\_System\_Nullable\_System\_Single\_\_), 
[ConfigManager<DebugSetting\>.SetDefault\(DebugSetting, int, int?, int?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Int32\_System\_Nullable\_System\_Int32\_\_System\_Nullable\_System\_Int32\_\_), 
[ConfigManager<DebugSetting\>.SetDefault\(DebugSetting, bool\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Boolean\_), 
[ConfigManager<DebugSetting\>.SetDefault\(DebugSetting, Size, Size?, Size?\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_System\_Drawing\_Size\_System\_Nullable\_System\_Drawing\_Size\_\_System\_Nullable\_System\_Drawing\_Size\_\_), 
[ConfigManager<DebugSetting\>.SetDefault\(DebugSetting, Colour4\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_0\_osu\_Framework\_Graphics\_Colour4\_), 
[ConfigManager<DebugSetting\>.SetDefault<TValue\>\(DebugSetting, TValue\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_SetDefault\_\_1\_\_0\_\_\_0\_), 
[ConfigManager<DebugSetting\>.AddBindable<TBindable\>\(DebugSetting, Bindable<TBindable\>\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_AddBindable\_\_1\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_0\_\_), 
[ConfigManager<DebugSetting\>.Get<TValue\>\(DebugSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_Get\_\_1\_\_0\_), 
[ConfigManager<DebugSetting\>.GetOriginalBindable<TValue\>\(DebugSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetOriginalBindable\_\_1\_\_0\_), 
[ConfigManager<DebugSetting\>.GetBindable<TValue\>\(DebugSetting\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_GetBindable\_\_1\_\_0\_), 
[ConfigManager<DebugSetting\>.BindWith<TValue\>\(DebugSetting, Bindable<TValue\>\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_BindWith\_\_1\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_0\_\_), 
[ConfigManager<DebugSetting\>.CreateTrackedSettings\(\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_CreateTrackedSettings), 
[ConfigManager<DebugSetting\>.LoadInto\(TrackedSettings\)](osu.Framework.Configuration.ConfigManager\-1.md\#osu\_Framework\_Configuration\_ConfigManager\_1\_LoadInto\_osu\_Framework\_Configuration\_Tracking\_TrackedSettings\_), 
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

[ObjectExtensions.AsNonNull<FrameworkDebugConfigManager\>\(FrameworkDebugConfigManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FrameworkDebugConfigManager\>\(FrameworkDebugConfigManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FrameworkDebugConfigManager\>\(FrameworkDebugConfigManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FrameworkDebugConfigManager\>\(FrameworkDebugConfigManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FrameworkDebugConfigManager, TChild\>\(FrameworkDebugConfigManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FrameworkDebugConfigManager, TChild\>\(FrameworkDebugConfigManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FrameworkDebugConfigManager, TChild\>\(FrameworkDebugConfigManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FrameworkDebugConfigManager\>\(FrameworkDebugConfigManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_FrameworkDebugConfigManager__ctor"></a> FrameworkDebugConfigManager\(\)

```csharp
public FrameworkDebugConfigManager()
```

## Properties

### <a id="osu_Framework_Configuration_FrameworkDebugConfigManager_Filename"></a> Filename

The backing file used to store the config. Null means no persistent storage.

```csharp
protected override string Filename { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Configuration_FrameworkDebugConfigManager_InitialiseDefaults"></a> InitialiseDefaults\(\)

Set all required default values via Set() calls.
Note that defaults set here may be overridden by <xref href="osu.Framework.Configuration.ConfigManager%601.defaultOverrides" data-throw-if-not-resolved="false"></xref> provided in the constructor.

```csharp
protected override void InitialiseDefaults()
```

