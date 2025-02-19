# <a id="osu_Framework_Testing_Input_ManualTextInputSource"></a> Class ManualTextInputSource

Namespace: [osu.Framework.Testing.Input](osu.Framework.Testing.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public class ManualTextInputSource : TextInputSource
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextInputSource](osu.Framework.Input.TextInputSource.md) ← 
[ManualTextInputSource](osu.Framework.Testing.Input.ManualTextInputSource.md)

#### Inherited Members

[TextInputSource.ImeActive](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_ImeActive), 
[TextInputSource.Activate\(TextInputProperties, RectangleF\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_Activate\_osu\_Framework\_Input\_TextInputProperties\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[TextInputSource.EnsureActivated\(TextInputProperties, RectangleF?\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_EnsureActivated\_osu\_Framework\_Input\_TextInputProperties\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[TextInputSource.Deactivate\(\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_Deactivate), 
[TextInputSource.SetImeRectangle\(RectangleF\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_SetImeRectangle\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[TextInputSource.ResetIme\(\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_ResetIme), 
[TextInputSource.OnTextInput](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_OnTextInput), 
[TextInputSource.OnImeComposition](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_OnImeComposition), 
[TextInputSource.OnImeResult](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_OnImeResult), 
[TextInputSource.ActivateTextInput\(TextInputProperties\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_ActivateTextInput\_osu\_Framework\_Input\_TextInputProperties\_), 
[TextInputSource.EnsureTextInputActivated\(TextInputProperties\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_EnsureTextInputActivated\_osu\_Framework\_Input\_TextInputProperties\_), 
[TextInputSource.DeactivateTextInput\(\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_DeactivateTextInput), 
[TextInputSource.TriggerTextInput\(string\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_TriggerTextInput\_System\_String\_), 
[TextInputSource.TriggerImeComposition\(string, int, int\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_TriggerImeComposition\_System\_String\_System\_Int32\_System\_Int32\_), 
[TextInputSource.TriggerImeResult\(string\)](osu.Framework.Input.TextInputSource.md\#osu\_Framework\_Input\_TextInputSource\_TriggerImeResult\_System\_String\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ManualTextInputSource\>\(ManualTextInputSource?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ManualTextInputSource\>\(ManualTextInputSource\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ManualTextInputSource\>\(ManualTextInputSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ManualTextInputSource\>\(ManualTextInputSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ManualTextInputSource, TChild\>\(ManualTextInputSource, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ManualTextInputSource, TChild\>\(ManualTextInputSource, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ManualTextInputSource, TChild\>\(ManualTextInputSource, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ManualTextInputSource\>\(ManualTextInputSource\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_ActivationQueue"></a> ActivationQueue

```csharp
public readonly Queue<TextInputProperties> ActivationQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TextInputProperties](osu.Framework.Input.TextInputProperties.md)\>

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_DeactivationQueue"></a> DeactivationQueue

```csharp
public readonly Queue<bool> DeactivationQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_EnsureActivatedQueue"></a> EnsureActivatedQueue

```csharp
public readonly Queue<TextInputProperties> EnsureActivatedQueue
```

#### Field Value

 [Queue](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue\-1)<[TextInputProperties](osu.Framework.Input.TextInputProperties.md)\>

## Methods

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_ActivateTextInput_osu_Framework_Input_TextInputProperties_"></a> ActivateTextInput\(TextInputProperties\)

Activates the native implementation that provides text input.
Should be overriden per-platform.

```csharp
protected override void ActivateTextInput(TextInputProperties properties)
```

#### Parameters

`properties` [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

A set of properties to consider during this text input session.

#### Remarks

An active native implementation should call <xref href="osu.Framework.Input.TextInputSource.TriggerTextInput(System.String)" data-throw-if-not-resolved="false"></xref> on new text input
and forward IME composition events through <xref href="osu.Framework.Input.TextInputSource.TriggerImeComposition(System.String%2cSystem.Int32%2cSystem.Int32)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Input.TextInputSource.TriggerImeResult(System.String)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_DeactivateTextInput"></a> DeactivateTextInput\(\)

Deactivates the native implementation that provides text input.
Should be overriden per-platform.

```csharp
protected override void DeactivateTextInput()
```

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_EnsureTextInputActivated_osu_Framework_Input_TextInputProperties_"></a> EnsureTextInputActivated\(TextInputProperties\)

Ensures that the native implementation that retrieves user text input is activated
and that the user can start entering text.

```csharp
protected override void EnsureTextInputActivated(TextInputProperties properties)
```

#### Parameters

`properties` [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

A set of properties to consider during this text input session.

#### Remarks

Only called if the native implementation has been activated with <xref href="osu.Framework.Input.TextInputSource.Activate(osu.Framework.Input.TextInputProperties%2cosu.Framework.Graphics.Primitives.RectangleF)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_ResetIme"></a> ResetIme\(\)

Resets IME.
This clears the current composition string and prepares it for new input.

```csharp
public override void ResetIme()
```

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_Text_System_String_"></a> Text\(string\)

```csharp
public void Text(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_TriggerImeComposition_System_String_System_Int32_System_Int32_"></a> TriggerImeComposition\(string, int, int\)

```csharp
public void TriggerImeComposition(string text, int start, int length)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`start` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Testing_Input_ManualTextInputSource_TriggerImeResult_System_String_"></a> TriggerImeResult\(string\)

```csharp
public void TriggerImeResult(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

