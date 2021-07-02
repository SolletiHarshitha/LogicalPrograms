using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class SquareRoot
    {
        //Reading the input
        public static void ReadInput()
        {
            Console.WriteLine("Enter number : ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter power value : ");
            double acc = Convert.ToDouble(Console.ReadLine());
            root(num, acc);
        }

        //Finding the squareroot of a number
        public static void root(double num,double acc)
        {
            double x = num;

            // The closed guess will be stored in the root
            double root;

            // To count the number of iterations
            int count = 0;

            while (true)
            {
                count++;

                // Calculate more closed x
                root = 0.5 * (x + (num / x));

                // Check for closeness
                if (Math.Abs(root - x) < acc)
                    break;

                // Update root
                x = root;
            }
            Console.WriteLine("the squareroot of "+num+" is : {0:0.00} ",root);
        }

    }
}
