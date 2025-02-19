# <a id="osu_Framework_Platform_ISystemFileSelector"></a> Interface ISystemFileSelector

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ISystemFileSelector : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<ISystemFileSelector\>\(ISystemFileSelector?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ISystemFileSelector\>\(ISystemFileSelector\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ISystemFileSelector\>\(ISystemFileSelector\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ISystemFileSelector\>\(ISystemFileSelector\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ISystemFileSelector, TChild\>\(ISystemFileSelector, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ISystemFileSelector, TChild\>\(ISystemFileSelector, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ISystemFileSelector, TChild\>\(ISystemFileSelector, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ISystemFileSelector\>\(ISystemFileSelector\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Platform_ISystemFileSelector_Present"></a> Present\(\)

Presents the system file selector.

```csharp
void Present()
```

### <a id="osu_Framework_Platform_ISystemFileSelector_Selected"></a> Selected

Triggered when the user has selected a file.

```csharp
event Action<FileInfo> Selected
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[FileInfo](https://learn.microsoft.com/dotnet/api/system.io.fileinfo)\>

