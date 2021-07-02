using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Choosing an option for which program to perform
            Console.WriteLine("Select an option"); 
            Console.WriteLine("1.Fibonacci series");
            Console.WriteLine("2.Perfect Number or not");
            Console.WriteLine("3.Prime Number or not");
            Console.WriteLine("4.Reverse a number");
            Console.WriteLine("5.Coupon Numbers");
            Console.WriteLine("6.Stimulate a stopwatch");
            Console.WriteLine("7.Day of Week");
            Console.WriteLine("8.Temperature conversion");
            Console.WriteLine("9.Monthly Payment");
            Console.WriteLine("10.Squareroot of a number");
            Console.WriteLine("11.Decimal to Binary Conversion");
            Console.WriteLine("12.Binary");
            Console.WriteLine("Enter an option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries.ReadInput();
                    break;
                case 2:
                    PerfectNumber.ReadInput();
                    break;
                case 3:
                    PrimeNumber.ReadInput();
                    break;
                case 4:
                    ReverseNumber.ReadInput();
                    break;
                case 5:
                    CouponNumbers.ReadInput();
                    break;
                case 6:
                    StopwatchProblem.ReadInput();
                    break;
                case 7:
                    DayOfWeek.ReadInput();
                    break;
                case 8:
                    TemperatureConversion.ReadInput();
                    break;
                case 9:
                    MonthlyPayment.ReadInput();
                    break;
                case 10:
                    SquareRoot.ReadInput();
                    break;
                case 11:
                    DecimalToBinary.ReadInput();
                    break;
                case 12:
                    Binary.ReadInput();
                    break;
            }  
        }
    }
}
