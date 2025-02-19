# <a id="osu_Framework_Utils_ThrowHelper"></a> Class ThrowHelper

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

Helper class for throwing exceptions in isolated methods, for cases where method inlining is beneficial.
As throwing directly in that case causes JIT to disable inlining on the surrounding method.

```csharp
public static class ThrowHelper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ThrowHelper](osu.Framework.Utils.ThrowHelper.md)

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

### <a id="osu_Framework_Utils_ThrowHelper_ThrowInvalidOperationException_System_String_"></a> ThrowInvalidOperationException\(string?\)

```csharp
public static void ThrowInvalidOperationException(string? message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

