using System;

namespace SortAlgorithms.ArrayGenerators.Interfaces
{
    public interface IArrayGenerator
    {
        int[] GetArray { get; }
        int[] GenerateArray();

        void PrintArray()
        {
            foreach (var value in GetArray) 
                Console.Write(value + " ");
        }
    }
}