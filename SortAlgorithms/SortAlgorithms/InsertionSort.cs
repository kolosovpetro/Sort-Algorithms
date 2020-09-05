﻿using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class InsertionSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            for (var k = 1; k < sequence.Length; k++)
            {
                var j = k;

                while (j > 1 && sequence[j - 1] > sequence[j])
                {
                    ISortAlgorithm.Swap(sequence, j - 1, j);
                    j--;
                }
            }
        }
    }
}