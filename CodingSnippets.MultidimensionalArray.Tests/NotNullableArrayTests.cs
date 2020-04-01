using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodingSnippets.MultidimensionalArray.Tests
{
    public class NotNullableArrayTests
    {
        [Test]
        public void Should_throw_exception_when_initialized_with_null()
        {
            Assert.Throws<ArgumentNullException>(() => NotNullableArray.Init(null));
        }

        [Test]
        public void Should_NOT_throw_exception_when_initialized_with_number()
        {
            Assert.DoesNotThrow(() => NotNullableArray.Init(1));
            Assert.AreEqual(new[] {1}, NotNullableArray.Init(1));
        }

        [Test]
        public void Should_NOT_throw_exception_when_initialized_with_char()
        {
            Assert.DoesNotThrow(() => NotNullableArray.Init(1));
            Assert.AreEqual(new[] {'1'}, NotNullableArray.Init('1'));
        }

        [Test]
        public void Should_NOT_throw_exception_when_initialized_with_list()
        {
            Assert.DoesNotThrow(() => NotNullableArray.Init(1));
            Assert.AreEqual(new[] {123}, NotNullableArray.Init(new[] {123}));
        }
    }
}
