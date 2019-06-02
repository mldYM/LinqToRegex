# Patterns\.Not\<TPattern>\(INegateable\<TPattern>\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that is a negation of the specified pattern\.

```csharp
public static TPattern Not<TPattern>(Pihrtsoft.Text.RegularExpressions.Linq.INegateable<TPattern> value) where TPattern : Pihrtsoft.Text.RegularExpressions.Linq.Pattern
```

### Type Parameters

**TPattern**

The type of the pattern\.

### Parameters

**value** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[INegateable](../../INegateable-1/README.md)\<TPattern>

A pattern to be negated\.

### Returns

TPattern

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.
