# <a id="osu_Framework_Graphics_Textures"></a> Namespace osu.Framework.Graphics.Textures

### Classes

 [ArrayPoolTextureUpload](osu.Framework.Graphics.Textures.ArrayPoolTextureUpload.md)

 [DisposableTexture](osu.Framework.Graphics.Textures.DisposableTexture.md)

A texture which can cleans up any resources held by the underlying <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref> on <xref href="osu.Framework.Graphics.Textures.DisposableTexture.Dispose(System.Boolean)" data-throw-if-not-resolved="false"></xref>.

 [LargeTextureStore](osu.Framework.Graphics.Textures.LargeTextureStore.md)

A texture store that bypasses atlasing and removes textures from memory after dereferenced by all consumers.

 [MemoryAllocatorTextureUpload](osu.Framework.Graphics.Textures.MemoryAllocatorTextureUpload.md)

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

 [TextureAtlas](osu.Framework.Graphics.Textures.TextureAtlas.md)

 [TextureLoaderStore](osu.Framework.Graphics.Textures.TextureLoaderStore.md)

Handles the parsing of image data from standard image formats into <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref>s ready for GPU consumption.

 [TextureRegion](osu.Framework.Graphics.Textures.TextureRegion.md)

A sub-region of a <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

 [TextureStore](osu.Framework.Graphics.Textures.TextureStore.md)

Provides drawable-ready <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>s sourced from any number of provided sources (via constructor parameter or <xref href="osu.Framework.Graphics.Textures.TextureStore.AddTextureSource(osu.Framework.IO.Stores.IResourceStore%7bosu.Framework.Graphics.Textures.TextureUpload%7d)" data-throw-if-not-resolved="false"></xref>).

 [TextureTooLargeForGLException](osu.Framework.Graphics.Textures.TextureTooLargeForGLException.md)

 [TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

Low level class for queueing texture uploads to the GPU.
Should be manually disposed if not queued for upload via <xref href="osu.Framework.Graphics.Textures.Texture.SetData(osu.Framework.Graphics.Textures.ITextureUpload)" data-throw-if-not-resolved="false"></xref>.

### Interfaces

 [ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md)

Provides drawable-ready <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>s.

 [ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md)

### Enums

 [Opacity](osu.Framework.Graphics.Textures.Opacity.md)

 [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

