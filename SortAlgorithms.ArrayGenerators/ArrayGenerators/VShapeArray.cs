using System;
using System.Linq;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class VShapeArray : IArrayGenerator
    {
        private readonly RandomArray _randomArray;
        public int[] GetArray { get; }

        public VShapeArray(int arraySize)
        {
            _randomArray = new RandomArray(arraySize / 2);
            GetArray = GenerateArray();
        }


        public int[] GenerateArray()
        {
            var left = _randomArray.GenerateArray();
            Array.Sort(left);
            Array.Reverse(left);
            var right = _randomArray.GenerateArray();
            Array.Sort(right);
            return left.Concat(right).ToArray();
        }
    }
}