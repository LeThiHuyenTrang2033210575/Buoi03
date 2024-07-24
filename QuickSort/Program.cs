using System;


namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 3 };
            Console.WriteLine("Mang ban đau:");
            PrintArray(numbers);

            QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("Mang sau khi QuickSort:");
            PrintArray(numbers);

            Console.ReadLine();
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
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
