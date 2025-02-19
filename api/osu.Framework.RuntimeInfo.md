# <a id="osu_Framework_RuntimeInfo"></a> Class RuntimeInfo

Namespace: [osu.Framework](osu.Framework.md)  
Assembly: osu.Framework.dll  

```csharp
public static class RuntimeInfo
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RuntimeInfo](osu.Framework.RuntimeInfo.md)

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

### <a id="osu_Framework_RuntimeInfo_EntryAssembly"></a> EntryAssembly

Gets the entry assembly.
When running under NUnit, the assembly of the current test will be returned instead.

```csharp
public static Assembly EntryAssembly { get; }
```

#### Property Value

 [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

### <a id="osu_Framework_RuntimeInfo_IsApple"></a> IsApple

```csharp
public static bool IsApple { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_RuntimeInfo_IsDesktop"></a> IsDesktop

```csharp
public static bool IsDesktop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_RuntimeInfo_IsMobile"></a> IsMobile

```csharp
public static bool IsMobile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_RuntimeInfo_IsUnix"></a> IsUnix

```csharp
public static bool IsUnix { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_RuntimeInfo_OS"></a> OS

```csharp
public static RuntimeInfo.Platform OS { get; }
```

#### Property Value

 [RuntimeInfo](osu.Framework.RuntimeInfo.md).[Platform](osu.Framework.RuntimeInfo.Platform.md)

### <a id="osu_Framework_RuntimeInfo_StartupDirectory"></a> StartupDirectory

The absolute path to the startup directory of this game.

```csharp
public static string StartupDirectory { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_RuntimeInfo_GetFrameworkAssemblyPath"></a> GetFrameworkAssemblyPath\(\)

Returns the absolute path of osu.Framework.dll.

```csharp
public static string GetFrameworkAssemblyPath()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

