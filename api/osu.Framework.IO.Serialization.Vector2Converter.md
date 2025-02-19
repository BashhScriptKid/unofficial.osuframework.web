# <a id="osu_Framework_IO_Serialization_Vector2Converter"></a> Class Vector2Converter

Namespace: [osu.Framework.IO.Serialization](osu.Framework.IO.Serialization.md)  
Assembly: osu.Framework.dll  

A type of <xref href="Newtonsoft.Json.JsonConverter" data-throw-if-not-resolved="false"></xref> that serializes only the X and Y coordinates of a <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref>.

```csharp
public class Vector2Converter : JsonConverter<Vector2>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
JsonConverter ← 
JsonConverter<Vector2\> ← 
[Vector2Converter](osu.Framework.IO.Serialization.Vector2Converter.md)

#### Inherited Members

JsonConverter<Vector2\>.WriteJson\(JsonWriter, object?, JsonSerializer\), 
JsonConverter<Vector2\>.WriteJson\(JsonWriter, Vector2, JsonSerializer\), 
JsonConverter<Vector2\>.ReadJson\(JsonReader, Type, object?, JsonSerializer\), 
JsonConverter<Vector2\>.ReadJson\(JsonReader, Type, Vector2, bool, JsonSerializer\), 
JsonConverter<Vector2\>.CanConvert\(Type\), 
JsonConverter.WriteJson\(JsonWriter, object?, JsonSerializer\), 
JsonConverter.ReadJson\(JsonReader, Type, object?, JsonSerializer\), 
JsonConverter.CanConvert\(Type\), 
JsonConverter.CanRead, 
JsonConverter.CanWrite, 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Vector2Converter\>\(Vector2Converter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Vector2Converter\>\(Vector2Converter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Vector2Converter\>\(Vector2Converter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Vector2Converter\>\(Vector2Converter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Vector2Converter, TChild\>\(Vector2Converter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Vector2Converter, TChild\>\(Vector2Converter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Vector2Converter, TChild\>\(Vector2Converter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Vector2Converter\>\(Vector2Converter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_IO_Serialization_Vector2Converter_ReadJson_Newtonsoft_Json_JsonReader_System_Type_osuTK_Vector2_System_Boolean_Newtonsoft_Json_JsonSerializer_"></a> ReadJson\(JsonReader, Type, Vector2, bool, JsonSerializer\)

Reads the JSON representation of the object.

```csharp
public override Vector2 ReadJson(JsonReader reader, Type objectType, Vector2 existingValue, bool hasExistingValue, JsonSerializer serializer)
```

#### Parameters

`reader` JsonReader

The <xref href="Newtonsoft.Json.JsonReader" data-throw-if-not-resolved="false"></xref> to read from.

`objectType` [Type](https://learn.microsoft.com/dotnet/api/system.type)

Type of the object.

`existingValue` Vector2

The existing value of object being read. If there is no existing value then <code>null</code> will be used.

`hasExistingValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

The existing value has a value.

`serializer` JsonSerializer

The calling serializer.

#### Returns

 Vector2

The object value.

### <a id="osu_Framework_IO_Serialization_Vector2Converter_WriteJson_Newtonsoft_Json_JsonWriter_osuTK_Vector2_Newtonsoft_Json_JsonSerializer_"></a> WriteJson\(JsonWriter, Vector2, JsonSerializer\)

Writes the JSON representation of the object.

```csharp
public override void WriteJson(JsonWriter writer, Vector2 value, JsonSerializer serializer)
```

#### Parameters

`writer` JsonWriter

The <xref href="Newtonsoft.Json.JsonWriter" data-throw-if-not-resolved="false"></xref> to write to.

`value` Vector2

The value.

`serializer` JsonSerializer

The calling serializer.

