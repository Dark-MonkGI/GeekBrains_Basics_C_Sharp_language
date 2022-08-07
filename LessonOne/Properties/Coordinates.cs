using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonOne.Properties
{
    internal class Coordinates
    {
        public  double X {get; set;}
        public double Y {get; set;}

        public Coordinates()
        {
            Thread.Sleep(100); //чтоб не генерились одинаковые числа
            Random random = new Random();
            
            X = random.NextDouble() + Convert.ToDouble(random.Next(1,8));
            Y = random.NextDouble() + Convert.ToDouble(random.Next(1, 8));
        }
    }
}
