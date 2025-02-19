# <a id="osu_Framework_Bindables_AggregateBindable_1"></a> Class AggregateBindable<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

Combines multiple bindables into one aggregate bindable result.

```csharp
public class AggregateBindable<T>
```

#### Type Parameters

`T` 

The type of values.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AggregateBindable<T\>](osu.Framework.Bindables.AggregateBindable\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AggregateBindable<T\>\>\(AggregateBindable<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AggregateBindable<T\>\>\(AggregateBindable<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AggregateBindable<T\>\>\(AggregateBindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AggregateBindable<T\>\>\(AggregateBindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AggregateBindable<T\>, TChild\>\(AggregateBindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AggregateBindable<T\>, TChild\>\(AggregateBindable<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AggregateBindable<T\>, TChild\>\(AggregateBindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AggregateBindable<T\>\>\(AggregateBindable<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_AggregateBindable_1__ctor_System_Func__0__0__0__osu_Framework_Bindables_Bindable__0__"></a> AggregateBindable\(Func<T, T, T\>, Bindable<T\>\)

Create a new aggregate bindable.

```csharp
public AggregateBindable(Func<T, T, T> aggregateFunction, Bindable<T> resultBindable = null)
```

#### Parameters

`aggregateFunction` [Func](https://learn.microsoft.com/dotnet/api/system.func\-3)<T, T, T\>

The function to be used for aggregation, taking two input <code class="typeparamref">T</code> values and returning one output.

`resultBindable` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

An optional newly constructed bindable to use for <xref href="osu.Framework.Bindables.AggregateBindable%601.Result" data-throw-if-not-resolved="false"></xref>. The initial value of this bindable is used as the initial value for the aggregate.

## Properties

### <a id="osu_Framework_Bindables_AggregateBindable_1_Result"></a> Result

The final result after aggregating all added sources.

```csharp
public IBindable<T> Result { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

## Methods

### <a id="osu_Framework_Bindables_AggregateBindable_1_AddSource_osu_Framework_Bindables_IBindable__0__"></a> AddSource\(IBindable<T\>\)

Add a new source to be included in aggregation.

```csharp
public void AddSource(IBindable<T> bindable)
```

#### Parameters

`bindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

The bindable to add.

### <a id="osu_Framework_Bindables_AggregateBindable_1_RemoveAllSources"></a> RemoveAllSources\(\)

```csharp
public void RemoveAllSources()
```

### <a id="osu_Framework_Bindables_AggregateBindable_1_RemoveSource_osu_Framework_Bindables_IBindable__0__"></a> RemoveSource\(IBindable<T\>\)

Remove a source from being included in aggregation.

```csharp
public void RemoveSource(IBindable<T> bindable)
```

#### Parameters

`bindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

The bindable to remove.

