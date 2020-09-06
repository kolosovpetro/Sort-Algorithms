using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class RandomArray : IArrayGenerator
    {
        private static readonly Random Random = new Random();
        
        public int[] GenerateArray(int arraySize)
        {
            var array = new int[arraySize];

            for (var i = 0; i < arraySize; i++)
                array[i] = Random.Next(arraySize);

            return array;
        }
    }
}