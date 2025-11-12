namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourhero = new Hero();
            //HLAVNA PRISERA
            /*
            Monster monster1 = new Monster("Goblin", 150, 19);
        

          //  int HeroHpAfterFight = ourHero.HP - monster1.DMG;
          // ourHero.HP = HeroHpAfterFight;


            while (true)
            {
                //Hero dostal po hlave od monstra
                monster1.MonsterAttak(ourHero);
                Console.WriteLine("HERO:HP " + ourHero.HP);

                //Monster dostal po hlave od Hero
                bool wasAttak = ourHero.HeroAttak(monster1);
                if (wasAttak)
                {
                    Console.WriteLine("MONSTER HP: " + monster1.HP);
                }
                else
                {
                    Console.WriteLine("---Nema energiu! Musi dat oddych...");
                    Console.WriteLine("HERO:energy " + ourHero.ENG);
                }

                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Hero is dead X-X");
                    break;
                }
                if (monster1.HP <= 0)
                {
                    Console.WriteLine("Monster is dead! =D");
                    break;
                }
               
            }
            */
            //SPECIAL PRISERA
            /*  MonsterSpecial monster2 = new MonsterSpecial("Troll", 200, 17);
              monster2.MonsterAttack2(ourhero);

              while (true)
              {

                  {
                      monster2.MonsterAttack2(ourhero);
                     // bool wasAttack2 = ourhero.HeroAttack2(monster2);


                      if (ourhero.HP <= 0)
                      {
                          Console.WriteLine(ourhero.Name + " Zomrel! X-X");
                          break;
                      }

                      if (monster2.HP <= 0)
                      {
                          Console.WriteLine("Si porazil " + monster2.RaceType + "a! =D");
                          break;
                      }
                  }
                  {
                      bool wasAttack2 = ourhero.HeroAttack2(monster2);
                      if (wasAttack2)
                      {

                      }
                      else
                      {
                          Console.WriteLine("Nema energiu, da si oddych");
                          Console.WriteLine("HERO Enegry: " + ourhero.ENG);
                      }

                      Console.WriteLine(" Hero HP: " + ourhero.HP);
                      Console.WriteLine(" Monster2 HP: " + monster2.HP);
                  }
              } */
            // INE PRISERY
            Monster monster1 = new Monster("Goblin", 150, 3);
            Monster monster2 = new Monster("Elf", 150, 5);
            Monster monster3 = new Monster("Trol", 150, 7);
            List<Monster> monstry = new List<Monster>();
            monstry.Add(monster1);
            monstry.Add(monster2);
            monstry.Add(monster3);

            Console.WriteLine("Ideš po lese a zaútočí na teba " + monster1.RaceType);

            while (true)
            {
                Random r = new Random();
                int pocetMonstrumov = monstry.Count;
                int ktora = r.Next(0, pocetMonstrumov);
                monstry[ktora].MonsterAttak(ourhero);
                if (ourhero.HP <= 0)
                {
                    Console.WriteLine("Hero zomrel! X-X");
                    break;
                }
                //Utok od monstra
                monster1.MonsterAttak(ourhero);
                monster2.MonsterAttak(ourhero);
                monster3.MonsterAttak(ourhero);

                ourhero.HeroAttak(monster1); //Hero Attack

                bool WasAttakSuccessful = ourhero.HeroAttak(monster1);
                Console.WriteLine("HERO HP: " + ourhero.HP);
                Console.WriteLine("MONSTER HP: " + monster1.HP);
            } /*  bool wasAttack = ourhero.HeroAttak(monster1);
                if (ourhero.HP <= 0)
                {
                    Console.WriteLine("Hero was dead X-X");
                    break;
                }
                else if (monster1.HP <= 0)
                {
                    Console.WriteLine("Si porazil monstruma! =D");
                    break;
             */
                bool WasAttackSuccessful = ourhero.HeroAttak(monster1);
                Console.WriteLine("Tvoj hrdina má teraz: " + ourhero.HP);
                Console.WriteLine("Príšera má teraz: " + monster1.HP);
            foreach (Monster monster in monstry)
            {
                Console.WriteLine(monster.RaceType + " má " + monster.HP);
            }
           
                Console.WriteLine(monster2.RaceType + " má " + monster2.HP);
                Console.WriteLine(monster3.RaceType + " má " + monster3.HP);

             
    }
       
    }
}

