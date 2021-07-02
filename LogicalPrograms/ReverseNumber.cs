using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        //Reading the input
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Reverse(num);
        }

        //Reversing the given number
        private static void Reverse(int num)
        {
            int a = num;
            int rev = 0;
            while(num!=0)
            {
                rev = rev*10 + (num % 10);
                num /= 10;
            }
            Console.WriteLine("The reverse of a number " + a + " is : "+rev); ;
        }
    }
}
