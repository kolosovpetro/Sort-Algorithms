using System.Linq;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.Core.Services;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class BubbleSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public BubbleSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public BubbleSort()
        {
        }

        public void SortSequence()
        {
            var swapped = true;

            while (swapped)
            {
                swapped = false;

                for (var k = 1; k < SortedSequence.Length; k++)
                {
                    if (SortedSequence[k - 1] <= SortedSequence[k]) continue;
                    SortServices.Swap(SortedSequence, k - 1, k);
                    swapped = true;
                }
            }
        }

        public void SetSequence(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }
    }
}