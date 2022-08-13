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

        public void Whatlength()
        {
            Console.WriteLine($"Length x({x}):  {Convert.ToString(GetCountOfDigitsOfNumber(x))} digits");
            Console.WriteLine($"Length y({y}):  {Convert.ToString(GetCountOfDigitsOfNumber(y))} digits");
            Console.WriteLine($"Length n({n}):  {Convert.ToString(n).Length} digits\n\r");
        }

        /// <summary>
        /// Подсчет кол-ва цифр числа (исходя из разрядности числа)
        /// </summary>
        /// <param name = "number">Число</param>
        /// <returns>Кол-во цифр числа</returns>
        private int GetCountOfDigitsOfNumber(int number)
        {
            // Если число равно 0, результат подсчета 1, завершаем работу метода
            int count = (number == 0) ? 1 : 0;
            
            while (number != 0) 
            {
                count++; 
                number /= 10; 
            }
            return count; 
        }

        public static void SumNumbers()
        {
            Console.WriteLine("Enter three positive integers to calculate the sum\n\r");
            int number = ImputNumber();
            int summ =0;

            while (number != 0)
            {
                if(number % 2 == 1)
                    summ += number;
                number = ImputNumber();
            }

            Console.WriteLine($"Sum of all numbers: {summ}");
        }

        /// <summary>
        /// Подсчет количества "хороших" чисел.
        /// </summary>
        public static void FindingSum()
        {
            Console.WriteLine("Подсчет количества \"хороших\" чисел");
            Console.WriteLine("==================================\n");
            Console.WriteLine($"Производится подсчет количества хороших чисел.\nЭто может занять несколько минут ...");
            DateTime start = DateTime.Now;
            int counter = 0;
            int sum = 0;

            var maxNumber = 1_000_000_000;

            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % GetSum(i) == 0)
                {
                    counter++;
                    sum += i;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до {maxNumber} равно {counter}, сумма: {sum}");
            Console.WriteLine($"Подсчет занял у нас {finish - start}");
            Console.ReadKey();

        }

        /// <summary>
        /// Поиск суммы своих цифр числа
        /// </summary>
        /// <param name="number">Заданное число</param>
        /// <returns></returns>
        static int GetSum(int number) 
        {
            var sum = 0;  
            while (number > 0) 
            {
                sum += number % 10;
                number /= 10; 
            }
            return sum; 
        }
    }
}
