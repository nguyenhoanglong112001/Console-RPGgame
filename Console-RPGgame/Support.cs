using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class Support : Character
    {
        public Support(string name, CharacterType type) : base(name, type)
        {
            atk = GameHelper.Randomvalue(20, 50);
            ap = GameHelper.Randomvalue(70, 150);
            hp = GameHelper.Randomvalue(250, 500);
            atkspeed = GameHelper.Randomvalue(10, 30);
        }
    }
}
