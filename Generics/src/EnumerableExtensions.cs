
using Generics.src;
using System;
using System.Collections.Generic;

public static class EnumerableExtensions
{
    // R1: Return only the requested page
    public static IEnumerable<T> Page<T>(
        this IEnumerable<T> source,
        int pageNumber,
        int pageSize)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(
                nameof(pageNumber),
                "Page number must be at least 1.");

        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(
                nameof(pageSize),
                "Page size must be at least 1.");

        return PageIterator(source, pageNumber, pageSize);
    }

    private static IEnumerable<T> PageIterator<T>(
        IEnumerable<T> source,
        int pageNumber,
        int pageSize)
    {
        long startIndex = (long)(pageNumber - 1) * pageSize;
        long index = 0;
        int returned = 0;

        foreach (T item in source)
        {
            if (index >= startIndex)
            {
                yield return item;
                returned++;

                if (returned == pageSize)
                    yield break;
            }

            index++;
        }
    }

    // R2: Find an item by its Id
    public static T? FindById<T>(
        this IEnumerable<T> source,
        int id)
        where T : IHasId
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        foreach (T item in source)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }

    // R3: Convert items into a read-only dictionary
    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
        this IEnumerable<T> source)
        where T : IHasId
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        Dictionary<int, T> dictionary = new Dictionary<int, T>();

        foreach (T item in source)
        {
            dictionary.Add(item.Id, item);
        }

        return dictionary;
    }
}
