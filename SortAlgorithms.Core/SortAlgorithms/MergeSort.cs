﻿using System;
using System.Linq;
using SortAlgorithms.Core.Interfaces;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class MergeSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public MergeSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public MergeSort()
        {
        }

        public void SortSequence()
        {
            MergeSortExecute(SortedSequence, 0, InitialSequence.Length - 1);
        }

        public void SetSequence(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        private static void MergeSortExecute(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) return;
            var middleIndex = startIndex + (endIndex - startIndex) / 2;
            MergeSortExecute(arr, startIndex, middleIndex);
            MergeSortExecute(arr, middleIndex + 1, endIndex);
            Merge(arr, startIndex, middleIndex, endIndex);
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            var leftSubarraySize = middle - left + 1;
            var rightSubarraySize = right - middle;

            var leftSubarray = new int[leftSubarraySize];
            var rightSubarray = new int[rightSubarraySize];

            Array.Copy(array, left, leftSubarray, 0, leftSubarraySize);
            Array.Copy(array, middle + 1, rightSubarray, 0, rightSubarraySize);

            int i = 0, j = 0, k = left;

            while (i < leftSubarraySize && j < rightSubarraySize)
            {
                if (leftSubarray[i] <= rightSubarray[j])
                {
                    array[k] = leftSubarray[i];
                    i++;
                }
                else
                {
                    array[k] = rightSubarray[j];
                    j++;
                }

                k++;
            }

            // Copy the remaining elements of L[], if there are any
            while (i < leftSubarraySize)
            {
                array[k] = leftSubarray[i];
                i++;
                k++;
            }

            // Copy the remaining elements of R[], if there are any
            while (j < rightSubarraySize)
            {
                array[k] = rightSubarray[j];
                j++;
                k++;
            }
        }
    }
}