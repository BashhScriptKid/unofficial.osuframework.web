# <a id="osu_Framework_Platform_IAndroidGraphicsSurface"></a> Interface IAndroidGraphicsSurface

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IAndroidGraphicsSurface
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IAndroidGraphicsSurface\>\(IAndroidGraphicsSurface?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IAndroidGraphicsSurface\>\(IAndroidGraphicsSurface\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IAndroidGraphicsSurface\>\(IAndroidGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IAndroidGraphicsSurface\>\(IAndroidGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IAndroidGraphicsSurface, TChild\>\(IAndroidGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IAndroidGraphicsSurface, TChild\>\(IAndroidGraphicsSurface, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IAndroidGraphicsSurface, TChild\>\(IAndroidGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IAndroidGraphicsSurface\>\(IAndroidGraphicsSurface\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Platform_IAndroidGraphicsSurface_JniEnvHandle"></a> JniEnvHandle

Returns JNI environment handle.

```csharp
nint JniEnvHandle { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_IAndroidGraphicsSurface_SurfaceHandle"></a> SurfaceHandle

Android Surface handle.

```csharp
nint SurfaceHandle { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Remarks

https://developer.android.com/reference/android/view/Surface.html

