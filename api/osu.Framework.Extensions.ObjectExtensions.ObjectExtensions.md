# <a id="osu_Framework_Extensions_ObjectExtensions_ObjectExtensions"></a> Class ObjectExtensions

Namespace: [osu.Framework.Extensions.ObjectExtensions](osu.Framework.Extensions.ObjectExtensions.md)  
Assembly: osu.Framework.dll  

Extensions that apply to all objects.

```csharp
public static class ObjectExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ObjectExtensions](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md)

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

### <a id="osu_Framework_Extensions_ObjectExtensions_ObjectExtensions_AsNonNull__1___0_"></a> AsNonNull<T\>\(T?\)

Coerces a nullable object as non-nullable. This is an alternative to the C# 8 null-forgiving operator "<code>!</code>".

```csharp
public static T AsNonNull<T>(this T? obj)
```

#### Parameters

`obj` T?

The nullable object.

#### Returns

 T

The non-nullable object corresponding to <code class="paramref">obj</code>.

#### Type Parameters

`T` 

The type of the object.

#### Remarks

This should only be used when an assertion or other handling is not a reasonable alternative.

### <a id="osu_Framework_Extensions_ObjectExtensions_ObjectExtensions_IsNotNull__1___0_"></a> IsNotNull<T\>\(T\)

<code>true</code> if the given object is not null, <code>false</code> otherwise.

```csharp
public static bool IsNotNull<T>(this T obj)
```

#### Parameters

`obj` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ObjectExtensions_ObjectExtensions_IsNull__1___0_"></a> IsNull<T\>\(T\)

If the given object is null.

```csharp
public static bool IsNull<T>(this T obj)
```

#### Parameters

`obj` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

