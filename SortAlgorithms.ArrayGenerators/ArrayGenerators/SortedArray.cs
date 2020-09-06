using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class SortedArray : IArrayGenerator
    {
        private readonly RandomArray _randomArray;
        public int[] GetArray { get; }


        public SortedArray(int arraySize)
        {
            _randomArray = new RandomArray(arraySize);
            GetArray = GenerateArray();
        }

        public int[] GenerateArray()
        {
            var array = _randomArray.GenerateArray();
            Array.Sort(array);
            return array;
        }
    }
}