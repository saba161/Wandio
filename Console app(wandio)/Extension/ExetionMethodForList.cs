using System;
using System.Collections.Generic;
using System.Linq;

namespace Wandio.Extension
{
    public static class ExetionMethodForList
    {
        public static IEnumerable<T> ThisDoesntMakeAnySense<T>(this List<T> list, Func<T, bool> check, Func<T> generator)
        {
            if(list == null)
            {
                throw new ArgumentNullException();
            }

            if (!list.Any(check))
            {
                list.Add(generator.Invoke());
            }

            return list;
        }
    }
}

