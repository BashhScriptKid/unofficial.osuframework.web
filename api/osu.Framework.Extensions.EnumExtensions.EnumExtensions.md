# <a id="osu_Framework_Extensions_EnumExtensions_EnumExtensions"></a> Class EnumExtensions

Namespace: [osu.Framework.Extensions.EnumExtensions](osu.Framework.Extensions.EnumExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class EnumExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EnumExtensions](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md)

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

### <a id="osu_Framework_Extensions_EnumExtensions_EnumExtensions_GetValuesInOrder__1"></a> GetValuesInOrder<T\>\(\)

Get values of an enum in order. Supports custom ordering via <xref href="osu.Framework.Utils.OrderAttribute" data-throw-if-not-resolved="false"></xref>.

```csharp
public static IEnumerable<T> GetValuesInOrder<T>()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_EnumExtensions_EnumExtensions_GetValuesInOrder__1_System_Collections_Generic_IEnumerable___0__"></a> GetValuesInOrder<T\>\(IEnumerable<T\>\)

Get values of a collection of enum values in order. Supports custom ordering via <xref href="osu.Framework.Utils.OrderAttribute" data-throw-if-not-resolved="false"></xref>.

```csharp
public static IEnumerable<T> GetValuesInOrder<T>(this IEnumerable<T> items)
```

#### Parameters

`items` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_EnumExtensions_EnumExtensions_HasFlagFast__1___0___0_"></a> HasFlagFast<T\>\(T, T\)

A fast alternative functionally equivalent to <xref href="System.Enum.HasFlag(System.Enum)" data-throw-if-not-resolved="false"></xref>, eliminating boxing in all scenarios.

```csharp
public static bool HasFlagFast<T>(this T enumValue, T flag) where T : unmanaged, Enum
```

#### Parameters

`enumValue` T

The enum to check.

`flag` T

The flag to check for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

