# <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions"></a> Class EnumerableExtensions

Namespace: [osu.Framework.Extensions.IEnumerableExtensions](osu.Framework.Extensions.IEnumerableExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class EnumerableExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EnumerableExtensions](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md)

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

### <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions_CartesianProduct__1_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable___0___"></a> CartesianProduct<T\>\(IEnumerable<IEnumerable<T\>\>\)

Get all combinations of provided sequences.

```csharp
public static IEnumerable<IEnumerable<T>> CartesianProduct<T>(this IEnumerable<IEnumerable<T>> sequences)
```

#### Parameters

`sequences` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>\>

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions_ForEach__1_System_Collections_Generic_IEnumerable___0__System_Action___0__"></a> ForEach<T\>\(IEnumerable<T\>, Action<T\>\)

Performs an action on all the items in an IEnumerable collection.

```csharp
public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The collection to iterate on.

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The action to be performed.

#### Type Parameters

`T` 

The type of the items stored in the collection.

### <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions_GetCommonPrefix_System_Collections_Generic_IEnumerable_System_String__"></a> GetCommonPrefix\(IEnumerable<string\>\)

Returns the most common prefix of every string in this <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref>

```csharp
public static string GetCommonPrefix(this IEnumerable<string> collection)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

The string <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref>

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The most common prefix, or an empty string if no common prefix could be found.

#### Examples

"ab" == { "abc", "abd" }.GetCommonPrefix()

### <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions_GetNext__1_System_Collections_Generic_IEnumerable___0____0_"></a> GetNext<T\>\(IEnumerable<T\>, T\)

Retrieves the item after a pivot from an <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public static T GetNext<T>(this IEnumerable<T> collection, T pivot)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The collection to iterate on.

`pivot` T

The pivot value.

#### Returns

 T

The item in <code class="paramref">collection</code> appearing after <code class="paramref">pivot</code>, or null if no such item exists.

#### Type Parameters

`T` 

The type of the items stored in the collection.

### <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions_GetPrevious__1_System_Collections_Generic_IEnumerable___0____0_"></a> GetPrevious<T\>\(IEnumerable<T\>, T\)

Retrieves the item before a pivot from an <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public static T GetPrevious<T>(this IEnumerable<T> collection, T pivot)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The collection to iterate on.

`pivot` T

The pivot value.

#### Returns

 T

The item in <code class="paramref">collection</code> appearing before <code class="paramref">pivot</code>, or null if no such item exists.

#### Type Parameters

`T` 

The type of the items stored in the collection.

### <a id="osu_Framework_Extensions_IEnumerableExtensions_EnumerableExtensions_Yield__1___0_"></a> Yield<T\>\(T\)

Wraps this object instance into an <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref>
consisting of a single item.

```csharp
public static IEnumerable<T> Yield<T>(this T item)
```

#### Parameters

`item` T

The instance that will be wrapped.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> consisting of a single item.

#### Type Parameters

`T` 

The type of the object.

