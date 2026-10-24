# Research: Extension Members in C#

Extension methods allow developers to add callable functionality to an existing type without changing that type's source code.

## Example

```csharp
public static class StringExtensions
{
    public static bool IsLongerThan(this string value, int length)
    {
        return value.Length > length;
    }
}

// Usage
string name = "Kerolos";
Console.WriteLine(name.IsLongerThan(5)); // True
```

## Benefits
- Reuse functionality with existing types.
- Keep helper methods organized.
- Use readable instance-style calls.

Traditional extension methods are declared inside static classes. C# 14 introduces broader extension-member syntax for additional kinds of members.

## Sources
- https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/extension-members
- https://devblogs.microsoft.com/dotnet/csharp-exploring-extension-members/