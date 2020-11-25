using System.Linq;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.Core.Services;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class CocktailSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public CocktailSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public CocktailSort()
        {
        }

        public void SortSequence()
        {
            var start = 0; // cocktail sort
            var end = SortedSequence.Length;

            while (true)
            {
                var swapped = false;

                for (var k = start; k < end - 1; k++)
                {
                    if (SortedSequence[k] < SortedSequence[k + 1]) continue;
                    SortServices.Swap(SortedSequence, k + 1, k);
                    swapped = true;
                }

                if (!swapped) break;

                end--;

                for (var t = end - 1; t >= start; t--)
                {
                    if (SortedSequence[t] < SortedSequence[t + 1]) continue;
                    SortServices.Swap(SortedSequence, t + 1, t);
                }

                start++;
            }
        }

        public void SetSequence(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }
    }
}