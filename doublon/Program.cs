using System;
using System.Collections.Generic;
using System.Linq;

namespace doublon
{
    internal class Program
    {
        private static List<int> myArray = new List<int>(100);

        private static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();

                myArray = Enumerable.Repeat(0, myArray.Capacity).Select(e => rand.Next(1, 6)).Distinct().OrderBy(e => e).ToList();

                foreach (var VARIABLE in myArray)
                {
                    Console.Write(VARIABLE + " ");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}