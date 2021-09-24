using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment3.Tests {
    public class ExtensionsTests {
        [Fact]
        public void Flatten_Given_Nested_Array_1through6_returns_Single_Array_1through6() {
            IEnumerable<int>[] list = {new[] {1, 2}, new[] {3, 4}, new[] {5, 6}};
            var result = list.Flatten();
            Assert.Equal(new[] {1, 2, 3, 4, 5, 6}, result);
        }
        
        [Fact]
        public void Flatten_GivenNullList_SkipNullList() {
            IEnumerable<int>[] list = {new[] {1, 2}, new[] {3, 4}, null, new[] {5, 6}};
            var result = list.Flatten();
            Assert.Equal(new[] {1, 2, 3, 4, 5, 6}, result);
        }
    }
}