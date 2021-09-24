using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public static class Extensions {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) =>
            items.SelectMany(itemList => itemList ??new List<T>());
    }
}
