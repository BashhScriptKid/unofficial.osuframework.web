# <a id="osu_Framework_Graphics_Performance_LifetimeEntry"></a> Class LifetimeEntry

Namespace: [osu.Framework.Graphics.Performance](osu.Framework.Graphics.Performance.md)  
Assembly: osu.Framework.dll  

An object for a <xref href="osu.Framework.Graphics.Performance.LifetimeEntryManager" data-throw-if-not-resolved="false"></xref> to consume, which provides a <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeStart" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeEnd" data-throw-if-not-resolved="false"></xref>.

```csharp
public class LifetimeEntry
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LifetimeEntry\>\(LifetimeEntry?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LifetimeEntry\>\(LifetimeEntry\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LifetimeEntry\>\(LifetimeEntry\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LifetimeEntry\>\(LifetimeEntry\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LifetimeEntry, TChild\>\(LifetimeEntry, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LifetimeEntry, TChild\>\(LifetimeEntry, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LifetimeEntry, TChild\>\(LifetimeEntry, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LifetimeEntry\>\(LifetimeEntry\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

Management of the object which the <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> refers to is left up to the consumer.

## Properties

### <a id="osu_Framework_Graphics_Performance_LifetimeEntry_LifetimeEnd"></a> LifetimeEnd

The time at which this <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> becomes dead in a <xref href="osu.Framework.Graphics.Performance.LifetimeEntryManager" data-throw-if-not-resolved="false"></xref>.

```csharp
public double LifetimeEnd { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Performance_LifetimeEntry_LifetimeStart"></a> LifetimeStart

The time at which this <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref> becomes alive in a <xref href="osu.Framework.Graphics.Performance.LifetimeEntryManager" data-throw-if-not-resolved="false"></xref>.

```csharp
public double LifetimeStart { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Graphics_Performance_LifetimeEntry_SetLifetime_System_Double_System_Double_"></a> SetLifetime\(double, double\)

Updates the stored lifetimes of this <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref>.

```csharp
protected void SetLifetime(double start, double end)
```

#### Parameters

`start` [double](https://learn.microsoft.com/dotnet/api/system.double)

The new <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeStart" data-throw-if-not-resolved="false"></xref> value.

`end` [double](https://learn.microsoft.com/dotnet/api/system.double)

The new <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeEnd" data-throw-if-not-resolved="false"></xref> value.

### <a id="osu_Framework_Graphics_Performance_LifetimeEntry_SetLifetimeEnd_System_Double_"></a> SetLifetimeEnd\(double\)

Update <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeEnd" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void SetLifetimeEnd(double end)
```

#### Parameters

`end` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Performance_LifetimeEntry_SetLifetimeStart_System_Double_"></a> SetLifetimeStart\(double\)

Update <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeStart" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Performance.LifetimeEntry" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void SetLifetimeStart(double start)
```

#### Parameters

`start` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Performance_LifetimeEntry_LifetimeChanged"></a> LifetimeChanged

Invoked after <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeStart" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Performance.LifetimeEntry.LifetimeEnd" data-throw-if-not-resolved="false"></xref> changes.

```csharp
public event Action<LifetimeEntry> LifetimeChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[LifetimeEntry](osu.Framework.Graphics.Performance.LifetimeEntry.md)\>

