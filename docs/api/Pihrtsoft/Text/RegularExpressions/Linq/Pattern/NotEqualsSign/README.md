# Pattern\.NotEqualsSign Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotEqualsSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotEqualsSign) | Appends a pattern that matches a character that is not an equals sign\. |
| [NotEqualsSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotEqualsSign_System_Int32_) | Appends a pattern that matches a specified number of characters that are not an equals sign\. |

## NotEqualsSign\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotEqualsSign"></a>

\
Appends a pattern that matches a character that is not an equals sign\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotEqualsSign()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotEqualsSign\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotEqualsSign_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not an equals sign\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotEqualsSign(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

