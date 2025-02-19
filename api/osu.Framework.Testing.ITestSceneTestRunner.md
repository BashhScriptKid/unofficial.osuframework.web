# <a id="osu_Framework_Testing_ITestSceneTestRunner"></a> Interface ITestSceneTestRunner

Namespace: [osu.Framework.Testing](osu.Framework.Testing.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ITestSceneTestRunner
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ITestSceneTestRunner\>\(ITestSceneTestRunner?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITestSceneTestRunner\>\(ITestSceneTestRunner\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITestSceneTestRunner\>\(ITestSceneTestRunner\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITestSceneTestRunner\>\(ITestSceneTestRunner\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITestSceneTestRunner, TChild\>\(ITestSceneTestRunner, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITestSceneTestRunner, TChild\>\(ITestSceneTestRunner, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITestSceneTestRunner, TChild\>\(ITestSceneTestRunner, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITestSceneTestRunner\>\(ITestSceneTestRunner\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Testing_ITestSceneTestRunner_RunTestBlocking_osu_Framework_Testing_TestScene_"></a> RunTestBlocking\(TestScene\)

Blocks execution until a provided <xref href="osu.Framework.Testing.TestScene" data-throw-if-not-resolved="false"></xref> runs to completion.

```csharp
void RunTestBlocking(TestScene test)
```

#### Parameters

`test` [TestScene](osu.Framework.Testing.TestScene.md)

The <xref href="osu.Framework.Testing.TestScene" data-throw-if-not-resolved="false"></xref> to run.

