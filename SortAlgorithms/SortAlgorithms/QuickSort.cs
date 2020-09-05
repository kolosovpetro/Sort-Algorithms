using SortAlgorithms.Auxiliaries.Auxiliaries;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class QuickSort : ISortAlgorithm
    {
        public int[] SortSequence(int[] sequence)
        {
            var copyArray = ArrayDeepCopy.CopyArray(sequence);
            QuickSortExecute(copyArray, 0, copyArray.Length - 1);
            return copyArray;
        }

        private static void QuickSortExecute(int[] array, int left, int right)
        {
            if (left >= right) return;
            var pivot = Partition(array, left, right);
            QuickSortExecute(array, left, pivot - 1);
            QuickSortExecute(array, pivot + 1, right);
        }

        private static int Partition(int[] array, int left, int right)
        {
            var pivot = array[right];
            var end = left;

            for (var i = left; i < right; i++)
            {
                if (array[i] < pivot)
                {
                    ISortAlgorithm.Swap(array, i, end);
                    end++;
                }
            }

            ISortAlgorithm.Swap(array, end, right);
            return end;
        }
    }
}