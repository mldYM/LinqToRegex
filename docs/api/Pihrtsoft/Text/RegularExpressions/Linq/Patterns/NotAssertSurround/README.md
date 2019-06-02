# Patterns\.NotAssertSurround Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAssertSurround(Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_) | Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\. |
| [NotAssertSurround(Object, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_System_Object_) | Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\. |

## NotAssertSurround\(Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.NegativeSurroundAssertion NotAssertSurround(object assertion, object content)
```

### Parameters

**assertion** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the negative assertions\.

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[NegativeSurroundAssertion](../../NegativeSurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**assertion** **content** is `null`\.

## NotAssertSurround\(Object, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.NegativeSurroundAssertion NotAssertSurround(object backAssertion, object content, object assertion)
```

### Parameters

**backAssertion** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the negative lookbehind assertion\.

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

**assertion** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the negative lookahead assertion\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[NegativeSurroundAssertion](../../NegativeSurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**backAssertion** or **content** or **assertion** is `null`\.
