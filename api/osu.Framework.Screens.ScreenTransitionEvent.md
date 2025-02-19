# <a id="osu_Framework_Screens_ScreenTransitionEvent"></a> Class ScreenTransitionEvent

Namespace: [osu.Framework.Screens](osu.Framework.Screens.md)  
Assembly: osu.Framework.dll  

Denotes a screen transition event.

```csharp
public class ScreenTransitionEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ScreenTransitionEvent](osu.Framework.Screens.ScreenTransitionEvent.md)

#### Derived

[ScreenExitEvent](osu.Framework.Screens.ScreenExitEvent.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ScreenTransitionEvent\>\(ScreenTransitionEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ScreenTransitionEvent\>\(ScreenTransitionEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ScreenTransitionEvent\>\(ScreenTransitionEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ScreenTransitionEvent\>\(ScreenTransitionEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ScreenTransitionEvent, TChild\>\(ScreenTransitionEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ScreenTransitionEvent, TChild\>\(ScreenTransitionEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ScreenTransitionEvent, TChild\>\(ScreenTransitionEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ScreenTransitionEvent\>\(ScreenTransitionEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Screens_ScreenTransitionEvent__ctor_osu_Framework_Screens_IScreen_osu_Framework_Screens_IScreen_"></a> ScreenTransitionEvent\(IScreen?, IScreen\)

```csharp
public ScreenTransitionEvent(IScreen? last, IScreen next)
```

#### Parameters

`last` [IScreen](osu.Framework.Screens.IScreen.md)?

`next` [IScreen](osu.Framework.Screens.IScreen.md)

## Properties

### <a id="osu_Framework_Screens_ScreenTransitionEvent_Last"></a> Last

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> which has been transitioned from.

```csharp
public IScreen? Last { get; }
```

#### Property Value

 [IScreen](osu.Framework.Screens.IScreen.md)?

### <a id="osu_Framework_Screens_ScreenTransitionEvent_Next"></a> Next

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> which has been transitioned to.

```csharp
public IScreen Next { get; }
```

#### Property Value

 [IScreen](osu.Framework.Screens.IScreen.md)

