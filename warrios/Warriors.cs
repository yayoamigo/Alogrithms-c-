using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warrios
{
    class Warrior
    {
        public string name;
        public int health;
        public int attackMax;
        public int blockMax;
        Random rnd = new Random();
        public Warrior(string name = "warrior", int health = 0, int attackMax = 0, int blockMax = 0)
        {
            this.name = name;
            this.health = health;
            this.attackMax = attackMax;
            this.blockMax = blockMax;
        }
        public int Attack()
        {
            return rnd.Next(1, this.attackMax);
        }
        public virtual int Block()
        {
            return rnd.Next(1, this.blockMax);
        }
    }
}
