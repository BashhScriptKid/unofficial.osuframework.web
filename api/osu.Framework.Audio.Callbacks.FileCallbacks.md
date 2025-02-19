# <a id="osu_Framework_Audio_Callbacks_FileCallbacks"></a> Class FileCallbacks

Namespace: [osu.Framework.Audio.Callbacks](osu.Framework.Audio.Callbacks.md)  
Assembly: osu.Framework.dll  

Wrapper on <xref href="ManagedBass.FileProcedures" data-throw-if-not-resolved="false"></xref> to provide functionality in <xref href="osu.Framework.Audio.Callbacks.BassCallback" data-throw-if-not-resolved="false"></xref>.
Can delegate to a class implementing the <xref href="osu.Framework.Audio.Callbacks.IFileProcedures" data-throw-if-not-resolved="false"></xref> interface.

```csharp
public class FileCallbacks : BassCallback, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BassCallback](osu.Framework.Audio.Callbacks.BassCallback.md) ← 
[FileCallbacks](osu.Framework.Audio.Callbacks.FileCallbacks.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[BassCallback.Handle](osu.Framework.Audio.Callbacks.BassCallback.md\#osu\_Framework\_Audio\_Callbacks\_BassCallback\_Handle), 
[BassCallback.Dispose\(bool\)](osu.Framework.Audio.Callbacks.BassCallback.md\#osu\_Framework\_Audio\_Callbacks\_BassCallback\_Dispose\_System\_Boolean\_), 
[BassCallback.Dispose\(\)](osu.Framework.Audio.Callbacks.BassCallback.md\#osu\_Framework\_Audio\_Callbacks\_BassCallback\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FileCallbacks\>\(FileCallbacks?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FileCallbacks\>\(FileCallbacks\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FileCallbacks\>\(FileCallbacks\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FileCallbacks\>\(FileCallbacks\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FileCallbacks, TChild\>\(FileCallbacks, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FileCallbacks, TChild\>\(FileCallbacks, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FileCallbacks, TChild\>\(FileCallbacks, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FileCallbacks\>\(FileCallbacks\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks__ctor_osu_Framework_Audio_Callbacks_IFileProcedures_"></a> FileCallbacks\(IFileProcedures\)

```csharp
public FileCallbacks(IFileProcedures implementation)
```

#### Parameters

`implementation` [IFileProcedures](osu.Framework.Audio.Callbacks.IFileProcedures.md)

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks__ctor_ManagedBass_FileProcedures_"></a> FileCallbacks\(FileProcedures\)

```csharp
public FileCallbacks(FileProcedures procedures)
```

#### Parameters

`procedures` FileProcedures

## Properties

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks_Callbacks"></a> Callbacks

```csharp
public FileProcedures Callbacks { get; }
```

#### Property Value

 FileProcedures

## Methods

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks_Close_System_IntPtr_"></a> Close\(nint\)

```csharp
public void Close(nint user)
```

#### Parameters

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks_Length_System_IntPtr_"></a> Length\(nint\)

```csharp
public long Length(nint user)
```

#### Parameters

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks_Read_System_IntPtr_System_Int32_System_IntPtr_"></a> Read\(nint, int, nint\)

```csharp
public int Read(nint buffer, int length, nint user)
```

#### Parameters

`buffer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Audio_Callbacks_FileCallbacks_Seek_System_Int64_System_IntPtr_"></a> Seek\(long, nint\)

```csharp
public bool Seek(long offset, nint user)
```

#### Parameters

`offset` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

