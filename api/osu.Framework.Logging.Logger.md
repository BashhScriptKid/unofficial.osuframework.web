# <a id="osu_Framework_Logging_Logger"></a> Class Logger

Namespace: [osu.Framework.Logging](osu.Framework.Logging.md)  
Assembly: osu.Framework.dll  

This class allows statically (globally) configuring and using logging functionality.

```csharp
public class Logger
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Logger](osu.Framework.Logging.Logger.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Logger\>\(Logger?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Logger\>\(Logger\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Logger\>\(Logger\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Logger\>\(Logger\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Logger, TChild\>\(Logger, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Logger, TChild\>\(Logger, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Logger, TChild\>\(Logger, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Logger\>\(Logger\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Logging_Logger_Enabled"></a> Enabled

Whether logging is enabled. Setting this to false will disable all logging.

```csharp
public static bool Enabled
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Logging_Logger_GameIdentifier"></a> GameIdentifier

An identifier for the game written to log file headers to indicate where the log file came from.

```csharp
public static string GameIdentifier
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_Logger_Level"></a> Level

The minimum log-level a logged message needs to have to be logged. Default is <xref href="osu.Framework.Logging.LogLevel.Verbose" data-throw-if-not-resolved="false"></xref>. Please note that setting this to <xref href="osu.Framework.Logging.LogLevel.Debug" data-throw-if-not-resolved="false"></xref>  will log input events, including keypresses when entering a password.

```csharp
public static LogLevel Level
```

#### Field Value

 [LogLevel](osu.Framework.Logging.LogLevel.md)

### <a id="osu_Framework_Logging_Logger_VersionIdentifier"></a> VersionIdentifier

An identifier for the version written to log file headers to indicate where the log file came from.

```csharp
public static string VersionIdentifier
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_Logging_Logger_Filename"></a> Filename

Gets the name of the file that this logger is logging to.

