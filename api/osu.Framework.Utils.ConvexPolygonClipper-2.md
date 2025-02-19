# <a id="osu_Framework_Utils_ConvexPolygonClipper_2"></a> Struct ConvexPolygonClipper<TClip, TSubject\>

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly ref struct ConvexPolygonClipper<TClip, TSubject> where TClip : IConvexPolygon where TSubject : IConvexPolygon
```

#### Type Parameters

`TClip` 

`TSubject` 

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="osu_Framework_Utils_ConvexPolygonClipper_2__ctor__0___1__"></a> ConvexPolygonClipper\(ref TClip, ref TSubject\)

```csharp
public ConvexPolygonClipper(ref TClip clipPolygon, ref TSubject subjectPolygon)
```

#### Parameters

`clipPolygon` TClip

`subjectPolygon` TSubject

### <a id="osu_Framework_Utils_ConvexPolygonClipper_2__ctor__0__1_"></a> ConvexPolygonClipper\(TClip, TSubject\)

```csharp
public ConvexPolygonClipper(TClip clipPolygon, TSubject subjectPolygon)
```

#### Parameters

`clipPolygon` TClip

`subjectPolygon` TSubject

## Methods

### <a id="osu_Framework_Utils_ConvexPolygonClipper_2_Clip"></a> Clip\(\)

Clips <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.subjectPolygon" data-throw-if-not-resolved="false"></xref> by <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.clipPolygon" data-throw-if-not-resolved="false"></xref>.

```csharp
public Span<Vector2> Clip()
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Vector2\>

A clockwise-ordered set of vertices representing the result of clipping <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.subjectPolygon" data-throw-if-not-resolved="false"></xref> by <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.clipPolygon" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Utils_ConvexPolygonClipper_2_Clip_System_Span_osuTK_Vector2__"></a> Clip\(Span<Vector2\>\)

Clips <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.subjectPolygon" data-throw-if-not-resolved="false"></xref> by <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.clipPolygon" data-throw-if-not-resolved="false"></xref> using an intermediate buffer.

```csharp
public Span<Vector2> Clip(Span<Vector2> buffer)
```

#### Parameters

`buffer` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Vector2\>

The buffer to contain the clipped vertices. Must have a length of <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.GetClipBufferSize" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Vector2\>

A clockwise-ordered set of vertices representing the result of clipping <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.subjectPolygon" data-throw-if-not-resolved="false"></xref> by <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.clipPolygon" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Utils_ConvexPolygonClipper_2_GetClipBufferSize"></a> GetClipBufferSize\(\)

Determines the minimum buffer size required to clip the two polygons.

```csharp
public int GetClipBufferSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The minimum buffer size required for <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.clipPolygon" data-throw-if-not-resolved="false"></xref> to clip <xref href="osu.Framework.Utils.ConvexPolygonClipper%602.subjectPolygon" data-throw-if-not-resolved="false"></xref>.

