# <a id="osu_Framework_Bindables_ICanBeDisabled"></a> Interface ICanBeDisabled

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

Interface for objects that have a disabled state.

```csharp
public interface ICanBeDisabled
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ICanBeDisabled\>\(ICanBeDisabled?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ICanBeDisabled\>\(ICanBeDisabled\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ICanBeDisabled\>\(ICanBeDisabled\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ICanBeDisabled\>\(ICanBeDisabled\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ICanBeDisabled, TChild\>\(ICanBeDisabled, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ICanBeDisabled, TChild\>\(ICanBeDisabled, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ICanBeDisabled, TChild\>\(ICanBeDisabled, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ICanBeDisabled\>\(ICanBeDisabled\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Bindables_ICanBeDisabled_Disabled"></a> Disabled

Whether this object has been disabled.

```csharp
bool Disabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Bindables_ICanBeDisabled_BindDisabledChanged_System_Action_System_Boolean__System_Boolean_"></a> BindDisabledChanged\(Action<bool\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.ICanBeDisabled.DisabledChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately.

```csharp
void BindDisabledChanged(Action<bool> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The action to perform when <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_ICanBeDisabled_DisabledChanged"></a> DisabledChanged

An event which is raised when <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled" data-throw-if-not-resolved="false"></xref>'s state has changed.

```csharp
event Action<bool> DisabledChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

