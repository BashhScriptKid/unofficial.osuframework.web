# <a id="osu_Framework_Tests_Bindables_BindableBoolTest"></a> Class BindableBoolTest

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableBoolTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableBoolTest](osu.Framework.Tests.Bindables.BindableBoolTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableBoolTest\>\(BindableBoolTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableBoolTest\>\(BindableBoolTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableBoolTest\>\(BindableBoolTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableBoolTest\>\(BindableBoolTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableBoolTest, TChild\>\(BindableBoolTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableBoolTest, TChild\>\(BindableBoolTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableBoolTest, TChild\>\(BindableBoolTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableBoolTest\>\(BindableBoolTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestParsingBoolean_System_Boolean_"></a> TestParsingBoolean\(bool\)

```csharp
[TestCase(true)]
[TestCase(false)]
public void TestParsingBoolean(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestParsingBoolean_System_Boolean_"></a> TestParsingBoolean\(bool\)

```csharp
[TestCase(true)]
[TestCase(false)]
public void TestParsingBoolean(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestParsingBoolean_System_Boolean_"></a> TestParsingBoolean\(bool\)

```csharp
[TestCase(true)]
[TestCase(false)]
public void TestParsingBoolean(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestParsingString_System_String_System_Boolean_"></a> TestParsingString\(string, bool\)

```csharp
[TestCase("True", true)]
[TestCase("true", true)]
[TestCase("False", false)]
[TestCase("false", false)]
[TestCase("1", true)]
[TestCase("0", false)]
public void TestParsingString(string value, bool expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestParsingString_System_String_System_Boolean_"></a> TestParsingString\(string, bool\)

```csharp
[TestCase("True", true)]
[TestCase("true", true)]
[TestCase("False", false)]
[TestCase("false", false)]
[TestCase("1", true)]
[TestCase("0", false)]
public void TestParsingString(string value, bool expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestParsingString_System_String_System_Boolean_"></a> TestParsingString\(string, bool\)

```csharp
[TestCase("True", true)]
[TestCase("true", true)]
[TestCase("False", false)]
[TestCase("false", false)]
[TestCase("1", true)]
[TestCase("0", false)]
public void TestParsingString(string value, bool expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestSet_System_Boolean_"></a> TestSet\(bool\)

```csharp
[TestCase(true)]
[TestCase(false)]
public void TestSet(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestSet_System_Boolean_"></a> TestSet\(bool\)

```csharp
[TestCase(true)]
[TestCase(false)]
public void TestSet(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Tests_Bindables_BindableBoolTest_TestSet_System_Boolean_"></a> TestSet\(bool\)

```csharp
[TestCase(true)]
[TestCase(false)]
public void TestSet(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

