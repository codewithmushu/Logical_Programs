using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Pragrams
{
    public class PrimeNumber
    {
        public static void CalcPrimeNumber()
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool IsPrimeNumber = true;

            if (num < 0)
            {
                IsPrimeNumber = false;
            }
            else
            {
               for (int i = 2; i <= Math.Sqrt (num); i++)
                {
                    if (num % i == 0)
                    {
                        IsPrimeNumber = false;
                        break;
                    }  
                }
            }
            if (IsPrimeNumber)
            {
                Console.WriteLine("{0} is Prime Number.", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number.", num);
            }
        }
    }
}
