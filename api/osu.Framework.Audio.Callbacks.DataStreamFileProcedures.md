# <a id="osu_Framework_Audio_Callbacks_DataStreamFileProcedures"></a> Class DataStreamFileProcedures

Namespace: [osu.Framework.Audio.Callbacks](osu.Framework.Audio.Callbacks.md)  
Assembly: osu.Framework.dll  

Implementation of <xref href="osu.Framework.Audio.Callbacks.IFileProcedures" data-throw-if-not-resolved="false"></xref> that supports reading from a <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref>.

```csharp
public class DataStreamFileProcedures : IFileProcedures
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DataStreamFileProcedures](osu.Framework.Audio.Callbacks.DataStreamFileProcedures.md)

#### Implements

[IFileProcedures](osu.Framework.Audio.Callbacks.IFileProcedures.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DataStreamFileProcedures\>\(DataStreamFileProcedures?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DataStreamFileProcedures\>\(DataStreamFileProcedures\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DataStreamFileProcedures\>\(DataStreamFileProcedures\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DataStreamFileProcedures\>\(DataStreamFileProcedures\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DataStreamFileProcedures, TChild\>\(DataStreamFileProcedures, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DataStreamFileProcedures, TChild\>\(DataStreamFileProcedures, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DataStreamFileProcedures, TChild\>\(DataStreamFileProcedures, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DataStreamFileProcedures\>\(DataStreamFileProcedures\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Callbacks_DataStreamFileProcedures__ctor_System_IO_Stream_"></a> DataStreamFileProcedures\(Stream\)

```csharp
public DataStreamFileProcedures(Stream data)
```

#### Parameters

`data` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

## Methods

### <a id="osu_Framework_Audio_Callbacks_DataStreamFileProcedures_Close_System_IntPtr_"></a> Close\(nint\)

```csharp
public void Close(nint user)
```

#### Parameters

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Audio_Callbacks_DataStreamFileProcedures_Length_System_IntPtr_"></a> Length\(nint\)

```csharp
public long Length(nint user)
```

#### Parameters

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Audio_Callbacks_DataStreamFileProcedures_Read_System_IntPtr_System_Int32_System_IntPtr_"></a> Read\(nint, int, nint\)

```csharp
public int Read(nint buffer, int length, nint user)
```

#### Parameters

`buffer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Audio_Callbacks_DataStreamFileProcedures_Seek_System_Int64_System_IntPtr_"></a> Seek\(long, nint\)

```csharp
public bool Seek(long offset, nint user)
```

#### Parameters

`offset` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

