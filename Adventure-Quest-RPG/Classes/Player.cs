using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG_.Classes
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerAttackPower { get; set; }

        public int PlayerDefense { get; set; }

        public Player(string Name, int Health, int AttackPower, int Defense)

        {

            this.PlayerName = Name;
            this.PlayerHealth = Health;
            this.PlayerAttackPower = AttackPower;
            this.PlayerDefense = Defense;

        }
      
        public void IncreaseHealth(int Power)
        {
            PlayerHealth = PlayerHealth + (Power/2);
            if (PlayerHealth > 100)
            {
                PlayerHealth = 100;
            }

        }

    }
}


