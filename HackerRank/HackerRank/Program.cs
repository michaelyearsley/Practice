using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 1, 0, -1, -1 };
            plusMinus(num);
            staircase(5);
            List<int> a = new List<int>() { 1, 10, 6};
            List<int> b = new List<int>() { 3, 10, 9};
            Console.WriteLine(String.Join(", ", compareTriplets(a, b)));
            int[] num1 = new int[] { 5, 5, 5, 5, 5 };
            miniMaxSum(num1);
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
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int countA = 0;
            int countB = 0;
            List<int> results = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    countA++;
                }
                else if (a[i] < b[i])
                {
                    countB++;
                }
            }
            results.Add(countA);
            results.Add(countB);
            return results;
        }
        static void miniMaxSum(int[] arr)
        {
            int min = arr[0];
            int max = 0;
            long sumMin = 0;
            long sumMax = 0;
            foreach (int item in arr)
            {
                if (min > item)
                {
                    min = item;
                }
                if (max < item)
                {
                    max = item;
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if (min == max)
                {
                    sumMin = (arr.Length - 1) * min;
                    sumMax = (arr.Length - 1) * max;
                break;
                }
                else if (arr[i] == min)
                {
                    sumMin = sumMin + arr[i];
                }
                else if(arr[i] == max)
                {
                    sumMax = sumMax + arr[i];
                }
                else
                {
                    sumMax = sumMax + arr[i];
                    sumMin = sumMin + arr[i];
                }
            }
            Console.WriteLine("{0} {1}", sumMin, sumMax);
        }
    }
}
