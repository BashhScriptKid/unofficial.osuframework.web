# <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions"></a> Class TestLoadExceptions

Namespace: [osu.Framework.Tests.Exceptions](osu.Framework.Tests.Exceptions.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
[TestFixture]
public class TestLoadExceptions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TestLoadExceptions](osu.Framework.Tests.Exceptions.TestLoadExceptions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TestLoadExceptions\>\(TestLoadExceptions?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestLoadExceptions\>\(TestLoadExceptions\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TestLoadExceptions\>\(TestLoadExceptions\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestLoadExceptions\>\(TestLoadExceptions\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TestLoadExceptions, TChild\>\(TestLoadExceptions, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestLoadExceptions, TChild\>\(TestLoadExceptions, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestLoadExceptions, TChild\>\(TestLoadExceptions, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestLoadExceptions\>\(TestLoadExceptions\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDisposeAfterLoad"></a> TestDisposeAfterLoad\(\)

The async load completion callback is scheduled on the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref>. The callback is generally used to add the child to the container,
however it is possible for the container to be disposed when this occurs due to being scheduled on the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref>. If this occurs,
the cancellation is invoked and the completion task should not be run.

This is a very timing-dependent test which performs the following sequence:
LoadAsync -&gt; schedule Callback -&gt; dispose parent -&gt; invoke scheduled callback

```csharp
[Test]
public void TestDisposeAfterLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDisposeAfterLoad"></a> TestDisposeAfterLoad\(\)

The async load completion callback is scheduled on the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref>. The callback is generally used to add the child to the container,
however it is possible for the container to be disposed when this occurs due to being scheduled on the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref>. If this occurs,
the cancellation is invoked and the completion task should not be run.

This is a very timing-dependent test which performs the following sequence:
LoadAsync -&gt; schedule Callback -&gt; dispose parent -&gt; invoke scheduled callback

```csharp
[Test]
public void TestDisposeAfterLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDisposeAfterLoad"></a> TestDisposeAfterLoad\(\)

The async load completion callback is scheduled on the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref>. The callback is generally used to add the child to the container,
however it is possible for the container to be disposed when this occurs due to being scheduled on the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref>. If this occurs,
the cancellation is invoked and the completion task should not be run.

This is a very timing-dependent test which performs the following sequence:
LoadAsync -&gt; schedule Callback -&gt; dispose parent -&gt; invoke scheduled callback

```csharp
[Test]
public void TestDisposeAfterLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDoubleAsyncAddFails"></a> TestDoubleAsyncAddFails\(\)

```csharp
[Test]
public void TestDoubleAsyncAddFails()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDoubleAsyncAddFails"></a> TestDoubleAsyncAddFails\(\)

```csharp
[Test]
public void TestDoubleAsyncAddFails()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDoubleAsyncAddFails"></a> TestDoubleAsyncAddFails\(\)

```csharp
[Test]
public void TestDoubleAsyncAddFails()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDoubleAsyncLoad"></a> TestDoubleAsyncLoad\(\)

```csharp
[Test]
public void TestDoubleAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDoubleAsyncLoad"></a> TestDoubleAsyncLoad\(\)

```csharp
[Test]
public void TestDoubleAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestDoubleAsyncLoad"></a> TestDoubleAsyncLoad\(\)

```csharp
[Test]
public void TestDoubleAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestLoadIntoInvalidTarget"></a> TestLoadIntoInvalidTarget\(\)

```csharp
[Test]
public void TestLoadIntoInvalidTarget()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestLoadIntoInvalidTarget"></a> TestLoadIntoInvalidTarget\(\)

```csharp
[Test]
public void TestLoadIntoInvalidTarget()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestLoadIntoInvalidTarget"></a> TestLoadIntoInvalidTarget\(\)

```csharp
[Test]
public void TestLoadIntoInvalidTarget()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestLoadableDisposedDuringAsyncLoad"></a> TestLoadableDisposedDuringAsyncLoad\(\)

```csharp
[Test]
public void TestLoadableDisposedDuringAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestLoadableDisposedDuringAsyncLoad"></a> TestLoadableDisposedDuringAsyncLoad\(\)

```csharp
[Test]
public void TestLoadableDisposedDuringAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestLoadableDisposedDuringAsyncLoad"></a> TestLoadableDisposedDuringAsyncLoad\(\)

```csharp
[Test]
public void TestLoadableDisposedDuringAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSingleAsyncAdd"></a> TestSingleAsyncAdd\(\)

```csharp
[Test]
public void TestSingleAsyncAdd()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSingleAsyncAdd"></a> TestSingleAsyncAdd\(\)

```csharp
[Test]
public void TestSingleAsyncAdd()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSingleAsyncAdd"></a> TestSingleAsyncAdd\(\)

```csharp
[Test]
public void TestSingleAsyncAdd()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSingleSyncAdd"></a> TestSingleSyncAdd\(\)

```csharp
[Test]
public void TestSingleSyncAdd()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSingleSyncAdd"></a> TestSingleSyncAdd\(\)

```csharp
[Test]
public void TestSingleSyncAdd()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSingleSyncAdd"></a> TestSingleSyncAdd\(\)

```csharp
[Test]
public void TestSingleSyncAdd()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSyncLoadException"></a> TestSyncLoadException\(\)

```csharp
[Test]
public void TestSyncLoadException()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSyncLoadException"></a> TestSyncLoadException\(\)

```csharp
[Test]
public void TestSyncLoadException()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestSyncLoadException"></a> TestSyncLoadException\(\)

```csharp
[Test]
public void TestSyncLoadException()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestTargetDisposedDuringAsyncLoad"></a> TestTargetDisposedDuringAsyncLoad\(\)

```csharp
[Test]
public void TestTargetDisposedDuringAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestTargetDisposedDuringAsyncLoad"></a> TestTargetDisposedDuringAsyncLoad\(\)

```csharp
[Test]
public void TestTargetDisposedDuringAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestTargetDisposedDuringAsyncLoad"></a> TestTargetDisposedDuringAsyncLoad\(\)

```csharp
[Test]
public void TestTargetDisposedDuringAsyncLoad()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestUnobservedException"></a> TestUnobservedException\(\)

```csharp
[Test]
public void TestUnobservedException()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestUnobservedException"></a> TestUnobservedException\(\)

```csharp
[Test]
public void TestUnobservedException()
```

### <a id="osu_Framework_Tests_Exceptions_TestLoadExceptions_TestUnobservedException"></a> TestUnobservedException\(\)

```csharp
[Test]
public void TestUnobservedException()
```

