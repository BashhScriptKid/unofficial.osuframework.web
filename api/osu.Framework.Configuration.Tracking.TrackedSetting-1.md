# <a id="osu_Framework_Configuration_Tracking_TrackedSetting_1"></a> Class TrackedSetting<TValue\>

Namespace: [osu.Framework.Configuration.Tracking](osu.Framework.Configuration.Tracking.md)  
Assembly: osu.Framework.dll  

A singular tracked setting.

```csharp
public abstract class TrackedSetting<TValue> : ITrackedSetting
```

#### Type Parameters

`TValue` 

The type of the tracked value.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TrackedSetting<TValue\>](osu.Framework.Configuration.Tracking.TrackedSetting\-1.md)

#### Implements

[ITrackedSetting](osu.Framework.Configuration.Tracking.ITrackedSetting.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TrackedSetting<TValue\>\>\(TrackedSetting<TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TrackedSetting<TValue\>\>\(TrackedSetting<TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TrackedSetting<TValue\>\>\(TrackedSetting<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TrackedSetting<TValue\>\>\(TrackedSetting<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TrackedSetting<TValue\>, TChild\>\(TrackedSetting<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TrackedSetting<TValue\>, TChild\>\(TrackedSetting<TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TrackedSetting<TValue\>, TChild\>\(TrackedSetting<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TrackedSetting<TValue\>\>\(TrackedSetting<TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_Tracking_TrackedSetting_1__ctor_System_Object_System_Func__0_osu_Framework_Configuration_Tracking_SettingDescription__"></a> TrackedSetting\(object, Func<TValue, SettingDescription\>\)

Constructs a new <xref href="osu.Framework.Configuration.Tracking.TrackedSetting%601" data-throw-if-not-resolved="false"></xref>.

```csharp
protected TrackedSetting(object setting, Func<TValue, SettingDescription> generateDescription)
```

#### Parameters

`setting` [object](https://learn.microsoft.com/dotnet/api/system.object)

The config setting to be tracked.

`generateDescription` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [SettingDescription](osu.Framework.Configuration.Tracking.SettingDescription.md)\>

A function that generates the description for the setting, invoked every time the value changes.

## Methods

### <a id="osu_Framework_Configuration_Tracking_TrackedSetting_1_LoadFrom__1_osu_Framework_Configuration_ConfigManager___0__"></a> LoadFrom<TLookup\>\(ConfigManager<TLookup\>\)

Loads a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> into this tracked setting, binding to <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting.SettingChanged" data-throw-if-not-resolved="false"></xref>.

```csharp
public void LoadFrom<TLookup>(ConfigManager<TLookup> configManager) where TLookup : struct, Enum
```

#### Parameters

`configManager` [ConfigManager](osu.Framework.Configuration.ConfigManager\-1.md)<TLookup\>

The <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref> to load from.

#### Type Parameters

`TLookup` 

### <a id="osu_Framework_Configuration_Tracking_TrackedSetting_1_Unload"></a> Unload\(\)

Unloads the <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> from this tracked setting, unbinding from <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting.SettingChanged" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Unload()
```

### <a id="osu_Framework_Configuration_Tracking_TrackedSetting_1_SettingChanged"></a> SettingChanged

Invoked when this setting has changed.

```csharp
[CanBeNull]
public event Action<SettingDescription> SettingChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[SettingDescription](osu.Framework.Configuration.Tracking.SettingDescription.md)\>

