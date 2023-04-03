using BenchmarkDotNet.Attributes;

namespace FindDuplicates;

[MemoryDiagnoser(false)]
[ReturnValueValidator(failOnError: true)]
public class Benchmark
{
    private IEnumerable<int> _enumerable;
    private ICollection<int> _collection;

    [Params(100, 1_000, 10_000)]
    public int Size { get; set; }

    [Params(Location.None, Location.Beginning, Location.FortyOnePercent, Location.End)]
    public Location DuplicateLocation { get; set; }


    [GlobalSetup]
    public void GlobalSetup()
    {
        var duplicateIndex = GetDuplicateIndex();

        _enumerable = duplicateIndex.HasValue
            ? Enumerable
                .Range(1, Size)
                .Select((value, index) => index == duplicateIndex.Value ? index : value)
            : Enumerable
                .Range(1, Size);

        _collection = _enumerable.ToArray();
    }

    [Benchmark(Baseline = true)]
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
    public bool LinqGroupByCollection()
    {
        return ContainsDuplicates.LinqGroupBy(_collection);
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
    public bool LinqGroupByEnumerable()
    {
        return ContainsDuplicates.LinqGroupBy(_enumerable);
    }

    [Benchmark]
    public bool ToHashSetEnumerable()
    {
        return ContainsDuplicates.ToHashSet(_enumerable);
    }

    private int? GetDuplicateIndex() => DuplicateLocation switch
    {
        Location.None => default,
        Location.Beginning => 1,
        Location.FortyOnePercent => (int)(Size * 0.41),
        Location.End => Size - 1,
        _ => throw new NotSupportedException("Location is not supported")
    };
}