using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        private int nameVariable;

        public int NameVariable 
        { 
            get 
            { 
                return NameVariable;  
            } 
            set
            {
                NameVariable = value;
            }
        }

        public Coordinates()
        {
            Thread.Sleep(100); //чтоб не генерились одинаковые числа
            Random random = new Random();

            X = random.NextDouble() + Convert.ToDouble(random.Next(1, 8));
            Y = random.NextDouble() + Convert.ToDouble(random.Next(1, 8));
        }
    }
}
