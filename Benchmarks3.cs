using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace ArrayIteration
{
    public class Benchmarks3 : ReadBenchmarksBase
    {
        //[Benchmark(Baseline = true)]
        public int Array_For()
        {
            var array = _array;
            var Res = 0;
            for (int To = 0; To < 1000; To++)
            {
                Res = 0;
                for (int i = 0; i < array.Length; i++)
                    Res += array[i];
            }
            return Res;
        }

        public int Array_For1()
        {
            var array = _array;
            var Res = 0;
            for (int To = 0; To < 1000; To++)
            {
                Res = 0;
                for (int i = 0; i < array.Length; i++)
                    Res += array[i];
            }
            return Res;
        }

        public int Array_For2()
        {
            var array = _array;
            var Res = 0;
            for (int To = 0; To < 1000; To++)
            {
                Res = 0;
                for (int i = 0; i < array.Length; i++)
                    Res += array[i];
            }
            return Res;
        }

        public int Array_For3()
        {
            var array = _array;
            var Res = 0;
            for (int To = 0; To < 1000; To++)
            {
                Res = 0;
                for (int i = 0; i < array.Length; i++)
                    Res += array[i];
            }
            return Res;
        }
    }
}