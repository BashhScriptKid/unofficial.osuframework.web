# <a id="osu_Framework_IO_Network_WebRequest"></a> Class WebRequest

Namespace: [osu.Framework.IO.Network](osu.Framework.IO.Network.md)  
Assembly: osu.Framework.dll  

```csharp
public class WebRequest : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[WebRequest](osu.Framework.IO.Network.WebRequest.md)

#### Derived

[FileWebRequest](osu.Framework.IO.Network.FileWebRequest.md), 
[JsonWebRequest<T\>](osu.Framework.IO.Network.JsonWebRequest\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<WebRequest\>\(WebRequest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<WebRequest\>\(WebRequest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<WebRequest\>\(WebRequest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<WebRequest\>\(WebRequest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<WebRequest, TChild\>\(WebRequest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<WebRequest, TChild\>\(WebRequest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<WebRequest, TChild\>\(WebRequest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<WebRequest\>\(WebRequest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Network_WebRequest__ctor_System_String_System_Object___"></a> WebRequest\(string, params object\[\]\)

```csharp
public WebRequest(string url = null, params object[] args)
```

#### Parameters

`url` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

## Fields

### <a id="osu_Framework_IO_Network_WebRequest_AllowRetryOnTimeout"></a> AllowRetryOnTimeout

Whether this request should internally retry (up to <xref href="osu.Framework.IO.Network.WebRequest.MAX_RETRIES" data-throw-if-not-resolved="false"></xref> times) on a timeout before throwing an exception.

```csharp
public bool AllowRetryOnTimeout
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Network_WebRequest_ContentType"></a> ContentType

The content type when POST content is provided.

```csharp
public string ContentType
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Network_WebRequest_DEFAULT_TIMEOUT"></a> DEFAULT\_TIMEOUT

```csharp
public const int DEFAULT_TIMEOUT = 10000
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_IO_Network_WebRequest_Method"></a> Method

```csharp
public HttpMethod Method
```

