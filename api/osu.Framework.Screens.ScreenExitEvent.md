# <a id="osu_Framework_Screens_ScreenExitEvent"></a> Class ScreenExitEvent

Namespace: [osu.Framework.Screens](osu.Framework.Screens.md)  
Assembly: osu.Framework.dll  

Denotes a screen exit event.

```csharp
public class ScreenExitEvent : ScreenTransitionEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ScreenTransitionEvent](osu.Framework.Screens.ScreenTransitionEvent.md) ← 
[ScreenExitEvent](osu.Framework.Screens.ScreenExitEvent.md)

#### Inherited Members

[ScreenTransitionEvent.Last](osu.Framework.Screens.ScreenTransitionEvent.md\#osu\_Framework\_Screens\_ScreenTransitionEvent\_Last), 
[ScreenTransitionEvent.Next](osu.Framework.Screens.ScreenTransitionEvent.md\#osu\_Framework\_Screens\_ScreenTransitionEvent\_Next), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ScreenExitEvent\>\(ScreenExitEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ScreenExitEvent\>\(ScreenExitEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ScreenExitEvent\>\(ScreenExitEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ScreenExitEvent\>\(ScreenExitEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ScreenExitEvent, TChild\>\(ScreenExitEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ScreenExitEvent, TChild\>\(ScreenExitEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ScreenExitEvent, TChild\>\(ScreenExitEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ScreenExitEvent\>\(ScreenExitEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Screens_ScreenExitEvent__ctor_osu_Framework_Screens_IScreen_osu_Framework_Screens_IScreen_osu_Framework_Screens_IScreen_"></a> ScreenExitEvent\(IScreen, IScreen, IScreen\)

```csharp
public ScreenExitEvent(IScreen last, IScreen next, IScreen destination)
```

#### Parameters

`last` [IScreen](osu.Framework.Screens.IScreen.md)

`next` [IScreen](osu.Framework.Screens.IScreen.md)

`destination` [IScreen](osu.Framework.Screens.IScreen.md)

## Properties

### <a id="osu_Framework_Screens_ScreenExitEvent_Destination"></a> Destination

The final <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> of this exit operation.

```csharp
public IScreen Destination { get; }
```

#### Property Value

 [IScreen](osu.Framework.Screens.IScreen.md)

