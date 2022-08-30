using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<LinkedListBenchmark>();

[MemoryDiagnoser]
public class LinkedListBenchmark
{
    [Params(1000, 100000)]
    public int Size;

    [Benchmark(Baseline = true)]

    public void AddNumsToEndList()
    {
        var list = new List<int>();
        for (int i = 0; i < Size; i++)
            list.Add(i);
    }

    [Benchmark]
    public void AddNumsToEndLinkedList()
    {
        var list = new LinkedList<int>();
        for (int i = 0; i < Size; i++)
            list.AddLast(i);
    }

    //public void AddNumsToStartList()
    //{
    //    var list = new List<int>();
    //    for (int i = 0; i < Size; i++)
    //        list.Insert(0, i);
    //}

    //[Benchmark]
    //public void AddNumsToStartLinkedList()
    //{
    //    var list = new LinkedList<int>();
    //    for (int i = 0; i < Size; i++)
    //        list.AddFirst(i);
    //}
}