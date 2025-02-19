# <a id="osu_Framework_Tests_Bindables_BindableIntTest"></a> Class BindableIntTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableIntTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableIntTest](osu.Framework.Tests.Bindables.BindableIntTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableIntTest\>\(BindableIntTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableIntTest\>\(BindableIntTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableIntTest\>\(BindableIntTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableIntTest\>\(BindableIntTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableIntTest, TChild\>\(BindableIntTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableIntTest, TChild\>\(BindableIntTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableIntTest, TChild\>\(BindableIntTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableIntTest\>\(BindableIntTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingInt_System_Int32_"></a> TestParsingInt\(int\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-2147483648)]
[TestCase(2147483647)]
public void TestParsingInt(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingInt_System_Int32_"></a> TestParsingInt\(int\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-2147483648)]
[TestCase(2147483647)]
public void TestParsingInt(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingInt_System_Int32_"></a> TestParsingInt\(int\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-2147483648)]
[TestCase(2147483647)]
public void TestParsingInt(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingString_System_String_System_Int32_"></a> TestParsingString\(string, int\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105", -105)]
[TestCase("105", 105)]
public void TestParsingString(string value, int expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingString_System_String_System_Int32_"></a> TestParsingString\(string, int\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105", -105)]
[TestCase("105", 105)]
public void TestParsingString(string value, int expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingString_System_String_System_Int32_"></a> TestParsingString\(string, int\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105", -105)]
[TestCase("105", 105)]
public void TestParsingString(string value, int expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingStringWithRange_System_String_System_Int32_System_Int32_System_Int32_"></a> TestParsingStringWithRange\(string, int, int, int\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105", -10, 10, -10 })]
[TestCase(new object?[] { "105", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, int minValue, int maxValue, int expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expected` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingStringWithRange_System_String_System_Int32_System_Int32_System_Int32_"></a> TestParsingStringWithRange\(string, int, int, int\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105", -10, 10, -10 })]
[TestCase(new object?[] { "105", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, int minValue, int maxValue, int expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expected` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestParsingStringWithRange_System_String_System_Int32_System_Int32_System_Int32_"></a> TestParsingStringWithRange\(string, int, int, int\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105", -10, 10, -10 })]
[TestCase(new object?[] { "105", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, int minValue, int maxValue, int expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expected` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestSet_System_Int32_"></a> TestSet\(int\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-2147483648)]
[TestCase(2147483647)]
public void TestSet(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestSet_System_Int32_"></a> TestSet\(int\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-2147483648)]
[TestCase(2147483647)]
public void TestSet(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableIntTest_TestSet_System_Int32_"></a> TestSet\(int\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-2147483648)]
[TestCase(2147483647)]
public void TestSet(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

