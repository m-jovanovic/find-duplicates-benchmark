using BenchmarkDotNet.Attributes;

namespace FindDuplicates;

[MemoryDiagnoser(false)]
public class Benchmark
{
    private static readonly Random Random = new();
    private static IEnumerable<int> _enumerable;
    private static ICollection<int> _collection;

    [Params(100, 1_000, 10_000)]
    public int Size { get; set; }


    [GlobalSetup]
    public void GlobalSetup()
    {
        var index = (int)(Size * 0.41);
       
        _enumerable = Enumerable
            .Range(1, Size)
            .Select((val, i) => i == index ? index : val);
        _collection = _enumerable.ToArray();
    }

    [Benchmark]
    public bool ForeachCollection()
    {
        return ContainsDuplicates.ForEach(_collection);
    }

    [Benchmark]
    public bool LinqAnyCollection()
    {
        return ContainsDuplicates.LinqAny(_collection);
    }

    [Benchmark]
    public bool LinqAllCollection()
    {
        return ContainsDuplicates.LinqAll(_collection);
    }

    [Benchmark]
    public bool LinqDistinctCollection()
    {
        return ContainsDuplicates.LinqDistinct(_collection);
    }

    [Benchmark]
    public bool ToHashSetCollection()
    {
        return ContainsDuplicates.ToHashSet(_collection);
    }

    [Benchmark]
    public bool ForeachEnumerable()
    {
        return ContainsDuplicates.ForEach(_enumerable);
    }

    [Benchmark]
    public bool LinqAnyEnumerable()
    {
        return ContainsDuplicates.LinqAny(_enumerable);
    }

    [Benchmark]
    public bool LinqAllEnumerable()
    {
        return ContainsDuplicates.LinqAll(_enumerable);
    }

    [Benchmark]
    public bool LinqDistinctEnumerable()
    {
        return ContainsDuplicates.LinqDistinct(_enumerable);
    }

    [Benchmark]
    public bool ToHashSetEnumerable()
    {
        return ContainsDuplicates.ToHashSet(_enumerable);
    }
}