using System;
using Xunit;

namespace FooLibTests.Integration
{
    public class IntegrationTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.False(false);
        }

        [Fact]
        [Trait("Category", "Interactive")]
        public void Test3()
        {
            Assert.False(false);
        }

        [Fact]
        [Trait("Category", "Interactive")]
        public void Test4()
        {
            Assert.False(false);
        }
    }
}
