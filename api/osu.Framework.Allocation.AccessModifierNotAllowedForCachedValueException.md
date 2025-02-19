# <a id="osu_Framework_Allocation_AccessModifierNotAllowedForCachedValueException"></a> Class AccessModifierNotAllowedForCachedValueException

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

Occurs when attempting to cache a non-private and non-readonly field with an attached <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref>.

```csharp
public class AccessModifierNotAllowedForCachedValueException : AccessModifierNotAllowedForMemberException, ISerializable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Exception](https://learn.microsoft.com/dotnet/api/system.exception) ← 
[SystemException](https://learn.microsoft.com/dotnet/api/system.systemexception) ← 
[InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception) ← 
[AccessModifierNotAllowedForMemberException](osu.Framework.Allocation.AccessModifierNotAllowedForMemberException.md) ← 
[AccessModifierNotAllowedForCachedValueException](osu.Framework.Allocation.AccessModifierNotAllowedForCachedValueException.md)

#### Implements

[ISerializable](https://learn.microsoft.com/dotnet/api/system.runtime.serialization.iserializable)

#### Inherited Members

[Exception.GetBaseException\(\)](https://learn.microsoft.com/dotnet/api/system.exception.getbaseexception), 
[Exception.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.exception.gettype), 
[Exception.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.exception.tostring), 
[Exception.Data](https://learn.microsoft.com/dotnet/api/system.exception.data), 
[Exception.HelpLink](https://learn.microsoft.com/dotnet/api/system.exception.helplink), 
[Exception.HResult](https://learn.microsoft.com/dotnet/api/system.exception.hresult), 
[Exception.InnerException](https://learn.microsoft.com/dotnet/api/system.exception.innerexception), 
[Exception.Message](https://learn.microsoft.com/dotnet/api/system.exception.message), 
[Exception.Source](https://learn.microsoft.com/dotnet/api/system.exception.source), 
[Exception.StackTrace](https://learn.microsoft.com/dotnet/api/system.exception.stacktrace), 
[Exception.TargetSite](https://learn.microsoft.com/dotnet/api/system.exception.targetsite), 
[Exception.SerializeObjectState](https://learn.microsoft.com/dotnet/api/system.exception.serializeobjectstate), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AccessModifierNotAllowedForCachedValueException\>\(AccessModifierNotAllowedForCachedValueException?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AccessModifierNotAllowedForCachedValueException\>\(AccessModifierNotAllowedForCachedValueException\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AccessModifierNotAllowedForCachedValueException\>\(AccessModifierNotAllowedForCachedValueException\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AccessModifierNotAllowedForCachedValueException\>\(AccessModifierNotAllowedForCachedValueException\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ExceptionExtensions.Rethrow\(Exception\)](osu.Framework.Extensions.ExceptionExtensions.ExceptionExtensions.md\#osu\_Framework\_Extensions\_ExceptionExtensions\_ExceptionExtensions\_Rethrow\_System\_Exception\_), 
[ContainerExtensions.WithChild<AccessModifierNotAllowedForCachedValueException, TChild\>\(AccessModifierNotAllowedForCachedValueException, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AccessModifierNotAllowedForCachedValueException, TChild\>\(AccessModifierNotAllowedForCachedValueException, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AccessModifierNotAllowedForCachedValueException, TChild\>\(AccessModifierNotAllowedForCachedValueException, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AccessModifierNotAllowedForCachedValueException\>\(AccessModifierNotAllowedForCachedValueException\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Allocation_AccessModifierNotAllowedForCachedValueException__ctor_osu_Framework_Extensions_TypeExtensions_AccessModifier_System_Reflection_MemberInfo_"></a> AccessModifierNotAllowedForCachedValueException\(AccessModifier, MemberInfo\)

```csharp
public AccessModifierNotAllowedForCachedValueException(AccessModifier modifier, MemberInfo member)
```

#### Parameters

`modifier` [AccessModifier](osu.Framework.Extensions.TypeExtensions.AccessModifier.md)

`member` [MemberInfo](https://learn.microsoft.com/dotnet/api/system.reflection.memberinfo)

