using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG_.Classes
{
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