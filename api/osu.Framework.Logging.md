# <a id="osu_Framework_Logging"></a> Namespace osu.Framework.Logging

### Classes

 [LogEntry](osu.Framework.Logging.LogEntry.md)

Captures information about a logged message.

 [Logger](osu.Framework.Logging.Logger.md)

This class allows statically (globally) configuring and using logging functionality.

 [ThrowingTraceListener](osu.Framework.Logging.ThrowingTraceListener.md)

A <xref href="System.Diagnostics.TraceListener" data-throw-if-not-resolved="false"></xref> that throws exceptions when a trace is hit.
This allows consistent behaviour across runtimes (ie. under Mono where no winforms dialog is displayed on encountering an exception).

### Enums

 [LogLevel](osu.Framework.Logging.LogLevel.md)

The level on which a log-message is logged.

 [LoggingTarget](osu.Framework.Logging.LoggingTarget.md)

The target for logging. Different targets can have different logfiles, are displayed differently in the LogOverlay and are generally useful for organizing logs into groups.

