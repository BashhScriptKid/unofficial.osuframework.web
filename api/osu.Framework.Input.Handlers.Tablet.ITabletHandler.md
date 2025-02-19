# <a id="osu_Framework_Input_Handlers_Tablet_ITabletHandler"></a> Interface ITabletHandler

Namespace: [osu.Framework.Input.Handlers.Tablet](osu.Framework.Input.Handlers.Tablet.md)  
Assembly: osu.Framework.dll  

An interface to access OpenTabletDriverHandler.
Can be considered for removal now that we're solely targeting .NET 6

```csharp
public interface ITabletHandler
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ITabletHandler\>\(ITabletHandler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITabletHandler\>\(ITabletHandler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITabletHandler\>\(ITabletHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITabletHandler\>\(ITabletHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITabletHandler, TChild\>\(ITabletHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITabletHandler, TChild\>\(ITabletHandler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITabletHandler, TChild\>\(ITabletHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITabletHandler\>\(ITabletHandler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_Handlers_Tablet_ITabletHandler_AreaOffset"></a> AreaOffset

The offset of the area which should be mapped to the game window.

```csharp
Bindable<Vector2> AreaOffset { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<Vector2\>

### <a id="osu_Framework_Input_Handlers_Tablet_ITabletHandler_AreaSize"></a> AreaSize

The size of the area which should be mapped to the game window.

```csharp
Bindable<Vector2> AreaSize { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<Vector2\>

### <a id="osu_Framework_Input_Handlers_Tablet_ITabletHandler_Enabled"></a> Enabled

```csharp
BindableBool Enabled { get; }
```

#### Property Value

 [BindableBool](osu.Framework.Bindables.BindableBool.md)

### <a id="osu_Framework_Input_Handlers_Tablet_ITabletHandler_Rotation"></a> Rotation

The rotation of the tablet area in degrees.

```csharp
Bindable<float> Rotation { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="osu_Framework_Input_Handlers_Tablet_ITabletHandler_Tablet"></a> Tablet

Information on the currently connected tablet device. May be null if no tablet is detected.

```csharp
IBindable<TabletInfo?> Tablet { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[TabletInfo](osu.Framework.Input.Handlers.Tablet.TabletInfo.md)?\>

