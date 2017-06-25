using System;
using System.Linq;

namespace ArraysDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] arr = arrTemp.Select(element => Int32.Parse(element)).ToArray();

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
