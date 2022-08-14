using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal struct ComplexStruct
    {
        /// <summary>
        /// Мнимая часть комплексногоч числа
        /// </summary>
        private int im;

        /// <summary>
        /// Действительная часть комплексногоч числа
        /// </summary>
        private int re;

        public int Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }

        public int Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        public ComplexStruct(int im, int re)
        {
            this.im = im;
            this.re = re;
        }





        public static ComplexStruct operator +(ComplexStruct complex1, ComplexStruct complex2)
        {
            int ss = complex1.Re + complex2.Re;// 
            int ss2 = complex1.Im + complex2.Im;

            ComplexStruct complex3 = new ComplexStruct(complex1.Re + complex2.Re, complex1.Im + complex2.Im); // 


            return new ComplexStruct { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im }; //  
        }






        public static ComplexStruct operator -(ComplexStruct complex1, ComplexStruct complex2)
        {
            return new ComplexStruct { Re = complex1.re - complex2.re, Im = complex1.im - complex2.im }; // 
        }



        public ComplexStruct Plus(ComplexStruct x)
        {
            return new ComplexStruct(re + x.Re, im + x.Im);
        }

        public ComplexStruct Minus(ComplexStruct x)
        {
            return new ComplexStruct(re - x.Re, im - x.im);
        }

        public static ComplexStruct Plus(ComplexStruct complex1, ComplexStruct complex2)
        {
            return new ComplexStruct(complex1.Re + complex2.Re, complex1.Im + complex2.Im);
        }

        public static ComplexStruct Minus(ComplexStruct complex1, ComplexStruct complex2)
        {
            return new ComplexStruct(complex1.Re - complex2.Re, complex1.Im - complex2.Im);
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

    }
}
