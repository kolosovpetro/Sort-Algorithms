using System;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class DotNetSort : ISortAlgorithm
    {
        public void SortSequence(int[] sequence)
        {
            Array.Sort(sequence);
        }
    }
}