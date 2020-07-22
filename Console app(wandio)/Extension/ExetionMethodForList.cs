using System;
using System.Collections.Generic;

namespace Wandio.Extension
{
    public static class ExetionMethodForList
    {
        public static IEnumerable<T> ThisDoesntMakeAnySense<T>(this List<T> list, Func<T, bool> check, Func<T> generator)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }

            var enumerator = list.GetEnumerator();

            foreach (var item in list)
            {
                if (enumerator.MoveNext() == check(enumerator.Current))
                {
                    return list;
                }
            }

            list.Add(generator());

            return list;
        }
    }
}