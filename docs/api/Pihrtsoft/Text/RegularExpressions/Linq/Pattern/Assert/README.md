# Pattern\.Assert Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Assert(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Assert_System_Object_) | Appends a zero\-width positive lookahead assertion with a specified content to be matched\. |
| [Assert(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Assert_System_Object___) | Appends a zero\-width positive lookahead assertion that matches any one pattern specified in the object array\. |

## Assert\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Assert_System_Object_"></a>

\
Appends a zero\-width positive lookahead assertion with a specified content to be matched\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Assert(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Assert\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Assert_System_Object___"></a>

\
Appends a zero\-width positive lookahead assertion that matches any one pattern specified in the object array\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Assert(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

