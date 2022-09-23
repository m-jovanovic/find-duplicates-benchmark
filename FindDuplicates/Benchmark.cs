using BenchmarkDotNet.Attributes;

namespace FindDuplicates;

[MemoryDiagnoser(false)]
public class Benchmark
{
    private static readonly Random Random = new();
    private static int[] _collection;

    [Params(100, 1_000, 10_000)]
    public int Size { get; set; }


    [GlobalSetup]
    public void GlobalSetup()
    {
        _collection = Enumerable
            .Range(1, Size)
            .ToArray();

        var index = (int)(Size * 0.41);
        _collection[index] = _collection[index + 1];
    }

    [Benchmark]
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
    public bool ToHashSet()
    {
        return ContainsDuplicates.ToHashSet(_collection);
    }
}