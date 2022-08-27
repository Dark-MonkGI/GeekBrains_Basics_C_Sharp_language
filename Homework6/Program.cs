using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            NewClass.Table(NewClass.MyFuncThree, -2, 2);

            Console.WriteLine("Таблица функции Sin:");
            NewClass.Table(delegate (double x, double y) { return y * Math.Sin(x); }, -2, 2);

            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();

            //Task2
            Hello.Say(6);

            List<Func> findFunc = new List<Func>() { new Func(FindMin.Fone), new Func(FindMin.Ftwo) };

            FindMin findMin = new FindMin();
            Console.WriteLine("Введите число, соответствующее номеру желаемой функции:");
            Console.WriteLine("\"1\" - Первая функци\n\r\"2\" - Вторая функция\n\r");

            findMin.SaveFunc(findFunc[int.Parse(Console.ReadLine())-1], "data.bin", -100, 100, 0.5);
            Console.WriteLine(findMin.Load("data.bin"));

            Console.ReadLine();
        }
    }
}
