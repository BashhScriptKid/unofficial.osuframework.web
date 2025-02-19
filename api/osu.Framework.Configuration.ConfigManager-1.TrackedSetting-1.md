# <a id="osu_Framework_Configuration_ConfigManager_1_TrackedSetting_1"></a> Class ConfigManager<TLookup\>.TrackedSetting<TValue\>

Namespace: [osu.Framework.Configuration](osu.Framework.Configuration.md)  
Assembly: osu.Framework.dll  

```csharp
public class ConfigManager<TLookup>.TrackedSetting<TValue> : TrackedSetting<TValue>, ITrackedSetting
```

#### Type Parameters

`TValue` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TrackedSetting<TValue\>](osu.Framework.Configuration.Tracking.TrackedSetting\-1.md) ← 
[ConfigManager<TLookup\>.TrackedSetting<TValue\>](osu.Framework.Configuration.ConfigManager\-1.TrackedSetting\-1.md)

#### Implements

[ITrackedSetting](osu.Framework.Configuration.Tracking.ITrackedSetting.md)

#### Inherited Members

[TrackedSetting<TValue\>.SettingChanged](osu.Framework.Configuration.Tracking.TrackedSetting\-1.md\#osu\_Framework\_Configuration\_Tracking\_TrackedSetting\_1\_SettingChanged), 
[TrackedSetting<TValue\>.LoadFrom<TLookup\>\(ConfigManager<TLookup\>\)](osu.Framework.Configuration.Tracking.TrackedSetting\-1.md\#osu\_Framework\_Configuration\_Tracking\_TrackedSetting\_1\_LoadFrom\_\_1\_osu\_Framework\_Configuration\_ConfigManager\_\_\_0\_\_), 
[TrackedSetting<TValue\>.Unload\(\)](osu.Framework.Configuration.Tracking.TrackedSetting\-1.md\#osu\_Framework\_Configuration\_Tracking\_TrackedSetting\_1\_Unload), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ConfigManager<TLookup\>.TrackedSetting<TValue\>\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ConfigManager<TLookup\>.TrackedSetting<TValue\>\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ConfigManager<TLookup\>.TrackedSetting<TValue\>\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ConfigManager<TLookup\>.TrackedSetting<TValue\>\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ConfigManager<TLookup\>.TrackedSetting<TValue\>, TChild\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ConfigManager<TLookup\>.TrackedSetting<TValue\>, TChild\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ConfigManager<TLookup\>.TrackedSetting<TValue\>, TChild\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ConfigManager<TLookup\>.TrackedSetting<TValue\>\>\(ConfigManager<TLookup\>.TrackedSetting<TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_ConfigManager_1_TrackedSetting_1__ctor__0_System_Func__1_osu_Framework_Configuration_Tracking_SettingDescription__"></a> TrackedSetting\(TLookup, Func<TValue, SettingDescription\>\)

Constructs a new <xref href="osu.Framework.Configuration.ConfigManager%601.TrackedSetting%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public TrackedSetting(TLookup setting, Func<TValue, SettingDescription> generateDescription)
```

#### Parameters

`setting` TLookup

The config setting to be tracked.

`generateDescription` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [SettingDescription](osu.Framework.Configuration.Tracking.SettingDescription.md)\>

A function that generates the description for the setting, invoked every time the value changes.

