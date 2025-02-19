# <a id="osu_Framework_Configuration_Tracking_ITrackedSetting"></a> Interface ITrackedSetting

Namespace: [osu.Framework.Configuration.Tracking](osu.Framework.Configuration.Tracking.md)  
Assembly: osu.Framework.dll  

A singular tracked setting.

```csharp
public interface ITrackedSetting
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ITrackedSetting\>\(ITrackedSetting?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITrackedSetting\>\(ITrackedSetting\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITrackedSetting\>\(ITrackedSetting\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITrackedSetting\>\(ITrackedSetting\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITrackedSetting, TChild\>\(ITrackedSetting, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITrackedSetting, TChild\>\(ITrackedSetting, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITrackedSetting, TChild\>\(ITrackedSetting, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITrackedSetting\>\(ITrackedSetting\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Configuration_Tracking_ITrackedSetting_LoadFrom__1_osu_Framework_Configuration_ConfigManager___0__"></a> LoadFrom<TLookup\>\(ConfigManager<TLookup\>\)

Loads a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> into this tracked setting, binding to <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting.SettingChanged" data-throw-if-not-resolved="false"></xref>.

```csharp
void LoadFrom<TLookup>(ConfigManager<TLookup> configManager) where TLookup : struct, Enum
```

#### Parameters

`configManager` [ConfigManager](osu.Framework.Configuration.ConfigManager\-1.md)<TLookup\>

The <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref> to load from.

#### Type Parameters

`TLookup` 

### <a id="osu_Framework_Configuration_Tracking_ITrackedSetting_Unload"></a> Unload\(\)

Unloads the <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> from this tracked setting, unbinding from <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting.SettingChanged" data-throw-if-not-resolved="false"></xref>.

```csharp
void Unload()
```

### <a id="osu_Framework_Configuration_Tracking_ITrackedSetting_SettingChanged"></a> SettingChanged

Invoked when this setting has changed.

```csharp
event Action<SettingDescription> SettingChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[SettingDescription](osu.Framework.Configuration.Tracking.SettingDescription.md)\>

