using System;
using System.Linq;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public static class ArrayGenerator
    {
        private static readonly Random Random = new Random();

        public static int[] RandomArray(int size)
        {
            var array = new int[size];

            for (var i = 0; i < size; i++)
                array[i] = Random.Next(size);

            return array;
        }

        public static int[] AShapeArray(int size)
        {
            var left = RandomArray(size / 2);
            Array.Sort(left);
            var right = RandomArray(size - size / 2);
            Array.Sort(right);
            Array.Reverse(right);
            return left.Concat(right).ToArray();
        }

        public static int[] VShapeArray(int size)
        {
            var left = RandomArray(size / 2);
            Array.Sort(left);
            Array.Reverse(left);
            var right = RandomArray(size - size / 2);
            Array.Sort(right);
            return left.Concat(right).ToArray();
        }

        public static int[] ConstantArray(int size)
        {
            var value = Random.Next(size);
            var array = new int[size];

            for (var i = 0; i < size; i++)
                array[i] = value;

            return array;
        }

        public static int[] ReverseArray(int size)
        {
            var array = RandomArray(size);
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        public static int[] SortedArray(int size)
        {
            var array = RandomArray(size);
            Array.Sort(array);
            return array;
        }
    }
}