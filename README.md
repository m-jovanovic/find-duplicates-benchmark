# Find Duplicates Benchmark

Benchmark showcasing 6 ways to check if a collection contains a duplicate element

``` ini
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i9-11950H 2.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
```

| Method                 | Size      | DuplicateLocation   |             Mean |            Error |           StdDev |     Ratio |  RatioSD |    Allocated | Alloc Ratio |
| ---------------------- | --------- | ------------------- | ---------------: | ---------------: | ---------------: | --------: | -------: | -----------: | ----------: |
| **ForeachCollection**  | **100**   | **None**            |    **728.76 ns** |     **5.546 ns** |     **5.187 ns** |  **1.00** | **0.00** |   **1864 B** |    **1.00** |
| LinqAnyCollection      | 100       | None                |        805.60 ns |         9.332 ns |         8.729 ns |      1.11 |     0.01 |       1952 B |        1.05 |
| LinqAllCollection      | 100       | None                |        760.15 ns |         6.393 ns |         5.980 ns |      1.04 |     0.01 |       1928 B |        1.03 |
| LinqDistinctCollection | 100       | None                |        711.19 ns |         9.877 ns |         9.239 ns |      0.98 |     0.02 |       1928 B |        1.03 |
| LinqGroupByCollection  | 100       | None                |      3,461.56 ns |        32.235 ns |        28.576 ns |      4.75 |     0.05 |      11032 B |        5.92 |
| ToHashSetCollection    | 100       | None                |        691.46 ns |         5.850 ns |         5.186 ns |      0.95 |     0.01 |       1864 B |        1.00 |
| ForeachEnumerable      | 100       | None                |      1,614.66 ns |        22.186 ns |        20.753 ns |      2.22 |     0.03 |       6112 B |        3.28 |
| LinqAnyEnumerable      | 100       | None                |      1,717.49 ns |        15.986 ns |        14.953 ns |      2.36 |     0.02 |       6200 B |        3.33 |
| LinqAllEnumerable      | 100       | None                |      1,674.47 ns |        20.232 ns |        18.925 ns |      2.30 |     0.03 |       6176 B |        3.31 |
| LinqDistinctEnumerable | 100       | None                |      2,212.13 ns |        25.981 ns |        24.303 ns |      3.04 |     0.04 |       6288 B |        3.37 |
| LinqGroupByEnumerable  | 100       | None                |      3,784.87 ns |        38.417 ns |        34.056 ns |      5.19 |     0.06 |      11112 B |        5.96 |
| ToHashSetEnumerable    | 100       | None                |      2,201.34 ns |        25.654 ns |        23.997 ns |      3.02 |     0.05 |       6224 B |        3.34 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **100**   | **Beginning**       |     **91.67 ns** |     **1.736 ns** |     **1.624 ns** |  **1.00** | **0.00** |   **1864 B** |    **1.00** |
| LinqAnyCollection      | 100       | Beginning           |        101.88 ns |         1.467 ns |         1.372 ns |      1.11 |     0.02 |       1952 B |        1.05 |
| LinqAllCollection      | 100       | Beginning           |        100.56 ns |         1.968 ns |         1.744 ns |      1.10 |     0.03 |       1928 B |        1.03 |
| LinqDistinctCollection | 100       | Beginning           |        720.45 ns |        13.422 ns |        12.555 ns |      7.86 |     0.18 |       1928 B |        1.03 |
| LinqGroupByCollection  | 100       | Beginning           |      2,653.83 ns |        20.327 ns |        16.974 ns |     29.00 |     0.61 |      10976 B |        5.89 |
| ToHashSetCollection    | 100       | Beginning           |        696.03 ns |        11.184 ns |        10.461 ns |      7.60 |     0.19 |       1864 B |        1.00 |
| ForeachEnumerable      | 100       | Beginning           |         60.25 ns |         0.456 ns |         0.405 ns |      0.66 |     0.01 |        280 B |        0.15 |
| LinqAnyEnumerable      | 100       | Beginning           |         70.09 ns |         1.010 ns |         0.945 ns |      0.76 |     0.02 |        368 B |        0.20 |
| LinqAllEnumerable      | 100       | Beginning           |         70.13 ns |         1.401 ns |         1.311 ns |      0.77 |     0.02 |        344 B |        0.18 |
| LinqDistinctEnumerable | 100       | Beginning           |      2,214.45 ns |        22.375 ns |        19.835 ns |     24.15 |     0.48 |       6288 B |        3.37 |
| LinqGroupByEnumerable  | 100       | Beginning           |      2,953.69 ns |        38.794 ns |        36.288 ns |     32.23 |     0.77 |      11056 B |        5.93 |
| ToHashSetEnumerable    | 100       | Beginning           |      2,283.39 ns |        35.413 ns |        33.126 ns |     24.92 |     0.56 |       6224 B |        3.34 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **100**   | **FortyOnePercent** |    **356.43 ns** |     **3.574 ns** |     **3.343 ns** |  **1.00** | **0.00** |   **1864 B** |    **1.00** |
| LinqAnyCollection      | 100       | FortyOnePercent     |        401.00 ns |         4.130 ns |         3.863 ns |      1.13 |     0.01 |       1952 B |        1.05 |
| LinqAllCollection      | 100       | FortyOnePercent     |        383.62 ns |         7.008 ns |         6.556 ns |      1.08 |     0.02 |       1928 B |        1.03 |
| LinqDistinctCollection | 100       | FortyOnePercent     |        716.35 ns |         9.690 ns |         8.092 ns |      2.01 |     0.02 |       1928 B |        1.03 |
| LinqGroupByCollection  | 100       | FortyOnePercent     |      2,854.94 ns |        27.816 ns |        26.019 ns |      8.01 |     0.09 |      10976 B |        5.89 |
| ToHashSetCollection    | 100       | FortyOnePercent     |        710.88 ns |         5.957 ns |         5.572 ns |      1.99 |     0.03 |       1864 B |        1.00 |
| ForeachEnumerable      | 100       | FortyOnePercent     |        743.03 ns |        14.049 ns |        13.142 ns |      2.08 |     0.03 |       2904 B |        1.56 |
| LinqAnyEnumerable      | 100       | FortyOnePercent     |        792.53 ns |         9.787 ns |         9.155 ns |      2.22 |     0.02 |       2992 B |        1.61 |
| LinqAllEnumerable      | 100       | FortyOnePercent     |        799.57 ns |         7.663 ns |         6.793 ns |      2.24 |     0.03 |       2968 B |        1.59 |
| LinqDistinctEnumerable | 100       | FortyOnePercent     |      2,288.78 ns |        21.175 ns |        19.807 ns |      6.42 |     0.08 |       6288 B |        3.37 |
| LinqGroupByEnumerable  | 100       | FortyOnePercent     |      3,398.62 ns |        43.017 ns |        40.238 ns |      9.54 |     0.14 |      11056 B |        5.93 |
| ToHashSetEnumerable    | 100       | FortyOnePercent     |      2,236.50 ns |        36.876 ns |        34.494 ns |      6.28 |     0.12 |       6224 B |        3.34 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **100**   | **End**             |    **718.52 ns** |     **7.584 ns** |     **7.094 ns** |  **1.00** | **0.00** |   **1864 B** |    **1.00** |
| LinqAnyCollection      | 100       | End                 |        803.10 ns |        13.940 ns |        13.040 ns |      1.12 |     0.02 |       1952 B |        1.05 |
| LinqAllCollection      | 100       | End                 |        757.83 ns |         3.566 ns |         3.161 ns |      1.06 |     0.01 |       1928 B |        1.03 |
| LinqDistinctCollection | 100       | End                 |        704.21 ns |         7.443 ns |         6.962 ns |      0.98 |     0.01 |       1928 B |        1.03 |
| LinqGroupByCollection  | 100       | End                 |      3,380.05 ns |        55.403 ns |        51.824 ns |      4.70 |     0.08 |      10976 B |        5.89 |
| ToHashSetCollection    | 100       | End                 |        696.49 ns |         8.856 ns |         8.284 ns |      0.97 |     0.01 |       1864 B |        1.00 |
| ForeachEnumerable      | 100       | End                 |      1,610.49 ns |        10.704 ns |         9.489 ns |      2.24 |     0.03 |       6112 B |        3.28 |
| LinqAnyEnumerable      | 100       | End                 |      1,709.64 ns |        24.197 ns |        22.634 ns |      2.38 |     0.03 |       6200 B |        3.33 |
| LinqAllEnumerable      | 100       | End                 |      1,692.55 ns |        30.752 ns |        28.765 ns |      2.36 |     0.05 |       6176 B |        3.31 |
| LinqDistinctEnumerable | 100       | End                 |      2,263.48 ns |        19.933 ns |        18.645 ns |      3.15 |     0.04 |       6288 B |        3.37 |
| LinqGroupByEnumerable  | 100       | End                 |      3,763.57 ns |        49.616 ns |        46.411 ns |      5.24 |     0.09 |      11056 B |        5.93 |
| ToHashSetEnumerable    | 100       | End                 |      2,257.88 ns |        21.405 ns |        18.975 ns |      3.15 |     0.04 |       6224 B |        3.34 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **1000**  | **None**            |  **6,721.72 ns** |    **70.320 ns** |    **65.778 ns** |  **1.00** | **0.00** |  **17800 B** |    **1.00** |
| LinqAnyCollection      | 1000      | None                |      7,605.59 ns |       115.055 ns |       107.622 ns |      1.13 |     0.02 |      17888 B |        1.00 |
| LinqAllCollection      | 1000      | None                |      6,992.34 ns |        55.749 ns |        52.148 ns |      1.04 |     0.01 |      17864 B |        1.00 |
| LinqDistinctCollection | 1000      | None                |      6,467.82 ns |        67.464 ns |        63.106 ns |      0.96 |     0.01 |      17864 B |        1.00 |
| LinqGroupByCollection  | 1000      | None                |     32,918.73 ns |       527.540 ns |       586.359 ns |      4.89 |     0.11 |     104616 B |        5.88 |
| ToHashSetCollection    | 1000      | None                |      6,459.93 ns |        51.246 ns |        45.429 ns |      0.96 |     0.01 |      17800 B |        1.00 |
| ForeachEnumerable      | 1000      | None                |     14,765.92 ns |       109.026 ns |        96.649 ns |      2.20 |     0.03 |      58776 B |        3.30 |
| LinqAnyEnumerable      | 1000      | None                |     15,608.31 ns |       150.437 ns |       133.359 ns |      2.32 |     0.03 |      58864 B |        3.31 |
| LinqAllEnumerable      | 1000      | None                |     15,877.61 ns |       145.314 ns |       128.817 ns |      2.36 |     0.04 |      58840 B |        3.31 |
| LinqDistinctEnumerable | 1000      | None                |     20,627.36 ns |       337.672 ns |       315.859 ns |      3.07 |     0.06 |      58952 B |        3.31 |
| LinqGroupByEnumerable  | 1000      | None                |     36,276.42 ns |       383.624 ns |       358.842 ns |      5.40 |     0.07 |     104696 B |        5.88 |
| ToHashSetEnumerable    | 1000      | None                |     20,473.26 ns |       202.226 ns |       189.163 ns |      3.05 |     0.04 |      58888 B |        3.31 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **1000**  | **Beginning**       |    **599.03 ns** |    **11.105 ns** |     **9.274 ns** |  **1.00** | **0.00** |  **17800 B** |    **1.00** |
| LinqAnyCollection      | 1000      | Beginning           |        596.36 ns |        11.755 ns |        12.577 ns |      0.99 |     0.03 |      17888 B |        1.00 |
| LinqAllCollection      | 1000      | Beginning           |        593.93 ns |        11.585 ns |        13.342 ns |      0.99 |     0.03 |      17864 B |        1.00 |
| LinqDistinctCollection | 1000      | Beginning           |      6,442.46 ns |        73.585 ns |        68.831 ns |     10.78 |     0.21 |      17864 B |        1.00 |
| LinqGroupByCollection  | 1000      | Beginning           |     23,099.24 ns |       303.098 ns |       283.518 ns |     38.59 |     0.66 |     104560 B |        5.87 |
| ToHashSetCollection    | 1000      | Beginning           |      6,455.51 ns |        65.933 ns |        61.674 ns |     10.80 |     0.17 |      17800 B |        1.00 |
| ForeachEnumerable      | 1000      | Beginning           |         59.59 ns |         0.762 ns |         0.713 ns |      0.10 |     0.00 |        280 B |        0.02 |
| LinqAnyEnumerable      | 1000      | Beginning           |         70.32 ns |         0.886 ns |         0.828 ns |      0.12 |     0.00 |        368 B |        0.02 |
| LinqAllEnumerable      | 1000      | Beginning           |         67.81 ns |         1.074 ns |         1.005 ns |      0.11 |     0.00 |        344 B |        0.02 |
| LinqDistinctEnumerable | 1000      | Beginning           |     20,953.85 ns |       410.931 ns |       384.385 ns |     35.07 |     0.93 |      58952 B |        3.31 |
| LinqGroupByEnumerable  | 1000      | Beginning           |     28,470.08 ns |       428.789 ns |       401.090 ns |     47.63 |     1.00 |     104640 B |        5.88 |
| ToHashSetEnumerable    | 1000      | Beginning           |     20,251.63 ns |       366.614 ns |       342.931 ns |     33.71 |     0.71 |      58888 B |        3.31 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **1000**  | **FortyOnePercent** |  **3,096.57 ns** |    **40.166 ns** |    **37.571 ns** |  **1.00** | **0.00** |  **17800 B** |    **1.00** |
| LinqAnyCollection      | 1000      | FortyOnePercent     |      3,379.33 ns |        33.938 ns |        30.085 ns |      1.09 |     0.02 |      17888 B |        1.00 |
| LinqAllCollection      | 1000      | FortyOnePercent     |      3,242.77 ns |        30.592 ns |        27.119 ns |      1.05 |     0.01 |      17864 B |        1.00 |
| LinqDistinctCollection | 1000      | FortyOnePercent     |      6,426.06 ns |        90.272 ns |        84.440 ns |      2.08 |     0.04 |      17864 B |        1.00 |
| LinqGroupByCollection  | 1000      | FortyOnePercent     |     26,477.80 ns |       281.600 ns |       235.149 ns |      8.53 |     0.15 |     104560 B |        5.87 |
| ToHashSetCollection    | 1000      | FortyOnePercent     |      6,399.74 ns |        65.410 ns |        61.184 ns |      2.07 |     0.04 |      17800 B |        1.00 |
| ForeachEnumerable      | 1000      | FortyOnePercent     |      5,359.93 ns |        86.938 ns |        81.322 ns |      1.73 |     0.04 |      13064 B |        0.73 |
| LinqAnyEnumerable      | 1000      | FortyOnePercent     |      5,658.93 ns |        66.418 ns |        62.128 ns |      1.83 |     0.03 |      13152 B |        0.74 |
| LinqAllEnumerable      | 1000      | FortyOnePercent     |      5,628.23 ns |        87.343 ns |        81.701 ns |      1.82 |     0.04 |      13128 B |        0.74 |
| LinqDistinctEnumerable | 1000      | FortyOnePercent     |     20,728.75 ns |       196.155 ns |       183.483 ns |      6.70 |     0.10 |      58952 B |        3.31 |
| LinqGroupByEnumerable  | 1000      | FortyOnePercent     |     30,891.56 ns |       373.838 ns |       349.688 ns |      9.98 |     0.18 |     104640 B |        5.88 |
| ToHashSetEnumerable    | 1000      | FortyOnePercent     |     20,173.41 ns |       206.796 ns |       183.319 ns |      6.51 |     0.11 |      58888 B |        3.31 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **1000**  | **End**             |  **6,715.74 ns** |    **78.223 ns** |    **73.170 ns** |  **1.00** | **0.00** |  **17800 B** |    **1.00** |
| LinqAnyCollection      | 1000      | End                 |      7,402.56 ns |        84.102 ns |        78.669 ns |      1.10 |     0.02 |      17888 B |        1.00 |
| LinqAllCollection      | 1000      | End                 |      7,143.91 ns |        52.693 ns |        49.289 ns |      1.06 |     0.01 |      17864 B |        1.00 |
| LinqDistinctCollection | 1000      | End                 |      6,399.18 ns |        45.908 ns |        42.942 ns |      0.95 |     0.01 |      17864 B |        1.00 |
| LinqGroupByCollection  | 1000      | End                 |     31,696.48 ns |       425.905 ns |       398.392 ns |      4.72 |     0.10 |     104560 B |        5.87 |
| ToHashSetCollection    | 1000      | End                 |      6,416.42 ns |        73.772 ns |        69.006 ns |      0.96 |     0.02 |      17800 B |        1.00 |
| ForeachEnumerable      | 1000      | End                 |     14,854.95 ns |       225.920 ns |       211.325 ns |      2.21 |     0.05 |      58776 B |        3.30 |
| LinqAnyEnumerable      | 1000      | End                 |     15,739.06 ns |       255.465 ns |       238.962 ns |      2.34 |     0.03 |      58864 B |        3.31 |
| LinqAllEnumerable      | 1000      | End                 |     15,392.70 ns |       104.427 ns |        97.681 ns |      2.29 |     0.03 |      58840 B |        3.31 |
| LinqDistinctEnumerable | 1000      | End                 |     20,894.78 ns |       309.340 ns |       289.357 ns |      3.11 |     0.04 |      58952 B |        3.31 |
| LinqGroupByEnumerable  | 1000      | End                 |     37,468.86 ns |       358.919 ns |       335.733 ns |      5.58 |     0.10 |     104640 B |        5.88 |
| ToHashSetEnumerable    | 1000      | End                 |     20,433.63 ns |       202.893 ns |       189.786 ns |      3.04 |     0.04 |      58888 B |        3.31 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **10000** | **None**            | **91,094.10 ns** |   **692.317 ns** |   **647.593 ns** |  **1.00** | **0.00** | **161813 B** |    **1.00** |
| LinqAnyCollection      | 10000     | None                |    101,183.66 ns |       916.373 ns |       857.176 ns |      1.11 |     0.01 |     161901 B |        1.00 |
| LinqAllCollection      | 10000     | None                |     97,829.39 ns |       957.686 ns |       895.820 ns |      1.07 |     0.01 |     161877 B |        1.00 |
| LinqDistinctCollection | 10000     | None                |     91,516.67 ns |       794.299 ns |       742.988 ns |      1.00 |     0.01 |     161877 B |        1.00 |
| LinqGroupByCollection  | 10000     | None                |    631,615.92 ns |     7,200.612 ns |     6,383.155 ns |      6.93 |     0.09 |    1142454 B |        7.06 |
| ToHashSetCollection    | 10000     | None                |     93,914.15 ns |     1,270.909 ns |     1,188.809 ns |      1.03 |     0.02 |     161813 B |        1.00 |
| ForeachEnumerable      | 10000     | None                |    190,685.81 ns |     3,552.224 ns |     3,322.752 ns |      2.09 |     0.04 |     538768 B |        3.33 |
| LinqAnyEnumerable      | 10000     | None                |    198,816.66 ns |     1,975.771 ns |     1,848.138 ns |      2.18 |     0.03 |     538856 B |        3.33 |
| LinqAllEnumerable      | 10000     | None                |    197,938.26 ns |     2,650.888 ns |     2,479.642 ns |      2.17 |     0.02 |     538832 B |        3.33 |
| LinqDistinctEnumerable | 10000     | None                |    250,872.97 ns |     3,581.229 ns |     3,349.884 ns |      2.75 |     0.05 |     538944 B |        3.33 |
| LinqGroupByEnumerable  | 10000     | None                |    689,133.95 ns |     8,627.327 ns |     8,070.007 ns |      7.57 |     0.09 |    1142534 B |        7.06 |
| ToHashSetEnumerable    | 10000     | None                |    246,239.22 ns |     3,669.210 ns |     3,432.182 ns |      2.70 |     0.05 |     538880 B |        3.33 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **10000** | **Beginning**       |  **6,880.96 ns** |    **75.955 ns** |    **71.048 ns** | **1.000** | **0.00** | **161813 B** |   **1.000** |
| LinqAnyCollection      | 10000     | Beginning           |      6,929.99 ns |        64.734 ns |        60.552 ns |     1.007 |     0.01 |     161901 B |       1.001 |
| LinqAllCollection      | 10000     | Beginning           |      7,097.82 ns |        39.460 ns |        34.981 ns |     1.031 |     0.01 |     161877 B |       1.000 |
| LinqDistinctCollection | 10000     | Beginning           |     92,580.86 ns |       889.974 ns |       832.482 ns |    13.456 |     0.16 |     161877 B |       1.000 |
| LinqGroupByCollection  | 10000     | Beginning           |    554,243.57 ns |     7,785.328 ns |     6,901.490 ns |    80.485 |     1.43 |    1142398 B |       7.060 |
| ToHashSetCollection    | 10000     | Beginning           |     92,985.67 ns |       759.712 ns |       710.635 ns |    13.515 |     0.18 |     161813 B |       1.000 |
| ForeachEnumerable      | 10000     | Beginning           |         61.03 ns |         0.786 ns |         0.735 ns |     0.009 |     0.00 |        280 B |       0.002 |
| LinqAnyEnumerable      | 10000     | Beginning           |         71.15 ns |         0.597 ns |         0.530 ns |     0.010 |     0.00 |        368 B |       0.002 |
| LinqAllEnumerable      | 10000     | Beginning           |         68.66 ns |         0.995 ns |         0.831 ns |     0.010 |     0.00 |        344 B |       0.002 |
| LinqDistinctEnumerable | 10000     | Beginning           |    244,055.14 ns |     3,413.509 ns |     3,192.998 ns |    35.473 |     0.66 |     538944 B |       3.331 |
| LinqGroupByEnumerable  | 10000     | Beginning           |    592,099.34 ns |    10,108.234 ns |     9,455.248 ns |    86.058 |     1.65 |    1142478 B |       7.060 |
| ToHashSetEnumerable    | 10000     | Beginning           |    247,400.21 ns |     4,691.237 ns |     4,388.186 ns |    35.958 |     0.74 |     538880 B |       3.330 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **10000** | **FortyOnePercent** | **44,616.78 ns** |   **406.013 ns** |   **379.784 ns** |  **1.00** | **0.00** | **161813 B** |    **1.00** |
| LinqAnyCollection      | 10000     | FortyOnePercent     |     48,224.32 ns |       455.001 ns |       425.609 ns |      1.08 |     0.02 |     161901 B |        1.00 |
| LinqAllCollection      | 10000     | FortyOnePercent     |     46,141.95 ns |       724.256 ns |       677.469 ns |      1.03 |     0.02 |     161877 B |        1.00 |
| LinqDistinctCollection | 10000     | FortyOnePercent     |     92,884.72 ns |     1,038.201 ns |       971.134 ns |      2.08 |     0.03 |     161877 B |        1.00 |
| LinqGroupByCollection  | 10000     | FortyOnePercent     |    584,942.94 ns |     8,072.656 ns |     7,156.199 ns |     13.12 |     0.22 |    1142398 B |        7.06 |
| ToHashSetCollection    | 10000     | FortyOnePercent     |     95,377.13 ns |       964.132 ns |       901.850 ns |      2.14 |     0.02 |     161813 B |        1.00 |
| ForeachEnumerable      | 10000     | FortyOnePercent     |     78,826.93 ns |       868.845 ns |       770.209 ns |      1.77 |     0.03 |     258387 B |        1.60 |
| LinqAnyEnumerable      | 10000     | FortyOnePercent     |     82,660.12 ns |     1,466.371 ns |     1,371.644 ns |      1.85 |     0.04 |     258475 B |        1.60 |
| LinqAllEnumerable      | 10000     | FortyOnePercent     |     83,556.19 ns |       754.950 ns |       706.181 ns |      1.87 |     0.02 |     258451 B |        1.60 |
| LinqDistinctEnumerable | 10000     | FortyOnePercent     |    250,828.61 ns |     2,097.124 ns |     1,961.651 ns |      5.62 |     0.06 |     538944 B |        3.33 |
| LinqGroupByEnumerable  | 10000     | FortyOnePercent     |    634,920.74 ns |     8,810.078 ns |     8,240.952 ns |     14.23 |     0.19 |    1142478 B |        7.06 |
| ToHashSetEnumerable    | 10000     | FortyOnePercent     |    245,208.85 ns |     3,574.293 ns |     3,343.396 ns |      5.50 |     0.09 |     538880 B |        3.33 |
|                        |           |                     |                  |                  |                  |           |          |              |             |
| **ForeachCollection**  | **10000** | **End**             | **93,863.65 ns** | **1,186.485 ns** | **1,109.839 ns** |  **1.00** | **0.00** | **161813 B** |    **1.00** |
| LinqAnyCollection      | 10000     | End                 |    102,418.73 ns |     1,008.851 ns |       943.679 ns |      1.09 |     0.02 |     161901 B |        1.00 |
| LinqAllCollection      | 10000     | End                 |     98,568.97 ns |     1,024.512 ns |       958.329 ns |      1.05 |     0.02 |     161877 B |        1.00 |
| LinqDistinctCollection | 10000     | End                 |     92,095.89 ns |     1,032.460 ns |       965.764 ns |      0.98 |     0.02 |     161877 B |        1.00 |
| LinqGroupByCollection  | 10000     | End                 |    660,996.44 ns |    12,410.031 ns |    11,608.351 ns |      7.04 |     0.16 |    1142398 B |        7.06 |
| ToHashSetCollection    | 10000     | End                 |     92,595.27 ns |       595.160 ns |       527.594 ns |      0.99 |     0.01 |     161813 B |        1.00 |
| ForeachEnumerable      | 10000     | End                 |    189,140.06 ns |     2,291.882 ns |     2,143.828 ns |      2.02 |     0.03 |     538768 B |        3.33 |
| LinqAnyEnumerable      | 10000     | End                 |    201,139.02 ns |     2,536.438 ns |     2,372.586 ns |      2.14 |     0.04 |     538856 B |        3.33 |
| LinqAllEnumerable      | 10000     | End                 |    200,562.64 ns |     3,482.309 ns |     3,257.354 ns |      2.14 |     0.04 |     538832 B |        3.33 |
| LinqDistinctEnumerable | 10000     | End                 |    254,411.98 ns |     2,737.680 ns |     2,426.882 ns |      2.71 |     0.03 |     538944 B |        3.33 |
| LinqGroupByEnumerable  | 10000     | End                 |    732,982.67 ns |     6,508.309 ns |     5,081.259 ns |      7.82 |     0.13 |    1142478 B |        7.06 |
| ToHashSetEnumerable    | 10000     | End                 |    247,684.04 ns |     4,326.799 ns |     5,922.572 ns |      2.63 |     0.07 |     538880 B |        3.33 |


## Notes

### TryGetNonEnumeratedCount

Calling the constructor overload for HashSet with the collection size can improve performance and memory efficiency by avoiding unnecessary resizing of the collection at runtime. Resizing a collection involves allocating a new array with a larger capacity and copying the existing elements to the new array. This can be costly in terms of time and space.

### CA1851: Possible multiple enumerations of IEnumerable collection

To detect a duplicate, we compare the distinct count to the enumerable count, which may cause multiple enumerations of the collection.

https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1851