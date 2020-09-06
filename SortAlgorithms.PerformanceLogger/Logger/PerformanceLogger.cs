using System;
using System.IO;
using SortAlgorithms.ArrayGenerators.Interfaces;
using SortAlgorithms.Interfaces;
using SortAlgorithms.PerformanceLogger.Timer;
using static SortAlgorithms.PerformanceLogger.Logger.Routes;

namespace SortAlgorithms.PerformanceLogger.Logger
{
    public static class PerformanceLogger
    {
        public static void Log(ISortAlgorithm sortAlgorithm, IArrayGenerator arrayGenerator)
        {
            var timeElapsed = RuntimeTimer.Measure(sortAlgorithm, arrayGenerator);
            var arrayType = arrayGenerator.GetType().Name;
            var sortAlgorithmName = sortAlgorithm.GetType().Name;
            var benchmarkFileName = $"{arrayType}.txt";
            Directory.CreateDirectory(BenchmarksFolder);
            var message =
                $"Time elapsed: {timeElapsed}, Array size: {arrayGenerator.Length}, Array Type: {arrayType}, " +
                $"Sort algorithm: {sortAlgorithmName}";
            Console.WriteLine(message);
            using var sw = new StreamWriter(BenchmarksFolder + benchmarkFileName, true);
            sw.WriteLine(message);
        }
    }
}