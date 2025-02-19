# <a id="osu_Framework_Text_ICharacterGlyph"></a> Interface ICharacterGlyph

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

Interface for an object that contains associated spacing information for a character.

```csharp
public interface ICharacterGlyph
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ICharacterGlyph\>\(ICharacterGlyph?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ICharacterGlyph\>\(ICharacterGlyph\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ICharacterGlyph\>\(ICharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ICharacterGlyph\>\(ICharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ICharacterGlyph, TChild\>\(ICharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ICharacterGlyph, TChild\>\(ICharacterGlyph, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ICharacterGlyph, TChild\>\(ICharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ICharacterGlyph\>\(ICharacterGlyph\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Text_ICharacterGlyph_Baseline"></a> Baseline

The position of the baseline in this glyph.

```csharp
float Baseline { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_ICharacterGlyph_Character"></a> Character

The character represented by this glyph.

```csharp
char Character { get; }
```

#### Property Value

 [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="osu_Framework_Text_ICharacterGlyph_XAdvance"></a> XAdvance

How much the current x-position should be moved after drawing a character.

```csharp
float XAdvance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_ICharacterGlyph_XOffset"></a> XOffset

How much the current x-position should be moved for drawing. This should not adjust the cursor position.

```csharp
float XOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_ICharacterGlyph_YOffset"></a> YOffset

How much the current y-position should be moved for drawing. This should not adjust the cursor position.

```csharp
float YOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Text_ICharacterGlyph_GetKerning__1___0_"></a> GetKerning<T\>\(T\)

Retrieves the kerning between this <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> and the one prior to it.

```csharp
float GetKerning<T>(T lastGlyph) where T : ICharacterGlyph
```

#### Parameters

`lastGlyph` T

The <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> prior to this one.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Type Parameters

`T` 

