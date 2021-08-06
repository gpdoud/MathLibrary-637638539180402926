using MathLibrary;

using System;

using Xunit;

namespace TestMathLibrary {

    public class TestMathLib {

        [Theory]
        [InlineData(4, 2, 0)]
        [InlineData(5, 2, 1)]
        public void TestMod(int a, int b, int mod) {
            Assert.Equal(mod, MathIntLibrary.Mod(a, b));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 1)]
        [InlineData(1, -2, -1)]
        public void TestAdd(int a, int b, int sum) {
            Assert.Equal(sum, MathIntLibrary.Add(a, b));
        }

        [Fact]
        public void TestZero() {
            Assert.Equal(0, MathIntLibrary.Zero());
        }
    }
}
