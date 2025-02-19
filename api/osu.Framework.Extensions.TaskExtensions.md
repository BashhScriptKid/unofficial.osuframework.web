# <a id="osu_Framework_Extensions_TaskExtensions"></a> Class TaskExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class TaskExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TaskExtensions](osu.Framework.Extensions.TaskExtensions.md)

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

### <a id="osu_Framework_Extensions_TaskExtensions_GetResultSafely__1_System_Threading_Tasks_Task___0__"></a> GetResultSafely<T\>\(Task<T\>\)

Safe alternative to Task.Result which ensures the calling thread is not a thread pool thread.

```csharp
public static T GetResultSafely<T>(this Task<T> task)
```

#### Parameters

`task` [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<T\>

#### Returns

 T

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_TaskExtensions_WaitSafely_System_Threading_Tasks_Task_"></a> WaitSafely\(Task\)

Safe alternative to Task.Wait which ensures the calling thread is not a thread pool thread.

```csharp
public static void WaitSafely(this Task task)
```

#### Parameters

`task` [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

