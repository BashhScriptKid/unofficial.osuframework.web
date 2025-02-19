# <a id="osu_Framework_Input_StateChanges_MousePositionRelativeInputFromPen"></a> Class MousePositionRelativeInputFromPen

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class MousePositionRelativeInputFromPen : MousePositionRelativeInput, ISourcedFromPen, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MousePositionRelativeInput](osu.Framework.Input.StateChanges.MousePositionRelativeInput.md) ← 
[MousePositionRelativeInputFromPen](osu.Framework.Input.StateChanges.MousePositionRelativeInputFromPen.md)

#### Implements

[ISourcedFromPen](osu.Framework.Input.StateChanges.ISourcedFromPen.md), 
[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[MousePositionRelativeInput.Delta](osu.Framework.Input.StateChanges.MousePositionRelativeInput.md\#osu\_Framework\_Input\_StateChanges\_MousePositionRelativeInput\_Delta), 
[MousePositionRelativeInput.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.MousePositionRelativeInput.md\#osu\_Framework\_Input\_StateChanges\_MousePositionRelativeInput\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MousePositionRelativeInputFromPen\>\(MousePositionRelativeInputFromPen?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MousePositionRelativeInputFromPen\>\(MousePositionRelativeInputFromPen\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MousePositionRelativeInputFromPen\>\(MousePositionRelativeInputFromPen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MousePositionRelativeInputFromPen\>\(MousePositionRelativeInputFromPen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MousePositionRelativeInputFromPen, TChild\>\(MousePositionRelativeInputFromPen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MousePositionRelativeInputFromPen, TChild\>\(MousePositionRelativeInputFromPen, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MousePositionRelativeInputFromPen, TChild\>\(MousePositionRelativeInputFromPen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MousePositionRelativeInputFromPen\>\(MousePositionRelativeInputFromPen\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_StateChanges_MousePositionRelativeInputFromPen_DeviceType"></a> DeviceType

The type of the tablet or pen device that made this input.

```csharp
public required TabletPenDeviceType DeviceType { get; init; }
```

#### Property Value

 [TabletPenDeviceType](osu.Framework.Input.StateChanges.TabletPenDeviceType.md)

