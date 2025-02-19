# <a id="osu_Framework_IO_Network_UrlEncoding"></a> Class UrlEncoding

Namespace: [osu.Framework.IO.Network](osu.Framework.IO.Network.md)  
Assembly: osu.Framework.dll  

```csharp
public static class UrlEncoding
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UrlEncoding](osu.Framework.IO.Network.UrlEncoding.md)

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

### <a id="osu_Framework_IO_Network_UrlEncoding_IntToHex_System_Int32_"></a> IntToHex\(int\)

```csharp
public static char IntToHex(int n)
```

#### Parameters

`n` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="osu_Framework_IO_Network_UrlEncoding_IsSafe_System_Char_"></a> IsSafe\(char\)

```csharp
public static bool IsSafe(char ch)
```

#### Parameters

`ch` [char](https://learn.microsoft.com/dotnet/api/system.char)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Network_UrlEncoding_UrlEncode_System_String_"></a> UrlEncode\(string\)

```csharp
public static string UrlEncode(string str)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Network_UrlEncoding_UrlEncode_System_String_System_Text_Encoding_System_Boolean_"></a> UrlEncode\(string, Encoding, bool\)

```csharp
public static string UrlEncode(string str, Encoding e, bool paramEncode)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`e` [Encoding](https://learn.microsoft.com/dotnet/api/system.text.encoding)

`paramEncode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Network_UrlEncoding_UrlEncodeParam_System_String_"></a> UrlEncodeParam\(string\)

```csharp
public static string UrlEncodeParam(string str)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Network_UrlEncoding_UrlEncodeToBytes_System_String_System_Text_Encoding_System_Boolean_"></a> UrlEncodeToBytes\(string, Encoding, bool\)

```csharp
public static byte[] UrlEncodeToBytes(string str, Encoding e, bool paramEncode)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

`e` [Encoding](https://learn.microsoft.com/dotnet/api/system.text.encoding)

`paramEncode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

