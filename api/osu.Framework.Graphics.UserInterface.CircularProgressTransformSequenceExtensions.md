# <a id="osu_Framework_Graphics_UserInterface_CircularProgressTransformSequenceExtensions"></a> Class CircularProgressTransformSequenceExtensions

Namespace: [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)  
Assembly: osu.Framework.dll  

```csharp
public static class CircularProgressTransformSequenceExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CircularProgressTransformSequenceExtensions](osu.Framework.Graphics.UserInterface.CircularProgressTransformSequenceExtensions.md)

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

### <a id="osu_Framework_Graphics_UserInterface_CircularProgressTransformSequenceExtensions_ProgressTo_osu_Framework_Graphics_Transforms_TransformSequence_osu_Framework_Graphics_UserInterface_CircularProgress__System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ProgressTo\(TransformSequence<CircularProgress\>, double, double, Easing\)

```csharp
public static TransformSequence<CircularProgress> ProgressTo(this TransformSequence<CircularProgress> t, double newValue, double duration = 0, Easing easing = Easing.None)
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CircularProgress](osu.Framework.Graphics.UserInterface.CircularProgress.md)\>

`newValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CircularProgress](osu.Framework.Graphics.UserInterface.CircularProgress.md)\>

### <a id="osu_Framework_Graphics_UserInterface_CircularProgressTransformSequenceExtensions_ProgressTo__1_osu_Framework_Graphics_Transforms_TransformSequence_osu_Framework_Graphics_UserInterface_CircularProgress__System_Double_System_Double___0_"></a> ProgressTo<TEasing\>\(TransformSequence<CircularProgress\>, double, double, TEasing\)

```csharp
public static TransformSequence<CircularProgress> ProgressTo<TEasing>(this TransformSequence<CircularProgress> t, double newValue, double duration, TEasing easing) where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CircularProgress](osu.Framework.Graphics.UserInterface.CircularProgress.md)\>

`newValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<[CircularProgress](osu.Framework.Graphics.UserInterface.CircularProgress.md)\>

#### Type Parameters

`TEasing` 

