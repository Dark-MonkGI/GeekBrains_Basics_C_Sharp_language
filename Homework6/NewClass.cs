using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    // В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем
    public delegate double Fun(double x);

    public delegate double FunTwoParam(double x, double y);

    internal class NewClass
    {

        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");

            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }

            Console.WriteLine("---------------------");
        }

        public static void Table(FunTwoParam F, double x, double y)
        {
            Console.WriteLine("----- X ----- Y -----");

            while (x <= y)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, y));
                x += 1;
            }

            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        public static double MyFuncTwo(double x, double y)
        {
            return y * x * x;
        }
        public static double MyFuncThree(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
