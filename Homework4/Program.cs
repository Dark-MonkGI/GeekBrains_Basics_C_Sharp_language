using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayHello;
using NewArray;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.Say(4);

            MyArray myArray = new MyArray(100, 5);
            Random random = new Random();
            
            Console.WriteLine($"Создали массив: {myArray}\r\n");
            Console.WriteLine($"Сумма элементов массива: {myArray.Summ} \r\n");
            Console.WriteLine($"Количество вхождений числа с максимальным значением: {myArray.MaxCount}\r\n");
            Console.WriteLine($"Изменинили все знаки массива:  {new MyArray(MyArray.Inverse(myArray.Arr))} \r\n");//
            Console.WriteLine($"Умножили все чилса массива на заданное число:  {new MyArray(MyArray.Multi(myArray.Arr, random.Next(1,10)))} \r\n");



            string[] loginArray = MyArray.LoadFromFile("Notebook");
            Account account = new Account(loginArray[0], loginArray[1]);
            account.IsLogin();

            Console.ReadLine();
        }
    }
}
