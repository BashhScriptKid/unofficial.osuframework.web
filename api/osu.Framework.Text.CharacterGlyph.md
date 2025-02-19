# <a id="osu_Framework_Text_CharacterGlyph"></a> Class CharacterGlyph

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class CharacterGlyph : ICharacterGlyph
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CharacterGlyph](osu.Framework.Text.CharacterGlyph.md)

#### Implements

[ICharacterGlyph](osu.Framework.Text.ICharacterGlyph.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CharacterGlyph\>\(CharacterGlyph?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CharacterGlyph\>\(CharacterGlyph\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CharacterGlyph\>\(CharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CharacterGlyph\>\(CharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CharacterGlyph, TChild\>\(CharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CharacterGlyph, TChild\>\(CharacterGlyph, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CharacterGlyph, TChild\>\(CharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CharacterGlyph\>\(CharacterGlyph\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Text_CharacterGlyph__ctor_System_Char_System_Single_System_Single_System_Single_System_Single_osu_Framework_IO_Stores_IGlyphStore_"></a> CharacterGlyph\(char, float, float, float, float, IGlyphStore\)

```csharp
public CharacterGlyph(char character, float xOffset, float yOffset, float xAdvance, float baseline, IGlyphStore containingStore)
```

#### Parameters

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

`xOffset` [float](https://learn.microsoft.com/dotnet/api/system.single)

`yOffset` [float](https://learn.microsoft.com/dotnet/api/system.single)

`xAdvance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`baseline` [float](https://learn.microsoft.com/dotnet/api/system.single)

`containingStore` [IGlyphStore](osu.Framework.IO.Stores.IGlyphStore.md)

## Properties

### <a id="osu_Framework_Text_CharacterGlyph_Baseline"></a> Baseline

The position of the baseline in this glyph.

```csharp
public float Baseline { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_CharacterGlyph_Character"></a> Character

The character represented by this glyph.

```csharp
public char Character { get; }
```

#### Property Value

 [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="osu_Framework_Text_CharacterGlyph_XAdvance"></a> XAdvance

How much the current x-position should be moved after drawing a character.

```csharp
public float XAdvance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_CharacterGlyph_XOffset"></a> XOffset

How much the current x-position should be moved for drawing. This should not adjust the cursor position.

```csharp
public float XOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_CharacterGlyph_YOffset"></a> YOffset

How much the current y-position should be moved for drawing. This should not adjust the cursor position.

```csharp
public float YOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Text_CharacterGlyph_GetKerning__1___0_"></a> GetKerning<T\>\(T\)

Retrieves the kerning between this <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> and the one prior to it.

```csharp
public float GetKerning<T>(T lastGlyph) where T : ICharacterGlyph
```

#### Parameters

`lastGlyph` T

The <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> prior to this one.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Type Parameters

`T` 

