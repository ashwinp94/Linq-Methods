﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Restriction/Filtering Operations

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = (from fruit in fruits
                                           where fruit.StartsWith("L")
                                           select fruit).ToList();
            Console.WriteLine("---------------------");
            Console.WriteLine("fruits that start with 'L'");
            foreach (string fru in LFruits)
            {
                Console.WriteLine($"{fru}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);
            Console.WriteLine("---------------------");
            Console.WriteLine("numbers that are divisible by 4 or 6");

            foreach (int c in fourSixMultiples)
                Console.WriteLine($"{c}");

            //Ordering Operations

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

            List<string> descend = names.OrderByDescending(x => x).ToList();
            Console.WriteLine("---------------------");
            Console.WriteLine("Names in descending order");


            foreach (string c in descend)
            {
                Console.WriteLine($"{c}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers1 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            Console.WriteLine("---------------------");
            Console.WriteLine("Numbers in ascending order");


            List<int> orderedNumbers = numbers1.OrderBy(x => x).ToList();

            foreach (int c in orderedNumbers)
            {
                Console.WriteLine($"{c}");
            }

            //Aggregate Operations

            // Output how many numbers are in this list
            List<int> numbers2 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            int countNumbers = numbers2.Count();

            Console.WriteLine("---------------------");
            Console.WriteLine($"there are {countNumbers} numbers in the list");


            // How much money have we made?
            List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };

            double totalMoney = purchases.Sum();

            Console.WriteLine("---------------------");
            Console.WriteLine($"We made: ${totalMoney}");


            // What is our most expensive product
            List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

            double mostExpensive = prices.Max<double>();
            // or can do 'double mostExpensive = prices.OrderByDescending(x=>x).First();'
            Console.WriteLine("---------------------");
            Console.WriteLine($"The most expensive thing costs: ${mostExpensive}");


            /*
                        Partitioning Operations

                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */

            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            IEnumerable<int> perfectSquare = wheresSquaredo.TakeWhile(n => ((Math.Sqrt(n) % 1) != 0));

            Console.WriteLine("---------------------");
            foreach(int c in perfectSquare)
            {
                Console.WriteLine($"List of numbers before perfect square {c}");
            }



        }
    }
}
