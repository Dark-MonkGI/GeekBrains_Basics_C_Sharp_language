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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello my teacher, Stanislav!");
            Console.WriteLine("My name is Ilya");
            Console.WriteLine($"This is my homework number: {number}");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================\n\r");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        

    }
}
