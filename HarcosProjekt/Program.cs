using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int lvl;
        private int hp;
        private int xp;
        private int    basHP;
        private int basDMG;

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;

            this.lvl = 1;
            this.xp = 0;
            //this.hp = hp;

            if (statuszSablon == 1)
            {
                this.basHP = 15;
                this.basDMG = 3;
            }
            else if (statuszSablon == 2)
            {
                this.basHP = 12;
                this.basDMG = 4;
            }
            else if (statuszSablon == 3)
            {
                this.basHP = 8;
                this.basDMG = 5;
            }
            else
            {
                Console.WriteLine("rossz statuszSablont adot meg");
            }
            //this.hp = this.basHP + this.lvl * 3;
        }

            public int MAXhp { get => this.basHP + this.lvl * 3; }
        
    
    
    }



    class Program
    {
        static void Main(string[] args)
        {






        Console.ReadKey();
        }
    }
}
