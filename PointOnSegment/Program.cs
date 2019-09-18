using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int min = Math.Min(x1, x2);
            int max = Math.Max(x1, x2);
            if(point <= max && point >= min)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            Console.WriteLine(Math.Min(Math.Abs(min -point), Math.Abs(max -point)));
        }
    }
}
