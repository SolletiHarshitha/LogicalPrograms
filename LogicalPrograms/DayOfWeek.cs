using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class DayOfWeek
    {
        //Printing the day of a date
        public static void ReadInput()
        {
            Console.WriteLine("Enter day :");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;
            switch(d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
