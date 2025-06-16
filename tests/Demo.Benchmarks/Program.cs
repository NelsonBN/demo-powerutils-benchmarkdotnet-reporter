using BenchmarkDotNet.Running;
using Demo.Benchmarks;

BenchmarkRunner.Run<ArrayProcessorBenchmarks>();
BenchmarkRunner.Run<StringProcessorBenchmarks>();
