# <a id="osu_Framework_Lists_FuncEqualityComparer_1"></a> Class FuncEqualityComparer<T\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

```csharp
public class FuncEqualityComparer<T> : IEqualityComparer<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FuncEqualityComparer<T\>](osu.Framework.Lists.FuncEqualityComparer\-1.md)

#### Implements

[IEqualityComparer<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FuncEqualityComparer<T\>\>\(FuncEqualityComparer<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FuncEqualityComparer<T\>\>\(FuncEqualityComparer<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FuncEqualityComparer<T\>\>\(FuncEqualityComparer<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FuncEqualityComparer<T\>\>\(FuncEqualityComparer<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FuncEqualityComparer<T\>, TChild\>\(FuncEqualityComparer<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FuncEqualityComparer<T\>, TChild\>\(FuncEqualityComparer<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FuncEqualityComparer<T\>, TChild\>\(FuncEqualityComparer<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FuncEqualityComparer<T\>\>\(FuncEqualityComparer<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Lists_FuncEqualityComparer_1__ctor_System_Func__0__0_System_Boolean__"></a> FuncEqualityComparer\(Func<T, T, bool\>\)

```csharp
public FuncEqualityComparer(Func<T, T, bool> func)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-3)<T, T, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

## Methods

### <a id="osu_Framework_Lists_FuncEqualityComparer_1_Equals__0__0_"></a> Equals\(T, T\)

Determines whether the specified objects are equal.

```csharp
public bool Equals(T x, T y)
```

#### Parameters

`x` T

The first object of type <code class="paramref">T</code> to compare.

`y` T

The second object of type <code class="paramref">T</code> to compare.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified objects are equal; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Lists_FuncEqualityComparer_1_GetHashCode__0_"></a> GetHashCode\(T\)

Returns a hash code for the specified object.

```csharp
public int GetHashCode(T obj)
```

#### Parameters

`obj` T

The <xref href="System.Object" data-throw-if-not-resolved="false"></xref> for which a hash code is to be returned.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the specified object.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

The type of <code class="paramref">obj</code> is a reference type and <code class="paramref">obj</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

