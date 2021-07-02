using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LogicalPrograms
{
    class StopwatchProblem
    {
        public static void ReadInput()
        {
            Stopwatch stopwatch = new Stopwatch();

            //Starting the timer
            Console.WriteLine("Please enter 1 to start the timer : ");
            int startTime = Convert.ToInt32(Console.ReadLine());
            stopwatch.Start();

            //Stoping the timer
            Console.WriteLine("Please enter 0 to stop the timer : ");
            int stopTime = Convert.ToInt32(Console.ReadLine());
            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);


        }
    }
}
