# <a id="osu_Framework_Localisation_LocalisableDescriptionAttribute"></a> Class LocalisableDescriptionAttribute

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

Specifies a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref>-based description for the target element.
The description can be retrieved through <xref href="osu.Framework.Extensions.ExtensionMethods.GetLocalisableDescription%60%601(%60%600)" data-throw-if-not-resolved="false"></xref>.

```csharp
[AttributeUsage(AttributeTargets.All)]
public sealed class LocalisableDescriptionAttribute : Attribute
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Attribute](https://learn.microsoft.com/dotnet/api/system.attribute) ← 
[LocalisableDescriptionAttribute](osu.Framework.Localisation.LocalisableDescriptionAttribute.md)

#### Inherited Members

[Attribute.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.attribute.equals), 
[Attribute.GetCustomAttribute\(Assembly, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-assembly\-system\-type\)), 
[Attribute.GetCustomAttribute\(Assembly, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-assembly\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttribute\(MemberInfo, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-memberinfo\-system\-type\)), 
[Attribute.GetCustomAttribute\(MemberInfo, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-memberinfo\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttribute\(Module, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-module\-system\-type\)), 
[Attribute.GetCustomAttribute\(Module, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-module\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttribute\(ParameterInfo, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-parameterinfo\-system\-type\)), 
[Attribute.GetCustomAttribute\(ParameterInfo, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattribute\#system\-attribute\-getcustomattribute\(system\-reflection\-parameterinfo\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(Assembly\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-assembly\)), 
[Attribute.GetCustomAttributes\(Assembly, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-assembly\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(Assembly, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-assembly\-system\-type\)), 
[Attribute.GetCustomAttributes\(Assembly, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-assembly\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(MemberInfo\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-memberinfo\)), 
[Attribute.GetCustomAttributes\(MemberInfo, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-memberinfo\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(MemberInfo, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-memberinfo\-system\-type\)), 
[Attribute.GetCustomAttributes\(MemberInfo, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-memberinfo\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(Module\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-module\)), 
[Attribute.GetCustomAttributes\(Module, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-module\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(Module, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-module\-system\-type\)), 
[Attribute.GetCustomAttributes\(Module, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-module\-system\-type\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(ParameterInfo\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-parameterinfo\)), 
[Attribute.GetCustomAttributes\(ParameterInfo, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-parameterinfo\-system\-boolean\)), 
[Attribute.GetCustomAttributes\(ParameterInfo, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-parameterinfo\-system\-type\)), 
[Attribute.GetCustomAttributes\(ParameterInfo, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.getcustomattributes\#system\-attribute\-getcustomattributes\(system\-reflection\-parameterinfo\-system\-type\-system\-boolean\)), 
[Attribute.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.attribute.gethashcode), 
[Attribute.IsDefaultAttribute\(\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefaultattribute), 
[Attribute.IsDefined\(Assembly, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-assembly\-system\-type\)), 
[Attribute.IsDefined\(Assembly, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-assembly\-system\-type\-system\-boolean\)), 
[Attribute.IsDefined\(MemberInfo, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-memberinfo\-system\-type\)), 
[Attribute.IsDefined\(MemberInfo, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-memberinfo\-system\-type\-system\-boolean\)), 
[Attribute.IsDefined\(Module, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-module\-system\-type\)), 
[Attribute.IsDefined\(Module, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-module\-system\-type\-system\-boolean\)), 
[Attribute.IsDefined\(ParameterInfo, Type\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-parameterinfo\-system\-type\)), 
[Attribute.IsDefined\(ParameterInfo, Type, bool\)](https://learn.microsoft.com/dotnet/api/system.attribute.isdefined\#system\-attribute\-isdefined\(system\-reflection\-parameterinfo\-system\-type\-system\-boolean\)), 
[Attribute.Match\(object?\)](https://learn.microsoft.com/dotnet/api/system.attribute.match), 
[Attribute.TypeId](https://learn.microsoft.com/dotnet/api/system.attribute.typeid), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LocalisableDescriptionAttribute\>\(LocalisableDescriptionAttribute?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisableDescriptionAttribute\>\(LocalisableDescriptionAttribute\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisableDescriptionAttribute\>\(LocalisableDescriptionAttribute\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisableDescriptionAttribute\>\(LocalisableDescriptionAttribute\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LocalisableDescriptionAttribute, TChild\>\(LocalisableDescriptionAttribute, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisableDescriptionAttribute, TChild\>\(LocalisableDescriptionAttribute, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisableDescriptionAttribute, TChild\>\(LocalisableDescriptionAttribute, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisableDescriptionAttribute\>\(LocalisableDescriptionAttribute\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Examples

Assuming the following source class from which the <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> description should be returned:
<pre><code class="lang-csharp">class Strings
{
    public static LocalisableString Example =&gt; "example string";
}</code></pre>
the attribute should be used in the following way:
<pre><code class="lang-csharp">[LocalisableDescription(typeof(Strings), nameof(Strings.Example))]</code></pre>

## Remarks

The C# language specification
<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/attributes#attribute-parameter-types">
only permits a limited set of parameter types for attributes,
</a>
and as such <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> instances cannot be passed in directly.
Therefore usages must pass both the target type in which the <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> description is declared,
as well as the name of the member which contains/returns the <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> (using <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/operators/nameof">nameof</a> for this is strongly encouraged).

## Constructors

### <a id="osu_Framework_Localisation_LocalisableDescriptionAttribute__ctor_System_Type_System_String_"></a> LocalisableDescriptionAttribute\(Type, string\)

Creates a new <xref href="osu.Framework.Localisation.LocalisableDescriptionAttribute" data-throw-if-not-resolved="false"></xref>.

```csharp
public LocalisableDescriptionAttribute(Type declaringType, string name)
```

#### Parameters

`declaringType` [Type](https://learn.microsoft.com/dotnet/api/system.type)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Fields

### <a id="osu_Framework_Localisation_LocalisableDescriptionAttribute_DeclaringType"></a> DeclaringType

The type declaring the static member providing the localisable description.

```csharp
public readonly Type DeclaringType
```

#### Field Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="osu_Framework_Localisation_LocalisableDescriptionAttribute_Name"></a> Name

The name of the static member providing the localisable description.

```csharp
public readonly string Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

