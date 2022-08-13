using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    public class Hello
    {
        public static void Say(int number)
        {
            Console.SetCursorPosition(45, 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================");

            Console.SetCursorPosition(45,2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello my teacher, Stanislav!");

            Console.SetCursorPosition(52, 3);
            Console.WriteLine("My name is Ilya");

            Console.SetCursorPosition(45, 4);
            Console.WriteLine($"This is my homework number: {number}");

            Console.SetCursorPosition(45, 5);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================\n\r");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        

    }
}
