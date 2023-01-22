using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //WHERE
            List<int> numbers = new List<int>{2,4,6,8,16,32,64};
            var numberGreaterThanTen = numbers.Where(x => x > 10);
            foreach (var number in numberGreaterThanTen)
            {
                Console.WriteLine(number);
            }
            
            
            
            
        }
    }
}