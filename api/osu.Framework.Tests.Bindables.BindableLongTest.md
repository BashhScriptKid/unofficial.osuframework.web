# <a id="osu_Framework_Tests_Bindables_BindableLongTest"></a> Class BindableLongTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableLongTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableLongTest](osu.Framework.Tests.Bindables.BindableLongTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableLongTest\>\(BindableLongTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableLongTest\>\(BindableLongTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableLongTest\>\(BindableLongTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableLongTest\>\(BindableLongTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableLongTest, TChild\>\(BindableLongTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableLongTest, TChild\>\(BindableLongTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableLongTest, TChild\>\(BindableLongTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableLongTest\>\(BindableLongTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingLong_System_Int64_"></a> TestParsingLong\(long\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-9223372036854775808)]
[TestCase(9223372036854775807)]
public void TestParsingLong(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingLong_System_Int64_"></a> TestParsingLong\(long\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-9223372036854775808)]
[TestCase(9223372036854775807)]
public void TestParsingLong(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingLong_System_Int64_"></a> TestParsingLong\(long\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-9223372036854775808)]
[TestCase(9223372036854775807)]
public void TestParsingLong(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingString_System_String_System_Int64_"></a> TestParsingString\(string, long\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105", -105)]
[TestCase("105", 105)]
public void TestParsingString(string value, long expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingString_System_String_System_Int64_"></a> TestParsingString\(string, long\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105", -105)]
[TestCase("105", 105)]
public void TestParsingString(string value, long expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingString_System_String_System_Int64_"></a> TestParsingString\(string, long\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105", -105)]
[TestCase("105", 105)]
public void TestParsingString(string value, long expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingStringWithRange_System_String_System_Int64_System_Int64_System_Int64_"></a> TestParsingStringWithRange\(string, long, long, long\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105", -10, 10, -10 })]
[TestCase(new object?[] { "105", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, long minValue, long maxValue, long expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`maxValue` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`expected` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingStringWithRange_System_String_System_Int64_System_Int64_System_Int64_"></a> TestParsingStringWithRange\(string, long, long, long\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105", -10, 10, -10 })]
[TestCase(new object?[] { "105", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, long minValue, long maxValue, long expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`maxValue` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`expected` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestParsingStringWithRange_System_String_System_Int64_System_Int64_System_Int64_"></a> TestParsingStringWithRange\(string, long, long, long\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105", -10, 10, -10 })]
[TestCase(new object?[] { "105", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, long minValue, long maxValue, long expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`maxValue` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`expected` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestSet_System_Int64_"></a> TestSet\(long\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-9223372036854775808)]
[TestCase(9223372036854775807)]
public void TestSet(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestSet_System_Int64_"></a> TestSet\(long\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-9223372036854775808)]
[TestCase(9223372036854775807)]
public void TestSet(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Tests_Bindables_BindableLongTest_TestSet_System_Int64_"></a> TestSet\(long\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105)]
[TestCase(105)]
[TestCase(-9223372036854775808)]
[TestCase(9223372036854775807)]
public void TestSet(long value)
```

#### Parameters

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

