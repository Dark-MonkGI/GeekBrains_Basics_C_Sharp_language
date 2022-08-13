using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class ComplexClass
    {

        /// <summary>
        /// Мнимая часть комплексногоч числа
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексногоч числа
        /// </summary>
        public double re;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;
        }


        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexClass Plus(ComplexClass complex)
        {
            ComplexClass c = new ComplexClass();
            c.Re = re + complex.Re;
            c.im = im + complex.im;
            return c;
        }

        /// <summary>
        /// Сложение двух комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число 1</param>
        /// <param name="complex2">Комплексное число 2</param>
        /// <returns></returns>
        public static ComplexClass Plus(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass();
            res.re = complex1.re + complex2.re;
            res.im = complex1.im + complex2.im;
            return res;
        }


        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexClass Minus(ComplexClass complex)
        {
            ComplexClass c = new ComplexClass();
            c.Re = re - complex.Re;
            c.im = im - complex.im;
            return c;
        }

        /// <summary>
        /// Вычитание двух комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число 1</param>
        /// <param name="complex2">Комплексное число 2</param>
        /// <returns></returns>
        public static ComplexClass Minus(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass();
            res.re = complex1.re - complex2.re;
            res.im = complex1.im - complex2.im;
            return res;
        }

        /// <summary>
        /// Перегрузка оператора +, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static ComplexClass operator +(ComplexClass complex1, ComplexClass complex2)
        {
            return new ComplexClass(  complex1.Re + complex2.Re,  complex1.Im + complex2.Im );
        }

        /// <summary>
        /// Перегрузка оператора -, вычитание комплексных чисел
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns></returns>
        public static ComplexClass operator -(ComplexClass complex1, ComplexClass complex2)
        {
            return new ComplexClass(complex1.Re - complex2.Re, complex1.Im - complex2.Im);
        }



        public override string ToString()
        {
            return $"{re} + {im}i";
        }



    }
}
