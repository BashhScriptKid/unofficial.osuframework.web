# <a id="osu_Framework_Tests_Bindables_BindableEnumTest"></a> Class BindableEnumTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableEnumTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableEnumTest\>\(BindableEnumTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableEnumTest\>\(BindableEnumTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableEnumTest\>\(BindableEnumTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableEnumTest\>\(BindableEnumTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableEnumTest, TChild\>\(BindableEnumTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableEnumTest, TChild\>\(BindableEnumTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableEnumTest, TChild\>\(BindableEnumTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableEnumTest\>\(BindableEnumTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestEmptyString"></a> TestEmptyString\(\)

```csharp
[Test]
public void TestEmptyString()
```

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestEmptyString"></a> TestEmptyString\(\)

```csharp
[Test]
public void TestEmptyString()
```

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestEmptyString"></a> TestEmptyString\(\)

```csharp
[Test]
public void TestEmptyString()
```

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestParsing_osu_Framework_Tests_Bindables_BindableEnumTest_TestEnum_System_Object___"></a> TestParsing\(TestEnum, params object\[\]\)

```csharp
[TestCase(new object?[] { BindableEnumTest.TestEnum.Value1, "Value1", 0, 0, 0, 0, 0, 0 })]
[TestCase(new object?[] { BindableEnumTest.TestEnum.Value2, "Value2", 1, 1, 1, 1, 1, 1 })]
[TestCase(new object?[] { (BindableEnumTest.TestEnum)-1, "-1", -1, -1, -1, -1, -1, -1 })]
[TestCase(new object?[] { (BindableEnumTest.TestEnum)2, "2", 2, 2, 2, 2, 2, 2 })]
public void TestParsing(BindableEnumTest.TestEnum expected, params object[] values)
```

#### Parameters

`expected` [BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md).[TestEnum](osu.Framework.Tests.Bindables.BindableEnumTest.TestEnum.md)

`values` [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestParsing_osu_Framework_Tests_Bindables_BindableEnumTest_TestEnum_System_Object___"></a> TestParsing\(TestEnum, params object\[\]\)

```csharp
[TestCase(new object?[] { BindableEnumTest.TestEnum.Value1, "Value1", 0, 0, 0, 0, 0, 0 })]
[TestCase(new object?[] { BindableEnumTest.TestEnum.Value2, "Value2", 1, 1, 1, 1, 1, 1 })]
[TestCase(new object?[] { (BindableEnumTest.TestEnum)-1, "-1", -1, -1, -1, -1, -1, -1 })]
[TestCase(new object?[] { (BindableEnumTest.TestEnum)2, "2", 2, 2, 2, 2, 2, 2 })]
public void TestParsing(BindableEnumTest.TestEnum expected, params object[] values)
```

#### Parameters

`expected` [BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md).[TestEnum](osu.Framework.Tests.Bindables.BindableEnumTest.TestEnum.md)

`values` [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestParsing_osu_Framework_Tests_Bindables_BindableEnumTest_TestEnum_System_Object___"></a> TestParsing\(TestEnum, params object\[\]\)

```csharp
[TestCase(new object?[] { BindableEnumTest.TestEnum.Value1, "Value1", 0, 0, 0, 0, 0, 0 })]
[TestCase(new object?[] { BindableEnumTest.TestEnum.Value2, "Value2", 1, 1, 1, 1, 1, 1 })]
[TestCase(new object?[] { (BindableEnumTest.TestEnum)-1, "-1", -1, -1, -1, -1, -1, -1 })]
[TestCase(new object?[] { (BindableEnumTest.TestEnum)2, "2", 2, 2, 2, 2, 2, 2 })]
public void TestParsing(BindableEnumTest.TestEnum expected, params object[] values)
```

#### Parameters

`expected` [BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md).[TestEnum](osu.Framework.Tests.Bindables.BindableEnumTest.TestEnum.md)

`values` [object](https://learn.microsoft.com/dotnet/api/system.object)\[\]

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestSet_osu_Framework_Tests_Bindables_BindableEnumTest_TestEnum_"></a> TestSet\(TestEnum\)

```csharp
[TestCase(BindableEnumTest.TestEnum.Value1)]
[TestCase(BindableEnumTest.TestEnum.Value2)]
[TestCase((BindableEnumTest.TestEnum)-1)]
[TestCase((BindableEnumTest.TestEnum)2)]
public void TestSet(BindableEnumTest.TestEnum value)
```

#### Parameters

`value` [BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md).[TestEnum](osu.Framework.Tests.Bindables.BindableEnumTest.TestEnum.md)

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestSet_osu_Framework_Tests_Bindables_BindableEnumTest_TestEnum_"></a> TestSet\(TestEnum\)

```csharp
[TestCase(BindableEnumTest.TestEnum.Value1)]
[TestCase(BindableEnumTest.TestEnum.Value2)]
[TestCase((BindableEnumTest.TestEnum)-1)]
[TestCase((BindableEnumTest.TestEnum)2)]
public void TestSet(BindableEnumTest.TestEnum value)
```

#### Parameters

`value` [BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md).[TestEnum](osu.Framework.Tests.Bindables.BindableEnumTest.TestEnum.md)

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestSet_osu_Framework_Tests_Bindables_BindableEnumTest_TestEnum_"></a> TestSet\(TestEnum\)

```csharp
[TestCase(BindableEnumTest.TestEnum.Value1)]
[TestCase(BindableEnumTest.TestEnum.Value2)]
[TestCase((BindableEnumTest.TestEnum)-1)]
[TestCase((BindableEnumTest.TestEnum)2)]
public void TestSet(BindableEnumTest.TestEnum value)
```

#### Parameters

`value` [BindableEnumTest](osu.Framework.Tests.Bindables.BindableEnumTest.md).[TestEnum](osu.Framework.Tests.Bindables.BindableEnumTest.TestEnum.md)

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestUnparsaebles_System_Object_"></a> TestUnparsaebles\(object\)

```csharp
[TestCase(1.1)]
[TestCase("Not a value")]
public void TestUnparsaebles(object value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestUnparsaebles_System_Object_"></a> TestUnparsaebles\(object\)

```csharp
[TestCase(1.1)]
[TestCase("Not a value")]
public void TestUnparsaebles(object value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Tests_Bindables_BindableEnumTest_TestUnparsaebles_System_Object_"></a> TestUnparsaebles\(object\)

```csharp
[TestCase(1.1)]
[TestCase("Not a value")]
public void TestUnparsaebles(object value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)

