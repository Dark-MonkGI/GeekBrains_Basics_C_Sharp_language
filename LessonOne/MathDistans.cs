using LessonOne.Properties;
using System;

namespace LessonOne
{
    internal class MathDistans
    { 
        public double Result { get ; private set; }

        Coordinates CoordOne = new Coordinates();
        private Coordinates CoordTwo = new Coordinates();



        public MathDistans()
        {
            Distans();
        }

        
        private void Distans()
        {
            this.Result = Math.Sqrt(Math.Pow(CoordTwo.X - CoordOne.X, 2) + Math.Pow(CoordTwo.Y - CoordOne.Y, 2));
        }

    }
}