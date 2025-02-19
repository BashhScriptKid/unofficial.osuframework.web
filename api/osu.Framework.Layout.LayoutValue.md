# <a id="osu_Framework_Layout_LayoutValue"></a> Class LayoutValue

Namespace: [osu.Framework.Layout](osu.Framework.Layout.md)  
Assembly: osu.Framework.dll  

A member that represents the validation state of the layout of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Can be invalidated according to state changes in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> (via <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags), and validated on-demand when the layout has been re-computed.

```csharp
public class LayoutValue : LayoutMember
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LayoutMember](osu.Framework.Layout.LayoutMember.md) ← 
[LayoutValue](osu.Framework.Layout.LayoutValue.md)

#### Inherited Members

[LayoutMember.Invalidation](osu.Framework.Layout.LayoutMember.md\#osu\_Framework\_Layout\_LayoutMember\_Invalidation), 
[LayoutMember.Conditions](osu.Framework.Layout.LayoutMember.md\#osu\_Framework\_Layout\_LayoutMember\_Conditions), 
[LayoutMember.Source](osu.Framework.Layout.LayoutMember.md\#osu\_Framework\_Layout\_LayoutMember\_Source), 
[LayoutMember.IsValid](osu.Framework.Layout.LayoutMember.md\#osu\_Framework\_Layout\_LayoutMember\_IsValid), 
[LayoutMember.Invalidate\(\)](osu.Framework.Layout.LayoutMember.md\#osu\_Framework\_Layout\_LayoutMember\_Invalidate), 
[LayoutMember.Validate\(\)](osu.Framework.Layout.LayoutMember.md\#osu\_Framework\_Layout\_LayoutMember\_Validate), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LayoutValue\>\(LayoutValue?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LayoutValue\>\(LayoutValue\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LayoutValue\>\(LayoutValue\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LayoutValue\>\(LayoutValue\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LayoutValue, TChild\>\(LayoutValue, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LayoutValue, TChild\>\(LayoutValue, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LayoutValue, TChild\>\(LayoutValue, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LayoutValue\>\(LayoutValue\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Layout_LayoutValue__ctor_osu_Framework_Graphics_Invalidation_osu_Framework_Layout_InvalidationSource_osu_Framework_Layout_InvalidationConditionDelegate_"></a> LayoutValue\(Invalidation, InvalidationSource, InvalidationConditionDelegate\)

Creates a new <xref href="osu.Framework.Layout.LayoutValue" data-throw-if-not-resolved="false"></xref>.

```csharp
public LayoutValue(Invalidation invalidation, InvalidationSource source = InvalidationSource.Default, InvalidationConditionDelegate conditions = null)
```

#### Parameters

`invalidation` [Invalidation](osu.Framework.Graphics.Invalidation.md)

The <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags that will invalidate this <xref href="osu.Framework.Layout.LayoutValue" data-throw-if-not-resolved="false"></xref>.

`source` [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

The source of the invalidation.

`conditions` [InvalidationConditionDelegate](osu.Framework.Layout.InvalidationConditionDelegate.md)

Any extra conditions that must be satisfied before this <xref href="osu.Framework.Layout.LayoutValue" data-throw-if-not-resolved="false"></xref> is invalidated.

## Methods

### <a id="osu_Framework_Layout_LayoutValue_Validate"></a> Validate\(\)

Validates this <xref href="osu.Framework.Layout.LayoutValue" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Validate()
```

