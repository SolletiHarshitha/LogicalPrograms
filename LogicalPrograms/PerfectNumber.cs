using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        //Reading the input 
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            PerfectOrNot(num);
        }

        //Checking the number is perfect or not
        private static void PerfectOrNot(int num)
        {
            int sum = 0;
            for(int i=1;i<num;i++)
            {
                if(num%i == 0)
                {
                    //Adding the factors of the number
                    sum += i;
                }
            }
            //If the sum of factors is equal to the number excluding itself then it is a perfect number
            if(sum==num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number");
            }
            
        }
    }
}
