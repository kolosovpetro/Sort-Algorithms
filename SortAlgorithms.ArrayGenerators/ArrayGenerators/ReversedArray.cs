using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class ReversedArray : IArrayGenerator
    {
        private readonly RandomArray _randomArray;
        public int[] GetArray { get; }

        public ReversedArray(int arraySize)
        {
            _randomArray = new RandomArray(arraySize);
            GetArray = GenerateArray();
        }

        public int[] GenerateArray()
        {
            var array = _randomArray.GenerateArray();
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}