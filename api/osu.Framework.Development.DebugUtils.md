# <a id="osu_Framework_Development_DebugUtils"></a> Class DebugUtils

Namespace: [osu.Framework.Development](osu.Framework.Development.md)  
Assembly: osu.Framework.dll  

```csharp
public static class DebugUtils
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DebugUtils](osu.Framework.Development.DebugUtils.md)

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

## Properties

### <a id="osu_Framework_Development_DebugUtils_IsDebugBuild"></a> IsDebugBuild

```csharp
public static bool IsDebugBuild { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Development_DebugUtils_IsNUnitRunning"></a> IsNUnitRunning

```csharp
public static bool IsNUnitRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Development_DebugUtils_LogPerformanceIssues"></a> LogPerformanceIssues

Whether the framework is currently logging performance issues.
This should be used only when a configuration is not available via DI or otherwise (ie. in a static context).

```csharp
public static bool LogPerformanceIssues { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

