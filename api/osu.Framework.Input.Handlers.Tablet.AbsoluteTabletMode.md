# <a id="osu_Framework_Input_Handlers_Tablet_AbsoluteTabletMode"></a> Class AbsoluteTabletMode

Namespace: [osu.Framework.Input.Handlers.Tablet](osu.Framework.Input.Handlers.Tablet.md)  
Assembly: osu.Framework.dll  

```csharp
public class AbsoluteTabletMode : AbsoluteOutputMode, IOutputMode, IPipelineElement<IDeviceReport>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
PipelineManager<IDeviceReport\> ← 
OutputMode ← 
AbsoluteOutputMode ← 
[AbsoluteTabletMode](osu.Framework.Input.Handlers.Tablet.AbsoluteTabletMode.md)

#### Implements

IOutputMode, 
IPipelineElement<IDeviceReport\>, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

AbsoluteOutputMode.CreateTransformationMatrix\(\), 
AbsoluteOutputMode.CalculateTransformation\(Area, Area, DigitizerSpecifications\), 
AbsoluteOutputMode.Transform\(IAbsolutePositionReport\), 
AbsoluteOutputMode.OnOutput\(IDeviceReport\), 
AbsoluteOutputMode.Input, 
AbsoluteOutputMode.Output, 
AbsoluteOutputMode.Pointer, 
AbsoluteOutputMode.AreaClipping, 
AbsoluteOutputMode.AreaLimiting, 
OutputMode.Consume\(IDeviceReport\), 
OutputMode.Read\(IDeviceReport\), 
OutputMode.CreateTransformationMatrix\(\), 
OutputMode.Transform\(IAbsolutePositionReport\), 
OutputMode.OnOutput\(IDeviceReport\), 
OutputMode.Dispose\(\), 
OutputMode.Passthrough, 
OutputMode.PreTransformElements, 
OutputMode.PostTransformElements, 
OutputMode.TransformationMatrix, 
OutputMode.Elements, 
OutputMode.Tablet, 
OutputMode.Emit, 
PipelineManager<IDeviceReport\>.Link<T2\>\(IPipelineElement<IDeviceReport\>, T2\), 
PipelineManager<IDeviceReport\>.Unlink<T2\>\(IPipelineElement<IDeviceReport\>, T2\), 
PipelineManager<IDeviceReport\>.LinkElements\(IEnumerable<IPipelineElement<IDeviceReport\>\>\), 
PipelineManager<IDeviceReport\>.UnlinkElements\(IEnumerable<IPipelineElement<IDeviceReport\>\>\), 
PipelineManager<IDeviceReport\>.LinkAll\(params object\[\]\), 
PipelineManager<IDeviceReport\>.UnlinkAll\(params object\[\]\), 
PipelineManager<IDeviceReport\>.GroupElements\(IList<IPositionedPipelineElement<IDeviceReport\>\>, PipelinePosition\), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AbsoluteTabletMode\>\(AbsoluteTabletMode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AbsoluteTabletMode\>\(AbsoluteTabletMode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AbsoluteTabletMode\>\(AbsoluteTabletMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AbsoluteTabletMode\>\(AbsoluteTabletMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AbsoluteTabletMode, TChild\>\(AbsoluteTabletMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AbsoluteTabletMode, TChild\>\(AbsoluteTabletMode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AbsoluteTabletMode, TChild\>\(AbsoluteTabletMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AbsoluteTabletMode\>\(AbsoluteTabletMode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Handlers_Tablet_AbsoluteTabletMode__ctor_OpenTabletDriver_Plugin_Platform_Pointer_IAbsolutePointer_"></a> AbsoluteTabletMode\(IAbsolutePointer\)

```csharp
public AbsoluteTabletMode(IAbsolutePointer pointer)
```

#### Parameters

`pointer` IAbsolutePointer

## Properties

### <a id="osu_Framework_Input_Handlers_Tablet_AbsoluteTabletMode_Pointer"></a> Pointer

```csharp
public override IAbsolutePointer Pointer { get; set; }
```

#### Property Value

 IAbsolutePointer

