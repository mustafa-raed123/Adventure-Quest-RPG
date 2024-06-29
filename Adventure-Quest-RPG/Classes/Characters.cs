using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG_.Classes
{
    public class Characters
    {
          public string Name {  get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public int Defense { get; set; }


        public Characters(string Name , int Health, int AttackPower , int Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;
        }

    }
}
