# <a id="osu_Framework_Platform_IOpenGLGraphicsSurface"></a> Interface IOpenGLGraphicsSurface

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Represents OpenGL-specific graphics API provided by an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IOpenGLGraphicsSurface
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IOpenGLGraphicsSurface\>\(IOpenGLGraphicsSurface?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IOpenGLGraphicsSurface\>\(IOpenGLGraphicsSurface\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IOpenGLGraphicsSurface\>\(IOpenGLGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IOpenGLGraphicsSurface\>\(IOpenGLGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IOpenGLGraphicsSurface, TChild\>\(IOpenGLGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IOpenGLGraphicsSurface, TChild\>\(IOpenGLGraphicsSurface, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IOpenGLGraphicsSurface, TChild\>\(IOpenGLGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IOpenGLGraphicsSurface\>\(IOpenGLGraphicsSurface\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_BackbufferFramebuffer"></a> BackbufferFramebuffer

The main framebuffer object, or null if unknown.

```csharp
int? BackbufferFramebuffer { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_CurrentContext"></a> CurrentContext

Returns the current graphics context.

```csharp
nint CurrentContext { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_VerticalSync"></a> VerticalSync

Enables or disables vertical sync.

```csharp
bool VerticalSync { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_WindowContext"></a> WindowContext

Returns the graphics context associated with the window.

```csharp
nint WindowContext { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

## Methods

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_ClearCurrent"></a> ClearCurrent\(\)

Clears the current graphics context.

```csharp
void ClearCurrent()
```

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_CreateContext"></a> CreateContext\(\)

Creates a new graphics context associated with this window.

```csharp
void CreateContext()
```

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_DeleteContext_System_IntPtr_"></a> DeleteContext\(nint\)

Deletes the specified context.

```csharp
void DeleteContext(nint context)
```

#### Parameters

`context` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_GetProcAddress_System_String_"></a> GetProcAddress\(string\)

Returns a pointer to the named OpenGL function.

```csharp
nint GetProcAddress(string symbol)
```

#### Parameters

`symbol` [string](https://learn.microsoft.com/dotnet/api/system.string)

The symbolic name of the OpenGL function.

#### Returns

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_MakeCurrent_System_IntPtr_"></a> MakeCurrent\(nint\)

Marks the specified context as current.

```csharp
void MakeCurrent(nint context)
```

#### Parameters

`context` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_IOpenGLGraphicsSurface_SwapBuffers"></a> SwapBuffers\(\)

Swaps the back buffer with the front buffer.

```csharp
void SwapBuffers()
```

