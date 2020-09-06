using System.Collections.Generic;
using SortAlgorithms.ArrayGenerators.ArrayGenerators;
using SortAlgorithms.ArrayGenerators.Interfaces;
using SortAlgorithms.Interfaces;
using SortAlgorithms.SortAlgorithms;

namespace SortAlgorithms.Benchmarks
{
    public static class Program
    {
        private static void Main()
        {
            const int sizeStep = 100;
            const int maxSize = 5000;

            for (var i = sizeStep; i <= maxSize; i += sizeStep)
            {
                var arrayList = new List<IArrayGenerator>
                {
                    new AShapeArray(i),
                    new ConstantArray(i),
                    new RandomArray(i),
                    new ReversedArray(i),
                    new SortedArray(i),
                    new VShapeArray(i)
                };

                var sortList = new List<ISortAlgorithm>
                {
                    new BubbleSort(),
                    new CocktailSort(),
                    new InsertionSort(),
                    new MergeSort(),
                    new QuickSort(),
                    new SelectionSort()
                };

                foreach (var algorithm in sortList)
                {
                    foreach (var array in arrayList) 
                        PerformanceLogger.Logger.PerformanceLogger.Log(algorithm, array);
                }
            }
        }
    }
}