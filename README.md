# Find Duplicates Benchmark

Benchmark showcasing 5 ways to check if a collection contains a duplicate element

``` ini

BenchmarkDotNet=v0.13.2, OS=ubuntu 20.04
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                 Method |  Size |         Mean |       Error |      StdDev |       Median | Allocated |
|----------------------- |------ |-------------:|------------:|------------:|-------------:|----------:|
|      **ForeachCollection** |   **100** |     **874.7 ns** |    **17.03 ns** |    **18.22 ns** |     **870.5 ns** |   **2.76 KB** |
|      LinqAnyCollection |   100 |     932.7 ns |     7.92 ns |     6.19 ns |     932.5 ns |   2.84 KB |
|      LinqAllCollection |   100 |     940.8 ns |     8.91 ns |     7.44 ns |     941.6 ns |   2.82 KB |
| LinqDistinctCollection |   100 |   1,023.2 ns |    17.11 ns |    29.05 ns |   1,014.7 ns |   1.88 KB |
|    ToHashSetCollection |   100 |     966.8 ns |    18.96 ns |    21.83 ns |     959.2 ns |   1.82 KB |
|      ForeachEnumerable |   100 |   1,171.9 ns |    23.27 ns |    20.63 ns |   1,174.7 ns |   2.84 KB |
|      LinqAnyEnumerable |   100 |   1,280.6 ns |    21.25 ns |    19.88 ns |   1,275.3 ns |   2.92 KB |
|      LinqAllEnumerable |   100 |   1,278.4 ns |    15.12 ns |    13.40 ns |   1,274.7 ns |    2.9 KB |
| LinqDistinctEnumerable |   100 |   3,231.9 ns |    41.45 ns |    36.75 ns |   3,229.1 ns |   6.14 KB |
|    ToHashSetEnumerable |   100 |   3,161.9 ns |    24.33 ns |    22.76 ns |   3,166.3 ns |   6.08 KB |
|      **ForeachCollection** |  **1000** |   **4,976.9 ns** |    **58.51 ns** |    **48.86 ns** |   **4,974.9 ns** |  **12.68 KB** |
|      LinqAnyCollection |  1000 |   5,642.9 ns |   112.71 ns |   270.06 ns |   5,549.8 ns |  12.77 KB |
|      LinqAllCollection |  1000 |   5,830.8 ns |   116.35 ns |   247.95 ns |   5,769.0 ns |  12.74 KB |
| LinqDistinctCollection |  1000 |   8,655.4 ns |   171.28 ns |   460.13 ns |   8,469.6 ns |  17.45 KB |
|    ToHashSetCollection |  1000 |   8,358.3 ns |   105.10 ns |    98.31 ns |   8,369.5 ns |  17.38 KB |
|      ForeachEnumerable |  1000 |   7,089.3 ns |   140.85 ns |   223.41 ns |   6,971.0 ns |  12.76 KB |
|      LinqAnyEnumerable |  1000 |   7,654.5 ns |    46.78 ns |    41.47 ns |   7,656.3 ns |  12.84 KB |
|      LinqAllEnumerable |  1000 |   7,537.1 ns |    91.35 ns |    85.45 ns |   7,557.9 ns |  12.82 KB |
| LinqDistinctEnumerable |  1000 |  28,020.3 ns |   548.42 ns | 1,385.93 ns |  27,367.5 ns |  57.57 KB |
|    ToHashSetEnumerable |  1000 |  27,034.9 ns |   449.33 ns |   420.31 ns |  26,890.1 ns |  57.51 KB |
|      **ForeachCollection** | **10000** |  **87,038.2 ns** |   **725.55 ns** |   **643.18 ns** |  **86,797.2 ns** | **252.26 KB** |
|      LinqAnyCollection | 10000 |  93,612.4 ns | 1,083.60 ns |   904.86 ns |  93,340.1 ns | 252.35 KB |
|      LinqAllCollection | 10000 |  92,531.2 ns | 1,339.35 ns | 1,118.42 ns |  92,564.2 ns | 252.33 KB |
| LinqDistinctCollection | 10000 | 124,171.0 ns | 1,583.06 ns | 1,480.80 ns | 124,034.3 ns |  158.1 KB |
|    ToHashSetCollection | 10000 | 124,794.4 ns | 1,637.24 ns | 1,451.37 ns | 124,654.4 ns | 158.03 KB |
|      ForeachEnumerable | 10000 | 108,083.5 ns | 1,266.67 ns | 1,184.85 ns | 107,396.2 ns | 252.34 KB |
|      LinqAnyEnumerable | 10000 | 116,679.6 ns | 2,216.55 ns | 2,073.37 ns | 115,920.3 ns | 252.43 KB |
|      LinqAllEnumerable | 10000 | 113,319.7 ns | 1,903.42 ns | 1,589.44 ns | 113,006.3 ns |  252.4 KB |
| LinqDistinctEnumerable | 10000 | 330,037.8 ns | 3,661.80 ns | 2,858.89 ns | 329,934.9 ns | 526.34 KB |
|    ToHashSetEnumerable | 10000 | 334,982.3 ns | 6,349.62 ns | 7,057.59 ns | 333,148.7 ns | 526.28 KB |
