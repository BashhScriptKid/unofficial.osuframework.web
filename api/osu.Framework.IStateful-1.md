# <a id="osu_Framework_IStateful_1"></a> Interface IStateful<T\>

Namespace: [osu.Framework](osu.Framework.md)  
Assembly: osu.Framework.dll  

An object which has a state and allows external consumers to change the current state.

```csharp
public interface IStateful<T> where T : struct
```

#### Type Parameters

`T` 

Generally an Enum type local to the class implementing this interface.

#### Extension Methods

[ObjectExtensions.AsNonNull<IStateful<T\>\>\(IStateful<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IStateful<T\>\>\(IStateful<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IStateful<T\>\>\(IStateful<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IStateful<T\>\>\(IStateful<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IStateful<T\>, TChild\>\(IStateful<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IStateful<T\>, TChild\>\(IStateful<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IStateful<T\>, TChild\>\(IStateful<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IStateful<T\>\>\(IStateful<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_IStateful_1_State"></a> State

The current state of this object.

```csharp
T State { get; set; }
```

#### Property Value

 T

### <a id="osu_Framework_IStateful_1_StateChanged"></a> StateChanged

Invoked when the state of this <xref href="osu.Framework.IStateful%601" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
event Action<T> StateChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

