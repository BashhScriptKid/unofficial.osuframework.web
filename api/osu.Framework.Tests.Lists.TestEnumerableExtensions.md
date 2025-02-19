# <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions"></a> Class TestEnumerableExtensions

Namespace: [osu.Framework.Tests.Lists](osu.Framework.Tests.Lists.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class TestEnumerableExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TestEnumerableExtensions](osu.Framework.Tests.Lists.TestEnumerableExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TestEnumerableExtensions\>\(TestEnumerableExtensions?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestEnumerableExtensions\>\(TestEnumerableExtensions\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TestEnumerableExtensions\>\(TestEnumerableExtensions\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestEnumerableExtensions\>\(TestEnumerableExtensions\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TestEnumerableExtensions, TChild\>\(TestEnumerableExtensions, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestEnumerableExtensions, TChild\>\(TestEnumerableExtensions, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestEnumerableExtensions, TChild\>\(TestEnumerableExtensions, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestEnumerableExtensions\>\(TestEnumerableExtensions\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestCommonPrefix"></a> TestCommonPrefix\(\)

```csharp
[Test]
public void TestCommonPrefix()
```

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestCommonPrefix"></a> TestCommonPrefix\(\)

```csharp
[Test]
public void TestCommonPrefix()
```

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestCommonPrefix"></a> TestCommonPrefix\(\)

```csharp
[Test]
public void TestCommonPrefix()
```

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestEmptyEnumerable"></a> TestEmptyEnumerable\(\)

```csharp
[Test]
public void TestEmptyEnumerable()
```

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestEmptyEnumerable"></a> TestEmptyEnumerable\(\)

```csharp
[Test]
public void TestEmptyEnumerable()
```

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestEmptyEnumerable"></a> TestEmptyEnumerable\(\)

```csharp
[Test]
public void TestEmptyEnumerable()
```

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestGetNext_System_String_System_String_"></a> TestGetNext\(string, string\)

```csharp
[TestCase("a", "b")]
[TestCase("b", "c")]
[TestCase("c", null)]
[TestCase("d", null)]
public void TestGetNext(string item, string expected)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestGetNext_System_String_System_String_"></a> TestGetNext\(string, string\)

```csharp
[TestCase("a", "b")]
[TestCase("b", "c")]
[TestCase("c", null)]
[TestCase("d", null)]
public void TestGetNext(string item, string expected)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestGetNext_System_String_System_String_"></a> TestGetNext\(string, string\)

```csharp
[TestCase("a", "b")]
[TestCase("b", "c")]
[TestCase("c", null)]
[TestCase("d", null)]
public void TestGetNext(string item, string expected)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestGetPrevious_System_String_System_String_"></a> TestGetPrevious\(string, string\)

```csharp
[TestCase("a", null)]
[TestCase("b", "a")]
[TestCase("c", "b")]
[TestCase("d", null)]
public void TestGetPrevious(string item, string expected)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestGetPrevious_System_String_System_String_"></a> TestGetPrevious\(string, string\)

```csharp
[TestCase("a", null)]
[TestCase("b", "a")]
[TestCase("c", "b")]
[TestCase("d", null)]
public void TestGetPrevious(string item, string expected)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Lists_TestEnumerableExtensions_TestGetPrevious_System_String_System_String_"></a> TestGetPrevious\(string, string\)

```csharp
[TestCase("a", null)]
[TestCase("b", "a")]
[TestCase("c", "b")]
[TestCase("d", null)]
public void TestGetPrevious(string item, string expected)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

