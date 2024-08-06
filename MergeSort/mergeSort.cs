using System;

namespace MergeSort
{
    class mergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 4, 6, 1, 3, 2, 7 };
            Console.WriteLine("DS Mang: " + string.Join(", ", arr));

            Sort(arr);

            Console.WriteLine("DS Mang Sau khi sap xep: " + string.Join(", ", arr));

        }
        public static void Sort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            Sort(left);
            Sort(right);
            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }
    }
}
