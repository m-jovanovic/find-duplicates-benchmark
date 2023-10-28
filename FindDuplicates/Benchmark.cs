using BenchmarkDotNet.Attributes;

namespace FindDuplicates;

[MemoryDiagnoser(false)]
[ReturnValueValidator(failOnError: true)]
public class Benchmark
{
    private IEnumerable<int> _collection = null!;

    [Params(100, 1_000, 10_000)]
    public int Size { get; set; }

    [Params(Location.None, Location.Beginning, Location.FortyOnePercent, Location.End)]
    public Location DuplicateLocation { get; set; }

    [Params(CollectionType.Array, CollectionType.Enumerable)]
    public CollectionType CollectionType { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        _collection = GetCollection();
    }

    [Benchmark(Baseline = true)]
    public bool Foreach()
    {
        return ContainsDuplicates.ForEach(_collection);
    }

    [Benchmark]
    public bool LinqAny()
    {
        return ContainsDuplicates.LinqAny(_collection);
    }

    [Benchmark]
    public bool LinqAll()
    {
        return ContainsDuplicates.LinqAll(_collection);
    }

    [Benchmark]
    public bool LinqDistinct()
    {
        return ContainsDuplicates.LinqDistinct(_collection);
    }

    [Benchmark]
    public bool LinqGroupBy()
    {
        return ContainsDuplicates.LinqGroupBy(_collection);
    }

    [Benchmark]
    public bool ToHashSet()
    {
        return ContainsDuplicates.ToHashSet(_collection);
    }

    [Benchmark]
    public bool TwoPointers()
    {
        return ContainsDuplicates.TwoPointers(_collection);
    }

    private int? GetDuplicateIndex() => DuplicateLocation switch
    {
        Location.None => default,
        Location.Beginning => 1,
        Location.FortyOnePercent => (int)(Size * 0.41),
        Location.End => Size - 1,
        _ => throw new NotSupportedException("Location is not supported")
    };

    private IEnumerable<int> GetCollection()
    {
        var duplicateIndex = GetDuplicateIndex();

        var items = duplicateIndex.HasValue
            ? Enumerable
                .Range(1, Size)
                .Select((value, index) => index == duplicateIndex.Value ? index : value)
            : Enumerable
                .Range(1, Size);


        return CollectionType switch
        {
            CollectionType.Array => items.ToArray(),
            CollectionType.Enumerable => items,
            _ => throw new NotSupportedException("CollectionType is not supported")
        };
    }
}