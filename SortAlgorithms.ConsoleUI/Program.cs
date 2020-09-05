using System;
using SortAlgorithms.Interfaces;
using SortAlgorithms.SortAlgorithms;

namespace SortAlgorithms.ConsoleUI
{
    public static class Program
    {
        private static void Main()
        {
            var sequence = new[] {1, 9, 3, 7, 2, 6, 11, 14, 10, 6, 8, 19, 22};
            ISortAlgorithm sortAlgorithm = new QuickSort();
            sortAlgorithm.SortSequence(sequence);

            Console.WriteLine("Sorted sequence: ");
            foreach (var value in sequence) 
                Console.Write(value + " ");
        }
    }
}