# <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions"></a> Class MatrixExtensions

Namespace: [osu.Framework.Extensions.MatrixExtensions](osu.Framework.Extensions.MatrixExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class MatrixExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MatrixExtensions](osu.Framework.Extensions.MatrixExtensions.MatrixExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_FastInvert_osuTK_Matrix3__"></a> FastInvert\(ref Matrix3\)

```csharp
public static void FastInvert(ref Matrix3 value)
```

#### Parameters

`value` Matrix3

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_RotateFromLeft_osuTK_Matrix3__System_Single_"></a> RotateFromLeft\(ref Matrix3, float\)

```csharp
public static void RotateFromLeft(ref Matrix3 m, float radians)
```

#### Parameters

`m` Matrix3

`radians` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_RotateFromRight_osuTK_Matrix3__System_Single_"></a> RotateFromRight\(ref Matrix3, float\)

```csharp
public static void RotateFromRight(ref Matrix3 m, float radians)
```

#### Parameters

`m` Matrix3

`radians` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_ScaleFromLeft_osuTK_Matrix3__osuTK_Vector2_"></a> ScaleFromLeft\(ref Matrix3, Vector2\)

```csharp
public static void ScaleFromLeft(ref Matrix3 m, Vector2 v)
```

#### Parameters

`m` Matrix3

`v` Vector2

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_ScaleFromRight_osuTK_Matrix3__osuTK_Vector2_"></a> ScaleFromRight\(ref Matrix3, Vector2\)

```csharp
public static void ScaleFromRight(ref Matrix3 m, Vector2 v)
```

#### Parameters

`m` Matrix3

`v` Vector2

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_ShearFromLeft_osuTK_Matrix3__osuTK_Vector2_"></a> ShearFromLeft\(ref Matrix3, Vector2\)

Apply shearing in X and Y direction from the left hand side.
Since shearing is non-commutative it is important to note that we
first shear in the X direction, and then in the Y direction.

```csharp
public static void ShearFromLeft(ref Matrix3 m, Vector2 v)
```

#### Parameters

`m` Matrix3

The matrix to apply the shearing operation to.

`v` Vector2

The X and Y amounts of shearing.

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_ShearFromRight_osuTK_Matrix3__osuTK_Vector2_"></a> ShearFromRight\(ref Matrix3, Vector2\)

Apply shearing in X and Y direction from the right hand side.
Since shearing is non-commutative it is important to note that we
first shear in the Y direction, and then in the X direction.

```csharp
public static void ShearFromRight(ref Matrix3 m, Vector2 v)
```

#### Parameters

`m` Matrix3

The matrix to apply the shearing operation to.

`v` Vector2

The X and Y amounts of shearing.

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_TranslateFromLeft_osuTK_Matrix3__osuTK_Vector2_"></a> TranslateFromLeft\(ref Matrix3, Vector2\)

```csharp
public static void TranslateFromLeft(ref Matrix3 m, Vector2 v)
```

#### Parameters

`m` Matrix3

`v` Vector2

### <a id="osu_Framework_Extensions_MatrixExtensions_MatrixExtensions_TranslateFromRight_osuTK_Matrix3__osuTK_Vector2_"></a> TranslateFromRight\(ref Matrix3, Vector2\)

```csharp
public static void TranslateFromRight(ref Matrix3 m, Vector2 v)
```

#### Parameters

`m` Matrix3

`v` Vector2

