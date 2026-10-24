# Task 2.1 — Research: IReadOnlyDictionary and SortedDictionary

## 1. What is IReadOnlyDictionary<TKey, TValue>?

`IReadOnlyDictionary<TKey, TValue>` is an interface that represents a collection of key-value pairs. It allows us to read values using keys, check whether a key exists, and iterate through the collection. It does not provide methods to add or remove items.

## 2. How is IReadOnlyDictionary different from Dictionary?

`Dictionary<TKey, TValue>` is a concrete collection that allows us to add, update, and remove items.

`IReadOnlyDictionary<TKey, TValue>` provides a read-only view of a dictionary. It exposes reading operations without exposing methods for modifying the collection.

A public method can return `IReadOnlyDictionary` instead of `Dictionary` to hide modification operations from the caller. This makes the API easier to use safely and reduces the caller's dependency on a specific collection implementation.

However, it does not guarantee that the underlying data cannot change through another reference.

## 3. What is SortedDictionary<TKey, TValue>?

`SortedDictionary<TKey, TValue>` is a collection of unique keys and their values. It keeps its items sorted by key, using the default comparer or a custom comparer.

When we iterate through it, the items are returned in key order.

## 4. How is SortedDictionary different from Dictionary?

`Dictionary<TKey, TValue>` provides average O(1) lookup by key, but it does not guarantee that items are iterated in sorted key order.

`SortedDictionary<TKey, TValue>` maintains keys in sorted order. Lookup, insertion, and removal generally take O(log n) time.

Therefore, `Dictionary` is usually faster for looking up values by key, while `SortedDictionary` is useful when sorted iteration is required.

## 5. When would you choose SortedDictionary?

I would choose `SortedDictionary` when I need to keep items sorted by their keys while adding, removing, and searching for items.

For example, I could use it to store students by their student IDs and iterate through them in ascending ID order.

If I only need fast lookups and do not need sorted iteration, I would usually choose `Dictionary`.




src
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2?view=net-10.0&utm_source=chatgpt.com
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=net-10.0&utm_source=chatgpt.com



## Task 2.2 — Pick the Collection

- **S1 — Dictionary:** A `Dictionary` provides fast average O(1) lookup by national ID.
- **S2 — HashSet:** A `HashSet` stores unique tags and prevents duplicate values.
- **S3 — List:** A `List` preserves the order in which grades are added and allows duplicate grades.
- **S4 — IReadOnlyDictionary:** It allows callers to read course prices by key without exposing methods to add or remove entries.
- **S5 — SortedDictionary:** It keeps sessions sorted by their start-time keys as sessions are added or removed.
- **S6 — IEnumerable:** It allows the caller to iterate over results and stop early without requiring a specific collection type or loading all results into a collection.