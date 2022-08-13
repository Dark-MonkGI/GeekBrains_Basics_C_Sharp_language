using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class SumNumbers
    {
        
        public static void WriteSummNumbers()
        {
            int summ = 0;
            bool flag;
            List<int> listInteger = new List<int>();

            while (true)
            {
                Console.WriteLine("Введите целое число:");
                flag = int.TryParse(Console.ReadLine(), out int newNumber);

                if (newNumber == 0) 
                    break;

                if (newNumber % 2 != 0 && newNumber > 0)
                {
                    summ += newNumber;
                    listInteger.Add(newNumber);
                }    
            }

            Console.WriteLine("Положительные, нечетные числа:");
            foreach (int num in listInteger)
                Console.WriteLine(num);

            Console.WriteLine("Сумма этих чисел:");
            Console.WriteLine(summ);
        }
    }
}
