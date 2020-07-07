using System;
using System.Collections.Generic;
using System.Linq;
using Wandio.Extension;
using static System.Console;

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

            VariantOne(listOfInts); //return new list with new item

            WriteLine(" ");

            VariantTwo(listOfInts); //return default list

            WriteLine(" ");

            VariantThree(listOfInts); //return Exeption
        }

        public static void VariantOne(List<int> listOfInts)
        {
            WriteLine("Add new element");

            Input(listOfInts);

            var resultOne = listOfInts.ThisDoesntMakeAnySense<int>(x => x == 5, () => 5);
            WriteLine(" ");

            Output(resultOne);
        }

        public static void VariantTwo(List<int> listOfInts)
        {
            WriteLine("default list");

            Input(listOfInts);

            var resultTwo = listOfInts.ThisDoesntMakeAnySense<int>(x => x == 3, () => 3);

            WriteLine(" ");

            Output(resultTwo);
        }

        public static void VariantThree(List<int> listOfInts)
        {
            WriteLine("List is NUll");

            Input(listOfInts);

            var resultThree = listOfInts.ThisDoesntMakeAnySense<int>(x => x == 3, () => 3);

            WriteLine(" ");

            Output(resultThree);
        }

        public static void Input(IEnumerable<int> list)
        {
            Write("Input: ");

            foreach (var item in list)
            {
                Write(item + " ");
            }
        }

        public static void Output(IEnumerable<int> list)
        {
            Write("Output: ");

            foreach (var item in list)
            {
                Write(item + " ");
            }
        }
    }
}