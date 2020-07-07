using System;
using System.Collections.Generic;
using System.Linq;
using Wandio.Extension;
using static System.Console;
using static Wandio.Test.Assert;

namespace Wandio
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            var listOfInts = numbers
                .Split(',')
                .Select(Int32.Parse).ToList();

            //First Test
            WriteLine($"Input: {numbers}");
            AreEqual
                (
                    listOfInts,
                    listOfInts.ThisDoesntMakeAnySense(x => x == 3, () => 3)
                );

            WriteLine();

            //Second Test
            WriteLine($"Input: {numbers}");
            AreEqual
                (
                    listOfInts,
                    listOfInts.ThisDoesntMakeAnySense(x => x == 10, () => 10)
                );

            WriteLine();

            //Three Test

            List<int> list = null;

            WriteLine($"Input: {numbers}");
            AreEqual
                (
                    null,
                    list.ThisDoesntMakeAnySense(x => x == 1, () => 19)
                );
        }
    }
}