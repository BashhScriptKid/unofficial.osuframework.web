# <a id="osu_Framework_Platform_Linux_Native_Library"></a> Class Library

Namespace: [osu.Framework.Platform.Linux.Native](osu.Framework.Platform.Linux.Native.md)  
Assembly: osu.Framework.dll  

```csharp
public static class Library
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Library](osu.Framework.Platform.Linux.Native.Library.md)

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

### <a id="osu_Framework_Platform_Linux_Native_Library_Load_System_String_osu_Framework_Platform_Linux_Native_Library_LoadFlags_"></a> Load\(string, LoadFlags\)

Loads a library with flags to use with dlopen. Uses <xref href="osu.Framework.Platform.Linux.Native.Library.LoadFlags" data-throw-if-not-resolved="false"></xref> for the flags

Uses NATIVE_DLL_SEARCH_DIRECTORIES and then ld.so for library paths

```csharp
public static void Load(string library, Library.LoadFlags flags)
```

#### Parameters

`library` [string](https://learn.microsoft.com/dotnet/api/system.string)

Full name of the library

`flags` [Library](osu.Framework.Platform.Linux.Native.Library.md).[LoadFlags](osu.Framework.Platform.Linux.Native.Library.LoadFlags.md)

See 'man dlopen' for more information.

