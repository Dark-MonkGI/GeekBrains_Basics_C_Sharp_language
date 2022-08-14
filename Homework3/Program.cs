using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayHello;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.Say(3);

            #region Struct Complex
            Random random = new Random();

            ComplexStruct complex1 = new ComplexStruct(6, 3);
            ComplexStruct complex2 = new ComplexStruct(4, 2);

            Console.WriteLine($"Работа с комплексными числами:\n\r |{complex1}| и |{complex2}|\n\r на базе структуры\n\r");

            Console.WriteLine($"=======================================");
            Console.WriteLine($"Результат сложения комплексных чисел:");
            Console.WriteLine($"Способ 1: {complex1.Plus(complex2)}");
            Console.WriteLine($"Способ 2: {ComplexStruct.Plus(complex1, complex2)}");

            ComplexStruct complex = complex1 + complex2; //

            Console.WriteLine($"Способ 3: {complex}"); //
            Console.WriteLine($"=======================================\n\r");

            Console.WriteLine($"=======================================");
            Console.WriteLine($"Результат вычитания комплексных чисел:");
            Console.WriteLine($"Способ 1: {complex1.Minus(complex2)}");
            Console.WriteLine($"Способ 2: {ComplexStruct.Minus(complex1, complex2)}");
            Console.WriteLine($"Способ 3: {complex1 - complex2}"); //
            Console.WriteLine($"=======================================\n\r");

            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine(); 
            Console.Clear();
            #endregion




            #region Class Complex
            Hello.Say(3);

            ComplexClass complex3 = new ComplexClass(random.NextDouble(), random.NextDouble());
            ComplexClass complex4 = new ComplexClass(random.NextDouble(), random.NextDouble());

            Console.WriteLine($"Работа с комплексными числами:\n\r |{complex3}| и |{complex4}|\n\r на базе класса\n\r");

            Console.WriteLine($"=======================================");
            Console.WriteLine($"Результат сложения комплексных чисел:");
            Console.WriteLine($"Способ 1: {complex3.Plus(complex4)}");
            Console.WriteLine($"Способ 2: {ComplexClass.Plus(complex3, complex4)}");
            Console.WriteLine($"Способ 3: {complex3 + complex4}");
            Console.WriteLine($"=======================================\n\r");

            Console.WriteLine($"=======================================");
            Console.WriteLine($"Результат вычитания комплексных чисел:");
            Console.WriteLine($"Способ 1: {complex3.Minus(complex4)}");
            Console.WriteLine($"Способ 2: {ComplexClass.Minus(complex3, complex4)}");
            Console.WriteLine($"Способ 3: {complex3 - complex4}");
            Console.WriteLine($"=======================================\n\r");

            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();
            #endregion


            Hello.Say(3);
            SumNumbers.WriteSummNumbers();


            Console.ReadLine();
        }

    }
}
