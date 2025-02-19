# <a id="osu_Framework_Tests_Bindables_BindableSizeTest"></a> Class BindableSizeTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableSizeTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableSizeTest](osu.Framework.Tests.Bindables.BindableSizeTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableSizeTest\>\(BindableSizeTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableSizeTest\>\(BindableSizeTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableSizeTest\>\(BindableSizeTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableSizeTest\>\(BindableSizeTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableSizeTest, TChild\>\(BindableSizeTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableSizeTest, TChild\>\(BindableSizeTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableSizeTest, TChild\>\(BindableSizeTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableSizeTest\>\(BindableSizeTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingSize_System_Int32_System_Int32_"></a> TestParsingSize\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 0)]
[TestCase(1, -1)]
[TestCase(2147483647, -2147483648)]
public void TestParsingSize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingSize_System_Int32_System_Int32_"></a> TestParsingSize\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 0)]
[TestCase(1, -1)]
[TestCase(2147483647, -2147483648)]
public void TestParsingSize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingSize_System_Int32_System_Int32_"></a> TestParsingSize\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 0)]
[TestCase(1, -1)]
[TestCase(2147483647, -2147483648)]
public void TestParsingSize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingString_System_String_System_Int32_System_Int32_"></a> TestParsingString\(string, int, int\)

```csharp
[TestCase("0x0", 0, 0)]
[TestCase("-0x-0", 0, 0)]
[TestCase("1920x1080", 1920, 1080)]
[TestCase("-1000x0", -1000, 0)]
[TestCase("0x-1000", 0, -1000)]
public void TestParsingString(string value, int expectedWidth, int expectedHeight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingString_System_String_System_Int32_System_Int32_"></a> TestParsingString\(string, int, int\)

```csharp
[TestCase("0x0", 0, 0)]
[TestCase("-0x-0", 0, 0)]
[TestCase("1920x1080", 1920, 1080)]
[TestCase("-1000x0", -1000, 0)]
[TestCase("0x-1000", 0, -1000)]
public void TestParsingString(string value, int expectedWidth, int expectedHeight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingString_System_String_System_Int32_System_Int32_"></a> TestParsingString\(string, int, int\)

```csharp
[TestCase("0x0", 0, 0)]
[TestCase("-0x-0", 0, 0)]
[TestCase("1920x1080", 1920, 1080)]
[TestCase("-1000x0", -1000, 0)]
[TestCase("0x-1000", 0, -1000)]
public void TestParsingString(string value, int expectedWidth, int expectedHeight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingStringWithRange_System_String_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_"></a> TestParsingStringWithRange\(string, int, int, int, int, int, int\)

```csharp
[TestCase(new object?[] { "0x0", -10, -10, 10, 10, 0, 0 })]
[TestCase(new object?[] { "5x-5", -10, -10, 10, 10, 5, -5 })]
[TestCase(new object?[] { "0x-100", 0, -10, 0, 10, 0, -10 })]
[TestCase(new object?[] { "120x0", -10, -10, 10, 10, 10, 0 })]
[TestCase(new object?[] { "-100x400", -25, 200, 25, 300, -25, 300 })]
public void TestParsingStringWithRange(string value, int minValueWidth, int minValueHeight, int maxValueWidth, int maxValueHeight, int expectedWidth, int expectedHeight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValueWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`minValueHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValueWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValueHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingStringWithRange_System_String_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_"></a> TestParsingStringWithRange\(string, int, int, int, int, int, int\)

```csharp
[TestCase(new object?[] { "0x0", -10, -10, 10, 10, 0, 0 })]
[TestCase(new object?[] { "5x-5", -10, -10, 10, 10, 5, -5 })]
[TestCase(new object?[] { "0x-100", 0, -10, 0, 10, 0, -10 })]
[TestCase(new object?[] { "120x0", -10, -10, 10, 10, 10, 0 })]
[TestCase(new object?[] { "-100x400", -25, 200, 25, 300, -25, 300 })]
public void TestParsingStringWithRange(string value, int minValueWidth, int minValueHeight, int maxValueWidth, int maxValueHeight, int expectedWidth, int expectedHeight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValueWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`minValueHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValueWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValueHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestParsingStringWithRange_System_String_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_"></a> TestParsingStringWithRange\(string, int, int, int, int, int, int\)

```csharp
[TestCase(new object?[] { "0x0", -10, -10, 10, 10, 0, 0 })]
[TestCase(new object?[] { "5x-5", -10, -10, 10, 10, 5, -5 })]
[TestCase(new object?[] { "0x-100", 0, -10, 0, 10, 0, -10 })]
[TestCase(new object?[] { "120x0", -10, -10, 10, 10, 10, 0 })]
[TestCase(new object?[] { "-100x400", -25, 200, 25, 300, -25, 300 })]
public void TestParsingStringWithRange(string value, int minValueWidth, int minValueHeight, int maxValueWidth, int maxValueHeight, int expectedWidth, int expectedHeight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValueWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`minValueHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValueWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxValueHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`expectedHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestSet_System_Int32_System_Int32_"></a> TestSet\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 0)]
[TestCase(1, -1)]
[TestCase(-2147483648, -2147483648)]
[TestCase(2147483647, 2147483647)]
[TestCase(-2147483648, 0)]
public void TestSet(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestSet_System_Int32_System_Int32_"></a> TestSet\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 0)]
[TestCase(1, -1)]
[TestCase(-2147483648, -2147483648)]
[TestCase(2147483647, 2147483647)]
[TestCase(-2147483648, 0)]
public void TestSet(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Bindables_BindableSizeTest_TestSet_System_Int32_System_Int32_"></a> TestSet\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 0)]
[TestCase(1, -1)]
[TestCase(-2147483648, -2147483648)]
[TestCase(2147483647, 2147483647)]
[TestCase(-2147483648, 0)]
public void TestSet(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

