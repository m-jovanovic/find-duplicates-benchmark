namespace FindDuplicates;

public static class ContainsDuplicates
{
    public static bool ForEach<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = enumerable.TryGetNonEnumeratedCount(out var count)
            ? new(count)
            : new();

        foreach (var element in enumerable)
        {
            if (!set.Add(element))
            {
                return true;
            }
        }

        return false;
    }

    public static bool LinqAny<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = enumerable.TryGetNonEnumeratedCount(out var count) 
            ? new(count) 
            : new();

        return enumerable.Any(element => !set.Add(element));
    }

    public static bool LinqAll<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = enumerable.TryGetNonEnumeratedCount(out var count)
            ? new(count)
            : new();

        return !enumerable.All(set.Add);
    }

    public static bool LinqDistinct<T>(IEnumerable<T> enumerable)
    {
        // when false, CA1851
        if (!enumerable.TryGetNonEnumeratedCount(out var count))
            count = enumerable.Count();

        return enumerable.Distinct().Count() != count;
    }

    public static bool LinqGroupBy<T>(IEnumerable<T> enumerable)
    {
        return enumerable.GroupBy(element => element)
            .Any(group => group.Count() > 1);
    }

    public static bool ToHashSet<T>(IEnumerable<T> enumerable)
    {
        // when false, CA1851
        if (!enumerable.TryGetNonEnumeratedCount(out var count))
            count = enumerable.Count();

        return enumerable.ToHashSet().Count != count;
    }
}