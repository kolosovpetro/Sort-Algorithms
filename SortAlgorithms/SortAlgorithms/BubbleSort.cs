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

                for (var step = 1; step < copyArray.Length; step++)
                {
                    if (copyArray[step - 1] <= copyArray[step]) continue;
                    ISortAlgorithm.Swap(copyArray, step - 1, step);
                    swapped = true;
                }
            }

            return copyArray;
        }
    }
}