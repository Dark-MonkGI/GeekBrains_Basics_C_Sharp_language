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

        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
        //метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.

        //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки

        int[] array;

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        /// <summary>
        ///  Свойство возвращает сумму элементов массива
        /// </summary>
        public int Summ
        {
            get 
            {
                int summ = 0;
                for (int i = 0; i < array.Length; i++)
                    summ += array[i];
                return summ;
            }
        }

        public MyArray(int[] array)
        {
            this.array = array;
        }

        public MyArray(int size)
        {
            Random random = new Random();

            this.array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = random.Next(-99, 100);
        }

        public MyArray(string fileName)
        {
            this.array = LoadArrayFromFile(fileName);
        }

        /// <summary>
        /// Конструктор, создающий массив с заданным шагом.
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="step">Шаг заполняемости</param>
        public MyArray(int size, int step)
        {
            this.array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = step;
                step += step;
            }
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
