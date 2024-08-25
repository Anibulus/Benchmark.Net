using BenchmarkDotNet.Attributes;

public class SortBenchmark
{
    private const int N = 100;

    private int[] integers = new int[N];
    public SortBenchmark()
    {
        for(int i = 0; i < N;i++)
            integers[i] = new Random(42).Next();
    }

    [Benchmark]
    public void BubbleSorting()
    {
        BubbleSort.Sort(integers);
    }

    [Benchmark]
    public void Quicksorting()
    {
        Quicksort.Sort(integers);
    }

    [Benchmark]
    public void LinqSorting()
    {
        integers.Order();
    }
}