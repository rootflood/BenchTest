using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ArrayIteration
{
    public abstract class ReadBenchmarksBase
    {
        protected int[] _array;

        [Params(1_000_000)]
        public int Count { get; set; }

        [GlobalSetup]
        public void GlobalSetup()
        {
            _array = new int[Count];
        }

        //[Benchmark]
        //public int Array_ForEach()
        //{
        //    var array = _array;
        //    var Res = 0;
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        foreach (var item in array)
        //            Res += item;
        //    }
        //    return Res;
        //}

        //[Benchmark]
        //public int Array_Ptr()
        //{
        //    static unsafe int AC(int[] source)
        //    {
        //        var sum = 0;
        //        var End = source.Length;
        //        fixed (int* p = source)
        //        {
        //            var Ptr = p;
        //            var EndPtr = p + End;
        //            for (; Ptr < EndPtr; Ptr++)
        //                sum += *Ptr;
        //        }
        //        return sum;
        //    }

        //    var Res = 0;
        //    for (int i = 0; i < 1000; i++)
        //        Res = AC(_array);
        //    return Res;
        //}

        [Benchmark]
        public int Span_ForEach_Inside()
        {
            var Res = 0;
            var source = _array.AsSpan();
            for (int i = 0; i < 1000; i++)
            {
                Res = 0;
                foreach (var item in source)
                    Res += item;
            }
            return Res;
        }
    }
}