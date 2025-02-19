# <a id="osu_Framework_Input_StateChanges_ISourcedFromPen"></a> Interface ISourcedFromPen

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

Denotes a simulated mouse input that was made by a tablet/pen device.

```csharp
public interface ISourcedFromPen : IInput
```

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ISourcedFromPen\>\(ISourcedFromPen?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ISourcedFromPen\>\(ISourcedFromPen\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ISourcedFromPen\>\(ISourcedFromPen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ISourcedFromPen\>\(ISourcedFromPen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ISourcedFromPen, TChild\>\(ISourcedFromPen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ISourcedFromPen, TChild\>\(ISourcedFromPen, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ISourcedFromPen, TChild\>\(ISourcedFromPen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ISourcedFromPen\>\(ISourcedFromPen\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_StateChanges_ISourcedFromPen_DeviceType"></a> DeviceType

The type of the tablet or pen device that made this input.

```csharp
TabletPenDeviceType DeviceType { get; }
```

#### Property Value

 [TabletPenDeviceType](osu.Framework.Input.StateChanges.TabletPenDeviceType.md)

