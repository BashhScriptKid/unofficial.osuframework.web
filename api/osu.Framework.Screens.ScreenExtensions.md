# <a id="osu_Framework_Screens_ScreenExtensions"></a> Class ScreenExtensions

Namespace: [osu.Framework.Screens](osu.Framework.Screens.md)  
Assembly: osu.Framework.dll  

```csharp
public static class ScreenExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ScreenExtensions](osu.Framework.Screens.ScreenExtensions.md)

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

### <a id="osu_Framework_Screens_ScreenExtensions_Exit_osu_Framework_Screens_IScreen_"></a> Exit\(IScreen\)

Exits from an <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
public static void Exit(this IScreen screen)
```

#### Parameters

`screen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to exit from.

### <a id="osu_Framework_Screens_ScreenExtensions_GetChildScreen_osu_Framework_Screens_IScreen_"></a> GetChildScreen\(IScreen\)

Retrieves the child <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> of an <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
public static IScreen GetChildScreen(this IScreen screen)
```

#### Parameters

`screen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to retrieve the child of.

#### Returns

 [IScreen](osu.Framework.Screens.IScreen.md)

The child <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> of <code class="paramref">screen</code>, or null if <code class="paramref">screen</code> has no child.

### <a id="osu_Framework_Screens_ScreenExtensions_GetParentScreen_osu_Framework_Screens_IScreen_"></a> GetParentScreen\(IScreen\)

Retrieves the parent <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> of an <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
public static IScreen GetParentScreen(this IScreen screen)
```

#### Parameters

`screen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to retrieve the parent of.

#### Returns

 [IScreen](osu.Framework.Screens.IScreen.md)

The parent <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> of <code class="paramref">screen</code>, or null if <code class="paramref">screen</code> has no parent.

### <a id="osu_Framework_Screens_ScreenExtensions_IsCurrentScreen_osu_Framework_Screens_IScreen_"></a> IsCurrentScreen\(IScreen\)

Retrieves whether an <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> is the current screen.
This will return false on all <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>s while a child <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> is loading.

```csharp
public static bool IsCurrentScreen(this IScreen screen)
```

#### Parameters

`screen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if <code class="paramref">screen</code> is the current screen.

### <a id="osu_Framework_Screens_ScreenExtensions_MakeCurrent_osu_Framework_Screens_IScreen_"></a> MakeCurrent\(IScreen\)

Makes an <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> the current screen, exiting all child <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>s along the way.

```csharp
public static void MakeCurrent(this IScreen screen)
```

#### Parameters

`screen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to make current.

### <a id="osu_Framework_Screens_ScreenExtensions_Push_osu_Framework_Screens_IScreen_osu_Framework_Screens_IScreen_"></a> Push\(IScreen, IScreen\)

Pushes an <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to another.

```csharp
public static void Push(this IScreen screen, IScreen newScreen)
```

#### Parameters

`screen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to push to.

`newScreen` [IScreen](osu.Framework.Screens.IScreen.md)

The <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> to push.

