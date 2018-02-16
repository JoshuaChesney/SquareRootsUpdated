using System;
using System.Linq;
using System.Diagnostics;

namespace Rooter
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSquares(0, 999999999999999999); //Find all applicable numbers up to an abritrarily large number
        }

        public static bool IsPerfectSquare(ulong num) //Determines if a number is a perfect square
        {
            double squareRoot = Math.Sqrt(num);
            bool isSquare = squareRoot % 1 == 0;
            return isSquare;
        }

        public static ulong IncreaseNums(ulong num) //Increases each digit in a number by 1
        {
            {
                ulong strlen = (ulong) num.ToString().Length;
                ulong ones = 0;
                for (ulong i = 1, p = 1; i <= strlen; p *= 10, i++)
                {
                    ones += p;
                }
                return num + ones;
            }
        }

        public static void FindSquares(ulong x, ulong y) //Main code to find applicable numbers from x to y
        {
            x = (ulong) Math.Sqrt((double) x);
            y = (ulong) Math.Sqrt((double) y);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (ulong i = x; i < y; i++)
            {
                if (IsPerfectSquare(IncreaseNums(i*i)))
                {
                    Console.WriteLine(i*i + " " + watch.Elapsed);
                }
            }


        }
    }


}
