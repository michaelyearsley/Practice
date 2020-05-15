using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 1, 0, -1, -1 };
            plusMinus(num);
            staircase(5);
        }
        static void plusMinus(int[] arr)
        {
            double countNeg = 0.0;
            double count0 = 0.0;
            double countPos = 0.0;
            foreach (var item in arr)
            {
                if (item == 0)
                {
                    count0++;
                }
                else if (item > 0)
                {
                    countPos++;
                }
                else if (item < 0)
                {
                    countNeg++;
                }
            }
            countNeg = Math.Round((countNeg / arr.Length), 6);
            count0 = Math.Round((count0 / arr.Length), 6);
            countPos = Math.Round((countPos / arr.Length), 6);
            Console.WriteLine(countPos);
            Console.WriteLine(countNeg);
            Console.WriteLine(count0);
        }
        static void staircase(int n)
        {
            string[] step = new string[n];
            for (int i = 0; i < n; i++)
            {

                if (i == n - 1)
                {
                    step[i] = "#";
                }
                else
                {
                    step[i]=" ";
                }
            }
            while (n > 0)
            {
                step[n-1] = "#";
                Console.WriteLine(String.Join("", step));
                n--;
            }
        }
    }
}
