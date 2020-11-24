namespace SortAlgorithms.Core.Services
{
    public static class SortServices
    {
        public static void Swap(int[] collection, int index1, int index2)
        {
            var temp = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = temp;
        }
    }
}