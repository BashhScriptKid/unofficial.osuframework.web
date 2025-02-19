# <a id="osu_Framework_Input_States_ButtonStates_1"></a> Class ButtonStates<TButton\>

Namespace: [osu.Framework.Input.States](osu.Framework.Input.States.md)  
Assembly: osu.Framework.dll  

Denotes multiple button states.

```csharp
public class ButtonStates<TButton> : IEnumerable<TButton>, IEnumerable where TButton : struct
```

#### Type Parameters

`TButton` 

The type of button.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonStates<TButton\>](osu.Framework.Input.States.ButtonStates\-1.md)

#### Implements

[IEnumerable<TButton\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ButtonStates<TButton\>\>\(ButtonStates<TButton\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<TButton\>\(IEnumerable<TButton\>, Action<TButton\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ButtonStates<TButton\>\>\(ButtonStates<TButton\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<TButton\>\(IEnumerable<TButton\>, TButton\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<TButton\>\(IEnumerable<TButton\>, TButton\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<TButton\>\(IEnumerable<TButton\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<ButtonStates<TButton\>\>\(ButtonStates<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ButtonStates<TButton\>\>\(ButtonStates<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ButtonStates<TButton\>, TChild\>\(ButtonStates<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ButtonStates<TButton\>, TChild\>\(ButtonStates<TButton\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ButtonStates<TButton\>, TChild\>\(ButtonStates<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ButtonStates<TButton\>\>\(ButtonStates<TButton\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_States_ButtonStates_1_HasAnyButtonPressed"></a> HasAnyButtonPressed

```csharp
public bool HasAnyButtonPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Input_States_ButtonStates_1_Add__0_"></a> Add\(TButton\)

```csharp
public void Add(TButton button)
```

#### Parameters

`button` TButton

### <a id="osu_Framework_Input_States_ButtonStates_1_Clone"></a> Clone\(\)

```csharp
public ButtonStates<TButton> Clone()
```

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>

### <a id="osu_Framework_Input_States_ButtonStates_1_EnumerateDifference_osu_Framework_Input_States_ButtonStates__0__"></a> EnumerateDifference\(ButtonStates<TButton\>\)

Enumerates the differences between ourselves and a previous <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public ButtonStates<TButton>.ButtonStateDifference EnumerateDifference(ButtonStates<TButton> lastButtons)
```

#### Parameters

`lastButtons` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>

The previous <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>.[ButtonStateDifference](osu.Framework.Input.States.ButtonStates\-1.ButtonStateDifference.md)

### <a id="osu_Framework_Input_States_ButtonStates_1_GetEnumerator"></a> GetEnumerator\(\)

Returns an enumerator that iterates through the collection.

```csharp
public IEnumerator<TButton> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<TButton\>

An enumerator that can be used to iterate through the collection.

### <a id="osu_Framework_Input_States_ButtonStates_1_IsPressed__0_"></a> IsPressed\(TButton\)

Finds whether a <code class="typeparamref">TButton</code> is currently pressed.

```csharp
public bool IsPressed(TButton button)
```

#### Parameters

`button` TButton

The <code class="typeparamref">TButton</code> to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_States_ButtonStates_1_Set_osu_Framework_Input_States_ButtonStates__0__"></a> Set\(ButtonStates<TButton\>\)

Copies the state of another <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> to ourselves.

```csharp
public void Set(ButtonStates<TButton> other)
```

#### Parameters

`other` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>

The <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> to copy.

### <a id="osu_Framework_Input_States_ButtonStates_1_SetPressed__0_System_Boolean_"></a> SetPressed\(TButton, bool\)

Sets the state of a <code class="typeparamref">TButton</code>.

```csharp
public bool SetPressed(TButton button, bool pressed)
```

#### Parameters

`button` TButton

The <code class="typeparamref">TButton</code> to set the state of.

`pressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">button</code> should be pressed.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the state of <code class="paramref">button</code> actually changed.

### <a id="osu_Framework_Input_States_ButtonStates_1_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

