using System;
using System.Linq;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class AShapeArray : IArrayGenerator
    {
        private static readonly RandomArray RandomArray = new RandomArray();

        public int[] GenerateArray(int arraySize)
        {
            var left = RandomArray.GenerateArray(arraySize / 2);
            Array.Sort(left);
            var right = RandomArray.GenerateArray(arraySize - arraySize / 2);
            Array.Sort(right);
            Array.Reverse(right);
            return left.Concat(right).ToArray();
        }
    }
}