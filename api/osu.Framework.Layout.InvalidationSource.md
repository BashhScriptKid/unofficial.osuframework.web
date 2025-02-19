# <a id="osu_Framework_Layout_InvalidationSource"></a> Enum InvalidationSource

Namespace: [osu.Framework.Layout](osu.Framework.Layout.md)  
Assembly: osu.Framework.dll  

Indicates the source of an invalidation of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
[Flags]
public enum InvalidationSource
```

#### Extension Methods

[ObjectExtensions.AsNonNull<InvalidationSource\>\(InvalidationSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InvalidationSource\>\(InvalidationSource\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<InvalidationSource\>\(InvalidationSource, InvalidationSource\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InvalidationSource\>\(InvalidationSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InvalidationSource\>\(InvalidationSource\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<InvalidationSource, TChild\>\(InvalidationSource, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InvalidationSource, TChild\>\(InvalidationSource, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InvalidationSource, TChild\>\(InvalidationSource, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InvalidationSource\>\(InvalidationSource\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Child = 4` 

The invalidation originates from a child in the subtree of the current <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.



`Default = 3` 

The default invalidation source. Deconstructs into <xref href="osu.Framework.Layout.InvalidationSource.Self" data-throw-if-not-resolved="false"></xref><pre><code class="lang-csharp">or</code></pre><xref href="osu.Framework.Layout.InvalidationSource.Parent" data-throw-if-not-resolved="false"></xref>.



`Parent = 2` 

The invalidation originates from a parent in the supertree of the current <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.



`Self = 1` 

The invalidation originates from the current <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.



