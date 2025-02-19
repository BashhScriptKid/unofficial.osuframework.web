# <a id="osu_Framework_Layout_LayoutMember"></a> Class LayoutMember

Namespace: [osu.Framework.Layout](osu.Framework.Layout.md)  
Assembly: osu.Framework.dll  

A member that represents a part of the layout of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Can be invalidated according to state changes in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> (via <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags).

```csharp
public abstract class LayoutMember
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LayoutMember](osu.Framework.Layout.LayoutMember.md)

#### Derived

[LayoutValue<T\>](osu.Framework.Layout.LayoutValue\-1.md), 
[LayoutValue](osu.Framework.Layout.LayoutValue.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LayoutMember\>\(LayoutMember?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LayoutMember\>\(LayoutMember\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LayoutMember\>\(LayoutMember\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LayoutMember\>\(LayoutMember\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LayoutMember, TChild\>\(LayoutMember, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LayoutMember, TChild\>\(LayoutMember, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LayoutMember, TChild\>\(LayoutMember, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LayoutMember\>\(LayoutMember\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Layout_LayoutMember__ctor_osu_Framework_Graphics_Invalidation_osu_Framework_Layout_InvalidationSource_osu_Framework_Layout_InvalidationConditionDelegate_"></a> LayoutMember\(Invalidation, InvalidationSource, InvalidationConditionDelegate?\)

Creates a new <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref>.

```csharp
protected LayoutMember(Invalidation invalidation, InvalidationSource source = InvalidationSource.Default, InvalidationConditionDelegate? conditions = null)
```

#### Parameters

`invalidation` [Invalidation](osu.Framework.Graphics.Invalidation.md)

The <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags that will invalidate this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref>.

`source` [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

The source of the invalidation.

`conditions` [InvalidationConditionDelegate](osu.Framework.Layout.InvalidationConditionDelegate.md)?

Any extra conditions that must be satisfied before this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref> is invalidated.

## Fields

### <a id="osu_Framework_Layout_LayoutMember_Conditions"></a> Conditions

Any extra conditions that must be satisfied before this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref> is invalidated.

```csharp
public readonly InvalidationConditionDelegate? Conditions
```

#### Field Value

 [InvalidationConditionDelegate](osu.Framework.Layout.InvalidationConditionDelegate.md)?

### <a id="osu_Framework_Layout_LayoutMember_Invalidation"></a> Invalidation

The <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref> responds to.

```csharp
public readonly Invalidation Invalidation
```

#### Field Value

 [Invalidation](osu.Framework.Graphics.Invalidation.md)

### <a id="osu_Framework_Layout_LayoutMember_Source"></a> Source

The source of <xref href="osu.Framework.Layout.LayoutMember.Invalidation" data-throw-if-not-resolved="false"></xref> this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref> responds to.

```csharp
public readonly InvalidationSource Source
```

#### Field Value

 [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

## Properties

### <a id="osu_Framework_Layout_LayoutMember_IsValid"></a> IsValid

Whether this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref> is valid.

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Layout_LayoutMember_Invalidate"></a> Invalidate\(\)

Invalidates this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Invalidate()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether any invalidation occurred.

### <a id="osu_Framework_Layout_LayoutMember_Validate"></a> Validate\(\)

Validates this <xref href="osu.Framework.Layout.LayoutMember" data-throw-if-not-resolved="false"></xref>.

```csharp
protected void Validate()
```

