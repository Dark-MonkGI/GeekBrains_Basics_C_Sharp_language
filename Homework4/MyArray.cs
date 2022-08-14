using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class MyArray
    {

        //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        //Создать свойство Sum, которое возвращает сумму элементов массива,
        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
        //метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.

        //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки

        int[] array;

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }


        public MyArray(int[] array)
        {
            this.array = array;
        }

        public MyArray(int size)
        {
            Random random = new Random();
            array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = random.Next(-99, 100);
        }

        public MyArray(string fileName)
        {
            this.array = LoadArrayFromFile(fileName);
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}\t");

            Console.WriteLine();
        }

        private int[] LoadArrayFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                //StreamWriter
                //    WriteLine
                StreamReader streamReader = new StreamReader(fileName);
                int[] buf = new int[1000];
                int count = 0;
                //streamReader.ReadLine();
                //streamReader.EndOfStream
                while (!streamReader.EndOfStream)
                {
                    buf[count] = int.Parse(streamReader.ReadLine());
                    count++;
                }

                int[] arr = new int[count];
                Array.Copy(buf, arr, count);
                streamReader.Close();
                return arr;

            }
            else
                throw new FileNotFoundException();
        }

    }
}
