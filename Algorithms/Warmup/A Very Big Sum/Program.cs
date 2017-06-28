using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
        long result = AVeryBigSum(n, ar);
        Console.WriteLine(result);
    }

    static long AVeryBigSum(int n, long[] ar)
    {
        long sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += ar[i];
        }

        return sum;
    }
}
