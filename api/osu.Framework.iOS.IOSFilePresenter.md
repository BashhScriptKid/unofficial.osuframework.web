# <a id="osu_Framework_iOS_IOSFilePresenter"></a> Class IOSFilePresenter

Namespace: [osu.Framework.iOS](osu.Framework.iOS.md)  
Assembly: osu.Framework.iOS.dll  

```csharp
public class IOSFilePresenter : UIDocumentInteractionControllerDelegate, IEquatable<NSObject>, INSObjectProtocol, IUIDocumentInteractionControllerDelegate, INativeObject, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
NSObject ← 
UIDocumentInteractionControllerDelegate ← 
[IOSFilePresenter](osu.Framework.iOS.IOSFilePresenter.md)

#### Implements

[IEquatable<NSObject\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
INSObjectProtocol, 
IUIDocumentInteractionControllerDelegate, 
INativeObject, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

UIDocumentInteractionControllerDelegate.CanPerformAction\(UIDocumentInteractionController, Selector?\), 
UIDocumentInteractionControllerDelegate.DidDismissOpenInMenu\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.DidDismissOptionsMenu\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.DidEndPreview\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.DidEndSendingToApplication\(UIDocumentInteractionController, string?\), 
UIDocumentInteractionControllerDelegate.PerformAction\(UIDocumentInteractionController, Selector?\), 
UIDocumentInteractionControllerDelegate.RectangleForPreview\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.ViewControllerForPreview\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.ViewForPreview\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.WillBeginPreview\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.WillBeginSendingToApplication\(UIDocumentInteractionController, string?\), 
UIDocumentInteractionControllerDelegate.WillPresentOpenInMenu\(UIDocumentInteractionController\), 
UIDocumentInteractionControllerDelegate.WillPresentOptionsMenu\(UIDocumentInteractionController\), 
NSObject.PlatformAssembly, 
NSObject.Dispose\(\), 
NSObject.ConformsToProtocol\(NativeHandle\), 
NSObject.DangerousRelease\(\), 
NSObject.DangerousRetain\(\), 
NSObject.DangerousAutorelease\(\), 
NSObject.BeginInvokeOnMainThread\(Selector, NSObject\), 
NSObject.InvokeOnMainThread\(Selector, NSObject\), 
NSObject.BeginInvokeOnMainThread\(Action\), 
NSObject.InvokeOnMainThread\(Action\), 
NSObject.FromObject\(object\), 
NSObject.SetValueForKeyPath\(NativeHandle, NSString\), 
NSObject.GetHashCode\(\), 
NSObject.Equals\(object\), 
NSObject.Equals\(NSObject\), 
NSObject.ToString\(\), 
NSObject.Invoke\(Action, double\), 
NSObject.Invoke\(Action, TimeSpan\), 
NSObject.Dispose\(bool\), 
NSObject.AddObserver\(string, NSKeyValueObservingOptions, Action<NSObservedChange\>\), 
NSObject.AddObserver\(NSString, NSKeyValueObservingOptions, Action<NSObservedChange\>\), 
NSObject.InvokeInBackground\(Action\), 
NSObject.AddObserver\(NSObject, NSString, NSKeyValueObservingOptions, nint\), 
NSObject.AddObserver\(NSObject, string, NSKeyValueObservingOptions, nint\), 
NSObject.AutomaticallyNotifiesObserversForKey\(string\), 
NSObject.AwakeFromNib\(\), 
NSObject.CancelPreviousPerformRequest\(NSObject\), 
NSObject.CancelPreviousPerformRequest\(NSObject, Selector, NSObject?\), 
NSObject.Copy\(\), 
NSObject.DidChange\(NSKeyValueChange, NSIndexSet, NSString\), 
NSObject.DidChange\(NSString, NSKeyValueSetMutationKind, NSSet\), 
NSObject.DidChangeValue\(string\), 
NSObject.DoesNotRecognizeSelector\(Selector\), 
NSObject.GetDictionaryOfValuesFromKeys\(NSString\[\]\), 
NSObject.GetKeyPathsForValuesAffecting\(NSString\), 
NSObject.GetMethodForSelector\(Selector\), 
NSObject.MutableCopy\(\), 
NSObject.ObserveValue\(NSString, NSObject, NSDictionary, nint\), 
NSObject.PerformSelector\(Selector, NSObject?, double, NSString\[\]\), 
NSObject.PerformSelector\(Selector, NSObject?, double\), 
NSObject.PerformSelector\(Selector, NSThread, NSObject?, bool\), 
NSObject.PerformSelector\(Selector, NSThread, NSObject?, bool, NSString\[\]?\), 
NSObject.PerformSelector\(Selector\), 
NSObject.PerformSelector\(Selector, NSObject?\), 
NSObject.PerformSelector\(Selector, NSObject?, NSObject?\), 
NSObject.PrepareForInterfaceBuilder\(\), 
NSObject.RemoveObserver\(NSObject, NSString, nint\), 
NSObject.RemoveObserver\(NSObject, string, nint\), 
NSObject.RemoveObserver\(NSObject, NSString\), 
NSObject.RemoveObserver\(NSObject, string\), 
NSObject.SetNilValueForKey\(NSString\), 
NSObject.SetValueForKey\(NSObject, NSString\), 
NSObject.SetValueForKeyPath\(NSObject, NSString\), 
NSObject.SetValueForUndefinedKey\(NSObject, NSString\), 
NSObject.SetValuesForKeysWithDictionary\(NSDictionary\), 
NSObject.ValueForKey\(NSString\), 
NSObject.ValueForKeyPath\(NSString\), 
NSObject.ValueForUndefinedKey\(NSString\), 
NSObject.WillChange\(NSKeyValueChange, NSIndexSet, NSString\), 
NSObject.WillChange\(NSString, NSKeyValueSetMutationKind, NSSet\), 
NSObject.WillChangeValue\(string\), 
NSObject.ClassHandle, 
NSObject.AccessibilityAttributedUserInputLabels, 
NSObject.AccessibilityRespondsToUserInteraction, 
NSObject.AccessibilityTextualContext, 
NSObject.AccessibilityUserInputLabels, 
NSObject.DebugDescription, 
NSObject.Description, 
NSObject.RetainCount, 
NSObject.ChangeIndexesKey, 
NSObject.ChangeKindKey, 
NSObject.ChangeNewKey, 
NSObject.ChangeNotificationIsPriorKey, 
NSObject.ChangeOldKey, 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IOSFilePresenter\>\(IOSFilePresenter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IOSFilePresenter\>\(IOSFilePresenter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IOSFilePresenter\>\(IOSFilePresenter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IOSFilePresenter\>\(IOSFilePresenter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IOSFilePresenter, TChild\>\(IOSFilePresenter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IOSFilePresenter, TChild\>\(IOSFilePresenter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IOSFilePresenter, TChild\>\(IOSFilePresenter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IOSFilePresenter\>\(IOSFilePresenter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_iOS_IOSFilePresenter__ctor_osu_Framework_iOS_IIOSWindow_"></a> IOSFilePresenter\(IIOSWindow\)

```csharp
public IOSFilePresenter(IIOSWindow window)
```

#### Parameters

`window` [IIOSWindow](osu.Framework.iOS.IIOSWindow.md)

## Methods

### <a id="osu_Framework_iOS_IOSFilePresenter_OpenFile_System_String_"></a> OpenFile\(string\)

```csharp
public bool OpenFile(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_iOS_IOSFilePresenter_PresentFile_System_String_"></a> PresentFile\(string\)

```csharp
public bool PresentFile(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_iOS_IOSFilePresenter_ViewControllerForPreview_UIKit_UIDocumentInteractionController_"></a> ViewControllerForPreview\(UIDocumentInteractionController\)

```csharp
public override UIViewController ViewControllerForPreview(UIDocumentInteractionController controller)
```

#### Parameters

`controller` UIDocumentInteractionController

#### Returns

 UIViewController

### <a id="osu_Framework_iOS_IOSFilePresenter_WillBeginSendingToApplication_UIKit_UIDocumentInteractionController_System_String_"></a> WillBeginSendingToApplication\(UIDocumentInteractionController, string?\)

```csharp
public override void WillBeginSendingToApplication(UIDocumentInteractionController controller, string? application)
```

#### Parameters

`controller` UIDocumentInteractionController

`application` [string](https://learn.microsoft.com/dotnet/api/system.string)?

