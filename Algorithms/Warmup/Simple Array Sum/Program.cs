using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = SimpleArraySum(n, ar);
        Console.WriteLine(result);
    }

    static int SimpleArraySum(int n, int[] ar)
    {
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += ar[i];
        }

        return sum;
    }
}
