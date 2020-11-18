using System;
using Xunit;
using SonarQubeTest;

namespace SonarQubeTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = new SonarQubeTest.Test.TestClass(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            Assert.NotNull(x);
        }
    }
}
