# <a id="osu_Framework_Extensions_ExceptionExtensions_ExceptionExtensions"></a> Class ExceptionExtensions

Namespace: [osu.Framework.Extensions.ExceptionExtensions](osu.Framework.Extensions.ExceptionExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class ExceptionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ExceptionExtensions](osu.Framework.Extensions.ExceptionExtensions.ExceptionExtensions.md)

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

### <a id="osu_Framework_Extensions_ExceptionExtensions_ExceptionExtensions_AsSingular_System_AggregateException_"></a> AsSingular\(AggregateException\)

Flattens <code class="paramref">aggregateException</code> into a singular <xref href="System.Exception" data-throw-if-not-resolved="false"></xref> if the <code class="paramref">aggregateException</code>
contains only a single <xref href="System.Exception" data-throw-if-not-resolved="false"></xref>. Otherwise, returns <code class="paramref">aggregateException</code>.

```csharp
public static Exception AsSingular(this AggregateException aggregateException)
```

#### Parameters

`aggregateException` [AggregateException](https://learn.microsoft.com/dotnet/api/system.aggregateexception)

The captured exception.

#### Returns

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

The highest level of flattening possible.

### <a id="osu_Framework_Extensions_ExceptionExtensions_ExceptionExtensions_GetLastInvocation_System_Reflection_TargetInvocationException_"></a> GetLastInvocation\(TargetInvocationException\)

Retrieves the last exception from a recursive <xref href="System.Reflection.TargetInvocationException" data-throw-if-not-resolved="false"></xref>.

```csharp
public static Exception GetLastInvocation(this TargetInvocationException exception)
```

#### Parameters

`exception` [TargetInvocationException](https://learn.microsoft.com/dotnet/api/system.reflection.targetinvocationexception)

The exception to retrieve the exception from.

#### Returns

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

The exception at the point of invocation.

### <a id="osu_Framework_Extensions_ExceptionExtensions_ExceptionExtensions_Rethrow_System_Exception_"></a> Rethrow\(Exception\)

Rethrows <code class="paramref">exception</code> as if it was captured in the current context.
This preserves the stack trace of <code class="paramref">exception</code>, and will not include the point of rethrow.

```csharp
public static void Rethrow(this Exception exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

The captured exception.

### <a id="osu_Framework_Extensions_ExceptionExtensions_ExceptionExtensions_RethrowAsSingular_System_AggregateException_"></a> RethrowAsSingular\(AggregateException\)

Rethrows the <xref href="System.Exception.InnerException" data-throw-if-not-resolved="false"></xref> of an <xref href="System.AggregateException" data-throw-if-not-resolved="false"></xref> if it exists,
otherwise, rethrows <code class="paramref">aggregateException</code>.
This preserves the stack trace of the exception that is rethrown, and will not include the point of rethrow.

```csharp
public static void RethrowAsSingular(this AggregateException aggregateException)
```

#### Parameters

`aggregateException` [AggregateException](https://learn.microsoft.com/dotnet/api/system.aggregateexception)

The captured exception.

