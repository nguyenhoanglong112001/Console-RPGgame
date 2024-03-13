using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class Assasin : Character
    {
        public Assasin(string name, CharacterType type) : base(name, type)
        {
            atk = GameHelper.Randomvalue(130, 150);
            ap = GameHelper.Randomvalue(0, 25);
            hp = GameHelper.Randomvalue(300, 600);
            atkspeed = GameHelper.Randomvalue(25, 40);
        }
    }
}
