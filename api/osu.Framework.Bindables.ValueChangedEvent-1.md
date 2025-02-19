# <a id="osu_Framework_Bindables_ValueChangedEvent_1"></a> Class ValueChangedEvent<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

An event fired when a value changes, providing the old and new value for reference.

```csharp
public class ValueChangedEvent<T>
```

#### Type Parameters

`T` 

The type of bindable.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ValueChangedEvent<T\>](osu.Framework.Bindables.ValueChangedEvent\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ValueChangedEvent<T\>\>\(ValueChangedEvent<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ValueChangedEvent<T\>\>\(ValueChangedEvent<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ValueChangedEvent<T\>\>\(ValueChangedEvent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ValueChangedEvent<T\>\>\(ValueChangedEvent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ValueChangedEvent<T\>, TChild\>\(ValueChangedEvent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ValueChangedEvent<T\>, TChild\>\(ValueChangedEvent<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ValueChangedEvent<T\>, TChild\>\(ValueChangedEvent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ValueChangedEvent<T\>\>\(ValueChangedEvent<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_ValueChangedEvent_1__ctor__0__0_"></a> ValueChangedEvent\(T, T\)

```csharp
public ValueChangedEvent(T oldValue, T newValue)
```

#### Parameters

`oldValue` T

`newValue` T

## Fields

### <a id="osu_Framework_Bindables_ValueChangedEvent_1_NewValue"></a> NewValue

The new (and current) value.

```csharp
public readonly T NewValue
```

#### Field Value

 T

### <a id="osu_Framework_Bindables_ValueChangedEvent_1_OldValue"></a> OldValue

The old value.

```csharp
public readonly T OldValue
```

#### Field Value

 T

