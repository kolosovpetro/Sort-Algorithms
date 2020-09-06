using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class ReversedArray : IArrayGenerator
    {
        private static readonly RandomArray RandomArray = new RandomArray();

        public int[] GenerateArray(int arraySize)
        {
            var array = RandomArray.GenerateArray(arraySize);
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}