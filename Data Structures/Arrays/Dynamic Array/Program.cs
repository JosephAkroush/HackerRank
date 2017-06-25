using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] arr = arrTemp.Select(element => Int32.Parse(element)).ToArray();
            int n = arr[0]; // The number of sequences in the list
            int q = arr[1]; // The number of queries

            List<List<int>> dynamicArray = new List<List<int>>(n);

            for (int i = 0; i < n; i++)
            {
                dynamicArray.Add(new List<int>());
            }

            int lastAnswer = 0;

            for (int i = 0; i < q; i++)
            {
                string[] query = Console.ReadLine().Split(' ');
                int[] parsedQuery = query.Select(element => Int32.Parse(element)).ToArray();
                int command = parsedQuery[0];
                int x = parsedQuery[1];
                int y = parsedQuery[2];
                int sequenceIndex = (x ^ lastAnswer) % n;

                var sequence = dynamicArray[sequenceIndex];

                if (command == 1)
                {
                    // Append
                    sequence.Add(y);
                }
                else
                {
                    // Print
                    lastAnswer = sequence[y % sequence.Count];

                    Console.WriteLine(lastAnswer);
                }
            }
        }
    }
}
