# Patterns\.NotPercent Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotPercent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent) | Returns a pattern that matches a character that is not a percent\. |
| [NotPercent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a percent\. |

## NotPercent\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent"></a>

\
Returns a pattern that matches a character that is not a percent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotPercent()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotPercent\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a percent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotPercent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

