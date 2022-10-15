using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Factorial
    {
        public Factorial(int n)
        {
            int f = 1; 
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }
    }
}
