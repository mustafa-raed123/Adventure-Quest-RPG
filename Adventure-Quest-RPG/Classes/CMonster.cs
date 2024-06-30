using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG_.Classes
{

    public class clsMonster : Monster
    {



        public clsMonster(string Name, int Health, int AttackPower, int Defense)
            : base(Name, Health, AttackPower, Defense)
        {

        }

    }
}