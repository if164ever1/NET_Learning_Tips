using System;
using System.Collections.Generic;
using System.Linq;


namespace Linq
{
    public class Bird
    {
        public string Name { get; set; }
        public string  Color { get; set; }
        public int Sightings { get; set; }
    }
    
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
            
            //LINQ WITH OBJECTS
            List<Bird> birds = new List<Bird>
            {
                new Bird{Name = "Cardinal", Color = "Red", Sightings = 3},
                new Bird{Name = "Dove",Color = "White", Sightings = 2},
                new Bird{Name = "Robin", Color = "Red", Sightings = 5},
                new Bird{Name = "Blue Jay", Color = "Blue", Sightings = 1},
                new Bird{Name = "Canary", Color = "Yellow", Sightings = 0}
            };
            var redColor = birds.Where(bird => bird.Color == "Red").Select(x => x.Name);
            foreach (var number in redColor)
            {
                Console.WriteLine(number);
            }
        }
    }
}