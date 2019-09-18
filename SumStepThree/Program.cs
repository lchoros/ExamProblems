using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumStepThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < l; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    sum1 += n;
                }
                else if ((i-1) % 3 == 0)
                {
                    sum2 += n;
                }
                else
                {
                    sum3 += n;
                }
            }

            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
