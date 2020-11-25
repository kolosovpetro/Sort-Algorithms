using System.Linq;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.Core.Services;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class QuickSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public QuickSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public QuickSort()
        {
        }

        public void SortSequence()
        {
            QuickSortExecute(SortedSequence, 0, InitialSequence.Length - 1);
        }

        public void SetSequence(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
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
                    SortServices.Swap(array, i, end);
                    end++;
                }
            }

            SortServices.Swap(array, end, right);
            return end;
        }
    }
}