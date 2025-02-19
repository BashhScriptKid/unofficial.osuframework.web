# <a id="osu_Framework_Tests_Bindables_BindableDoubleTest"></a> Class BindableDoubleTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableDoubleTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableDoubleTest](osu.Framework.Tests.Bindables.BindableDoubleTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableDoubleTest\>\(BindableDoubleTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableDoubleTest\>\(BindableDoubleTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableDoubleTest\>\(BindableDoubleTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableDoubleTest\>\(BindableDoubleTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableDoubleTest, TChild\>\(BindableDoubleTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableDoubleTest, TChild\>\(BindableDoubleTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableDoubleTest, TChild\>\(BindableDoubleTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableDoubleTest\>\(BindableDoubleTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestDefaultCheck_System_Double_System_Double_System_Nullable_System_Double__"></a> TestDefaultCheck\(double, double, double?\)

```csharp
[TestCase(-1, 1)]
[TestCase(1.1, 1)]
[TestCase(-1.1, 1)]
[TestCase(-1, 1, 1E-08)]
[TestCase(1.00000001, 1, 1E-08)]
[TestCase(-1.00000001, 1, 1E-08)]
[TestCase(0.99999999, 1, 1E-08)]
[TestCase(-0.99999999, 1, 1E-08)]
[TestCase(199.1223345568, 199.1223345567, 1E-10)]
[TestCase(-199.1223345568, 199.1223345567, 1E-10)]
[TestCase(-199.1223345567, 199.1223345567, 1E-10)]
public void TestDefaultCheck(double value, double def, double? precision = null)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

`def` [double](https://learn.microsoft.com/dotnet/api/system.double)

`precision` [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestDefaultCheck_System_Double_System_Double_System_Nullable_System_Double__"></a> TestDefaultCheck\(double, double, double?\)

```csharp
[TestCase(-1, 1)]
[TestCase(1.1, 1)]
[TestCase(-1.1, 1)]
[TestCase(-1, 1, 1E-08)]
[TestCase(1.00000001, 1, 1E-08)]
[TestCase(-1.00000001, 1, 1E-08)]
[TestCase(0.99999999, 1, 1E-08)]
[TestCase(-0.99999999, 1, 1E-08)]
[TestCase(199.1223345568, 199.1223345567, 1E-10)]
[TestCase(-199.1223345568, 199.1223345567, 1E-10)]
[TestCase(-199.1223345567, 199.1223345567, 1E-10)]
public void TestDefaultCheck(double value, double def, double? precision = null)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

