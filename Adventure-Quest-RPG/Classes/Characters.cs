using Adventure_Quest_RPG_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG_.Classes
{
    public class Characters
    {
        public string PlayerName { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerAttackPower { get; set; }

        public int PlayerDefense { get; set; }

        public Characters(string Name, int Health, int AttackPower, int Defense)

        {

            this.PlayerName = Name;
            this.PlayerHealth = Health;
            this.PlayerAttackPower = AttackPower;
            this.PlayerDefense = Defense;

        }
    }
        public class Player :Characters
        {


            public Player(string Name, int Health, int AttackPower, int Defense):
                base(Name, Health, AttackPower, Defense)

            {
   
            }

            public void IncreaseHealth(int Power)
            {
                PlayerHealth = PlayerHealth + (Power / 2);
                if (PlayerHealth > 100)
                {
                    PlayerHealth = 100;
                }

            }

        }
        public abstract class Monster
        {


            public string MonstorName { get; set; }
            public int MonstorHealth { get; set; }
            public int MonstorAttackPower { get; set; }

            public int MonstorDefense { get; set; }

            public bool isAtacker { get; set; }


            public Monster(string Name, int Health, int AttackPower, int Defense)

            {
                this.MonstorName = Name;
                this.MonstorHealth = Health;
                this.MonstorAttackPower = AttackPower;
                this.MonstorDefense = Defense;
                isAtacker = true;

            }





        }

    }
    public class clsMonster : Monster
{



        public clsMonster(string Name, int Health, int AttackPower, int Defense)
            : base(Name, Health, AttackPower, Defense)
        {

        }

    }

