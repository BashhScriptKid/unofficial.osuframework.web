# <a id="osu_Framework_Tests_Localisation_CultureInfoHelperTest"></a> Class CultureInfoHelperTest

Namespace: [osu.Framework.Tests.Localisation](osu.Framework.Tests.Localisation.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class CultureInfoHelperTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CultureInfoHelperTest](osu.Framework.Tests.Localisation.CultureInfoHelperTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CultureInfoHelperTest\>\(CultureInfoHelperTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CultureInfoHelperTest\>\(CultureInfoHelperTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CultureInfoHelperTest\>\(CultureInfoHelperTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CultureInfoHelperTest\>\(CultureInfoHelperTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CultureInfoHelperTest, TChild\>\(CultureInfoHelperTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CultureInfoHelperTest, TChild\>\(CultureInfoHelperTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CultureInfoHelperTest, TChild\>\(CultureInfoHelperTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CultureInfoHelperTest\>\(CultureInfoHelperTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Localisation_CultureInfoHelperTest_TestTryGetCultureInfo_System_String_System_Boolean_System_String_"></a> TestTryGetCultureInfo\(string, bool, string\)

```csharp
[TestCase("en-US", true, "en-US")]
[TestCase("invalid name", false, "")]
[TestCase("", true, "")]
[TestCase("ko_KR", false, "")]
public void TestTryGetCultureInfo(string name, bool expectedReturnValue, string expectedCultureName)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedReturnValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`expectedCultureName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Localisation_CultureInfoHelperTest_TestTryGetCultureInfo_System_String_System_Boolean_System_String_"></a> TestTryGetCultureInfo\(string, bool, string\)

```csharp
[TestCase("en-US", true, "en-US")]
[TestCase("invalid name", false, "")]
[TestCase("", true, "")]
[TestCase("ko_KR", false, "")]
public void TestTryGetCultureInfo(string name, bool expectedReturnValue, string expectedCultureName)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedReturnValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`expectedCultureName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Localisation_CultureInfoHelperTest_TestTryGetCultureInfo_System_String_System_Boolean_System_String_"></a> TestTryGetCultureInfo\(string, bool, string\)

```csharp
[TestCase("en-US", true, "en-US")]
[TestCase("invalid name", false, "")]
[TestCase("", true, "")]
[TestCase("ko_KR", false, "")]
public void TestTryGetCultureInfo(string name, bool expectedReturnValue, string expectedCultureName)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedReturnValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`expectedCultureName` [string](https://learn.microsoft.com/dotnet/api/system.string)