`def` [double](https://learn.microsoft.com/dotnet/api/system.double)

`precision` [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestDefaultCheck_System_Double_System_Double_System_Nullable_System_Double__"></a> TestDefaultCheck\(double, double, double?\)

```csharp
[TestCase(-1, 1)]
[TestCase(1.1, 1)]
[TestCase(-1.1, 1)]
[TestCase(-1, 1, 1E-08)]
[TestCase(1.00000001, 1, 1E-08)]
[TestCase(-1.00000001, 1, 1E-08)]
[TestCase(0.99999999, 1, 1E-08)]
[TestCase(-0.99999999, 1, 1E-08)]
[TestCase(199.1223345568, 199.1223345567, 1E-10)]
[TestCase(-199.1223345568, 199.1223345567, 1E-10)]
[TestCase(-199.1223345567, 199.1223345567, 1E-10)]
public void TestDefaultCheck(double value, double def, double? precision = null)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

`def` [double](https://learn.microsoft.com/dotnet/api/system.double)

`precision` [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingDouble_System_Double_"></a> TestParsingDouble\(double\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-1.7976931348623157E+308)]
[TestCase(1.7976931348623157E+308)]
public void TestParsingDouble(double value)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingDouble_System_Double_"></a> TestParsingDouble\(double\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-1.7976931348623157E+308)]
[TestCase(1.7976931348623157E+308)]
public void TestParsingDouble(double value)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingDouble_System_Double_"></a> TestParsingDouble\(double\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-1.7976931348623157E+308)]
[TestCase(1.7976931348623157E+308)]
public void TestParsingDouble(double value)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingNumberLocale_System_Double_System_String_System_String_"></a> TestParsingNumberLocale\(double, string, string\)

```csharp
[TestCase(1.4, "en-US", "1.4")]
[TestCase(1.4, "de-DE", "1,4")]
[TestCase(1400.01, "de-DE", "1400,01")]
[TestCase(1234.57, "ru-RU", "1234,57")]
[TestCase(1.094, "fr-FR", "1,094")]
[TestCase(1400.01, "zh-CN", "1400.01")]
public void TestParsingNumberLocale(double value, string locale, string expected)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingNumberLocale_System_Double_System_String_System_String_"></a> TestParsingNumberLocale\(double, string, string\)

```csharp
[TestCase(1.4, "en-US", "1.4")]
[TestCase(1.4, "de-DE", "1,4")]
[TestCase(1400.01, "de-DE", "1400,01")]
[TestCase(1234.57, "ru-RU", "1234,57")]
[TestCase(1.094, "fr-FR", "1,094")]
[TestCase(1400.01, "zh-CN", "1400.01")]
public void TestParsingNumberLocale(double value, string locale, string expected)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingNumberLocale_System_Double_System_String_System_String_"></a> TestParsingNumberLocale\(double, string, string\)

```csharp
[TestCase(1.4, "en-US", "1.4")]
[TestCase(1.4, "de-DE", "1,4")]
[TestCase(1400.01, "de-DE", "1400,01")]
[TestCase(1234.57, "ru-RU", "1234,57")]
[TestCase(1.094, "fr-FR", "1,094")]
[TestCase(1400.01, "zh-CN", "1400.01")]
public void TestParsingNumberLocale(double value, string locale, string expected)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingString_System_String_System_Double_"></a> TestParsingString\(string, double\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105.123", -105.123)]
[TestCase("105.123", 105.123)]
public void TestParsingString(string value, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingString_System_String_System_Double_"></a> TestParsingString\(string, double\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105.123", -105.123)]
[TestCase("105.123", 105.123)]
public void TestParsingString(string value, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingString_System_String_System_Double_"></a> TestParsingString\(string, double\)

```csharp
[TestCase("0", 0)]
[TestCase("1", 1)]
[TestCase("-0", 0)]
[TestCase("-105.123", -105.123)]
[TestCase("105.123", 105.123)]
public void TestParsingString(string value, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingStringLocale_System_String_System_String_System_Double_"></a> TestParsingStringLocale\(string, string, double\)

```csharp
[TestCase("1.4", "en-US", 1.4)]
[TestCase("1,4", "de-DE", 1.4)]
[TestCase("1.400,01", "de-DE", 1400.01)]
[TestCase("1 234,57", "ru-RU", 1234.57)]
[TestCase("1,094", "fr-FR", 1.094)]
[TestCase("1,400.01", "zh-CN", 1400.01)]
public void TestParsingStringLocale(string value, string locale, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingStringLocale_System_String_System_String_System_Double_"></a> TestParsingStringLocale\(string, string, double\)

```csharp
[TestCase("1.4", "en-US", 1.4)]
[TestCase("1,4", "de-DE", 1.4)]
[TestCase("1.400,01", "de-DE", 1400.01)]
[TestCase("1 234,57", "ru-RU", 1234.57)]
[TestCase("1,094", "fr-FR", 1.094)]
[TestCase("1,400.01", "zh-CN", 1400.01)]
public void TestParsingStringLocale(string value, string locale, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingStringLocale_System_String_System_String_System_Double_"></a> TestParsingStringLocale\(string, string, double\)

```csharp
[TestCase("1.4", "en-US", 1.4)]
[TestCase("1,4", "de-DE", 1.4)]
[TestCase("1.400,01", "de-DE", 1400.01)]
[TestCase("1 234,57", "ru-RU", 1234.57)]
[TestCase("1,094", "fr-FR", 1.094)]
[TestCase("1,400.01", "zh-CN", 1400.01)]
public void TestParsingStringLocale(string value, string locale, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`locale` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingStringWithRange_System_String_System_Double_System_Double_System_Double_"></a> TestParsingStringWithRange\(string, double, double, double\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105.123", -10, 10, -10 })]
[TestCase(new object?[] { "105.123", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, double minValue, double maxValue, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`maxValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingStringWithRange_System_String_System_Double_System_Double_System_Double_"></a> TestParsingStringWithRange\(string, double, double, double\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105.123", -10, 10, -10 })]
[TestCase(new object?[] { "105.123", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, double minValue, double maxValue, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`maxValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestParsingStringWithRange_System_String_System_Double_System_Double_System_Double_"></a> TestParsingStringWithRange\(string, double, double, double\)

```csharp
[TestCase(new object?[] { "0", -10, 10, 0 })]
[TestCase(new object?[] { "1", -10, 10, 1 })]
[TestCase(new object?[] { "-0", -10, 10, 0 })]
[TestCase(new object?[] { "-105.123", -10, 10, -10 })]
[TestCase(new object?[] { "105.123", -10, 10, 10 })]
public void TestParsingStringWithRange(string value, double minValue, double maxValue, double expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`maxValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`expected` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestPropagationToPlainBindable"></a> TestPropagationToPlainBindable\(\)

```csharp
[Test]
public void TestPropagationToPlainBindable()
```

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestPropagationToPlainBindable"></a> TestPropagationToPlainBindable\(\)

```csharp
[Test]
public void TestPropagationToPlainBindable()
```

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestPropagationToPlainBindable"></a> TestPropagationToPlainBindable\(\)

```csharp
[Test]
public void TestPropagationToPlainBindable()
```

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestSet_System_Double_"></a> TestSet\(double\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-1.7976931348623157E+308)]
[TestCase(1.7976931348623157E+308)]
public void TestSet(double value)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestSet_System_Double_"></a> TestSet\(double\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-1.7976931348623157E+308)]
[TestCase(1.7976931348623157E+308)]
public void TestSet(double value)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Bindables_BindableDoubleTest_TestSet_System_Double_"></a> TestSet\(double\)

```csharp
[TestCase(0)]
[TestCase(0)]
[TestCase(1)]
[TestCase(-105.123)]
[TestCase(105.123)]
[TestCase(-1.7976931348623157E+308)]
[TestCase(1.7976931348623157E+308)]
public void TestSet(double value)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

