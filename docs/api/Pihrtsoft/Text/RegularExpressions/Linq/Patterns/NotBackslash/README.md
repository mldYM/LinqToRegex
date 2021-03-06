# Patterns\.NotBackslash Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotBackslash()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotBackslash) | Returns a pattern that matches a character that is not a backslash\. |
| [NotBackslash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotBackslash_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a backslash\. |

## NotBackslash\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotBackslash"></a>

\
Returns a pattern that matches a character that is not a backslash\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotBackslash()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotBackslash\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotBackslash_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a backslash\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotBackslash(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

