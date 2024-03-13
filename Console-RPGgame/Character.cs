using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class Character
    {
        public string name {  get;protected set; }
        public CharacterType type { get; set; }
        public int hp { get; protected set; }
        public int atk {  get; protected set; }
        public int atkspeed { get; protected set; }
        public int ap {  get; protected set; }

        public List<Item> itemuse = null;

        public Character(string name, CharacterType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
