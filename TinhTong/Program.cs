using System;
namespace TinhTong
{
    class Program
    {

        static int SumArray(int[] arr, int left, int right)
        {

            if (left == right)
            {
                return arr[left];
            }


            int mid = (left + right) / 2;


            int leftSum = SumArray(arr, left, mid);
            int rightSum = SumArray(arr, mid + 1, right);

            return leftSum + rightSum;
        }

        static void Main()
        {

            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }


            int sum = SumArray(arr, 0, arr.Length - 1);


            Console.WriteLine("Tong cua mang tu 1 den " + n + " la: " + sum);
            Console.ReadLine();
        }
    }
}