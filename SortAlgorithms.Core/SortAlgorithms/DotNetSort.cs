using System;
using SortAlgorithms.Core.Interfaces;

namespace SortAlgorithms.Core.SortAlgorithms
{
    public class DotNetSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            Array.Sort(sequence);
        }
    }
}