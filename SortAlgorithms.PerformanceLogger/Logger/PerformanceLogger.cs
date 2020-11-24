using System;
using System.IO;
using SortAlgorithms.ArrayGenerators.Interfaces;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.PerformanceLogger.Timer;
using static SortAlgorithms.PerformanceLogger.Logger.Routes;

namespace SortAlgorithms.PerformanceLogger.Logger
{
    public static class PerformanceLogger
    {
        public static void Log(ISortAlgorithm sortAlgorithm, IArrayGenerator arrayGenerator)
        {
            var elapsed = RuntimeTimer.Measure(sortAlgorithm, arrayGenerator);
            var arrayType = arrayGenerator.GetType().Name;
            var size = arrayGenerator.Length;
            var algorithmName = sortAlgorithm.GetType().Name;
            var benchmarkFileName = $"{algorithmName}_{arrayType}.csv";
            var benchmarkDirectory = BenchmarksFolder + $"{algorithmName}/";
            Directory.CreateDirectory(benchmarkDirectory);
            var message = $"Elapsed; {elapsed}; Array Size; {size}; Array Type; {arrayType}; {algorithmName};";
            Console.WriteLine(message);
            using var sw = new StreamWriter(benchmarkDirectory + benchmarkFileName, true);
            sw.WriteLine(message);
        }
    }
}