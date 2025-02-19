# <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest"></a> Class HeadlessGameHostTest

Namespace: [osu.Framework.Tests.Platform](osu.Framework.Tests.Platform.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class HeadlessGameHostTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HeadlessGameHostTest](osu.Framework.Tests.Platform.HeadlessGameHostTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HeadlessGameHostTest\>\(HeadlessGameHostTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HeadlessGameHostTest\>\(HeadlessGameHostTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HeadlessGameHostTest\>\(HeadlessGameHostTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HeadlessGameHostTest\>\(HeadlessGameHostTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HeadlessGameHostTest, TChild\>\(HeadlessGameHostTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HeadlessGameHostTest, TChild\>\(HeadlessGameHostTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HeadlessGameHostTest, TChild\>\(HeadlessGameHostTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HeadlessGameHostTest\>\(HeadlessGameHostTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostDisposalWhenNeverRun"></a> TestGameHostDisposalWhenNeverRun\(\)

```csharp
[Test]
public void TestGameHostDisposalWhenNeverRun()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostDisposalWhenNeverRun"></a> TestGameHostDisposalWhenNeverRun\(\)

```csharp
[Test]
public void TestGameHostDisposalWhenNeverRun()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostDisposalWhenNeverRun"></a> TestGameHostDisposalWhenNeverRun\(\)

```csharp
[Test]
public void TestGameHostDisposalWhenNeverRun()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostExceptionDuringAsynchronousChildLoad"></a> TestGameHostExceptionDuringAsynchronousChildLoad\(\)

<xref href="osu.Framework.Platform.GameHost.PerformExit(System.Boolean)" data-throw-if-not-resolved="false"></xref> is virtual, but there are some cases where exit is mandatory.
This aims to test that shutdown from an exception firing (ie. the `finally` portion of <xref href="osu.Framework.Platform.GameHost.Run(osu.Framework.Game)" data-throw-if-not-resolved="false"></xref>)
fires correctly even if the base call of <xref href="osu.Framework.Platform.GameHost.PerformExit(System.Boolean)" data-throw-if-not-resolved="false"></xref> is omitted.

```csharp
[Test]
public void TestGameHostExceptionDuringAsynchronousChildLoad()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostExceptionDuringAsynchronousChildLoad"></a> TestGameHostExceptionDuringAsynchronousChildLoad\(\)

<xref href="osu.Framework.Platform.GameHost.PerformExit(System.Boolean)" data-throw-if-not-resolved="false"></xref> is virtual, but there are some cases where exit is mandatory.
This aims to test that shutdown from an exception firing (ie. the `finally` portion of <xref href="osu.Framework.Platform.GameHost.Run(osu.Framework.Game)" data-throw-if-not-resolved="false"></xref>)
fires correctly even if the base call of <xref href="osu.Framework.Platform.GameHost.PerformExit(System.Boolean)" data-throw-if-not-resolved="false"></xref> is omitted.

```csharp
[Test]
public void TestGameHostExceptionDuringAsynchronousChildLoad()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostExceptionDuringAsynchronousChildLoad"></a> TestGameHostExceptionDuringAsynchronousChildLoad\(\)

<xref href="osu.Framework.Platform.GameHost.PerformExit(System.Boolean)" data-throw-if-not-resolved="false"></xref> is virtual, but there are some cases where exit is mandatory.
This aims to test that shutdown from an exception firing (ie. the `finally` portion of <xref href="osu.Framework.Platform.GameHost.Run(osu.Framework.Game)" data-throw-if-not-resolved="false"></xref>)
fires correctly even if the base call of <xref href="osu.Framework.Platform.GameHost.PerformExit(System.Boolean)" data-throw-if-not-resolved="false"></xref> is omitted.

```csharp
[Test]
public void TestGameHostExceptionDuringAsynchronousChildLoad()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostExceptionDuringSetupHost"></a> TestGameHostExceptionDuringSetupHost\(\)

```csharp
[Test]
public void TestGameHostExceptionDuringSetupHost()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostExceptionDuringSetupHost"></a> TestGameHostExceptionDuringSetupHost\(\)

```csharp
[Test]
public void TestGameHostExceptionDuringSetupHost()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestGameHostExceptionDuringSetupHost"></a> TestGameHostExceptionDuringSetupHost\(\)

```csharp
[Test]
public void TestGameHostExceptionDuringSetupHost()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestThreadSafetyResetOnEnteringThread"></a> TestThreadSafetyResetOnEnteringThread\(\)

```csharp
[Test]
public void TestThreadSafetyResetOnEnteringThread()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestThreadSafetyResetOnEnteringThread"></a> TestThreadSafetyResetOnEnteringThread\(\)

```csharp
[Test]
public void TestThreadSafetyResetOnEnteringThread()
```

### <a id="osu_Framework_Tests_Platform_HeadlessGameHostTest_TestThreadSafetyResetOnEnteringThread"></a> TestThreadSafetyResetOnEnteringThread\(\)

```csharp
[Test]
public void TestThreadSafetyResetOnEnteringThread()
```