```csharp
public string Filename { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_Logger_Name"></a> Name

The name of the logger.

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_Logger_OutputToListeners"></a> OutputToListeners

Whether the output of this logger should be sent to listeners of <xref href="osu.Framework.Logging.Logger.Debug(System.String)" data-throw-if-not-resolved="false"></xref> and <xref href="System.Console" data-throw-if-not-resolved="false"></xref>.
Defaults to true.

```csharp
public bool OutputToListeners { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Logging_Logger_Storage"></a> Storage

The storage to place logs inside.

```csharp
public static Storage Storage { get; set; }
```

#### Property Value

 [Storage](osu.Framework.Platform.Storage.md)

### <a id="osu_Framework_Logging_Logger_Target"></a> Target

The target for which this logger logs information. This will only be null if the logger has a name.

```csharp
public LoggingTarget? Target { get; }
```

#### Property Value

 [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)?

### <a id="osu_Framework_Logging_Logger_TotalLogOperations"></a> TotalLogOperations

```csharp
public int TotalLogOperations { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Logging_Logger_Add_System_String_osu_Framework_Logging_LogLevel_System_Exception_System_Boolean_"></a> Add\(string, LogLevel, Exception, bool\)

Log an arbitrary string to current log.

```csharp
public void Add(string message = "", LogLevel level = LogLevel.Verbose, Exception exception = null, bool outputToListeners = true)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message to log. Can include newline (\n) characters to split into multiple lines.

`level` [LogLevel](osu.Framework.Logging.LogLevel.md)

The verbosity level.

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

An optional related exception.

`outputToListeners` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the message should be sent to listeners of <xref href="osu.Framework.Logging.Logger.Debug(System.String)" data-throw-if-not-resolved="false"></xref> and <xref href="System.Console" data-throw-if-not-resolved="false"></xref>. True by default.

### <a id="osu_Framework_Logging_Logger_AddFilteredText_System_String_"></a> AddFilteredText\(string\)

Add a plain-text phrase which should always be filtered from logs. The filtered phrase will be replaced with asterisks (*).
Useful for avoiding logging of credentials.
See also <xref href="osu.Framework.Logging.Logger.ApplyFilters(System.String)" data-throw-if-not-resolved="false"></xref>.

```csharp
public static void AddFilteredText(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_Logger_ApplyFilters_System_String_"></a> ApplyFilters\(string\)

Removes phrases which should be filtered from logs.
Useful for avoiding logging of credentials.
See also <xref href="osu.Framework.Logging.Logger.AddFilteredText(System.String)" data-throw-if-not-resolved="false"></xref>.

```csharp
public static string ApplyFilters(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Logging_Logger_Debug_System_String_"></a> Debug\(string\)

Logs a new message with the <xref href="osu.Framework.Logging.LogLevel.Debug" data-throw-if-not-resolved="false"></xref> and will only be logged if your project is built in the Debug configuration. Please note that the default setting for <xref href="osu.Framework.Logging.Logger.Level" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Logging.LogLevel.Verbose" data-throw-if-not-resolved="false"></xref> so unless you increase the <xref href="osu.Framework.Logging.Logger.Level" data-throw-if-not-resolved="false"></xref> to <xref href="osu.Framework.Logging.LogLevel.Debug" data-throw-if-not-resolved="false"></xref> messages printed with this method will not appear in the output.

```csharp
public void Debug(string message = "")
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message that should be logged.

### <a id="osu_Framework_Logging_Logger_Error_System_Exception_System_String_osu_Framework_Logging_LoggingTarget_System_Boolean_"></a> Error\(Exception, string, LoggingTarget, bool\)

Logs the given exception with the given description to the specified logging target.

```csharp
public static void Error(Exception e, string description, LoggingTarget target = LoggingTarget.Runtime, bool recursive = false)
```

#### Parameters

`e` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

The exception that should be logged.

`description` [string](https://learn.microsoft.com/dotnet/api/system.string)

The description of the error that should be logged with the exception.

`target` [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)

The logging target (file).

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the inner exceptions of the given exception <code class="paramref">e</code> should be logged recursively.

### <a id="osu_Framework_Logging_Logger_Error_System_Exception_System_String_System_String_System_Boolean_"></a> Error\(Exception, string, string, bool\)

Logs the given exception with the given description to the logger with the given name.

```csharp
public static void Error(Exception e, string description, string name, bool recursive = false)
```

#### Parameters

`e` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

The exception that should be logged.

`description` [string](https://learn.microsoft.com/dotnet/api/system.string)

The description of the error that should be logged with the exception.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The logger name (file).

`recursive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the inner exceptions of the given exception <code class="paramref">e</code> should be logged recursively.

### <a id="osu_Framework_Logging_Logger_Flush"></a> Flush\(\)

Pause execution until all logger writes have completed and file handles have been closed.

```csharp
public static void Flush()
```

### <a id="osu_Framework_Logging_Logger_GetLogger_osu_Framework_Logging_LoggingTarget_"></a> GetLogger\(LoggingTarget\)

For classes that regularly log to the same target, this method may be preferred over the static Log method.

```csharp
public static Logger GetLogger(LoggingTarget target = LoggingTarget.Runtime)
```

#### Parameters

`target` [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)

The logging target.

#### Returns

 [Logger](osu.Framework.Logging.Logger.md)

The logger responsible for the given logging target.

### <a id="osu_Framework_Logging_Logger_GetLogger_System_String_"></a> GetLogger\(string\)

For classes that regularly log to the same target, this method may be preferred over the static Log method.

```csharp
public static Logger GetLogger(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the custom logger.

#### Returns

 [Logger](osu.Framework.Logging.Logger.md)

The logger responsible for the given logging target.

### <a id="osu_Framework_Logging_Logger_Log_System_String_osu_Framework_Logging_LoggingTarget_osu_Framework_Logging_LogLevel_System_Boolean_"></a> Log\(string, LoggingTarget, LogLevel, bool\)

Log an arbitrary string to the specified logging target.

```csharp
public static void Log(string message, LoggingTarget target = LoggingTarget.Runtime, LogLevel level = LogLevel.Verbose, bool outputToListeners = true)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message to log. Can include newline (\n) characters to split into multiple lines.

`target` [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)

The logging target (file).

`level` [LogLevel](osu.Framework.Logging.LogLevel.md)

The verbosity level.

`outputToListeners` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the message should be sent to listeners of <xref href="osu.Framework.Logging.Logger.Debug(System.String)" data-throw-if-not-resolved="false"></xref> and <xref href="System.Console" data-throw-if-not-resolved="false"></xref>. True by default.

### <a id="osu_Framework_Logging_Logger_Log_System_String_System_String_osu_Framework_Logging_LogLevel_System_Boolean_"></a> Log\(string, string, LogLevel, bool\)

Log an arbitrary string to the logger with the given name.

```csharp
public static void Log(string message, string name, LogLevel level = LogLevel.Verbose, bool outputToListeners = true)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message to log. Can include newline (\n) characters to split into multiple lines.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The logger name (file).

`level` [LogLevel](osu.Framework.Logging.LogLevel.md)

The verbosity level.

`outputToListeners` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the message should be sent to listeners of <xref href="osu.Framework.Logging.Logger.Debug(System.String)" data-throw-if-not-resolved="false"></xref> and <xref href="System.Console" data-throw-if-not-resolved="false"></xref>. True by default.

### <a id="osu_Framework_Logging_Logger_LogPrint_System_String_osu_Framework_Logging_LoggingTarget_osu_Framework_Logging_LogLevel_"></a> LogPrint\(string, LoggingTarget, LogLevel\)

Logs a message to the specified logging target and also displays a print statement.

```csharp
public static void LogPrint(string message, LoggingTarget target = LoggingTarget.Runtime, LogLevel level = LogLevel.Verbose)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message to log. Can include newline (\n) characters to split into multiple lines.

`target` [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)

The logging target (file).

`level` [LogLevel](osu.Framework.Logging.LogLevel.md)

The verbosity level.

### <a id="osu_Framework_Logging_Logger_LogPrint_System_String_System_String_osu_Framework_Logging_LogLevel_"></a> LogPrint\(string, string, LogLevel\)

Logs a message to the logger with the given name and also displays a print statement.

```csharp
public static void LogPrint(string message, string name, LogLevel level = LogLevel.Verbose)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The message to log. Can include newline (\n) characters to split into multiple lines.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The logger name (file).

`level` [LogLevel](osu.Framework.Logging.LogLevel.md)

The verbosity level.

### <a id="osu_Framework_Logging_Logger_NewEntry"></a> NewEntry

Fires whenever any logger tries to log a new entry, but before the entry is actually written to the logfile.

```csharp
public static event Action<LogEntry> NewEntry
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[LogEntry](osu.Framework.Logging.LogEntry.md)\>

