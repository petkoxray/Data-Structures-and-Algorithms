using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Remove_ODD_Occurence
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!dict.ContainsKey(list[i]))
                {
                    dict.Add(list[i], 0);
                }

                dict[list[i]]++;
            }

            var filtred = dict.Where(x => x.Value % 2 == 0);
            Console.WriteLine(string.Join(" ", filtred));
        }
    }
}
