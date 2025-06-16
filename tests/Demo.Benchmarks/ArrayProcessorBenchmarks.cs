using BenchmarkDotNet.Attributes;

namespace Demo.Benchmarks;

[MemoryDiagnoser]
[JsonExporterAttribute.Full]
public class ArrayProcessorBenchmarks
{
    [Benchmark]
    public void GenerateArray()
    {
        var output = ArrayProcessor.Generate();
    }
}
