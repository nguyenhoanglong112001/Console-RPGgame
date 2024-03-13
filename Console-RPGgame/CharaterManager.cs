using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPGgame
{
    public class CharaterManager
    {
        public CharaterManager()
        {

        }
        public CharacterType ChooseType()
        {
            int select = Program.uimanager.InputInt("lua chon cua ban: ");
            if (select == 1)
            {
                Program.character.type = CharacterType.Tanker;
            }
            else if (select == 2)
            {
                Program.character.type = CharacterType.Support;
            }
            else if (select == 3)
            {
                Program.character.type = CharacterType.Ranged;
            }
            else if (select == 4)
            {
                Program.character.type = CharacterType.Fighter;
            }
            else if (select == 5)
            {
                Program.character.type = CharacterType.Assasin;
            }
            return Program.character.type;
        }

        public void CreateHero(string name)
        {
            Console.Clear();
            CharacterType herotype = Program.charaterManager.ChooseType();
            if (herotype == CharacterType.Assasin)
            {
                Program.character = new Assasin(name, herotype);
            }
            else if (herotype == CharacterType.Support)
            {
                Program.character = new Support(name, herotype);
            }
            else if (herotype == CharacterType.Fighter)
            {
                Program.character = new Fighter(name, herotype);
            }
            else if (herotype == CharacterType.Tanker)
            {
                Program.character = new Tanker(name, herotype);
            }
            else if (herotype == CharacterType.Ranged)
            {
                Program.character = new Ranged(name, herotype);
            }
        }
    }
}
