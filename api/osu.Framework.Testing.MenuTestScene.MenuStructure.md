# <a id="osu_Framework_Testing_MenuTestScene_MenuStructure"></a> Class MenuTestScene.MenuStructure

Namespace: [osu.Framework.Testing](osu.Framework.Testing.md)  
Assembly: osu.Framework.dll  

Helper class used to retrieve various internal properties/items from a <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref>.

```csharp
protected class MenuTestScene.MenuStructure
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MenuTestScene.MenuStructure](osu.Framework.Testing.MenuTestScene.MenuStructure.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MenuTestScene.MenuStructure\>\(MenuTestScene.MenuStructure?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MenuTestScene.MenuStructure\>\(MenuTestScene.MenuStructure\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MenuTestScene.MenuStructure\>\(MenuTestScene.MenuStructure\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MenuTestScene.MenuStructure\>\(MenuTestScene.MenuStructure\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MenuTestScene.MenuStructure, TChild\>\(MenuTestScene.MenuStructure, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MenuTestScene.MenuStructure, TChild\>\(MenuTestScene.MenuStructure, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MenuTestScene.MenuStructure, TChild\>\(MenuTestScene.MenuStructure, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MenuTestScene.MenuStructure\>\(MenuTestScene.MenuStructure\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Testing_MenuTestScene_MenuStructure__ctor_osu_Framework_Graphics_UserInterface_Menu_"></a> MenuStructure\(Menu\)

```csharp
public MenuStructure(Menu menu)
```

#### Parameters

`menu` [Menu](osu.Framework.Graphics.UserInterface.Menu.md)

## Methods

### <a id="osu_Framework_Testing_MenuTestScene_MenuStructure_GetMenuItems"></a> GetMenuItems\(\)

Retrieves the <xref href="osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem" data-throw-if-not-resolved="false"></xref>s of the <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> represented by this <xref href="osu.Framework.Testing.MenuTestScene.MenuStructure" data-throw-if-not-resolved="false"></xref>.

```csharp
public IReadOnlyList<Drawable> GetMenuItems()
```

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Testing_MenuTestScene_MenuStructure_GetSelectedIndex"></a> GetSelectedIndex\(\)

Finds the <xref href="osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem" data-throw-if-not-resolved="false"></xref> index in the <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> represented by this <xref href="osu.Framework.Testing.MenuTestScene.MenuStructure" data-throw-if-not-resolved="false"></xref> that
has <xref href="osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem.State" data-throw-if-not-resolved="false"></xref> set to <xref href="osu.Framework.Graphics.UserInterface.MenuItemState.Selected" data-throw-if-not-resolved="false"></xref>.

```csharp
public int GetSelectedIndex()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Testing_MenuTestScene_MenuStructure_GetSubMenu_System_Int32_"></a> GetSubMenu\(int\)

Retrieves the sub-<xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> at an index-offset from the current <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref>.

```csharp
public Menu GetSubMenu(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sub-<xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> index. An index of 0 is the <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> represented by this <xref href="osu.Framework.Testing.MenuTestScene.MenuStructure" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [Menu](osu.Framework.Graphics.UserInterface.Menu.md)

### <a id="osu_Framework_Testing_MenuTestScene_MenuStructure_GetSubStructure_System_Int32_"></a> GetSubStructure\(int\)

Generates a new <xref href="osu.Framework.Testing.MenuTestScene.MenuStructure" data-throw-if-not-resolved="false"></xref> for the a sub-<xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref>.

```csharp
public MenuTestScene.MenuStructure GetSubStructure(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sub-<xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> index to generate the <xref href="osu.Framework.Testing.MenuTestScene.MenuStructure" data-throw-if-not-resolved="false"></xref> for. An index of 0 is the <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> represented by this <xref href="osu.Framework.Testing.MenuTestScene.MenuStructure" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [MenuTestScene](osu.Framework.Testing.MenuTestScene.md).[MenuStructure](osu.Framework.Testing.MenuTestScene.MenuStructure.md)

### <a id="osu_Framework_Testing_MenuTestScene_MenuStructure_SetSelectedState_System_Int32_osu_Framework_Graphics_UserInterface_MenuItemState_"></a> SetSelectedState\(int, MenuItemState\)

Sets the <xref href="osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem" data-throw-if-not-resolved="false"></xref><xref href="osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem.State" data-throw-if-not-resolved="false"></xref> at the specified index to a specified state.

```csharp
public void SetSelectedState(int index, MenuItemState state)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the <xref href="osu.Framework.Graphics.UserInterface.Menu.DrawableMenuItem" data-throw-if-not-resolved="false"></xref> to set the state of.

`state` [MenuItemState](osu.Framework.Graphics.UserInterface.MenuItemState.md)

The state to be set.

