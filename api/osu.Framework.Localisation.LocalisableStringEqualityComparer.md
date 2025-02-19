# <a id="osu_Framework_Localisation_LocalisableStringEqualityComparer"></a> Class LocalisableStringEqualityComparer

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

An equality comparer for the <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> type.

```csharp
public class LocalisableStringEqualityComparer : IEqualityComparer<LocalisableString>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisableStringEqualityComparer](osu.Framework.Localisation.LocalisableStringEqualityComparer.md)

#### Implements

[IEqualityComparer<LocalisableString\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LocalisableStringEqualityComparer\>\(LocalisableStringEqualityComparer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisableStringEqualityComparer\>\(LocalisableStringEqualityComparer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisableStringEqualityComparer\>\(LocalisableStringEqualityComparer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisableStringEqualityComparer\>\(LocalisableStringEqualityComparer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LocalisableStringEqualityComparer, TChild\>\(LocalisableStringEqualityComparer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisableStringEqualityComparer, TChild\>\(LocalisableStringEqualityComparer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisableStringEqualityComparer, TChild\>\(LocalisableStringEqualityComparer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisableStringEqualityComparer\>\(LocalisableStringEqualityComparer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Localisation_LocalisableStringEqualityComparer_Default"></a> Default

```csharp
public static LocalisableStringEqualityComparer Default { get; }
```

#### Property Value

 [LocalisableStringEqualityComparer](osu.Framework.Localisation.LocalisableStringEqualityComparer.md)

## Methods

### <a id="osu_Framework_Localisation_LocalisableStringEqualityComparer_Equals_osu_Framework_Localisation_LocalisableString_osu_Framework_Localisation_LocalisableString_"></a> Equals\(LocalisableString, LocalisableString\)

Determines whether the specified objects are equal.

```csharp
public bool Equals(LocalisableString x, LocalisableString y)
```

#### Parameters

`x` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The first object of type <code class="paramref">T</code> to compare.

`y` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The second object of type <code class="paramref">T</code> to compare.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified objects are equal; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_LocalisableStringEqualityComparer_GetHashCode_osu_Framework_Localisation_LocalisableString_"></a> GetHashCode\(LocalisableString\)

Returns a hash code for the specified object.

```csharp
public int GetHashCode(LocalisableString obj)
```

#### Parameters

`obj` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The <xref href="System.Object" data-throw-if-not-resolved="false"></xref> for which a hash code is to be returned.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the specified object.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

The type of <code class="paramref">obj</code> is a reference type and <code class="paramref">obj</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

