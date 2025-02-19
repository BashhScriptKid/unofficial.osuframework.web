# <a id="osu_Framework_Input_Handlers_Tablet_TabletDriver"></a> Class TabletDriver

Namespace: [osu.Framework.Input.Handlers.Tablet](osu.Framework.Input.Handlers.Tablet.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class TabletDriver : Driver, IDriver, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
Driver ← 
[TabletDriver](osu.Framework.Input.Handlers.Tablet.TabletDriver.md)

#### Implements

IDriver, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

Driver.GetReportParser\(DeviceIdentifier\), 
Driver.Detect\(\), 
Driver.Dispose\(\), 
Driver.CompositeDeviceHub, 
Driver.InputDevices, 
Driver.Tablets, 
Driver.TabletsChanged, 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TabletDriver\>\(TabletDriver?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletDriver\>\(TabletDriver\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletDriver\>\(TabletDriver\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletDriver\>\(TabletDriver\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletDriver, TChild\>\(TabletDriver, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletDriver, TChild\>\(TabletDriver, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletDriver, TChild\>\(TabletDriver, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletDriver\>\(TabletDriver\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Handlers_Tablet_TabletDriver__ctor_OpenTabletDriver_Plugin_Components_ICompositeDeviceHub_OpenTabletDriver_Plugin_Components_IReportParserProvider_OpenTabletDriver_Plugin_Components_IDeviceConfigurationProvider_"></a> TabletDriver\(ICompositeDeviceHub, IReportParserProvider, IDeviceConfigurationProvider\)

```csharp
public TabletDriver(ICompositeDeviceHub deviceHub, IReportParserProvider reportParserProvider, IDeviceConfigurationProvider configurationProvider)
```

#### Parameters

`deviceHub` ICompositeDeviceHub

`reportParserProvider` IReportParserProvider

`configurationProvider` IDeviceConfigurationProvider

## Fields

### <a id="osu_Framework_Input_Handlers_Tablet_TabletDriver_PostLog"></a> PostLog

```csharp
public Action<string, LogLevel, Exception?>? PostLog
```

#### Field Value

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-3)<[string](https://learn.microsoft.com/dotnet/api/system.string), [LogLevel](osu.Framework.Logging.LogLevel.md), [Exception](https://learn.microsoft.com/dotnet/api/system.exception)?\>?

## Methods

### <a id="osu_Framework_Input_Handlers_Tablet_TabletDriver_Create"></a> Create\(\)

```csharp
public static TabletDriver Create()
```

#### Returns

 [TabletDriver](osu.Framework.Input.Handlers.Tablet.TabletDriver.md)

### <a id="osu_Framework_Input_Handlers_Tablet_TabletDriver_Dispose"></a> Dispose\(\)

```csharp
public void Dispose()
```

### <a id="osu_Framework_Input_Handlers_Tablet_TabletDriver_DeviceReported"></a> DeviceReported

```csharp
public event EventHandler<IDeviceReport>? DeviceReported
```

#### Event Type

 [EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler\-1)<IDeviceReport\>?

