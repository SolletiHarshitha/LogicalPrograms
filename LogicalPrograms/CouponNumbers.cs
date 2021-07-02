using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        //Reading the input
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter starting number of the coupon : ");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number of the coupon : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            generate(number, startNumber, endNumber);
        }

        //Generating random numbers
        private static void generate(int number,int startNumber,int endNumber)
        { 
            Random random = new Random();
            int randomCoupon = random.Next(startNumber, endNumber);
            List<int> listOfCoupons = new List <int>();
            listOfCoupons.Add(randomCoupon);
            //int count = 1;
            for(int i=1;i<number;i++)
            {
                if(!(listOfCoupons.Contains(randomCoupon)))
                {
                    listOfCoupons.Add(randomCoupon);
                }
                randomCoupon = random.Next(startNumber, endNumber);
            }
            foreach(int i in listOfCoupons)
            {
                Console.WriteLine("Coupon Number is : "+i);
            }

        }
    }
}
