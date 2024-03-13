using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
                Login();
                MainMenu();
            }
            else if (select == 2)
            {
                Register();
            }
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=======RPG game======");
            Console.WriteLine("1. Create Hero");
            int select = InputInt("Lua chon cua ban: ");
            if (select == 1)
            {
                CreateHero();
            }
        }

        public void Register()
        {
            Console.Clear();
            string json = File.ReadAllText("Data.json");
            Data data = JsonConvert.DeserializeObject<Data>(json);
            Label:
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            foreach(var kvp in data.accounts.Values)
            {
                if (username.Equals(kvp.username))
                {
                    Console.WriteLine("Tai khoan da ton tai vui long nhap lai");
                    goto Label;
                }
            }
            Program.account = new Account(username, password);

            data.accounts.Add(username, Program.account);
            string newJson = JsonConvert.SerializeObject(data);
            File.WriteAllText("Data.json", newJson);
            Console.WriteLine("Tao tai khoan thanh cong");
            Console.ReadKey();
            LoginUI();
        }

        public void Login()
        {
            Console.Clear();
            string json = File.ReadAllText("Data.json");
            Data data = JsonConvert.DeserializeObject<Data>(json);
        Label:
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            if (data.accounts.Any(u => u.Value.username.Equals(username) && u.Value.password.Equals(password)))
            {
                Console.WriteLine("Dang nhap thanh cong");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sai thong tin tai khoan vui long dang nhap lai");
                goto Label;
            }

        }

        public void TypeChooseUI()
        {
            Console.Clear();
            Console.WriteLine("Choose hero character: ");
            Console.WriteLine("1. Tanker");
            Console.WriteLine("2. Support");
            Console.WriteLine("3. Ranged");
            Console.WriteLine("4. Fighter");
            Console.WriteLine("5. Assasin");
            Program.charaterManager.ChooseType();
        }

        public void CreateHero()
        {
            Console.Clear();
            string name = InputStr("Nhap ten hero: ");
            TypeChooseUI();
            Console.WriteLine("Create Hero Succes");
            Console.ReadKey();
            MainMenu();
        }

        public string InputStr(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public int InputInt(string input)
        {
            Console.WriteLine(input);
            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Nhap sai ky tu vui long nhap lai !!!!!");
                InputInt(input);
            }    
            return result;
        }
    }
}
