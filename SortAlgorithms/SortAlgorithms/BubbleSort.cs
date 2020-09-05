using SortAlgorithms.Auxiliaries.Auxiliaries;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class BubbleSort : ISortAlgorithm
    {
        public int[] SortSequence(int[] sequence)
        {
            var copyArray = ArrayDeepCopy.CopyArray(sequence);

            var swapped = true;

            while (swapped)
            {
                swapped = false;

                for (var k = 1; k < copyArray.Length; k++)
                {
                    if (copyArray[k - 1] <= copyArray[k]) continue;
                    ISortAlgorithm.Swap(copyArray, k - 1, k);
                    swapped = true;
                }
            }

            return copyArray;
        }
    }
}