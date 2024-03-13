using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Console_RPGgame
{
    internal class Program
    {
        public static Account account = null;
        public static Character character = null;
        public static UImanager uimanager = new UImanager();
        public static CharaterManager charaterManager = new CharaterManager();
        static void Main(string[] args)
        {
            uimanager.LoginUI();
        }
    }
}
