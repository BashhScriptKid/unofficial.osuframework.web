# <a id="osu_Framework_Host"></a> Class Host

Namespace: [osu.Framework](osu.Framework.md)  
Assembly: osu.Framework.dll  

```csharp
public static class Host
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Host](osu.Framework.Host.md)

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

### <a id="osu_Framework_Host_GetSuitableDesktopHost_System_String_osu_Framework_HostOptions_"></a> GetSuitableDesktopHost\(string, HostOptions\)

```csharp
public static DesktopGameHost GetSuitableDesktopHost(string gameName, HostOptions hostOptions = null)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`hostOptions` [HostOptions](osu.Framework.HostOptions.md)

#### Returns

 [DesktopGameHost](osu.Framework.Platform.DesktopGameHost.md)

