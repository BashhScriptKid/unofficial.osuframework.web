# <a id="osu_Framework_Bindables_BindableDictionary_2"></a> Class BindableDictionary<TKey, TValue\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableDictionary<TKey, TValue> : IBindableDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IEnumerable where TKey : notnull
```

#### Type Parameters

`TKey` 

`TValue` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableDictionary<TKey, TValue\>](osu.Framework.Bindables.BindableDictionary\-2.md)

#### Implements

[IBindableDictionary<TKey, TValue\>](osu.Framework.Bindables.IBindableDictionary\-2.md), 
[IReadOnlyDictionary<TKey, TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IBindable](osu.Framework.Bindables.IBindable.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IParseable](osu.Framework.Bindables.IParseable.md), 
[IDictionary<TKey, TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2), 
[ICollection<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IEnumerable<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.idictionary), 
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.icollection), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableDictionary<TKey, TValue\>\>\(BindableDictionary<TKey, TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, Action<KeyValuePair<TKey, TValue\>\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableDictionary<TKey, TValue\>\>\(BindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, KeyValuePair<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, KeyValuePair<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<BindableDictionary<TKey, TValue\>\>\(BindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableDictionary<TKey, TValue\>\>\(BindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableDictionary<TKey, TValue\>, TChild\>\(BindableDictionary<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableDictionary<TKey, TValue\>, TChild\>\(BindableDictionary<TKey, TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableDictionary<TKey, TValue\>, TChild\>\(BindableDictionary<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableDictionary<TKey, TValue\>\>\(BindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableDictionary_2__ctor_System_Collections_Generic_IEqualityComparer__0__"></a> BindableDictionary\(IEqualityComparer<TKey\>?\)

Initializes a new instance of the <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref> class that is empty, has the default initial capacity, and uses the specified <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public BindableDictionary(IEqualityComparer<TKey>? comparer = null)
```

#### Parameters

`comparer` [IEqualityComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)<TKey\>?

The <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref> implementation to use when comparing keys, or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> to use the default <xref href="System.Collections.Generic.EqualityComparer%601" data-throw-if-not-resolved="false"></xref> for the type of the key.

### <a id="osu_Framework_Bindables_BindableDictionary_2__ctor_System_Collections_Generic_IDictionary__0__1__System_Collections_Generic_IEqualityComparer__0__"></a> BindableDictionary\(IDictionary<TKey, TValue\>, IEqualityComparer<TKey\>?\)

Initializes a new instance of the <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref> class that contains elements copied from the specified <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> and uses the specified <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public BindableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey>? comparer = null)
```

#### Parameters

`dictionary` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<TKey, TValue\>

The <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> whose elements are copied to the new <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref>.

`comparer` [IEqualityComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)<TKey\>?

The <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref> implementation to use when comparing keys, or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> to use the default <xref href="System.Collections.Generic.EqualityComparer%601" data-throw-if-not-resolved="false"></xref> for the type of the key.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">dictionary</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

<code class="paramref">dictionary</code> contains one or more duplicate keys.

### <a id="osu_Framework_Bindables_BindableDictionary_2__ctor_System_Int32_System_Collections_Generic_IEqualityComparer__0__"></a> BindableDictionary\(int, IEqualityComparer<TKey\>?\)

Initializes a new instance of the <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref> class that is empty, has the specified initial capacity, and uses the specified <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public BindableDictionary(int capacity, IEqualityComparer<TKey>? comparer = null)
```

#### Parameters

`capacity` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The initial number of elements that the <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref> can contain.

`comparer` [IEqualityComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)<TKey\>?

The <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref> implementation to use when comparing keys, or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> to use the default <xref href="System.Collections.Generic.EqualityComparer%601" data-throw-if-not-resolved="false"></xref> for the type of the key.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">capacity</code> is less than 0.

### <a id="osu_Framework_Bindables_BindableDictionary_2__ctor_System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair__0__1___System_Collections_Generic_IEqualityComparer__0__"></a> BindableDictionary\(IEnumerable<KeyValuePair<TKey, TValue\>\>, IEqualityComparer<TKey\>?\)

Initializes a new instance of the <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref> class that contains elements copied from the specified <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> and uses the specified <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public BindableDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey>? comparer = null)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>\>

The <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> whose elements are copied to the new <xref href="System.Collections.Generic.Dictionary%602" data-throw-if-not-resolved="false"></xref>.

`comparer` [IEqualityComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)<TKey\>?

