using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        //Reading the Input
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeOrNot(num);
        }

        //Checking the number is prime or not
        private static void PrimeOrNot(int  num)
        {
            int flag = 0;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
            {
                Console.WriteLine(num+" is a prime number");
            }
            else
            {
                Console.WriteLine(num+" is not a prime number");
            }
        }
    }
}
