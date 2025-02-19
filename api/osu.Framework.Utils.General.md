# <a id="osu_Framework_Utils_General"></a> Class General

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

```csharp
public static class General
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[General](osu.Framework.Utils.General.md)

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

### <a id="osu_Framework_Utils_General_AttemptWithRetryOnException__1_System_Action_System_Int32_System_Boolean_"></a> AttemptWithRetryOnException<TException\>\(Action, int, bool\)

Attempt an operation and perform retries on a matching exception, up to a limit.
Useful for IO operations which can fail for a short period due to an open file handle.

```csharp
public static bool AttemptWithRetryOnException<TException>(this Action action, int attempts = 10, bool throwOnFailure = true) where TException : Exception
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The action to perform.

`attempts` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of attempts (250ms wait between each).

`throwOnFailure` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to throw an exception on failure. If <code>false</code>, will silently fail.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the operation succeeded.

#### Type Parameters

`TException` 

The type of exception which should trigger retries.

