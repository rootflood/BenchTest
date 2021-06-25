using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ArrayIteration
{
    public abstract class BenchmarksBase
    {
        protected int[] _array;

        [Params(1_000_000)]
        public int Count { get; set; }

        [GlobalSetup]
        public void GlobalSetup()
        {
            _array = new int[Count];
        }
        
        [Benchmark]
        public int Span_ForEach()
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