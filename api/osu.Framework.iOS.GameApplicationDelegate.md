# <a id="osu_Framework_iOS_GameApplicationDelegate"></a> Class GameApplicationDelegate

Namespace: [osu.Framework.iOS](osu.Framework.iOS.md)  
Assembly: osu.Framework.iOS.dll  

Base <xref href="UIKit.UIApplicationDelegate" data-throw-if-not-resolved="false"></xref> implementation for osu!framework applications.

```csharp
public abstract class GameApplicationDelegate : UIApplicationDelegate, IEquatable<NSObject>, INSObjectProtocol, IUIApplicationDelegate, INativeObject, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
NSObject ← 
UIApplicationDelegate ← 
[GameApplicationDelegate](osu.Framework.iOS.GameApplicationDelegate.md)

#### Derived

[AppDelegate](osu.Framework.Tests.AppDelegate.md)

#### Implements

[IEquatable<NSObject\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
INSObjectProtocol, 
IUIApplicationDelegate, 
INativeObject, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

UIApplicationDelegate.AccessibilityPerformMagicTap\(\), 
UIApplicationDelegate.ApplicationSignificantTimeChange\(UIApplication\), 
UIApplicationDelegate.ChangedStatusBarFrame\(UIApplication, CGRect\), 
UIApplicationDelegate.ContinueUserActivity\(UIApplication, NSUserActivity, UIApplicationRestorationHandler\), 
UIApplicationDelegate.DidChangeStatusBarOrientation\(UIApplication, UIInterfaceOrientation\), 
UIApplicationDelegate.DidDecodeRestorableState\(UIApplication, NSCoder\), 
UIApplicationDelegate.DidDiscardSceneSessions\(UIApplication, NSSet<UISceneSession\>\), 
UIApplicationDelegate.DidEnterBackground\(UIApplication\), 
UIApplicationDelegate.DidFailToContinueUserActivity\(UIApplication, string, NSError\), 
UIApplicationDelegate.DidReceiveRemoteNotification\(UIApplication, NSDictionary, Action<UIBackgroundFetchResult\>\), 
UIApplicationDelegate.DidRegisterUserNotificationSettings\(UIApplication, UIUserNotificationSettings\), 
UIApplicationDelegate.FailedToRegisterForRemoteNotifications\(UIApplication, NSError\), 
UIApplicationDelegate.FinishedLaunching\(UIApplication\), 
UIApplicationDelegate.FinishedLaunching\(UIApplication, NSDictionary\), 
UIApplicationDelegate.GetConfiguration\(UIApplication, UISceneSession, UISceneConnectionOptions\), 
UIApplicationDelegate.GetHandlerForIntent\(UIApplication, INIntent\), 
UIApplicationDelegate.GetSupportedInterfaceOrientations\(UIApplication, UIWindow\), 
UIApplicationDelegate.GetViewController\(UIApplication, string\[\], NSCoder\), 
UIApplicationDelegate.HandleAction\(UIApplication, string, UILocalNotification, Action\), 
UIApplicationDelegate.HandleAction\(UIApplication, string, UILocalNotification, NSDictionary, Action\), 
UIApplicationDelegate.HandleAction\(UIApplication, string, NSDictionary, Action\), 
UIApplicationDelegate.HandleAction\(UIApplication, string, NSDictionary, NSDictionary, Action\), 
UIApplicationDelegate.HandleEventsForBackgroundUrl\(UIApplication, string, Action\), 
UIApplicationDelegate.HandleIntent\(UIApplication, INIntent, Action<INIntentResponse\>\), 
UIApplicationDelegate.HandleOpenURL\(UIApplication, NSUrl\), 
UIApplicationDelegate.HandleWatchKitExtensionRequest\(UIApplication, NSDictionary, Action<NSDictionary\>\), 
UIApplicationDelegate.OnActivated\(UIApplication\), 
UIApplicationDelegate.OnResignActivation\(UIApplication\), 
UIApplicationDelegate.OpenUrl\(UIApplication, NSUrl, string, NSObject\), 
UIApplicationDelegate.OpenUrl\(UIApplication, NSUrl, NSDictionary\), 
UIApplicationDelegate.OpenUrl\(UIApplication, NSUrl, UIApplicationOpenUrlOptions\), 
UIApplicationDelegate.PerformActionForShortcutItem\(UIApplication, UIApplicationShortcutItem, UIOperationHandler\), 
UIApplicationDelegate.PerformFetch\(UIApplication, Action<UIBackgroundFetchResult\>\), 
UIApplicationDelegate.ProtectedDataDidBecomeAvailable\(UIApplication\), 
UIApplicationDelegate.ProtectedDataWillBecomeUnavailable\(UIApplication\), 
UIApplicationDelegate.ReceiveMemoryWarning\(UIApplication\), 
UIApplicationDelegate.ReceivedLocalNotification\(UIApplication, UILocalNotification\), 
UIApplicationDelegate.ReceivedRemoteNotification\(UIApplication, NSDictionary\), 
UIApplicationDelegate.RegisteredForRemoteNotifications\(UIApplication, NSData\), 
UIApplicationDelegate.ShouldAllowExtensionPointIdentifier\(UIApplication, NSString\), 
UIApplicationDelegate.ShouldAutomaticallyLocalizeKeyCommands\(UIApplication\), 
UIApplicationDelegate.ShouldRequestHealthAuthorization\(UIApplication\), 
UIApplicationDelegate.ShouldRestoreApplicationState\(UIApplication, NSCoder\), 
UIApplicationDelegate.ShouldRestoreSecureApplicationState\(UIApplication, NSCoder\), 
UIApplicationDelegate.ShouldSaveApplicationState\(UIApplication, NSCoder\), 
UIApplicationDelegate.ShouldSaveSecureApplicationState\(UIApplication, NSCoder\), 
UIApplicationDelegate.UserActivityUpdated\(UIApplication, NSUserActivity\), 
UIApplicationDelegate.UserDidAcceptCloudKitShare\(UIApplication, CKShareMetadata\), 
UIApplicationDelegate.WillChangeStatusBarFrame\(UIApplication, CGRect\), 
UIApplicationDelegate.WillChangeStatusBarOrientation\(UIApplication, UIInterfaceOrientation, double\), 
UIApplicationDelegate.WillContinueUserActivity\(UIApplication, string\), 
UIApplicationDelegate.WillEncodeRestorableState\(UIApplication, NSCoder\), 
UIApplicationDelegate.WillEnterForeground\(UIApplication\), 
UIApplicationDelegate.WillFinishLaunching\(UIApplication, NSDictionary\), 
UIApplicationDelegate.WillTerminate\(UIApplication\), 
UIApplicationDelegate.Window, 
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

[ObjectExtensions.AsNonNull<GameApplicationDelegate\>\(GameApplicationDelegate?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GameApplicationDelegate\>\(GameApplicationDelegate\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GameApplicationDelegate\>\(GameApplicationDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GameApplicationDelegate\>\(GameApplicationDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GameApplicationDelegate, TChild\>\(GameApplicationDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GameApplicationDelegate, TChild\>\(GameApplicationDelegate, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GameApplicationDelegate, TChild\>\(GameApplicationDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GameApplicationDelegate\>\(GameApplicationDelegate\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_iOS_GameApplicationDelegate_Host"></a> Host

```csharp
public IOSGameHost Host { get; }
```

#### Property Value

 [IOSGameHost](osu.Framework.iOS.IOSGameHost.md)

## Methods

### <a id="osu_Framework_iOS_GameApplicationDelegate_CreateGame"></a> CreateGame\(\)

Creates the <xref href="osu.Framework.Game" data-throw-if-not-resolved="false"></xref> class to launch.

```csharp
protected abstract Game CreateGame()
```

#### Returns

 Game

### <a id="osu_Framework_iOS_GameApplicationDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary_"></a> FinishedLaunching\(UIApplication, NSDictionary\)

```csharp
public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
```

#### Parameters

`application` UIApplication

`launchOptions` NSDictionary

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_iOS_GameApplicationDelegate_OpenUrl_UIKit_UIApplication_Foundation_NSUrl_Foundation_NSDictionary_"></a> OpenUrl\(UIApplication, NSUrl, NSDictionary\)

```csharp
public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
```

#### Parameters

`app` UIApplication

`url` NSUrl

`options` NSDictionary

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

