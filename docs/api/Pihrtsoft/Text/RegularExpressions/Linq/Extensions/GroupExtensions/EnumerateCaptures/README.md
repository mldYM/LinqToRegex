# GroupExtensions\.EnumerateCaptures\(Group\) Method

[Home](../../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.Extensions\.[GroupExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns enumerable collection of captures of a specified group\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(this System.Text.RegularExpressions.Group group)
```

### Parameters

**group** &emsp; System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)

A regular expression group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**group** is `null`\.
