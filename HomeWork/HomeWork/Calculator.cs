using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Calculator
    {
        public Calculator(int n, int m)
        {
            Console.WriteLine("Please enter number for operation(1-4)");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            
            int cal = Convert.ToInt32(Console.ReadLine());
            int Ans = 0;
            switch (cal)
            {
                case 1:
                    Ans = n + m;
                    Console.WriteLine(Ans);
                    break;
                case 2:
                    Ans = n - m;
                    Console.WriteLine(Ans);
                    break;
                case 3:
                    Ans = n * m;
                    Console.WriteLine(Ans);
                    break;
                case 4:
                    Ans = n / m;
                    Console.WriteLine(Ans);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
            
}
