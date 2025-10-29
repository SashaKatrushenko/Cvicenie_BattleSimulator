namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin", 150, 3);
        

            int HeroHpAfterFight = ourHero.HP - monster1.DMG;
            ourHero.HP = HeroHpAfterFight;


            while (true)
            {
                //Hero dostal po hlave od monstra
                monster1.MonsterAttak(ourHero);
                Console.WriteLine("HERO:HP " + ourHero.HP);

                //Monster dostal po hlave od Hero
                bool wasAttak = ourHero.HeroAttak(monster1);
                if (wasAttak)
                {
                    Console.WriteLine("MONSTER:HP " + monster1.HP);
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


          //  Console.WriteLine(ourHero.HP);
          //  Console.WriteLine(monster1.HP);



        }
    }
}
