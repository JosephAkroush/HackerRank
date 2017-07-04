static int BirthdayCakeCandles(int n, int[] ar)
{
    int numberOfCandles = 0;
    int max = 0;

    for (int i = 0; i < n; i++)
    {
        if (ar[i] > max)
        {
            numberOfCandles = 1;
            max = ar[i];
        }
        else if (ar[i] == max)
        {
            numberOfCandles++;
        }
    }

    return numberOfCandles;
}
