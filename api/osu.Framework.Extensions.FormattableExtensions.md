# <a id="osu_Framework_Extensions_FormattableExtensions"></a> Class FormattableExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class FormattableExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FormattableExtensions](osu.Framework.Extensions.FormattableExtensions.md)

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

### <a id="osu_Framework_Extensions_FormattableExtensions_ToString_System_IFormattable_System_IFormatProvider_"></a> ToString\(IFormattable, IFormatProvider\)

Formats the value of <code class="paramref">formattable</code> using the default format string and the supplied <code class="paramref">formatProvider</code>.

```csharp
public static string ToString(this IFormattable formattable, IFormatProvider formatProvider)
```

#### Parameters

`formattable` [IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

`formatProvider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

