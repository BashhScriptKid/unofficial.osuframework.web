# <a id="osu_Framework_Graphics_DrawableExtensions"></a> Class DrawableExtensions

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Holds extension methods for <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public static class DrawableExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawableExtensions](osu.Framework.Graphics.DrawableExtensions.md)

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

### <a id="osu_Framework_Graphics_DrawableExtensions_FindClosestParent__1_osu_Framework_Graphics_Drawable_"></a> FindClosestParent<T\>\(Drawable?\)

Find the closest parent of a specified type.

```csharp
public static T? FindClosestParent<T>(this Drawable? drawable) where T : class, IDrawable
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)?

#### Returns

 T?

The first matching parent, or null if no parent of type <code class="typeparamref">T</code> is found.

#### Type Parameters

`T` 

The type to match.

#### Remarks

This can be a potentially expensive operation and should be used with discretion.

### <a id="osu_Framework_Graphics_DrawableExtensions_IsRootedAt_osu_Framework_Graphics_Drawable_osu_Framework_Graphics_Drawable_"></a> IsRootedAt\(Drawable?, Drawable\)

Check whether the drawable is rooted at a proposed parent drawable.

```csharp
public static bool IsRootedAt(this Drawable? drawable, Drawable root)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)?

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to be checked.

`root` [Drawable](osu.Framework.Graphics.Drawable.md)

The root to be checked against.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the drawable was rooted.

### <a id="osu_Framework_Graphics_DrawableExtensions_RemoveAndDisposeImmediately_osu_Framework_Graphics_Drawable_"></a> RemoveAndDisposeImmediately\(Drawable\)

Forces removal of this drawable from its parent, followed by immediate synchronous disposal.

```csharp
public static void RemoveAndDisposeImmediately(this Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to be disposed.

#### Remarks

This is intended as a temporary solution for the fact that there is no way to easily dispose
a component in a way that is guaranteed to be synchronously run on the update thread.

Eventually components will have a better method for unloading.

### <a id="osu_Framework_Graphics_DrawableExtensions_With__1___0_System_Action___0__"></a> With<T\>\(T, Action<T\>\)

Adjusts specified properties of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public static T With<T>(this T drawable, Action<T> adjustment) where T : Drawable
```

#### Parameters

`drawable` T

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> whose properties should be adjusted.

`adjustment` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The adjustment function.

#### Returns

 T

The given <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

