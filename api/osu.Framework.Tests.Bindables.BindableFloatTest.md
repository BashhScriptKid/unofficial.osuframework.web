# <a id="osu_Framework_Tests_Bindables_BindableFloatTest"></a> Class BindableFloatTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableFloatTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableFloatTest](osu.Framework.Tests.Bindables.BindableFloatTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableFloatTest\>\(BindableFloatTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableFloatTest\>\(BindableFloatTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableFloatTest\>\(BindableFloatTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableFloatTest\>\(BindableFloatTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableFloatTest, TChild\>\(BindableFloatTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableFloatTest, TChild\>\(BindableFloatTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableFloatTest, TChild\>\(BindableFloatTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableFloatTest\>\(BindableFloatTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestDefaultCheck_System_Single_System_Single_System_Nullable_System_Single__"></a> TestDefaultCheck\(float, float, float?\)

```csharp
[TestCase(-1, 1)]
[TestCase(1.1, 1)]
[TestCase(-1.1, 1)]
[TestCase(-1, 1, 0.01)]
[TestCase(1.01, 1, 0.01)]
[TestCase(-1.01, 1, 0.01)]
[TestCase(0.99, 1, 0.01)]
[TestCase(-0.99, 1, 0.01)]
[TestCase(105.123, 105.122, 0.001)]
[TestCase(-105.123, 105.122, 0.001)]
[TestCase(-105.122, 105.122, 0.001)]
public void TestDefaultCheck(float value, float def, float? precision = null)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`def` [float](https://learn.microsoft.com/dotnet/api/system.single)

`precision` [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestDefaultCheck_System_Single_System_Single_System_Nullable_System_Single__"></a> TestDefaultCheck\(float, float, float?\)

```csharp
[TestCase(-1, 1)]
[TestCase(1.1, 1)]
[TestCase(-1.1, 1)]
[TestCase(-1, 1, 0.01)]
[TestCase(1.01, 1, 0.01)]
[TestCase(-1.01, 1, 0.01)]
[TestCase(0.99, 1, 0.01)]
[TestCase(-0.99, 1, 0.01)]
[TestCase(105.123, 105.122, 0.001)]
[TestCase(-105.123, 105.122, 0.001)]
[TestCase(-105.122, 105.122, 0.001)]
public void TestDefaultCheck(float value, float def, float? precision = null)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`def` [float](https://learn.microsoft.com/dotnet/api/system.single)

`precision` [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestDefaultCheck_System_Single_System_Single_System_Nullable_System_Single__"></a> TestDefaultCheck\(float, float, float?\)

```csharp
[TestCase(-1, 1)]
[TestCase(1.1, 1)]
[TestCase(-1.1, 1)]
[TestCase(-1, 1, 0.01)]
[TestCase(1.01, 1, 0.01)]
[TestCase(-1.01, 1, 0.01)]
[TestCase(0.99, 1, 0.01)]
[TestCase(-0.99, 1, 0.01)]
[TestCase(105.123, 105.122, 0.001)]
[TestCase(-105.123, 105.122, 0.001)]
[TestCase(-105.122, 105.122, 0.001)]
public void TestDefaultCheck(float value, float def, float? precision = null)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`def` [float](https://learn.microsoft.com/dotnet/api/system.single)

`precision` [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingFloat_System_Single_"></a> TestParsingFloat\(float\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-3.4028235E+38)]
[TestCase(3.4028235E+38)]
public void TestParsingFloat(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingFloat_System_Single_"></a> TestParsingFloat\(float\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-3.4028235E+38)]
[TestCase(3.4028235E+38)]
public void TestParsingFloat(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingFloat_System_Single_"></a> TestParsingFloat\(float\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-3.4028235E+38)]
[TestCase(3.4028235E+38)]
public void TestParsingFloat(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingNumberLocale_System_Single_System_String_System_String_"></a> TestParsingNumberLocale\(float, string, string\)

```csharp
[TestCase(1.4, "en-US", "1.4")]
[TestCase(1.4, "de-DE", "1,4")]
[TestCase(1400.01, "de-DE", "1400,01")]
[TestCase(1234.57, "ru-RU", "1234,57")]
[TestCase(1.094, "fr-FR", "1,094")]
[TestCase(1400.01, "zh-CN", "1400.01")]
public void TestParsingNumberLocale(float value, string locale, string expected)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingNumberLocale_System_Single_System_String_System_String_"></a> TestParsingNumberLocale\(float, string, string\)

```csharp
[TestCase(1.4, "en-US", "1.4")]
[TestCase(1.4, "de-DE", "1,4")]
[TestCase(1400.01, "de-DE", "1400,01")]
[TestCase(1234.57, "ru-RU", "1234,57")]
[TestCase(1.094, "fr-FR", "1,094")]
[TestCase(1400.01, "zh-CN", "1400.01")]
public void TestParsingNumberLocale(float value, string locale, string expected)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingNumberLocale_System_Single_System_String_System_String_"></a> TestParsingNumberLocale\(float, string, string\)

```csharp
[TestCase(1.4, "en-US", "1.4")]
[TestCase(1.4, "de-DE", "1,4")]
[TestCase(1400.01, "de-DE", "1400,01")]
[TestCase(1234.57, "ru-RU", "1234,57")]
[TestCase(1.094, "fr-FR", "1,094")]
[TestCase(1400.01, "zh-CN", "1400.01")]
public void TestParsingNumberLocale(float value, string locale, string expected)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingString_System_String_System_Single_"></a> TestParsingString\(string, float\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105.123", -105.123)]
[TestCase("105.123", 105.123)]
public void TestParsingString(string value, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingString_System_String_System_Single_"></a> TestParsingString\(string, float\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105.123", -105.123)]
[TestCase("105.123", 105.123)]
public void TestParsingString(string value, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingString_System_String_System_Single_"></a> TestParsingString\(string, float\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105.123", -105.123)]
[TestCase("105.123", 105.123)]
public void TestParsingString(string value, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingStringLocale_System_String_System_String_System_Single_"></a> TestParsingStringLocale\(string, string, float\)

```csharp
[TestCase("1.4", "en-US", 1.4)]
[TestCase("1,4", "de-DE", 1.4)]
[TestCase("1.400,01", "de-DE", 1400.01)]
[TestCase("1 234,57", "ru-RU", 1234.57)]
[TestCase("1,094", "fr-FR", 1.094)]
[TestCase("1,400.01", "zh-CN", 1400.01)]
public void TestParsingStringLocale(string value, string locale, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingStringLocale_System_String_System_String_System_Single_"></a> TestParsingStringLocale\(string, string, float\)

```csharp
[TestCase("1.4", "en-US", 1.4)]
[TestCase("1,4", "de-DE", 1.4)]
[TestCase("1.400,01", "de-DE", 1400.01)]
[TestCase("1 234,57", "ru-RU", 1234.57)]
[TestCase("1,094", "fr-FR", 1.094)]
[TestCase("1,400.01", "zh-CN", 1400.01)]
public void TestParsingStringLocale(string value, string locale, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingStringLocale_System_String_System_String_System_Single_"></a> TestParsingStringLocale\(string, string, float\)

```csharp
[TestCase("1.4", "en-US", 1.4)]
[TestCase("1,4", "de-DE", 1.4)]
[TestCase("1.400,01", "de-DE", 1400.01)]
[TestCase("1 234,57", "ru-RU", 1234.57)]
[TestCase("1,094", "fr-FR", 1.094)]
[TestCase("1,400.01", "zh-CN", 1400.01)]
public void TestParsingStringLocale(string value, string locale, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingStringWithRange_System_String_System_Single_System_Single_System_Single_"></a> TestParsingStringWithRange\(string, float, float, float\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105.123", -10, 10, -10 })]
[TestCase(new object?[] { "105.123", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, float minValue, float maxValue, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingStringWithRange_System_String_System_Single_System_Single_System_Single_"></a> TestParsingStringWithRange\(string, float, float, float\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105.123", -10, 10, -10 })]
[TestCase(new object?[] { "105.123", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, float minValue, float maxValue, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestParsingStringWithRange_System_String_System_Single_System_Single_System_Single_"></a> TestParsingStringWithRange\(string, float, float, float\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105.123", -10, 10, -10 })]
[TestCase(new object?[] { "105.123", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, float minValue, float maxValue, float expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expected` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestSet_System_Single_"></a> TestSet\(float\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-3.4028235E+38)]
[TestCase(3.4028235E+38)]
public void TestSet(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestSet_System_Single_"></a> TestSet\(float\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-3.4028235E+38)]
[TestCase(3.4028235E+38)]
public void TestSet(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableFloatTest_TestSet_System_Single_"></a> TestSet\(float\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-3.4028235E+38)]
[TestCase(3.4028235E+38)]
public void TestSet(float value)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

