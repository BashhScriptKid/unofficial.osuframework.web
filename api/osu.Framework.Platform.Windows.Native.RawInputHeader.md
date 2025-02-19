# <a id="osu_Framework_Platform_Windows_Native_RawInputHeader"></a> Struct RawInputHeader

Namespace: [osu.Framework.Platform.Windows.Native](osu.Framework.Platform.Windows.Native.md)  
Assembly: osu.Framework.dll  

Value type for a raw input header.

```csharp
public struct RawInputHeader
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RawInputHeader\>\(RawInputHeader\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RawInputHeader\>\(RawInputHeader\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RawInputHeader\>\(RawInputHeader\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RawInputHeader\>\(RawInputHeader\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<RawInputHeader, TChild\>\(RawInputHeader, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RawInputHeader, TChild\>\(RawInputHeader, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RawInputHeader, TChild\>\(RawInputHeader, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RawInputHeader\>\(RawInputHeader\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Platform_Windows_Native_RawInputHeader_Device"></a> Device

Handle to the device sending the data.

```csharp
public nint Device
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_Windows_Native_RawInputHeader_Size"></a> Size

Size of the packet of data.

```csharp
public int Size
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Platform_Windows_Native_RawInputHeader_Type"></a> Type

Type of device the input is coming from.

```csharp
public RawInputType Type
```

#### Field Value

 [RawInputType](osu.Framework.Platform.Windows.Native.RawInputType.md)

### <a id="osu_Framework_Platform_Windows_Native_RawInputHeader_wParam"></a> wParam

wParam from the window message.

```csharp
public nint wParam
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

