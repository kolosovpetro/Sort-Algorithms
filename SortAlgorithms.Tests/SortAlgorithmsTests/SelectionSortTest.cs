using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using SortAlgorithms.Core.Interfaces;
using SortAlgorithms.Core.SortAlgorithms;

namespace SortAlgorithms.Tests.SortAlgorithmsTests
{
    [TestFixture]
    public class SelectionSortTest
    {
        [Test]
        public void Selection_Sort_Test()
        {
            var sequence = new[] {1, 9, 3, 7, 2, 6, 11, 14, 10, 6, 8, 19, 22};
            ISortAlgorithm sortAlgorithm = new SelectionSort();
            sortAlgorithm.SortSequence(sequence);
            sequence.SequenceEqual(new[] {1, 2, 3, 6, 6, 7, 8, 9, 10, 11, 14, 19, 22})
                .Should().BeTrue();
        }
    }
}