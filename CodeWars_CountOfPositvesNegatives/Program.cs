using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_CountOfPositvesNegatives
{
    class Program
    {
        static void Main()
        {
            // https://www.codewars.com/kata/576bb71bbbcf0951d5000044
            int[] output = CountPositivesSumNegatives(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 });
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            output = CountPositivesSumNegatives(new int[] { });
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            Console.ReadKey();
        }

        // First solution
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null)
                return new int[] { };

            int positives = 0, negatives = 0;
            foreach (var item in input)
            {
                if (item.ToString().Contains('-'))
                    negatives += item;
                else
                  if (item > 0)
                    positives++;
            }

            return positives != 0 && negatives != 0 ? new int[] { positives, negatives } : new int[] { };
        }

        // Refactored solution
        public static int[] CountPositivesSumNegativesTwo(int[] input)
        {
            return (input == null || input.Length == 0) ? new int[0] : new int[] { input.Count(x => x > 0), input.Where(x => x < 0).Sum() };
        }
    }
}
