# <a id="osu_Framework_Input_StateChanges_ButtonInputEntry_1"></a> Struct ButtonInputEntry<TButton\>

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

Denotes a button state.

```csharp
public struct ButtonInputEntry<TButton> where TButton : struct
```

#### Type Parameters

`TButton` 

Type of button.

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ButtonInputEntry<TButton\>\>\(ButtonInputEntry<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ButtonInputEntry<TButton\>\>\(ButtonInputEntry<TButton\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ButtonInputEntry<TButton\>\>\(ButtonInputEntry<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ButtonInputEntry<TButton\>\>\(ButtonInputEntry<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ButtonInputEntry<TButton\>, TChild\>\(ButtonInputEntry<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ButtonInputEntry<TButton\>, TChild\>\(ButtonInputEntry<TButton\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ButtonInputEntry<TButton\>, TChild\>\(ButtonInputEntry<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ButtonInputEntry<TButton\>\>\(ButtonInputEntry<TButton\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_ButtonInputEntry_1__ctor__0_System_Boolean_"></a> ButtonInputEntry\(TButton, bool\)

```csharp
public ButtonInputEntry(TButton button, bool isPressed)
```

#### Parameters

`button` TButton

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="osu_Framework_Input_StateChanges_ButtonInputEntry_1_Button"></a> Button

The button referred to.

```csharp
public TButton Button
```

#### Field Value

 TButton

### <a id="osu_Framework_Input_StateChanges_ButtonInputEntry_1_IsPressed"></a> IsPressed

Whether <xref href="osu.Framework.Input.StateChanges.ButtonInputEntry%601.Button" data-throw-if-not-resolved="false"></xref> is currently pressed or not.

```csharp
public bool IsPressed
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

