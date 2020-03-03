using System;
using Xunit;

namespace LibraryApiIntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(true, true);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        public void CanAdd(int a, int b, int expectedResult)
        {
            var answer = a + b;
            Assert.Equal(expectedResult, answer);
        }
    }
}
