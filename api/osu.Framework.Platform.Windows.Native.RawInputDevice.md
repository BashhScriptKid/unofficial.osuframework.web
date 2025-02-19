# <a id="osu_Framework_Platform_Windows_Native_RawInputDevice"></a> Struct RawInputDevice

Namespace: [osu.Framework.Platform.Windows.Native](osu.Framework.Platform.Windows.Native.md)  
Assembly: osu.Framework.dll  

```csharp
public struct RawInputDevice
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RawInputDevice\>\(RawInputDevice\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RawInputDevice\>\(RawInputDevice\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RawInputDevice\>\(RawInputDevice\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RawInputDevice\>\(RawInputDevice\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<RawInputDevice, TChild\>\(RawInputDevice, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RawInputDevice, TChild\>\(RawInputDevice, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RawInputDevice, TChild\>\(RawInputDevice, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RawInputDevice\>\(RawInputDevice\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Platform_Windows_Native_RawInputDevice_Flags"></a> Flags

Mode flag that specifies how to interpret the information provided by UsagePage and Usage.

```csharp
public RawInputDeviceFlags Flags
```

#### Field Value

 [RawInputDeviceFlags](osu.Framework.Platform.Windows.Native.RawInputDeviceFlags.md)

### <a id="osu_Framework_Platform_Windows_Native_RawInputDevice_Usage"></a> Usage

Top level collection Usage for the raw input device.

```csharp
public HIDUsage Usage
```

#### Field Value

 [HIDUsage](osu.Framework.Platform.Windows.Native.HIDUsage.md)

### <a id="osu_Framework_Platform_Windows_Native_RawInputDevice_UsagePage"></a> UsagePage

Top level collection Usage page for the raw input device.

```csharp
public HIDUsagePage UsagePage
```

#### Field Value

 [HIDUsagePage](osu.Framework.Platform.Windows.Native.HIDUsagePage.md)

### <a id="osu_Framework_Platform_Windows_Native_RawInputDevice_WindowHandle"></a> WindowHandle

Handle to the target device. If NULL, it follows the keyboard focus.

```csharp
public nint WindowHandle
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

