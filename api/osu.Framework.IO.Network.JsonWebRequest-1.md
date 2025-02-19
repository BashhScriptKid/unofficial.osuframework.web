# <a id="osu_Framework_IO_Network_JsonWebRequest_1"></a> Class JsonWebRequest<T\>

Namespace: [osu.Framework.IO.Network](osu.Framework.IO.Network.md)  
Assembly: osu.Framework.dll  

A web request with a specific JSON response format.

```csharp
public class JsonWebRequest<T> : WebRequest, IDisposable
```

#### Type Parameters

`T` 

the response format.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[WebRequest](osu.Framework.IO.Network.WebRequest.md) ← 
[JsonWebRequest<T\>](osu.Framework.IO.Network.JsonWebRequest\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[WebRequest.DEFAULT\_TIMEOUT](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_DEFAULT\_TIMEOUT), 
[WebRequest.Started](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Started), 
[WebRequest.Finished](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Finished), 
[WebRequest.Failed](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Failed), 
[WebRequest.DownloadProgress](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_DownloadProgress), 
[WebRequest.UploadProgress](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_UploadProgress), 
[WebRequest.Aborted](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Aborted), 
[WebRequest.ResponseStream](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_ResponseStream), 
[WebRequest.ResponseHeaders](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_ResponseHeaders), 
[WebRequest.Url](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Url), 
[WebRequest.Method](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Method), 
[WebRequest.Timeout](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Timeout), 
[WebRequest.AllowRetryOnTimeout](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AllowRetryOnTimeout), 
[WebRequest.ContentType](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_ContentType), 
[WebRequest.Accept](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Accept), 
[WebRequest.UserAgent](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_UserAgent), 
[WebRequest.AllowInsecureRequests](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AllowInsecureRequests), 
[WebRequest.Completed](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Completed), 
[WebRequest.GetResponseString\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_GetResponseString), 
[WebRequest.GetResponseData\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_GetResponseData), 
[WebRequest.CreateOutputStream\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_CreateOutputStream), 
[WebRequest.PerformAsync\(CancellationToken\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_PerformAsync\_System\_Threading\_CancellationToken\_), 
[WebRequest.Perform\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Perform), 
[WebRequest.PrePerform\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_PrePerform), 
[WebRequest.Complete\(Exception\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Complete\_System\_Exception\_), 
[WebRequest.ProcessResponse\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_ProcessResponse), 
[WebRequest.Abort\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Abort), 
[WebRequest.AddRaw\(string\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddRaw\_System\_String\_), 
[WebRequest.AddRaw\(byte\[\]\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddRaw\_System\_Byte\_\_\_), 
[WebRequest.AddRaw\(Stream\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddRaw\_System\_IO\_Stream\_), 
[WebRequest.AddFile\(string, byte\[\], string\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddFile\_System\_String\_System\_Byte\_\_\_System\_String\_), 
[WebRequest.AddParameter\(string, string\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddParameter\_System\_String\_System\_String\_), 
[WebRequest.AddParameter\(string, string, RequestParameterType\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddParameter\_System\_String\_System\_String\_osu\_Framework\_IO\_Network\_RequestParameterType\_), 
[WebRequest.AddHeader\(string, string\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_AddHeader\_System\_String\_System\_String\_), 
[WebRequest.Dispose\(bool\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Dispose\_System\_Boolean\_), 
[WebRequest.Dispose\(\)](osu.Framework.IO.Network.WebRequest.md\#osu\_Framework\_IO\_Network\_WebRequest\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<JsonWebRequest<T\>\>\(JsonWebRequest<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<JsonWebRequest<T\>\>\(JsonWebRequest<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<JsonWebRequest<T\>\>\(JsonWebRequest<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<JsonWebRequest<T\>\>\(JsonWebRequest<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<JsonWebRequest<T\>, TChild\>\(JsonWebRequest<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<JsonWebRequest<T\>, TChild\>\(JsonWebRequest<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<JsonWebRequest<T\>, TChild\>\(JsonWebRequest<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<JsonWebRequest<T\>\>\(JsonWebRequest<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Network_JsonWebRequest_1__ctor_System_String_System_Object___"></a> JsonWebRequest\(string, params object\[\]\)

```csharp
public JsonWebRequest(string url = null, params object[] args)
```

#### Parameters

`url` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

## Properties

### <a id="osu_Framework_IO_Network_JsonWebRequest_1_Accept"></a> Accept

The type of content expected by this web request.

```csharp
protected override string Accept { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Network_JsonWebRequest_1_ResponseObject"></a> ResponseObject

```csharp
public T ResponseObject { get; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_IO_Network_JsonWebRequest_1_ProcessResponse"></a> ProcessResponse\(\)

Performs any post-processing of the response.
Exceptions thrown in this method will be passed to <xref href="osu.Framework.IO.Network.WebRequest.Failed" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void ProcessResponse()
```

