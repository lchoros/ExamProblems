using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 3;
            Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));

            int middleDots = (width - 5) / 2;
            for (int row = 1; row <= n-1; row++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', row), new string('.', middleDots));
                middleDots--;
            }
            middleDots ++;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }

            Console.WriteLine("{0}", new string('*', width));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }

            for (int row = 1; row <= n-1; row++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n-row), new string('.', middleDots));
                middleDots++;
            }


            Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));

        }
    }
}
