using System;
using SortAlgorithms.ArrayGenerators.ArrayGenerators;
using SortAlgorithms.Interfaces;
using SortAlgorithms.SortAlgorithms;

namespace SortAlgorithms.ConsoleUI
{
    public static class Program
    {
        private static void Main()
        {
            var randomArray = ArrayGenerator.RandomArray(10);
            var aShapeArray = ArrayGenerator.AShapeArray(10);

            Console.WriteLine("Random array: ");
            foreach (var value in randomArray)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("AShape Array: ");
            foreach (var value in aShapeArray)
            {
                Console.Write(value + " ");
            }

            var sequence = new[] {1, 9, 3, 7, 2, 6, 11, 14, 10, 6, 8, 19, 22};
            ISortAlgorithm sortAlgorithm = new BubbleSort();
            var sortedSequence = sortAlgorithm.SortSequence(sequence);

            Console.WriteLine("Initial sequence: ");
            foreach (var value in sequence)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("Sorted sequence: ");
            foreach (var value in sortedSequence)
            {
                Console.Write(value + " ");
            }
        }
    }
}