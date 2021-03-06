# Patterns\.Comma Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Comma()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Comma) | Returns a pattern that matches a comma\. |
| [Comma(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Comma_System_Int32_) | Returns a pattern that matches a specified number of commas\. |

## Comma\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Comma"></a>

\
Returns a pattern that matches a comma\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Comma()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Comma\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Comma_System_Int32_"></a>

\
Returns a pattern that matches a specified number of commas\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Comma(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

