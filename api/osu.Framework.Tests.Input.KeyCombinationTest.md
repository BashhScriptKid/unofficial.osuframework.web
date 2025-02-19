# <a id="osu_Framework_Tests_Input_KeyCombinationTest"></a> Class KeyCombinationTest

Namespace: [osu.Framework.Tests.Input](osu.Framework.Tests.Input.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class KeyCombinationTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[KeyCombinationTest](osu.Framework.Tests.Input.KeyCombinationTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<KeyCombinationTest\>\(KeyCombinationTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<KeyCombinationTest\>\(KeyCombinationTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<KeyCombinationTest\>\(KeyCombinationTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<KeyCombinationTest\>\(KeyCombinationTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<KeyCombinationTest, TChild\>\(KeyCombinationTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<KeyCombinationTest, TChild\>\(KeyCombinationTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<KeyCombinationTest, TChild\>\(KeyCombinationTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<KeyCombinationTest\>\(KeyCombinationTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestCreationNoDuplicates"></a> TestCreationNoDuplicates\(\)

```csharp
[Test]
public void TestCreationNoDuplicates()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestCreationNoDuplicates"></a> TestCreationNoDuplicates\(\)

```csharp
[Test]
public void TestCreationNoDuplicates()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestCreationNoDuplicates"></a> TestCreationNoDuplicates\(\)

```csharp
[Test]
public void TestCreationNoDuplicates()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestCreationWithDuplicates"></a> TestCreationWithDuplicates\(\)

```csharp
[Test]
public void TestCreationWithDuplicates()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestCreationWithDuplicates"></a> TestCreationWithDuplicates\(\)

```csharp
[Test]
public void TestCreationWithDuplicates()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestCreationWithDuplicates"></a> TestCreationWithDuplicates\(\)

```csharp
[Test]
public void TestCreationWithDuplicates()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestEmptyCombinationIsNeverPressed"></a> TestEmptyCombinationIsNeverPressed\(\)

```csharp
[Test]
public void TestEmptyCombinationIsNeverPressed()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestEmptyCombinationIsNeverPressed"></a> TestEmptyCombinationIsNeverPressed\(\)

```csharp
[Test]
public void TestEmptyCombinationIsNeverPressed()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestEmptyCombinationIsNeverPressed"></a> TestEmptyCombinationIsNeverPressed\(\)

```csharp
[Test]
public void TestEmptyCombinationIsNeverPressed()
```

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestLeftRightModifierHandling_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_Bindings_KeyCombinationMatchingMode_System_Boolean_"></a> TestLeftRightModifierHandling\(KeyCombination, KeyCombination, KeyCombinationMatchingMode, bool\)

```csharp
[TestCaseSource("key_combination_display_test_cases")]
public void TestLeftRightModifierHandling(KeyCombination candidate, KeyCombination pressed, KeyCombinationMatchingMode matchingMode, bool shouldContain)
```

#### Parameters

`candidate` [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

`pressed` [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

`matchingMode` [KeyCombinationMatchingMode](osu.Framework.Input.Bindings.KeyCombinationMatchingMode.md)

`shouldContain` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestLeftRightModifierHandling_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_Bindings_KeyCombinationMatchingMode_System_Boolean_"></a> TestLeftRightModifierHandling\(KeyCombination, KeyCombination, KeyCombinationMatchingMode, bool\)

```csharp
[TestCaseSource("key_combination_display_test_cases")]
public void TestLeftRightModifierHandling(KeyCombination candidate, KeyCombination pressed, KeyCombinationMatchingMode matchingMode, bool shouldContain)
```

#### Parameters

`candidate` KeyCombination

`pressed` KeyCombination

`matchingMode` KeyCombinationMatchingMode

`shouldContain` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Input_KeyCombinationTest_TestLeftRightModifierHandling_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_Bindings_KeyCombinationMatchingMode_System_Boolean_"></a> TestLeftRightModifierHandling\(KeyCombination, KeyCombination, KeyCombinationMatchingMode, bool\)

```csharp
[TestCaseSource("key_combination_display_test_cases")]
public void TestLeftRightModifierHandling(KeyCombination candidate, KeyCombination pressed, KeyCombinationMatchingMode matchingMode, bool shouldContain)
```

#### Parameters

`candidate` KeyCombination

`pressed` KeyCombination

`matchingMode` KeyCombinationMatchingMode

`shouldContain` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

