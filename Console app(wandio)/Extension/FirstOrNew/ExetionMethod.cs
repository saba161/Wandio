using System;
using System.Collections.Generic;

namespace Wandio.Extension.FirstOrNew
{
    public static class ExetionMethod
    {
        public static T FirstOrNew<T>(this IEnumerable<T> list)
            where T : new()
        {
            if (list == null)
            {
                throw new ArgumentException("Value can't be null");
            }

            var enumerator = list.GetEnumerator();

            if (enumerator.MoveNext())
            {
                return enumerator.Current;
            }

            return new T();
        }
    }
}
