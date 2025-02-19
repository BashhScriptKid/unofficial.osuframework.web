# <a id="osu_Framework_Input_InputResampler"></a> Class InputResampler

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

Reduces cursor input to relevant nodes and corners that noticably affect the cursor path.
If the input is a raw/HD input this won't omit any input nodes.
Set SmoothRawInput to true to keep behaviour for HD inputs.

```csharp
public class InputResampler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputResampler](osu.Framework.Input.InputResampler.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<InputResampler\>\(InputResampler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InputResampler\>\(InputResampler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InputResampler\>\(InputResampler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InputResampler\>\(InputResampler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InputResampler, TChild\>\(InputResampler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InputResampler, TChild\>\(InputResampler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InputResampler, TChild\>\(InputResampler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InputResampler\>\(InputResampler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_InputResampler_ResampleRawInput"></a> ResampleRawInput

true if AddPosition should treat raw input (input with a decimal fraction) the same
as normal input. If false, AddPosition will always just return the position argument
passed to the function without modification.

```csharp
public bool ResampleRawInput { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Input_InputResampler_AddPosition_osuTK_Vector2_"></a> AddPosition\(Vector2\)

Function that takes in a <code class="paramref">position</code> and returns a list of positions
that can be used by the caller to make the input path smoother or reduce it.
The current implementation always returns only none or exactly one vector which
reduces the input to the corner nodes.

```csharp
public List<Vector2> AddPosition(Vector2 position)
```

#### Parameters

`position` Vector2

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

#### Remarks

To save on allocations, the returned list is only valid until the next call of <xref href="osu.Framework.Input.InputResampler.AddPosition(osuTK.Vector2)" data-throw-if-not-resolved="false"></xref>.

