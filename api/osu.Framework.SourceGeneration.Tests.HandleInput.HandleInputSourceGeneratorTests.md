# <a id="osu_Framework_SourceGeneration_Tests_HandleInput_HandleInputSourceGeneratorTests"></a> Class HandleInputSourceGeneratorTests

Namespace: [osu.Framework.SourceGeneration.Tests.HandleInput](osu.Framework.SourceGeneration.Tests.HandleInput.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class HandleInputSourceGeneratorTests : AbstractGeneratorTests
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbstractGeneratorTests](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md) ← 
[HandleInputSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.HandleInput.HandleInputSourceGeneratorTests.md)

#### Inherited Members

[AbstractGeneratorTests.ResourceNamespace](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md\#osu\_Framework\_SourceGeneration\_Tests\_AbstractGeneratorTests\_ResourceNamespace), 
[AbstractGeneratorTests.GetTestSources\(string, out \(string filename, string content\)\[\], out \(string filename, string content\)\[\], out \(string filename, string content\)\[\], out \(string filename, string content\)\[\]\)](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md\#osu\_Framework\_SourceGeneration\_Tests\_AbstractGeneratorTests\_GetTestSources\_System\_String\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HandleInputSourceGeneratorTests\>\(HandleInputSourceGeneratorTests?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HandleInputSourceGeneratorTests\>\(HandleInputSourceGeneratorTests\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HandleInputSourceGeneratorTests\>\(HandleInputSourceGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HandleInputSourceGeneratorTests\>\(HandleInputSourceGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HandleInputSourceGeneratorTests, TChild\>\(HandleInputSourceGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HandleInputSourceGeneratorTests, TChild\>\(HandleInputSourceGeneratorTests, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HandleInputSourceGeneratorTests, TChild\>\(HandleInputSourceGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HandleInputSourceGeneratorTests\>\(HandleInputSourceGeneratorTests\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_HandleInput_HandleInputSourceGeneratorTests_ResourceNamespace"></a> ResourceNamespace

```csharp
protected override string ResourceNamespace { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_HandleInput_HandleInputSourceGeneratorTests_Check_System_String_"></a> Check\(string\)

```csharp
[Theory]
[InlineData(new object[] { "HandleMethod" })]
[InlineData(new object[] { "OnMouseMoveMethod" })]
[InlineData(new object[] { "OnHoverMethod" })]
[InlineData(new object[] { "OnHoverLostMethod" })]
[InlineData(new object[] { "OnMouseDownMethod" })]
[InlineData(new object[] { "OnMouseUpMethod" })]
[InlineData(new object[] { "OnClickMethod" })]
[InlineData(new object[] { "OnDoubleClickMethod" })]
[InlineData(new object[] { "OnDragStartMethod" })]
[InlineData(new object[] { "OnDragMethod" })]
[InlineData(new object[] { "OnDragEndMethod" })]
[InlineData(new object[] { "OnScrollMethod" })]
[InlineData(new object[] { "OnFocusMethod" })]
[InlineData(new object[] { "OnFocusLostMethod" })]
[InlineData(new object[] { "OnTouchDownMethod" })]
[InlineData(new object[] { "OnTouchMoveMethod" })]
[InlineData(new object[] { "OnTouchUpMethod" })]
[InlineData(new object[] { "OnTabletPenButtonPressMethod" })]
[InlineData(new object[] { "OnTabletPenButtonReleaseMethod" })]
[InlineData(new object[] { "OnKeyDownMethod" })]
[InlineData(new object[] { "OnKeyUpMethod" })]
[InlineData(new object[] { "OnJoystickPressMethod" })]
[InlineData(new object[] { "OnJoystickReleaseMethod" })]
[InlineData(new object[] { "OnJoystickAxisMoveMethod" })]
[InlineData(new object[] { "OnTabletAuxiliaryButtonPressMethod" })]
[InlineData(new object[] { "OnTabletAuxiliaryButtonReleaseMethod" })]
[InlineData(new object[] { "OnMidiDownMethod" })]
[InlineData(new object[] { "OnMidiUpMethod" })]
[InlineData(new object[] { "HandlePositionalInputProperty" })]
[InlineData(new object[] { "HandleNonPositionalInputProperty" })]
[InlineData(new object[] { "AcceptsFocusProperty" })]
[InlineData(new object[] { "IHasTooltipInterface" })]
[InlineData(new object[] { "IHasCustomTooltipInterface" })]
[InlineData(new object[] { "IHasContextMenuInterface" })]
[InlineData(new object[] { "IHasPopoverInterface" })]
[InlineData(new object[] { "IKeyBindingHandlerInterface" })]
[InlineData(new object[] { "IntermediateNonPartial" })]
public Task Check(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

