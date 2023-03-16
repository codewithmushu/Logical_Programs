using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Pragrams
{
    public class StopWatchProgram
    {
        public static void CalElapseTime()
        {
            Console.WriteLine("Press any key to start the stopwatch...");
            Console.ReadKey();

            DateTime StartTime = DateTime.Now;

            Console.WriteLine("\nPress any key to stop the stopwatch.... ");
            Console.ReadKey();

            DateTime EndTime = DateTime.Now;

            TimeSpan ElapsedTime = EndTime - StartTime;

            Console.WriteLine("\nElapsed time: " + ElapsedTime.ToString(@"hh\:mm\:ss\.fff"));
            Console.ReadKey();
        }
    }
}
