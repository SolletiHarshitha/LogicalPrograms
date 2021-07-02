using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class MonthlyPayment
    {
        //Calculating the monthly payment
        public static void ReadInput()
        {
            Console.WriteLine("Enter Principal amount : ");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of years : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest : ");
            int rate = Convert.ToInt32(Console.ReadLine());
            int n = 12 * year;
            double r =(double) rate / (12 * 100);
            double payment = (double)(principal * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("Monthly Payment is : "+payment);
        }
    }
}
