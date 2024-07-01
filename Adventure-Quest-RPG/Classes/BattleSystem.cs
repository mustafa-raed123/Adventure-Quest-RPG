using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG_.Classes
{
    public class BattleSystem
    {
        bool isAttacker = true;
        int AttackingCount = 0;
        int DamageValue = 0;
        int Level = 1;

        private void StartBattleScreen()
        {
            Console.Clear();

            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\n\t\tStart Battle Screen\n");
            Console.WriteLine("\t\t----------------------------------------------");

        }
  
 
        public void StartBattle(Player Player, clsMonster Enemy)
        {
           // StartBattleScreen();

            while (Player.PlayerHealth > 0 && Enemy.MonstorHealth > 0)
            {
                if (isAttacker)
                {
                    Console.WriteLine("\n\t\tPlayer turn :\n");
                    if (!Attack(ref Player, ref Enemy))
                    {
                        Console.WriteLine("\n\t\t You Won");
                    };
                }
                else
                {
                    Console.WriteLine("\n\t\tEnemy turn :\n");

                    if (!Attack(ref Enemy, ref Player))
                    {
                        Console.WriteLine("\n\t\t you Lost ");
                    };
                }
            }
        }
        public bool Attack(ref Player Attacker, ref clsMonster Target)
        {
            Target.MonstorDefense = GetRandomlPowerOFDefense();
            int Power = GetRandomlyAttack();
            Attacker.PlayerAttackPower = Power;

            if (Target.MonstorDefense < Power)
            {               
                DamageValue += Power;
                Console.WriteLine($"\n\t\tPlayer Attack Power : + {Power}");
                Console.WriteLine($"\n\t\tDamage Value : - {Power}");
                if (Attacker.PlayerHealth < 100)
                {
                  Attacker.IncreaseHealth(Power);               
                }
                Console.WriteLine($"\n\t\tYour Level Up To {++Level} And Your Health Up to {Attacker.PlayerHealth}");
                Target.MonstorHealth = Target.MonstorHealth - Power;
                if (Target.MonstorHealth > 0)
                {
                    Console.WriteLine($"\n\t\tThe Helth Of Target :{Target.MonstorHealth}\n");             
                }
                else
                {
                    Target.MonstorHealth = 0;
                    isAttacker = false;
                    return false;
                }
            }
            else
            {
                
                Console.WriteLine($"\n\t\tThe target is defensed ");
                Console.WriteLine($"\n\t\t the Attacter power is {Attacker.PlayerAttackPower}");
                Console.WriteLine($"\n\t\t the Attackter power after defense is  {Attacker.PlayerAttackPower / 2 }");

                Target.MonstorHealth -= (Attacker.PlayerAttackPower / 2);

                Console.WriteLine($"\n\t\tThe Helth Of Target :{Target.MonstorHealth}");

                Console.WriteLine($"\n\t\tThe Helth Of the Player : {Attacker.PlayerHealth}");
                


            }
            isAttacker = false;


            return true;

        }
        public bool Attack(ref clsMonster Attacker, ref Player Target)
        {
            int Power = GetRandomlyAttack();

            Attacker.MonstorAttackPower = Power;
            Target.PlayerDefense = GetRandomlPowerOFDefense();

            if (Target.PlayerDefense < Power)
            {
                Power = GetRandomlyAttack();
                
                Console.WriteLine($"\n\t\tMonster Attack Power : + {Power}");
                Console.WriteLine($"\n\t\tDamage Value : - {Power}");
                Console.WriteLine($"\n\t\t The Monster Health :  {Attacker.MonstorHealth}");
                Target.PlayerHealth -= Power;

                if (Target.PlayerHealth > 0)
                {
                    Console.WriteLine($"\n\t\tThe Helth Of Target :{Target.PlayerHealth}\n");
                }
                else
                {
                    Target.PlayerHealth = 0;
                    isAttacker = true;
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"\n\t\tThe target is defensed");
                Console.WriteLine($"\n\t\t the Attackter power is {Attacker.MonstorAttackPower}");
                Console.WriteLine($"\n\t\t the Attacter power after defense is  {Attacker.MonstorAttackPower / 2}");

                Target.PlayerHealth -= Attacker.MonstorAttackPower / 2;

                Console.WriteLine($"\n\t\tThe Helth Of Target :{Target.PlayerHealth}");
                Console.WriteLine($"\n\t\tThe Helth Of the Monster : {Attacker.MonstorHealth}");
                          
            }
            isAttacker = true;
            return true;
        }
        public int GetRandomlyAttack()
        {
            Random random = new Random();
            int AttackValue;
            return AttackValue = (random.Next(11, 20));
        }
        public int GetRandomlPowerOFDefense()
        {
            Random random = new Random();

            int DefenseValue;

            return DefenseValue = (random.Next(10, 15));
        }

        
    }
}
