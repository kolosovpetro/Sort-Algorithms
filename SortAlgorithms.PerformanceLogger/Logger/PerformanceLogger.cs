using SortAlgorithms.ArrayGenerators.Interfaces;
using SortAlgorithms.Interfaces;
using SortAlgorithms.PerformanceLogger.Timer;

namespace SortAlgorithms.PerformanceLogger.Logger
{
    public static class PerformanceLogger
    {
        public static void Log(ISortAlgorithm sortAlgorithm, IArrayGenerator arrayGenerator)
        {
            var timeElapsed = RuntimeTimer.Measure(sortAlgorithm, arrayGenerator);
        }
    }
}