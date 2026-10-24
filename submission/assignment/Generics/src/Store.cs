
using Generics.src;
using System;
using System.Collections.Generic;

public class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> items = new Dictionary<int, T>();

    public void Add(T item)
    {
        if (!items.TryAdd(item.Id, item))
        {
            throw new InvalidOperationException(
                $"An item with ID {item.Id} already exists."
            );
        }
    }

    public T? GetById(int id)
    {
        if (items.TryGetValue(id, out T? item))
        {
            return item;
        }

        return default;
    }

    public IReadOnlyCollection<T> GetAll()
    {
        return items.Values;
    }

    public void Remove(int id)
    {
        items.Remove(id);
    }
}
