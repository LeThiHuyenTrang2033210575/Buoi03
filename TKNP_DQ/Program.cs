using System;


namespace TKNP_DQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 8, 9 };
            Console.WriteLine("Mang:");
            PrintArray(numbers);

            int target = 5;
            int index = RecursiveBinarySearch(numbers, target, 0, numbers.Length - 1);

            if (index == -1)
            {
                Console.WriteLine("Khong tim thay " + target + " trong mang");
            }
            else
            {
                Console.WriteLine("So can tim duoc tim thay tai vi tri " + index + "");
            }

            Console.ReadLine();
        }

        static int RecursiveBinarySearch(int[] arr, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                return RecursiveBinarySearch(arr, target, mid + 1, right);
            }
            else
            {
                return RecursiveBinarySearch(arr, target, left, mid - 1);
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
