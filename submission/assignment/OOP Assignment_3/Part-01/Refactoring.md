# Research: IReadOnlyDictionary & SortedDictionary

## 1. What is IReadOnlyDictionary<TKey, TValue>?

`IReadOnlyDictionary<TKey, TValue>` is an interface that represents a collection of unique keys and their values. It allows us to read values using keys, check if a key exists, and loop through the collection. It does not provide methods for adding, updating, or removing entries through the interface.

## 2. How is IReadOnlyDictionary different from Dictionary, and why would a public method return one?

`Dictionary<TKey, TValue>` is a concrete collection that allows us to add, update, and remove entries. `IReadOnlyDictionary<TKey, TValue>` exposes only reading operations.

A public method can return `IReadOnlyDictionary` when callers only need to read the data. This hides modification methods, reduces the operations available to callers, and makes the API more flexible because the implementation can be changed later.

However, it does not automatically make the underlying collection immutable. If another part of the program modifies the original dictionary, those changes may still be visible.

## 3. How is SortedDictionary different from Dictionary in ordering and lookup speed?

`Dictionary<TKey, TValue>` uses a hash-based structure and usually provides average O(1) lookup by key. It does not guarantee that entries are enumerated in sorted key order.

`SortedDictionary<TKey, TValue>` keeps entries sorted by key. It uses a binary search tree, so lookup, insertion, and removal take O(log n) time.

Therefore, `Dictionary` is usually faster for looking up keys, while `SortedDictionary` is useful when we need entries to be enumerated in key order.

## 4. When would you choose SortedDictionary?

I would choose `SortedDictionary` when I need to store key/value pairs and always process or display them in sorted key order.

For example, I could use it to store students' results by student ID, configuration settings by name, or events by date when ordered traversal by key is useful.

If I only need fast lookups and do not need sorted keys, I would usually choose `Dictionary` instead.

## Sources

- Microsoft Learn — IReadOnlyDictionary<TKey, TValue>: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2
- Microsoft Learn — SortedDictionary<TKey, TValue>: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2
- Microsoft Learn — ReadOnlyDictionary<TKey, TValue>: https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlydictionary-2