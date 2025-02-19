# <a id="osu_Framework_Development_ThreadSafety"></a> Class ThreadSafety

Namespace: [osu.Framework.Development](osu.Framework.Development.md)  
Assembly: osu.Framework.dll  

Utilities to ensure correct thread usage throughout a game.

```csharp
public static class ThreadSafety
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ThreadSafety](osu.Framework.Development.ThreadSafety.md)

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

### <a id="osu_Framework_Development_ThreadSafety_IsAudioThread"></a> IsAudioThread

Whether the current code is executing on the audio thread.

```csharp
public static bool IsAudioThread { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Development_ThreadSafety_IsDrawThread"></a> IsDrawThread

Whether the current code is executing on the draw thread.

```csharp
public static bool IsDrawThread { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Development_ThreadSafety_IsInputThread"></a> IsInputThread

Whether the current code is executing on the input thread.

```csharp
public static bool IsInputThread { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Development_ThreadSafety_IsUpdateThread"></a> IsUpdateThread

Whether the current code is executing on the update thread.

```csharp
public static bool IsUpdateThread { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

