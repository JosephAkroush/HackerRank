using System;

class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();

        int words = 1;

        foreach (char c in s)
        {
            if (Char.IsUpper(c))
            {
                words++;
            }
        }

        Console.WriteLine(words);
    }
}
