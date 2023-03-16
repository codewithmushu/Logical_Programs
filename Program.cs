using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Pragrams
{
    public class Program
    {
        static void Main(string[] args)
        {


            // PerfectNumber.FindPerfectNumber();
            // FibonacciSeries.Display();
            //ReverseNumber.FindReverseNumber();
            //  PrimeNumber.CalcPrimeNumber();
            StopWatchProgram.CalElapseTime();


           // int[] couponNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Replace with your own distinct coupon numbers
            //int distinctCount = GetDistinctCouponCount(couponNumbers);
            //Console.WriteLine($"Total random number needed to have all distinct numbers: {(int)GetDistinctCouponCount(couponNumbers)}");


        }

        //private static int GetDistinctCouponCount(int[] couponNumbers)
        //{

        //    int distinctCount = 0;
        //    bool[] isCouponSelected = new bool[couponNumbers.Length];
        //    while (Array.IndexOf(isCouponSelected, false) != -1)
        //    {
        //        int randomNumber = GenerateRandomNumber(couponNumbers.Length);
        //        if (!isCouponSelected[randomNumber])
        //        {
        //            isCouponSelected[randomNumber] = true;
        //            distinctCount++;
        //        }
        //    }
        //    return distinctCount;

        //}   
        //public static int GenerateRandomNumber(int maxNumber)
        //{
        //        Random random = new Random();
        //        return random.Next(maxNumber);
        //}
        
    }
}
