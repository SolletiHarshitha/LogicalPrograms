using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Binary
    {
        public static int count = 8, i, j = 0;

        //Reading the input
        public static void ReadInput()
        {
            DecimalToBinary.ReadInput();
            int num = DecimalToBinary.num;
            int[] binary = DecimalToBinary.binary;
            int[] swapBinaryNumber = new int[32];
            SwapNibbles(binary, swapBinaryNumber);
            Console.WriteLine("\n");
        }

        // Printing binary array in reverse order
        public static void SwapNibbles(int[] binary, int[] swapBinaryNumber)
        {
            //Adding first half of 8 bits in reverse order
            for (i = count / 2 - 1; i >= 0; i--)
            {
                swapBinaryNumber[j] = binary[i];
                j++;
            }
            //Adding second half of 8 bits in reverse order
            for (i = count - 1; i > count / 2 - 1; i--)
            {
                swapBinaryNumber[j] = binary[i];
                j++;
            }
            //Printing the binary form after swapping
            Console.Write("Binary form of a number after Swap nibbles : ");
            for (i = 0; i < count; i++)
                Console.Write(swapBinaryNumber[i]);
            ToDecimalConversion(swapBinaryNumber);
        }

        //Convert from Binary to Decimal
        public static void ToDecimalConversion(int[] swapBinaryNumber)
        {

            int decimalNumber = 0, baseVal = 1, n;

            for (i = count - 1; i >= 0; i--)
            {
                n = swapBinaryNumber[i];
                decimalNumber = decimalNumber + n * baseVal;
                baseVal = baseVal * 2;
            }

            Console.Write("\nDecimal Number after Swap nibbles : " + decimalNumber + "\n");
            PowerOf2(decimalNumber);
        }

        //Finding the decimal number is power of 2 or not
        public static void PowerOf2(int decimalNumber)
        { 

            Boolean result = (int)(Math.Ceiling(Math.Log(decimalNumber) / Math.Log(2))) == (int)(Math.Floor(Math.Log(decimalNumber) / Math.Log(2)));

            if (result)
                Console.WriteLine("The number " + decimalNumber + " is a power of 2 \n");
            else
                Console.WriteLine("The number " + decimalNumber + " is not a power of 2\n");
        }
    }
}
