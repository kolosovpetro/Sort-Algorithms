using System.Linq;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.Core.Services;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class SelectionSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public SelectionSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public SelectionSort()
        {
        }

        public void SortSequence()
        {
            for (var k = 0; k < SortedSequence.Length; k++)
            {
                var minIndex = k;

                for (var j = k + 1; j < SortedSequence.Length; j++)
                    minIndex = SortedSequence[minIndex] < SortedSequence[j] ? minIndex : j;

                SortServices.Swap(SortedSequence, k, minIndex);
            }
        }

        public void SetSequence(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }
    }
}