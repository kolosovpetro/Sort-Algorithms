using System;
using System.Linq;
using SortAlgorithms.Core.Interfaces;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class DotNetSort : ISortAlgorithm
    {
        public int[] InitialSequence { get; private set; }
        public int[] SortedSequence { get; private set; }

        public DotNetSort(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }

        public DotNetSort()
        {
        }

        public void SortSequence()
        {
            Array.Sort(SortedSequence);
        }

        public void SetSequence(int[] sequence)
        {
            InitialSequence = sequence;
            SortedSequence = sequence.Select(x => x).ToArray();
        }
    }
}