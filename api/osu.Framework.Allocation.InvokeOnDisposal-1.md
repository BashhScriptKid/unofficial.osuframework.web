# <a id="osu_Framework_Allocation_InvokeOnDisposal_1"></a> Class InvokeOnDisposal<T\>

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

Instances of this class capture an action for later cleanup. When a method returns an instance of this class, the appropriate usage is:
<pre><code class="lang-csharp">using (SomeMethod())
    {
        // ...
    }</code></pre>
The using block will automatically dispose the returned instance, doing the necessary cleanup work.

```csharp
public class InvokeOnDisposal<T> : IDisposable
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvokeOnDisposal<T\>](osu.Framework.Allocation.InvokeOnDisposal\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<InvokeOnDisposal<T\>\>\(InvokeOnDisposal<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InvokeOnDisposal<T\>\>\(InvokeOnDisposal<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InvokeOnDisposal<T\>\>\(InvokeOnDisposal<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InvokeOnDisposal<T\>\>\(InvokeOnDisposal<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InvokeOnDisposal<T\>, TChild\>\(InvokeOnDisposal<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InvokeOnDisposal<T\>, TChild\>\(InvokeOnDisposal<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InvokeOnDisposal<T\>, TChild\>\(InvokeOnDisposal<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InvokeOnDisposal<T\>\>\(InvokeOnDisposal<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Allocation_InvokeOnDisposal_1__ctor__0_System_Action__0__"></a> InvokeOnDisposal\(T, Action<T\>\)

Constructs a new instance, capturing the given action to be run during disposal.

```csharp
public InvokeOnDisposal(T sender, Action<T> action)
```

#### Parameters

`sender` T

The sender which should appear in the <code class="paramref">action</code> callback.

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The action to invoke during disposal.

## Methods

### <a id="osu_Framework_Allocation_InvokeOnDisposal_1_Dispose"></a> Dispose\(\)

Disposes this instance, calling the initially captured action.

```csharp
public virtual void Dispose()
```

