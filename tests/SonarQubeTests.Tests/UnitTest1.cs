using SomeCode;
using System;
using Xunit;

namespace SonarQubeTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = new ClassTwo(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            Assert.NotNull(x);
        }
    }
}
