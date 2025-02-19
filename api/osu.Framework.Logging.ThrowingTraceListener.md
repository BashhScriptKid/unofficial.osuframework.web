# <a id="osu_Framework_Logging_ThrowingTraceListener"></a> Class ThrowingTraceListener

Namespace: [osu.Framework.Logging](osu.Framework.Logging.md)  
Assembly: osu.Framework.dll  

A <xref href="System.Diagnostics.TraceListener" data-throw-if-not-resolved="false"></xref> that throws exceptions when a trace is hit.
This allows consistent behaviour across runtimes (ie. under Mono where no winforms dialog is displayed on encountering an exception).

```csharp
public class ThrowingTraceListener : TraceListener, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarshalByRefObject](https://learn.microsoft.com/dotnet/api/system.marshalbyrefobject) ← 
[TraceListener](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener) ← 
[ThrowingTraceListener](osu.Framework.Logging.ThrowingTraceListener.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[TraceListener.Close\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.close), 
[TraceListener.Dispose\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.dispose\#system\-diagnostics\-tracelistener\-dispose), 
[TraceListener.Dispose\(bool\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.dispose\#system\-diagnostics\-tracelistener\-dispose\(system\-boolean\)), 
[TraceListener.Fail\(string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.fail\#system\-diagnostics\-tracelistener\-fail\(system\-string\)), 
[TraceListener.Fail\(string?, string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.fail\#system\-diagnostics\-tracelistener\-fail\(system\-string\-system\-string\)), 
[TraceListener.Flush\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.flush), 
[TraceListener.GetSupportedAttributes\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.getsupportedattributes), 
[TraceListener.TraceData\(TraceEventCache?, string, TraceEventType, int, object?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.tracedata\#system\-diagnostics\-tracelistener\-tracedata\(system\-diagnostics\-traceeventcache\-system\-string\-system\-diagnostics\-traceeventtype\-system\-int32\-system\-object\)), 
[TraceListener.TraceData\(TraceEventCache?, string, TraceEventType, int, params object?\[\]?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.tracedata\#system\-diagnostics\-tracelistener\-tracedata\(system\-diagnostics\-traceeventcache\-system\-string\-system\-diagnostics\-traceeventtype\-system\-int32\-system\-object\(\)\)), 
[TraceListener.TraceEvent\(TraceEventCache?, string, TraceEventType, int\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.traceevent\#system\-diagnostics\-tracelistener\-traceevent\(system\-diagnostics\-traceeventcache\-system\-string\-system\-diagnostics\-traceeventtype\-system\-int32\)), 
[TraceListener.TraceEvent\(TraceEventCache?, string, TraceEventType, int, string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.traceevent\#system\-diagnostics\-tracelistener\-traceevent\(system\-diagnostics\-traceeventcache\-system\-string\-system\-diagnostics\-traceeventtype\-system\-int32\-system\-string\)), 
[TraceListener.TraceEvent\(TraceEventCache?, string, TraceEventType, int, string?, params object?\[\]?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.traceevent\#system\-diagnostics\-tracelistener\-traceevent\(system\-diagnostics\-traceeventcache\-system\-string\-system\-diagnostics\-traceeventtype\-system\-int32\-system\-string\-system\-object\(\)\)), 
[TraceListener.TraceTransfer\(TraceEventCache?, string, int, string?, Guid\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.tracetransfer), 
[TraceListener.Write\(object?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.write\#system\-diagnostics\-tracelistener\-write\(system\-object\)), 
[TraceListener.Write\(object?, string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.write\#system\-diagnostics\-tracelistener\-write\(system\-object\-system\-string\)), 
[TraceListener.Write\(string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.write\#system\-diagnostics\-tracelistener\-write\(system\-string\)), 
[TraceListener.Write\(string?, string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.write\#system\-diagnostics\-tracelistener\-write\(system\-string\-system\-string\)), 
[TraceListener.WriteIndent\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.writeindent), 
[TraceListener.WriteLine\(object?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.writeline\#system\-diagnostics\-tracelistener\-writeline\(system\-object\)), 
[TraceListener.WriteLine\(object?, string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.writeline\#system\-diagnostics\-tracelistener\-writeline\(system\-object\-system\-string\)), 
[TraceListener.WriteLine\(string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.writeline\#system\-diagnostics\-tracelistener\-writeline\(system\-string\)), 
[TraceListener.WriteLine\(string?, string?\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.writeline\#system\-diagnostics\-tracelistener\-writeline\(system\-string\-system\-string\)), 
[TraceListener.Attributes](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.attributes), 
[TraceListener.Filter](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.filter), 
[TraceListener.IndentLevel](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.indentlevel), 
[TraceListener.IndentSize](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.indentsize), 
[TraceListener.IsThreadSafe](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.isthreadsafe), 
[TraceListener.Name](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.name), 
[TraceListener.NeedIndent](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.needindent), 
[TraceListener.TraceOutputOptions](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelistener.traceoutputoptions), 
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

[ObjectExtensions.AsNonNull<ThrowingTraceListener\>\(ThrowingTraceListener?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ThrowingTraceListener\>\(ThrowingTraceListener\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ThrowingTraceListener\>\(ThrowingTraceListener\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ThrowingTraceListener\>\(ThrowingTraceListener\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ThrowingTraceListener, TChild\>\(ThrowingTraceListener, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ThrowingTraceListener, TChild\>\(ThrowingTraceListener, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ThrowingTraceListener, TChild\>\(ThrowingTraceListener, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ThrowingTraceListener\>\(ThrowingTraceListener\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Logging_ThrowingTraceListener_Fail_System_String_"></a> Fail\(string\)

Emits an error message to the listener you create when you implement the <xref href="System.Diagnostics.TraceListener" data-throw-if-not-resolved="false"></xref> class.

```csharp
public override void Fail(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

A message to emit.

### <a id="osu_Framework_Logging_ThrowingTraceListener_Fail_System_String_System_String_"></a> Fail\(string, string\)

Emits an error message and a detailed error message to the listener you create when you implement the <xref href="System.Diagnostics.TraceListener" data-throw-if-not-resolved="false"></xref> class.

```csharp
public override void Fail(string message1, string message2)
```

#### Parameters

`message1` [string](https://learn.microsoft.com/dotnet/api/system.string)

`message2` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_ThrowingTraceListener_Write_System_String_"></a> Write\(string\)

When overridden in a derived class, writes the specified message to the listener you create in the derived class.

```csharp
public override void Write(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

A message to write.

### <a id="osu_Framework_Logging_ThrowingTraceListener_WriteLine_System_String_"></a> WriteLine\(string\)

When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.

```csharp
public override void WriteLine(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

A message to write.

