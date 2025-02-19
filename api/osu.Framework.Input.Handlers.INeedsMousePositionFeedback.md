# <a id="osu_Framework_Input_Handlers_INeedsMousePositionFeedback"></a> Interface INeedsMousePositionFeedback

Namespace: [osu.Framework.Input.Handlers](osu.Framework.Input.Handlers.md)  
Assembly: osu.Framework.dll  

An <xref href="osu.Framework.Input.Handlers.InputHandler" data-throw-if-not-resolved="false"></xref> which needs to receive feedback of the final mouse position.

```csharp
public interface INeedsMousePositionFeedback
```

#### Extension Methods

[ObjectExtensions.AsNonNull<INeedsMousePositionFeedback\>\(INeedsMousePositionFeedback?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<INeedsMousePositionFeedback\>\(INeedsMousePositionFeedback\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<INeedsMousePositionFeedback\>\(INeedsMousePositionFeedback\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<INeedsMousePositionFeedback\>\(INeedsMousePositionFeedback\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<INeedsMousePositionFeedback, TChild\>\(INeedsMousePositionFeedback, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<INeedsMousePositionFeedback, TChild\>\(INeedsMousePositionFeedback, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<INeedsMousePositionFeedback, TChild\>\(INeedsMousePositionFeedback, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<INeedsMousePositionFeedback\>\(INeedsMousePositionFeedback\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Input_Handlers_INeedsMousePositionFeedback_FeedbackMousePositionChange_osuTK_Vector2_System_Boolean_"></a> FeedbackMousePositionChange\(Vector2, bool\)

Receives the final mouse position from an <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref>.

```csharp
void FeedbackMousePositionChange(Vector2 position, bool isSelfFeedback)
```

#### Parameters

`position` Vector2

The final mouse position.

`isSelfFeedback` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the feedback was triggered from this handler.

