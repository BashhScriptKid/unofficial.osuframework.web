# <a id="osu_Framework_Platform_NativeStorage"></a> Class NativeStorage

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public class NativeStorage : Storage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Storage](osu.Framework.Platform.Storage.md) ← 
[NativeStorage](osu.Framework.Platform.NativeStorage.md)

#### Derived

[DesktopStorage](osu.Framework.Platform.DesktopStorage.md), 
[TemporaryNativeStorage](osu.Framework.Testing.TemporaryNativeStorage.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<NativeStorage\>\(NativeStorage?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<NativeStorage\>\(NativeStorage\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<NativeStorage\>\(NativeStorage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<NativeStorage\>\(NativeStorage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<NativeStorage, TChild\>\(NativeStorage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<NativeStorage, TChild\>\(NativeStorage, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<NativeStorage, TChild\>\(NativeStorage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<NativeStorage\>\(NativeStorage\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_NativeStorage__ctor_System_String_osu_Framework_Platform_GameHost_"></a> NativeStorage\(string, GameHost\)

```csharp
public NativeStorage(string path, GameHost host = null)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`host` [GameHost](osu.Framework.Platform.GameHost.md)

## Methods

### <a id="osu_Framework_Platform_NativeStorage_Delete_System_String_"></a> Delete\(string\)

Delete a file.

```csharp
public override void Delete(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the file to delete.

### <a id="osu_Framework_Platform_NativeStorage_DeleteDirectory_System_String_"></a> DeleteDirectory\(string\)

Delete a directory and all its contents recursively.

```csharp
public override void DeleteDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the directory to delete.

### <a id="osu_Framework_Platform_NativeStorage_Exists_System_String_"></a> Exists\(string\)

Check whether a file exists at the specified path.

```csharp
public override bool Exists(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a file exists.

### <a id="osu_Framework_Platform_NativeStorage_ExistsDirectory_System_String_"></a> ExistsDirectory\(string\)

Check whether a directory exists at the specified path.

```csharp
public override bool ExistsDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a directory exists.

### <a id="osu_Framework_Platform_NativeStorage_GetDirectories_System_String_"></a> GetDirectories\(string\)

Retrieve a list of directories at the specified path.

```csharp
public override IEnumerable<string> GetDirectories(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to list.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

A list of directories in the path, relative to the path of this storage.

### <a id="osu_Framework_Platform_NativeStorage_GetFiles_System_String_System_String_"></a> GetFiles\(string, string\)

Retrieve a list of files at the specified path.

```csharp
public override IEnumerable<string> GetFiles(string path, string pattern = "*")
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to list.

`pattern` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional search pattern. Accepts "*" wildcard.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

A list of files in the path, relative to the path of this storage.

### <a id="osu_Framework_Platform_NativeStorage_GetFullPath_System_String_System_Boolean_"></a> GetFullPath\(string, bool\)

Get a usable filesystem path for the provided incomplete path.

```csharp
public override string GetFullPath(string path, bool createIfNotExisting = false)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

An incomplete path, usually provided as user input.

`createIfNotExisting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Create the path if it doesn't already exist.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A usable filesystem path.

### <a id="osu_Framework_Platform_NativeStorage_GetStorageForDirectory_System_String_"></a> GetStorageForDirectory\(string\)

Retrieve a <xref href="osu.Framework.Platform.Storage" data-throw-if-not-resolved="false"></xref> for a contained directory.
Creates the path if not existing.

```csharp
public override Storage GetStorageForDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The subdirectory to use as a root.

#### Returns

 [Storage](osu.Framework.Platform.Storage.md)

A more specific storage.

### <a id="osu_Framework_Platform_NativeStorage_GetStream_System_String_System_IO_FileAccess_System_IO_FileMode_"></a> GetStream\(string, FileAccess, FileMode\)

Retrieve a stream from an underlying file inside this storage.

```csharp
public override Stream GetStream(string path, FileAccess access = FileAccess.Read, FileMode mode = FileMode.OpenOrCreate)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the file.

`access` [FileAccess](https://learn.microsoft.com/dotnet/api/system.io.fileaccess)

The access requirements.

`mode` [FileMode](https://learn.microsoft.com/dotnet/api/system.io.filemode)

The mode in which the file should be opened.

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

A stream associated with the requested path.

### <a id="osu_Framework_Platform_NativeStorage_Move_System_String_System_String_"></a> Move\(string, string\)

Move a file from one location to another. File must exist. Destination will be overwritten if exists.

```csharp
public override void Move(string from, string to)
```

#### Parameters

`from` [string](https://learn.microsoft.com/dotnet/api/system.string)

The file path to move.

`to` [string](https://learn.microsoft.com/dotnet/api/system.string)

The destination path.

### <a id="osu_Framework_Platform_NativeStorage_OpenFileExternally_System_String_"></a> OpenFileExternally\(string\)

Requests that a file be opened externally with an associated application, if available.

```csharp
public override bool OpenFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The relative path to the file which should be opened.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully opened.

### <a id="osu_Framework_Platform_NativeStorage_PresentFileExternally_System_String_"></a> PresentFileExternally\(string\)

Requests to present a file externally in the platform's native file browser.

```csharp
public override bool PresentFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

Relative path to the file.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully presented.

#### Remarks

This will open the parent folder and, (if available) highlight the file.

