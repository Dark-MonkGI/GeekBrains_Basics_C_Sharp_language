using System;
using System.IO;


namespace Homework6
{
    public delegate double Func(double x);

    class FindMin
    {
        public static double Fone(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Ftwo(double x)
        {
            return x * x - 10 * x + 50;
        }

        public void SaveFunc(Func F, string fileName, double x, double b, double h)
        {
            fileName = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\" + fileName;

            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    while (x <= b)
                    {
                        bw.Write(F(x));
                        x += h;
                    }
                }
            }
        }

        public double Load(string fileName)
        {
            fileName = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\" + fileName;
            
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using(BinaryReader bw = new BinaryReader(fs))
                {
                    double min = double.MaxValue;
                    double d;

                    for (int i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        // Считываем значение и переходим к следующему
                        d = bw.ReadDouble();
                        if (d < min) min = d;
                    }
                    return min;
                }
            }
        }
    }
}
