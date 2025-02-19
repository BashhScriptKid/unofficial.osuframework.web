# <a id="osu_Framework_Graphics_UserInterface_DropdownMenuItem_1"></a> Class DropdownMenuItem<T\>

Namespace: [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)  
Assembly: osu.Framework.dll  

```csharp
public class DropdownMenuItem<T> : MenuItem
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](osu.Framework.Graphics.UserInterface.MenuItem.md) ← 
[DropdownMenuItem<T\>](osu.Framework.Graphics.UserInterface.DropdownMenuItem\-1.md)

#### Inherited Members

[MenuItem.Text](osu.Framework.Graphics.UserInterface.MenuItem.md\#osu\_Framework\_Graphics\_UserInterface\_MenuItem\_Text), 
[MenuItem.Action](osu.Framework.Graphics.UserInterface.MenuItem.md\#osu\_Framework\_Graphics\_UserInterface\_MenuItem\_Action), 
[MenuItem.Items](osu.Framework.Graphics.UserInterface.MenuItem.md\#osu\_Framework\_Graphics\_UserInterface\_MenuItem\_Items), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DropdownMenuItem<T\>\>\(DropdownMenuItem<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DropdownMenuItem<T\>\>\(DropdownMenuItem<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DropdownMenuItem<T\>\>\(DropdownMenuItem<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DropdownMenuItem<T\>\>\(DropdownMenuItem<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DropdownMenuItem<T\>, TChild\>\(DropdownMenuItem<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DropdownMenuItem<T\>, TChild\>\(DropdownMenuItem<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DropdownMenuItem<T\>, TChild\>\(DropdownMenuItem<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DropdownMenuItem<T\>\>\(DropdownMenuItem<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_UserInterface_DropdownMenuItem_1__ctor_osu_Framework_Localisation_LocalisableString__0_"></a> DropdownMenuItem\(LocalisableString, T\)

```csharp
public DropdownMenuItem(LocalisableString text, T value)
```

#### Parameters

`text` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

`value` T

### <a id="osu_Framework_Graphics_UserInterface_DropdownMenuItem_1__ctor__0_System_Action_"></a> DropdownMenuItem\(T, Action\)

```csharp
public DropdownMenuItem(T value, Action action)
```

#### Parameters

`value` T

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)

## Fields

### <a id="osu_Framework_Graphics_UserInterface_DropdownMenuItem_1_Value"></a> Value

```csharp
public readonly T Value
```

#### Field Value

 T

