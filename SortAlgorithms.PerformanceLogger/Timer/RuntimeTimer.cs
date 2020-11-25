using System;
using System.Diagnostics;
using SortAlgorithms.Core.Interfaces;

namespace SortAlgorithms.PerformanceLogger.Timer
{
    public static class RuntimeTimer
    {
        public static TimeSpan Measure(ISortAlgorithm sortAlgorithm)
        {
            Action act = sortAlgorithm.SortSequence;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            act.Invoke();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}