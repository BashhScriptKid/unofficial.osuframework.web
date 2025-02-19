# <a id="osu_Framework_Allocation_ValueInvokeOnDisposal_1"></a> Struct ValueInvokeOnDisposal<T\>

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

Instances of this struct capture an action for later cleanup. The appropriate usage is:
<pre><code class="lang-csharp">using (SomeMethod())
     {
         // ...
     }</code></pre>
The using block will automatically dispose the returned instance, doing the necessary cleanup work.

This is a struct version of <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used when allocations are to be minimised.

```csharp
public readonly struct ValueInvokeOnDisposal<T> : IDisposable
```

#### Type Parameters

`T` 

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ValueInvokeOnDisposal<T\>\>\(ValueInvokeOnDisposal<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ValueInvokeOnDisposal<T\>\>\(ValueInvokeOnDisposal<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ValueInvokeOnDisposal<T\>\>\(ValueInvokeOnDisposal<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ValueInvokeOnDisposal<T\>\>\(ValueInvokeOnDisposal<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ValueInvokeOnDisposal<T\>, TChild\>\(ValueInvokeOnDisposal<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ValueInvokeOnDisposal<T\>, TChild\>\(ValueInvokeOnDisposal<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ValueInvokeOnDisposal<T\>, TChild\>\(ValueInvokeOnDisposal<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ValueInvokeOnDisposal<T\>\>\(ValueInvokeOnDisposal<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Allocation_ValueInvokeOnDisposal_1__ctor__0_System_Action__0__"></a> ValueInvokeOnDisposal\(T, Action<T\>\)

Constructs a new instance, capturing the given action to be run during disposal.

```csharp
public ValueInvokeOnDisposal(T sender, Action<T> action)
```

#### Parameters

`sender` T

The sender which should appear in the <code class="paramref">action</code> callback.

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The action to invoke during disposal.

## Methods

### <a id="osu_Framework_Allocation_ValueInvokeOnDisposal_1_Dispose"></a> Dispose\(\)

Disposes this instance, calling the initially captured action.

```csharp
public void Dispose()
```

