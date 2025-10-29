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
        public string RaceType { get; set; }   //Monster race type (troll, goblin, org)
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
            hero.HP = hero.HP - DMG;
        }
    }
}
