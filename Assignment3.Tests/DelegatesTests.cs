using System;
using Xunit;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Func_returns_12_when_multiplying_3_by_4()
        {
            Assert.Equal(12, Extensions.product(3,4));
           
        }

        [Fact]
        public void Func_returns_12_when_multiplying_3_y_4()
        {
            Assert.Equal("olleh", Extensions.reverse("hello"));
        }

        [Fact]
        public void Func_returns_12_when_multiplyg_3_y_4()
        {
            Assert.Equal(true, Extensions.isNumericallyEqual(42, "0042")); 
        }
    }
}
