```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method | iterationNumber | Mean     | Error    | StdDev   | Allocated |
|------- |---------------- |---------:|---------:|---------:|----------:|
| Data   | 100             | 754.9 μs | 23.08 μs | 67.34 μs |     432 B |
