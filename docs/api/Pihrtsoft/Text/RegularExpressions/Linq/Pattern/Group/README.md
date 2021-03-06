# Pattern\.Group Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Group()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Group) | Appends an empty numbered group\. |
| [Group(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Group_System_Object_) | Appends a numbered group with a specified content\. |
| [Group(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Group_System_Object___) | Appends a numbered group with a specified content\. |

## Group\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Group"></a>

\
Appends an empty numbered group\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Group()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Group\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Group_System_Object_"></a>

\
Appends a numbered group with a specified content\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Group(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Group\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Group_System_Object___"></a>

\
Appends a numbered group with a specified content\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Group(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

