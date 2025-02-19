# <a id="osu_Framework_Input_ICanSuppressKeyEventLogging"></a> Interface ICanSuppressKeyEventLogging

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

An interface which suppresses logging of keyboard input events.
Useful for password fields, where user input should not be logged.

```csharp
public interface ICanSuppressKeyEventLogging
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ICanSuppressKeyEventLogging\>\(ICanSuppressKeyEventLogging?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ICanSuppressKeyEventLogging\>\(ICanSuppressKeyEventLogging\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ICanSuppressKeyEventLogging\>\(ICanSuppressKeyEventLogging\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ICanSuppressKeyEventLogging\>\(ICanSuppressKeyEventLogging\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ICanSuppressKeyEventLogging, TChild\>\(ICanSuppressKeyEventLogging, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ICanSuppressKeyEventLogging, TChild\>\(ICanSuppressKeyEventLogging, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ICanSuppressKeyEventLogging, TChild\>\(ICanSuppressKeyEventLogging, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ICanSuppressKeyEventLogging\>\(ICanSuppressKeyEventLogging\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_ICanSuppressKeyEventLogging_SuppressKeyEventLogging"></a> SuppressKeyEventLogging

Whether key event logging should be suppressed for this drawable.

```csharp
bool SuppressKeyEventLogging { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

