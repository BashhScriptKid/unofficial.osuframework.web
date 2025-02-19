# <a id="osu_Framework_Extensions_PopoverExtensions"></a> Class PopoverExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class PopoverExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PopoverExtensions](osu.Framework.Extensions.PopoverExtensions.md)

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

### <a id="osu_Framework_Extensions_PopoverExtensions_HidePopover_osu_Framework_Graphics_Drawable_"></a> HidePopover\(Drawable\)

Hides the popover shown on <code class="paramref">drawable</code>'s nearest <xref href="osu.Framework.Graphics.Cursor.PopoverContainer" data-throw-if-not-resolved="false"></xref> ancestor.

```csharp
public static void HidePopover(this Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Extensions_PopoverExtensions_ShowPopover_osu_Framework_Graphics_Cursor_IHasPopover_"></a> ShowPopover\(IHasPopover\)

Shows the popover for <code class="paramref">hasPopover</code> on its nearest <xref href="osu.Framework.Graphics.Cursor.PopoverContainer" data-throw-if-not-resolved="false"></xref> ancestor.

```csharp
public static void ShowPopover(this IHasPopover hasPopover)
```

#### Parameters

`hasPopover` [IHasPopover](osu.Framework.Graphics.Cursor.IHasPopover.md)

