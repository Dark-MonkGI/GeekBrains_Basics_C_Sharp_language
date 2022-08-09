using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class LoginUsers
    {
        private string username;
        private string password;

        public LoginUsers()
        {
            this.username = "root";
            this.password = "GeekBrains";
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

                if (name == username && pass == password)
                    return true;
                count++;
            }while (count < 3);

            return false;
        }

    }
}
