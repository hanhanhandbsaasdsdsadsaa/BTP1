using System;

namespace BTP1
{
    class binarySearch
    {
        static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 9;

            int index = BinarySearch(numbers, key);

            if (index == -1)
                Console.WriteLine("Phan tu " + key + "khong tim thay trong mang.");
            else
                Console.WriteLine("Phan tu " + key + "nam o vi tri " + index + " trong mang");
        }
    }
}

