# <a id="osu_Framework_Allocation_CachedAttribute"></a> Class CachedAttribute

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

An attribute that may be attached to a class, interface, field, or property definitions of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>
to indicate that the value should be cached as a dependency.
Cached values may be resolved through <xref href="osu.Framework.Allocation.BackgroundDependencyLoaderAttribute" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Allocation.ResolvedAttribute" data-throw-if-not-resolved="false"></xref>.

```csharp
[MeansImplicitUse]
[AttributeUsage(AttributeTargets.Class|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
public class CachedAttribute : Attribute
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Attribute](https://learn.microsoft.com/dotnet/api/system.attribute) ← 
[CachedAttribute](osu.Framework.Allocation.CachedAttribute.md)

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
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CachedAttribute\>\(CachedAttribute?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CachedAttribute\>\(CachedAttribute\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CachedAttribute\>\(CachedAttribute\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CachedAttribute\>\(CachedAttribute\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CachedAttribute, TChild\>\(CachedAttribute, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CachedAttribute, TChild\>\(CachedAttribute, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CachedAttribute, TChild\>\(CachedAttribute, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CachedAttribute\>\(CachedAttribute\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

The behaviour of this attribute differs in meaning depending on the type of member it is placed on.
<ul><li><p>
In the case of fields and properties, the dependency will be cached for the children of the drawable that contains the field or property.
</p><p>
Unless specified differently by <xref href="osu.Framework.Allocation.CachedAttribute.Type" data-throw-if-not-resolved="false"></xref>, the dependency will be cached using the field/property value's concrete (most-derived) type.
See the examples section of the <xref href="osu.Framework.Allocation.CachedAttribute.Type" data-throw-if-not-resolved="false"></xref> property documentation for further information.
</p></li><li><p>
Instances of classes annotated with <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> will cache themselves for their own children.
Unless specified differently by <xref href="osu.Framework.Allocation.CachedAttribute.Type" data-throw-if-not-resolved="false"></xref>, the dependency will be cached using the type <em>at the point where the <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> was declared</em>.
</p><p>
Note that while the <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> itself is not inherited, derived class instances will still cache themselves using the base class.
See the examples section of the <xref href="osu.Framework.Allocation.CachedAttribute.Type" data-throw-if-not-resolved="false"></xref> property documentation for further information.
</p></li><li>
If a class implements an interface annotated with <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref>, then instances of that class will cache themselves for their own children using the interface type.
As with classes, the <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> is not inherited between interfaces either,
but an instance of a class will cache itself to children using all cacheable interface types that it implements.
</li></ul>

## Constructors

### <a id="osu_Framework_Allocation_CachedAttribute__ctor"></a> CachedAttribute\(\)

Identifies a member to be cached to a <xref href="osu.Framework.Allocation.DependencyContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public CachedAttribute()
```

### <a id="osu_Framework_Allocation_CachedAttribute__ctor_System_Type_System_String_"></a> CachedAttribute\(Type, string\)

Identifies a member to be cached to a <xref href="osu.Framework.Allocation.DependencyContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public CachedAttribute(Type type = null, string name = null)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type to cache the member as.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name to identify the member as in the cache.

## Fields

### <a id="osu_Framework_Allocation_CachedAttribute_Name"></a> Name

The name to identify this member with.

```csharp
public string Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

If the member is cached with a custom <xref href="osu.Framework.Allocation.CacheInfo" data-throw-if-not-resolved="false"></xref> that provides a parent, the name is automatically inferred from the field/property.

### <a id="osu_Framework_Allocation_CachedAttribute_Type"></a> Type

The type to cache the value as. If null, the type depends on the type of member that the attribute is placed on:
<ul><li>In the case of fields and properties, the attribute will use the concrete/most-derived type of the field/property's value.</li><li>In the case of classes and interfaces, the attribute will use the class/interface type on which the <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> was <em>directly placed</em>.</li></ul>

```csharp
public Type Type
```

#### Field Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

#### Examples

<p>
 In the case of fields and properties, if this value is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> on the following field definition:
 <pre><code class="lang-csharp">[Cached]
 private BaseType obj = new DerivedType();</code></pre>
 then the cached type will be <code>DerivedType</code>.
 </p>
<p>
 In the case of classes, given the following structure:
 <pre><code class="lang-csharp">[Cached]
 public class A { }

 public class B : A { }</code></pre>
 the following things will happen:
 <ul><li>Instances of <code>A</code> will cache themselves to children using type <code>A</code>.</li><li>Instances of <code>B</code> will cache themselves to children using type <code>A</code>.</li><li>
 Instances of <code>B</code> will <em>not</em> cache themselves to children using type <code>B</code>.
 To achieve that effect, the <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> has to be repeated on class <code>B</code>.
 </li></ul><xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> placed in interface inheritance hierarchies follows analogous rules to the ones described above for classes.
 </p>

