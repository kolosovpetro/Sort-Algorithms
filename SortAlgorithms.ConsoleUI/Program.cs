using System;
using System.Net;
using SortAlgorithms.ArrayGenerators.ArrayGenerators;

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
        }
    }
}