using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Person
    {
        private string Name;
        private string Surname;
        private int personAge;
        private int height;
        private int weight;

        public Person()
        {
            WriteData();
        }


        private void WriteData()
        {
            WriteData("имя");
            this.Name = Console.ReadLine();

            WriteData("фамилию");
            this.Surname = Console.ReadLine();

            WriteData("возраст");
            this.personAge = Convert.ToInt32(Console.ReadLine());

            WriteData("Рост");
            this.height = Convert.ToInt32(Console.ReadLine());

            WriteData("вес");
            this.weight = Convert.ToInt32(Console.ReadLine());
        }



        private void WriteData(string parameter)
        {
            Console.WriteLine($"\n\rВведите {parameter}: ");
        }

        public void ShowMe()
        {
            string HiPerson = "Hello " + Name + " " + Surname;
            string HiPersonNext = string.Format("Your age: {0} years old", personAge);
            string HiPersonNextTwo = $"Your height: {height}, your weight: {weight}";

            Console.WriteLine(HiPerson);
            Console.WriteLine(HiPersonNext);
            Console.WriteLine(HiPersonNextTwo);
            Console.WriteLine($"Your body mass index: {bodyMassIndex(height, weight)}");
        }

        private double bodyMassIndex(int height, int weight)
        {
            // I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            return weight / (Convert.ToDouble(height) / 100 * (Convert.ToDouble(height) / 100));
        }
    }
}
