﻿using SortAlgorithms.Interfaces;
using SortAlgorithms.Services;

namespace SortAlgorithms.SortAlgorithms
{
    public class QuickSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            QuickSortExecute(sequence, 0, sequence.Length - 1);
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