using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayHello;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.Say(6);

            Console.WriteLine("Таблица функции MyFunc:");
            NewClass.Table(NewClass.MyFuncTwo, -2, 2);

            Console.WriteLine("Таблица функции Sin:");
            NewClass.Table(NewClass.MyFuncThree, -2, 2); // Можно передавать уже созданные методы

            Console.WriteLine("Таблица функции Sin:");
            NewClass.Table(delegate (double x, double y ) { return y * Math.Sin(x); }, -2, 2);

            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();
        }
    }
}
