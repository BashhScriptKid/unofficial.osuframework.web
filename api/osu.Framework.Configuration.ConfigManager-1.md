# <a id="osu_Framework_Configuration_ConfigManager_1"></a> Class ConfigManager<TLookup\>

Namespace: [osu.Framework.Configuration](osu.Framework.Configuration.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class ConfigManager<TLookup> : ConfigManager, IDisposable, ITrackableConfigManager, IConfigManager where TLookup : struct, Enum
```

#### Type Parameters

`TLookup` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConfigManager](osu.Framework.Configuration.ConfigManager.md) ← 
[ConfigManager<TLookup\>](osu.Framework.Configuration.ConfigManager\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[ITrackableConfigManager](osu.Framework.Configuration.Tracking.ITrackableConfigManager.md), 
[IConfigManager](osu.Framework.Configuration.IConfigManager.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<ConfigManager<TLookup\>\>\(ConfigManager<TLookup\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ConfigManager<TLookup\>\>\(ConfigManager<TLookup\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ConfigManager<TLookup\>\>\(ConfigManager<TLookup\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ConfigManager<TLookup\>\>\(ConfigManager<TLookup\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ConfigManager<TLookup\>, TChild\>\(ConfigManager<TLookup\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ConfigManager<TLookup\>, TChild\>\(ConfigManager<TLookup\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ConfigManager<TLookup\>, TChild\>\(ConfigManager<TLookup\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ConfigManager<TLookup\>\>\(ConfigManager<TLookup\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_ConfigManager_1__ctor_System_Collections_Generic_IDictionary__0_System_Object__"></a> ConfigManager\(IDictionary<TLookup, object\>\)

Initialise a new <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref>

```csharp
protected ConfigManager(IDictionary<TLookup, object> defaultOverrides = null)
```

#### Parameters

`defaultOverrides` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<TLookup, [object](https://learn.microsoft.com/dotnet/api/system.object)\>

Dictionary of overrides which should take precedence over defaults specified by the <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref> implementation.

## Fields

### <a id="osu_Framework_Configuration_ConfigManager_1_ConfigStore"></a> ConfigStore

```csharp
protected readonly Dictionary<TLookup, IBindable> ConfigStore
```

#### Field Value

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TLookup, [IBindable](osu.Framework.Bindables.IBindable.md)\>

## Properties

### <a id="osu_Framework_Configuration_ConfigManager_1_AddMissingEntries"></a> AddMissingEntries

Whether user specified configuration elements should be set even though a default was never specified.

```csharp
protected virtual bool AddMissingEntries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Configuration_ConfigManager_1_AddBindable__1__0_osu_Framework_Bindables_Bindable___0__"></a> AddBindable<TBindable\>\(TLookup, Bindable<TBindable\>\)

```csharp
protected virtual void AddBindable<TBindable>(TLookup lookup, Bindable<TBindable> bindable)
```

#### Parameters

`lookup` TLookup

`bindable` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TBindable\>

#### Type Parameters

`TBindable` 

### <a id="osu_Framework_Configuration_ConfigManager_1_BindWith__1__0_osu_Framework_Bindables_Bindable___0__"></a> BindWith<TValue\>\(TLookup, Bindable<TValue\>\)

Binds a local bindable with a configuration-backed bindable.

```csharp
public void BindWith<TValue>(TLookup lookup, Bindable<TValue> bindable)
```

#### Parameters

`lookup` TLookup

`bindable` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TValue\>

#### Type Parameters

`TValue` 

### <a id="osu_Framework_Configuration_ConfigManager_1_CheckLookupContainsPrivateInformation__0_"></a> CheckLookupContainsPrivateInformation\(TLookup\)

Check whether a specific lookup may contain private user information.

```csharp
protected virtual bool CheckLookupContainsPrivateInformation(TLookup lookup)
```

#### Parameters

`lookup` TLookup

The lookup type to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether private information is present.

### <a id="osu_Framework_Configuration_ConfigManager_1_CreateTrackedSettings"></a> CreateTrackedSettings\(\)

Retrieves all the settings of this <xref href="osu.Framework.Configuration.ConfigManager%601" data-throw-if-not-resolved="false"></xref> that are to be tracked for changes.

```csharp
public virtual TrackedSettings CreateTrackedSettings()
```

#### Returns

 [TrackedSettings](osu.Framework.Configuration.Tracking.TrackedSettings.md)

A list of <xref href="osu.Framework.Configuration.Tracking.ITrackedSetting" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Configuration_ConfigManager_1_Get__1__0_"></a> Get<TValue\>\(TLookup\)

```csharp
public TValue Get<TValue>(TLookup lookup)
```

#### Parameters

`lookup` TLookup

#### Returns

 TValue

#### Type Parameters

`TValue` 

### <a id="osu_Framework_Configuration_ConfigManager_1_GetBindable__1__0_"></a> GetBindable<TValue\>\(TLookup\)

Retrieve a bindable. This will be a new instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
public Bindable<TValue> GetBindable<TValue>(TLookup lookup)
```

#### Parameters

`lookup` TLookup

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TValue\>

A weakly bound copy of the specified bindable.

#### Type Parameters

`TValue` 

### <a id="osu_Framework_Configuration_ConfigManager_1_GetCurrentConfigurationForLogging"></a> GetCurrentConfigurationForLogging\(\)

Get the full configuration for logging purposes.

```csharp
public virtual IDictionary<TLookup, string> GetCurrentConfigurationForLogging()
```

#### Returns

 [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<TLookup, [string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Remarks

Excludes any potentially sensitive information via <xref href="osu.Framework.Configuration.ConfigManager%601.CheckLookupContainsPrivateInformation(%600)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Configuration_ConfigManager_1_GetOriginalBindable__1__0_"></a> GetOriginalBindable<TValue\>\(TLookup\)

```csharp
protected Bindable<TValue> GetOriginalBindable<TValue>(TLookup lookup)
```

#### Parameters

`lookup` TLookup

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TValue\>

#### Type Parameters

`TValue` 

### <a id="osu_Framework_Configuration_ConfigManager_1_InitialiseDefaults"></a> InitialiseDefaults\(\)

Set all required default values via Set() calls.
Note that defaults set here may be overridden by <xref href="osu.Framework.Configuration.ConfigManager%601.defaultOverrides" data-throw-if-not-resolved="false"></xref> provided in the constructor.

```csharp
protected virtual void InitialiseDefaults()
```

### <a id="osu_Framework_Configuration_ConfigManager_1_LoadInto_osu_Framework_Configuration_Tracking_TrackedSettings_"></a> LoadInto\(TrackedSettings\)

Loads <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref>s into <xref href="osu.Framework.Configuration.Tracking.TrackedSettings" data-throw-if-not-resolved="false"></xref>.

```csharp
public void LoadInto(TrackedSettings settings)
```

#### Parameters

`settings` [TrackedSettings](osu.Framework.Configuration.Tracking.TrackedSettings.md)

The settings to load into.

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__0_System_Double_System_Nullable_System_Double__System_Nullable_System_Double__System_Nullable_System_Double__"></a> SetDefault\(TLookup, double, double?, double?, double?\)

Sets a configuration's default value.

```csharp
protected BindableDouble SetDefault(TLookup lookup, double value, double? min = null, double? max = null, double? precision = null)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

The default value.

`min` [double](https://learn.microsoft.com/dotnet/api/system.double)?

The minimum value.

`max` [double](https://learn.microsoft.com/dotnet/api/system.double)?

The maximum value.

`precision` [double](https://learn.microsoft.com/dotnet/api/system.double)?

The value precision.

#### Returns

 [BindableDouble](osu.Framework.Bindables.BindableDouble.md)

The original bindable (not a bound copy).

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__0_System_Single_System_Nullable_System_Single__System_Nullable_System_Single__System_Nullable_System_Single__"></a> SetDefault\(TLookup, float, float?, float?, float?\)

Sets a configuration's default value.

```csharp
protected BindableFloat SetDefault(TLookup lookup, float value, float? min = null, float? max = null, float? precision = null)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The default value.

`min` [float](https://learn.microsoft.com/dotnet/api/system.single)?

The minimum value.

`max` [float](https://learn.microsoft.com/dotnet/api/system.single)?

The maximum value.

`precision` [float](https://learn.microsoft.com/dotnet/api/system.single)?

The value precision.

#### Returns

 [BindableFloat](osu.Framework.Bindables.BindableFloat.md)

The original bindable (not a bound copy).

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__0_System_Int32_System_Nullable_System_Int32__System_Nullable_System_Int32__"></a> SetDefault\(TLookup, int, int?, int?\)

Sets a configuration's default value.

```csharp
protected BindableInt SetDefault(TLookup lookup, int value, int? min = null, int? max = null)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The default value.

`min` [int](https://learn.microsoft.com/dotnet/api/system.int32)?

The minimum value.

`max` [int](https://learn.microsoft.com/dotnet/api/system.int32)?

The maximum value.

#### Returns

 [BindableInt](osu.Framework.Bindables.BindableInt.md)

The original bindable (not a bound copy).

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__0_System_Boolean_"></a> SetDefault\(TLookup, bool\)

Sets a configuration's default value.

```csharp
protected BindableBool SetDefault(TLookup lookup, bool value)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

The default value.

#### Returns

 [BindableBool](osu.Framework.Bindables.BindableBool.md)

The original bindable (not a bound copy).

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__0_System_Drawing_Size_System_Nullable_System_Drawing_Size__System_Nullable_System_Drawing_Size__"></a> SetDefault\(TLookup, Size, Size?, Size?\)

Sets a configuration's default value.

```csharp
protected BindableSize SetDefault(TLookup lookup, Size value, Size? min = null, Size? max = null)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

The default value.

`min` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)?

The minimum value.

`max` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)?

The maximum value.

#### Returns

 [BindableSize](osu.Framework.Bindables.BindableSize.md)

The original bindable (not a bound copy).

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__0_osu_Framework_Graphics_Colour4_"></a> SetDefault\(TLookup, Colour4\)

Sets a configuration's default value.

```csharp
protected BindableColour4 SetDefault(TLookup lookup, Colour4 value)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` [Colour4](osu.Framework.Graphics.Colour4.md)

The default value.

#### Returns

 [BindableColour4](osu.Framework.Bindables.BindableColour4.md)

The original bindable (not a bound copy).

### <a id="osu_Framework_Configuration_ConfigManager_1_SetDefault__1__0___0_"></a> SetDefault<TValue\>\(TLookup, TValue\)

Sets a configuration's default value.

```csharp
protected Bindable<TValue> SetDefault<TValue>(TLookup lookup, TValue value)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` TValue

The default value.

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TValue\>

The original bindable (not a bound copy).

#### Type Parameters

`TValue` 

### <a id="osu_Framework_Configuration_ConfigManager_1_SetValue__1__0___0_"></a> SetValue<TValue\>\(TLookup, TValue\)

Sets a configuration's value.

```csharp
public void SetValue<TValue>(TLookup lookup, TValue value)
```

#### Parameters

`lookup` TLookup

The lookup key.

`value` TValue

The value. Will also become the default value if one has not already been initialised.

#### Type Parameters

`TValue` 

The type of value.

