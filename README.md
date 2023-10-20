# Find Duplicates Benchmark

Benchmark showcasing 6 ways to check if a collection contains a duplicate element

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.2283)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2


```
|       Method |  Size | DuplicateLocation | CollectionType |          Mean |         Error |        StdDev |        Median |     Ratio | RatioSD | Allocated | Alloc Ratio |
|------------- |------ |------------------ |--------------- |--------------:|--------------:|--------------:|--------------:|----------:|--------:|----------:|------------:|
|      **Foreach** |   **100** |              **None** |          **Array** |     **509.29 ns** |      **7.411 ns** |      **6.188 ns** |     **509.99 ns** |      **1.00** |    **0.00** |    **1864 B** |        **1.00** |
|      LinqAny |   100 |              None |          Array |     630.51 ns |      8.572 ns |      7.599 ns |     629.13 ns |      1.24 |    0.03 |    1952 B |        1.05 |
|      LinqAll |   100 |              None |          Array |     560.42 ns |      4.827 ns |      4.031 ns |     560.47 ns |      1.10 |    0.02 |    1928 B |        1.03 |
| LinqDistinct |   100 |              None |          Array |     525.37 ns |     10.210 ns |     10.485 ns |     528.53 ns |      1.03 |    0.03 |    1928 B |        1.03 |
|  LinqGroupBy |   100 |              None |          Array |   2,544.85 ns |     47.961 ns |     53.308 ns |   2,559.89 ns |      4.96 |    0.13 |   11032 B |        5.92 |
|    ToHashSet |   100 |              None |          Array |     536.66 ns |      6.946 ns |      6.497 ns |     537.17 ns |      1.05 |    0.02 |    1864 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |              **None** |     **Enumerable** |   **1,195.92 ns** |     **23.780 ns** |     **46.382 ns** |   **1,176.30 ns** |      **1.00** |    **0.00** |    **6112 B** |        **1.00** |
|      LinqAny |   100 |              None |     Enumerable |   1,237.36 ns |     13.536 ns |     11.999 ns |   1,238.64 ns |      0.98 |    0.02 |    6200 B |        1.01 |
|      LinqAll |   100 |              None |     Enumerable |   1,163.70 ns |     16.393 ns |     15.334 ns |   1,161.57 ns |      0.93 |    0.02 |    6176 B |        1.01 |
| LinqDistinct |   100 |              None |     Enumerable |   1,531.50 ns |     18.042 ns |     15.994 ns |   1,531.16 ns |      1.21 |    0.02 |    6288 B |        1.03 |
|  LinqGroupBy |   100 |              None |     Enumerable |   2,707.20 ns |     29.221 ns |     27.333 ns |   2,702.41 ns |      2.15 |    0.06 |   11112 B |        1.82 |
|    ToHashSet |   100 |              None |     Enumerable |   1,497.04 ns |     14.213 ns |     13.295 ns |   1,494.99 ns |      1.19 |    0.03 |    6224 B |        1.02 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |         **Beginning** |          **Array** |      **76.41 ns** |      **1.600 ns** |      **1.497 ns** |      **76.96 ns** |      **1.00** |    **0.00** |    **1864 B** |        **1.00** |
|      LinqAny |   100 |         Beginning |          Array |      83.10 ns |      1.405 ns |      1.314 ns |      82.66 ns |      1.09 |    0.03 |    1952 B |        1.05 |
|      LinqAll |   100 |         Beginning |          Array |      78.97 ns |      1.577 ns |      1.619 ns |      79.02 ns |      1.04 |    0.02 |    1928 B |        1.03 |
| LinqDistinct |   100 |         Beginning |          Array |     499.30 ns |      9.493 ns |      8.880 ns |     498.92 ns |      6.54 |    0.17 |    1928 B |        1.03 |
|  LinqGroupBy |   100 |         Beginning |          Array |   1,838.40 ns |     31.122 ns |     47.527 ns |   1,821.41 ns |     24.43 |    0.78 |   10976 B |        5.89 |
|    ToHashSet |   100 |         Beginning |          Array |     495.64 ns |      4.430 ns |      3.927 ns |     495.16 ns |      6.49 |    0.11 |    1864 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |         **Beginning** |     **Enumerable** |      **41.34 ns** |      **0.677 ns** |      **0.633 ns** |      **41.21 ns** |      **1.00** |    **0.00** |     **280 B** |        **1.00** |
|      LinqAny |   100 |         Beginning |     Enumerable |      49.12 ns |      0.482 ns |      0.451 ns |      49.30 ns |      1.19 |    0.02 |     368 B |        1.31 |
|      LinqAll |   100 |         Beginning |     Enumerable |      45.40 ns |      0.398 ns |      0.352 ns |      45.33 ns |      1.10 |    0.02 |     344 B |        1.23 |
| LinqDistinct |   100 |         Beginning |     Enumerable |   1,576.97 ns |     31.569 ns |     31.005 ns |   1,578.58 ns |     38.13 |    0.75 |    6288 B |       22.46 |
|  LinqGroupBy |   100 |         Beginning |     Enumerable |   2,049.56 ns |     39.167 ns |     41.908 ns |   2,053.40 ns |     49.51 |    1.44 |   11056 B |       39.49 |
|    ToHashSet |   100 |         Beginning |     Enumerable |   1,532.25 ns |     14.659 ns |     12.241 ns |   1,532.09 ns |     37.08 |    0.46 |    6224 B |       22.23 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |   **FortyOnePercent** |          **Array** |     **276.12 ns** |      **5.458 ns** |      **7.287 ns** |     **275.99 ns** |      **1.00** |    **0.00** |    **1864 B** |        **1.00** |
|      LinqAny |   100 |   FortyOnePercent |          Array |     305.24 ns |      5.211 ns |      4.875 ns |     303.35 ns |      1.11 |    0.05 |    1952 B |        1.05 |
|      LinqAll |   100 |   FortyOnePercent |          Array |     281.73 ns |      5.446 ns |      5.827 ns |     282.57 ns |      1.02 |    0.03 |    1928 B |        1.03 |
| LinqDistinct |   100 |   FortyOnePercent |          Array |     518.60 ns |      9.814 ns |     10.078 ns |     516.67 ns |      1.87 |    0.06 |    1928 B |        1.03 |
|  LinqGroupBy |   100 |   FortyOnePercent |          Array |   2,157.15 ns |     22.612 ns |     21.152 ns |   2,157.48 ns |      7.81 |    0.25 |   10976 B |        5.89 |
|    ToHashSet |   100 |   FortyOnePercent |          Array |     529.03 ns |      6.473 ns |      5.738 ns |     529.83 ns |      1.92 |    0.06 |    1864 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |   **FortyOnePercent** |     **Enumerable** |     **592.29 ns** |      **7.031 ns** |      **6.577 ns** |     **592.38 ns** |      **1.00** |    **0.00** |    **2904 B** |        **1.00** |
|      LinqAny |   100 |   FortyOnePercent |     Enumerable |     606.11 ns |     12.119 ns |     15.327 ns |     603.99 ns |      1.02 |    0.03 |    2992 B |        1.03 |
|      LinqAll |   100 |   FortyOnePercent |     Enumerable |     578.34 ns |      6.970 ns |      6.520 ns |     576.95 ns |      0.98 |    0.01 |    2968 B |        1.02 |
| LinqDistinct |   100 |   FortyOnePercent |     Enumerable |   1,612.72 ns |     22.169 ns |     20.737 ns |   1,620.28 ns |      2.72 |    0.06 |    6288 B |        2.17 |
|  LinqGroupBy |   100 |   FortyOnePercent |     Enumerable |   2,385.22 ns |     29.971 ns |     26.568 ns |   2,382.86 ns |      4.03 |    0.05 |   11056 B |        3.81 |
|    ToHashSet |   100 |   FortyOnePercent |     Enumerable |   1,549.72 ns |     22.578 ns |     21.120 ns |   1,546.13 ns |      2.62 |    0.04 |    6224 B |        2.14 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |               **End** |          **Array** |     **498.11 ns** |      **5.510 ns** |      **5.154 ns** |     **498.17 ns** |      **1.00** |    **0.00** |    **1864 B** |        **1.00** |
|      LinqAny |   100 |               End |          Array |     612.99 ns |      6.269 ns |      5.557 ns |     614.90 ns |      1.23 |    0.02 |    1952 B |        1.05 |
|      LinqAll |   100 |               End |          Array |     535.88 ns |      9.518 ns |      8.903 ns |     534.57 ns |      1.08 |    0.02 |    1928 B |        1.03 |
| LinqDistinct |   100 |               End |          Array |     514.97 ns |      9.633 ns |      9.461 ns |     512.04 ns |      1.03 |    0.02 |    1928 B |        1.03 |
|  LinqGroupBy |   100 |               End |          Array |   2,474.43 ns |     41.298 ns |     36.610 ns |   2,481.73 ns |      4.96 |    0.08 |   10976 B |        5.89 |
|    ToHashSet |   100 |               End |          Array |     513.28 ns |      9.078 ns |     10.455 ns |     510.85 ns |      1.03 |    0.02 |    1864 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |   **100** |               **End** |     **Enumerable** |   **1,282.55 ns** |     **25.276 ns** |     **27.045 ns** |   **1,276.39 ns** |      **1.00** |    **0.00** |    **6112 B** |        **1.00** |
|      LinqAny |   100 |               End |     Enumerable |   1,332.67 ns |     17.776 ns |     16.628 ns |   1,334.75 ns |      1.04 |    0.02 |    6200 B |        1.01 |
|      LinqAll |   100 |               End |     Enumerable |   1,228.58 ns |     24.457 ns |     28.164 ns |   1,222.28 ns |      0.96 |    0.03 |    6176 B |        1.01 |
| LinqDistinct |   100 |               End |     Enumerable |   1,588.08 ns |     30.178 ns |     28.229 ns |   1,588.76 ns |      1.23 |    0.02 |    6288 B |        1.03 |
|  LinqGroupBy |   100 |               End |     Enumerable |   2,787.90 ns |     47.981 ns |     44.881 ns |   2,779.52 ns |      2.17 |    0.05 |   11056 B |        1.81 |
|    ToHashSet |   100 |               End |     Enumerable |   1,581.83 ns |     16.809 ns |     15.723 ns |   1,582.29 ns |      1.23 |    0.03 |    6224 B |        1.02 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |              **None** |          **Array** |   **4,695.82 ns** |     **71.926 ns** |     **63.761 ns** |   **4,713.15 ns** |      **1.00** |    **0.00** |   **17800 B** |        **1.00** |
|      LinqAny |  1000 |              None |          Array |   5,900.21 ns |     44.162 ns |     41.309 ns |   5,897.83 ns |      1.26 |    0.02 |   17888 B |        1.00 |
|      LinqAll |  1000 |              None |          Array |   5,070.21 ns |     63.098 ns |     55.935 ns |   5,086.93 ns |      1.08 |    0.01 |   17864 B |        1.00 |
| LinqDistinct |  1000 |              None |          Array |   4,734.70 ns |     77.549 ns |     72.540 ns |   4,723.59 ns |      1.01 |    0.02 |   17864 B |        1.00 |
|  LinqGroupBy |  1000 |              None |          Array |  23,379.78 ns |    247.116 ns |    219.062 ns |  23,452.48 ns |      4.98 |    0.08 |  104616 B |        5.88 |
|    ToHashSet |  1000 |              None |          Array |   4,668.11 ns |     90.684 ns |    111.368 ns |   4,681.69 ns |      0.99 |    0.02 |   17800 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |              **None** |     **Enumerable** |  **10,369.32 ns** |    **123.794 ns** |    **115.797 ns** |  **10,372.60 ns** |      **1.00** |    **0.00** |   **58776 B** |        **1.00** |
|      LinqAny |  1000 |              None |     Enumerable |  11,117.63 ns |    143.456 ns |    134.189 ns |  11,168.39 ns |      1.07 |    0.01 |   58864 B |        1.00 |
|      LinqAll |  1000 |              None |     Enumerable |  10,363.67 ns |    157.114 ns |    146.965 ns |  10,348.99 ns |      1.00 |    0.02 |   58840 B |        1.00 |
| LinqDistinct |  1000 |              None |     Enumerable |  13,552.33 ns |    199.926 ns |    166.947 ns |  13,580.69 ns |      1.31 |    0.02 |   58952 B |        1.00 |
|  LinqGroupBy |  1000 |              None |     Enumerable |  24,873.57 ns |    395.700 ns |    370.138 ns |  24,767.11 ns |      2.40 |    0.04 |  104696 B |        1.78 |
|    ToHashSet |  1000 |              None |     Enumerable |  13,171.53 ns |    135.057 ns |    126.332 ns |  13,141.87 ns |      1.27 |    0.02 |   58888 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |         **Beginning** |          **Array** |     **521.27 ns** |      **6.899 ns** |      **6.453 ns** |     **521.15 ns** |      **1.00** |    **0.00** |   **17800 B** |        **1.00** |
|      LinqAny |  1000 |         Beginning |          Array |     530.60 ns |      8.946 ns |      8.368 ns |     531.77 ns |      1.02 |    0.01 |   17888 B |        1.00 |
|      LinqAll |  1000 |         Beginning |          Array |     530.03 ns |     10.094 ns |      9.442 ns |     529.91 ns |      1.02 |    0.02 |   17864 B |        1.00 |
| LinqDistinct |  1000 |         Beginning |          Array |   4,638.04 ns |     20.007 ns |     16.707 ns |   4,646.49 ns |      8.90 |    0.12 |   17864 B |        1.00 |
|  LinqGroupBy |  1000 |         Beginning |          Array |  17,444.32 ns |    174.822 ns |    163.528 ns |  17,407.64 ns |     33.47 |    0.43 |  104560 B |        5.87 |
|    ToHashSet |  1000 |         Beginning |          Array |   4,632.13 ns |     38.545 ns |     32.187 ns |   4,639.58 ns |      8.89 |    0.12 |   17800 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |         **Beginning** |     **Enumerable** |      **41.51 ns** |      **0.762 ns** |      **0.712 ns** |      **41.73 ns** |      **1.00** |    **0.00** |     **280 B** |        **1.00** |
|      LinqAny |  1000 |         Beginning |     Enumerable |      47.99 ns |      0.945 ns |      0.928 ns |      48.00 ns |      1.16 |    0.03 |     368 B |        1.31 |
|      LinqAll |  1000 |         Beginning |     Enumerable |      46.41 ns |      0.446 ns |      0.395 ns |      46.44 ns |      1.12 |    0.03 |     344 B |        1.23 |
| LinqDistinct |  1000 |         Beginning |     Enumerable |  13,578.13 ns |    106.116 ns |     99.261 ns |  13,565.01 ns |    327.17 |    4.39 |   58952 B |      210.54 |
|  LinqGroupBy |  1000 |         Beginning |     Enumerable |  19,639.96 ns |    223.485 ns |    209.048 ns |  19,635.02 ns |    473.31 |   11.39 |  104640 B |      373.71 |
|    ToHashSet |  1000 |         Beginning |     Enumerable |  14,183.79 ns |    212.563 ns |    188.432 ns |  14,244.92 ns |    341.93 |    5.84 |   58888 B |      210.31 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |   **FortyOnePercent** |          **Array** |   **2,639.49 ns** |     **52.208 ns** |    **106.648 ns** |   **2,644.74 ns** |      **1.00** |    **0.00** |   **17800 B** |        **1.00** |
|      LinqAny |  1000 |   FortyOnePercent |          Array |   2,871.67 ns |     37.329 ns |     33.091 ns |   2,871.95 ns |      1.11 |    0.07 |   17888 B |        1.00 |
|      LinqAll |  1000 |   FortyOnePercent |          Array |   2,509.79 ns |     41.744 ns |     39.047 ns |   2,498.08 ns |      0.97 |    0.06 |   17864 B |        1.00 |
| LinqDistinct |  1000 |   FortyOnePercent |          Array |   5,078.23 ns |    110.681 ns |    322.860 ns |   4,944.50 ns |      2.01 |    0.14 |   17864 B |        1.00 |
|  LinqGroupBy |  1000 |   FortyOnePercent |          Array |  20,094.32 ns |    206.098 ns |    192.784 ns |  20,043.43 ns |      7.76 |    0.38 |  104560 B |        5.87 |
|    ToHashSet |  1000 |   FortyOnePercent |          Array |   4,760.18 ns |     54.574 ns |     51.049 ns |   4,749.52 ns |      1.84 |    0.11 |   17800 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |   **FortyOnePercent** |     **Enumerable** |   **3,739.15 ns** |     **38.894 ns** |     **36.381 ns** |   **3,742.16 ns** |      **1.00** |    **0.00** |   **13064 B** |        **1.00** |
|      LinqAny |  1000 |   FortyOnePercent |     Enumerable |   4,058.53 ns |     41.469 ns |     38.790 ns |   4,045.93 ns |      1.09 |    0.02 |   13152 B |        1.01 |
|      LinqAll |  1000 |   FortyOnePercent |     Enumerable |   3,768.74 ns |     32.094 ns |     30.021 ns |   3,765.82 ns |      1.01 |    0.01 |   13128 B |        1.00 |
| LinqDistinct |  1000 |   FortyOnePercent |     Enumerable |  13,799.60 ns |    133.805 ns |    125.161 ns |  13,800.78 ns |      3.69 |    0.06 |   58952 B |        4.51 |
|  LinqGroupBy |  1000 |   FortyOnePercent |     Enumerable |  21,069.78 ns |    184.656 ns |    172.728 ns |  21,103.02 ns |      5.64 |    0.08 |  104640 B |        8.01 |
|    ToHashSet |  1000 |   FortyOnePercent |     Enumerable |  13,530.68 ns |     72.890 ns |     68.181 ns |  13,523.89 ns |      3.62 |    0.03 |   58888 B |        4.51 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |               **End** |          **Array** |   **4,671.53 ns** |     **57.754 ns** |     **51.197 ns** |   **4,673.27 ns** |      **1.00** |    **0.00** |   **17800 B** |        **1.00** |
|      LinqAny |  1000 |               End |          Array |   5,996.29 ns |     76.885 ns |     71.919 ns |   6,003.00 ns |      1.28 |    0.02 |   17888 B |        1.00 |
|      LinqAll |  1000 |               End |          Array |   5,104.82 ns |     75.458 ns |     70.584 ns |   5,095.29 ns |      1.09 |    0.02 |   17864 B |        1.00 |
| LinqDistinct |  1000 |               End |          Array |   4,685.45 ns |     89.351 ns |     95.605 ns |   4,674.33 ns |      1.00 |    0.02 |   17864 B |        1.00 |
|  LinqGroupBy |  1000 |               End |          Array |  23,665.84 ns |    329.299 ns |    308.027 ns |  23,651.97 ns |      5.07 |    0.08 |  104560 B |        5.87 |
|    ToHashSet |  1000 |               End |          Array |   4,738.79 ns |     51.363 ns |     48.045 ns |   4,736.95 ns |      1.01 |    0.02 |   17800 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** |  **1000** |               **End** |     **Enumerable** |  **10,395.77 ns** |    **120.868 ns** |    **113.060 ns** |  **10,385.32 ns** |      **1.00** |    **0.00** |   **58776 B** |        **1.00** |
|      LinqAny |  1000 |               End |     Enumerable |  11,207.78 ns |    147.704 ns |    130.936 ns |  11,205.08 ns |      1.08 |    0.01 |   58864 B |        1.00 |
|      LinqAll |  1000 |               End |     Enumerable |  10,450.92 ns |    168.406 ns |    157.527 ns |  10,453.84 ns |      1.01 |    0.02 |   58840 B |        1.00 |
| LinqDistinct |  1000 |               End |     Enumerable |  13,662.70 ns |    151.984 ns |    142.166 ns |  13,634.60 ns |      1.31 |    0.02 |   58952 B |        1.00 |
|  LinqGroupBy |  1000 |               End |     Enumerable |  24,826.40 ns |    129.864 ns |    115.121 ns |  24,819.26 ns |      2.39 |    0.03 |  104640 B |        1.78 |
|    ToHashSet |  1000 |               End |     Enumerable |  13,672.79 ns |     87.873 ns |     82.196 ns |  13,679.70 ns |      1.32 |    0.01 |   58888 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |              **None** |          **Array** |  **69,390.25 ns** |    **656.529 ns** |    **614.118 ns** |  **69,438.68 ns** |      **1.00** |    **0.00** |  **161813 B** |        **1.00** |
|      LinqAny | 10000 |              None |          Array |  80,424.97 ns |    851.736 ns |    711.238 ns |  80,545.40 ns |      1.16 |    0.01 |  161901 B |        1.00 |
|      LinqAll | 10000 |              None |          Array |  73,589.33 ns |  1,130.815 ns |  1,057.765 ns |  73,731.71 ns |      1.06 |    0.02 |  161877 B |        1.00 |
| LinqDistinct | 10000 |              None |          Array |  71,028.81 ns |    829.147 ns |    775.584 ns |  71,029.02 ns |      1.02 |    0.01 |  161877 B |        1.00 |
|  LinqGroupBy | 10000 |              None |          Array | 565,841.67 ns | 11,291.415 ns | 22,550.175 ns | 557,524.61 ns |      8.29 |    0.41 | 1142454 B |        7.06 |
|    ToHashSet | 10000 |              None |          Array |  72,665.45 ns |    757.276 ns |    708.357 ns |  72,711.22 ns |      1.05 |    0.01 |  161813 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |              **None** |     **Enumerable** | **145,382.52 ns** |  **1,077.163 ns** |  **1,007.579 ns** | **145,194.97 ns** |      **1.00** |    **0.00** |  **538768 B** |        **1.00** |
|      LinqAny | 10000 |              None |     Enumerable | 152,204.07 ns |  1,865.139 ns |  1,744.652 ns | 152,304.44 ns |      1.05 |    0.01 |  538856 B |        1.00 |
|      LinqAll | 10000 |              None |     Enumerable | 146,130.62 ns |  1,444.017 ns |  1,280.084 ns | 146,274.48 ns |      1.00 |    0.01 |  538832 B |        1.00 |
| LinqDistinct | 10000 |              None |     Enumerable | 177,543.27 ns |  2,483.727 ns |  2,323.280 ns | 177,703.15 ns |      1.22 |    0.02 |  538944 B |        1.00 |
|  LinqGroupBy | 10000 |              None |     Enumerable | 578,089.15 ns | 10,332.773 ns | 10,148.164 ns | 574,785.84 ns |      3.98 |    0.08 | 1142534 B |        2.12 |
|    ToHashSet | 10000 |              None |     Enumerable | 176,401.25 ns |  1,596.310 ns |  1,493.189 ns | 176,638.67 ns |      1.21 |    0.01 |  538880 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |         **Beginning** |          **Array** |   **5,911.94 ns** |     **67.344 ns** |     **62.993 ns** |   **5,911.37 ns** |      **1.00** |    **0.00** |  **161813 B** |        **1.00** |
|      LinqAny | 10000 |         Beginning |          Array |   5,944.57 ns |     70.752 ns |     66.182 ns |   5,957.92 ns |      1.01 |    0.01 |  161901 B |        1.00 |
|      LinqAll | 10000 |         Beginning |          Array |   5,961.54 ns |     81.933 ns |     76.640 ns |   5,978.02 ns |      1.01 |    0.01 |  161877 B |        1.00 |
| LinqDistinct | 10000 |         Beginning |          Array |  70,611.90 ns |  1,139.780 ns |  1,066.151 ns |  70,673.90 ns |     11.95 |    0.22 |  161877 B |        1.00 |
|  LinqGroupBy | 10000 |         Beginning |          Array | 536,250.27 ns | 10,577.696 ns | 19,867.477 ns | 539,511.47 ns |     91.32 |    3.41 | 1142398 B |        7.06 |
|    ToHashSet | 10000 |         Beginning |          Array |  71,104.55 ns |    462.128 ns |    432.274 ns |  71,082.69 ns |     12.03 |    0.16 |  161813 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |         **Beginning** |     **Enumerable** |      **41.70 ns** |      **0.336 ns** |      **0.315 ns** |      **41.73 ns** |      **1.00** |    **0.00** |     **280 B** |        **1.00** |
|      LinqAny | 10000 |         Beginning |     Enumerable |      48.77 ns |      0.364 ns |      0.323 ns |      48.76 ns |      1.17 |    0.01 |     368 B |        1.31 |
|      LinqAll | 10000 |         Beginning |     Enumerable |      46.39 ns |      0.422 ns |      0.374 ns |      46.32 ns |      1.11 |    0.01 |     344 B |        1.23 |
| LinqDistinct | 10000 |         Beginning |     Enumerable | 173,348.45 ns |  1,639.076 ns |  1,533.193 ns | 173,348.83 ns |  4,156.89 |   43.39 |  538944 B |    1,924.80 |
|  LinqGroupBy | 10000 |         Beginning |     Enumerable | 516,625.19 ns |  9,973.466 ns |  9,795.277 ns | 515,386.87 ns | 12,391.24 |  291.35 | 1142478 B |    4,080.28 |
|    ToHashSet | 10000 |         Beginning |     Enumerable | 179,468.29 ns |  3,498.011 ns |  3,888.030 ns | 179,204.98 ns |  4,322.45 |  114.36 |  538880 B |    1,924.57 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |   **FortyOnePercent** |          **Array** |  **33,703.80 ns** |    **460.392 ns** |    **430.651 ns** |  **33,657.34 ns** |      **1.00** |    **0.00** |  **161813 B** |        **1.00** |
|      LinqAny | 10000 |   FortyOnePercent |          Array |  37,602.12 ns |    468.775 ns |    415.557 ns |  37,451.57 ns |      1.11 |    0.02 |  161901 B |        1.00 |
|      LinqAll | 10000 |   FortyOnePercent |          Array |  35,521.96 ns |    305.069 ns |    254.746 ns |  35,584.62 ns |      1.05 |    0.01 |  161877 B |        1.00 |
| LinqDistinct | 10000 |   FortyOnePercent |          Array |  71,606.63 ns |  1,150.281 ns |  1,075.973 ns |  71,640.28 ns |      2.13 |    0.05 |  161877 B |        1.00 |
|  LinqGroupBy | 10000 |   FortyOnePercent |          Array | 548,037.20 ns | 10,954.127 ns | 21,876.575 ns | 548,118.65 ns |     16.32 |    0.77 | 1142398 B |        7.06 |
|    ToHashSet | 10000 |   FortyOnePercent |          Array |  71,015.45 ns |  1,150.894 ns |  1,076.547 ns |  71,230.09 ns |      2.11 |    0.04 |  161813 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |   **FortyOnePercent** |     **Enumerable** |  **59,400.63 ns** |    **790.747 ns** |    **700.976 ns** |  **59,405.87 ns** |      **1.00** |    **0.00** |  **258386 B** |        **1.00** |
|      LinqAny | 10000 |   FortyOnePercent |     Enumerable |  63,467.14 ns |  1,199.230 ns |  1,121.761 ns |  63,164.76 ns |      1.07 |    0.02 |  258474 B |        1.00 |
|      LinqAll | 10000 |   FortyOnePercent |     Enumerable |  59,756.61 ns |    793.628 ns |    742.360 ns |  59,802.70 ns |      1.01 |    0.02 |  258450 B |        1.00 |
| LinqDistinct | 10000 |   FortyOnePercent |     Enumerable | 175,129.57 ns |  2,220.572 ns |  2,077.124 ns | 174,798.17 ns |      2.95 |    0.05 |  538944 B |        2.09 |
|  LinqGroupBy | 10000 |   FortyOnePercent |     Enumerable | 540,895.51 ns | 10,404.570 ns | 13,158.450 ns | 540,236.72 ns |      9.12 |    0.28 | 1142478 B |        4.42 |
|    ToHashSet | 10000 |   FortyOnePercent |     Enumerable | 178,194.95 ns |  3,440.222 ns |  3,049.667 ns | 177,109.66 ns |      3.00 |    0.06 |  538880 B |        2.09 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |               **End** |          **Array** |  **70,900.92 ns** |    **639.482 ns** |    **566.884 ns** |  **71,098.77 ns** |      **1.00** |    **0.00** |  **161813 B** |        **1.00** |
|      LinqAny | 10000 |               End |          Array |  80,729.85 ns |    759.182 ns |    710.139 ns |  80,874.63 ns |      1.14 |    0.01 |  161901 B |        1.00 |
|      LinqAll | 10000 |               End |          Array |  73,956.99 ns |  1,395.174 ns |  1,305.047 ns |  74,063.27 ns |      1.04 |    0.02 |  161877 B |        1.00 |
| LinqDistinct | 10000 |               End |          Array |  71,398.06 ns |  1,286.936 ns |  1,203.801 ns |  71,178.30 ns |      1.01 |    0.02 |  161877 B |        1.00 |
|  LinqGroupBy | 10000 |               End |          Array | 588,249.86 ns | 11,717.346 ns | 17,537.972 ns | 587,790.14 ns |      8.24 |    0.26 | 1142398 B |        7.06 |
|    ToHashSet | 10000 |               End |          Array |  70,745.33 ns |    716.313 ns |    670.039 ns |  70,782.15 ns |      1.00 |    0.01 |  161813 B |        1.00 |
|              |       |                   |                |               |               |               |               |           |         |           |             |
|      **Foreach** | **10000** |               **End** |     **Enumerable** | **144,571.47 ns** |  **2,324.323 ns** |  **2,174.173 ns** | **144,759.16 ns** |      **1.00** |    **0.00** |  **538768 B** |        **1.00** |
|      LinqAny | 10000 |               End |     Enumerable | 150,326.75 ns |  2,437.770 ns |  2,280.292 ns | 150,122.05 ns |      1.04 |    0.02 |  538856 B |        1.00 |
|      LinqAll | 10000 |               End |     Enumerable | 144,987.69 ns |  1,858.720 ns |  1,738.648 ns | 145,466.09 ns |      1.00 |    0.02 |  538832 B |        1.00 |
| LinqDistinct | 10000 |               End |     Enumerable | 177,692.33 ns |  3,300.151 ns |  3,086.964 ns | 178,458.30 ns |      1.23 |    0.03 |  538944 B |        1.00 |
|  LinqGroupBy | 10000 |               End |     Enumerable | 583,122.53 ns | 10,231.521 ns | 19,217.276 ns | 580,200.44 ns |      4.04 |    0.16 | 1142478 B |        2.12 |
|    ToHashSet | 10000 |               End |     Enumerable | 174,950.47 ns |  2,303.043 ns |  2,154.268 ns | 175,203.49 ns |      1.21 |    0.02 |  538880 B |        1.00 |


## Notes

### TryGetNonEnumeratedCount

Calling the constructor overload for HashSet with the collection size can improve performance and memory efficiency by avoiding unnecessary resizing of the collection at runtime. Resizing a collection involves allocating a new array with a larger capacity and copying the existing elements to the new array. This can be costly in terms of time and space.

### CA1851: Possible multiple enumerations of IEnumerable collection

To detect a duplicate, we compare the distinct count to the enumerable count, which may cause multiple enumerations of the collection.

https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1851

## Contributors

- [@darren-clark](https://github.com/darren-clark)
- [@GeorgeTsiokos](https://github.com/GeorgeTsiokos)
- [@rchoffardet](https://github.com/rchoffardet)
