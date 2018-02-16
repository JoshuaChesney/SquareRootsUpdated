using System;
using System.Linq;
using System.Diagnostics;

namespace Rooter
{
    class Program
    {
        static void Main(string[] args)
        {
            MainFunction(0, 999999999999999999);
        }

        public static bool IsPerfectSquare(long num)
        {
            double squareRoot = Math.Sqrt(num);
            bool isSquare = squareRoot % 1 == 0;
            return isSquare;
        }

        public static long IncreaseNums(long num)
        {
            {
                string numString = num.ToString();
                string ones = "";
                for (int i = 0; i < numString.Length; i++)
                {
                    ones += "1";
                }
                return Convert.ToInt64(numString) + Convert.ToInt64(ones);
            }
        }

        public static void MainFunction(int x, long y)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = x; i < y; i++)
            {
                if (!((i.ToString()).Contains('9')) & i.ToString().EndsWith("25"))
                {
                    if (IsPerfectSquare(i))
                    {
                        if (IsPerfectSquare(IncreaseNums(i)))
                        {
                            Console.WriteLine(i + " " + watch.Elapsed);
                        }
                    }
                }
            }


        }
    }


}
