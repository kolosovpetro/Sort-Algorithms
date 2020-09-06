using System;
using System.Linq;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class AShapeArray : IArrayGenerator
    {
        private readonly RandomArray _randomArray;
        public int[] GetArray { get; private set; }

        public AShapeArray(int arraySize)
        {
            _randomArray = new RandomArray(arraySize / 2);
            GetArray = GenerateArray();
        }


        public int[] GenerateArray()
        {
            var left = _randomArray.GenerateArray();
            Array.Sort(left);
            var right = _randomArray.GenerateArray();
            Array.Sort(right);
            Array.Reverse(right);
            return left.Concat(right).ToArray();
        }
    }
}