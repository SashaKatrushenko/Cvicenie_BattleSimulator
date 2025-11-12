using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    public class Monster
    {
        public string RaceType { get; set; }   //Monster race type (troll, goblin, ork)
        public int HP { get; set; }      //Health
        public int DMG { get; set; }     //Damage

        public Monster(string raceType, int hP, int dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }

        public void MonsterAttak(Hero hero)
        {
           /* int finalDMG = DMG - hero.ARM;
            if (finalDMG < 0)
            {
                finalDMG = 0;
            }
            hero.HP = hero.HP - finalDMG;
            if (hero.HP < 0)
            {
                hero.HP = 0;
            }
          */   if (hero.ARM < DMG)
            {
                int vysledny_damage = DMG - hero.ARM;
                hero.HP = hero.HP - vysledny_damage;
            }
        }
    }
}
