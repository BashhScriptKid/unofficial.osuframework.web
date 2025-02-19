# <a id="osu_Framework_Extensions_PlatformActionExtensions_PlatformActionExtensions"></a> Class PlatformActionExtensions

Namespace: [osu.Framework.Extensions.PlatformActionExtensions](osu.Framework.Extensions.PlatformActionExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class PlatformActionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PlatformActionExtensions](osu.Framework.Extensions.PlatformActionExtensions.PlatformActionExtensions.md)

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

### <a id="osu_Framework_Extensions_PlatformActionExtensions_PlatformActionExtensions_IsCommonTextEditingAction_osu_Framework_Input_PlatformAction_"></a> IsCommonTextEditingAction\(PlatformAction\)

Returns <code>true</code> if this <code class="paramref">platformAction</code> is a common text editing <xref href="osu.Framework.Input.PlatformAction" data-throw-if-not-resolved="false"></xref>.

```csharp
public static bool IsCommonTextEditingAction(this PlatformAction platformAction)
```

#### Parameters

`platformAction` [PlatformAction](osu.Framework.Input.PlatformAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

Common text editing actions are those used for text editing in a text box,
and/or are used by an platform-native IME for internal text editing purposes.

