using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class DecimalToBinary
    {
        public static int num;
        public static int [] binary=new int [32];

        //Reading the input
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            ToBinaryConversion();
        }

        //Convert from Decimal to Binary
        public static void ToBinaryConversion()
        { 
            int i = 0,a=num,count=8;
            while (a>0)
            {
                binary[i] = a% 2;
                a /= 2;
                i++;
            }
            for(int j=i;j<count;j++)
            {
                binary[j] = 0;
            }
            Console.Write("The Binary form of " + num + " is : ");
            for (int j=i-1;j>=0;j--)
            {
                Console.Write(binary[j]);
            }
            Console.WriteLine();
        }
    }
}