The <xref href="System.Collections.Generic.IEqualityComparer%601" data-throw-if-not-resolved="false"></xref> implementation to use when comparing keys, or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> to use the default <xref href="System.Collections.Generic.EqualityComparer%601" data-throw-if-not-resolved="false"></xref> for the type of the key.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">collection</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

<code class="paramref">collection</code> contains one or more duplicated keys.

## Properties

### <a id="osu_Framework_Bindables_BindableDictionary_2_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.BindableDictionary%602.BindTo(osu.Framework.Bindables.BindableDictionary%7b%600%2c%601%7d)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
public BindableDictionary<TKey, TValue> BindTarget { set; }
```

#### Property Value

 [BindableDictionary](osu.Framework.Bindables.BindableDictionary\-2.md)<TKey, TValue\>

### <a id="osu_Framework_Bindables_BindableDictionary_2_Count"></a> Count

Gets the number of elements in the collection.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Bindables_BindableDictionary_2_Description"></a> Description

The description for this object.

```csharp
public string? Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_Bindables_BindableDictionary_2_Disabled"></a> Disabled

Whether this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> has been disabled.
When disabled, attempting to change the contents of this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> will result in an <xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Disabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableDictionary_2_IsDefault"></a> IsDefault

Check whether this object has its default value.

```csharp
public bool IsDefault { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableDictionary_2_IsReadOnly"></a> IsReadOnly

Gets a value indicating whether the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableDictionary_2_Keys"></a> Keys

Gets an <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> containing the keys of the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public ICollection<TKey> Keys { get; }
```

#### Property Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<TKey\>

### <a id="osu_Framework_Bindables_BindableDictionary_2_Values"></a> Values

Gets an <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> containing the values in the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public ICollection<TValue> Values { get; }
```

#### Property Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<TValue\>

### <a id="osu_Framework_Bindables_BindableDictionary_2_Item__0_"></a> this\[TKey\]

Gets or sets the element with the specified key.

```csharp
public TValue this[TKey key] { get; set; }
```

#### Property Value

 TValue

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [KeyNotFoundException](https://learn.microsoft.com/dotnet/api/system.collections.generic.keynotfoundexception)

The property is retrieved and <code class="paramref">key</code> is not found.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The property is set and the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> is read-only.

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when setting an item while this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>.

## Methods

### <a id="osu_Framework_Bindables_BindableDictionary_2_Add__0__1_"></a> Add\(TKey, TValue\)

Adds an element with the provided key and value to the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Add(TKey key, TValue value)
```

#### Parameters

`key` TKey

The object to use as the key of the element to add.

`value` TValue

The object to use as the value of the element to add.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

An element with the same key already exists in the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> is read-only.

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableDictionary_2_BindCollectionChanged_osu_Framework_Bindables_NotifyDictionaryChangedEventHandler__0__1__System_Boolean_"></a> BindCollectionChanged\(NotifyDictionaryChangedEventHandler<TKey, TValue\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.BindableDictionary%602.CollectionChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately
with an <xref href="System.Collections.Specialized.NotifyCollectionChangedAction.Add" data-throw-if-not-resolved="false"></xref> event for the entire contents of this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public void BindCollectionChanged(NotifyDictionaryChangedEventHandler<TKey, TValue> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [NotifyDictionaryChangedEventHandler](osu.Framework.Bindables.NotifyDictionaryChangedEventHandler\-2.md)<TKey, TValue\>

The action to perform when this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_BindableDictionary_2_BindDisabledChanged_System_Action_System_Boolean__System_Boolean_"></a> BindDisabledChanged\(Action<bool\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.ICanBeDisabled.DisabledChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately.

```csharp
public void BindDisabledChanged(Action<bool> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The action to perform when <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_BindableDictionary_2_BindTo_osu_Framework_Bindables_BindableDictionary__0__1__"></a> BindTo\(BindableDictionary<TKey, TValue\>\)

Binds this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> to another.

```csharp
public void BindTo(BindableDictionary<TKey, TValue> them)
```

#### Parameters

`them` [BindableDictionary](osu.Framework.Bindables.BindableDictionary\-2.md)<TKey, TValue\>

The <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> to be bound to.

### <a id="osu_Framework_Bindables_BindableDictionary_2_Clear"></a> Clear\(\)

Removes all elements from the <xref href="System.Collections.IDictionary" data-throw-if-not-resolved="false"></xref> object.

```csharp
public void Clear()
```

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.IDictionary" data-throw-if-not-resolved="false"></xref> object is read-only.

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableDictionary_2_ContainsKey__0_"></a> ContainsKey\(TKey\)

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

### <a id="osu_Framework_Bindables_BindableDictionary_2_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected virtual BindableDictionary<TKey, TValue> CreateInstance()
```

#### Returns

 [BindableDictionary](osu.Framework.Bindables.BindableDictionary\-2.md)<TKey, TValue\>

### <a id="osu_Framework_Bindables_BindableDictionary_2_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
public BindableDictionary<TKey, TValue> GetBoundCopy()
```

#### Returns

 [BindableDictionary](osu.Framework.Bindables.BindableDictionary\-2.md)<TKey, TValue\>

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

### <a id="osu_Framework_Bindables_BindableDictionary_2_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
```

#### Returns

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<TKey, TValue\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.enumerator)

