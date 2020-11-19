using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));
            Console.WriteLine("Fruits that start with L: ");
            foreach (string fruit in LFruits)
            {
                Console.Write($"{fruit}, ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            Console.WriteLine("Numbers filtered, multiples of 4 or 6: ");
            foreach (int number in fourSixMultiples)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };
            IEnumerable<string> namesSorted = names.OrderByDescending(a => a);
            Console.WriteLine("Names sorted in Descending Order: ");
            foreach (string name in namesSorted)
            {
                Console.Write($"{name}, ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersForOrdering = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> numbersSorted = numbersForOrdering.OrderBy(n => n);
            Console.WriteLine("Numbers sorted in Ascending Order: ");
            foreach (int number in numbersSorted)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            // Output how many numbers are in this list
            List<int> numbersToAggregate = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine($"Count of numbers in list: {numbersToAggregate.Count()}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine($"We have made: ${purchases.Sum()}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            IEnumerable<double> sortedPrices = prices.OrderByDescending(n => n);
            double largestPrice = sortedPrices.First();
            Console.WriteLine($"Most expensive product costs ${largestPrice}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> stopAtSquare = wheresSquaredo.TakeWhile(num => !(Math.Sqrt(num) % 1 == 0)).ToList();
            Console.WriteLine("Stop at perfect square: ");
            foreach (int number in stopAtSquare)
            {
                Console.Write($"{number}, ");
            }
        }
    }
}
