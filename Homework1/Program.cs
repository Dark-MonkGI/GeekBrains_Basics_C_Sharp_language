using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayHello;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.Say(1);

            Person person = new Person();
            person.ShowMe();

            MathDistans Distans = new MathDistans();
            Console.WriteLine($"Distance between two coordinates:  {Distans.Result}");
            Console.ReadLine();
        }

    }
}