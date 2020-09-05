using System;
using System.Diagnostics;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.PerformanceLogger.Timer
{
    public static class RuntimeTimer
    {
        public static TimeSpan Measure(ISortAlgorithm sortAlgorithm, int[] array)
        {
            Action act = () => sortAlgorithm.SortSequence(array);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            act.Invoke();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}