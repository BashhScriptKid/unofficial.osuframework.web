# <a id="osu_Framework_Testing_TestingExtensions"></a> Class TestingExtensions

Namespace: [osu.Framework.Testing](osu.Framework.Testing.md)  
Assembly: osu.Framework.dll  

```csharp
public static class TestingExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TestingExtensions](osu.Framework.Testing.TestingExtensions.md)

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

### <a id="osu_Framework_Testing_TestingExtensions_ChildrenOfType__1_osu_Framework_Graphics_Drawable_"></a> ChildrenOfType<T\>\(Drawable?\)

Find all children recursively of a specific type. As this is expensive and dangerous, it should only be used for testing purposes.

```csharp
public static IEnumerable<T> ChildrenOfType<T>(this Drawable? drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)?

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

