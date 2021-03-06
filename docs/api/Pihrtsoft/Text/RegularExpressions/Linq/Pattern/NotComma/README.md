# Pattern\.NotComma Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotComma()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotComma) | Appends a pattern that matches a character that is not a comma\. |
| [NotComma(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotComma_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a comma\. |

## NotComma\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotComma"></a>

\
Appends a pattern that matches a character that is not a comma\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotComma()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotComma\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotComma_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a comma\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotComma(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

