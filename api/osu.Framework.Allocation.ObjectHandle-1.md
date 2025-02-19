# <a id="osu_Framework_Allocation_ObjectHandle_1"></a> Struct ObjectHandle<T\>

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

Wrapper on <xref href="System.Runtime.InteropServices.GCHandle" data-throw-if-not-resolved="false"></xref> that supports the <xref href="System.IDisposable" data-throw-if-not-resolved="false"></xref> pattern.

```csharp
public struct ObjectHandle<T> : IDisposable where T : class
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

[ObjectExtensions.AsNonNull<ObjectHandle<T\>\>\(ObjectHandle<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ObjectHandle<T\>\>\(ObjectHandle<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ObjectHandle<T\>\>\(ObjectHandle<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ObjectHandle<T\>\>\(ObjectHandle<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ObjectHandle<T\>, TChild\>\(ObjectHandle<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ObjectHandle<T\>, TChild\>\(ObjectHandle<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ObjectHandle<T\>, TChild\>\(ObjectHandle<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ObjectHandle<T\>\>\(ObjectHandle<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Allocation_ObjectHandle_1__ctor__0_System_Runtime_InteropServices_GCHandleType_"></a> ObjectHandle\(T, GCHandleType\)

Wraps the provided object with a <xref href="System.Runtime.InteropServices.GCHandle" data-throw-if-not-resolved="false"></xref>, using the given <xref href="System.Runtime.InteropServices.GCHandleType" data-throw-if-not-resolved="false"></xref>.

```csharp
public ObjectHandle(T target, GCHandleType handleType)
```

#### Parameters

`target` T

The target object to wrap.

`handleType` [GCHandleType](https://learn.microsoft.com/dotnet/api/system.runtime.interopservices.gchandletype)

The handle type to use.

### <a id="osu_Framework_Allocation_ObjectHandle_1__ctor_System_IntPtr_System_Boolean_"></a> ObjectHandle\(nint, bool\)

Recreates an <xref href="osu.Framework.Allocation.ObjectHandle%601" data-throw-if-not-resolved="false"></xref> based on the passed <xref href="System.IntPtr" data-throw-if-not-resolved="false"></xref>.
If <code class="paramref">ownsHandle</code> is <code>true</code>, disposing this object will free the handle.

```csharp
public ObjectHandle(nint handle, bool ownsHandle = false)
```

#### Parameters

`handle` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

<xref href="osu.Framework.Allocation.ObjectHandle%601.Handle" data-throw-if-not-resolved="false"></xref> from a previously constructed <xref href="osu.Framework.Allocation.ObjectHandle%601.%23ctor(%600%2cSystem.Runtime.InteropServices.GCHandleType)" data-throw-if-not-resolved="false"></xref>.

`ownsHandle` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this instance owns the underlying <xref href="System.Runtime.InteropServices.GCHandle" data-throw-if-not-resolved="false"></xref>.

## Properties

### <a id="osu_Framework_Allocation_ObjectHandle_1_Address"></a> Address

The address of target object, if it is allocated and pinned.  Otherwise <xref href="System.IntPtr.Zero" data-throw-if-not-resolved="false"></xref>.
Note: This is not the same as the <xref href="osu.Framework.Allocation.ObjectHandle%601.Handle" data-throw-if-not-resolved="false"></xref>.

```csharp
public nint Address { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Allocation_ObjectHandle_1_Handle"></a> Handle

The pointer from the <xref href="System.Runtime.InteropServices.GCHandle" data-throw-if-not-resolved="false"></xref>, if it is allocated.  Otherwise <xref href="System.IntPtr.Zero" data-throw-if-not-resolved="false"></xref>.

```csharp
public nint Handle { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Allocation_ObjectHandle_1_IsAllocated"></a> IsAllocated

```csharp
public bool IsAllocated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Allocation_ObjectHandle_1_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Allocation_ObjectHandle_1_GetTarget__0__"></a> GetTarget\(out T\)

Gets the object being referenced.
Returns true if successful and populates <code class="paramref">target</code> with the referenced object.
Returns false If the handle is not allocated or the target is not of type <code class="typeparamref">T</code>.

```csharp
public bool GetTarget(out T target)
```

#### Parameters

`target` T

Populates this parameter with the targeted object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

