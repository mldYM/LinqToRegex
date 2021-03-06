# Patterns\.GraveAccent Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GraveAccent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GraveAccent) | Returns a pattern that matches a grave accent\. |
| [GraveAccent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GraveAccent_System_Int32_) | Returns a pattern that matches a specified number of grave accents\. |

## GraveAccent\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GraveAccent"></a>

\
Returns a pattern that matches a grave accent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern GraveAccent()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## GraveAccent\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GraveAccent_System_Int32_"></a>

\
Returns a pattern that matches a specified number of grave accents\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup GraveAccent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

