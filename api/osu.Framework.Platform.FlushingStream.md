# <a id="osu_Framework_Platform_FlushingStream"></a> Class FlushingStream

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

A <xref href="System.IO.FileStream" data-throw-if-not-resolved="false"></xref> which always flushes to disk on disposal.

```csharp
public class FlushingStream : FileStream, IAsyncDisposable, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject) ← 
[Stream](https://learn.microsoft.com/dotnet/api/system.io.stream) ← 
[FileStream](https://learn.microsoft.com/dotnet/api/system.io.filestream) ← 
[FlushingStream](osu.Framework.Platform.FlushingStream.md)

#### Implements

[IAsyncDisposable](https://learn.microsoft.com/dotnet/api/system.iasyncdisposable), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[FileStream.BeginRead\(byte\[\], int, int, AsyncCallback?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.beginread), 
[FileStream.BeginWrite\(byte\[\], int, int, AsyncCallback?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.beginwrite), 
[FileStream.CopyToAsync\(Stream, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.copytoasync), 
[FileStream.Dispose\(bool\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.dispose), 
[FileStream.DisposeAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.disposeasync), 
[FileStream.EndRead\(IAsyncResult\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.endread), 
[FileStream.EndWrite\(IAsyncResult\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.endwrite), 
[FileStream.Flush\(\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.flush\#system\-io\-filestream\-flush), 
[FileStream.Flush\(bool\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.flush\#system\-io\-filestream\-flush\(system\-boolean\)), 
[FileStream.FlushAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.flushasync), 
[FileStream.Lock\(long, long\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.lock), 
[FileStream.Read\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.read\#system\-io\-filestream\-read\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[FileStream.Read\(Span<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.read\#system\-io\-filestream\-read\(system\-span\(\(system\-byte\)\)\)), 
[FileStream.ReadAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.readasync\#system\-io\-filestream\-readasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[FileStream.ReadAsync\(Memory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.readasync\#system\-io\-filestream\-readasync\(system\-memory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[FileStream.ReadByte\(\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.readbyte), 
[FileStream.Seek\(long, SeekOrigin\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.seek), 
[FileStream.SetLength\(long\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.setlength), 
[FileStream.Unlock\(long, long\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.unlock), 
[FileStream.Write\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.write\#system\-io\-filestream\-write\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[FileStream.Write\(ReadOnlySpan<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.write\#system\-io\-filestream\-write\(system\-readonlyspan\(\(system\-byte\)\)\)), 
[FileStream.WriteAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.writeasync\#system\-io\-filestream\-writeasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[FileStream.WriteAsync\(ReadOnlyMemory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.writeasync\#system\-io\-filestream\-writeasync\(system\-readonlymemory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[FileStream.WriteByte\(byte\)](https://learn.microsoft.com/dotnet/api/system.io.filestream.writebyte), 
[FileStream.CanRead](https://learn.microsoft.com/dotnet/api/system.io.filestream.canread), 
[FileStream.CanSeek](https://learn.microsoft.com/dotnet/api/system.io.filestream.canseek), 
[FileStream.CanWrite](https://learn.microsoft.com/dotnet/api/system.io.filestream.canwrite), 
[FileStream.Handle](https://learn.microsoft.com/dotnet/api/system.io.filestream.handle), 
[FileStream.IsAsync](https://learn.microsoft.com/dotnet/api/system.io.filestream.isasync), 
[FileStream.Length](https://learn.microsoft.com/dotnet/api/system.io.filestream.length), 
[FileStream.Name](https://learn.microsoft.com/dotnet/api/system.io.filestream.name), 
[FileStream.Position](https://learn.microsoft.com/dotnet/api/system.io.filestream.position), 
[FileStream.SafeFileHandle](https://learn.microsoft.com/dotnet/api/system.io.filestream.safefilehandle), 
[Stream.Null](https://learn.microsoft.com/dotnet/api/system.io.stream.null), 
[Stream.BeginRead\(byte\[\], int, int, AsyncCallback?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.stream.beginread), 
[Stream.BeginWrite\(byte\[\], int, int, AsyncCallback?, object?\)](https://learn.microsoft.com/dotnet/api/system.io.stream.beginwrite), 
[Stream.Close\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.close), 
[Stream.CopyTo\(Stream\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copyto\#system\-io\-stream\-copyto\(system\-io\-stream\)), 
[Stream.CopyTo\(Stream, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copyto\#system\-io\-stream\-copyto\(system\-io\-stream\-system\-int32\)), 
[Stream.CopyToAsync\(Stream\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\)), 
[Stream.CopyToAsync\(Stream, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\-system\-int32\)), 
[Stream.CopyToAsync\(Stream, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.CopyToAsync\(Stream, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.copytoasync\#system\-io\-stream\-copytoasync\(system\-io\-stream\-system\-threading\-cancellationtoken\)), 
[Stream.CreateWaitHandle\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.createwaithandle), 
[Stream.Dispose\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.dispose\#system\-io\-stream\-dispose), 
[Stream.Dispose\(bool\)](https://learn.microsoft.com/dotnet/api/system.io.stream.dispose\#system\-io\-stream\-dispose\(system\-boolean\)), 
[Stream.DisposeAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.disposeasync), 
[Stream.EndRead\(IAsyncResult\)](https://learn.microsoft.com/dotnet/api/system.io.stream.endread), 
[Stream.EndWrite\(IAsyncResult\)](https://learn.microsoft.com/dotnet/api/system.io.stream.endwrite), 
[Stream.Flush\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.flush), 
[Stream.FlushAsync\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.flushasync\#system\-io\-stream\-flushasync), 
[Stream.FlushAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.flushasync\#system\-io\-stream\-flushasync\(system\-threading\-cancellationtoken\)), 
[Stream.ObjectInvariant\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.objectinvariant), 
[Stream.Read\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.read\#system\-io\-stream\-read\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.Read\(Span<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.stream.read\#system\-io\-stream\-read\(system\-span\(\(system\-byte\)\)\)), 
[Stream.ReadAsync\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readasync\#system\-io\-stream\-readasync\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.ReadAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readasync\#system\-io\-stream\-readasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.ReadAsync\(Memory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readasync\#system\-io\-stream\-readasync\(system\-memory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[Stream.ReadAtLeast\(Span<byte\>, int, bool\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readatleast), 
[Stream.ReadAtLeastAsync\(Memory<byte\>, int, bool, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readatleastasync), 
[Stream.ReadByte\(\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readbyte), 
[Stream.ReadExactly\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactly\#system\-io\-stream\-readexactly\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.ReadExactly\(Span<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactly\#system\-io\-stream\-readexactly\(system\-span\(\(system\-byte\)\)\)), 
[Stream.ReadExactlyAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactlyasync\#system\-io\-stream\-readexactlyasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.ReadExactlyAsync\(Memory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.readexactlyasync\#system\-io\-stream\-readexactlyasync\(system\-memory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[Stream.Seek\(long, SeekOrigin\)](https://learn.microsoft.com/dotnet/api/system.io.stream.seek), 
[Stream.SetLength\(long\)](https://learn.microsoft.com/dotnet/api/system.io.stream.setlength), 
[Stream.Synchronized\(Stream\)](https://learn.microsoft.com/dotnet/api/system.io.stream.synchronized), 
[Stream.ValidateBufferArguments\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.validatebufferarguments), 
[Stream.ValidateCopyToArguments\(Stream, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.validatecopytoarguments), 
[Stream.Write\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.write\#system\-io\-stream\-write\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.Write\(ReadOnlySpan<byte\>\)](https://learn.microsoft.com/dotnet/api/system.io.stream.write\#system\-io\-stream\-write\(system\-readonlyspan\(\(system\-byte\)\)\)), 
[Stream.WriteAsync\(byte\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writeasync\#system\-io\-stream\-writeasync\(system\-byte\(\)\-system\-int32\-system\-int32\)), 
[Stream.WriteAsync\(byte\[\], int, int, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writeasync\#system\-io\-stream\-writeasync\(system\-byte\(\)\-system\-int32\-system\-int32\-system\-threading\-cancellationtoken\)), 
[Stream.WriteAsync\(ReadOnlyMemory<byte\>, CancellationToken\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writeasync\#system\-io\-stream\-writeasync\(system\-readonlymemory\(\(system\-byte\)\)\-system\-threading\-cancellationtoken\)), 
[Stream.WriteByte\(byte\)](https://learn.microsoft.com/dotnet/api/system.io.stream.writebyte), 
[Stream.CanRead](https://learn.microsoft.com/dotnet/api/system.io.stream.canread), 
[Stream.CanSeek](https://learn.microsoft.com/dotnet/api/system.io.stream.canseek), 
[Stream.CanTimeout](https://learn.microsoft.com/dotnet/api/system.io.stream.cantimeout), 
[Stream.CanWrite](https://learn.microsoft.com/dotnet/api/system.io.stream.canwrite), 
[Stream.Length](https://learn.microsoft.com/dotnet/api/system.io.stream.length), 
[Stream.Position](https://learn.microsoft.com/dotnet/api/system.io.stream.position), 
[Stream.ReadTimeout](https://learn.microsoft.com/dotnet/api/system.io.stream.readtimeout), 
[Stream.WriteTimeout](https://learn.microsoft.com/dotnet/api/system.io.stream.writetimeout), 
[MarshalByRefObject.GetLifetimeService\(\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.getlifetimeservice), 
[MarshalByRefObject.InitializeLifetimeService\(\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.initializelifetimeservice), 
[MarshalByRefObject.MemberwiseClone\(bool\)](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject.memberwiseclone), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FlushingStream\>\(FlushingStream?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.ComputeMD5Hash\(Stream\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_ComputeMD5Hash\_System\_IO\_Stream\_), 
[ExtensionMethods.ComputeSHA2Hash\(Stream\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_ComputeSHA2Hash\_System\_IO\_Stream\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FlushingStream\>\(FlushingStream\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FlushingStream\>\(FlushingStream\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FlushingStream\>\(FlushingStream\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[StreamExtensions.ReadAllBytesToArray\(Stream\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadAllBytesToArray\_System\_IO\_Stream\_), 
[StreamExtensions.ReadAllBytesToArrayAsync\(Stream, CancellationToken\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadAllBytesToArrayAsync\_System\_IO\_Stream\_System\_Threading\_CancellationToken\_), 
[StreamExtensions.ReadAllRemainingBytesToArray\(Stream\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadAllRemainingBytesToArray\_System\_IO\_Stream\_), 
[StreamExtensions.ReadAllRemainingBytesToArrayAsync\(Stream, CancellationToken\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadAllRemainingBytesToArrayAsync\_System\_IO\_Stream\_System\_Threading\_CancellationToken\_), 
[StreamExtensions.ReadBytesToArray\(Stream, int\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadBytesToArray\_System\_IO\_Stream\_System\_Int32\_), 
[StreamExtensions.ReadBytesToArrayAsync\(Stream, int, CancellationToken\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadBytesToArrayAsync\_System\_IO\_Stream\_System\_Int32\_System\_Threading\_CancellationToken\_), 
[StreamExtensions.ReadToFill\(Stream, Span<byte\>\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadToFill\_System\_IO\_Stream\_System\_Span\_System\_Byte\_\_), 
[StreamExtensions.ReadToFillAsync\(Stream, Memory<byte\>, CancellationToken\)](osu.Framework.Extensions.StreamExtensions.md\#osu\_Framework\_Extensions\_StreamExtensions\_ReadToFillAsync\_System\_IO\_Stream\_System\_Memory\_System\_Byte\_\_System\_Threading\_CancellationToken\_), 
[ContainerExtensions.WithChild<FlushingStream, TChild\>\(FlushingStream, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FlushingStream, TChild\>\(FlushingStream, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FlushingStream, TChild\>\(FlushingStream, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FlushingStream\>\(FlushingStream\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

This adds a considerable overhead, but is required to avoid files being potentially written to disk in a corrupt state.
See https://stackoverflow.com/questions/49260358/what-could-cause-an-xml-file-to-be-filled-with-null-characters/52751216#52751216.

## Constructors

### <a id="osu_Framework_Platform_FlushingStream__ctor_System_String_System_IO_FileMode_System_IO_FileAccess_"></a> FlushingStream\(string, FileMode, FileAccess\)

```csharp
public FlushingStream(string path, FileMode mode, FileAccess access)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`mode` [FileMode](https://learn.microsoft.com/dotnet/api/system.io.filemode)

`access` [FileAccess](https://learn.microsoft.com/dotnet/api/system.io.fileaccess)

## Methods

### <a id="osu_Framework_Platform_FlushingStream_Dispose_System_Boolean_"></a> Dispose\(bool\)

Releases the unmanaged resources used by the <xref href="System.IO.FileStream" data-throw-if-not-resolved="false"></xref> and optionally releases the managed resources.

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to release both managed and unmanaged resources; <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> to release only unmanaged resources.

