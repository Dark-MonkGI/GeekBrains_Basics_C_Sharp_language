using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayHello;
using System.Text.RegularExpressions;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.Say(5);

            CheckMyString.InputLolin();
            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();

            CheckMyString checkMyString = new CheckMyString();

            Console.WriteLine("Слова длиннее 5 символов:\n\r");
            checkMyString.PrintShortWords(5);
            Console.WriteLine("=======================================");
            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Текст без слов, заканчивающихся на 'о':");
            checkMyString.PrintWordsWithoutletter('о'); // тут не понял, как он догадался перенос строки там где надо поставить
            Console.WriteLine("=======================================");

            Console.WriteLine($"Самое длинное слово: \n\r {checkMyString.LongestWord()}");    
            Console.WriteLine("=======================================");
            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Строка из самых длинных слов в тексте:");
            checkMyString.StringLongWords();
            Console.WriteLine("=======================================");
            Console.WriteLine($"Для продолжения введите Enter");
            Console.ReadLine();
            Console.Clear();


            Console.ReadLine();
        }
    }
}
