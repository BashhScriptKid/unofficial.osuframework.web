# <a id="osu_Framework_Extensions_ListExtensions_ListExtensions"></a> Class ListExtensions

Namespace: [osu.Framework.Extensions.ListExtensions](osu.Framework.Extensions.ListExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class ListExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ListExtensions](osu.Framework.Extensions.ListExtensions.ListExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Extensions_ListExtensions_ListExtensions_AsSlimReadOnly__1_System_Collections_Generic_List___0__"></a> AsSlimReadOnly<T\>\(List<T\>\)

Creates a new read-only view into a <xref href="System.Collections.Generic.List%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public static SlimReadOnlyListWrapper<T> AsSlimReadOnly<T>(this List<T> list)
```

#### Parameters

`list` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

The list to create the view of.

#### Returns

 [SlimReadOnlyListWrapper](osu.Framework.Lists.SlimReadOnlyListWrapper\-1.md)<T\>

The read-only view.

#### Type Parameters

`T` 

The type of elements contained by the list.

#### Remarks

Enumeration does not allocate the enumerator.

### <a id="osu_Framework_Extensions_ListExtensions_ListExtensions_AsSlimReadOnly__2_System_Collections_Generic_Dictionary___0___1__"></a> AsSlimReadOnly<TKey, TValue\>\(Dictionary<TKey, TValue\>\)

Creates a new read-only view into a <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public static SlimReadOnlyDictionaryWrapper<TKey, TValue> AsSlimReadOnly<TKey, TValue>(this Dictionary<TKey, TValue> dictionary) where TKey : notnull
```

#### Parameters

`dictionary` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TKey, TValue\>

The dictionary to create the view of.

#### Returns

 [SlimReadOnlyDictionaryWrapper](osu.Framework.Lists.SlimReadOnlyDictionaryWrapper\-2.md)<TKey, TValue\>

The read-only view.

#### Type Parameters

`TKey` 

The type of keys in the dictionary.

`TValue` 

The type of values in the dictionary.

#### Remarks

Enumeration does not allocate the enumerator.

