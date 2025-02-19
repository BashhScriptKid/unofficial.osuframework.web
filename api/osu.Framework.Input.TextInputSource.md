# <a id="osu_Framework_Input_TextInputSource"></a> Class TextInputSource

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

A source from which we can retrieve user text input.
Generally hides a native implementation from the game framework.

```csharp
public class TextInputSource
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextInputSource](osu.Framework.Input.TextInputSource.md)

#### Derived

[ManualTextInputSource](osu.Framework.Testing.Input.ManualTextInputSource.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextInputSource\>\(TextInputSource?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextInputSource\>\(TextInputSource\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextInputSource\>\(TextInputSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextInputSource\>\(TextInputSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextInputSource, TChild\>\(TextInputSource, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextInputSource, TChild\>\(TextInputSource, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextInputSource, TChild\>\(TextInputSource, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextInputSource\>\(TextInputSource\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_TextInputSource_ImeActive"></a> ImeActive

Whether IME is actively providing text composition through <xref href="osu.Framework.Input.TextInputSource.OnImeComposition" data-throw-if-not-resolved="false"></xref> and accepting input from the user.

```csharp
public bool ImeActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Input_TextInputSource_Activate_osu_Framework_Input_TextInputProperties_osu_Framework_Graphics_Primitives_RectangleF_"></a> Activate\(TextInputProperties, RectangleF\)

Activates this <xref href="osu.Framework.Input.TextInputSource" data-throw-if-not-resolved="false"></xref>.
User text input can be acquired through <xref href="osu.Framework.Input.TextInputSource.OnTextInput" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Input.TextInputSource.OnImeComposition" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Input.TextInputSource.OnImeResult" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Activate(TextInputProperties properties, RectangleF imeRectangle)
```

#### Parameters

`properties` [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

A set of properties to consider during this text input session.

`imeRectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

Rough location of where the text will be input, so the native implementation
can adjust virtual keyboards and IME popups.

#### Remarks

Each <xref href="osu.Framework.Input.TextInputSource.Activate(osu.Framework.Input.TextInputProperties%2cosu.Framework.Graphics.Primitives.RectangleF)" data-throw-if-not-resolved="false"></xref> must be followed by a <xref href="osu.Framework.Input.TextInputSource.Deactivate" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_TextInputSource_ActivateTextInput_osu_Framework_Input_TextInputProperties_"></a> ActivateTextInput\(TextInputProperties\)

Activates the native implementation that provides text input.
Should be overriden per-platform.

```csharp
protected virtual void ActivateTextInput(TextInputProperties properties)
```

#### Parameters

`properties` [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

A set of properties to consider during this text input session.

#### Remarks

An active native implementation should call <xref href="osu.Framework.Input.TextInputSource.TriggerTextInput(System.String)" data-throw-if-not-resolved="false"></xref> on new text input
and forward IME composition events through <xref href="osu.Framework.Input.TextInputSource.TriggerImeComposition(System.String%2cSystem.Int32%2cSystem.Int32)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Input.TextInputSource.TriggerImeResult(System.String)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_TextInputSource_Deactivate"></a> Deactivate\(\)

Deactivates this <xref href="osu.Framework.Input.TextInputSource" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Deactivate()
```

#### Remarks

Should be called once text input is no longer needed.
Each <xref href="osu.Framework.Input.TextInputSource.Deactivate" data-throw-if-not-resolved="false"></xref> must be preceded by an <xref href="osu.Framework.Input.TextInputSource.Activate(osu.Framework.Input.TextInputProperties%2cosu.Framework.Graphics.Primitives.RectangleF)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_TextInputSource_DeactivateTextInput"></a> DeactivateTextInput\(\)

Deactivates the native implementation that provides text input.
Should be overriden per-platform.

```csharp
protected virtual void DeactivateTextInput()
```

### <a id="osu_Framework_Input_TextInputSource_EnsureActivated_osu_Framework_Input_TextInputProperties_System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__"></a> EnsureActivated\(TextInputProperties, RectangleF?\)

Ensures that the native implementation that retrieves user text input is activated
and that the user can start entering text.

```csharp
public void EnsureActivated(TextInputProperties properties, RectangleF? imeRectangle = null)
```

#### Parameters

`properties` [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

A set of properties to consider during this text input session.

`imeRectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

Rough location of where the text will be input, so the native implementation
can adjust virtual keyboards and IME popups. Can be <code>null</code> to avoid changing
the IME rectangle.

### <a id="osu_Framework_Input_TextInputSource_EnsureTextInputActivated_osu_Framework_Input_TextInputProperties_"></a> EnsureTextInputActivated\(TextInputProperties\)

Ensures that the native implementation that retrieves user text input is activated
and that the user can start entering text.

```csharp
protected virtual void EnsureTextInputActivated(TextInputProperties properties)
```

#### Parameters

`properties` [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

A set of properties to consider during this text input session.

#### Remarks

Only called if the native implementation has been activated with <xref href="osu.Framework.Input.TextInputSource.Activate(osu.Framework.Input.TextInputProperties%2cosu.Framework.Graphics.Primitives.RectangleF)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_TextInputSource_ResetIme"></a> ResetIme\(\)

Resets IME.
This clears the current composition string and prepares it for new input.

```csharp
public virtual void ResetIme()
```

### <a id="osu_Framework_Input_TextInputSource_SetImeRectangle_osu_Framework_Graphics_Primitives_RectangleF_"></a> SetImeRectangle\(RectangleF\)

Sets where the native implementation displays IME controls and other text input elements.

```csharp
public virtual void SetImeRectangle(RectangleF rectangle)
```

#### Parameters

`rectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

Should be provided in screen space.

### <a id="osu_Framework_Input_TextInputSource_TriggerImeComposition_System_String_System_Int32_System_Int32_"></a> TriggerImeComposition\(string, int, int\)

```csharp
protected void TriggerImeComposition(string text, int start, int length)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`start` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Input_TextInputSource_TriggerImeResult_System_String_"></a> TriggerImeResult\(string\)

```csharp
protected void TriggerImeResult(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Input_TextInputSource_TriggerTextInput_System_String_"></a> TriggerTextInput\(string\)

```csharp
protected void TriggerTextInput(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Input_TextInputSource_OnImeComposition"></a> OnImeComposition

Invoked when IME composition starts or changes.

```csharp
public event TextInputSource.ImeCompositionDelegate? OnImeComposition
```

#### Event Type

 [TextInputSource](osu.Framework.Input.TextInputSource.md).[ImeCompositionDelegate](osu.Framework.Input.TextInputSource.ImeCompositionDelegate.md)?

#### Remarks

Empty string for text means that the composition has been cancelled.

### <a id="osu_Framework_Input_TextInputSource_OnImeResult"></a> OnImeResult

Invoked when IME composition successfully completes.

```csharp
public event Action<string>? OnImeResult
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>?

### <a id="osu_Framework_Input_TextInputSource_OnTextInput"></a> OnTextInput

Invoked on text input.

```csharp
public event Action<string>? OnTextInput
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>?

