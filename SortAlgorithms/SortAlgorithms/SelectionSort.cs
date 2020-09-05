using SortAlgorithms.Auxiliaries.Auxiliaries;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class SelectionSort : ISortAlgorithm
    {
        public int[] SortSequence(int[] sequence)
        {
            var copyArray = ArrayDeepCopy.CopyArray(sequence);

            for (var k = 0; k < copyArray.Length; k++)
            {
                var minIndex = k;

                for (var j = k + 1; j < copyArray.Length; j++)
                    minIndex = copyArray[minIndex] < copyArray[j] ? minIndex : j;
                
                ISortAlgorithm.Swap(copyArray, k, minIndex);
            }

            return copyArray;
        }
    }
}