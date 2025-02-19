# <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2"></a> Struct SlimReadOnlyDictionaryWrapper<TKey, TValue\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly struct SlimReadOnlyDictionaryWrapper<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : notnull
```

#### Type Parameters

`TKey` 

`TValue` 

#### Implements

[IReadOnlyDictionary<TKey, TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SlimReadOnlyDictionaryWrapper<TKey, TValue\>\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, Action<KeyValuePair<TKey, TValue\>\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SlimReadOnlyDictionaryWrapper<TKey, TValue\>\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, KeyValuePair<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, KeyValuePair<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<SlimReadOnlyDictionaryWrapper<TKey, TValue\>\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SlimReadOnlyDictionaryWrapper<TKey, TValue\>\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SlimReadOnlyDictionaryWrapper<TKey, TValue\>, TChild\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SlimReadOnlyDictionaryWrapper<TKey, TValue\>, TChild\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SlimReadOnlyDictionaryWrapper<TKey, TValue\>, TChild\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SlimReadOnlyDictionaryWrapper<TKey, TValue\>\>\(SlimReadOnlyDictionaryWrapper<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2__ctor_System_Collections_Generic_Dictionary__0__1__"></a> SlimReadOnlyDictionaryWrapper\(Dictionary<TKey, TValue\>\)

```csharp
public SlimReadOnlyDictionaryWrapper(Dictionary<TKey, TValue> dict)
```

#### Parameters

`dict` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TKey, TValue\>

## Properties

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_Count"></a> Count

Gets the number of elements in the collection.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_Keys"></a> Keys

```csharp
public Dictionary<TKey, TValue>.KeyCollection Keys { get; }
```

#### Property Value

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TKey, TValue\>.[KeyCollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.keycollection)

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_Values"></a> Values

```csharp
public Dictionary<TKey, TValue>.ValueCollection Values { get; }
```

#### Property Value

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TKey, TValue\>.[ValueCollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.valuecollection)

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_Item__0_"></a> this\[TKey\]

Gets the element that has the specified key in the read-only dictionary.

```csharp
public TValue this[TKey key] { get; }
```

#### Property Value

 TValue

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [KeyNotFoundException](https://learn.microsoft.com/dotnet/api/system.collections.generic.keynotfoundexception)

The property is retrieved and <code class="paramref">key</code> is not found.

## Methods

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_ContainsKey__0_"></a> ContainsKey\(TKey\)

Determines whether the read-only dictionary contains an element that has the specified key.

```csharp
public bool ContainsKey(TKey key)
```

#### Parameters

`key` TKey

The key to locate.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the read-only dictionary contains an element that has the specified key; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
```

#### Returns

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TKey, TValue\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.enumerator)

### <a id="osu_Framework_Lists_SlimReadOnlyDictionaryWrapper_2_TryGetValue__0__1__"></a> TryGetValue\(TKey, out TValue\)

Gets the value that is associated with the specified key.

```csharp
public bool TryGetValue(TKey key, out TValue value)
```

#### Parameters

`key` TKey

The key to locate.

`value` TValue

When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <code class="paramref">value</code> parameter. This parameter is passed uninitialized.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the object that implements the <xref href="System.Collections.Generic.IReadOnlyDictionary%602" data-throw-if-not-resolved="false"></xref> interface contains an element that has the specified key; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

