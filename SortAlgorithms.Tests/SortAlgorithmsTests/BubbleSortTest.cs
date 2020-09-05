using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.Tests.SortAlgorithmsTests
{
    [TestFixture]
    public class BubbleSortTest
    {
        [Test]
        public void Bubble_Sort_Test()
        {
            var sequence = new[] {1, 9, 3, 7, 2, 6, 11, 14, 10, 6, 8, 19, 22};
            ISortAlgorithm sortAlgorithm = null;
            var sortedSequence = sortAlgorithm.SortSequence(sequence);
            sortedSequence.SequenceEqual(new[] {1, 2, 3, 6, 6, 7, 8, 9, 11, 14, 19, 22})
                .Should().BeTrue();
        }
    }
}