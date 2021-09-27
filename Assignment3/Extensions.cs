using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment3 {
    public static class Extensions {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) =>
            items.SelectMany(itemList => itemList ?? new List<T>());
        
        public static bool IsSecure(this Uri uri) => uri.Scheme == Uri.UriSchemeHttps;

        public static int WordCount(this string input) => new Regex(@"\p{L}+").Matches(input).Count;

        public static Func<string, string> Reverse = (input) => new(input.Reverse().ToArray());

        public static Func<int, int, int> Product = (a, b) => a * b;

        public static Func<int, string, bool> IsNumericallyEqual = (num, str) => Int32.Parse(str).Equals(num);
    }
}