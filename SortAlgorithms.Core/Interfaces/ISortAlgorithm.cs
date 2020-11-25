namespace SortAlgorithms.Core.Interfaces
{
    public interface ISortAlgorithm
    {
        int[] InitialSequence { get; }
        int[] SortedSequence { get; }
        void SortSequence();
        void SetSequence(int[] sequence);
    }
}