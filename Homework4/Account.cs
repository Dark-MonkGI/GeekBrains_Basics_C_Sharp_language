using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework4
{
    internal struct Account
    {
        string login;
        string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }


        public void IsLogin()
        {
            if (ChachUsers())
                Console.WriteLine("Successful login\n\r");
            else
                Console.WriteLine("Access is denied\n\r");
        }

        private bool ChachUsers()
        {
            string name;
            string pass;
            int count = 0;

            do
            {
                Console.WriteLine("Enter login:\n\r");
                name = Console.ReadLine();
                Console.WriteLine("Enter password:\n\r");
                pass = Console.ReadLine();

                if (name == login && pass == password)
                    return true;
                count++;
            } while (count < 3);

            return false;
        }
    }
}
