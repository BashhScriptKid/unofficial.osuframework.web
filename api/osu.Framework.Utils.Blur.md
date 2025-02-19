# <a id="osu_Framework_Utils_Blur"></a> Class Blur

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

Helper methods for blur calculations.

```csharp
public static class Blur
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Blur](osu.Framework.Utils.Blur.md)

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

### <a id="osu_Framework_Utils_Blur_EvalGaussian_System_Single_System_Single_"></a> EvalGaussian\(float, float\)

Evaluates a 1-D gaussian distribution with 0 mean and sigma standard deviation at position x.

```csharp
public static double EvalGaussian(float x, float sigma)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

The position to evaluate the distribution at.

`sigma` [float](https://learn.microsoft.com/dotnet/api/system.single)

Standard deviation of the distribution.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The probability density of the distribution at x.

### <a id="osu_Framework_Utils_Blur_KernelSize_System_Single_System_Single_"></a> KernelSize\(float, float\)

Finds the gaussian blur kernel size where the magnitude of the gaussian distribution within the kernel
is greater than or equal to cutoffThreshold times the maximum of the distribution.

```csharp
public static int KernelSize(float sigma, float cutoffThreshold = 0.1)
```

#### Parameters

`sigma` [float](https://learn.microsoft.com/dotnet/api/system.single)

Standard deviation of the distribution.

`cutoffThreshold` [float](https://learn.microsoft.com/dotnet/api/system.single)

The threshold that defines the kernel size.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The size of the kernel satisfying the requested threshold.

