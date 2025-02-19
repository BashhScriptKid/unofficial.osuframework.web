# <a id="osu_Framework_Lists"></a> Namespace osu.Framework.Lists

### Classes

 [FuncEqualityComparer<T\>](osu.Framework.Lists.FuncEqualityComparer\-1.md)

 [LazyList<TSource, TTarget\>](osu.Framework.Lists.LazyList\-2.md)

A list that lazily applies a transformation to elements of a source list to a target type when its indexed or iterated.

 [LockedWeakList<T\>](osu.Framework.Lists.LockedWeakList\-1.md)

A <xref href="osu.Framework.Lists.IWeakList%601" data-throw-if-not-resolved="false"></xref> which locks all operations.

 [ObservableArray<T\>](osu.Framework.Lists.ObservableArray\-1.md)

A wrapper for an array that provides notifications when elements are changed.

 [SortedList<T\>](osu.Framework.Lists.SortedList\-1.md)

 [WeakList<T\>](osu.Framework.Lists.WeakList\-1.md)

A list maintaining weak reference of objects.

### Structs

 [LockedWeakList<T\>.Enumerator](osu.Framework.Lists.LockedWeakList\-1.Enumerator.md)

 [SlimReadOnlyDictionaryWrapper<TKey, TValue\>](osu.Framework.Lists.SlimReadOnlyDictionaryWrapper\-2.md)

 [SlimReadOnlyListWrapper<T\>](osu.Framework.Lists.SlimReadOnlyListWrapper\-1.md)

A wrapper that provides a read-only view into a <xref href="System.Collections.Generic.List%601" data-throw-if-not-resolved="false"></xref>.
This can be instantiated via the <xref href="osu.Framework.Extensions.ListExtensions.ListExtensions.AsSlimReadOnly%60%601(System.Collections.Generic.List%7b%60%600%7d)" data-throw-if-not-resolved="false"></xref> extension method.

 [WeakList<T\>.ValidItemsEnumerator](osu.Framework.Lists.WeakList\-1.ValidItemsEnumerator.md)

An enumerator over only the valid items of a <xref href="osu.Framework.Lists.WeakList%601" data-throw-if-not-resolved="false"></xref>.

### Interfaces

 [INotifyArrayChanged](osu.Framework.Lists.INotifyArrayChanged.md)

Provides an event for notifying about array elements changing.

 [IWeakList<T\>](osu.Framework.Lists.IWeakList\-1.md)

A slim interface for a list which stores weak references of objects.

