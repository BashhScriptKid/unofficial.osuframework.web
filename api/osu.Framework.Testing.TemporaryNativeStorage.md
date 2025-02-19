# <a id="osu_Framework_Testing_TemporaryNativeStorage"></a> Class TemporaryNativeStorage

Namespace: [osu.Framework.Testing](osu.Framework.Testing.md)  
Assembly: osu.Framework.dll  

A temporary storage that can be used for testing purposes.
Writes files to the OS temporary directory and cleans up on disposal.

```csharp
public class TemporaryNativeStorage : NativeStorage, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Storage](osu.Framework.Platform.Storage.md) ← 
[NativeStorage](osu.Framework.Platform.NativeStorage.md) ← 
[TemporaryNativeStorage](osu.Framework.Testing.TemporaryNativeStorage.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[NativeStorage.Exists\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_Exists\_System\_String\_), 
[NativeStorage.ExistsDirectory\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_ExistsDirectory\_System\_String\_), 
[NativeStorage.DeleteDirectory\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_DeleteDirectory\_System\_String\_), 
[NativeStorage.Delete\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_Delete\_System\_String\_), 
[NativeStorage.Move\(string, string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_Move\_System\_String\_System\_String\_), 
[NativeStorage.GetDirectories\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_GetDirectories\_System\_String\_), 
[NativeStorage.GetFiles\(string, string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_GetFiles\_System\_String\_System\_String\_), 
[NativeStorage.GetFullPath\(string, bool\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_GetFullPath\_System\_String\_System\_Boolean\_), 
[NativeStorage.OpenFileExternally\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_OpenFileExternally\_System\_String\_), 
[NativeStorage.PresentFileExternally\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_PresentFileExternally\_System\_String\_), 
[NativeStorage.GetStream\(string, FileAccess, FileMode\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_GetStream\_System\_String\_System\_IO\_FileAccess\_System\_IO\_FileMode\_), 
[NativeStorage.GetStorageForDirectory\(string\)](osu.Framework.Platform.NativeStorage.md\#osu\_Framework\_Platform\_NativeStorage\_GetStorageForDirectory\_System\_String\_), 
[Storage.BasePath](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_BasePath), 
[Storage.GetFullPath\(string, bool\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_GetFullPath\_System\_String\_System\_Boolean\_), 
[Storage.Exists\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_Exists\_System\_String\_), 
[Storage.ExistsDirectory\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_ExistsDirectory\_System\_String\_), 
[Storage.DeleteDirectory\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_DeleteDirectory\_System\_String\_), 
[Storage.Delete\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_Delete\_System\_String\_), 
[Storage.GetDirectories\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_GetDirectories\_System\_String\_), 
[Storage.GetFiles\(string, string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_GetFiles\_System\_String\_System\_String\_), 
[Storage.GetStorageForDirectory\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_GetStorageForDirectory\_System\_String\_), 
[Storage.Move\(string, string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_Move\_System\_String\_System\_String\_), 
[Storage.CreateFileSafely\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_CreateFileSafely\_System\_String\_), 
[Storage.GetStream\(string, FileAccess, FileMode\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_GetStream\_System\_String\_System\_IO\_FileAccess\_System\_IO\_FileMode\_), 
[Storage.OpenFileExternally\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_OpenFileExternally\_System\_String\_), 
[Storage.PresentExternally\(\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_PresentExternally), 
[Storage.PresentFileExternally\(string\)](osu.Framework.Platform.Storage.md\#osu\_Framework\_Platform\_Storage\_PresentFileExternally\_System\_String\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TemporaryNativeStorage\>\(TemporaryNativeStorage?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TemporaryNativeStorage\>\(TemporaryNativeStorage\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TemporaryNativeStorage\>\(TemporaryNativeStorage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TemporaryNativeStorage\>\(TemporaryNativeStorage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TemporaryNativeStorage, TChild\>\(TemporaryNativeStorage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TemporaryNativeStorage, TChild\>\(TemporaryNativeStorage, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TemporaryNativeStorage, TChild\>\(TemporaryNativeStorage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TemporaryNativeStorage\>\(TemporaryNativeStorage\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Testing_TemporaryNativeStorage__ctor_System_String_osu_Framework_Platform_GameHost_"></a> TemporaryNativeStorage\(string, GameHost\)

```csharp
public TemporaryNativeStorage(string path, GameHost host = null)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`host` [GameHost](osu.Framework.Platform.GameHost.md)

## Methods

### <a id="osu_Framework_Testing_TemporaryNativeStorage_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

