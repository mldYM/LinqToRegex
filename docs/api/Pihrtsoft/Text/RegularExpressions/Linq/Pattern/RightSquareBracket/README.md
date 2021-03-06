# Pattern\.RightSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightSquareBracket) | Appends a pattern that matches a right square bracket\. |
| [RightSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightSquareBracket_System_Int32_) | Appends a pattern that matches a specified number of right square brackets\. |

## RightSquareBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightSquareBracket"></a>

\
Appends a pattern that matches a right square bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern RightSquareBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## RightSquareBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightSquareBracket_System_Int32_"></a>

\
Appends a pattern that matches a specified number of right square brackets\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup RightSquareBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

