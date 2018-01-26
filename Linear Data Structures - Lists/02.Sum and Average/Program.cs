using System;
using System.Linq;

namespace _02.Sum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}
