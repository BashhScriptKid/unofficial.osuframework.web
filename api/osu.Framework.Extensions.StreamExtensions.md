# <a id="osu_Framework_Extensions_StreamExtensions"></a> Class StreamExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class StreamExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[StreamExtensions](osu.Framework.Extensions.StreamExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Extensions_StreamExtensions_ReadAllBytesToArray_System_IO_Stream_"></a> ReadAllBytesToArray\(Stream\)

Read the full content of a seekable stream.

```csharp
public static byte[] ReadAllBytesToArray(this Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The full byte content.

#### Remarks

For a non-seekable stream, use <xref href="osu.Framework.Extensions.StreamExtensions.ReadAllRemainingBytesToArray(System.IO.Stream)" data-throw-if-not-resolved="false"></xref> instead.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

The <code class="paramref">stream</code> does not allow seeking, or is too long.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadAllBytesToArrayAsync_System_IO_Stream_System_Threading_CancellationToken_"></a> ReadAllBytesToArrayAsync\(Stream, CancellationToken\)

Read the full content of a seekable stream.

```csharp
public static Task<byte[]> ReadAllBytesToArrayAsync(this Stream stream, CancellationToken cancellationToken = default)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The full byte content.

#### Remarks

For a non-seekable stream, use <xref href="osu.Framework.Extensions.StreamExtensions.ReadAllRemainingBytesToArray(System.IO.Stream)" data-throw-if-not-resolved="false"></xref> instead.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

The <code class="paramref">stream</code> does not allow seeking, or is too long.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadAllRemainingBytesToArray_System_IO_Stream_"></a> ReadAllRemainingBytesToArray\(Stream\)

Read all bytes from a non-seekable stream.

```csharp
public static byte[] ReadAllRemainingBytesToArray(this Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The full byte content.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadAllRemainingBytesToArrayAsync_System_IO_Stream_System_Threading_CancellationToken_"></a> ReadAllRemainingBytesToArrayAsync\(Stream, CancellationToken\)

Read all bytes from a non-seekable stream.

```csharp
public static Task<byte[]> ReadAllRemainingBytesToArrayAsync(this Stream stream, CancellationToken cancellationToken = default)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The full byte content.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadBytesToArray_System_IO_Stream_System_Int32_"></a> ReadBytesToArray\(Stream, int\)

Read specified length from current position in stream.

```csharp
public static byte[] ReadBytesToArray(this Stream stream, int length)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The length to read.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The full byte content.

#### Exceptions

 [EndOfStreamException](https://learn.microsoft.com/dotnet/api/system.io.endofstreamexception)

The <code class="paramref">length</code> specified exceeded the available data in the stream.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadBytesToArrayAsync_System_IO_Stream_System_Int32_System_Threading_CancellationToken_"></a> ReadBytesToArrayAsync\(Stream, int, CancellationToken\)

Read the full content of a stream.

```csharp
public static Task<byte[]> ReadBytesToArrayAsync(this Stream stream, int length, CancellationToken cancellationToken = default)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The length to read.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The full byte content.

#### Exceptions

 [EndOfStreamException](https://learn.microsoft.com/dotnet/api/system.io.endofstreamexception)

The <code class="paramref">length</code> specified exceeded the available data in the stream.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadToFill_System_IO_Stream_System_Span_System_Byte__"></a> ReadToFill\(Stream, Span<byte\>\)

Reads bytes from a stream until the provided buffer is full.

```csharp
[Obsolete("Use Stream.ReadExactly")]
public static void ReadToFill(this Stream stream, Span<byte> buffer)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

`buffer` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

The buffer to read into.

#### Exceptions

 [EndOfStreamException](https://learn.microsoft.com/dotnet/api/system.io.endofstreamexception)

Throws if the stream didn't have enough content to fill the buffer.

### <a id="osu_Framework_Extensions_StreamExtensions_ReadToFillAsync_System_IO_Stream_System_Memory_System_Byte__System_Threading_CancellationToken_"></a> ReadToFillAsync\(Stream, Memory<byte\>, CancellationToken\)

Reads bytes from a stream until the provided buffer is full.

```csharp
[Obsolete("Use Stream.ReadExactlyAsync")]
public static Task ReadToFillAsync(this Stream stream, Memory<byte> buffer, CancellationToken cancellationToken = default)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to read.

`buffer` [Memory](https://learn.microsoft.com/dotnet/api/system.memory\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

The buffer to read into.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

#### Exceptions

 [EndOfStreamException](https://learn.microsoft.com/dotnet/api/system.io.endofstreamexception)

Throws if the stream didn't have enough content to fill the buffer.

