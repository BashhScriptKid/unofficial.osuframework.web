# <a id="osu_Framework_Tests_IO_TestWebRequest"></a> Class TestWebRequest

Namespace: [osu.Framework.Tests.IO](osu.Framework.Tests.IO.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
[Category("httpbin")]
public class TestWebRequest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TestWebRequest](osu.Framework.Tests.IO.TestWebRequest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TestWebRequest\>\(TestWebRequest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestWebRequest\>\(TestWebRequest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TestWebRequest\>\(TestWebRequest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestWebRequest\>\(TestWebRequest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TestWebRequest, TChild\>\(TestWebRequest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestWebRequest, TChild\>\(TestWebRequest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestWebRequest, TChild\>\(TestWebRequest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestWebRequest\>\(TestWebRequest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_IO_TestWebRequest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_Setup"></a> Setup\(\)

```csharp
[SetUp]
public void Setup()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_Teardown"></a> Teardown\(\)

```csharp
[TearDown]
public void Teardown()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAbortReceive_System_Boolean_"></a> TestAbortReceive\(bool\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> after response has been received from the server
but before data has been read.

```csharp
[Test]
[Retry(5)]
public void TestAbortReceive(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAbortReceive_System_Boolean_"></a> TestAbortReceive\(bool\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> after response has been received from the server
but before data has been read.

```csharp
[Test]
[Retry(5)]
public void TestAbortReceive(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAbortReceive_System_Boolean_"></a> TestAbortReceive\(bool\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> after response has been received from the server
but before data has been read.

```csharp
[Test]
[Retry(5)]
public void TestAbortReceive(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAbortRequest"></a> TestAbortRequest\(\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> before the request is sent to the server.

```csharp
[Test]
[Retry(5)]
public void TestAbortRequest()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAbortRequest"></a> TestAbortRequest\(\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> before the request is sent to the server.

```csharp
[Test]
[Retry(5)]
public void TestAbortRequest()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAbortRequest"></a> TestAbortRequest\(\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> before the request is sent to the server.

```csharp
[Test]
[Retry(5)]
public void TestAbortRequest()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAllowInsecureRequestsOverride_System_String_System_Boolean_"></a> TestAllowInsecureRequestsOverride\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestAllowInsecureRequestsOverride(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAllowInsecureRequestsOverride_System_String_System_Boolean_"></a> TestAllowInsecureRequestsOverride\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestAllowInsecureRequestsOverride(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestAllowInsecureRequestsOverride_System_String_System_Boolean_"></a> TestAllowInsecureRequestsOverride\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestAllowInsecureRequestsOverride(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestBadStatusCode_System_Boolean_"></a> TestBadStatusCode\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestBadStatusCode(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestBadStatusCode_System_Boolean_"></a> TestBadStatusCode\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestBadStatusCode(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestBadStatusCode_System_Boolean_"></a> TestBadStatusCode\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestBadStatusCode(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCancelReceive"></a> TestCancelReceive\(\)

Tests cancelling the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> after response has been received from the server
but before data has been read.

```csharp
[Test]
[Retry(5)]
public void TestCancelReceive()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCancelReceive"></a> TestCancelReceive\(\)

Tests cancelling the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> after response has been received from the server
but before data has been read.

```csharp
[Test]
[Retry(5)]
public void TestCancelReceive()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCancelReceive"></a> TestCancelReceive\(\)

Tests cancelling the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> after response has been received from the server
but before data has been read.

```csharp
[Test]
[Retry(5)]
public void TestCancelReceive()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCancelRequest"></a> TestCancelRequest\(\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> before the request is sent to the server.

```csharp
[Test]
[Retry(5)]
public Task TestCancelRequest()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCancelRequest"></a> TestCancelRequest\(\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> before the request is sent to the server.

```csharp
[Test]
[Retry(5)]
public Task TestCancelRequest()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCancelRequest"></a> TestCancelRequest\(\)

Tests aborting the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> before the request is sent to the server.

```csharp
[Test]
[Retry(5)]
public Task TestCancelRequest()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestConcurrency"></a> TestConcurrency\(\)

Tests async execution is correctly yielding during IO wait time.

```csharp
[Test]
public void TestConcurrency()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestConcurrency"></a> TestConcurrency\(\)

Tests async execution is correctly yielding during IO wait time.

```csharp
[Test]
public void TestConcurrency()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestConcurrency"></a> TestConcurrency\(\)

Tests async execution is correctly yielding during IO wait time.

```csharp
[Test]
public void TestConcurrency()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCustomUserAgent_System_String_System_Boolean_"></a> TestCustomUserAgent\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestCustomUserAgent(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCustomUserAgent_System_String_System_Boolean_"></a> TestCustomUserAgent\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestCustomUserAgent(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestCustomUserAgent_System_String_System_Boolean_"></a> TestCustomUserAgent\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestCustomUserAgent(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestEventUnbindOnCompletion_System_Boolean_"></a> TestEventUnbindOnCompletion\(bool\)

Tests being able to abort + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestEventUnbindOnCompletion(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestEventUnbindOnCompletion_System_Boolean_"></a> TestEventUnbindOnCompletion\(bool\)

Tests being able to abort + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestEventUnbindOnCompletion(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestEventUnbindOnCompletion_System_Boolean_"></a> TestEventUnbindOnCompletion\(bool\)

Tests being able to abort + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestEventUnbindOnCompletion(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestFailTimeout"></a> TestFailTimeout\(\)

Tests that a <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> will only timeout a maximum of <xref href="osu.Framework.IO.Network.WebRequest.MAX_RETRIES" data-throw-if-not-resolved="false"></xref> times before being aborted.

```csharp
[Test]
[Retry(5)]
public void TestFailTimeout()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestFailTimeout"></a> TestFailTimeout\(\)

Tests that a <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> will only timeout a maximum of <xref href="osu.Framework.IO.Network.WebRequest.MAX_RETRIES" data-throw-if-not-resolved="false"></xref> times before being aborted.

```csharp
[Test]
[Retry(5)]
public void TestFailTimeout()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestFailTimeout"></a> TestFailTimeout\(\)

Tests that a <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> will only timeout a maximum of <xref href="osu.Framework.IO.Network.WebRequest.MAX_RETRIES" data-throw-if-not-resolved="false"></xref> times before being aborted.

```csharp
[Test]
[Retry(5)]
public void TestFailTimeout()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestFormParamsNotSupportedForGet"></a> TestFormParamsNotSupportedForGet\(\)

```csharp
[Test]
public void TestFormParamsNotSupportedForGet()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestFormParamsNotSupportedForGet"></a> TestFormParamsNotSupportedForGet\(\)

```csharp
[Test]
public void TestFormParamsNotSupportedForGet()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestFormParamsNotSupportedForGet"></a> TestFormParamsNotSupportedForGet\(\)

```csharp
[Test]
public void TestFormParamsNotSupportedForGet()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestGetBinaryData_System_Boolean_System_Boolean_"></a> TestGetBinaryData\(bool, bool\)

```csharp
[Test]
[Retry(5)]
public void TestGetBinaryData(bool async, bool chunked)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`chunked` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestGetBinaryData_System_Boolean_System_Boolean_"></a> TestGetBinaryData\(bool, bool\)

```csharp
[Test]
[Retry(5)]
public void TestGetBinaryData(bool async, bool chunked)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`chunked` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestGetBinaryData_System_Boolean_System_Boolean_"></a> TestGetBinaryData\(bool, bool\)

```csharp
[Test]
[Retry(5)]
public void TestGetBinaryData(bool async, bool chunked)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`chunked` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestGetWithQueryStringParameters"></a> TestGetWithQueryStringParameters\(\)

```csharp
[Test]
[Retry(5)]
public void TestGetWithQueryStringParameters()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestGetWithQueryStringParameters"></a> TestGetWithQueryStringParameters\(\)

```csharp
[Test]
[Retry(5)]
public void TestGetWithQueryStringParameters()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestGetWithQueryStringParameters"></a> TestGetWithQueryStringParameters\(\)

```csharp
[Test]
[Retry(5)]
public void TestGetWithQueryStringParameters()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestInvalidGetExceptions_System_String_System_Boolean_"></a> TestInvalidGetExceptions\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestInvalidGetExceptions(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestInvalidGetExceptions_System_String_System_Boolean_"></a> TestInvalidGetExceptions\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestInvalidGetExceptions(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestInvalidGetExceptions_System_String_System_Boolean_"></a> TestInvalidGetExceptions\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestInvalidGetExceptions(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestJsonWebRequestThrowsCorrectlyOnMultipleErrors_System_Boolean_"></a> TestJsonWebRequestThrowsCorrectlyOnMultipleErrors\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestJsonWebRequestThrowsCorrectlyOnMultipleErrors(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestJsonWebRequestThrowsCorrectlyOnMultipleErrors_System_Boolean_"></a> TestJsonWebRequestThrowsCorrectlyOnMultipleErrors\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestJsonWebRequestThrowsCorrectlyOnMultipleErrors(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestJsonWebRequestThrowsCorrectlyOnMultipleErrors_System_Boolean_"></a> TestJsonWebRequestThrowsCorrectlyOnMultipleErrors\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestJsonWebRequestThrowsCorrectlyOnMultipleErrors(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestNoContentPost_System_Boolean_"></a> TestNoContentPost\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestNoContentPost(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestNoContentPost_System_Boolean_"></a> TestNoContentPost\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestNoContentPost(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestNoContentPost_System_Boolean_"></a> TestNoContentPost\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestNoContentPost(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestOneTimeout"></a> TestOneTimeout\(\)

Tests that specifically-crafted <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> is completed after one timeout.

```csharp
[Test]
[Retry(5)]
public void TestOneTimeout()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestOneTimeout"></a> TestOneTimeout\(\)

Tests that specifically-crafted <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> is completed after one timeout.

```csharp
[Test]
[Retry(5)]
public void TestOneTimeout()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestOneTimeout"></a> TestOneTimeout\(\)

Tests that specifically-crafted <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> is completed after one timeout.

```csharp
[Test]
[Retry(5)]
public void TestOneTimeout()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPostWithJsonRequest_System_Boolean_"></a> TestPostWithJsonRequest\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestPostWithJsonRequest(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPostWithJsonRequest_System_Boolean_"></a> TestPostWithJsonRequest\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestPostWithJsonRequest(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPostWithJsonRequest_System_Boolean_"></a> TestPostWithJsonRequest\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestPostWithJsonRequest(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPostWithJsonResponse_System_Boolean_"></a> TestPostWithJsonResponse\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestPostWithJsonResponse(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPostWithJsonResponse_System_Boolean_"></a> TestPostWithJsonResponse\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestPostWithJsonResponse(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPostWithJsonResponse_System_Boolean_"></a> TestPostWithJsonResponse\(bool\)

```csharp
[Test]
[Retry(5)]
public void TestPostWithJsonResponse(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPutWithQueryAndFormParams"></a> TestPutWithQueryAndFormParams\(\)

```csharp
[Test]
[Retry(5)]
public void TestPutWithQueryAndFormParams()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPutWithQueryAndFormParams"></a> TestPutWithQueryAndFormParams\(\)

```csharp
[Test]
[Retry(5)]
public void TestPutWithQueryAndFormParams()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestPutWithQueryAndFormParams"></a> TestPutWithQueryAndFormParams\(\)

```csharp
[Test]
[Retry(5)]
public void TestPutWithQueryAndFormParams()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestRestartAfterAbort_System_Boolean_"></a> TestRestartAfterAbort\(bool\)

Tests not being able to perform a request after an initial perform-abort sequence.

```csharp
[Test]
[Retry(5)]
public void TestRestartAfterAbort(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestRestartAfterAbort_System_Boolean_"></a> TestRestartAfterAbort\(bool\)

Tests not being able to perform a request after an initial perform-abort sequence.

```csharp
[Test]
[Retry(5)]
public void TestRestartAfterAbort(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestRestartAfterAbort_System_Boolean_"></a> TestRestartAfterAbort\(bool\)

Tests not being able to perform a request after an initial perform-abort sequence.

```csharp
[Test]
[Retry(5)]
public void TestRestartAfterAbort(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestRestartAfterAbortViaCancellationToken"></a> TestRestartAfterAbortViaCancellationToken\(\)

Tests being able to cancel + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestRestartAfterAbortViaCancellationToken()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestRestartAfterAbortViaCancellationToken"></a> TestRestartAfterAbortViaCancellationToken\(\)

Tests being able to cancel + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestRestartAfterAbortViaCancellationToken()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestRestartAfterAbortViaCancellationToken"></a> TestRestartAfterAbortViaCancellationToken\(\)

Tests being able to cancel + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestRestartAfterAbortViaCancellationToken()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestStartAfterAbort_System_Boolean_"></a> TestStartAfterAbort\(bool\)

Tests not being able to perform a request after an abort (before any perform).

```csharp
[Test]
[Retry(5)]
public void TestStartAfterAbort(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestStartAfterAbort_System_Boolean_"></a> TestStartAfterAbort\(bool\)

Tests not being able to perform a request after an abort (before any perform).

```csharp
[Test]
[Retry(5)]
public void TestStartAfterAbort(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestStartAfterAbort_System_Boolean_"></a> TestStartAfterAbort\(bool\)

Tests not being able to perform a request after an abort (before any perform).

```csharp
[Test]
[Retry(5)]
public void TestStartAfterAbort(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestSynchronousFlowTplReliance"></a> TestSynchronousFlowTplReliance\(\)

Ensure the work load, and importantly, the continuations do not run on the TPL thread pool.
Since we have our own task schedulers handling these load tasks.

```csharp
[Test]
public void TestSynchronousFlowTplReliance()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestSynchronousFlowTplReliance"></a> TestSynchronousFlowTplReliance\(\)

Ensure the work load, and importantly, the continuations do not run on the TPL thread pool.
Since we have our own task schedulers handling these load tasks.

```csharp
[Test]
public void TestSynchronousFlowTplReliance()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestSynchronousFlowTplReliance"></a> TestSynchronousFlowTplReliance\(\)

Ensure the work load, and importantly, the continuations do not run on the TPL thread pool.
Since we have our own task schedulers handling these load tasks.

```csharp
[Test]
public void TestSynchronousFlowTplReliance()
```

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestUnbindOnDispose_System_Boolean_"></a> TestUnbindOnDispose\(bool\)

Tests being able to abort + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestUnbindOnDispose(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestUnbindOnDispose_System_Boolean_"></a> TestUnbindOnDispose\(bool\)

Tests being able to abort + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestUnbindOnDispose(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestUnbindOnDispose_System_Boolean_"></a> TestUnbindOnDispose\(bool\)

Tests being able to abort + restart a request.

```csharp
[Test]
[Retry(5)]
public void TestUnbindOnDispose(bool async)
```

#### Parameters

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestValidGet_System_String_System_Boolean_"></a> TestValidGet\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestValidGet(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestValidGet_System_String_System_Boolean_"></a> TestValidGet\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestValidGet(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestValidGet_System_String_System_Boolean_"></a> TestValidGet\(string, bool\)

```csharp
[Test]
[Retry(5)]
public void TestValidGet(string protocol, bool async)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

`async` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestValidGetFromTask_System_String_"></a> TestValidGetFromTask\(string\)

Ensure that synchronous requests can be run without issue from within a TPL thread pool thread.
Not recommended as it would block the thread, but we've deemed to allow this for now.

```csharp
[Test]
[Retry(5)]
public void TestValidGetFromTask(string protocol)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestValidGetFromTask_System_String_"></a> TestValidGetFromTask\(string\)

Ensure that synchronous requests can be run without issue from within a TPL thread pool thread.
Not recommended as it would block the thread, but we've deemed to allow this for now.

```csharp
[Test]
[Retry(5)]
public void TestValidGetFromTask(string protocol)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_IO_TestWebRequest_TestValidGetFromTask_System_String_"></a> TestValidGetFromTask\(string\)

Ensure that synchronous requests can be run without issue from within a TPL thread pool thread.
Not recommended as it would block the thread, but we've deemed to allow this for now.

```csharp
[Test]
[Retry(5)]
public void TestValidGetFromTask(string protocol)
```

#### Parameters

`protocol` [string](https://learn.microsoft.com/dotnet/api/system.string)

