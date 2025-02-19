# <a id="osu_Framework_Input_TextInputProperties"></a> Struct TextInputProperties

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

Represents a number of properties to consider during a text input session.

```csharp
public record struct TextInputProperties : IEquatable<TextInputProperties>
```

#### Implements

[IEquatable<TextInputProperties\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextInputProperties\>\(TextInputProperties\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextInputProperties\>\(TextInputProperties\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextInputProperties\>\(TextInputProperties\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextInputProperties\>\(TextInputProperties\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextInputProperties, TChild\>\(TextInputProperties, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextInputProperties, TChild\>\(TextInputProperties, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextInputProperties, TChild\>\(TextInputProperties, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextInputProperties\>\(TextInputProperties\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_TextInputProperties__ctor_osu_Framework_Input_TextInputType_System_Boolean_System_Boolean_"></a> TextInputProperties\(TextInputType, bool, bool\)

Represents a number of properties to consider during a text input session.

```csharp
public TextInputProperties(TextInputType Type, bool AllowIme = true, bool AutoCapitalisation = false)
```

#### Parameters

`Type` [TextInputType](osu.Framework.Input.TextInputType.md)

The type of text being input.

`AllowIme` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<p>
Whether IME should be allowed during this text input session, if supported by the given text input type.
</p>
<p>
Note that this is just a hint to the native implementation, some might respect this,
while others will ignore and always have the IME (dis)allowed.
</p>

`AutoCapitalisation` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether text should be automatically capitalised.

## Properties

### <a id="osu_Framework_Input_TextInputProperties_AllowIme"></a> AllowIme

<p>
Whether IME should be allowed during this text input session, if supported by the given text input type.
</p>
<p>
Note that this is just a hint to the native implementation, some might respect this,
while others will ignore and always have the IME (dis)allowed.
</p>

```csharp
public bool AllowIme { readonly get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_TextInputProperties_AutoCapitalisation"></a> AutoCapitalisation

Whether text should be automatically capitalised.

```csharp
public bool AutoCapitalisation { readonly get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_TextInputProperties_Type"></a> Type

The type of text being input.

```csharp
public TextInputType Type { readonly get; set; }
```

#### Property Value

 [TextInputType](osu.Framework.Input.TextInputType.md)

