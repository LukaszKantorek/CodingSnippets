using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CodingSnippets.MultidimensionalArray.Tests
{
    class SelectManyTests
    {
        [Test]
        public void SelectManyTest()
        {
            var twoDimentionalList = new List<List<int>>
            {
                new List<int> {1, 1, 2},
                new List<int> {3, 4}
            };

            var flattenList = twoDimentionalList
                .SelectMany(x => x)
                .Distinct();

            Assert.AreEqual(new List<int>{1, 2, 3, 4}, flattenList);
        }
    }
}
