# <a id="osu_Framework_FrameworkEnvironment"></a> Class FrameworkEnvironment

Namespace: [osu.Framework](osu.Framework.md)  
Assembly: osu.Framework.dll  

```csharp
public static class FrameworkEnvironment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FrameworkEnvironment](osu.Framework.FrameworkEnvironment.md)

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

### <a id="osu_Framework_FrameworkEnvironment_AllowInsecureRequests"></a> AllowInsecureRequests

Whether non-SSL requests should be allowed. Debug only. Defaults to disabled.
When disabled, http:// requests will be automatically converted to https://.

```csharp
public static bool AllowInsecureRequests { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_DeferredRendererEventsOutputPath"></a> DeferredRendererEventsOutputPath

```csharp
public static string? DeferredRendererEventsOutputPath { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_FrameworkEnvironment_FailFlakyTests"></a> FailFlakyTests

```csharp
public static bool FailFlakyTests { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_ForceTestGC"></a> ForceTestGC

```csharp
public static bool ForceTestGC { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_FrameStatisticsViaTouch"></a> FrameStatisticsViaTouch

```csharp
public static bool FrameStatisticsViaTouch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_NoStructuredBuffers"></a> NoStructuredBuffers

```csharp
public static bool NoStructuredBuffers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_NoTestTimeout"></a> NoTestTimeout

```csharp
public static bool NoTestTimeout { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_PreferredGraphicsRenderer"></a> PreferredGraphicsRenderer

```csharp
public static string? PreferredGraphicsRenderer { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_FrameworkEnvironment_PreferredGraphicsSurface"></a> PreferredGraphicsSurface

```csharp
public static GraphicsSurfaceType? PreferredGraphicsSurface { get; }
```

#### Property Value

 [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)?

### <a id="osu_Framework_FrameworkEnvironment_StagingBufferType"></a> StagingBufferType

```csharp
public static int? StagingBufferType { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="osu_Framework_FrameworkEnvironment_StartupExecutionMode"></a> StartupExecutionMode

```csharp
public static ExecutionMode? StartupExecutionMode { get; }
```

#### Property Value

 [ExecutionMode](osu.Framework.Platform.ExecutionMode.md)?

### <a id="osu_Framework_FrameworkEnvironment_UseSDL3"></a> UseSDL3

```csharp
public static bool UseSDL3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_FrameworkEnvironment_VertexBufferCount"></a> VertexBufferCount

```csharp
public static int? VertexBufferCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

