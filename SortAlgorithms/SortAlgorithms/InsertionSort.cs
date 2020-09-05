using SortAlgorithms.Auxiliaries.Auxiliaries;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class InsertionSort : ISortAlgorithm
    {
        public int[] SortSequence(int[] sequence)
        {
            var copyArray = ArrayDeepCopy.CopyArray(sequence);

            for (var k = 1; k < copyArray.Length; k++)
            {
                var j = k;

                while (j > 1 && copyArray[j - 1] > copyArray[j])
                {
                    ISortAlgorithm.Swap(copyArray, j - 1, j);
                    j--;
                }
            }

            return copyArray;
        }
    }
}