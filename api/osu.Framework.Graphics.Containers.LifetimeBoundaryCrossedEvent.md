# <a id="osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent"></a> Struct LifetimeBoundaryCrossedEvent

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Represents that the clock is crossed <xref href="osu.Framework.Graphics.Containers.LifetimeManagementContainer" data-throw-if-not-resolved="false"></xref>'s child lifetime boundary i.e. <xref href="osu.Framework.Graphics.Drawable.LifetimeStart" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.LifetimeEnd" data-throw-if-not-resolved="false"></xref>,

```csharp
public readonly struct LifetimeBoundaryCrossedEvent
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LifetimeBoundaryCrossedEvent\>\(LifetimeBoundaryCrossedEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LifetimeBoundaryCrossedEvent\>\(LifetimeBoundaryCrossedEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LifetimeBoundaryCrossedEvent\>\(LifetimeBoundaryCrossedEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LifetimeBoundaryCrossedEvent\>\(LifetimeBoundaryCrossedEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LifetimeBoundaryCrossedEvent, TChild\>\(LifetimeBoundaryCrossedEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LifetimeBoundaryCrossedEvent, TChild\>\(LifetimeBoundaryCrossedEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LifetimeBoundaryCrossedEvent, TChild\>\(LifetimeBoundaryCrossedEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LifetimeBoundaryCrossedEvent\>\(LifetimeBoundaryCrossedEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent__ctor_osu_Framework_Graphics_Drawable_osu_Framework_Graphics_Performance_LifetimeBoundaryKind_osu_Framework_Graphics_Performance_LifetimeBoundaryCrossingDirection_"></a> LifetimeBoundaryCrossedEvent\(Drawable, LifetimeBoundaryKind, LifetimeBoundaryCrossingDirection\)

```csharp
public LifetimeBoundaryCrossedEvent(Drawable child, LifetimeBoundaryKind kind, LifetimeBoundaryCrossingDirection direction)
```

#### Parameters

`child` [Drawable](osu.Framework.Graphics.Drawable.md)

`kind` [LifetimeBoundaryKind](osu.Framework.Graphics.Performance.LifetimeBoundaryKind.md)

`direction` [LifetimeBoundaryCrossingDirection](osu.Framework.Graphics.Performance.LifetimeBoundaryCrossingDirection.md)

## Fields

### <a id="osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent_Child"></a> Child

The drawable.

```csharp
public readonly Drawable Child
```

#### Field Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent_Direction"></a> Direction

The direction of the crossing.

```csharp
public readonly LifetimeBoundaryCrossingDirection Direction
```

#### Field Value

 [LifetimeBoundaryCrossingDirection](osu.Framework.Graphics.Performance.LifetimeBoundaryCrossingDirection.md)

### <a id="osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent_Kind"></a> Kind

Which lifetime boundary is crossed.

```csharp
public readonly LifetimeBoundaryKind Kind
```

#### Field Value

 [LifetimeBoundaryKind](osu.Framework.Graphics.Performance.LifetimeBoundaryKind.md)

## Methods

### <a id="osu_Framework_Graphics_Containers_LifetimeBoundaryCrossedEvent_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

