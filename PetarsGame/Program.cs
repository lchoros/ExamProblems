using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetarsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int sum = 0;
            string result = string.Empty;
            for (int i = start; i < end; i++)
            {
                if(i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }
            string sumStr = sum.ToString();
            if (sum % 2 == 0)
            {
                var firstDigit = sumStr[0];
                for (int i = 0; i < sumStr.Length; i++)
                {
                    if(firstDigit == sumStr[i])
                    {
                        result += sign;
                    }
                    else
                    {
                        result += sumStr[i];
                    }
                }
            }
            else
            {
                var lstDigit = sum %= 10;
                var x = sumStr[0];
                for (int i = 0; i < sumStr.Length; i++)
                {
                    if (lstDigit == char.GetNumericValue(sumStr[i]))
                    {
                        result += sign;
                    }
                    else
                    {
                        result += sumStr[i];
                    }
                }
            }
            Console.WriteLine(result);
       }
    }
}
