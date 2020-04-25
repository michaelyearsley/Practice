using System;
using System.ComponentModel.Design;

namespace AmazonPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 90, 85, 75, 60, 120, 150, 125 };
            int d;
            Movie(nums, d = 250);
        }
        public static void Movie(int[] nums, int d)
        {
            int movie1 = 0, movie2 = 0;
            d = d - 30;
            int[] nums2 = new int[] { movie1, movie2 };
            if (d == 0 || nums.Length <= 0)
                Console.WriteLine("no data");
            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (nums[i] + nums[j] > movie1 + movie2 && nums[i] + nums[j] < d)
                    {
                        movie1 = nums[i];
                        movie2 = nums[j];
                    }
                }
            }
            Console.WriteLine("({0}, {1}) = {2}", movie1, movie2, movie1 + movie2);
        }
        
        


    }
}
