# <a id="osu_Framework_Tests_Primitives_QuadTest"></a> Class QuadTest

Namespace: [osu.Framework.Tests.Primitives](osu.Framework.Tests.Primitives.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class QuadTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[QuadTest](osu.Framework.Tests.Primitives.QuadTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<QuadTest\>\(QuadTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<QuadTest\>\(QuadTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<QuadTest\>\(QuadTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<QuadTest\>\(QuadTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<QuadTest, TChild\>\(QuadTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<QuadTest, TChild\>\(QuadTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<QuadTest, TChild\>\(QuadTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<QuadTest\>\(QuadTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestArea_osu_Framework_Graphics_Primitives_Quad_"></a> TestArea\(Quad\)

```csharp
[TestCaseSource(typeof(QuadTest.AreaTestData), "TestCases")]
[DefaultFloatingPointTolerance(0.10000000149011612)]
public float TestArea(Quad testQuad)
```

#### Parameters

`testQuad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestArea_osu_Framework_Graphics_Primitives_Quad_"></a> TestArea\(Quad\)

```csharp
[TestCaseSource(typeof(QuadTest.AreaTestData), "TestCases")]
[DefaultFloatingPointTolerance(0.10000000149011612)]
public float TestArea(Quad testQuad)
```

#### Parameters

`testQuad` Quad

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestArea_osu_Framework_Graphics_Primitives_Quad_"></a> TestArea\(Quad\)

```csharp
[TestCaseSource(typeof(QuadTest.AreaTestData), "TestCases")]
[DefaultFloatingPointTolerance(0.10000000149011612)]
public float TestArea(Quad testQuad)
```

#### Parameters

`testQuad` Quad

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_osu_Framework_Graphics_Primitives_Quad_"></a> TestContains\(Quad\)

```csharp
[TestCaseSource("test_quads")]
public void TestContains(Quad quad)
```

#### Parameters

`quad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_osu_Framework_Graphics_Primitives_Quad_"></a> TestContains\(Quad\)

```csharp
[TestCaseSource("test_quads")]
public void TestContains(Quad quad)
```

#### Parameters

`quad` Quad

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_osu_Framework_Graphics_Primitives_Quad_"></a> TestContains\(Quad\)

```csharp
[TestCaseSource("test_quads")]
public void TestContains(Quad quad)
```

#### Parameters

`quad` Quad

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroHeightQuad"></a> TestContains\_ZeroHeightQuad\(\)

```csharp
[Test]
public void TestContains_ZeroHeightQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroHeightQuad"></a> TestContains\_ZeroHeightQuad\(\)

```csharp
[Test]
public void TestContains_ZeroHeightQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroHeightQuad"></a> TestContains\_ZeroHeightQuad\(\)

```csharp
[Test]
public void TestContains_ZeroHeightQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroSizedQuad"></a> TestContains\_ZeroSizedQuad\(\)

```csharp
[Test]
public void TestContains_ZeroSizedQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroSizedQuad"></a> TestContains\_ZeroSizedQuad\(\)

```csharp
[Test]
public void TestContains_ZeroSizedQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroSizedQuad"></a> TestContains\_ZeroSizedQuad\(\)

```csharp
[Test]
public void TestContains_ZeroSizedQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroWidthQuad"></a> TestContains\_ZeroWidthQuad\(\)

```csharp
[Test]
public void TestContains_ZeroWidthQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroWidthQuad"></a> TestContains\_ZeroWidthQuad\(\)

```csharp
[Test]
public void TestContains_ZeroWidthQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestContains_ZeroWidthQuad"></a> TestContains\_ZeroWidthQuad\(\)

```csharp
[Test]
public void TestContains_ZeroWidthQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestFlippedQuad"></a> TestFlippedQuad\(\)

```csharp
[Test]
public void TestFlippedQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestFlippedQuad"></a> TestFlippedQuad\(\)

```csharp
[Test]
public void TestFlippedQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestFlippedQuad"></a> TestFlippedQuad\(\)

```csharp
[Test]
public void TestFlippedQuad()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestFromNegativeSizedRectangle"></a> TestFromNegativeSizedRectangle\(\)

```csharp
[Test]
public void TestFromNegativeSizedRectangle()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestFromNegativeSizedRectangle"></a> TestFromNegativeSizedRectangle\(\)

```csharp
[Test]
public void TestFromNegativeSizedRectangle()
```

### <a id="osu_Framework_Tests_Primitives_QuadTest_TestFromNegativeSizedRectangle"></a> TestFromNegativeSizedRectangle\(\)

```csharp
[Test]
public void TestFromNegativeSizedRectangle()
```

