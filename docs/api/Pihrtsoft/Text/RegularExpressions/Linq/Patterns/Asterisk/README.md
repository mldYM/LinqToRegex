# Patterns\.Asterisk Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Asterisk()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Asterisk) | Returns a pattern that matches an asterisk\. |
| [Asterisk(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Asterisk_System_Int32_) | Returns a pattern that matches a specified number of asterisks\. |

## Asterisk\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Asterisk"></a>

\
Returns a pattern that matches an asterisk\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Asterisk()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Asterisk\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Asterisk_System_Int32_"></a>

\
Returns a pattern that matches a specified number of asterisks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Asterisk(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

