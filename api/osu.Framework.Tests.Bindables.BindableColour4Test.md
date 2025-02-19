# <a id="osu_Framework_Tests_Bindables_BindableColour4Test"></a> Class BindableColour4Test

Namespace: [osu.Framework.Tests.Bindables](osu.Framework.Tests.Bindables.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class BindableColour4Test
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableColour4Test](osu.Framework.Tests.Bindables.BindableColour4Test.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableColour4Test\>\(BindableColour4Test?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableColour4Test\>\(BindableColour4Test\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableColour4Test\>\(BindableColour4Test\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableColour4Test\>\(BindableColour4Test\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BindableColour4Test, TChild\>\(BindableColour4Test, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableColour4Test, TChild\>\(BindableColour4Test, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableColour4Test, TChild\>\(BindableColour4Test, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableColour4Test\>\(BindableColour4Test\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestParsingString_System_String_osu_Framework_Graphics_Colour4_"></a> TestParsingString\(string, Colour4\)

```csharp
[TestCaseSource("hex_parsed_colours")]
public void TestParsingString(string value, Colour4 expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestParsingString_System_String_osu_Framework_Graphics_Colour4_"></a> TestParsingString\(string, Colour4\)

```csharp
[TestCaseSource("hex_parsed_colours")]
public void TestParsingString(string value, Colour4 expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` Colour4

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestParsingString_System_String_osu_Framework_Graphics_Colour4_"></a> TestParsingString\(string, Colour4\)

```csharp
[TestCaseSource("hex_parsed_colours")]
public void TestParsingString(string value, Colour4 expected)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expected` Colour4

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestSet_System_Byte_System_Byte_System_Byte_System_Byte_"></a> TestSet\(byte, byte, byte, byte\)

```csharp
[TestCase(new object?[] { 0, 0, 0, 255 })]
[TestCase(new object?[] { 255, 255, 255, 255 })]
[TestCase(new object?[] { 255, 102, 170, 128 })]
public void TestSet(byte r, byte g, byte b, byte a)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestSet_System_Byte_System_Byte_System_Byte_System_Byte_"></a> TestSet\(byte, byte, byte, byte\)

```csharp
[TestCase(new object?[] { 0, 0, 0, 255 })]
[TestCase(new object?[] { 255, 255, 255, 255 })]
[TestCase(new object?[] { 255, 102, 170, 128 })]
public void TestSet(byte r, byte g, byte b, byte a)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestSet_System_Byte_System_Byte_System_Byte_System_Byte_"></a> TestSet\(byte, byte, byte, byte\)

```csharp
[TestCase(new object?[] { 0, 0, 0, 255 })]
[TestCase(new object?[] { 255, 255, 255, 255 })]
[TestCase(new object?[] { 255, 102, 170, 128 })]
public void TestSet(byte r, byte g, byte b, byte a)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestToString_osu_Framework_Graphics_Colour4_System_String_"></a> TestToString\(Colour4, string\)

```csharp
[TestCaseSource("hex_serialized_colours")]
public void TestToString(Colour4 value, string expected)
```

#### Parameters

`value` [Colour4](osu.Framework.Graphics.Colour4.md)

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestToString_osu_Framework_Graphics_Colour4_System_String_"></a> TestToString\(Colour4, string\)

```csharp
[TestCaseSource("hex_serialized_colours")]
public void TestToString(Colour4 value, string expected)
```

#### Parameters

`value` Colour4

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Tests_Bindables_BindableColour4Test_TestToString_osu_Framework_Graphics_Colour4_System_String_"></a> TestToString\(Colour4, string\)

```csharp
[TestCaseSource("hex_serialized_colours")]
public void TestToString(Colour4 value, string expected)
```

#### Parameters

`value` Colour4

`expected` [string](https://learn.microsoft.com/dotnet/api/system.string)

