using System;
using BenchmarkDotNet.Running;

namespace BenchmarkDNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<MyParserBenchmark>();
            BenchmarkRunner.Run<StructuresBenchMark2>();
        }
    }
}