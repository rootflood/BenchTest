using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace ArrayIteration
{
    public class Benchmarks1 : ReadBenchmarksBase
    {
        //[Benchmark(Baseline = true)]
        //public int Array_For()
        //{
        //    static int AC(int[] array)
        //    {
        //        var sum = 0;
        //        foreach (var item in array)
        //            sum += item;
        //        return sum;
        //    }
        //    var Res = 0;
        //    for (int i = 0; i < 1000; i++)
        //        Res = AC(_array);
        //    return Res;
        //}
    }
}