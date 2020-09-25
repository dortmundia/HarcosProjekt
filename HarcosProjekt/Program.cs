using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

        public string Nev { get => nev; set => nev = value; }

        public int LVL { get => lvl; set => lvl = 1; }
        public int HP { get => hp; set => hp = 1; }
        public int XP { get => xp; set => xp = 0; }
        public int szintlepeshez { get => this.lvl * 5 + 10; }
        public int MAXHP { get => this.lvl * 3 + this.basHP; }
        public int DMG { get => this.lvl + this.basDMG; }



        public Harcos(string nev, int statuszSablon)
        {

            //this.lvl = 1;
          //  this.xp = 0;
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

        public int BasDmg { get => basDMG; }
        public int BasHP { get => basHP; }

          //  public int MAXhp { get => this.basHP + this.lvl * 3; } idk miért hoztam ezt kétszer létre.


        public override string ToString()
        {
            return String.Format($"{0} – LVL:{1} – EXP: {2}/{3} – HP: {4}/{5} – DMG: {6}",Nev,LVL,XP,szintlepeshez,HP,MAXHP,DMG);
          
        }


    }



    class Program
    {
        static void Main(string[] args)
        {






        Console.ReadKey();
        }
    }
}
