﻿using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class CocktailSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            var start = 0;
            var end = sequence.Length;

            while (true)
            {
                var swapped = false;

                for (var k = start; k < end - 1; k++)
                {
                    if (sequence[k] < sequence[k + 1]) continue;
                    ISortAlgorithm.Swap(sequence, k + 1, k);
                    swapped = true;
                }

                if (!swapped) break;

                end--;

                for (var t = end - 1; t >= start; t--)
                {
                    if (sequence[t] < sequence[t + 1]) continue;
                    ISortAlgorithm.Swap(sequence, t + 1, t);
                }

                start++;
            }
        }
    }
}