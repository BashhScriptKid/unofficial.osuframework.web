# <a id="osu_Framework_Extensions_OSPlatformExtensions"></a> Class OSPlatformExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class OSPlatformExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OSPlatformExtensions](osu.Framework.Extensions.OSPlatformExtensions.md)

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

### <a id="osu_Framework_Extensions_OSPlatformExtensions_IsSupportedOnCurrentOSPlatform_System_Reflection_MemberInfo_"></a> IsSupportedOnCurrentOSPlatform\(MemberInfo\)

Checks whether this <xref href="System.Reflection.MemberInfo" data-throw-if-not-resolved="false"></xref> is supported on the current runtime platform as specified by
[SupportedOSPlatform] and [UnsupportedOSPlatform].

```csharp
public static bool IsSupportedOnCurrentOSPlatform(this MemberInfo member)
```

#### Parameters

`member` [MemberInfo](https://learn.microsoft.com/dotnet/api/system.reflection.memberinfo)

The <xref href="System.Reflection.MemberInfo" data-throw-if-not-resolved="false"></xref> to check the attributes of.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<code>true</code> if this <code class="paramref">member</code> is supported, false otherwise.

#### Remarks

This is only a naive check of attributes defined directly on this member, and doesn't account for the (un)supported platforms of the containing class or assembly.

