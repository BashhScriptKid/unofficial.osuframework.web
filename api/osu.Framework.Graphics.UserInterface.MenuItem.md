# <a id="osu_Framework_Graphics_UserInterface_MenuItem"></a> Class MenuItem

Namespace: [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)  
Assembly: osu.Framework.dll  

```csharp
public class MenuItem
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuItem](osu.Framework.Graphics.UserInterface.MenuItem.md)

#### Derived

[DropdownMenuItem<T\>](osu.Framework.Graphics.UserInterface.DropdownMenuItem\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MenuItem\>\(MenuItem?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MenuItem\>\(MenuItem\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MenuItem\>\(MenuItem\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MenuItem\>\(MenuItem\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MenuItem, TChild\>\(MenuItem, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MenuItem, TChild\>\(MenuItem, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MenuItem, TChild\>\(MenuItem, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MenuItem\>\(MenuItem\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_UserInterface_MenuItem__ctor_osu_Framework_Localisation_LocalisableString_"></a> MenuItem\(LocalisableString\)

Creates a new <xref href="osu.Framework.Graphics.UserInterface.MenuItem" data-throw-if-not-resolved="false"></xref>.

```csharp
public MenuItem(LocalisableString text)
```

#### Parameters

`text` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The text to display.

### <a id="osu_Framework_Graphics_UserInterface_MenuItem__ctor_System_Action_"></a> MenuItem\(Action\)

Creates a new <xref href="osu.Framework.Graphics.UserInterface.MenuItem" data-throw-if-not-resolved="false"></xref>.

```csharp
protected MenuItem(Action action)
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The <xref href="osu.Framework.Graphics.UserInterface.MenuItem.Action" data-throw-if-not-resolved="false"></xref> to perform when clicked.

### <a id="osu_Framework_Graphics_UserInterface_MenuItem__ctor_osu_Framework_Localisation_LocalisableString_System_Action_"></a> MenuItem\(LocalisableString, Action?\)

Creates a new <xref href="osu.Framework.Graphics.UserInterface.MenuItem" data-throw-if-not-resolved="false"></xref>.

```csharp
public MenuItem(LocalisableString text, Action? action)
```

#### Parameters

`text` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The text to display.

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)?

The <xref href="osu.Framework.Graphics.UserInterface.MenuItem.Action" data-throw-if-not-resolved="false"></xref> to perform when clicked.

## Fields

### <a id="osu_Framework_Graphics_UserInterface_MenuItem_Action"></a> Action

The <xref href="osu.Framework.Graphics.UserInterface.MenuItem.Action" data-throw-if-not-resolved="false"></xref> that is performed when this <xref href="osu.Framework.Graphics.UserInterface.MenuItem" data-throw-if-not-resolved="false"></xref> is clicked.

```csharp
public readonly Bindable<Action?> Action
```

#### Field Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[Action](https://learn.microsoft.com/dotnet/api/system.action)?\>

### <a id="osu_Framework_Graphics_UserInterface_MenuItem_Items"></a> Items

A list of items which are to be displayed in a sub-menu originating from this <xref href="osu.Framework.Graphics.UserInterface.MenuItem" data-throw-if-not-resolved="false"></xref>.

```csharp
public IReadOnlyList<MenuItem> Items
```

#### Field Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[MenuItem](osu.Framework.Graphics.UserInterface.MenuItem.md)\>

### <a id="osu_Framework_Graphics_UserInterface_MenuItem_Text"></a> Text

The text which this <xref href="osu.Framework.Graphics.UserInterface.MenuItem" data-throw-if-not-resolved="false"></xref> displays.

```csharp
public readonly Bindable<LocalisableString> Text
```

#### Field Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[LocalisableString](osu.Framework.Localisation.LocalisableString.md)\>

