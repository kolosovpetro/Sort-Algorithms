using System.Collections.Generic;

namespace SortAlgorithms.Interfaces
{
    public interface ISortAlgorithm
    {
        int[] SortSequence(IEnumerable<int> sequence);

        void Swap(int[] collection, int index1, int index2)
        {
            var temp = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = temp;
        }
    }
}