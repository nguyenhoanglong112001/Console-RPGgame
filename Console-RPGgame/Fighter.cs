using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class Fighter : Character
    {
        public Fighter(string name, CharacterType type) : base(name, type)
        {
            atk = GameHelper.Randomvalue(80, 100);
            ap = GameHelper.Randomvalue(0, 10);
            hp = GameHelper.Randomvalue(700, 1000);
            atkspeed = GameHelper.Randomvalue(10, 50);
        }
    }
}
