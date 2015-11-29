﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Collections.Generic;

namespace PapyrusDotNet.Common.Extensions
{
    public static class CollectionExtensions
    {
        public static bool Contains<T>(this Collection<T> collection, Func<T, bool> predicate)
        {
            return collection.Any(predicate);
        }
        public static bool Contains<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Any(predicate);
        }
        public static void EnsureAdd<T>(this List<T> collection, T value)
        {
            if (collection == null) throw new NullReferenceException();
            if (!collection.Contains(value))
                collection.Add(value);
        }

        public static void EnsureAdd<T>(this IList<T> collection, T value)
        {
            if (collection == null) throw new NullReferenceException();
            if (!collection.Contains(value))
                collection.Add(value);
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> a)
        {
            if (a == null) return;
            foreach (var c in collection)
            {
                a(c);
            }
        }
        public static void ForEach(this IEnumerable collection, Action<object> a)
        {
            if (a == null) return;
            foreach (var c in collection)
            {
                a(c);
            }
        }
    }
}
