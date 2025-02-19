# <a id="osu_Framework_Graphics_UserInterface_IHasCurrentValue_1"></a> Interface IHasCurrentValue<T\>

Namespace: [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)  
Assembly: osu.Framework.dll  

A UI element which supports a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> current value.
You can bind to <xref href="osu.Framework.Graphics.UserInterface.IHasCurrentValue%601.Current" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Bindables.Bindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> to get updates.

```csharp
public interface IHasCurrentValue<T>
```

#### Type Parameters

`T` 

#### Extension Methods

[ObjectExtensions.AsNonNull<IHasCurrentValue<T\>\>\(IHasCurrentValue<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IHasCurrentValue<T\>\>\(IHasCurrentValue<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IHasCurrentValue<T\>\>\(IHasCurrentValue<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IHasCurrentValue<T\>\>\(IHasCurrentValue<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IHasCurrentValue<T\>, TChild\>\(IHasCurrentValue<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IHasCurrentValue<T\>, TChild\>\(IHasCurrentValue<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IHasCurrentValue<T\>, TChild\>\(IHasCurrentValue<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IHasCurrentValue<T\>\>\(IHasCurrentValue<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_UserInterface_IHasCurrentValue_1_Current"></a> Current

Gets or sets the <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> that provides the current value.

```csharp
Bindable<T> Current { get; set; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

#### Remarks

A provided <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> will be bound to, rather than be stored internally.

