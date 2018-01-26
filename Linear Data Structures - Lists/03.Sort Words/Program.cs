using System;
using System.Linq;

namespace _03.Sort_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();
            var sorted = list.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
