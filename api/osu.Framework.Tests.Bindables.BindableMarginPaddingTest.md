# <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest"></a> Class BindableMarginPaddingTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableMarginPaddingTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableMarginPaddingTest](osu.Framework.Tests.Bindables.BindableMarginPaddingTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableMarginPaddingTest\>\(BindableMarginPaddingTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableMarginPaddingTest\>\(BindableMarginPaddingTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableMarginPaddingTest\>\(BindableMarginPaddingTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableMarginPaddingTest\>\(BindableMarginPaddingTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableMarginPaddingTest, TChild\>\(BindableMarginPaddingTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableMarginPaddingTest, TChild\>\(BindableMarginPaddingTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableMarginPaddingTest, TChild\>\(BindableMarginPaddingTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableMarginPaddingTest\>\(BindableMarginPaddingTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestParsingString_System_String_System_Single_System_Single_System_Single_System_Single_"></a> TestParsingString\(string, float, float, float, float\)

```csharp
[TestCase(new object?[] { "(0, 0, 0, 0)", 0, 0, 0, 0 })]
[TestCase(new object?[] { "(-0, -0, -0, -0)", 0, 0, 0, 0 })]
[TestCase(new object?[] { "(1, 2, 3, 4)", 1, 2, 3, 4 })]
[TestCase(new object?[] { "(1.5, 2.5, 3.5, 4.5)", 1.5, 2.5, 3.5, 4.5 })]
public void TestParsingString(string value, float expectedTop, float expectedLeft, float expectedBottom, float expectedRight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestParsingString_System_String_System_Single_System_Single_System_Single_System_Single_"></a> TestParsingString\(string, float, float, float, float\)

```csharp
[TestCase(new object?[] { "(0, 0, 0, 0)", 0, 0, 0, 0 })]
[TestCase(new object?[] { "(-0, -0, -0, -0)", 0, 0, 0, 0 })]
[TestCase(new object?[] { "(1, 2, 3, 4)", 1, 2, 3, 4 })]
[TestCase(new object?[] { "(1.5, 2.5, 3.5, 4.5)", 1.5, 2.5, 3.5, 4.5 })]
public void TestParsingString(string value, float expectedTop, float expectedLeft, float expectedBottom, float expectedRight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestParsingString_System_String_System_Single_System_Single_System_Single_System_Single_"></a> TestParsingString\(string, float, float, float, float\)

```csharp
[TestCase(new object?[] { "(0, 0, 0, 0)", 0, 0, 0, 0 })]
[TestCase(new object?[] { "(-0, -0, -0, -0)", 0, 0, 0, 0 })]
[TestCase(new object?[] { "(1, 2, 3, 4)", 1, 2, 3, 4 })]
[TestCase(new object?[] { "(1.5, 2.5, 3.5, 4.5)", 1.5, 2.5, 3.5, 4.5 })]
public void TestParsingString(string value, float expectedTop, float expectedLeft, float expectedBottom, float expectedRight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestParsingStringWithRange_System_String_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> TestParsingStringWithRange\(string, float, float, float, float, float, float, float, float, float, float, float, float\)

```csharp
[TestCase(new object?[] { "(0, 0, 0, 0)", -10, -10, -10, -10, 10, 10, 10, 10, 0, 0, 0, 0 })]
[TestCase(new object?[] { "(5, -5, 5, -5)", -10, -10, -10, -10, 10, 10, 10, 10, 5, -5, 5, -5 })]
[TestCase(new object?[] { "(-100, -100, -100, -100)", -10, -10, -10, -10, 10, 10, 10, 10, -10, -10, -10, -10 })]
[TestCase(new object?[] { "(100, 100, 100, 100)", -10, -10, -10, -10, 10, 10, 10, 10, 10, 10, 10, 10 })]
public void TestParsingStringWithRange(string value, float minValueTop, float minValueLeft, float minValueBottom, float minValueRight, float maxValueTop, float maxValueLeft, float maxValueBottom, float maxValueRight, float expectedTop, float expectedLeft, float expectedBottom, float expectedRight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValueTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestParsingStringWithRange_System_String_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> TestParsingStringWithRange\(string, float, float, float, float, float, float, float, float, float, float, float, float\)

```csharp
[TestCase(new object?[] { "(0, 0, 0, 0)", -10, -10, -10, -10, 10, 10, 10, 10, 0, 0, 0, 0 })]
[TestCase(new object?[] { "(5, -5, 5, -5)", -10, -10, -10, -10, 10, 10, 10, 10, 5, -5, 5, -5 })]
[TestCase(new object?[] { "(-100, -100, -100, -100)", -10, -10, -10, -10, 10, 10, 10, 10, -10, -10, -10, -10 })]
[TestCase(new object?[] { "(100, 100, 100, 100)", -10, -10, -10, -10, 10, 10, 10, 10, 10, 10, 10, 10 })]
public void TestParsingStringWithRange(string value, float minValueTop, float minValueLeft, float minValueBottom, float minValueRight, float maxValueTop, float maxValueLeft, float maxValueBottom, float maxValueRight, float expectedTop, float expectedLeft, float expectedBottom, float expectedRight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValueTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestParsingStringWithRange_System_String_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> TestParsingStringWithRange\(string, float, float, float, float, float, float, float, float, float, float, float, float\)

```csharp
[TestCase(new object?[] { "(0, 0, 0, 0)", -10, -10, -10, -10, 10, 10, 10, 10, 0, 0, 0, 0 })]
[TestCase(new object?[] { "(5, -5, 5, -5)", -10, -10, -10, -10, 10, 10, 10, 10, 5, -5, 5, -5 })]
[TestCase(new object?[] { "(-100, -100, -100, -100)", -10, -10, -10, -10, 10, 10, 10, 10, -10, -10, -10, -10 })]
[TestCase(new object?[] { "(100, 100, 100, 100)", -10, -10, -10, -10, 10, 10, 10, 10, 10, 10, 10, 10 })]
public void TestParsingStringWithRange(string value, float minValueTop, float minValueLeft, float minValueBottom, float minValueRight, float maxValueTop, float maxValueLeft, float maxValueBottom, float maxValueRight, float expectedTop, float expectedLeft, float expectedBottom, float expectedRight)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`minValueTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minValueRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maxValueRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedLeft` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`expectedRight` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestSet_System_Single_System_Single_System_Single_System_Single_"></a> TestSet\(float, float, float, float\)

```csharp
[TestCase(new object?[] { 0, 0, 0, 0 })]
[TestCase(new object?[] { 0, 1, 2, 3 })]
[TestCase(new object?[] { 1, -1, 2, -2 })]
[TestCase(new object?[] { -3.4028235E+38, -3.4028235E+38, -3.4028235E+38, -3.4028235E+38 })]
[TestCase(new object?[] { 3.4028235E+38, 3.4028235E+38, 3.4028235E+38, 3.4028235E+38 })]
[TestCase(new object?[] { -3.4028235E+38, 0, 0, 0 })]
public void TestSet(float top, float left, float bottom, float right)
```

#### Parameters

`top` [float](https://learn.microsoft.com/dotnet/api/system.single)

`left` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestSet_System_Single_System_Single_System_Single_System_Single_"></a> TestSet\(float, float, float, float\)

```csharp
[TestCase(new object?[] { 0, 0, 0, 0 })]
[TestCase(new object?[] { 0, 1, 2, 3 })]
[TestCase(new object?[] { 1, -1, 2, -2 })]
[TestCase(new object?[] { -3.4028235E+38, -3.4028235E+38, -3.4028235E+38, -3.4028235E+38 })]
[TestCase(new object?[] { 3.4028235E+38, 3.4028235E+38, 3.4028235E+38, 3.4028235E+38 })]
[TestCase(new object?[] { -3.4028235E+38, 0, 0, 0 })]
public void TestSet(float top, float left, float bottom, float right)
```

#### Parameters

`top` [float](https://learn.microsoft.com/dotnet/api/system.single)

`left` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Bindables_BindableMarginPaddingTest_TestSet_System_Single_System_Single_System_Single_System_Single_"></a> TestSet\(float, float, float, float\)

```csharp
[TestCase(new object?[] { 0, 0, 0, 0 })]
[TestCase(new object?[] { 0, 1, 2, 3 })]
[TestCase(new object?[] { 1, -1, 2, -2 })]
[TestCase(new object?[] { -3.4028235E+38, -3.4028235E+38, -3.4028235E+38, -3.4028235E+38 })]
[TestCase(new object?[] { 3.4028235E+38, 3.4028235E+38, 3.4028235E+38, 3.4028235E+38 })]
[TestCase(new object?[] { -3.4028235E+38, 0, 0, 0 })]
public void TestSet(float top, float left, float bottom, float right)
```

#### Parameters

`top` [float](https://learn.microsoft.com/dotnet/api/system.single)

`left` [float](https://learn.microsoft.com/dotnet/api/system.single)

`bottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