### <a id="osu_Framework_Bindables_BindableDictionary_2_Parse_System_Object_System_IFormatProvider_"></a> Parse\(object?, IFormatProvider\)

Parse an object into this instance.
A collection holding items of type <xref href="System.Collections.Generic.KeyValuePair%602" data-throw-if-not-resolved="false"></xref> can be parsed. Null results in an empty <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Parse(object? input, IFormatProvider provider)
```

#### Parameters

`input` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The input which is to be parsed.

`provider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)

Not valid for <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableDictionary_2_Remove__0_"></a> Remove\(TKey\)

Removes the element with the specified key from the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Remove(TKey key)
```

#### Parameters

`key` TKey

The key of the element to remove.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the element is successfully removed; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.  This method also returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> if <code class="paramref">key</code> was not found in the original <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> is read-only.

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableDictionary_2_Remove__0__1__"></a> Remove\(TKey, out TValue\)

Removes the element with the specified key from the <xref href="System.Collections.IDictionary" data-throw-if-not-resolved="false"></xref> object.

```csharp
public bool Remove(TKey key, out TValue value)
```

#### Parameters

`key` TKey

The key of the element to remove.

`value` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">key</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.IDictionary" data-throw-if-not-resolved="false"></xref> object is read-only.  

 -or-  

 The <xref href="System.Collections.IDictionary" data-throw-if-not-resolved="false"></xref> has a fixed size.

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableDictionary_2_TryGetValue__0__1__"></a> TryGetValue\(TKey, out TValue\)

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

### <a id="osu_Framework_Bindables_BindableDictionary_2_UnbindAll"></a> UnbindAll\(\)

Calls <xref href="osu.Framework.Bindables.IUnbindable.UnbindEvents" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.IUnbindable.UnbindBindings" data-throw-if-not-resolved="false"></xref>

```csharp
public void UnbindAll()
```

### <a id="osu_Framework_Bindables_BindableDictionary_2_UnbindBindings"></a> UnbindBindings\(\)

Unbinds all bound <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s.

```csharp
public void UnbindBindings()
```

### <a id="osu_Framework_Bindables_BindableDictionary_2_UnbindEvents"></a> UnbindEvents\(\)

Unbinds all bound events.

```csharp
public void UnbindEvents()
```

### <a id="osu_Framework_Bindables_BindableDictionary_2_UnbindFrom_osu_Framework_Bindables_IUnbindable_"></a> UnbindFrom\(IUnbindable\)

Unbinds ourselves from another <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> such that we stop receiving updates it.
The other <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> will also stop receiving any events from us.

```csharp
public void UnbindFrom(IUnbindable them)
```

#### Parameters

`them` [IUnbindable](osu.Framework.Bindables.IUnbindable.md)

The other bindable.

### <a id="osu_Framework_Bindables_BindableDictionary_2_CollectionChanged"></a> CollectionChanged

An event which is raised when this <xref href="osu.Framework.Bindables.IBindableDictionary%602" data-throw-if-not-resolved="false"></xref> changes.

```csharp
public event NotifyDictionaryChangedEventHandler<TKey, TValue>? CollectionChanged
```

#### Event Type

 [NotifyDictionaryChangedEventHandler](osu.Framework.Bindables.NotifyDictionaryChangedEventHandler\-2.md)<TKey, TValue\>?

### <a id="osu_Framework_Bindables_BindableDictionary_2_DisabledChanged"></a> DisabledChanged

An event which is raised when <xref href="osu.Framework.Bindables.BindableDictionary%602.Disabled" data-throw-if-not-resolved="false"></xref>'s state has changed (or manually via <xref href="osu.Framework.Bindables.BindableDictionary%602.triggerDisabledChange(System.Boolean)" data-throw-if-not-resolved="false"></xref>).

```csharp
public event Action<bool>? DisabledChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

