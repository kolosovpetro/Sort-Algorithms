using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class RandomArray : IArrayGenerator
    {
        private static readonly Random Random = new Random();
        private readonly int _arraySize;
        
        public int[] GetArray { get; }
        public RandomArray(int arraySize)
        {
            _arraySize = arraySize;
            GetArray = GenerateArray();
        }

        public int[] GenerateArray()
        {
            var array = new int[_arraySize];

            for (var i = 0; i < _arraySize; i++)
                array[i] = Random.Next(_arraySize);

            return array;
        }
    }
}