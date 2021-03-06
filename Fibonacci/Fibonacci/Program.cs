﻿using System;

namespace Fibonacci
{
    public class Program
    {
        public static int Fib(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(Fib(i));
            }
        }
    }
}
