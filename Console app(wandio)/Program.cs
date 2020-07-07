using System;
using System.Collections.Generic;
using Wandio.Extension;
using Wandio.Extension.FirstOrNew;
using static System.Console;

namespace Wandio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { };

            Predicate<int> check = CheckValueInList;

            var result = arr.ThisDoesntMakeAnySense<int>(check);
        }

        public static bool CheckValueInList(int x)
        {
            return true;
        }

        public static bool Check(List<int> list, int x)
        {
            foreach (var item in list)
            {
                if (item == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


