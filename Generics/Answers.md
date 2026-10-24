
## Step 2 — A store for courses

### What is the same?

Both StudentStore and CourseStore use a List to store objects.
Both have the same four methods: Add, GetById, GetAll, and Remove.
Both search for an item by its Id and return null if it is not found.

### What is different?

StudentStore stores Student objects, which have Id and Name.
CourseStore stores Course objects, which have Id, Title, and Price.

The logic of the two stores is almost identical, but the types
and the data properties are different.





## Step 3 — One class for both

### Compiler error

'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)
### Explanation

The compiler rejects `item.Id` because T can represent any type.
The compiler does not know that every type used with Store<T>
has an Id property.

Student and Course have an Id property, but other types such as
string and int do not. We need to tell the compiler that T must
provide an Id property before we can access it.



## Step 5 — Make it fast and safe

### Why Dictionary?

I replaced List<T> with Dictionary<int, T>, using each item's Id as the key.
This allows GetById to use TryGetValue instead of looping through all items.
Dictionary lookup is O(1) on average.

### Duplicate IDs

Add uses TryAdd. If the ID already exists, it throws an InvalidOperationException
with a clear error message. This prevents duplicate IDs.

### GetAll return type

GetAll returns IReadOnlyCollection<T>. The caller can enumerate and read
the collection but cannot add or remove items through this interface.
The returned Dictionary value collection also does not support adding or
removing items.



## Step 7 — Prove it in Main

### Why does Store<string> not compile?

Store<T> has the constraint where T : IHasId.
This means every type used with Store<T> must implement IHasId.

Student and Course implement IHasId, but string does not.
Therefore, Store<string> violates the generic constraint and the compiler rejects it.

### What is the common name for the kind of class built in Steps 4 and 5?

It is called a generic repository or repository-like class.
It provides common operations to store, retrieve, and remove objects
without writing a separate store class for each type.
