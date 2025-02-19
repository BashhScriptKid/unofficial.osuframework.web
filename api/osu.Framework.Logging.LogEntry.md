# <a id="osu_Framework_Logging_LogEntry"></a> Class LogEntry

Namespace: [osu.Framework.Logging](osu.Framework.Logging.md)  
Assembly: osu.Framework.dll  

Captures information about a logged message.

```csharp
public class LogEntry
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LogEntry](osu.Framework.Logging.LogEntry.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LogEntry\>\(LogEntry?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LogEntry\>\(LogEntry\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LogEntry\>\(LogEntry\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LogEntry\>\(LogEntry\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LogEntry, TChild\>\(LogEntry, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LogEntry, TChild\>\(LogEntry, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LogEntry, TChild\>\(LogEntry, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LogEntry\>\(LogEntry\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Logging_LogEntry_Exception"></a> Exception

An optional related exception.

```csharp
public Exception Exception
```

#### Field Value

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

### <a id="osu_Framework_Logging_LogEntry_Level"></a> Level

The level for which the message was logged.

```csharp
public LogLevel Level
```

#### Field Value

 [LogLevel](osu.Framework.Logging.LogLevel.md)

### <a id="osu_Framework_Logging_LogEntry_LoggerName"></a> LoggerName

The name of the logger to which this message is being logged, or null if it is being logged to a specific <xref href="osu.Framework.Logging.LoggingTarget" data-throw-if-not-resolved="false"></xref>.

```csharp
public string LoggerName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_LogEntry_Message"></a> Message

The message that was logged.

```csharp
public string Message
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_LogEntry_Target"></a> Target

The target to which this message is being logged, or null if it is being logged to a custom named logger.

```csharp
public LoggingTarget? Target
```

#### Field Value

 [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)?

