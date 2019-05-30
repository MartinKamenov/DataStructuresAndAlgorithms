using DSA_CSharp.src.Sorting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.SortingTests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void MergeSortSortsCorrectlyTenNumbers()
        {
            // Arrange
            int[] numbers = new int[] { 1, 202, 14, 0, -5, 16, 7, 3, 66, 10 };

            //Act
            int[] sortedNumbers = MergeSort<int>.MergeSortWithoutAllocatingArray(numbers);

            //Assert
            Assert.That(
                sortedNumbers, 
                Is.EquivalentTo(new int[] { -5, 0, 1, 3, 7, 10, 14, 16, 66, 202 }),
                "Array is not sorted ascending"
            );
        }

        [Test]
        public void MergeSortReturnsEmptyArrayWhenNoArrayIsPassed()
        {
            // Arrange
            int[] numbers = new int[0];

            //Act
            int[] sortedNumbers = MergeSort<int>.MergeSortWithoutAllocatingArray(numbers);

            //Assert
            Assert.That(
                sortedNumbers,
                Is.EquivalentTo(new int[0]),
                "Array is not sorted ascending"
            );
        }

        [Test]
        public void MergeSortWorksCorrectlyWithOneElemenent()
        {
            // Arrange
            int[] numbers = new int[] { 1 };

            //Act
            int[] sortedNumbers = MergeSort<int>.MergeSortWithoutAllocatingArray(numbers);

            //Assert
            Assert.That(
                sortedNumbers,
                Is.EquivalentTo(new int[] { 1 }),
                "Array is not sorted ascending"
            );
        }

        [Test]
        public void MergeSortWorksCorrectlyWithTwoElemenents()
        {
            // Arrange
            int[] numbers = new int[] { 2, 1 };

            //Act
            int[] sortedNumbers = MergeSort<int>.MergeSortWithoutAllocatingArray(numbers);

            //Assert
            Assert.That(
                sortedNumbers,
                Is.EquivalentTo(new int[] { 1, 2 }),
                "Array is not sorted ascending"
            );
        }
    }
}
