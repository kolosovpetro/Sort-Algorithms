namespace SortAlgorithms.Interfaces
{
    public interface ISortAlgorithm
    {
        int[] SortSequence(int[] sequence);

        static void Swap(int[] collection, int index1, int index2)
        {
            var temp = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = temp;
        }
    }
}