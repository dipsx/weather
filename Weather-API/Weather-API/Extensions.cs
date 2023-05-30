using System;
using System.Collections.Generic;

namespace Weather_API {
    public static class Extensions {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action) {
            if (collection == null) {
                return;
            }

            foreach (T item in collection) {
                action(item);
            }
        }
    }
}
