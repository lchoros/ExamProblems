﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfterFiveDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int daysInMonth = 31;
            if (month == 2)
            {
                daysInMonth = 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysInMonth = 30;
            }
            day += 5;
            if(day + 5 > daysInMonth)
            {
                if(month == 12)
                {
                    month = 1;
                }
                else
                {
                    month++;
                }
                day = 5 - (daysInMonth - day);
            }
            else
            {
                day += 5;
            }
            Console.WriteLine("{0}.{1:00}", day, month);
        }
    }
}
