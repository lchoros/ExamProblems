using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = decimal.Parse(Console.ReadLine());
            double term = int.Parse(Console.ReadLine());
            decimal bankInterest = decimal.Parse(Console.ReadLine());
            decimal friendInterest = decimal.Parse(Console.ReadLine());

            double d = Math.Pow(1.0 + (double)bankInterest, term);
            decimal futureBankValue = price * (decimal)d;
            decimal futureFriendValue = price * (1M + friendInterest);


            if(futureBankValue < futureFriendValue)
            {
                Console.WriteLine("{0:f2} Bank", futureBankValue);
            }
            else
            {
                Console.WriteLine("{0:f2} Friend", futureFriendValue);
            }
        }
    }
}
