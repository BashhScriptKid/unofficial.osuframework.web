# <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand"></a> Class FlakyTestAttribute.FlakyTestCommand

Namespace: [osu.Framework.Tests](osu.Framework.Tests.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class FlakyTestAttribute.FlakyTestCommand : DelegatingTestCommand
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
TestCommand ← 
DelegatingTestCommand ← 
[FlakyTestAttribute.FlakyTestCommand](osu.Framework.Tests.FlakyTestAttribute.FlakyTestCommand.md)

#### Inherited Members

DelegatingTestCommand.innerCommand, 
DelegatingTestCommand.RunTestMethodInThreadAbortSafeZone\(TestExecutionContext, Action\), 
TestCommand.Execute\(TestExecutionContext\), 
TestCommand.Test, 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FlakyTestAttribute.FlakyTestCommand\>\(FlakyTestAttribute.FlakyTestCommand?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FlakyTestAttribute.FlakyTestCommand\>\(FlakyTestAttribute.FlakyTestCommand\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FlakyTestAttribute.FlakyTestCommand\>\(FlakyTestAttribute.FlakyTestCommand\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FlakyTestAttribute.FlakyTestCommand\>\(FlakyTestAttribute.FlakyTestCommand\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FlakyTestAttribute.FlakyTestCommand, TChild\>\(FlakyTestAttribute.FlakyTestCommand, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FlakyTestAttribute.FlakyTestCommand, TChild\>\(FlakyTestAttribute.FlakyTestCommand, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FlakyTestAttribute.FlakyTestCommand, TChild\>\(FlakyTestAttribute.FlakyTestCommand, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FlakyTestAttribute.FlakyTestCommand\>\(FlakyTestAttribute.FlakyTestCommand\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand__ctor_NUnit_Framework_Internal_Commands_TestCommand_System_Int32_"></a> FlakyTestCommand\(TestCommand, int\)

```csharp
public FlakyTestCommand(TestCommand innerCommand, int tryCount)
```

#### Parameters

`innerCommand` TestCommand

`tryCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand__ctor_NUnit_Framework_Internal_Commands_TestCommand_System_Int32_"></a> FlakyTestCommand\(TestCommand, int\)

```csharp
public FlakyTestCommand(TestCommand innerCommand, int tryCount)
```

#### Parameters

`innerCommand` TestCommand

`tryCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand__ctor_NUnit_Framework_Internal_Commands_TestCommand_System_Int32_"></a> FlakyTestCommand\(TestCommand, int\)

```csharp
public FlakyTestCommand(TestCommand innerCommand, int tryCount)
```

#### Parameters

`innerCommand` TestCommand

`tryCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand_Execute_NUnit_Framework_Internal_TestExecutionContext_"></a> Execute\(TestExecutionContext\)

Runs the test in a specified context, returning a TestResult.

```csharp
public override TestResult Execute(TestExecutionContext context)
```

#### Parameters

`context` TestExecutionContext

The TestExecutionContext to be used for running the test.

#### Returns

 TestResult

A TestResult

### <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand_Execute_NUnit_Framework_Internal_TestExecutionContext_"></a> Execute\(TestExecutionContext\)

Runs the test in a specified context, returning a TestResult.

```csharp
public override TestResult Execute(TestExecutionContext context)
```

#### Parameters

`context` TestExecutionContext

The TestExecutionContext to be used for running the test.

#### Returns

 TestResult

A TestResult

### <a id="osu_Framework_Tests_FlakyTestAttribute_FlakyTestCommand_Execute_NUnit_Framework_Internal_TestExecutionContext_"></a> Execute\(TestExecutionContext\)

Runs the test in a specified context, returning a TestResult.

```csharp
public override TestResult Execute(TestExecutionContext context)
```

#### Parameters

`context` TestExecutionContext

The TestExecutionContext to be used for running the test.

#### Returns

 TestResult

A TestResult

