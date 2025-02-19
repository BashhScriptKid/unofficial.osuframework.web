# <a id="osu_Framework_Input_TextInputSource_ImeCompositionDelegate"></a> Delegate TextInputSource.ImeCompositionDelegate

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

Fired on a new IME composition.

```csharp
public delegate void TextInputSource.ImeCompositionDelegate(string text, int start, int length)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

The composition text.

`start` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the selection start.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The length of the selection.

#### Extension Methods

[ObjectExtensions.AsNonNull<TextInputSource.ImeCompositionDelegate\>\(TextInputSource.ImeCompositionDelegate?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextInputSource.ImeCompositionDelegate\>\(TextInputSource.ImeCompositionDelegate\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextInputSource.ImeCompositionDelegate\>\(TextInputSource.ImeCompositionDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextInputSource.ImeCompositionDelegate\>\(TextInputSource.ImeCompositionDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextInputSource.ImeCompositionDelegate, TChild\>\(TextInputSource.ImeCompositionDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextInputSource.ImeCompositionDelegate, TChild\>\(TextInputSource.ImeCompositionDelegate, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextInputSource.ImeCompositionDelegate, TChild\>\(TextInputSource.ImeCompositionDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextInputSource.ImeCompositionDelegate\>\(TextInputSource.ImeCompositionDelegate\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

Empty string for <code class="paramref">text</code> means that the composition has been cancelled.

