static void Main(String[] args)
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[][] a = new int[n][];
    
    for (int a_i = 0; a_i < n; a_i++)
    {
        string[] a_temp = Console.ReadLine().Split(' ');
        a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
    }

    int sumA = 0;
    int sumB = 0;

    for (int i = 0; i < n; i++)
    {
        sumA += a[i][i];
        sumB += a[n - i - 1][i];
    }

    Console.WriteLine(Math.Abs(sumA - sumB));
}
