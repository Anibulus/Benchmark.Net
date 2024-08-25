
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<Md5VsSha256>();
var sum = BenchmarkRunner.Run<SortBenchmark>();