using System;

namespace TKNP_KDQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 8, 9 };
            Console.WriteLine("Mang:");
            PrintArray(numbers);

            int target = 5;
            int index = IterativeBinarySearch(numbers, target);

            if (index == -1)
            {
                Console.WriteLine("Khong tim thay " + target + "trong mang.");
            }
            else
            {
                Console.WriteLine("So can tim đuoc tim thay tai vi tri " + index + "");
            }

            Console.ReadLine();
        }

        static int IterativeBinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
