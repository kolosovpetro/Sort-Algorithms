using System.Linq;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.Core.Services;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class InsertionSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public InsertionSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public InsertionSort()
        {
        }

        public void SortSequence()
        {
            for (var k = 1; k < SortedSequence.Length; k++)
            {
                var j = k;

                while (j > 1 && SortedSequence[j - 1] > SortedSequence[j])
                {
                    SortServices.Swap(SortedSequence, j - 1, j);
                    j--;
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