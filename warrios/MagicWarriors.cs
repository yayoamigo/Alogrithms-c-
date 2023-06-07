using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warrios
{
    class MagicWarriors : Warrior, Imagic
    {

        public int MagicAbility = 0;
        
        public MagicWarriors(string name , int health, int attackMax , int blockMax , int magicAbility) 
         : base(name, health, attackMax, blockMax) {
         MagicAbility = magicAbility;
        }

        public void CanTeleport()
        {
            Console.WriteLine("teleports away");
        }

        public void CantTeleport()
        {
            Console.WriteLine("cant teleport");
        }

        public override int Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            if (rndDodge > MagicAbility)
            {
                CanTeleport();
                return 10000;
            }
            else
            {
                CantTeleport();
                return base.Block();
            }

           
        }
    }
}
