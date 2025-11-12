using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    public class Hero
    {
        public string Name { get; set; } = "Arnost";  //Hero name
        public int HP { get; set; } = 100;    //Health
        public int DMG { get; set; } = 10;    //Damage
        public int ENG { get; set; } = 100;   //Energy
        public int ARM { get; set; } = 15;    //Armor

        public bool HeroAttak(Monster monster)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;                 //za jeden utok strati 20 energii
                monster.HP = monster.HP - DMG;  //zrani monstra
                return true;
            }
            else
            {
                ENG = ENG + 50;                //Ak nema dost eng, tak si ju trochu obnovi
                return false;
            }
        }

        //Druha prisera
        
        public void TakeDamage(int damage)
        {
        int finalDamage = damage - ARM;

            if (finalDamage< 0)
                finalDamage = 0;

            HP -= finalDamage;
        }
        public bool HeroDMG(Monster monster)
        {
            if (ENG - 20 >= 0)
            {
                ENG -= 20;
                monster.HP -= this.DMG;
                return true;
            }
            else
            {
                ENG += 50;
                return false;
            }
        }
        public bool HeroAttack2(MonsterSpecial monster2)
        {
            if (ENG - 20 >= 0)
            {
                ENG -= 20;
                monster2.HP -= this.DMG;
                return true;
            }
            else

            {
                ENG = ENG + 50;
                return false;
            }
        }
        public bool HeroDMG2(MonsterSpecial monster2)
        {
            if (ENG - 20 >= 0)
            {
                ENG -= 20;
                monster2.HP -= this.DMG;
                return true;
            }
            else
            {
                ENG += 50;
                return false;
            }
        }

    }

 }

