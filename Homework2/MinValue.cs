using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Maths
    {
        int x, y, n;

        public Maths()
        {
            Console.WriteLine("Enter three positive integers\n\r");
            this.x = ImputNumber();
            this.y = ImputNumber();
            this.n = ImputNumber();
        }

        public static int ImputNumber()
        {
            int? number = null;

            while(number is null || number < 0) 
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("You didn't enter a number");
                    Console.WriteLine("Enter three positive integers\n\r");
                }
                if (number < 0)
                    Console.WriteLine("You entered a negative number");
            }

            return (int)number;
        }

        public void MinNumber()
        {
            if(x < y && x < n)
                Console.WriteLine($"Minimum number: {x}");
            else if(y < n && y < x)
                Console.WriteLine($"Minimum number: {y}");
            else
                Console.WriteLine($"Minimum number: {n}");
            Console.WriteLine();
        }

        internal void Whatlength()
        {
            Console.WriteLine($"Length x({x}):  {Convert.ToString(x).Length} digits");
            Console.WriteLine($"Length y({y}):  {Convert.ToString(y).Length} digits");
            Console.WriteLine($"Length n({n}):  {Convert.ToString(n).Length} digits\n\r");
        }

        public static void SumNumbers()
        {
            Console.WriteLine("Enter three positive integers to calculate the sum\n\r");
            int number = ImputNumber();
            int summ =0;

            while (number != 0)
            {
                summ += number;
                number = ImputNumber();
            }

            Console.WriteLine($"Sum of all numbers: {summ}");
        }
    }
}
