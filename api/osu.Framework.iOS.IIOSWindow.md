# <a id="osu_Framework_iOS_IIOSWindow"></a> Interface IIOSWindow

Namespace: [osu.Framework.iOS](osu.Framework.iOS.md)  
Assembly: osu.Framework.iOS.dll  

Interface representation of the game window on the iOS platform.

```csharp
public interface IIOSWindow : IWindow, IDisposable
```

#### Implements

IWindow, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IIOSWindow\>\(IIOSWindow?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IIOSWindow\>\(IIOSWindow\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IIOSWindow\>\(IIOSWindow\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IIOSWindow\>\(IIOSWindow\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IIOSWindow, TChild\>\(IIOSWindow, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IIOSWindow, TChild\>\(IIOSWindow, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IIOSWindow, TChild\>\(IIOSWindow, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IIOSWindow\>\(IIOSWindow\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_iOS_IIOSWindow_UIWindow"></a> UIWindow

The underlying <xref href="osu.Framework.iOS.IIOSWindow.UIWindow" data-throw-if-not-resolved="false"></xref> associated to this window.

```csharp
UIWindow UIWindow { get; }
```

#### Property Value

 UIWindow

### <a id="osu_Framework_iOS_IIOSWindow_ViewController"></a> ViewController

The <xref href="UIKit.UIViewController" data-throw-if-not-resolved="false"></xref> presenting this window's content.

```csharp
UIViewController ViewController { get; }
```

#### Property Value

 UIViewController