#### Field Value

 [HttpMethod](https://learn.microsoft.com/dotnet/api/system.net.http.httpmethod)

### <a id="osu_Framework_IO_Network_WebRequest_Timeout"></a> Timeout

The amount of time from last sent or received data to trigger a timeout and abort the request.

```csharp
public int Timeout
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_IO_Network_WebRequest_Url"></a> Url

The URL of this request.

```csharp
public string Url
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_IO_Network_WebRequest_Aborted"></a> Aborted

Whether the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> was aborted due to an exception or a user abort request.

```csharp
public bool Aborted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Network_WebRequest_Accept"></a> Accept

The type of content expected by this web request.

```csharp
protected virtual string Accept { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Network_WebRequest_AllowInsecureRequests"></a> AllowInsecureRequests

Whether non-SSL requests should be allowed. Defaults to disabled.
In the default state, http:// requests will be automatically converted to https://.

```csharp
public bool AllowInsecureRequests { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

Setting this overrides the <code>OSU_INSECURE_REQUESTS</code> environment variable.

### <a id="osu_Framework_IO_Network_WebRequest_Completed"></a> Completed

Whether the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> has been run.

```csharp
public bool Completed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Network_WebRequest_ResponseHeaders"></a> ResponseHeaders

```csharp
public HttpResponseHeaders ResponseHeaders { get; }
```

#### Property Value

 [HttpResponseHeaders](https://learn.microsoft.com/dotnet/api/system.net.http.headers.httpresponseheaders)

### <a id="osu_Framework_IO_Network_WebRequest_ResponseStream"></a> ResponseStream

The response stream.

```csharp
public Stream ResponseStream { get; }
```

#### Property Value

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_IO_Network_WebRequest_UserAgent"></a> UserAgent

The value of the User-agent HTTP header.

```csharp
protected virtual string UserAgent { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_IO_Network_WebRequest_Abort"></a> Abort\(\)

Forcefully abort the request.

```csharp
public void Abort()
```

### <a id="osu_Framework_IO_Network_WebRequest_AddFile_System_String_System_Byte___System_String_"></a> AddFile\(string, byte\[\], string\)

Add a new FILE parameter to this request.
This may not be used in conjunction with <xref href="osu.Framework.IO.Network.WebRequest.AddRaw(System.IO.Stream)" data-throw-if-not-resolved="false"></xref>. GET requests may not contain files.

```csharp
public void AddFile(string paramName, byte[] data, string filename = "blob")
```

#### Parameters

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the form parameter of the request that the file relates to.

`data` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The file data.

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The filename of the file to be sent to be reported to the server in the <code>Content-Disposition</code> header.
<code>blob</code> is used by default if omitted, to <a href="https://developer.mozilla.org/en-US/docs/Web/API/FormData/append#filename">mirror browser behaviour</a>.

### <a id="osu_Framework_IO_Network_WebRequest_AddHeader_System_String_System_String_"></a> AddHeader\(string, string\)

Adds a new header to this request. Replaces any existing header with the same name.

```csharp
public void AddHeader(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the header.

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

The header value.

### <a id="osu_Framework_IO_Network_WebRequest_AddParameter_System_String_System_String_"></a> AddParameter\(string, string\)

<p>
Add a new parameter to this request. Replaces any existing parameter with the same name.
</p>
<p>
If this request's <xref href="osu.Framework.IO.Network.WebRequest.Method" data-throw-if-not-resolved="false"></xref> supports a request body (<code>POST, PUT, DELETE, PATCH</code>), a <xref href="osu.Framework.IO.Network.RequestParameterType.Form" data-throw-if-not-resolved="false"></xref> parameter will be added;
otherwise, a <xref href="osu.Framework.IO.Network.RequestParameterType.Query" data-throw-if-not-resolved="false"></xref> parameter will be added.
For more fine-grained control over the parameter type, use the <xref href="osu.Framework.IO.Network.WebRequest.AddParameter(System.String%2cSystem.String%2cosu.Framework.IO.Network.RequestParameterType)" data-throw-if-not-resolved="false"></xref> overload.
</p>
<p>
  <xref href="osu.Framework.IO.Network.RequestParameterType.Form" data-throw-if-not-resolved="false"></xref> parameters may not be used in conjunction with <xref href="osu.Framework.IO.Network.WebRequest.AddRaw(System.IO.Stream)" data-throw-if-not-resolved="false"></xref>.
</p>

```csharp
public void AddParameter(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter.

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

The parameter value.

#### Remarks

Values added to the request URL query string are automatically percent-encoded before sending the request.

### <a id="osu_Framework_IO_Network_WebRequest_AddParameter_System_String_System_String_osu_Framework_IO_Network_RequestParameterType_"></a> AddParameter\(string, string, RequestParameterType\)

Add a new parameter to this request. Replaces any existing parameter with the same name.
<xref href="osu.Framework.IO.Network.RequestParameterType.Form" data-throw-if-not-resolved="false"></xref> parameters may not be used in conjunction with <xref href="osu.Framework.IO.Network.WebRequest.AddRaw(System.IO.Stream)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddParameter(string name, string value, RequestParameterType type)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter.

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

The parameter value.

`type` [RequestParameterType](osu.Framework.IO.Network.RequestParameterType.md)

The type of the request parameter.

#### Remarks

Values added to the request URL query string are automatically percent-encoded before sending the request.

### <a id="osu_Framework_IO_Network_WebRequest_AddRaw_System_String_"></a> AddRaw\(string\)

Adds a raw POST body to this request.
This may not be used in conjunction with <xref href="osu.Framework.IO.Network.WebRequest.AddFile(System.String%2cSystem.Byte%5b%5d%2cSystem.String)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.IO.Network.WebRequest.AddParameter(System.String%2cSystem.String%2cosu.Framework.IO.Network.RequestParameterType)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddRaw(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

The text.

### <a id="osu_Framework_IO_Network_WebRequest_AddRaw_System_Byte___"></a> AddRaw\(byte\[\]\)

Adds a raw POST body to this request.
This may not be used in conjunction with <xref href="osu.Framework.IO.Network.WebRequest.AddFile(System.String%2cSystem.Byte%5b%5d%2cSystem.String)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.IO.Network.WebRequest.AddParameter(System.String%2cSystem.String%2cosu.Framework.IO.Network.RequestParameterType)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddRaw(byte[] bytes)
```

#### Parameters

`bytes` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The raw data.

### <a id="osu_Framework_IO_Network_WebRequest_AddRaw_System_IO_Stream_"></a> AddRaw\(Stream\)

Adds a raw POST body to this request.
This may not be used in conjunction with <xref href="osu.Framework.IO.Network.WebRequest.AddFile(System.String%2cSystem.Byte%5b%5d%2cSystem.String)" data-throw-if-not-resolved="false"></xref>
and <xref href="osu.Framework.IO.Network.WebRequest.AddParameter(System.String%2cSystem.String%2cosu.Framework.IO.Network.RequestParameterType)" data-throw-if-not-resolved="false"></xref> with the request type of <xref href="osu.Framework.IO.Network.RequestParameterType.Form" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddRaw(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream containing the raw data. This stream will _not_ be finalized by this request.

### <a id="osu_Framework_IO_Network_WebRequest_Complete_System_Exception_"></a> Complete\(Exception\)

```csharp
protected virtual Task Complete(Exception e = null)
```

#### Parameters

`e` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_IO_Network_WebRequest_CreateOutputStream"></a> CreateOutputStream\(\)

```csharp
protected virtual Stream CreateOutputStream()
```

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_IO_Network_WebRequest_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Network_WebRequest_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_IO_Network_WebRequest_GetResponseData"></a> GetResponseData\(\)

Retrieve the full response body as an array of bytes.

```csharp
[CanBeNull]
public byte[] GetResponseData()
```

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The response body.
Can be <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if the request hasn't yet <xref href="osu.Framework.IO.Network.WebRequest.Completed" data-throw-if-not-resolved="false"></xref>, or if it has been <xref href="osu.Framework.IO.Network.WebRequest.Aborted" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_IO_Network_WebRequest_GetResponseString"></a> GetResponseString\(\)

Retrieve the full response body as a UTF8 encoded string.

```csharp
[CanBeNull]
public string GetResponseString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The response body.
Can be <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if the request hasn't yet <xref href="osu.Framework.IO.Network.WebRequest.Completed" data-throw-if-not-resolved="false"></xref>, or if it has been <xref href="osu.Framework.IO.Network.WebRequest.Aborted" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_IO_Network_WebRequest_Perform"></a> Perform\(\)

Performs the request synchronously.

```csharp
public void Perform()
```

### <a id="osu_Framework_IO_Network_WebRequest_PerformAsync_System_Threading_CancellationToken_"></a> PerformAsync\(CancellationToken\)

Performs the request asynchronously.

```csharp
public Task PerformAsync(CancellationToken cancellationToken = default)
```

#### Parameters

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A token to cancel the request.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_IO_Network_WebRequest_PrePerform"></a> PrePerform\(\)

Task to run direct before performing the request.

```csharp
protected virtual void PrePerform()
```

### <a id="osu_Framework_IO_Network_WebRequest_ProcessResponse"></a> ProcessResponse\(\)

Performs any post-processing of the response.
Exceptions thrown in this method will be passed to <xref href="osu.Framework.IO.Network.WebRequest.Failed" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void ProcessResponse()
```

### <a id="osu_Framework_IO_Network_WebRequest_DownloadProgress"></a> DownloadProgress

Invoked when the download progress has changed.

```csharp
public event Action<long, long> DownloadProgress
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-2)<[long](https://learn.microsoft.com/dotnet/api/system.int64), [long](https://learn.microsoft.com/dotnet/api/system.int64)\>

### <a id="osu_Framework_IO_Network_WebRequest_Failed"></a> Failed

Invoked when the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> has failed.

```csharp
public event Action<Exception> Failed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Exception](https://learn.microsoft.com/dotnet/api/system.exception)\>

### <a id="osu_Framework_IO_Network_WebRequest_Finished"></a> Finished

Invoked when the <xref href="osu.Framework.IO.Network.WebRequest" data-throw-if-not-resolved="false"></xref> has finished successfully.

```csharp
public event Action Finished
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="osu_Framework_IO_Network_WebRequest_Started"></a> Started

Invoked when a response has been received, but not data has been received.

```csharp
public event Action Started
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="osu_Framework_IO_Network_WebRequest_UploadProgress"></a> UploadProgress

Invoked when the upload progress has changed.

```csharp
public event Action<long, long> UploadProgress
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-2)<[long](https://learn.microsoft.com/dotnet/api/system.int64), [long](https://learn.microsoft.com/dotnet/api/system.int64)\>

