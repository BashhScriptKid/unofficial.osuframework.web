# <a id="osu_Framework_Utils_RNG"></a> Class RNG

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

Static utility class for random number generation.

```csharp
public static class RNG
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RNG](osu.Framework.Utils.RNG.md)

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

### <a id="osu_Framework_Utils_RNG_Next"></a> Next\(\)

Returns a non-negative signed integer.

```csharp
public static int Next()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A non-negative signed integer.

### <a id="osu_Framework_Utils_RNG_Next_System_Int32_"></a> Next\(int\)

Returns a signed integer in the range [0,maxValue).

```csharp
public static int Next(int maxValue)
```

#### Parameters

`maxValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The maximum value that should be returned (exclusive, the highest possible result is maxValue - 1).

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A signed integer in the range [0,maxValue).

### <a id="osu_Framework_Utils_RNG_Next_System_Int32_System_Int32_"></a> Next\(int, int\)

Returns a signed integer in the range [minValue,maxValue).

```csharp
public static int Next(int minValue, int maxValue)
```

#### Parameters

`minValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The minimum value that should be returned (inclusive).

`maxValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The maximum value that should be returned (exclusive, the highest possible result is maxValue - 1).

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A signed integer in the range [minValue,maxValue).

### <a id="osu_Framework_Utils_RNG_NextBool_System_Double_"></a> NextBool\(double\)

Returns true or false. The likelihood of true and false are determined by trueChance.

```csharp
public static bool NextBool(double trueChance = 0.5)
```

#### Parameters

`trueChance` [double](https://learn.microsoft.com/dotnet/api/system.double)

The chance that the result is true (a value from 0.0 to 1.0).

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True or false with the given probability.

### <a id="osu_Framework_Utils_RNG_NextBytes_System_Byte___"></a> NextBytes\(byte\[\]\)

Fills the given buffer with random bytes.

```csharp
public static void NextBytes(byte[] buffer)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The buffer that should be filled.

### <a id="osu_Framework_Utils_RNG_NextBytes_System_Int32_"></a> NextBytes\(int\)

Creates a new byte array with the given length and fills it with random values.

```csharp
public static byte[] NextBytes(int length)
```

#### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The length the byte array should have.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The newly created byte array.

### <a id="osu_Framework_Utils_RNG_NextDouble"></a> NextDouble\(\)

Returns a double-precision floating point number in the range [0,1).

```csharp
public static double NextDouble()
```

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

A double-precision floating point number in the range [0,1).

### <a id="osu_Framework_Utils_RNG_NextDouble_System_Double_"></a> NextDouble\(double\)

Returns a double-precision floating point number in the range [0,maxValue).

```csharp
public static double NextDouble(double maxValue)
```

#### Parameters

`maxValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

The maximum value that should be returned (exclusive).

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

A double-precision floating point number in the range [0,maxValue).

### <a id="osu_Framework_Utils_RNG_NextDouble_System_Double_System_Double_"></a> NextDouble\(double, double\)

Returns a double-precision floating point number in the range [minValue,maxValue).

```csharp
public static double NextDouble(double minValue, double maxValue)
```

#### Parameters

`minValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

The minimum value that should be returned (inclusive).

`maxValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

The maximum value that should be returned (exclusive).

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

A double-precision floating point number in the range [minValue,maxValue).

### <a id="osu_Framework_Utils_RNG_NextSingle"></a> NextSingle\(\)

Returns a single-precision floating point number in the range [0,1).

```csharp
public static float NextSingle()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

A single-precision floating point number in the range [0,1).

### <a id="osu_Framework_Utils_RNG_NextSingle_System_Single_"></a> NextSingle\(float\)

Returns a single-precision floating point number in the range [0,maxValue).

```csharp
public static float NextSingle(float maxValue)
```

#### Parameters

`maxValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The maximum value that should be returned (exclusive).

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

A single-precision floating point number in the range [0,maxValue).

### <a id="osu_Framework_Utils_RNG_NextSingle_System_Single_System_Single_"></a> NextSingle\(float, float\)

Returns a single-precision floating point number in the range [minValue,maxValue).

```csharp
public static float NextSingle(float minValue, float maxValue)
```

#### Parameters

`minValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The minimum value that should be returned (inclusive).

`maxValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The maximum value that should be returned (exclusive).

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

A single-precision floating point number in the range [minValue,maxValue).

