# PatternBuilder\.AppendIfGroup Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendIfGroup(Int32, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_Int32_System_Object_System_Object_) | Appends an if construct\. |
| [AppendIfGroup(String, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_String_System_Object_System_Object_) | Appends an if construct\. |

## AppendIfGroup\(Int32, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_Int32_System_Object_System_Object_"></a>

### Summary

Appends an if construct\.

```csharp
public void AppendIfGroup(int groupNumber, object trueContent, object falseContent)
```

### Parameters

**groupNumber** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

**trueContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the named group is matched\.

**falseContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the named group is not matched\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**trueContent** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## AppendIfGroup\(String, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_String_System_Object_System_Object_"></a>

### Summary

Appends an if construct\.

```csharp
public void AppendIfGroup(string groupName, object trueContent, object falseContent)
```

### Parameters

**groupName** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**trueContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the named group is matched\.

**falseContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the named group is not matched\.

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** or **trueContent** is `null`\.
