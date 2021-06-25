using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ArrayIteration
{
    public abstract class ReadBenchmarksBase
    {
        const int Seed = 42;
        const int MaxValue = 100;
        protected int[] _array;
        protected List<int> _list;

        [Params(1_000_000)]
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public int Count { get; set; }

        [GlobalSetup]
        public void GlobalSetup()
        {
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            _array = new int[Count];
        }

        [Benchmark]
        public int Array_ForEach()
        {
            var array = _array;
            var Res = 0;
            for (int i = 0; i < 1000; i++)
            {
                foreach (var item in array)
                    Res += item;
            }
            return Res;
        }

        [Benchmark]
        public int Array_Ptr()
        {
            static unsafe int AC(int[] source)
            {
                var sum = 0;
                var End = source.Length;
                fixed (int* p = source)
                {
                    var Ptr = p;
                    var EndPtr = p + End;
                    for (; Ptr < EndPtr; Ptr++)
                        sum += *Ptr;
                }
                return sum;
            }

            var Res = 0;
            for (int i = 0; i < 1000; i++)
                Res = AC(_array);
            return Res;
        }
    }
}