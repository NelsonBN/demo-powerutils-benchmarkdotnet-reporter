using BenchmarkDotNet.Attributes;

namespace Demo.Benchmarks;

[MemoryDiagnoser]
[JsonExporterAttribute.Full]
public class StringProcessorBenchmarks
{
    [Benchmark]
    public void GenerateString()
    {
        var output = StringProcessor.Generate();
    }
}
