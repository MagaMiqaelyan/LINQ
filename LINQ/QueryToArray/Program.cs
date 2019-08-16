using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryToArray
{
    internal class Program
    {
        public static IEnumerable<string> GetCity(string[] cities)
        {
            return from city in cities
                   where city.Contains('n') && city.EndsWith('e')
                   select city;
        }

        private static void Main(string[] args)
        {
            string[] cities = { "Yerevan", "Rome", "Milan", "Florence", "Venice", "Athens" };

            /// SQL syntax
            foreach (var city in GetCity(cities))
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();

            /// Method syntax
            var query = cities.Where(city => city.Contains('n') && city.EndsWith('e'));
            foreach (var city in query)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
        }
    }
}
