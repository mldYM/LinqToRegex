# Patterns\.Group Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Group()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Group) | Returns an empty numbered group\. |
| [Group(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Group_System_Object_) | Returns a numbered group with a specified content\. |
| [Group(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Group_System_Object___) | Returns a numbered group with a specified content\. |

## Group\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Group"></a>

\
Returns an empty numbered group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Group()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Group\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Group_System_Object_"></a>

\
Returns a numbered group with a specified content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Group(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Group\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Group_System_Object___"></a>

\
Returns a numbered group with a specified content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Group(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

