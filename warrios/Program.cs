using System;
using warrios;



    class Program
    {

        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 1000, 120, 40);
            MagicWarriors loki = new MagicWarriors("Loki", 800, 100, 40, 60);

            Battle.StartFight(thor, loki);


        }
    }

