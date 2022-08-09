using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayHello;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.Say(2);

            Maths Value = new Maths();
            Value.MinNumber();
            Value.Whatlength();

            Maths.SumNumbers();

            LoginUsers loginUsers = new LoginUsers();
            loginUsers.IsLogin();

            Console.ReadLine();
        }
    }
}
