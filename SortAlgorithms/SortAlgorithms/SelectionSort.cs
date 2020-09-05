﻿using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class SelectionSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            for (var k = 0; k < sequence.Length; k++)
            {
                var minIndex = k;

                for (var j = k + 1; j < sequence.Length; j++)
                    minIndex = sequence[minIndex] < sequence[j] ? minIndex : j;
                
                ISortAlgorithm.Swap(sequence, k, minIndex);
            }
        }
    }
}