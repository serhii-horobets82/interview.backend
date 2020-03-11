using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend
{
    public static class Extension
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }

    public class Task4
    {

        public void Execute()
        {
            int[] values = Enumerable.Range(1, 100).ToArray();
            var evenNumbers = values.MyWhere(x => x % 2 == 0).Take(3).ToList();
            evenNumbers.ForEach(i => Console.Write("{0}\t", i));
        }
    }
}