using System;

namespace SortAlgorithms.Auxiliaries.Auxiliaries
{
    public static class ArrayDeepCopy
    {
        public static int[] CopyArray(int[] sourceArray)
        {
            var destinationArray = new int[sourceArray.Length];
            Array.Copy(sourceArray, destinationArray, sourceArray.Length);
            return destinationArray;
        }
    }
}