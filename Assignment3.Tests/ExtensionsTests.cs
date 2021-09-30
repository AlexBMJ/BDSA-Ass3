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

        [Fact]
        public void IsSecure_return_true_if_startswith_https_and_endswith_com(){
            Uri uri = new Uri("https://docs.microsoft.com/");
            Assert.True(uri.IsSecure());
        }

        [Fact]
        public void IsSecure_return_true_if_startswith_https_and_endswith_dk()
        {
            Uri uri = new Uri("https://magicweb.dk/");
            
            Assert.True(uri.IsSecure());
        }

        [Fact]
        public void WordCount_returns_8_for_word_facebook()
        {
            string input = "facebook";
            
            Assert.Equal(1, input.WordCount());
        }

        [Fact]
        public void WordCount_returns_8_for_word_HelloWorld_123123()
        {
            string input = "Hello World 123123";
            
            Assert.Equal(2, input.WordCount());
        }
    }
}