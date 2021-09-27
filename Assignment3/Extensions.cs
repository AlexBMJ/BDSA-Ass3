using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) =>
            items.SelectMany(itemList => itemList ??new List<T>());

    
        public static bool IsSecure(this Uri link)
        {
            return link.AbsoluteUri.StartsWith("http") && (link.AbsoluteUri.EndsWith(".com/") || link.AbsoluteUri.EndsWith(".dk/") || link.AbsoluteUri.EndsWith(".org/"));
        }

        public static int WordCount(this string input){
            Regex regex = new Regex("[a-zA-Z]");
            var matches = regex.Matches(input);
            int counter = 0;
            foreach (var match in matches){
                counter++;
            }
            return counter;
        }

        public static string ReverseString(string input){
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static bool NumberIsEqual(int number, string input){
            return Int32.Parse(input).Equals(number);
        }

        //1
        public static Func<string, string> Reverse = ReverseString;

        // 2.
         public static Func<int, int, int> Product = (a, b) => a * b;

         //3
         public static Func<int, string, bool> IsNumericallyEqual = NumberIsEqual;
    }
    
}
