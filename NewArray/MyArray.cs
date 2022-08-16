using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArray
{
    public class MyArray
    {
        int[] array;

        public int[] Arr
        {
            get { return array; }
            set { array = value; }
        }

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

        /// <summary>
        /// Свойство возвращает количество вхождений числа с максимальным значением
        /// </summary>
        public int MaxCount
        {
            get
            {
                int maxValue = this.array[0];
                int count = 1;
                foreach (var val in array)
                {
                    if (val > maxValue)
                    {
                        maxValue = val;
                        count = 1;
                    }
                    else
                        count++;
                }

                return count;
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

        /// <summary>
        /// Конструктор, создающий массив с заданным шагом.
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="step">Шаг заполняемости</param>
        public MyArray(int size, int step)
        {
            this.array = new int[size];
            int newStep = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = newStep;
                newStep += step;
            }
        }

        /// <summary>
        /// Изменяет все знаки у входящего массива
        /// </summary>
        /// <param name="array">Массив чисел</param>
        /// <returns></returns>
        public static int[] Inverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i] * (-1);

            return newArray;
        }

        /// <summary>
        /// Умножает все чилса массива на заданное число
        /// </summary>
        /// <param name="array">Передаваемый массив</param>
        /// <param name="x"> Множитель</param>
        public static int[] Multi(int[] array, int number)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i] * number;
            return newArray;
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}\t");

            Console.WriteLine();
        }

        /// <summary>
        /// Получаем данные из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static string[] LoadFromFile(string fileName)
        {
            fileName = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\" + fileName + $".txt";

            if (File.Exists(fileName))
            {
                StreamReader streamReader = new StreamReader(fileName);

                List<string> buf = new List<string>();
                int count = 0;

                while (!streamReader.EndOfStream)
                {
                    string[] str = streamReader.ReadLine().Split(';');
                    buf.Add(str[0]);
                    buf.Add(str[1]);
                    count+=2;
                }

                string[] arr = new string[count];
                buf.CopyTo(arr);
                streamReader.Close();
                return arr;

            }
            else
                throw new FileNotFoundException();
        }

        public override string ToString()
        {
            string tempStr = "";
            foreach(var el in array)
                 tempStr += el + "; ";

            return tempStr;
        }
    }
}
