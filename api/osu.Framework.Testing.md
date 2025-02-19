# <a id="osu_Framework_Testing"></a> Namespace osu.Framework.Testing

### Namespaces

 [osu.Framework.Testing.Drawables](osu.Framework.Testing.Drawables.md)

 [osu.Framework.Testing.Input](osu.Framework.Testing.Input.md)

### Classes

 [GridTestScene](osu.Framework.Testing.GridTestScene.md)

An abstract test case which exposes small cells arranged in a grid.
Useful for displaying multiple configurations of a tested component at a glance.

 [HeadlessTestAttribute](osu.Framework.Testing.HeadlessTestAttribute.md)

Denotes a "visual" test which should only be run in a headless context.
This will stop the test from showing up in a <xref href="osu.Framework.Testing.TestBrowser" data-throw-if-not-resolved="false"></xref>.

 [ManualInputManagerTestScene](osu.Framework.Testing.ManualInputManagerTestScene.md)

An abstract test case which is tested with manual input management.

 [MenuTestScene.MenuStructure](osu.Framework.Testing.MenuTestScene.MenuStructure.md)

Helper class used to retrieve various internal properties/items from a <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref>.

 [MenuTestScene](osu.Framework.Testing.MenuTestScene.md)

A test scene that provides a set of helper functions and structures for testing a <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref>.

 [SetUpStepsAttribute](osu.Framework.Testing.SetUpStepsAttribute.md)

Denotes a method which adds <xref href="osu.Framework.Testing.TestScene" data-throw-if-not-resolved="false"></xref> steps.
Invoked via <xref href="osu.Framework.Testing.TestScene.RunSetUpSteps" data-throw-if-not-resolved="false"></xref> (which is called from nUnit's [SetUp] or <xref href="osu.Framework.Testing.TestBrowser.LoadTest(System.Type%2cSystem.Action%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>).

 [SoloAttribute](osu.Framework.Testing.SoloAttribute.md)

Denotes a single test method which will be "solo"ed during visual execution.
This implies all other tests will be ignored.

 [TearDownStepsAttribute](osu.Framework.Testing.TearDownStepsAttribute.md)

Denotes a method which adds <xref href="osu.Framework.Testing.TestScene" data-throw-if-not-resolved="false"></xref> steps at the end.
Invoked via <xref href="osu.Framework.Testing.TestScene.RunTearDownSteps" data-throw-if-not-resolved="false"></xref> (which is called from nUnit's [TearDown] or <xref href="osu.Framework.Testing.TestBrowser.LoadTest(System.Type%2cSystem.Action%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>).

 [TemporaryNativeStorage](osu.Framework.Testing.TemporaryNativeStorage.md)

A temporary storage that can be used for testing purposes.
Writes files to the OS temporary directory and cleans up on disposal.

 [TestBrowser](osu.Framework.Testing.TestBrowser.md)

 [TestBrowserTestRunner](osu.Framework.Testing.TestBrowserTestRunner.md)

 [TestRunHeadlessGameHost](osu.Framework.Testing.TestRunHeadlessGameHost.md)

A GameHost which writes to the system temporary directory, attempting to clean up after the test run completes.
Also runs in non-realtime (allowing faster test execution) by default.

 [TestSceneTestRunner.TestRunner](osu.Framework.Testing.TestSceneTestRunner.TestRunner.md)

 [TestScene](osu.Framework.Testing.TestScene.md)

 [TestSceneTestRunner](osu.Framework.Testing.TestSceneTestRunner.md)

 [TestingExtensions](osu.Framework.Testing.TestingExtensions.md)

### Interfaces

 [ITestSceneTestRunner](osu.Framework.Testing.ITestSceneTestRunner.md)

### Enums

 [TestBrowserAction](osu.Framework.Testing.TestBrowserAction.md)

