# <a id="osu_Framework_Android_AndroidStorage"></a> Class AndroidStorage

Namespace: [osu.Framework.Android](osu.Framework.Android.md)  
Assembly: osu.Framework.Android.dll  

```csharp
public class AndroidStorage : NativeStorage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
Storage ← 
NativeStorage ← 
[AndroidStorage](osu.Framework.Android.AndroidStorage.md)

#### Inherited Members

NativeStorage.Exists\(string\), 
NativeStorage.ExistsDirectory\(string\), 
NativeStorage.DeleteDirectory\(string\), 
NativeStorage.Delete\(string\), 
NativeStorage.Move\(string, string\), 
NativeStorage.GetDirectories\(string\), 
NativeStorage.GetFiles\(string, string\), 
NativeStorage.GetFullPath\(string, bool\), 
NativeStorage.OpenFileExternally\(string\), 
NativeStorage.PresentFileExternally\(string\), 
NativeStorage.GetStream\(string, FileAccess, FileMode\), 
NativeStorage.GetStorageForDirectory\(string\), 
Storage.BasePath, 
Storage.GetFullPath\(string, bool\), 
Storage.Exists\(string\), 
Storage.ExistsDirectory\(string\), 
Storage.DeleteDirectory\(string\), 
Storage.Delete\(string\), 
Storage.GetDirectories\(string\), 
Storage.GetFiles\(string, string\), 
Storage.GetStorageForDirectory\(string\), 
Storage.Move\(string, string\), 
Storage.CreateFileSafely\(string\), 
Storage.GetStream\(string, FileAccess, FileMode\), 
Storage.OpenFileExternally\(string\), 
Storage.PresentExternally\(\), 
Storage.PresentFileExternally\(string\), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AndroidStorage\>\(AndroidStorage?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AndroidStorage\>\(AndroidStorage\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AndroidStorage\>\(AndroidStorage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AndroidStorage\>\(AndroidStorage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AndroidStorage, TChild\>\(AndroidStorage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AndroidStorage, TChild\>\(AndroidStorage, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AndroidStorage, TChild\>\(AndroidStorage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AndroidStorage\>\(AndroidStorage\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Android_AndroidStorage__ctor_System_String_osu_Framework_Platform_GameHost_"></a> AndroidStorage\(string, GameHost\)

```csharp
public AndroidStorage(string path, GameHost host)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`host` GameHost

