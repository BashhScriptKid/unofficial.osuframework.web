# <a id="osu_Framework_Tests_Platform_ComponentAsyncDisposalTest"></a> Class ComponentAsyncDisposalTest

Namespace: [osu.Framework.Tests.Platform](osu.Framework.Tests.Platform.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class ComponentAsyncDisposalTest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ComponentAsyncDisposalTest](osu.Framework.Tests.Platform.ComponentAsyncDisposalTest.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ComponentAsyncDisposalTest\>\(ComponentAsyncDisposalTest?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ComponentAsyncDisposalTest\>\(ComponentAsyncDisposalTest\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ComponentAsyncDisposalTest\>\(ComponentAsyncDisposalTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ComponentAsyncDisposalTest\>\(ComponentAsyncDisposalTest\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ComponentAsyncDisposalTest, TChild\>\(ComponentAsyncDisposalTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ComponentAsyncDisposalTest, TChild\>\(ComponentAsyncDisposalTest, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ComponentAsyncDisposalTest, TChild\>\(ComponentAsyncDisposalTest, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ComponentAsyncDisposalTest\>\(ComponentAsyncDisposalTest\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Platform_ComponentAsyncDisposalTest_TestChildDisposedBeforeGame"></a> TestChildDisposedBeforeGame\(\)

Ensure that if a component is on the async disposal queue, the game will wait for the queue to empty before disposing itself.
While we generally don't dispose games in normal execution, this may be used in tests, and can cause unwanted exceptions in (cancelled) load
methods if not ordered correctly.

```csharp
[Test]
public void TestChildDisposedBeforeGame()
```

### <a id="osu_Framework_Tests_Platform_ComponentAsyncDisposalTest_TestChildDisposedBeforeGame"></a> TestChildDisposedBeforeGame\(\)

Ensure that if a component is on the async disposal queue, the game will wait for the queue to empty before disposing itself.
While we generally don't dispose games in normal execution, this may be used in tests, and can cause unwanted exceptions in (cancelled) load
methods if not ordered correctly.

```csharp
[Test]
public void TestChildDisposedBeforeGame()
```

### <a id="osu_Framework_Tests_Platform_ComponentAsyncDisposalTest_TestChildDisposedBeforeGame"></a> TestChildDisposedBeforeGame\(\)

Ensure that if a component is on the async disposal queue, the game will wait for the queue to empty before disposing itself.
While we generally don't dispose games in normal execution, this may be used in tests, and can cause unwanted exceptions in (cancelled) load
methods if not ordered correctly.

```csharp
[Test]
public void TestChildDisposedBeforeGame()
```

