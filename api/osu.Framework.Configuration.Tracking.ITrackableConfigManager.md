# <a id="osu_Framework_Configuration_Tracking_ITrackableConfigManager"></a> Interface ITrackableConfigManager

Namespace: [osu.Framework.Configuration.Tracking](osu.Framework.Configuration.Tracking.md)  
Assembly: osu.Framework.dll  

An <xref href="osu.Framework.Configuration.IConfigManager" data-throw-if-not-resolved="false"></xref> that provides a way to track its config settings.

```csharp
public interface ITrackableConfigManager : IConfigManager
```

#### Implements

[IConfigManager](osu.Framework.Configuration.IConfigManager.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ITrackableConfigManager\>\(ITrackableConfigManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITrackableConfigManager\>\(ITrackableConfigManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITrackableConfigManager\>\(ITrackableConfigManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITrackableConfigManager\>\(ITrackableConfigManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITrackableConfigManager, TChild\>\(ITrackableConfigManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITrackableConfigManager, TChild\>\(ITrackableConfigManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITrackableConfigManager, TChild\>\(ITrackableConfigManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITrackableConfigManager\>\(ITrackableConfigManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Configuration_Tracking_ITrackableConfigManager_CreateTrackedSettings"></a> CreateTrackedSettings\(\)

Retrieves all the settings of this <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref> that are to be tracked for changes.

```csharp
TrackedSettings? CreateTrackedSettings()
```

#### Returns

 [TrackedSettings](osu.Framework.Configuration.Tracking.TrackedSettings.md)?

A list of <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Configuration_Tracking_ITrackableConfigManager_LoadInto_osu_Framework_Configuration_Tracking_TrackedSettings_"></a> LoadInto\(TrackedSettings\)

Loads <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref>s into <xref href="osu.Framework.Configuration.Tracking.TrackedSettings" data-throw-if-not-resolved="false"></xref>.

```csharp
void LoadInto(TrackedSettings settings)
```

#### Parameters

`settings` [TrackedSettings](osu.Framework.Configuration.Tracking.TrackedSettings.md)

The settings to load into.

