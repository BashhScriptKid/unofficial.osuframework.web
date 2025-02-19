# <a id="osu_Framework_Platform_Storage"></a> Class Storage

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Storage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Storage](osu.Framework.Platform.Storage.md)

#### Derived

[NativeStorage](osu.Framework.Platform.NativeStorage.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Storage\>\(Storage?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Storage\>\(Storage\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Storage\>\(Storage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Storage\>\(Storage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Storage, TChild\>\(Storage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Storage, TChild\>\(Storage, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Storage, TChild\>\(Storage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Storage\>\(Storage\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_Storage__ctor_System_String_System_String_"></a> Storage\(string, string\)

```csharp
protected Storage(string path, string subfolder = null)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`subfolder` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_Platform_Storage_BasePath"></a> BasePath

```csharp
protected string BasePath { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Platform_Storage_CreateFileSafely_System_String_"></a> CreateFileSafely\(string\)

Create a new file on disk, using a temporary file to write to before moving to the final location to ensure a half-written file cannot exist at the specified location.

```csharp
[Pure]
public Stream CreateFileSafely(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the file to create or overwrite.

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

A stream associated with the requested path. Will only exist at the specified location after the stream is disposed.

#### Remarks

If the target file path already exists, it will be deleted before attempting to write a new version.

### <a id="osu_Framework_Platform_Storage_Delete_System_String_"></a> Delete\(string\)

Delete a file.

```csharp
public abstract void Delete(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the file to delete.

### <a id="osu_Framework_Platform_Storage_DeleteDirectory_System_String_"></a> DeleteDirectory\(string\)

Delete a directory and all its contents recursively.

```csharp
public abstract void DeleteDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the directory to delete.

### <a id="osu_Framework_Platform_Storage_Exists_System_String_"></a> Exists\(string\)

Check whether a file exists at the specified path.

```csharp
public abstract bool Exists(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a file exists.

### <a id="osu_Framework_Platform_Storage_ExistsDirectory_System_String_"></a> ExistsDirectory\(string\)

Check whether a directory exists at the specified path.

```csharp
public abstract bool ExistsDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a directory exists.

### <a id="osu_Framework_Platform_Storage_GetDirectories_System_String_"></a> GetDirectories\(string\)

Retrieve a list of directories at the specified path.

```csharp
public abstract IEnumerable<string> GetDirectories(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to list.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

A list of directories in the path, relative to the path of this storage.

### <a id="osu_Framework_Platform_Storage_GetFiles_System_String_System_String_"></a> GetFiles\(string, string\)

Retrieve a list of files at the specified path.

```csharp
public abstract IEnumerable<string> GetFiles(string path, string pattern = "*")
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to list.

`pattern` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional search pattern. Accepts "*" wildcard.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

A list of files in the path, relative to the path of this storage.

### <a id="osu_Framework_Platform_Storage_GetFullPath_System_String_System_Boolean_"></a> GetFullPath\(string, bool\)

Get a usable filesystem path for the provided incomplete path.

```csharp
public abstract string GetFullPath(string path, bool createIfNotExisting = false)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

An incomplete path, usually provided as user input.

`createIfNotExisting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Create the path if it doesn't already exist.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A usable filesystem path.

### <a id="osu_Framework_Platform_Storage_GetStorageForDirectory_System_String_"></a> GetStorageForDirectory\(string\)

Retrieve a <xref href="osu.Framework.Platform.Storage" data-throw-if-not-resolved="false"></xref> for a contained directory.
Creates the path if not existing.

```csharp
public virtual Storage GetStorageForDirectory(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The subdirectory to use as a root.

#### Returns

 [Storage](osu.Framework.Platform.Storage.md)

A more specific storage.

### <a id="osu_Framework_Platform_Storage_GetStream_System_String_System_IO_FileAccess_System_IO_FileMode_"></a> GetStream\(string, FileAccess, FileMode\)

Retrieve a stream from an underlying file inside this storage.

```csharp
[Pure]
public abstract Stream GetStream(string path, FileAccess access = FileAccess.Read, FileMode mode = FileMode.OpenOrCreate)
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

### <a id="osu_Framework_Platform_Storage_Move_System_String_System_String_"></a> Move\(string, string\)

Move a file from one location to another. File must exist. Destination will be overwritten if exists.

```csharp
public abstract void Move(string from, string to)
```

#### Parameters

`from` [string](https://learn.microsoft.com/dotnet/api/system.string)

The file path to move.

`to` [string](https://learn.microsoft.com/dotnet/api/system.string)

The destination path.

### <a id="osu_Framework_Platform_Storage_OpenFileExternally_System_String_"></a> OpenFileExternally\(string\)

Requests that a file be opened externally with an associated application, if available.

```csharp
public abstract bool OpenFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The relative path to the file which should be opened.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully opened.

### <a id="osu_Framework_Platform_Storage_PresentExternally"></a> PresentExternally\(\)

Opens a native file browser window to the root path of this storage.

```csharp
public bool PresentExternally()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the storage was successfully presented.

### <a id="osu_Framework_Platform_Storage_PresentFileExternally_System_String_"></a> PresentFileExternally\(string\)

Requests to present a file externally in the platform's native file browser.

```csharp
public abstract bool PresentFileExternally(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

Relative path to the file.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the file was successfully presented.

#### Remarks

This will open the parent folder and, (if available) highlight the file.

