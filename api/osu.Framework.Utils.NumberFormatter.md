# <a id="osu_Framework_Utils_NumberFormatter"></a> Class NumberFormatter

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

Exposes functionality for formatting numbers.

```csharp
public static class NumberFormatter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NumberFormatter](osu.Framework.Utils.NumberFormatter.md)

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

### <a id="osu_Framework_Utils_NumberFormatter_PrintWithSiSuffix_System_Double_"></a> PrintWithSiSuffix\(double\)

Prints the number with at most two decimal digits, followed by a magnitude suffic (k, M, G, T, etc.) depending on the magnitude of the number. If the number is
too large or small this will print the number using scientific notation instead.

```csharp
public static string PrintWithSiSuffix(double number)
```

#### Parameters

`number` [double](https://learn.microsoft.com/dotnet/api/system.double)

The number to print.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The number with at most two decimal digits, followed by a magnitude suffic (k, M, G, T, etc.) depending on the magnitude of the number. If the number is
    too large or small this will print the number using scientific notation instead.

