using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            var count = 0;

            foreach (var item in list)
            {
                count++;
            }

            if (count > 0)
            {
                return list.ElementAt(0);
            }

            return new T();
        }
    }
}
