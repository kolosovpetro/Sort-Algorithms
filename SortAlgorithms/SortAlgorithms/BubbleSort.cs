﻿using SortAlgorithms.Interfaces;
using SortAlgorithms.Services;

namespace SortAlgorithms.SortAlgorithms
{
    public class BubbleSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            var swapped = true;

            while (swapped)
            {
                swapped = false;

                for (var k = 1; k < sequence.Length; k++)
                {
                    if (sequence[k - 1] <= sequence[k]) continue;
                    SortServices.Swap(sequence, k - 1, k);
                    swapped = true;
                }
            }
        }
    }
}