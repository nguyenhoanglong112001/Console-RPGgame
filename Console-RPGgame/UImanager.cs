using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class UImanager
    {
        public void LoginUI()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            int select = InputInt("Lua chon cua ban");
            if (select == 1)
            {

            }
            else if (select == 2)
            {

            }
        }

        public void Register()
        {
            Console.Clear();
            string json = File.ReadAllText("");
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            Account account= new Account(username, password);


        }

        public void Login()
        {
            Console.Clear();
            Console.WriteLine("");
        }

        public string InputStr(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public int InputInt(string input)
        {
            Console.WriteLine(input);
            return int.Parse(Console.ReadLine());
        }
    }
}
