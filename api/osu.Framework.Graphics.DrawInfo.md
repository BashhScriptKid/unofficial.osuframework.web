# <a id="osu_Framework_Graphics_DrawInfo"></a> Struct DrawInfo

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public struct DrawInfo : IEquatable<DrawInfo>
```

#### Implements

[IEquatable<DrawInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DrawInfo\>\(DrawInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DrawInfo\>\(DrawInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DrawInfo\>\(DrawInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DrawInfo\>\(DrawInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DrawInfo, TChild\>\(DrawInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DrawInfo, TChild\>\(DrawInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DrawInfo, TChild\>\(DrawInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DrawInfo\>\(DrawInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_DrawInfo__ctor_System_Nullable_osuTK_Matrix3__System_Nullable_osuTK_Matrix3__"></a> DrawInfo\(Matrix3?, Matrix3?\)

```csharp
public DrawInfo(Matrix3? matrix = null, Matrix3? matrixInverse = null)
```

#### Parameters

`matrix` Matrix3?

`matrixInverse` Matrix3?

## Fields

### <a id="osu_Framework_Graphics_DrawInfo_Matrix"></a> Matrix

```csharp
public Matrix3 Matrix
```

#### Field Value

 Matrix3

### <a id="osu_Framework_Graphics_DrawInfo_MatrixInverse"></a> MatrixInverse

```csharp
public Matrix3 MatrixInverse
```

#### Field Value

 Matrix3

## Methods

### <a id="osu_Framework_Graphics_DrawInfo_ApplyTransform_osuTK_Vector2_osuTK_Vector2_System_Single_osuTK_Vector2_osuTK_Vector2_"></a> ApplyTransform\(Vector2, Vector2, float, Vector2, Vector2\)

Applies a transformation to the current DrawInfo.

```csharp
public void ApplyTransform(Vector2 translation, Vector2 scale, float rotation, Vector2 shear, Vector2 origin)
```

#### Parameters

`translation` Vector2

The amount by which to translate the current position.

`scale` Vector2

The amount by which to scale.

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount by which to rotate.

`shear` Vector2

The shear amounts for both directions.

`origin` Vector2

The center of rotation and scale.

### <a id="osu_Framework_Graphics_DrawInfo_Equals_osu_Framework_Graphics_DrawInfo_"></a> Equals\(DrawInfo\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(DrawInfo other)
```

#### Parameters

`other` [DrawInfo](osu.Framework.Graphics.DrawInfo.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_DrawInfo_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

