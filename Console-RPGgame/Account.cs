using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class Account
    {
        public string username {  get;protected set; }
        public string password { get;protected set; }
        public Character character = null;

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
