# <a id="osu_Framework_Platform_Windows_Native_RawMouse"></a> Struct RawMouse

Namespace: [osu.Framework.Platform.Windows.Native](osu.Framework.Platform.Windows.Native.md)  
Assembly: osu.Framework.dll  

Contains information about the state of the mouse.

```csharp
public struct RawMouse
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RawMouse\>\(RawMouse\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RawMouse\>\(RawMouse\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RawMouse\>\(RawMouse\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RawMouse\>\(RawMouse\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<RawMouse, TChild\>\(RawMouse, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RawMouse, TChild\>\(RawMouse, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RawMouse, TChild\>\(RawMouse, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RawMouse\>\(RawMouse\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_ButtonData"></a> ButtonData

If the mouse wheel is moved, this will contain the delta amount.

```csharp
public short ButtonData
```

#### Field Value

 [short](https://learn.microsoft.com/dotnet/api/system.int16)

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_ButtonFlags"></a> ButtonFlags

Flags for the event.

```csharp
public RawMouseButtons ButtonFlags
```

#### Field Value

 [RawMouseButtons](osu.Framework.Platform.Windows.Native.RawMouseButtons.md)

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_ExtraInformation"></a> ExtraInformation

The device-specific additional information for the event.

```csharp
public uint ExtraInformation
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_Flags"></a> Flags

The mouse state.

```csharp
public RawMouseFlags Flags
```

#### Field Value

 [RawMouseFlags](osu.Framework.Platform.Windows.Native.RawMouseFlags.md)

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_LastX"></a> LastX

The motion in the X direction. This is signed relative motion or
absolute motion, depending on the value of usFlags.

```csharp
public int LastX
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_LastY"></a> LastY

The motion in the Y direction. This is signed relative motion or absolute motion,
depending on the value of usFlags.

```csharp
public int LastY
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Platform_Windows_Native_RawMouse_RawButtons"></a> RawButtons

Raw button data.

```csharp
public uint RawButtons
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

