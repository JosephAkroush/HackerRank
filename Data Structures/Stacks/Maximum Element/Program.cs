using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] stack = new int[n];
        int items = 0;
        int max = 0;
        
        for (int i = 0; i < n; i++)
        {
            string[] query = Console.ReadLine().Split(' ');
            int[] queryArray = query.Select(element => Int32.Parse(element)).ToArray();
            int operation = queryArray[0];
            
            if (operation == 1)
            {
                int data = queryArray[1];
                
                if (items == 0)
                {
                    stack[items++] = data;
                }
                else
                {
                    max = stack[items - 1];
                    
                    if (data > max)
                    {
                        stack[items++] = data;
                    }
                    else
                    {
                        stack[items++] = max;
                    }
                }
            }
            else if (operation == 2)
            {
                --items;
            }
            else if (operation == 3)
            {
                Console.WriteLine(stack[items - 1]);
            }
        }
    }
}
