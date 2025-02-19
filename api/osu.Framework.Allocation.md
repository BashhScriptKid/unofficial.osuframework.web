# <a id="osu_Framework_Allocation"></a> Namespace osu.Framework.Allocation

### Classes

 [AccessModifierNotAllowedForCachedValueException](osu.Framework.Allocation.AccessModifierNotAllowedForCachedValueException.md)

Occurs when attempting to cache a non-private and non-readonly field with an attached <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref>.

 [AccessModifierNotAllowedForLoaderMethodException](osu.Framework.Allocation.AccessModifierNotAllowedForLoaderMethodException.md)

Occurs when a method with an attached <xref href="osu.Framework.Allocation.BackgroundDependencyLoaderAttribute" data-throw-if-not-resolved="false"></xref> isn't private.

 [AccessModifierNotAllowedForMemberException](osu.Framework.Allocation.AccessModifierNotAllowedForMemberException.md)

Occurs when a dependency-related operation occurred on a member with an unacceptable access modifier.

 [AccessModifierNotAllowedForPropertySetterException](osu.Framework.Allocation.AccessModifierNotAllowedForPropertySetterException.md)

Occurs when the setter of a property with an attached <xref href="osu.Framework.Allocation.ResolvedAttribute" data-throw-if-not-resolved="false"></xref> isn't private.

 [BackgroundDependencyLoaderAttribute](osu.Framework.Allocation.BackgroundDependencyLoaderAttribute.md)

Marks a method as the (potentially asynchronous) initialization method of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, allowing for automatic injection of dependencies via the parameters of the method.

 [CachedAttribute](osu.Framework.Allocation.CachedAttribute.md)

An attribute that may be attached to a class, interface, field, or property definitions of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>
to indicate that the value should be cached as a dependency.
Cached values may be resolved through <xref href="osu.Framework.Allocation.BackgroundDependencyLoaderAttribute" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Allocation.ResolvedAttribute" data-throw-if-not-resolved="false"></xref>.

 [CachedModelDependencyContainer<TModel\>](osu.Framework.Allocation.CachedModelDependencyContainer\-1.md)

A <xref href="osu.Framework.Allocation.DependencyContainer" data-throw-if-not-resolved="false"></xref> which caches a <code class="typeparamref">TModel</code> and members it contains attached with a <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> as dependencies.

 [DependencyContainer](osu.Framework.Allocation.DependencyContainer.md)

Hierarchically caches dependencies and can inject those automatically into types registered for dependency injection.

 [DependencyNotRegisteredException](osu.Framework.Allocation.DependencyNotRegisteredException.md)

Occurs when an object requests the resolution of a dependency, but the dependency doesn't exist.
This is caused by the dependency not being registered by parent <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> through
<xref href="osu.Framework.Graphics.Containers.CompositeDrawable.CreateChildDependencies(osu.Framework.Allocation.IReadOnlyDependencyContainer)" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref>.

 [InvokeOnDisposal](osu.Framework.Allocation.InvokeOnDisposal.md)

Instances of this class capture an action for later cleanup. When a method returns an instance of this class, the appropriate usage is:
<pre><code class="lang-csharp">using (SomeMethod())
    {
        // ...
    }</code></pre>
The using block will automatically dispose the returned instance, doing the necessary cleanup work.

 [InvokeOnDisposal<T\>](osu.Framework.Allocation.InvokeOnDisposal\-1.md)

Instances of this class capture an action for later cleanup. When a method returns an instance of this class, the appropriate usage is:
<pre><code class="lang-csharp">using (SomeMethod())
    {
        // ...
    }</code></pre>
The using block will automatically dispose the returned instance, doing the necessary cleanup work.

 [LongRunningLoadAttribute](osu.Framework.Allocation.LongRunningLoadAttribute.md)

Denotes a component which performs long-running tasks in its <xref href="osu.Framework.Allocation.BackgroundDependencyLoaderAttribute" data-throw-if-not-resolved="false"></xref> method that are not CPU intensive.
Long-running tasks are scheduled into a lower priority thread pool.

 [MultipleDependencyLoaderMethodsException](osu.Framework.Allocation.MultipleDependencyLoaderMethodsException.md)

Occurs when multiple <xref href="osu.Framework.Allocation.BackgroundDependencyLoaderAttribute" data-throw-if-not-resolved="false"></xref>s exist in one object.

 [NullDependencyException](osu.Framework.Allocation.NullDependencyException.md)

The exception that is thrown when attempting to cache <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> using <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref>.

 [PropertyNotWritableException](osu.Framework.Allocation.PropertyNotWritableException.md)

 [ReadOnlyDependencyContainerExtensions](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md)

 [ResolvedAttribute](osu.Framework.Allocation.ResolvedAttribute.md)

An attribute that is attached to properties of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> component to indicate that the value of the property should be retrieved from a dependency cache.
Properties marked with this attribute must be private and have a setter.

 [TimedExpiryCache<TKey, TValue\>](osu.Framework.Allocation.TimedExpiryCache\-2.md)

A key-value store which supports cleaning up items after a specified expiry time.

 [TypeAlreadyCachedException](osu.Framework.Allocation.TypeAlreadyCachedException.md)

### Structs

 [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

 [ObjectHandle<T\>](osu.Framework.Allocation.ObjectHandle\-1.md)

Wrapper on <xref href="System.Runtime.InteropServices.GCHandle" data-throw-if-not-resolved="false"></xref> that supports the <xref href="System.IDisposable" data-throw-if-not-resolved="false"></xref> pattern.

 [ValueInvokeOnDisposal<T\>](osu.Framework.Allocation.ValueInvokeOnDisposal\-1.md)

Instances of this struct capture an action for later cleanup. The appropriate usage is:
<pre><code class="lang-csharp">using (SomeMethod())
     {
         // ...
     }</code></pre>
The using block will automatically dispose the returned instance, doing the necessary cleanup work.

This is a struct version of <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used when allocations are to be minimised.

 [ValueInvokeOnDisposal](osu.Framework.Allocation.ValueInvokeOnDisposal.md)

Instances of this struct capture an action for later cleanup. The appropriate usage is:
<pre><code class="lang-csharp">using (SomeMethod())
     {
         // ...
     }</code></pre>
The using block will automatically dispose the returned instance, doing the necessary cleanup work.

This is a struct version of <xref href="osu.Framework.Allocation.InvokeOnDisposal" data-throw-if-not-resolved="false"></xref> to be used when allocations are to be minimised.

### Interfaces

 [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

An interface for objects to register dependency activation functions with.

 [IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md)

An interface that may be attached to objects to allow them to be used in <xref href="osu.Framework.Allocation.DependencyContainer.Inject%60%601(%60%600)" data-throw-if-not-resolved="false"></xref>.

 [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

Read-only interface into a dependency container capable of injective and retrieving dependencies based
on types.

 [ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md)

Implemented by source generators to inject dependencies into an object.

 [ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md)

### Delegates

 [CacheDependencyDelegate](osu.Framework.Allocation.CacheDependencyDelegate.md)

 [InjectDependencyDelegate](osu.Framework.Allocation.InjectDependencyDelegate.md)

