using System;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[n];

            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string query = Console.ReadLine();
                int counter = 0;

                foreach (var item in strings)
                {
                    if (query == item)
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}
