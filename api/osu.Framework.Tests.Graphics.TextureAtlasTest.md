# <a id="osu_Framework_Tests_Graphics_TextureAtlasTest"></a> Class TextureAtlasTest

Namespace: [osu.Framework.Tests.Graphics](osu.Framework.Tests.Graphics.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class TextureAtlasTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureAtlasTest](osu.Framework.Tests.Graphics.TextureAtlasTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextureAtlasTest\>\(TextureAtlasTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextureAtlasTest\>\(TextureAtlasTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextureAtlasTest\>\(TextureAtlasTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextureAtlasTest\>\(TextureAtlasTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextureAtlasTest, TChild\>\(TextureAtlasTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextureAtlasTest, TChild\>\(TextureAtlasTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextureAtlasTest, TChild\>\(TextureAtlasTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextureAtlasTest\>\(TextureAtlasTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasAdd_System_Int32_System_Int32_"></a> TestAtlasAdd\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 1)]
[TestCase(984, 20)]
[TestCase(985, 20)]
[TestCase(1008, 20)]
[TestCase(1020, 20)]
[TestCase(1024, 20)]
[TestCase(1025, 20)]
[TestCase(20, 984)]
[TestCase(20, 985)]
[TestCase(20, 1008)]
[TestCase(20, 1020)]
[TestCase(20, 1024)]
[TestCase(20, 1500)]
[TestCase(984, 984)]
[TestCase(985, 985)]
[TestCase(1020, 985)]
[TestCase(1500, 985)]
[TestCase(1008, 1008)]
[TestCase(1020, 1020)]
[TestCase(1500, 1500)]
public void TestAtlasAdd(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasAdd_System_Int32_System_Int32_"></a> TestAtlasAdd\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 1)]
[TestCase(984, 20)]
[TestCase(985, 20)]
[TestCase(1008, 20)]
[TestCase(1020, 20)]
[TestCase(1024, 20)]
[TestCase(1025, 20)]
[TestCase(20, 984)]
[TestCase(20, 985)]
[TestCase(20, 1008)]
[TestCase(20, 1020)]
[TestCase(20, 1024)]
[TestCase(20, 1500)]
[TestCase(984, 984)]
[TestCase(985, 985)]
[TestCase(1020, 985)]
[TestCase(1500, 985)]
[TestCase(1008, 1008)]
[TestCase(1020, 1020)]
[TestCase(1500, 1500)]
public void TestAtlasAdd(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasAdd_System_Int32_System_Int32_"></a> TestAtlasAdd\(int, int\)

```csharp
[TestCase(0, 0)]
[TestCase(1, 1)]
[TestCase(984, 20)]
[TestCase(985, 20)]
[TestCase(1008, 20)]
[TestCase(1020, 20)]
[TestCase(1024, 20)]
[TestCase(1025, 20)]
[TestCase(20, 984)]
[TestCase(20, 985)]
[TestCase(20, 1008)]
[TestCase(20, 1020)]
[TestCase(20, 1024)]
[TestCase(20, 1500)]
[TestCase(984, 984)]
[TestCase(985, 985)]
[TestCase(1020, 985)]
[TestCase(1500, 985)]
[TestCase(1008, 1008)]
[TestCase(1020, 1020)]
[TestCase(1500, 1500)]
public void TestAtlasAdd(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasFirstRowAddRespectsWhitePixelSize"></a> TestAtlasFirstRowAddRespectsWhitePixelSize\(\)

```csharp
[Test]
public void TestAtlasFirstRowAddRespectsWhitePixelSize()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasFirstRowAddRespectsWhitePixelSize"></a> TestAtlasFirstRowAddRespectsWhitePixelSize\(\)

```csharp
[Test]
public void TestAtlasFirstRowAddRespectsWhitePixelSize()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasFirstRowAddRespectsWhitePixelSize"></a> TestAtlasFirstRowAddRespectsWhitePixelSize\(\)

```csharp
[Test]
public void TestAtlasFirstRowAddRespectsWhitePixelSize()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasSecondRowAddRespectsWhitePixelSize"></a> TestAtlasSecondRowAddRespectsWhitePixelSize\(\)

```csharp
[Test]
public void TestAtlasSecondRowAddRespectsWhitePixelSize()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasSecondRowAddRespectsWhitePixelSize"></a> TestAtlasSecondRowAddRespectsWhitePixelSize\(\)

```csharp
[Test]
public void TestAtlasSecondRowAddRespectsWhitePixelSize()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestAtlasSecondRowAddRespectsWhitePixelSize"></a> TestAtlasSecondRowAddRespectsWhitePixelSize\(\)

```csharp
[Test]
public void TestAtlasSecondRowAddRespectsWhitePixelSize()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestSubTextureIsAtlasTexture"></a> TestSubTextureIsAtlasTexture\(\)

```csharp
[Test]
public void TestSubTextureIsAtlasTexture()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestSubTextureIsAtlasTexture"></a> TestSubTextureIsAtlasTexture\(\)

```csharp
[Test]
public void TestSubTextureIsAtlasTexture()
```

### <a id="osu_Framework_Tests_Graphics_TextureAtlasTest_TestSubTextureIsAtlasTexture"></a> TestSubTextureIsAtlasTexture\(\)

```csharp
[Test]
public void TestSubTextureIsAtlasTexture()
```

