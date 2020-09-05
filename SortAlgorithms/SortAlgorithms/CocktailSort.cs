using SortAlgorithms.Auxiliaries.Auxiliaries;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class CocktailSort : ISortAlgorithm
    {
        public int[] SortSequence(int[] sequence)
        {
            var copyArray = ArrayDeepCopy.CopyArray(sequence);
            CocktailSortExecute(copyArray);
            return copyArray;
        }

        private static void CocktailSortExecute(int[] array)
        {
            var start = 0;
            var end = array.Length;

            while (true)
            {
                var swapped = false;
                
                for (var k = start; k < end - 1; k++)
                {
                    if (array[k] < array[k + 1]) continue;
                    ISortAlgorithm.Swap(array, k + 1, k);
                    swapped = true;
                }

                if (!swapped) break;

                end--;

                for (var t = end - 1; t >= start; t--)
                {
                    if (array[t] < array[t + 1]) continue;
                    ISortAlgorithm.Swap(array, t + 1, t);
                }

                start++;
            }
        }
    }
}