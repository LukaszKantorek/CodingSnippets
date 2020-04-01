using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CodingSnippets.MultidimensionalArray.Tests
{
    public class Tests
    {
        [Test]
        public void Should_throw_exception_being_invoked_with_null_parameter()
        {
            Assert.Throws<ArgumentNullException>(
                () => ((object) null).ToFlattenArray());
        }

        [Test]
        public void Should_create_flat_list_from_single_integer()
        {
            const int number = 1;

            var flatArray = number.ToFlattenArray();

            var expectedFlatList = new object[] { 1 };

            Assert.AreEqual(expectedFlatList, flatArray);
        }

        [Test]
        public void Should_flatten_multidimensional_array_of_numbers()
        {
            var arrayWithNumbers = new object [] {1, 2, 3, new [] {4, 5, 6}};

            var flatArray = arrayWithNumbers.ToFlattenArray();

            var expectedFlatList = new object[] { 1, 2, 3, 4, 5, 6 };

            Assert.AreEqual(expectedFlatList, flatArray);
        }

        [Test]
        public void Should_flatten_more_complicated_multidimensional_array_of_numbers()
        {
            var arrayWithNumbers = new object[] { 1, 2, new object[] { 3, 4 , new[] { 5, 6 } } };

            var flatArray = arrayWithNumbers.ToFlattenArray();

            var expectedFlatList = new object[] { 1, 2, 3, 4, 5, 6 };

            Assert.AreEqual(expectedFlatList, flatArray);
        }

        [Test]
        public void should_flatten_list_with_different_types_of_variables()
        {
            var arrayWithNumbers = new object[] { 1, '2', new object[] { 3, (short)4, new object[] { '5', (long)6 } } };

            var flatArray = arrayWithNumbers.ToFlattenArray();

            var expectedFlatList = new object[] { 1, '2', 3, (short)4, '5', (long)6 };

            Assert.AreEqual(expectedFlatList, flatArray);
        }

        [Test]
        public void Should_flat_groups_of_different_IEnumerables_lists()
        {
            var arrayWithNumbers = new object[] { 1, new List<object> {2, 3}, new HashSet<object> {4, 5}, new object [] {6, 7} };

            var flatArray = arrayWithNumbers.ToFlattenArray();

            var expectedFlatList = new object[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.AreEqual(expectedFlatList, flatArray);
        }
    }
}