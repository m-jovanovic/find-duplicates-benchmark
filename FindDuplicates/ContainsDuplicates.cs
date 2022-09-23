namespace FindDuplicates;

public static class ContainsDuplicates
{
    public static bool ForEach<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

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
        HashSet<T> set = new();

        return enumerable.Any(element => !set.Add(element));
    }

    public static bool LinqAll<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

        return !enumerable.All(set.Add);
    }

    public static bool LinqDistinct<T>(IEnumerable<T> enumerable)
    {
        return enumerable.Distinct().Count() != enumerable.Count();
    }

    public static bool ToHashSet<T>(IEnumerable<T> enumerable)
    {
        return enumerable.ToHashSet().Count != enumerable.Count();
    }
}