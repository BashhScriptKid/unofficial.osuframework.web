# <a id="osu_Framework_Graphics_Containers_ContainerExtensions"></a> Class ContainerExtensions

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Holds extension methods for <xref href="osu.Framework.Graphics.Containers.Container%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public static class ContainerExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ContainerExtensions](osu.Framework.Graphics.Containers.ContainerExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Graphics_Containers_ContainerExtensions_WithChild__2___0___1_"></a> WithChild<TContainer, TChild\>\(TContainer, TChild\)

Set a specified <code class="paramref">child</code> on <code class="paramref">container</code>.

```csharp
public static TContainer WithChild<TContainer, TChild>(this TContainer container, TChild child) where TContainer : IContainerCollection<TChild> where TChild : Drawable
```

#### Parameters

`container` TContainer

The <code class="paramref">container</code> that will have a child set.

`child` TChild

The <code class="paramref">child</code> that should be set to the <code class="paramref">container</code>.

#### Returns

 TContainer

The given <code class="paramref">container</code>.

#### Type Parameters

`TContainer` 

The container type.

`TChild` 

The type of children contained by <code class="paramref">container</code>.

### <a id="osu_Framework_Graphics_Containers_ContainerExtensions_WithChildren__2___0_System_Collections_Generic_IEnumerable___1__"></a> WithChildren<TContainer, TChild\>\(TContainer, IEnumerable<TChild\>\)

Set specified <code class="paramref">children</code> on <code class="paramref">container</code>.

```csharp
public static TContainer WithChildren<TContainer, TChild>(this TContainer container, IEnumerable<TChild> children) where TContainer : IContainerCollection<TChild> where TChild : Drawable
```

#### Parameters

`container` TContainer

The <code class="paramref">container</code> that will have children set.

`children` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TChild\>

The <code class="paramref">children</code> that should be set to the <code class="paramref">container</code>.

#### Returns

 TContainer

The given <code class="paramref">container</code>.

#### Type Parameters

`TContainer` 

The container type.

`TChild` 

The type of children contained by <code class="paramref">container</code>.

### <a id="osu_Framework_Graphics_Containers_ContainerExtensions_Wrap__2___0___1_"></a> Wrap<TContainer, TChild\>\(TContainer, TChild\)

Wraps the given <code class="paramref">drawable</code> with the given <code class="paramref">container</code>
such that the <code class="paramref">container</code> can be used instead of the <code class="paramref">drawable</code>
without affecting the layout. The <code class="paramref">container</code> must not contain any children before wrapping.

```csharp
public static TContainer Wrap<TContainer, TChild>(this TContainer container, TChild drawable) where TContainer : Container<TChild> where TChild : Drawable
```

#### Parameters

`container` TContainer

The <code class="paramref">container</code> that should wrap the given <code class="paramref">drawable</code>.

`drawable` TChild

The <code class="paramref">drawable</code> that should be wrapped by the given <code class="paramref">container</code>.

#### Returns

 TContainer

The given <code class="paramref">container</code>.

#### Type Parameters

`TContainer` 

The type of the <code class="paramref">container</code>.

`TChild` 

The type of the children of <code class="paramref">container</code>.

