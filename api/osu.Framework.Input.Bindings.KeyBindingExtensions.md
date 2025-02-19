# <a id="osu_Framework_Input_Bindings_KeyBindingExtensions"></a> Class KeyBindingExtensions

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

```csharp
public static class KeyBindingExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[KeyBindingExtensions](osu.Framework.Input.Bindings.KeyBindingExtensions.md)

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

### <a id="osu_Framework_Input_Bindings_KeyBindingExtensions_GetAction__1_osu_Framework_Input_Bindings_IKeyBinding_"></a> GetAction<T\>\(IKeyBinding\)

Get the action associated with this binding, cast to the required enum type.

```csharp
public static T GetAction<T>(this IKeyBinding obj) where T : struct
```

#### Parameters

`obj` [IKeyBinding](osu.Framework.Input.Bindings.IKeyBinding.md)

#### Returns

 T

A cast <code class="typeparamref">T</code> representation of <xref href="osu.Framework.Input.Bindings.KeyBinding.Action" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The enum type.

