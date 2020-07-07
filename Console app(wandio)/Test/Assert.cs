using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Wandio.Test
{
    public class Assert
    {
        public static void AreEqual(IEnumerable<int> excepted, IEnumerable<int> actual)
        {
            try
            {
                if (excepted == null || actual == null)
                {
                    throw new ArgumentNullException();
                }

                var result = excepted.SequenceEqual(actual);

                if (result == true)
                {
                    WriteLine(@$"Result: {true}");
                    Excepted(excepted);
                    WriteLine();
                    Actual(actual);
                }
                else
                {
                    WriteLine(@$"Result: {false}");
                    Excepted(excepted);
                    WriteLine();
                    Actual(actual);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            }
        }

        public static void Excepted(IEnumerable<int> list)
        {
            Write("Excepted: ");

            foreach (var item in list)
            {
                Write(item + " ");
            }
        }

        public static void Actual(IEnumerable<int> list)
        {
            Write("Actual: ");

            foreach (var item in list)
            {
                Write(item + " ");
            }
        }
    }
}
