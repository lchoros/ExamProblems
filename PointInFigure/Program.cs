using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool insideOne = (x <= 10 && x >= 4) && (y <= 3 && y >= -5);
            bool insideTwo = (x <= 12 && x >= 2) && (y <= 1 && y >= -3);

            if(insideOne || insideTwo)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

        }
    }
}
