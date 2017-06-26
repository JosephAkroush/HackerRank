using System;
using System.Linq;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');
            int[] arr = nd.Select(element => Int32.Parse(element)).ToArray();
            int n = arr[0]; // The number of elements in the array
            int d = arr[1]; // The number of left shifts to perform

            string[] input = Console.ReadLine().Split(' ');
            int[] inputArray = input.Select(element => Int32.Parse(element)).ToArray();

            d = d % n;
            Reverse(arr, 0, n - 1);
            Reverse(arr, 0, n - d - 1);
            Reverse(arr, n - d, n - 1);

            Console.WriteLine(String.Join(" ", inputArray));
        }

        static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int tmp = arr[start];
                arr[start] = arr[end];
                arr[end] = tmp;
                start++;
                end--;
            }
        }
    }
}
