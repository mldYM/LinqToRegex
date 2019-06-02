# Pattern\.NotExclamationMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotExclamationMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotExclamationMark) | Appends a pattern that matches a character that is not an exclamation mark\. |
| [NotExclamationMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotExclamationMark_System_Int32_) | Appends a pattern that matches a specified number of characters that are not an exclamation mark\. |

## NotExclamationMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotExclamationMark"></a>

### Summary

Appends a pattern that matches a character that is not an exclamation mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotExclamationMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotExclamationMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotExclamationMark_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not an exclamation mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotExclamationMark(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.
