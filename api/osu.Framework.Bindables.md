# <a id="osu_Framework_Bindables"></a> Namespace osu.Framework.Bindables

### Classes

 [AggregateBindable<T\>](osu.Framework.Bindables.AggregateBindable\-1.md)

Combines multiple bindables into one aggregate bindable result.

 [Bindable<T\>](osu.Framework.Bindables.Bindable\-1.md)

A generic implementation of a <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>

 [BindableBool](osu.Framework.Bindables.BindableBool.md)

 [BindableColour4](osu.Framework.Bindables.BindableColour4.md)

 [BindableDictionary<TKey, TValue\>](osu.Framework.Bindables.BindableDictionary\-2.md)

 [BindableDouble](osu.Framework.Bindables.BindableDouble.md)

 [BindableFloat](osu.Framework.Bindables.BindableFloat.md)

 [BindableInt](osu.Framework.Bindables.BindableInt.md)

 [BindableList<T\>](osu.Framework.Bindables.BindableList\-1.md)

 [BindableLong](osu.Framework.Bindables.BindableLong.md)

 [BindableMarginPadding](osu.Framework.Bindables.BindableMarginPadding.md)

 [BindableNumber<T\>](osu.Framework.Bindables.BindableNumber\-1.md)

 [BindableNumberWithCurrent<T\>](osu.Framework.Bindables.BindableNumberWithCurrent\-1.md)

A bindable which holds a reference to a bound target, allowing switching between targets and handling unbind/rebind.

 [BindableSafeArea](osu.Framework.Bindables.BindableSafeArea.md)

A subclass of <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> specifically for representing the "safe areas" of a device.
It exists to prevent regular <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref>s from being globally cached.

 [BindableSize](osu.Framework.Bindables.BindableSize.md)

Represents a <xref href="System.Drawing.Size" data-throw-if-not-resolved="false"></xref> bindable with defined component-wise constraints applied to it.

 [BindableWithCurrent<T\>](osu.Framework.Bindables.BindableWithCurrent\-1.md)

A bindable which holds a reference to a bound target, allowing switching between targets and handling unbind/rebind.

 [LeasedBindable<T\>](osu.Framework.Bindables.LeasedBindable\-1.md)

A bindable carrying a mutually exclusive lease on another bindable.
Can only be retrieved via <xref href="osu.Framework.Bindables.Bindable%601.BeginLease(System.Boolean)" data-throw-if-not-resolved="false"></xref>.

 [NonNullableBindable<T\>](osu.Framework.Bindables.NonNullableBindable\-1.md)

 [NotifyDictionaryChangedEventArgs<TKey, TValue\>](osu.Framework.Bindables.NotifyDictionaryChangedEventArgs\-2.md)

Arguments for a dictionary's CollectionChanged event.

 [RangeConstrainedBindable<T\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md)

 [ValueChangedEvent<T\>](osu.Framework.Bindables.ValueChangedEvent\-1.md)

An event fired when a value changes, providing the old and new value for reference.

### Interfaces

 [IBindable<T\>](osu.Framework.Bindables.IBindable\-1.md)

An interface which can be bound to other <xref href="osu.Framework.Bindables.IBindable%601" data-throw-if-not-resolved="false"></xref>s in order to watch for (and react to) <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled?text=Disabled" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.IBindable%601.Value?text=Value" data-throw-if-not-resolved="false"></xref> changes.

 [IBindable](osu.Framework.Bindables.IBindable.md)

An interface which can be bound to other <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s in order to watch for (and react to) <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled?text=Disabled" data-throw-if-not-resolved="false"></xref> changes.

 [IBindableDictionary<TKey, TValue\>](osu.Framework.Bindables.IBindableDictionary\-2.md)

 [IBindableList<T\>](osu.Framework.Bindables.IBindableList\-1.md)

A readonly interface which can be bound to other <xref href="osu.Framework.Bindables.IBindableList%601" data-throw-if-not-resolved="false"></xref>s in order to watch for state and content changes.

 [IBindableNumber<T\>](osu.Framework.Bindables.IBindableNumber\-1.md)

 [IBindableWithCurrent<T\>](osu.Framework.Bindables.IBindableWithCurrent\-1.md)

 [ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md)

Interface for objects that have a disabled state.

 [IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md)

Interface for objects that have a default value.

 [IHasDescription](osu.Framework.Bindables.IHasDescription.md)

Interface for objects that have a description.

 [ILeasedBindable](osu.Framework.Bindables.ILeasedBindable.md)

An interface that represents a leased bindable.

 [ILeasedBindable<T\>](osu.Framework.Bindables.ILeasedBindable\-1.md)

An interface that representes a leased bindable.

 [IParseable](osu.Framework.Bindables.IParseable.md)

Represents a class which can be parsed from an arbitrary object.

 [IUnbindable](osu.Framework.Bindables.IUnbindable.md)

Interface for objects that support publicly unbinding events or <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s.

### Enums

 [NotifyDictionaryChangedAction](osu.Framework.Bindables.NotifyDictionaryChangedAction.md)

### Delegates

 [NotifyDictionaryChangedEventHandler<TKey, TValue\>](osu.Framework.Bindables.NotifyDictionaryChangedEventHandler\-2.md)

The delegate to use for handlers that receive the CollectionChanged event.

