# Research: Span<T> in C#

`Span<T>` provides a view over a contiguous region of memory. It can access part of an existing array without creating a new array for the selected elements.

## Benefits
- Reduces unnecessary allocations in suitable scenarios.
- Provides efficient access to sections of memory.
- Can be useful when parsing or processing data.

## Example

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
Span<int> middle = numbers.AsSpan(1, 3);
middle[0] = 99;

Console.WriteLine(numbers[1]); // 99
```

The output is `99` because the span refers to the original array.

## Limitation

`Span<T>` is a `ref struct` and has restrictions on how it can be stored and used, particularly across asynchronous suspension points.

## Sources
- https://learn.microsoft.com/en-us/dotnet/standard/memory-and-spans/
- https://learn.microsoft.com/en-us/archive/msdn-magazine/2017/connect/csharp-all-about-span-exploring-a-new-net-mainstay