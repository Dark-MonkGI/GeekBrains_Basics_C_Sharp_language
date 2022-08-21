using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

namespace Homework5
{
    public class CheckMyString
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", "-", " " };
        private string[] words;

        public CheckMyString()
        {
            this.words = MyText.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Слова текста, которые содержат не более n букв
        /// </summary>
        /// <param name="countLetters">ограничение количества букв в слове</param>
        public void PrintShortWords(int countLetters)
        {
            StringBuilder newString = new StringBuilder();

            foreach (string word in this.words)
            {
                if(word.Length > countLetters)
                    newString.Append($"{word}\n");
            }

            Console.WriteLine(newString.ToString());
        }

        /// <summary>
        /// Убирает из текста слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="symbol">символ</param>
        public void PrintWordsWithoutletter(char symbol)
        {
            StringBuilder newString = new StringBuilder();

            foreach (string word in this.words)
            {
                if (!word.EndsWith(symbol.ToString()))
                    newString.Append($"{word} ");
            }

            Console.WriteLine(newString.ToString());
        }

        /// <summary>
        /// Самое длинное слово из теста
        /// </summary>
        public string  LongestWord()
        {
            var longestWord = "";

            foreach (string word in this.words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }
            return longestWord;
        }

        /// <summary>
        /// Строка из самых длинных слов текста
        /// </summary>
        public void StringLongWords()
        {
            int thirtyPercentLength = (int)(Convert.ToDouble(LongestWord().Length) / 100 * 30);
            StringBuilder newString = new StringBuilder();

            foreach (string word in this.words)
            {
                if (word.Length > thirtyPercentLength)
                    newString.Append($"{word} ");
            }
            Console.WriteLine(newString);
        }


        /// <summary>
        /// Запрос на ввод логина у пользователя
        /// </summary>
        static public void InputLolin()
        {
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Enter login:\n\r");

                if (LoginIsCorrect(Console.ReadLine()))
                {
                    Console.WriteLine($"Логин верный\n\r");
                    break;
                }
                count++;
            } 

        }

        /// <summary>
        ///  Проверка корректности логина - строка от 2 до 10 символов,
        ///  содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.
        /// </summary>
        /// <param name="lolin">Введенный логин</param>
        /// <returns></returns>
        static private bool LoginIsCorrect(string lolin)
        {
            if (lolin.Length < 2 || lolin.Length > 10)
            {
                Console.WriteLine("Некорректная длина логина\n\r");
                return false;
            }

            if (char.GetUnicodeCategory(lolin[0]) == UnicodeCategory.DecimalDigitNumber)
            {
                Console.WriteLine("Логин не может начинаться числом\n\r");
                return false;
            }

            foreach (char c in lolin)
            {
                UnicodeCategory category = char.GetUnicodeCategory(c);

                if (!(category == UnicodeCategory.DecimalDigitNumber) && !(category == UnicodeCategory.UppercaseLetter) && !(category == UnicodeCategory.LowercaseLetter))
                {
                    Console.WriteLine($"Недопустимый символ: {c}\n\r");
                    return false;
                }
            }

            return true;
        }
    }
}
