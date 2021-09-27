using System;
using Xunit;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Func_Product_returns_12_when_multiplying_3_by_4()
        {
            Assert.Equal(12, Extensions.Product(3,4));
           
        }

        [Fact]
        public void Func_Revers_returns_olleh_when_given_hello()
        {
            Assert.Equal("olleh", Extensions.Reverse("hello"));
        }

        [Fact]
        public void Func_IsNumericallyEqual_returns_true_for_string0042_and_integer_42()
        {
            Assert.True(Extensions.IsNumericallyEqual(42, "0042")); 
        }
    }
}
