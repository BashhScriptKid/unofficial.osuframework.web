# <a id="osu_Framework_Configuration_Tracking_TrackedSettings"></a> Class TrackedSettings

Namespace: [osu.Framework.Configuration.Tracking](osu.Framework.Configuration.Tracking.md)  
Assembly: osu.Framework.dll  

```csharp
public class TrackedSettings : List<ITrackedSetting>, IList<ITrackedSetting>, ICollection<ITrackedSetting>, IReadOnlyList<ITrackedSetting>, IReadOnlyCollection<ITrackedSetting>, IEnumerable<ITrackedSetting>, IList, ICollection, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[List<ITrackedSetting\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1) ← 
[TrackedSettings](osu.Framework.Configuration.Tracking.TrackedSettings.md)

#### Implements

[IList<ITrackedSetting\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<ITrackedSetting\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<ITrackedSetting\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<ITrackedSetting\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<ITrackedSetting\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IList](https://learn.microsoft.com/dotnet/api/system.collections.ilist), 
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.icollection), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[List<ITrackedSetting\>.Add\(ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.add), 
[List<ITrackedSetting\>.AddRange\(IEnumerable<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.addrange), 
[List<ITrackedSetting\>.AsReadOnly\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.asreadonly), 
[List<ITrackedSetting\>.BinarySearch\(int, int, ITrackedSetting, IComparer<ITrackedSetting\>?\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.binarysearch\#system\-collections\-generic\-list\-1\-binarysearch\(system\-int32\-system\-int32\-0\-system\-collections\-generic\-icomparer\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.BinarySearch\(ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.binarysearch\#system\-collections\-generic\-list\-1\-binarysearch\(\-0\)), 
[List<ITrackedSetting\>.BinarySearch\(ITrackedSetting, IComparer<ITrackedSetting\>?\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.binarysearch\#system\-collections\-generic\-list\-1\-binarysearch\(\-0\-system\-collections\-generic\-icomparer\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.Clear\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.clear), 
[List<ITrackedSetting\>.Contains\(ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.contains), 
[List<ITrackedSetting\>.ConvertAll<TOutput\>\(Converter<ITrackedSetting, TOutput\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.convertall), 
[List<ITrackedSetting\>.CopyTo\(int, ITrackedSetting\[\], int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.copyto\#system\-collections\-generic\-list\-1\-copyto\(system\-int32\-0\(\)\-system\-int32\-system\-int32\)), 
[List<ITrackedSetting\>.CopyTo\(ITrackedSetting\[\]\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.copyto\#system\-collections\-generic\-list\-1\-copyto\(\-0\(\)\)), 
[List<ITrackedSetting\>.CopyTo\(ITrackedSetting\[\], int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.copyto\#system\-collections\-generic\-list\-1\-copyto\(\-0\(\)\-system\-int32\)), 
[List<ITrackedSetting\>.EnsureCapacity\(int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.ensurecapacity), 
[List<ITrackedSetting\>.Exists\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.exists), 
[List<ITrackedSetting\>.Find\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.find), 
[List<ITrackedSetting\>.FindAll\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findall), 
[List<ITrackedSetting\>.FindIndex\(int, int, Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findindex\#system\-collections\-generic\-list\-1\-findindex\(system\-int32\-system\-int32\-system\-predicate\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.FindIndex\(int, Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findindex\#system\-collections\-generic\-list\-1\-findindex\(system\-int32\-system\-predicate\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.FindIndex\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findindex\#system\-collections\-generic\-list\-1\-findindex\(system\-predicate\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.FindLast\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findlast), 
[List<ITrackedSetting\>.FindLastIndex\(int, int, Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findlastindex\#system\-collections\-generic\-list\-1\-findlastindex\(system\-int32\-system\-int32\-system\-predicate\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.FindLastIndex\(int, Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findlastindex\#system\-collections\-generic\-list\-1\-findlastindex\(system\-int32\-system\-predicate\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.FindLastIndex\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.findlastindex\#system\-collections\-generic\-list\-1\-findlastindex\(system\-predicate\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.ForEach\(Action<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.foreach), 
[List<ITrackedSetting\>.GetEnumerator\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.getenumerator), 
[List<ITrackedSetting\>.GetRange\(int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.getrange), 
[List<ITrackedSetting\>.IndexOf\(ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.indexof\#system\-collections\-generic\-list\-1\-indexof\(\-0\)), 
[List<ITrackedSetting\>.IndexOf\(ITrackedSetting, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.indexof\#system\-collections\-generic\-list\-1\-indexof\(\-0\-system\-int32\)), 
[List<ITrackedSetting\>.IndexOf\(ITrackedSetting, int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.indexof\#system\-collections\-generic\-list\-1\-indexof\(\-0\-system\-int32\-system\-int32\)), 
[List<ITrackedSetting\>.Insert\(int, ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.insert), 
[List<ITrackedSetting\>.InsertRange\(int, IEnumerable<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.insertrange), 
[List<ITrackedSetting\>.LastIndexOf\(ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.lastindexof\#system\-collections\-generic\-list\-1\-lastindexof\(\-0\)), 
[List<ITrackedSetting\>.LastIndexOf\(ITrackedSetting, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.lastindexof\#system\-collections\-generic\-list\-1\-lastindexof\(\-0\-system\-int32\)), 
[List<ITrackedSetting\>.LastIndexOf\(ITrackedSetting, int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.lastindexof\#system\-collections\-generic\-list\-1\-lastindexof\(\-0\-system\-int32\-system\-int32\)), 
[List<ITrackedSetting\>.Remove\(ITrackedSetting\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.remove), 
[List<ITrackedSetting\>.RemoveAll\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.removeall), 
[List<ITrackedSetting\>.RemoveAt\(int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.removeat), 
[List<ITrackedSetting\>.RemoveRange\(int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.removerange), 
[List<ITrackedSetting\>.Reverse\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.reverse\#system\-collections\-generic\-list\-1\-reverse), 
[List<ITrackedSetting\>.Reverse\(int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.reverse\#system\-collections\-generic\-list\-1\-reverse\(system\-int32\-system\-int32\)), 
[List<ITrackedSetting\>.Slice\(int, int\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.slice), 
[List<ITrackedSetting\>.Sort\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.sort\#system\-collections\-generic\-list\-1\-sort), 
[List<ITrackedSetting\>.Sort\(IComparer<ITrackedSetting\>?\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.sort\#system\-collections\-generic\-list\-1\-sort\(system\-collections\-generic\-icomparer\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.Sort\(Comparison<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.sort\#system\-collections\-generic\-list\-1\-sort\(system\-comparison\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.Sort\(int, int, IComparer<ITrackedSetting\>?\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.sort\#system\-collections\-generic\-list\-1\-sort\(system\-int32\-system\-int32\-system\-collections\-generic\-icomparer\(\(\-0\)\)\)), 
[List<ITrackedSetting\>.ToArray\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.toarray), 
[List<ITrackedSetting\>.TrimExcess\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.trimexcess), 
[List<ITrackedSetting\>.TrueForAll\(Predicate<ITrackedSetting\>\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.trueforall), 
[List<ITrackedSetting\>.Capacity](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.capacity), 
[List<ITrackedSetting\>.Count](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.count), 
[List<ITrackedSetting\>.this\[int\]](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.item), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.AddInPlace<ITrackedSetting\>\(List<ITrackedSetting\>, ITrackedSetting\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_AddInPlace\_\_1\_System\_Collections\_Generic\_List\_\_\_0\_\_\_\_0\_), 
[ExtensionMethods.AddInPlace<ITrackedSetting\>\(List<ITrackedSetting\>, ITrackedSetting, IComparer<ITrackedSetting\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_AddInPlace\_\_1\_System\_Collections\_Generic\_List\_\_\_0\_\_\_\_0\_System\_Collections\_Generic\_IComparer\_\_\_0\_\_), 
[ObjectExtensions.AsNonNull<TrackedSettings\>\(TrackedSettings?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ListExtensions.AsSlimReadOnly<ITrackedSetting\>\(List<ITrackedSetting\>\)](osu.Framework.Extensions.ListExtensions.ListExtensions.md\#osu\_Framework\_Extensions\_ListExtensions\_ListExtensions\_AsSlimReadOnly\_\_1\_System\_Collections\_Generic\_List\_\_\_0\_\_), 
[EnumerableExtensions.ForEach<ITrackedSetting\>\(IEnumerable<ITrackedSetting\>, Action<ITrackedSetting\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TrackedSettings\>\(TrackedSettings\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<ITrackedSetting\>\(IEnumerable<ITrackedSetting\>, ITrackedSetting\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<ITrackedSetting\>\(IEnumerable<ITrackedSetting\>, ITrackedSetting\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<ITrackedSetting\>\(IEnumerable<ITrackedSetting\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<TrackedSettings\>\(TrackedSettings\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TrackedSettings\>\(TrackedSettings\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TrackedSettings, TChild\>\(TrackedSettings, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TrackedSettings, TChild\>\(TrackedSettings, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TrackedSettings, TChild\>\(TrackedSettings, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TrackedSettings\>\(TrackedSettings\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Configuration_Tracking_TrackedSettings_LoadFrom__1_osu_Framework_Configuration_ConfigManager___0__"></a> LoadFrom<TLookup\>\(ConfigManager<TLookup\>\)

```csharp
public void LoadFrom<TLookup>(ConfigManager<TLookup> configManager) where TLookup : struct, Enum
```

#### Parameters

`configManager` [ConfigManager](osu.Framework.Configuration.ConfigManager\-1.md)<TLookup\>

#### Type Parameters

`TLookup` 

### <a id="osu_Framework_Configuration_Tracking_TrackedSettings_Unload"></a> Unload\(\)

```csharp
public void Unload()
```

### <a id="osu_Framework_Configuration_Tracking_TrackedSettings_SettingChanged"></a> SettingChanged

```csharp
public event Action<SettingDescription> SettingChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[SettingDescription](osu.Framework.Configuration.Tracking.SettingDescription.md)\>

