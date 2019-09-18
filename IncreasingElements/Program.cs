using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int previous = 0;
            int longest = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if(a > previous)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                longest = Math.Max(counter, longest);
                previous = a;
            }
            Console.WriteLine(longest);
        }
    }
}
