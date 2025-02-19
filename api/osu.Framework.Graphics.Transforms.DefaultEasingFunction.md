# <a id="osu_Framework_Graphics_Transforms_DefaultEasingFunction"></a> Struct DefaultEasingFunction

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

An easing function corresponding to one of the <xref href="osu.Framework.Graphics.Easing" data-throw-if-not-resolved="false"></xref> types.

```csharp
public readonly struct DefaultEasingFunction : IEasingFunction
```

#### Implements

[IEasingFunction](osu.Framework.Graphics.Transforms.IEasingFunction.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DefaultEasingFunction\>\(DefaultEasingFunction\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DefaultEasingFunction\>\(DefaultEasingFunction\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DefaultEasingFunction\>\(DefaultEasingFunction\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DefaultEasingFunction\>\(DefaultEasingFunction\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DefaultEasingFunction, TChild\>\(DefaultEasingFunction, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DefaultEasingFunction, TChild\>\(DefaultEasingFunction, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DefaultEasingFunction, TChild\>\(DefaultEasingFunction, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DefaultEasingFunction\>\(DefaultEasingFunction\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Transforms_DefaultEasingFunction__ctor_osu_Framework_Graphics_Easing_"></a> DefaultEasingFunction\(Easing\)

Creates a new <xref href="osu.Framework.Graphics.Transforms.DefaultEasingFunction" data-throw-if-not-resolved="false"></xref> for an <xref href="osu.Framework.Graphics.Easing" data-throw-if-not-resolved="false"></xref>.

```csharp
public DefaultEasingFunction(Easing easing)
```

#### Parameters

`easing` [Easing](osu.Framework.Graphics.Easing.md)

The <xref href="osu.Framework.Graphics.Easing" data-throw-if-not-resolved="false"></xref> type.

## Methods

### <a id="osu_Framework_Graphics_Transforms_DefaultEasingFunction_ApplyEasing_System_Double_"></a> ApplyEasing\(double\)

Applies the easing function to a time value.

```csharp
public double ApplyEasing(double time)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time value to apply the easing to.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The eased time value.

