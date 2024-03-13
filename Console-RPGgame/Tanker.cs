using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class Tanker : Character
    {
        public Tanker(string name, CharacterType type) : base(name, type)
        {
            atk = GameHelper.Randomvalue(50, 80);
            ap = 0;
            hp = GameHelper.Randomvalue(1000, 1500);
            atkspeed = GameHelper.Randomvalue(10, 30);
        }
    }
}
