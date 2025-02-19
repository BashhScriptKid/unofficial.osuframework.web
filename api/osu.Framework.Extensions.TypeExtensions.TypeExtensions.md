# <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions"></a> Class TypeExtensions

Namespace: [osu.Framework.Extensions.TypeExtensions](osu.Framework.Extensions.TypeExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class TypeExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TypeExtensions](osu.Framework.Extensions.TypeExtensions.TypeExtensions.md)

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

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_EnumerateBaseTypes_System_Type_"></a> EnumerateBaseTypes\(Type\)

Return every base type until (and excluding) <xref href="System.Object" data-throw-if-not-resolved="false"></xref>

```csharp
public static IEnumerable<Type> EnumerateBaseTypes(this Type t)
```

#### Parameters

`t` [Type](https://learn.microsoft.com/dotnet/api/system.type)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Type](https://learn.microsoft.com/dotnet/api/system.type)\>

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_GetAccessModifier_System_Reflection_FieldInfo_"></a> GetAccessModifier\(FieldInfo\)

```csharp
public static AccessModifier GetAccessModifier(this FieldInfo field)
```

#### Parameters

`field` [FieldInfo](https://learn.microsoft.com/dotnet/api/system.reflection.fieldinfo)

#### Returns

 [AccessModifier](osu.Framework.Extensions.TypeExtensions.AccessModifier.md)

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_GetAccessModifier_System_Reflection_MethodInfo_"></a> GetAccessModifier\(MethodInfo\)

```csharp
public static AccessModifier GetAccessModifier(this MethodInfo method)
```

#### Parameters

`method` [MethodInfo](https://learn.microsoft.com/dotnet/api/system.reflection.methodinfo)

#### Returns

 [AccessModifier](osu.Framework.Extensions.TypeExtensions.AccessModifier.md)

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_GetUnderlyingNullableType_System_Type_"></a> GetUnderlyingNullableType\(Type\)

Gets the underlying type of a <xref href="System.Nullable%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public static Type GetUnderlyingNullableType(this Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The potentially nullable type.

#### Returns

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

The underlying type, or null if one does not exist.

#### Remarks

This method is cached.

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_IsNullable_System_Type_"></a> IsNullable\(Type\)

Determines whether the specified type is a <xref href="System.Nullable%601" data-throw-if-not-resolved="false"></xref> type.
<p>
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/nullable-types/how-to-identify-a-nullable-type
</p>

```csharp
public static bool IsNullable(this Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

When nullable reference types are enabled, prefer to use one of:
<xref href="osu.Framework.Extensions.TypeExtensions.TypeExtensions.IsNullable(System.Reflection.EventInfo)" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Extensions.TypeExtensions.TypeExtensions.IsNullable(System.Reflection.PropertyInfo)" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Extensions.TypeExtensions.TypeExtensions.IsNullable(System.Reflection.FieldInfo)" data-throw-if-not-resolved="false"></xref>, or <xref href="osu.Framework.Extensions.TypeExtensions.TypeExtensions.IsNullable(System.Reflection.ParameterInfo)" data-throw-if-not-resolved="false"></xref>,
in order to properly handle events/properties/fields/parameters.

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_IsNullable_System_Reflection_EventInfo_"></a> IsNullable\(EventInfo\)

Determines whether the type of an event is nullable.

```csharp
public static bool IsNullable(this EventInfo eventInfo)
```

#### Parameters

`eventInfo` [EventInfo](https://learn.microsoft.com/dotnet/api/system.reflection.eventinfo)

The event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the event type is nullable.

#### Remarks

Will be <code>false</code> for reference types if nullable reference types are not enabled.

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_IsNullable_System_Reflection_ParameterInfo_"></a> IsNullable\(ParameterInfo\)

Determines whether the type of a parameter is nullable.

```csharp
public static bool IsNullable(this ParameterInfo parameterInfo)
```

#### Parameters

`parameterInfo` [ParameterInfo](https://learn.microsoft.com/dotnet/api/system.reflection.parameterinfo)

The parameter.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the parameter type is nullable.

#### Remarks

Will be <code>false</code> for reference types if nullable reference types are not enabled.

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_IsNullable_System_Reflection_FieldInfo_"></a> IsNullable\(FieldInfo\)

Determines whether the type of a field is nullable.

```csharp
public static bool IsNullable(this FieldInfo fieldInfo)
```

#### Parameters

`fieldInfo` [FieldInfo](https://learn.microsoft.com/dotnet/api/system.reflection.fieldinfo)

The field.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the field type is nullable.

#### Remarks

Will be <code>false</code> for reference types if nullable reference types are not enabled.

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_IsNullable_System_Reflection_PropertyInfo_"></a> IsNullable\(PropertyInfo\)

Determines whether the type of a property is nullable.

```csharp
public static bool IsNullable(this PropertyInfo propertyInfo)
```

#### Parameters

`propertyInfo` [PropertyInfo](https://learn.microsoft.com/dotnet/api/system.reflection.propertyinfo)

The property.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the property type is nullable.

#### Remarks

Will be <code>false</code> for reference types if nullable reference types are not enabled.

### <a id="osu_Framework_Extensions_TypeExtensions_TypeExtensions_ReadableName_System_Type_"></a> ReadableName\(Type\)

```csharp
public static string ReadableName(this Type t)
```

#### Parameters

`t` [Type](https://learn.microsoft.com/dotnet/api/system.type)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

