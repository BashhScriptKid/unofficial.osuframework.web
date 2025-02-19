# <a id="osu_Framework_Configuration_Tracking_SettingDescription"></a> Class SettingDescription

Namespace: [osu.Framework.Configuration.Tracking](osu.Framework.Configuration.Tracking.md)  
Assembly: osu.Framework.dll  

Contains information that can be displayed when tracked settings change.

```csharp
public class SettingDescription
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SettingDescription](osu.Framework.Configuration.Tracking.SettingDescription.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SettingDescription\>\(SettingDescription?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SettingDescription\>\(SettingDescription\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SettingDescription\>\(SettingDescription\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SettingDescription\>\(SettingDescription\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SettingDescription, TChild\>\(SettingDescription, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SettingDescription, TChild\>\(SettingDescription, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SettingDescription, TChild\>\(SettingDescription, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SettingDescription\>\(SettingDescription\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Configuration_Tracking_SettingDescription__ctor_System_Object_osu_Framework_Localisation_LocalisableString_osu_Framework_Localisation_LocalisableString_System_Nullable_osu_Framework_Localisation_LocalisableString__"></a> SettingDescription\(object, LocalisableString, LocalisableString, LocalisableString?\)

Constructs a new <xref href="osu.Framework.Configuration.Tracking.SettingDescription" data-throw-if-not-resolved="false"></xref>.

```csharp
public SettingDescription(object rawValue, LocalisableString name, LocalisableString value, LocalisableString? shortcut = null)
```

#### Parameters

`rawValue` [object](https://learn.microsoft.com/dotnet/api/system.object)

The raw setting value.

`name` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The readable setting name.

`value` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The readable setting value.

`shortcut` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)?

The shortcut keys that cause this setting to change.

## Fields

### <a id="osu_Framework_Configuration_Tracking_SettingDescription_Name"></a> Name

The readable setting name.

```csharp
public readonly LocalisableString Name
```

#### Field Value

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Configuration_Tracking_SettingDescription_RawValue"></a> RawValue

The raw setting value.

```csharp
public readonly object RawValue
```

#### Field Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Configuration_Tracking_SettingDescription_Shortcut"></a> Shortcut

The shortcut keys that cause this setting to change.

```csharp
public readonly LocalisableString Shortcut
```

#### Field Value

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Configuration_Tracking_SettingDescription_Value"></a> Value

The readable setting value.

```csharp
public readonly LocalisableString Value
```

#### Field Value

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

