# <a id="osu_Framework_Audio_Callbacks_IFileProcedures"></a> Interface IFileProcedures

Namespace: [osu.Framework.Audio.Callbacks](osu.Framework.Audio.Callbacks.md)  
Assembly: osu.Framework.dll  

Interface that closely matches the definition of the <xref href="ManagedBass.FileProcedures" data-throw-if-not-resolved="false"></xref> struct.

```csharp
public interface IFileProcedures
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IFileProcedures\>\(IFileProcedures?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IFileProcedures\>\(IFileProcedures\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IFileProcedures\>\(IFileProcedures\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IFileProcedures\>\(IFileProcedures\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IFileProcedures, TChild\>\(IFileProcedures, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IFileProcedures, TChild\>\(IFileProcedures, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IFileProcedures, TChild\>\(IFileProcedures, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IFileProcedures\>\(IFileProcedures\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Audio_Callbacks_IFileProcedures_Close_System_IntPtr_"></a> Close\(nint\)

```csharp
void Close(nint user)
```

#### Parameters

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Audio_Callbacks_IFileProcedures_Length_System_IntPtr_"></a> Length\(nint\)

```csharp
long Length(nint user)
```

#### Parameters

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Audio_Callbacks_IFileProcedures_Read_System_IntPtr_System_Int32_System_IntPtr_"></a> Read\(nint, int, nint\)

```csharp
int Read(nint buffer, int length, nint user)
```

#### Parameters

`buffer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Audio_Callbacks_IFileProcedures_Seek_System_Int64_System_IntPtr_"></a> Seek\(long, nint\)

```csharp
bool Seek(long offset, nint user)
```

#### Parameters

`offset` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`user` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

