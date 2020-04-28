using System;
using System.IO.MemoryMappedFiles;

namespace RecursiveSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 91, 8, 6, 4, 58, 62, 14, 8, 16 };
            SortArr(arr, 0, arr.Length-1);
            
        }
        public static void SortArr(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = (left + right) / 2;
            pivot = arr[pivot];
            int index = partition(arr, left, right, pivot);
            SortArr(arr, left, index - 1);
            SortArr(arr, index, right);
        }
        public static int partition(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    Swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;  
        }
        public static void Swap(int[] arr, int left, int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
