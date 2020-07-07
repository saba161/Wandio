using System;
using System.Collections.Generic;

namespace Wandio.Extension
{
    public static class ExetionMethodForList
    {
        public static IEnumerable<T> ThisDoesntMakeAnySense<T>(this List<T> list, Predicate<T> check)
        {
            return list;
        }
    }
}

