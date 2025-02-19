# <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest"></a> Class RangeConstrainedBindableTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class RangeConstrainedBindableTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RangeConstrainedBindableTest](osu.Framework.Tests.Bindables.RangeConstrainedBindableTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RangeConstrainedBindableTest\>\(RangeConstrainedBindableTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RangeConstrainedBindableTest\>\(RangeConstrainedBindableTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RangeConstrainedBindableTest\>\(RangeConstrainedBindableTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RangeConstrainedBindableTest\>\(RangeConstrainedBindableTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<RangeConstrainedBindableTest, TChild\>\(RangeConstrainedBindableTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RangeConstrainedBindableTest, TChild\>\(RangeConstrainedBindableTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RangeConstrainedBindableTest, TChild\>\(RangeConstrainedBindableTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RangeConstrainedBindableTest\>\(RangeConstrainedBindableTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestBindToAnotherBindableWithDisjointRange"></a> TestBindToAnotherBindableWithDisjointRange\(\)

```csharp
[Test]
public void TestBindToAnotherBindableWithDisjointRange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestBindToAnotherBindableWithDisjointRange"></a> TestBindToAnotherBindableWithDisjointRange\(\)

```csharp
[Test]
public void TestBindToAnotherBindableWithDisjointRange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestBindToAnotherBindableWithDisjointRange"></a> TestBindToAnotherBindableWithDisjointRange\(\)

```csharp
[Test]
public void TestBindToAnotherBindableWithDisjointRange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestDefaultMaxValueAppliedInConstructor"></a> TestDefaultMaxValueAppliedInConstructor\(\)

```csharp
[Test]
public void TestDefaultMaxValueAppliedInConstructor()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestDefaultMaxValueAppliedInConstructor"></a> TestDefaultMaxValueAppliedInConstructor\(\)

```csharp
[Test]
public void TestDefaultMaxValueAppliedInConstructor()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestDefaultMaxValueAppliedInConstructor"></a> TestDefaultMaxValueAppliedInConstructor\(\)

```csharp
[Test]
public void TestDefaultMaxValueAppliedInConstructor()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestDefaultMinValueAppliedInConstructor"></a> TestDefaultMinValueAppliedInConstructor\(\)

```csharp
[Test]
public void TestDefaultMinValueAppliedInConstructor()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestDefaultMinValueAppliedInConstructor"></a> TestDefaultMinValueAppliedInConstructor\(\)

```csharp
[Test]
public void TestDefaultMinValueAppliedInConstructor()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestDefaultMinValueAppliedInConstructor"></a> TestDefaultMinValueAppliedInConstructor\(\)

```csharp
[Test]
public void TestDefaultMinValueAppliedInConstructor()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueChangeEventOccursAfterMaxValueChangeEvent"></a> TestValueChangeEventOccursAfterMaxValueChangeEvent\(\)

Tests that the order of maximum value vs value changed events follows the order:
MaxValue (bound) -&gt; MaxValue -&gt; Value (bound) -&gt; Value

```csharp
[Test]
public void TestValueChangeEventOccursAfterMaxValueChangeEvent()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueChangeEventOccursAfterMaxValueChangeEvent"></a> TestValueChangeEventOccursAfterMaxValueChangeEvent\(\)

Tests that the order of maximum value vs value changed events follows the order:
MaxValue (bound) -&gt; MaxValue -&gt; Value (bound) -&gt; Value

```csharp
[Test]
public void TestValueChangeEventOccursAfterMaxValueChangeEvent()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueChangeEventOccursAfterMaxValueChangeEvent"></a> TestValueChangeEventOccursAfterMaxValueChangeEvent\(\)

Tests that the order of maximum value vs value changed events follows the order:
MaxValue (bound) -&gt; MaxValue -&gt; Value (bound) -&gt; Value

```csharp
[Test]
public void TestValueChangeEventOccursAfterMaxValueChangeEvent()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueChangeEventOccursAfterMinValueChangeEvent"></a> TestValueChangeEventOccursAfterMinValueChangeEvent\(\)

Tests that the order of minimum value vs value changed events follows the order:
MinValue (bound) -&gt; MinValue -&gt; Value (bound) -&gt; Value

```csharp
[Test]
public void TestValueChangeEventOccursAfterMinValueChangeEvent()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueChangeEventOccursAfterMinValueChangeEvent"></a> TestValueChangeEventOccursAfterMinValueChangeEvent\(\)

Tests that the order of minimum value vs value changed events follows the order:
MinValue (bound) -&gt; MinValue -&gt; Value (bound) -&gt; Value

```csharp
[Test]
public void TestValueChangeEventOccursAfterMinValueChangeEvent()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueChangeEventOccursAfterMinValueChangeEvent"></a> TestValueChangeEventOccursAfterMinValueChangeEvent\(\)

Tests that the order of minimum value vs value changed events follows the order:
MinValue (bound) -&gt; MinValue -&gt; Value (bound) -&gt; Value

```csharp
[Test]
public void TestValueChangeEventOccursAfterMinValueChangeEvent()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueUpdatedOnMaxValueChange"></a> TestValueUpdatedOnMaxValueChange\(\)

Tests that the value of a bindable is updated when the maximum value is changed.

```csharp
[Test]
public void TestValueUpdatedOnMaxValueChange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueUpdatedOnMaxValueChange"></a> TestValueUpdatedOnMaxValueChange\(\)

Tests that the value of a bindable is updated when the maximum value is changed.

```csharp
[Test]
public void TestValueUpdatedOnMaxValueChange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueUpdatedOnMaxValueChange"></a> TestValueUpdatedOnMaxValueChange\(\)

Tests that the value of a bindable is updated when the maximum value is changed.

```csharp
[Test]
public void TestValueUpdatedOnMaxValueChange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueUpdatedOnMinValueChange"></a> TestValueUpdatedOnMinValueChange\(\)

Tests that the value of a bindable is updated when the minimum value is changed.

```csharp
[Test]
public void TestValueUpdatedOnMinValueChange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueUpdatedOnMinValueChange"></a> TestValueUpdatedOnMinValueChange\(\)

Tests that the value of a bindable is updated when the minimum value is changed.

```csharp
[Test]
public void TestValueUpdatedOnMinValueChange()
```

### <a id="osu_Framework_Tests_Bindables_RangeConstrainedBindableTest_TestValueUpdatedOnMinValueChange"></a> TestValueUpdatedOnMinValueChange\(\)

Tests that the value of a bindable is updated when the minimum value is changed.

```csharp
[Test]
public void TestValueUpdatedOnMinValueChange()
```

